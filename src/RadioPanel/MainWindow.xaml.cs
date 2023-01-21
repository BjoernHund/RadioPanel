using FsConnect.Managers;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace RadioPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _connected;
        private bool _com1Available;

        private readonly DispatcherTimer _connectTimer;

        private FsConnect.FsConnect _fsConnect;
        private RadioManager _radioManager;

        public RadioInformation RadioInformation { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                var left = Settings.Default.WindowLeft;
                var top = Settings.Default.WindowTop;

                if (top != 0 || left != 0)
                {
                    WindowStartupLocation = WindowStartupLocation.Manual;
                    Left = left;
                    Top = top;
                }
            }
            catch
            {
                MessageBox.Show("Unable to load settings file", "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            RadioInformation = new RadioInformation { Com1 = 122.800, Com1Stby = 133.500, Status = "Disconnected" };
            gridRadioPanel.DataContext = RadioInformation;

            _connectTimer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            _connectTimer.Tick += ConnectTimer_Tick;

            Start();
        }

        private void Start()
        {
            _connectTimer.Start();
        }

        private void Connect()
        {
            if (_connected)
            {
                _connectTimer.Stop();
                return;
            }

            _fsConnect = new FsConnect.FsConnect();
            _fsConnect.ConnectionChanged += FsConnect_ConnectionChanged;
            _fsConnect.Connect("RadioPanel");
            _radioManager = new RadioManager(_fsConnect);
            _radioManager.RadioUpdated += RadioManager_RadioUpdated;
            _radioManager.Start();
        }

        private void Disconnect()
        {
            if (_fsConnect.Connected)
            {
                _radioManager.Stop();
                _radioManager.Dispose();
                _fsConnect.Disconnect();
                _fsConnect.Dispose();
                _radioManager = null;
                _fsConnect = null;
            }
        }

        private void ConnectTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                Connect();
            }
            catch
            {
                _connected = false;
            }
        }

        private void FsConnect_ConnectionChanged(object sender, bool e)
        {
            _connected = e;
            RadioInformation.Status = _connected && _com1Available ? "Connected" : "Disconnected";
        }

        private void RadioManager_RadioUpdated(object sender, RadioUpdatedEventsArgs e)
        {
            _com1Available = e.Com1Available == 0;

            RadioInformation.Com1 = e.Com1ActiveFrequency;
            RadioInformation.Com1Stby = e.Com1StandbyFrequency;
            RadioInformation.Status = _connected && _com1Available ? "Connected" : "Disconnected";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                Settings.Default.WindowLeft = Left;
                Settings.Default.WindowTop = Top;
                Settings.Default.Save();
            }

            Disconnect();

            base.OnClosing(e);
        }

        private void ComSTBY_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var binding = txtComSTBY.GetBindingExpression(TextBox.TextProperty);

            if (e.Key == Key.Enter)
            {
                txtComSTBY.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                if (_fsConnect?.Connected == true)
                {
                    _radioManager?.SetCom1StandbyFrequency(RadioInformation.Com1Stby);
                }
                e.Handled = true;
            }
            else if (e.Key == Key.Escape)
            {
                binding.UpdateTarget();
                txtComSTBY.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                e.Handled = true;
            }
        }

        private void SelectText(object sender, RoutedEventArgs e)
        {
            txtComSTBY.Text = "0";
            txtComSTBY.SelectAll();
        }

        private void SelectivelyIgnoreMouseButton(object sender, MouseButtonEventArgs e)
        {
            if (!txtComSTBY.IsKeyboardFocusWithin)
            {
                e.Handled = true;
                txtComSTBY.Focus();
            }
        }

        private void Switch_Click(object sender, RoutedEventArgs e)
        {
            if (_fsConnect?.Connected == true)
            {
                _radioManager?.Com1Swap();
            }
        }

        private void RadioPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();
    }
}

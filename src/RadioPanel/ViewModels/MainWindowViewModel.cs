using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FsConnect.Managers;
using System;
using System.Windows.Threading;

namespace RadioPanel.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private bool _connected;
        private bool _com1Available;
        private readonly DispatcherTimer _connectTimer;

        private FsConnect.FsConnect _fsConnect;
        private RadioManager _radioManager;

        [ObservableProperty]
        private double com1 = 122.800;
        
        [ObservableProperty]
        private double com1Stby = 133.500;
        
        [ObservableProperty]
        private string status = "Disconnected";

        public MainWindowViewModel()
        {
            _connectTimer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            _connectTimer.Tick += ConnectTimer_Tick;

            this.Start();
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
            _fsConnect.ConnectionChanged += this.FsConnect_ConnectionChanged;
            _fsConnect.Connect("RadioPanel");

            _radioManager = new RadioManager(_fsConnect);
            _radioManager.RadioUpdated += this.RadioManager_RadioUpdated;
            _radioManager.Start();
        }

        public void Disconnect()
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
                this.Connect();
            }
            catch
            {
                _connected = false;
            }
        }

        private void FsConnect_ConnectionChanged(object sender, bool e)
        {
            _connected = e;
            this.Status = _connected && _com1Available ? "Connected" : "Disconnected";
        }

        private void RadioManager_RadioUpdated(object sender, RadioUpdatedEventsArgs e)
        {
            _com1Available = e.Com1Available == 0;

            this.Com1 = e.Com1ActiveFrequency;
            this.Com1Stby = e.Com1StandbyFrequency;
            this.Status = _connected && _com1Available ? "Connected" : "Disconnected";
        }

        [RelayCommand(CanExecute = nameof(CanSendCommands))]
        private void SetCom1StandbyFrequency()
        {
            _radioManager?.SetCom1StandbyFrequency(this.Com1Stby);
        }

        [RelayCommand(CanExecute = nameof(CanSendCommands))]
        private void SwapCom1Frequency()
        {
            _radioManager?.Com1Swap();
        }

        private bool CanSendCommands()
        {
            return _connected && _com1Available;
        }
    }
}

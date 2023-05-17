using Microsoft.Extensions.DependencyInjection;
using RadioPanel.ViewModels;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace RadioPanel.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = App.Current.Services.GetService<MainWindowViewModel>();

            try
            {
                double left = Settings.Default.WindowLeft;
                double top = Settings.Default.WindowTop;

                if (top != 0 || left != 0)
                {
                    this.WindowStartupLocation = WindowStartupLocation.Manual;
                    this.Left = left;
                    this.Top = top;
                }
            }
            catch
            {
                MessageBox.Show("Unable to load settings file", "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                Settings.Default.WindowLeft = Left;
                Settings.Default.WindowTop = Top;
                Settings.Default.Save();
            }

            MainWindowViewModel viewModel =  this.DataContext as MainWindowViewModel;
            viewModel.Disconnect();

            base.OnClosing(e);
        }

        private void RadioPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

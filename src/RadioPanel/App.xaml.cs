using System.Threading;
using System.Windows;

namespace RadioPanel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            const string mutextName = "RadioPanel";
            _ = new Mutex(true, mutextName, out var createdNew);
            if (!createdNew)
            {
                Current.Shutdown();
            }
        }
    }
}

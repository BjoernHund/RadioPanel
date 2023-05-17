using Microsoft.Extensions.DependencyInjection;
using RadioPanel.ViewModels;
using System;
using System.Threading;
using System.Windows;

namespace RadioPanel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Services = this.ConfigureServices();
        }

        public IServiceProvider Services { get; }

        public new static App Current => (App)Application.Current;

        protected override void OnStartup(StartupEventArgs e)
        {
            const string mutextName = "RadioPanel";
            _ = new Mutex(true, mutextName, out var createdNew);
            if (!createdNew)
            {
                Current.Shutdown();
            }
        }

        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<MainWindowViewModel>();
            
            return services.BuildServiceProvider();
        }
    }
}

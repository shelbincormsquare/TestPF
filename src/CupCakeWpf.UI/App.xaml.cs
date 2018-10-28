using Autofac;
using System.Windows;

namespace CupCakeWpf.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new StartUp.Bootstrapper();
            var container = bootstrapper.BootStrap();
            var mainWindow = container.Resolve<MainWindow>();
            MainWindow.Show();
        }
    }
}

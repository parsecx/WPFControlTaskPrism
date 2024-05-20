using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using WPFControlTaskPrism.Modules;
using WPFControlTaskPrism.ViewModels;
using WPFControlTaskPrism.Views;

namespace WPFControlTaskPrism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomeView,HomeViewViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<MainModule>();
        }
    }
}

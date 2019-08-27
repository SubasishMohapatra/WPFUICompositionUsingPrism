using EnglishModule;
using HelloWorldModule;
using ListingModule;
using MathsModule;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace WPFUIComposition
{
    //This is the main bootstrapper class
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(MathsModule.MathsModule));
            moduleCatalog.AddModule(typeof(EnglishModule.EnglishModule));
            moduleCatalog.AddModule(typeof(ListingModule.ListingModule));
        }

    }
}

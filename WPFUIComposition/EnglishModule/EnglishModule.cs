using EnglishModule.Views;
using Prism.Modularity;
using Prism.Regions;

namespace EnglishModule
{
    public class EnglishModule : IModule
    {
        private readonly IRegionManager regionManager;

        public EnglishModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            //Register all views here to be displayed
            regionManager.RegisterViewWithRegion("NavigationRegion", typeof(EnglishMenuItemView));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(EnglishContentView));
        }
    }
}

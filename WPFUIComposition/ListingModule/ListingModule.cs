using ListingModule.ViewModels;
using ListingModule.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingModule
{
    public class ListingModule:IModule
    {
        private readonly IRegionManager regionManager;

        public ListingModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            //Register all views
            regionManager.RegisterViewWithRegion("NavigationRegion", typeof(ListingMenuItemView));
            this.regionManager.RegisterViewWithRegion("ContentRegion", typeof(ListingContentView));
        }
    }
}

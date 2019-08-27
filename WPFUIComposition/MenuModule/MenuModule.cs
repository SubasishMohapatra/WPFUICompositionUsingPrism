using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuModule
{
    public class MenuModule : IModule
    {
        private readonly IRegionManager regionManager;

        public MenuModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MenuRegion", typeof(Menus));
        }
    }
}

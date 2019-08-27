using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavModule
{
    public class NavModule : IModule
    {
        private readonly IRegionManager regionManager;

        public NavModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("NavigationRegion", typeof(Navigation));
        }
    }
}

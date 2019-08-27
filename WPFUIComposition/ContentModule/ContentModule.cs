using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentModule
{
    public class ContentModule:IModule
    {
        private readonly IRegionManager regionManager;

        public ContentModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ContentView));
        }
    }
}

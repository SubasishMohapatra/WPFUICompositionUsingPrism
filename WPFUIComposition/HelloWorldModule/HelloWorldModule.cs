using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;

namespace HelloWorldModule
{
    //Hello Module
    public class HelloWorldModule : IModule
    {
        private readonly IRegionManager regionManager;

        public HelloWorldModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(HelloWorldView));
        }
    }
}

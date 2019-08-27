using ListingModule.Model;
using System.Collections.Generic;

namespace ListingModule.ViewModels
{
    internal class AKVOpenItemViewModel : IOpenItemViewModel
    {
        public AKVOpenItemViewModel()
        {
            
        }

        public string Header => "AKV Open Items";

        public IOpenItem OpenItems { get; set ; }

    }
}

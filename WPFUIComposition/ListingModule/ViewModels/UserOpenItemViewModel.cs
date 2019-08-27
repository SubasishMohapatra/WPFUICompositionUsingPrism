using ListingModule.Model;
using System.Collections.Generic;

namespace ListingModule.ViewModels
{
    internal class UserOpenItemViewModel : IOpenItemViewModel
    {
        public UserOpenItemViewModel()
        {
            
        }
        
        public string Header { get => "User Open Items"; }

        public IOpenItem OpenItems { get; set; }
    }
}

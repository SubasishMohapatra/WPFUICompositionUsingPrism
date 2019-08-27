using ListingModule.Model;
using System.Collections.Generic;

namespace ListingModule.ViewModels
{
    internal class UserOpenItems : IOpenItem
    {
        public UserOpenItems()
        {
            OpenItems = new List<UserOpenItem>();
        }
        public UserOpenItems(IEnumerable<UserOpenItem> openItems)
        {
            OpenItems = new List<UserOpenItem>(openItems);
        }
        public List<UserOpenItem> OpenItems { get; set; }
    }
}

using ListingModule.Model;
using System.Collections.Generic;
using System.Windows.Data;

namespace ListingModule.ViewModels
{
    internal class AKVOpenItems : IOpenItem
    {
        public AKVOpenItems()
        {
            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(new List<AKVOpenItem>());
            //PropertyGroupDescription groupDescription = new PropertyGroupDescription("AKVName");
            //view.GroupDescriptions.Add(groupDescription);
            //OpenItems = view;
        }
        public AKVOpenItems(IEnumerable<AKVOpenItem> openItems)
        {

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(openItems);
            view.GroupDescriptions.Add(new PropertyGroupDescription("AKVName"));
            view.GroupDescriptions.Add(new PropertyGroupDescription("FunctionName"));
            OpenItems = view;
        }

        //public List<AKVOpenItem> OpenItems { get; set; }
        public CollectionView  OpenItems { get; set; }
    }
}

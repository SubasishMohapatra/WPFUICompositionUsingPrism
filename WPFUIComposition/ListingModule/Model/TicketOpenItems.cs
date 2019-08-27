using ListingModule.Model;
using System.Collections.Generic;

namespace ListingModule.ViewModels
{
    internal class TicketOpenItems : IOpenItem
    {
        public TicketOpenItems()
        {
            OpenItems = new List<TicketOpenItem>();
        }

        public TicketOpenItems(IEnumerable<TicketOpenItem> openItems)
        {
            OpenItems = new List<TicketOpenItem>(openItems);
        }

        public List<TicketOpenItem> OpenItems { get; set; }
    }
}

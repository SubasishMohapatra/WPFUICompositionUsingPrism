using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingModule.Model
{
    class TicketOpenItem
    {
        public Guid ID { get; set; }
        public int TicketID { get; set; }
        public string Message { get; set; }
        public TicketStatus Status { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingModule.Model
{
    class UserOpenItem
    {
        public Guid ID { get; set; }
        public string Message { get; set; }
        public UserOpenItemTypeEnum OpenItemType { get; set; }
    }
}

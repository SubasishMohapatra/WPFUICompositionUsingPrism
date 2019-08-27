using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingModule.ViewModels
{
    public interface IOpenItemViewModel
    {
        string Header { get; }
        IOpenItem OpenItems{ get; set; }
    }
}

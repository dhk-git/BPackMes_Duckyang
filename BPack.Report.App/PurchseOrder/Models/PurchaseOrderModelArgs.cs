using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.PurchseOrder.Models
{
    public class PurchaseOrderModelArgs : ModelArgsBase
    {
        public List<string> Poh_No_List { get; set; }
    }
}

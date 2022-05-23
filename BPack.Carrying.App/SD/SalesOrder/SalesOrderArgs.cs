using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.SD.SalesOrder;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD
{
    public class SalesOrderArgs : ArgsBase
    {
        public SalesOrderModelArgs SalesOrderModelArgs { get; set; } = new SalesOrderModelArgs();
    }
}

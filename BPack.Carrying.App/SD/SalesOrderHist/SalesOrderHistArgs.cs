using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.SD.SalesOrderHist;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD
{
    public class SalesOrderHistArgs : ArgsBase
    {
        public SalesOrderHistModelArgs SalesOrderHistModelArgs { get; set; } = new SalesOrderHistModelArgs();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.InvoiceStatus;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class InvoiceStatusArgs : ArgsBase
    {
        public InvoiceStatusModelArgs InvoiceStatusModelArgs { get; set; } = new InvoiceStatusModelArgs();
    }
}

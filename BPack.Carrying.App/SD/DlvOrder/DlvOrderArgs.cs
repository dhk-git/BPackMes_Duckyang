using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.SD.DlvOrder;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD
{
    public class DlvOrderArgs : ArgsBase
    {
        public DlvOrderModelArgs DlvOrderModelArgs { get; set; } = new DlvOrderModelArgs();
    }
}

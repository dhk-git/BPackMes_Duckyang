using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.SD.DlvOrderHist;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD
{
    public class DlvOrderHistArgs : ArgsBase
    {
        public DlvOrderHistModelArgs DlvOrderHistModelArgs { get; set; } = new DlvOrderHistModelArgs();
    }
}

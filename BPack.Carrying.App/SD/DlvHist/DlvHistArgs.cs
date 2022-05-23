using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.SD.DlvHist;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD
{
    public class DlvHistArgs : ArgsBase
    {
        public DlvHistModelArgs DlvHistModelArgs { get; set; } = new DlvHistModelArgs();
    }
}

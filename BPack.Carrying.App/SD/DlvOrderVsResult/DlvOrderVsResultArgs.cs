using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.SD.DlvOrderVsResult;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD
{
    public class DlvOrderVsResultArgs : ArgsBase
    {
        public DlvOrderVsResultModelArgs DlvOrderVsResultModelArgs { get; set; } = new DlvOrderVsResultModelArgs();
    }
}

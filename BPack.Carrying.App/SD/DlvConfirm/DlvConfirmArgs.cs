using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.SD.DlvConfirm;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD
{
    public class DlvConfirmArgs : ArgsBase
    {
        public DlvConfirmModelArgs DlvConfirmModelArgs { get; set; } = new DlvConfirmModelArgs();
    }
}

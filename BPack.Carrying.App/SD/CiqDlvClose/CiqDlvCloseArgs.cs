using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.SD.CiqDlvClose;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD
{
    public class CiqDlvCloseArgs : ArgsBase
    {
        public CiqDlvCloseModelArgs CiqDlvCloseModelArgs { get; set; } = new CiqDlvCloseModelArgs();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.HumHuMaster;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class HumHuMasterArgs : ArgsBase
    {
        public HumHuMasterModelArgs HumHuMasterModelArgs { get; set; } = new HumHuMasterModelArgs();
    }
}

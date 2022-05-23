using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.NwtStatusInfo;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class NwtStatusInfoArgs : ArgsBase
    {
        public NwtStatusInfoModelArgs NwtStatusInfoModelArgs { get; set; } = new NwtStatusInfoModelArgs();
    }
}

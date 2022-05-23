using BPack.Model.App.MM.MovDoc;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MM.MovDoc
{
    public class MovDocArgs : ArgsBase
    {
        public MovDocModelArgs MovDocModelArgs { get; set; } = new MovDocModelArgs();
        public string Select_Extra_Plant_Cd { get; set; }
    }
}

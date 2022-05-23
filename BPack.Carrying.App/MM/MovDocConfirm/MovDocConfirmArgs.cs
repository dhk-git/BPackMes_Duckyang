using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.MovDocConfirm;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class MovDocConfirmArgs : ArgsBase
    {
        public MovDocConfirmModelArgs MovDocConfirmModelArgs { get; set; } = new MovDocConfirmModelArgs();
    }
}

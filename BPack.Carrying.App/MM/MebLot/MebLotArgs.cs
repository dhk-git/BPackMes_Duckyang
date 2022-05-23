using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.MebLot;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class MebLotArgs : ArgsBase
    {
        public MebLotModelArgs MebLotModelArgs { get; set; } = new MebLotModelArgs();
    }
}

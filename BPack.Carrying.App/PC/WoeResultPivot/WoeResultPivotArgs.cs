using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WoeResultPivot;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WoeResultPivotArgs : ArgsBase
    {
        public WoeResultPivotModelArgs WoeResultPivotModelArgs { get; set; } = new WoeResultPivotModelArgs();
    }
}

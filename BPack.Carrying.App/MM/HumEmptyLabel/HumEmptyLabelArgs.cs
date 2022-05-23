using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.HumEmptyLabel;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class HumEmptyLabelArgs : ArgsBase
    {
        public HumEmptyLabelModelArgs HumEmptyLabelModelArgs { get; set; } = new HumEmptyLabelModelArgs();
    }
}

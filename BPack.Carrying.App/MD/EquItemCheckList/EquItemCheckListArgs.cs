using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.EquItemCheckList;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class EquItemCheckListArgs : ArgsBase
    {
        public EquItemCheckListModelArgs EquItemCheckListModelArgs { get; set; } = new EquItemCheckListModelArgs();
    }
}

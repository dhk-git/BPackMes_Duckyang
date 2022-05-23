using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.QciChkList;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class QciChkListArgs : ArgsBase
    {
        public QciChkListModelArgs QciChkListModelArgs { get; set; } = new QciChkListModelArgs();
    }
}

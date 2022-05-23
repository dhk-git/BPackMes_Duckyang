using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.QciInspStd;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class QciInspStdArgs : ArgsBase
    {
        public QciInspStdModelArgs QciInspStdModelArgs { get; set; } = new QciInspStdModelArgs();
    }
}

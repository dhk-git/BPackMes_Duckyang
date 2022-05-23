using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.QciInspStd_dy;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class QciInspStd_dyArgs : ArgsBase
    {
        public QciInspStd_dyModelArgs QciInspStd_dyModelArgs { get; set; } = new QciInspStd_dyModelArgs();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.QciNcr;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class QciNcrArgs : ArgsBase
    {
        public QciNcrModelArgs QciNcrModelArgs { get; set; } = new QciNcrModelArgs();
    }
}

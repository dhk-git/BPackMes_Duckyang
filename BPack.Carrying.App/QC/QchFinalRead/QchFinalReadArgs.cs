using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.QchFinalRead;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class QchFinalReadArgs : ArgsBase
    {
        public QchFinalReadModelArgs QchFinalReadModelArgs { get; set; } = new QchFinalReadModelArgs();
    }
}

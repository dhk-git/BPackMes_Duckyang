using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.QchFmlRead;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class QchFmlReadArgs : ArgsBase
    {
        public QchFmlReadModelArgs QchFmlReadModelArgs { get; set; } = new QchFmlReadModelArgs();
    }
}

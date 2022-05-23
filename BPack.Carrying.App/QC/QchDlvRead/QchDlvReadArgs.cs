using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.QchDlvRead;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class QchDlvReadArgs : ArgsBase
    {
        public QchDlvReadModelArgs QchDlvReadModelArgs { get; set; } = new QchDlvReadModelArgs();
    }
}

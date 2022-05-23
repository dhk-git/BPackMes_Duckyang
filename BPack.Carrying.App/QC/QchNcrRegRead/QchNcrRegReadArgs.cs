using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.QchNcrRegRead;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class QchNcrRegReadArgs : ArgsBase
    {
        public QchNcrRegReadModelArgs QchNcrRegReadModelArgs { get; set; } = new QchNcrRegReadModelArgs();
    }
}

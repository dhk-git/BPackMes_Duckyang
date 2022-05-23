using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.QC.QchPatrolRead;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC
{
    public class QchPatrolReadArgs : ArgsBase
    {
        public QchPatrolReadModelArgs QchPatrolReadModelArgs { get; set; } = new QchPatrolReadModelArgs();
    }
}

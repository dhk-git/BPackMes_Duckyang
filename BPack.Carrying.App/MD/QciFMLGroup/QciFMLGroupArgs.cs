using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.QciFMLGroup;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class QciFMLGroupArgs : ArgsBase
    {
        public QciFMLGroupModelArgs QciFMLGroupModelArgs { get; set; } = new QciFMLGroupModelArgs();
    }
}

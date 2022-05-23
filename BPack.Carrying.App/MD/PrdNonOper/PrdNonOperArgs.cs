using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MD.PrdNonOper;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD
{
    public class PrdNonOperArgs : ArgsBase
    {
        public PrdNonOperModelArgs PrdNonOperModelArgs { get; set; } = new PrdNonOperModelArgs();
    }
}

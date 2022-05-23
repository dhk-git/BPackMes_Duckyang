using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdRouting
{
    public class PrdRoutingSelectedEventArgs : EventArgs
    {
        public List<BomDetailModel> SeletedBomDetailModels { get; set; }
    }
}

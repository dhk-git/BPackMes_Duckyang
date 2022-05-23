using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.WoeResultBatch;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class WoeResultBatchArgs : ArgsBase
    {
        public WoeResultBatchModelArgs WoeResultBatchModelArgs { get; set; } = new WoeResultBatchModelArgs();
        public WoeResultBatchBpModel WoeResultBatchBpModel { get; set; }
        public string SelectedHuList { get; set; }
        public decimal SelectedHuQty { get; set; }
        public decimal OperQty { get; set; }
    }
}

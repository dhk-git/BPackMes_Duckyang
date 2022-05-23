using BPack.Model.App.PC.WorkOrder;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC.WorkOrder
{
    public class WorkOrderArgs : ArgsBase
    {
        public WorkOrderModelArgs WorkOrderModelArgs { get; set; } = new WorkOrderModelArgs();
    }
}

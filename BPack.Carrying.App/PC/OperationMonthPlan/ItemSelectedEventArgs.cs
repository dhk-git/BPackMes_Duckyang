using BPack.CommonMes.Controls.ItemMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.PC.OperationMonthPlan
{
    public class ItemSelectedEventArgs : EventArgs
    {
        public string SelectedItemCode { get; set; }
        public ItemMasterModel SeletedItemMasterModel { get; set; }
    }
}

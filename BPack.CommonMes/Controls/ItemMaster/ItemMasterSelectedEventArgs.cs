using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Controls.ItemMaster
{
    public class ItemMasterSelectedEventArgs : EventArgs
    {
        public string SelectedItemCode { get; set; }
        public ItemMasterModel SeletedItemMasterModel { get; set; }
    }
}

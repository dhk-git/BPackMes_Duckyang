using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.PO.PurPack
{
    public class PurPackModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Item_Cd { get; set; }
        public string Select_Main_Item_Nm { get; set; }
        public string Select_Main_Item_Gr_1 { get; set; }
        public string Select_Main_Bp_Cd { get; set; }
        public string Select_Main_Invoice_Status { get; set; }
        public string Select_Invoice_No { get; set; }
        public string Select_Invoice_Status { get; set; }
        public string Select_Main_Invoice_No { get; set; }

        public string ExcelImport_BpCd { get; set; }
        public DateTime ExcelImport_InvoiceDt { get; set; }
        public DateTime ExcelImport_EtaDt { get; set; }
    }
}

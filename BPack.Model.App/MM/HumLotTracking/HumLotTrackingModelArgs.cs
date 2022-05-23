using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.HumLotTracking
{
    public class HumLotTrackingModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_CD { get; set; }
        public string Select_Main_Plant_CD { get; set; }
        public string Select_Main_Item_CD { get; set; }
        public string Select_Main_Hu_No { get; set; }
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }

        public string Select_Header_Hu_No { get; set; }
        public string Select_Main_Hu_Barcode { get; set; }
        public string Select_Main_Item_Type { get; set; }
        public string Select_Main_Body_No { get; set; }
        public string Select_Main_Alc_Cd { get; set; }
        public string Select_Main_Pbs_Seq { get; set; }

        public string Select_Main_Do_No { get; set; }       //납입카드번호
        public string Select_Main_Prcp_No { get; set; }     //가입고번호
        public string Select_Main_Checked_Semi { get; set; }    //반제품 체크
    }
}

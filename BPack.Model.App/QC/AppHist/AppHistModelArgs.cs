using BPack.Common.Model;
using System;

namespace BPack.Model.App.QC.AppHist
{
    public class AppHistModelArgs : ModelArgsBase
    {
        public string Select_Main_Opt { get; set; }
        public string Select_Main_User_Id { get; set; }
        public string Select_Main_Comp_Cd { get; set; }
        public string Select_Main_Plant_Cd { get; set; }
        public DateTime Select_Main_Req_Dt_From { get; set; }
        public DateTime Select_Main_Req_Dt_To { get; set; }
        public string Select_Main_Ref_No { get; set; }
        public string Select_Main_Insp_App_Status_List { get; set; }

        public string Select_Ref_No { get; set; }
        public string Select_Insp_No { get; set; }
        public string Select_File_Name { get; set; }
        public string Select_File_Name_In_Server { get; set; }
    }
}

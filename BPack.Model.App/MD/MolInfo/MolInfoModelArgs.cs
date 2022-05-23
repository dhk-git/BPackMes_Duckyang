using BPack.Common.Model;

namespace BPack.Model.App.MD.MolInfo
{
    public class MolInfoModelArgs : ModelArgsBase
    {
        public string Select_Main_Comp_Code { get; set; }
        public string Select_Main_Plant_Code { get; set; }
        public string Select_Main_Mold_Code { get; set; }
        public string Select_Main_Mold_Name { get; set; }
    }
}

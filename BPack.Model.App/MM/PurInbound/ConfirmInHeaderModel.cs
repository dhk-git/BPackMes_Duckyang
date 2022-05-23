using BPack.Common.Model;

namespace BPack.Model.App.MM.PurInbound
{
    public class ConfirmInHeaderModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string PIH_NO { get; set; }
        public string WH_CD { get; set; }
    }

}

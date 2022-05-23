using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.HumLocInfo;

namespace BPack.Pocket.App.MM.HumLocInfo
{
    public class HumLocInfoPocket : PocketBase
    {
        public HumLocInfoPocket()
        {
            InitPocket("HumLocInfo");
        }

        public List<HumLocInfoModel> SelectHumLocInfoModels(HumLocInfoModelArgs args)
        {
            return PocketQuery<HumLocInfoModel>("MM.HumLocInfo.HuList.Select", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Code,
                WH_CD = args.Select_Main_Ware_House,
                LOC_CD = args.Select_Main_Location,
                ITEM_CD = args.Select_Main_Item_Code,
                HU_NO = args.Select_Main_Hu_No
                //, FROM_IN_DTTM = args.Select_Main_End_Dt
            });
        }

        public void DeleteHumLocInfoModels(List<HumLocInfoModel> humLocInfoModels)
        {
            PocketExecute("MM.HumLocInfo.HuList.Delete", GetParameters_StrapDisableParam(humLocInfoModels));
        }
    }
}

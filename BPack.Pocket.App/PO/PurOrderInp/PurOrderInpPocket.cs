using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PO.PurOrderInp;

namespace BPack.Pocket.App.PO.PurOrderInp
{
    public class PurOrderInpPocket : PocketBase
    {
        public PurOrderInpPocket()
        {
            InitPocket("PurOrderInp");
        }

        public List<PurOrderInpModel> SelectPurOrderInpModels(PurOrderInpModelArgs args)
        {
            return PocketQuery<PurOrderInpModel>("PO.PurOrderInp.PurOrderInpList.Select", new {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt
            });
        }

        public List<PurInpDetailModel> SelectPurInpDetailModels(PurOrderInpModelArgs args)
        {
            return PocketQuery<PurInpDetailModel>("PO.PurOrderInp.PurInpDetailList.Select", new { 
                POH_DT = args.Select_Poh_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD =  args.Select_Item_Cd
            });
        }

    }
}

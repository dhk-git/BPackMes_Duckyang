using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.PurInboundHist;

namespace BPack.Pocket.App.MM.PurInboundHist
{
    public class PurInboundHistPocket : PocketBase
    {
        public PurInboundHistPocket()
        {
            InitPocket("PurInboundHist");
        }

        public List<PurInboundHistModel> SelectPurInboundHistModels(PurInboundHistModelArgs args)
        {
            return PocketQuery<PurInboundHistModel>("MM.Pur.PurInBoundHist.Select", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Cd,
                PIH_NO = args.select_Main_Pih_no
              , DO_NO = args.select_Main_Do_no
              , ITEM_CD = args.select_Main_Item_cd
              , START_DT = args.Select_Main_Start_Dt
              , END_DT  = args.Select_Main_End_Dt
            });
        }
    }
}

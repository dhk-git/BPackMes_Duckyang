using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.InpMatHist;

namespace BPack.Pocket.App.MM.InpMatHist
{
    public class InpMatHistPocket : PocketBase
    {
        public InpMatHistPocket()
        {
            InitPocket("InpMatHist");
        }

        public List<InpMatHistHeaderModel> SelectInpMatHistHeaderModels(InpMatHistModelArgs args)
        {
            return PocketQuery<InpMatHistHeaderModel>("MM.InpMatHist.InpMatHistHeader.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                BP_CD = args.Select_Main_Bp_Cd,
                BP_NM = args.Select_Main_Bp_Nm
            });
        }

        public List<InpMatHistDetailModel> SelectInpMatHistDetailModels(InpMatHistModelArgs args)
        {
            return PocketQuery<InpMatHistDetailModel>("MM.InpMatHist.InpMatHistDetail.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                ITEM_CD = args.Select_Item_Cd,
                BP_CD = args.Select_Bp_Cd
            });
        }

    }
}

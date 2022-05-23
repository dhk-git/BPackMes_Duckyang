using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.HumLotTracking;

namespace BPack.Pocket.App.MM.HumLotTracking
{
    public class HumLotTrackingPocket : PocketBase
    {
        public HumLotTrackingPocket()
        {
            InitPocket("HumLotTracking");
        }

        public List<HumHeaderReverseModel> SelectHumHeaderBackwardModels(HumLotTrackingModelArgs args)
        {
            return PocketQuery<HumHeaderReverseModel>("MM.HumLotTracking.HumHeaderReverseList.Select", new
            {

                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD,
                ITEM_CD = args.Select_Main_Item_CD,
                ITEM_TYPE = args.Select_Main_Item_Type,
                HU_NO = args.Select_Main_Hu_No,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                HU_BARCODE = args.Select_Main_Hu_Barcode,
                BODY_NO = args.Select_Main_Body_No,
                ALC_CD = args.Select_Main_Alc_Cd,
                PBS_SEQ = args.Select_Main_Pbs_Seq,
                CHECKED_SEMI = args.Select_Main_Checked_Semi
            });
        }

        public List<HumHeaderForwardModel> SelectHumHeaderForwardModels(HumLotTrackingModelArgs args)
        {
            return PocketQuery<HumHeaderForwardModel>("MM.HumLotTracking.HumHeaderForwardList.Select", new
            {

                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD,
                ITEM_CD = args.Select_Main_Item_CD,
                ITEM_TYPE = args.Select_Main_Item_Type,
                HU_NO = args.Select_Main_Hu_No,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                HU_BARCODE = args.Select_Main_Hu_Barcode,
                DO_NO = args.Select_Main_Do_No,
                PRCP_NO = args.Select_Main_Prcp_No,
                CHECKED_SEMI = args.Select_Main_Checked_Semi
            });
        }

        public List<HumDetailForwardModel> SelectHumDetailForwardModels(HumLotTrackingModelArgs args)
        {
            return PocketQuery<HumDetailForwardModel>("MM.HumLotTracking.HumDetailFowardList.Select", new
            {
                HU_NO = args.Select_Header_Hu_No
            });
        }

        public List<HumDetailReverseModel> SelectHumDetailReverseModels(HumLotTrackingModelArgs args)
        {
            return PocketQuery<HumDetailReverseModel>("MM.HumLotTracking.HumDetailReverseList.Select", new
            {
                HU_NO = args.Select_Header_Hu_No
            });
        }
    }
}

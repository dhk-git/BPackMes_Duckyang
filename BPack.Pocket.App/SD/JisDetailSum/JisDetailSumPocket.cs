using BPack.Common.Pocket;
using BPack.Model.App.SD.JisDetailSum;
using System.Collections.Generic;

namespace BPack.Pocket.App.SD.JisDetailSum
{
    public class JisDetailSumPocket : PocketBase
    {
        public JisDetailSumPocket()
        {
            InitPocket("JisDetailSum");
        }

        public List<JisDetailSumModel> SelectJisDetailSumModels(JisDetailSumModelArgs args)
        {
            return PocketQuery<JisDetailSumModel>("SD.JISDetail.Sum.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                DT_OPT = args.Select_Main_Dt_Opt,
                DT_FROM = args.Select_Main_Dt_From,
                DT_TO = args.Select_Main_Dt_To,
                DLV_PLC_CD = args.Select_Main_Dlv_Plc_Cd,
                ALC_TYPE = args.Select_Main_Alc_Type,
                ALC_CD = args.Select_Main_Alc_Cd,
                ITEM_TYPE = args.Select_Main_Item_Type,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1
            });
        }
    }
}

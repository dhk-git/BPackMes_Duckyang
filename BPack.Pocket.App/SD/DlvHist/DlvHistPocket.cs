using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.DlvHist;

namespace BPack.Pocket.App.SD.DlvHist
{
    public class DlvHistPocket : PocketBase
    {
        public DlvHistPocket()
        {
            InitPocket("DlvHist");
        }

        public List<DlvHistModel> SelectDlvHistModels(DlvHistModelArgs args)
        {
            return PocketQuery<DlvHistModel>("SD.DlvHist.DlvHistList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                REQ_CLS = args.Select_Main_Req_Cls,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1,
                ALC_CD = args.Select_Main_Alc_Cd,
                DLV_TYPE = args.Select_Main_Dlv_Type,
                DLV_PLC_CD = args.Select_Main_Dlv_Plc_Cd
            });
        }

        public List<DlvHistDetailModel> SelectDlvHistDetailModels(DlvHistModelArgs args)
        {
            return PocketQuery<DlvHistDetailModel>("SD.DlvHist.DlvHistDetailList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                REQ_CLS = args.Select_Main_Req_Cls,
                REQ_DT = args.Select_Req_Dt,
                DLV_DT = args.Select_Dlv_Dt,
                DLV_TYPE = args.Select_Dlv_Type,
                GATE_CD = args.Select_Gate_Cd,
                DLV_PLC_CD = args.Select_Dlv_Plc_Cd,
                ITEM_CD = args.Select_Item_Cd
            });
        }

        public List<DlvHistDetailJisModel> SelectDlvHistDetailJisModels(DlvHistModelArgs args)
        {
            return PocketQuery<DlvHistDetailJisModel>("SD.DlvHist.DlvHistDetailJisList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                GATE_CD = args.Select_Main_Gate_Cd,
                DLV_PLC_CD = args.Select_Main_Dlv_Plc_Cd,
                ITEM_CD = args.Select_Main_Item_Cd
            });
        }
    }
}

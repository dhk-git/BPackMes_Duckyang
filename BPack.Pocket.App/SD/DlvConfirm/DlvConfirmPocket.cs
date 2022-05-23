using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.DlvConfirm;

namespace BPack.Pocket.App.SD.DlvConfirm
{
    public class DlvConfirmPocket : PocketBase
    {
        public DlvConfirmPocket()
        {
            InitPocket("DlvConfirm");
        }

        public List<DlvConfirmHeaderModel> SelectDlvConfirmHeaderModels(DlvConfirmModelArgs args)
        {
            return PocketQuery<DlvConfirmHeaderModel>("SD.DlvConfirm.Header.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                DLV_PLC_CD = args.Select_Main_Dlv_Plc_Cd,
                DLV_TYPE = args.Select_Dlv_Type,
                REQ_DT_FROM = args.Select_Main_Req_Dt_From,
                REQ_DT_TO = args.Select_Main_Req_Dt_To,
                DLV_STATUS = args.Select_Main_Dlv_Status,
                CAR_NO = args.Select_Main_Car_No,
                DOH_NO = args.Select_Main_Doh_No
            });
        }
        public List<DlvConfirmDetailJISModel> SelectDlvConfirmDetailJISModels(DlvConfirmModelArgs args)
        {
            return PocketQuery<DlvConfirmDetailJISModel>("SD.DlvConfirm.Detail.Select", new
            {
                OPT = "2",
                DOH_NO = args.Select_Doh_No
            });
        }

        public List<DlvConfirmDetailJITModel> SelectDlvConfirmDetailJITModels(DlvConfirmModelArgs args)
        {
            return PocketQuery<DlvConfirmDetailJITModel>("SD.DlvConfirm.Detail.Select", new
            {
                OPT = "1",
                DOH_NO = args.Select_Doh_No
            });
        }

        public List<DlvConfirmDetailHUModel> SelectDlvConfirmDetailHUModels(DlvConfirmModelArgs args)
        {
            return PocketQuery<DlvConfirmDetailHUModel>("SD.DlvConfirm.Detail.HU.Select", new
            {
                DOD_NO = args.Select_Dod_No
            });
        }

        public List<DlvConfirmCardHeaderModel> SelectDlvConfirmCardHeaderModels(string Drt_No)
        {
            return PocketQuery<DlvConfirmCardHeaderModel>("SD.DlvConfirm.DlvCard.Select", new
            {
                OPT = "1",
                DRT_NO = Drt_No
            });
        }

        public List<DlvConfirmCardDetailModel> SelectDlvConfirmCardDetailModels(string Drt_No)
        {
            return PocketQuery<DlvConfirmCardDetailModel>("SD.DlvConfirm.DlvCard.Select", new
            {
                OPT = "2",
                DRT_NO = Drt_No
            });
        }
    }
}

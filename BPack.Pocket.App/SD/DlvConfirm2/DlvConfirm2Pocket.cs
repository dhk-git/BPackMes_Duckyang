using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.DlvConfirm2;

namespace BPack.Pocket.App.SD.DlvConfirm2
{
    public class DlvConfirm2Pocket : PocketBase
    {
        public DlvConfirm2Pocket()
        {
            InitPocket("DlvConfirm2");
        }

        public List<DlvResultModel> SelectDlvResultModels(DlvConfirm2ModelArgs args)
        {
            return PocketQuery<DlvResultModel>("SD.DlvConfirm2.DlvResultList.R", new { 
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                BP_CD = args.Select_Main_Bp_Cd
            });
        }

        public void SaveDlvResultModel(DlvResultModel dlvResultModel)
        {
            PocketExecute("SD.DlvConfirm2.DlvResultList.U", GetParameters_StrapDisableParam(dlvResultModel));
        }

        public List<DlvResultDetailModel> SelectDlvResultDetailModels(DlvConfirm2ModelArgs args)
        {
            return PocketQuery<DlvResultDetailModel>("SD.DlvConfirm2.DlvResultDetailList.R", new
            {
                DRH_NO = args.Select_Drh_No,
                DOH_NO = args.Select_Doh_No
            });
        }
        public List<DlvResultHuModel> SelectDlvResultHuModels(DlvConfirm2ModelArgs args)
        {
            return PocketQuery<DlvResultHuModel>("SD.DlvConfirm2.DlvResultHuList.R", new
            {
                DRH_NO = args.Select_Drh_No,
                DRD_NO = args.Select_Drd_No
            });
        }

        public void BpDlvConfirm(DlvConfirm2ModelArgs args)
        {
            PocketExecute("SD.DlvConfirm2.DlvConfirm.BP", new {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                DRH_NO = args.Select_Drh_No
            });
        }

        public List<DlvResultLpackModel> SelectDlvResultLpackModel(DlvConfirm2ModelArgs args)
        {
            return PocketQuery<DlvResultLpackModel>("SD.DlvConfirm2.DlvResultLpack.R", new
            {
                DRH_NO = args.Select_Drh_No
            });
        }

        public List<DlvResultMpackModel> SelectDlvResultMpackModel(DlvConfirm2ModelArgs args)
        {
            return PocketQuery<DlvResultMpackModel>("SD.DlvConfirm2.DlvResultMpack.R", new
            {
                DRH_NO = args.Select_Drh_No
            });
        }

        public List<DlvPopOrdModel> SelectDlvPopOrdModel(DlvConfirm2ModelArgs args)
        {
            return PocketQuery<DlvPopOrdModel>("SD.DlvConfirm2.DlvPopOrd.R", new
            {
                DRH_NO = args.Select_Drh_No
            });
        }
        public List<DlvPopOrdDetailModel> SelectDlvPopOrdDetailModel(DlvConfirm2ModelArgs args)
        {
            return PocketQuery<DlvPopOrdDetailModel>("SD.DlvConfirm2.DlvPopOrdDetail.R", new
            {
                DRH_NO = args.Select_Drh_No
            });
        }
        public List<DlvPopOrdDetailLpackModel> SelectDlvPopOrdDetailLpackModel(DlvConfirm2ModelArgs args)
        {
            return PocketQuery<DlvPopOrdDetailLpackModel>("SD.DlvConfirm2.DlvPopOrdDetailLpack.R", new
            {
                DRH_NO = args.Select_Drh_No,
                DOH_NO=args.Select_Doh_No,
                ITEM_CD=args.Select_Item_cd
            });
        }
        public List<DlvPopOrdDetailMpackModel> SelectDlvPopOrdDetailMpackModel(DlvConfirm2ModelArgs args)
        {
            return PocketQuery<DlvPopOrdDetailMpackModel>("SD.DlvConfirm2.DlvPopOrdDetailMpack.R", new
            {
                DRH_NO = args.Select_Drh_No,
                DOH_NO = args.Select_Doh_No,
                ITEM_CD = args.Select_Item_cd,
                PACK_DATE= args.Select_Pack_Date,
                SHIP_DATE=args.Select_Ship_Date
            });
        }



    }
}

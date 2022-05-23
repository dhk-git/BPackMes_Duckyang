using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.GirInv;

namespace BPack.Pocket.App.MM.GirInv
{
    public class GirInvPocket : PocketBase
    {
        public GirInvPocket()
        {
            InitPocket("GirInv");
        }

        public List<InvModel> SelectInvModels(GirInvModelArgs args)
        {
            return PocketQuery<InvModel>("MM.GirInv.InvList.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                WH_CD = args.Select_Main_Wh_Cd
            });
        }
        public List<InvDetailModel> SelectInvDetailModels(GirInvModelArgs args)
        {
            return PocketQuery<InvDetailModel>("MM.GirInv.InvDetailList.Select", new
            {
                INV_NO = args.Select_Inv_No,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1
            });
        }

        public List<StockModel> SelectStockModels(GirInvModelArgs args)
        {
            return PocketQuery<StockModel>("MM.GirInv.StockList.Select", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                WH_CD = args.Select_Wh_Cd,
                INV_NO = args.Select_Inv_No,
                INV_GIR_DT = args.Select_Inv_Gir_Dt,
                IS_INCLUDE_AFTER_GIR = args.Select_Is_Include_After_Gir
            });
        }

        public void SaveInvModel(InvModel invModel)
        {
            var rst = PocketQuery<InvModel>("MM.GirInv.InvList.Save", GetParameters_StrapDisableParam(invModel)).SingleOrDefault();
            if (invModel.RowState == Common.Model.RowState.Added)
            {
                invModel.INV_NO = rst.INV_NO;
            }
        }

        public void SaveInvDetailModels(List<InvDetailModel> invDetailModels)
        {
            PocketExecute("MM.GirInv.InvDetailList.Save", GetParameters_StrapDisableParam(invDetailModels));
        }

        public void BpAdjustInv(GirInvModelArgs args)
        {
            PocketExecute("MM.GirInv.InvAdjust.BP", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                WH_CD = args.Select_Wh_Cd,
                INV_NO = args.Select_Inv_No,
                INV_GIR_DT = args.Select_Inv_Gir_Dt,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
            });
        }

        public void BpOpenInv(GirInvModelArgs args)
        {
            PocketExecute("MM.GirInv.OpenInv.BP", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                WH_CD = args.Select_Wh_Cd,
                IS_INCLUDE_AFTER_GIR = args.Select_Is_Include_After_Gir,
                INV_NO = args.Select_Inv_No,
                INV_GIR_DT = args.Select_Inv_Gir_Dt,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
            });
        }

        public void BpOpenCancelInv(GirInvModelArgs args)
        {
            PocketExecute("MM.GirInv.OpenCancelInv.BP", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                WH_CD = args.Select_Wh_Cd,
                IS_INCLUDE_AFTER_GIR = args.Select_Is_Include_After_Gir,
                INV_NO = args.Select_Inv_No,
                INV_GIR_DT = args.Select_Inv_Gir_Dt,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
            });
        }

        public DateTime GetLastCloseDt(GirInvModelArgs girInvModelArgs)
        {
            var rst = PocketQuery<dynamic>("MM.GirInv.GetLastCloseDt", new { 
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode
            }).SingleOrDefault();
            return (DateTime)rst.CLOSE_DT;
        }
    }
}

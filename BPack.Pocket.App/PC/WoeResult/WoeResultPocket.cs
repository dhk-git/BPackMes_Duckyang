using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeResult;

namespace BPack.Pocket.App.PC.WoeResult
{
    public class WoeResultPocket : PocketBase
    {
        public WoeResultPocket()
        {
            InitPocket("WoeResult");
        }

        public void BpAddWoeHuModel(WoeAddHuBpModel woeAddHuBpModel)
        {
            PocketExecute("PC.WoeResult.Hu.BP", woeAddHuBpModel);
        }

        public void BpAddWoeParentHuByAll(WoeAddParentHuBpModel woeAddParentHuBpModel)
        {
            PocketExecute("PC.WoeResult.ParentHu.All.BP", woeAddParentHuBpModel);
        }

        public void BpAddWoeParentHuByDivideOkNg(WoeAddParentHuBpModel woeAddParentHuBpModel)
        {
            PocketExecute("PC.WoeResult.ParentHu.DivideOkNg.BP", woeAddParentHuBpModel);
        }

        public void BpAutoInsertMaterial(WoeResultModelArgs args)
        {
            PocketExecute("PC.WoeResult.OrderMaterial.AutoInsert.BP", new
            {
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD = args.Select_Mat_Wh_Cd,
                LOC_CD = args.Select_Mat_Loc_Cd,
                WO_NO = args.Select_Wo_No,
                ROUTE_NO = args.Select_Route_No,
                OPER = args.Select_Oper
            });
        }

        public void BpCloseWorkResult(WoeWorkResultCloseModel woeWorkResultCloseModel)
        {
            PocketExecute("PC.WoeResult.WorkResult.Close.BP", GetParameters_StrapDisableParam(woeWorkResultCloseModel));
        }

        public void BpManualInsertMaterial(WoeResultModelArgs args)
        {
            Common.Config.SystemConfig.RefreshServerDateTime();
            PocketExecute("PC.WoeResult.OrderMaterial.ManualInsert.BP", new
            {
                CREATE_DTTM = Common.Config.SystemConfig.ServerDateTime,
                MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WH_CD = args.Select_Mat_Wh_Cd,
                LOC_CD = args.Select_Mat_Loc_Cd,
                WO_NO = args.Select_Wo_No,
                ROUTE_NO = args.Select_Route_No,
                OPER = args.Select_Oper,
                HU_NO = args.Scaned_Hu_No
            });
        }

        public void SaveWoeHuModel(WoeHuModel woeHuModel)
        {
            PocketExecute("PC.WoeResult.Hu.Save", GetParameters_StrapDisableParam(woeHuModel));
        }

        public void SaveWoeOrderMaterialModel(WoeOrderMaterialModel woeOrderMaterialModel)
        {
            PocketExecute("PC.WoeResult.OrderMaterial.Save", GetParameters_StrapDisableParam(woeOrderMaterialModel));
        }

        public void SaveWoeParentHuModel(WoeParentHuModel woeParentHuModel)
        {
            PocketExecute("PC.WoeResult.ParentHu.Save", GetParameters_StrapDisableParam(woeParentHuModel));
        }

        public void SaveWoeUsedMaterialModel(WoeUsedMaterialModel woeUsedMaterialModel)
        {
            PocketExecute("PC.WoeResult.UsedMaterial.Save", GetParameters_StrapDisableParam(woeUsedMaterialModel));
        }

        public void SaveWoeWorkResultModel(WoeWorkResultModel woeWorkResultModel)
        {
            PocketExecute("PC.WoeResult.WorkResult.Save", GetParameters_StrapDisableParam(woeWorkResultModel));
        }

        public List<WoeHuModel> SelectWoeHuModels(WoeResultModelArgs args)
        {
            return PocketQuery<WoeHuModel>("PC.WoeResult.Hu.Select", new
            {
                RST_NO = args.Select_Rst_No
            });
        }

        public List<WoeOrderMaterialModel> SelectWoeOrderMaterialModels(WoeResultModelArgs args)
        {
            return PocketQuery<WoeOrderMaterialModel>("PC.WoeResult.OrderMaterial.Select", new
            {
                WO_NO = args.Select_Wo_No,
                OPER = args.Select_Oper
            });
        }

        public List<WoeParentHuModel> SelectWoeParentHuModels(WoeResultModelArgs args)
        {
            return PocketQuery<WoeParentHuModel>("PC.WoeResult.ParentHu.Select", new
            {
                RST_NO = args.Select_Rst_No
            });
        }

        public List<WoeUsedMaterialModel> SelectWoeUsedMaterialModels(WoeResultModelArgs args)
        {
            return PocketQuery<WoeUsedMaterialModel>("PC.WoeResult.UsedMaterial.R", new
            {
                RST_NO = args.Select_Rst_No,
                HU_NO = args.Select_Hu_No
            });
        }

        public List<WoeWorkOrderModel> SelectWoeWorkOrderModels(WoeResultModelArgs args)
        {
            return PocketQuery<WoeWorkOrderModel>("PC.WoeResult.WorkOrder.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WC_CD = args.Select_Main_Wc_Cd,
                WOD_STATUS = args.Select_Main_Wod_Status
            });
        }

        public List<WoeWorkResultModel> SelectWoeWorkResultModels(WoeResultModelArgs args)
        {
            return PocketQuery<WoeWorkResultModel>("PC.WoeResult.WorkResult.Select", new
            {
                WO_NO = args.Select_Wo_No,
                OPER = args.Select_Oper
            });
        }
    }
}

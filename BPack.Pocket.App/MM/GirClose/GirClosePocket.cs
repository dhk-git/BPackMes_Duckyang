using System;
using System.Collections.Generic;
using BPack.Common.Pocket;
using BPack.Model.App.MM.GirClose;

namespace BPack.Pocket.App.MM.GirClose
{
    public class GirClosePocket : PocketBase
    {
        public GirClosePocket()
        {
            InitPocket("GirClose");
        }

        public void BpCloseGir(CloseDateModel closeDateModel)
        {
            //Common.Config.SystemConfig.RefreshServerDateTime();
            //closeDateModel.CREATE_DTTM = Common.Config.SystemConfig.ServerDateTime;
            //closeDateModel.MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime;
            closeDateModel.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
            closeDateModel.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
            closeDateModel.GIR_CLOSE_STATUS = "S002";
            PocketExecute("MM.GirClose.CloseGir.BP", GetParameters_StrapDisableParam(closeDateModel));
        }

        public void BpCloseGir_Batch(CloseDateModel closeDateModel)
        {
            PocketExecute("MM.GirClose.CloseGir.BP.Batch", new { 
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                CLOSE_DT = closeDateModel.CLOSE_DT,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
            });
        }


        public void BpCloseGirCancel(CloseDateModel closeDateModel)
        {
            //Common.Config.SystemConfig.RefreshServerDateTime();
            //closeDateModel.CREATE_DTTM = Common.Config.SystemConfig.ServerDateTime;
            //closeDateModel.MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime;
            closeDateModel.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
            closeDateModel.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
            PocketExecute("MM.GirClose.CloseGirCancel.BP", GetParameters_StrapDisableParam(closeDateModel));
        }

        public List<CloseDateModel> SelectCloseDateModels(GirCloseModelArgs args)
        {
            return PocketQuery<CloseDateModel>("MM.GirClose.CloseDate.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd
            });
        }
        
        public List<CloseLocModel> SelectCloseLocModels(GirCloseModelArgs args)
        {
            return PocketQuery<CloseLocModel>("MM.GirClose.CloseLoc.Select", new
            {
                CLOSE_DT = args.Select_Close_Dt,
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd
            });
        }

        public List<CloseWhModel> SelectCloseWhModels(GirCloseModelArgs args)
        {
            return PocketQuery<CloseWhModel>("MM.GirClose.CloseWh.Select", new
            {
                CLOSE_DT = args.Select_Close_Dt,
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd
            });
        }

        public List<CloseGirTypeModel> SelectCloseGirTypeModels(GirCloseModelArgs args)
        {
            return PocketQuery<CloseGirTypeModel>("MM.GirClose.CloseGirType.Select", new
            {
                CLOSE_DT = args.Select_Close_Dt,
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.SomDevice;

namespace BPack.Pocket.App.MD.SomDevice
{
    public class SomDevicePocket : PocketBase
    {
        public SomDevicePocket()
        {
            InitPocket("SomDevice");
        }

        public void SaveDeviceModel(DeviceModel deviceModel)
        {
            PocketExecute("MD.SomDevice.DeviceList.Save", GetParameters_StrapDisableParam(deviceModel));
        }

        public void SaveDeviceModels(List<DeviceModel> deviceModels)
        {
            PocketExecute("MD.SomDevice.DeviceList.Save", GetParameters_StrapDisableParam(deviceModels));
        }

        public void SaveModeModel(ModeModel modeModel)
        {
            PocketExecute("MD.SomDevice.ModeList.Save", GetParameters_StrapDisableParam(modeModel));
        }

        public void SaveModeModels(List<ModeModel> modeModels)
        {
            PocketExecute("MD.SomDevice.ModeList.Save", GetParameters_StrapDisableParam(modeModels));
        }

        public void SaveSettingModels(List<SettingModel> settingModels)
        {
            PocketExecute("MD.SomDevice.SettingList.Save", GetParameters_StrapDisableParam(settingModels));
        }

        public void SavePlcInfoModels(List<PlcInfoModel> plcInfoModels)
        {
            PocketExecute("MD.SomDevice.PlcInfoList.Save", GetParameters_StrapDisableParam(plcInfoModels));
        }

        public List<DeviceModel> SelectDeviceModels(SomDeviceModelArgs args)
        {
            return PocketQuery<DeviceModel>("MD.SomDevice.DeviceList.Select", new {
                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD
            });
        }

        public List<ModeModel> SelectModeModels(SomDeviceModelArgs args)
        {
            return PocketQuery<ModeModel>("MD.SomDevice.ModeList.Select", new
            {
                DVC_ID = args.Select_Dvc_ID
            });
        }

        public List<SettingModel> SelectSettingModels(SomDeviceModelArgs args)
        {
            return PocketQuery<SettingModel>("MD.SomDevice.SettingList.Select", new
            {
                DVC_ID = args.Select_Dvc_ID,
                MODE_ID = args.Select_Mode_ID
            });
        }

        public List<PlcInfoModel> SelectPlcInfoModels(SomDeviceModelArgs args)
        {
            return PocketQuery<PlcInfoModel>("MD.SomDevice.PlcInfoList.Select", new
            {
                DVC_ID = args.Select_Dvc_ID
            });
        }

        public void SyncSettingData(SomDeviceModelArgs args)
        {
            Common.Config.SystemConfig.RefreshServerDateTime();
            var currentTime = Common.Config.SystemConfig.ServerDateTime;
            PocketExecute("MD.SomDevice.SyncSetting.BP", new {
                DVC_ID = args.Select_Dvc_ID,
                MODE_ID = args.Select_Mode_ID, 
                CREATE_DTTM = currentTime,
                MODIFY_DTTM = currentTime,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
            });
        }
    }
}

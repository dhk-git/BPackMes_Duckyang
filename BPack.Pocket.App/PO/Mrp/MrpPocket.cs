using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PO.Mrp;

namespace BPack.Pocket.App.PO.Mrp
{
    public class MrpPocket : PocketBase
    {
        public MrpPocket()
        {
            InitPocket("Mrp");
        }

        public List<MrphModel> SelectMrphModels(MrpModelArgs args)
        {
            return PocketQuery<MrphModel>("PO.Mrp.MrpHeader.Select", new
            {
                MRH_NO = args.Select_Main_Mrh_No
            });
        }
        public List<MrpmModel> SelectMrpmModels(MrpModelArgs args)
        {
            return PocketQuery<MrpmModel>("PO.Mrp.MrpMasterInfo.Select", new
            {
                MRH_NO = args.Select_Mrh_No
            });
        }
        
        public List<MrpdModel> SelectMrpdModels(MrpModelArgs args)
        {
            return PocketQuery<MrpdModel>("PO.Mrp.MrpDetail.Select", new
            {
                MRH_NO = args.Select_Mrh_No
            });
        }

        public List<PorModel> SelectPorModels(MrpModelArgs args)
        {
            return PocketQuery<PorModel>("PO.Mrp.PorList.Select", new { 
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt
            });
        }

        public void SavePorModel(PorModel porModel)
        {
            var rst = PocketQuery<PorModel>("PO.Mrp.PorList.Save", GetParameters_StrapDisableParam(porModel)).SingleOrDefault();
            if (porModel.RowState == Common.Model.RowState.Added)
            {
                porModel.POR_NO = rst.POR_NO;
            }
        }

        public List<PorDetailModel> SelectPorDetailModels(MrpModelArgs args)
        {
            return PocketQuery<PorDetailModel>("PO.Mrp.PorDetailList.Select", new
            {
                POR_NO = args.Select_Por_No
            });
        }

        public void SavePorDetailModels(List<PorDetailModel> porDetailModels)
        {
            PocketExecute("PO.Mrp.PorDetailList.Save", GetParameters_StrapDisableParam(porDetailModels));
        }

        public void BpRunMrp(MrpModelArgs args)
        {
            PocketExecute("PO.Mrp.RunMrp.BP", new {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
            });
        }

        public void BpConfirmOrCancelPor(MrpModelArgs args)
        {
            PocketExecute("PO.Mrp.ConfirmOrCancelPor.BP", new {
                POR_NO = args.Select_Por_No,
                POR_STATUS = args.Select_New_Por_Status,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
            });
        }

        public List<PacPopupModel> SelectPacPopupModels(MrpModelArgs args)
        {
            return PocketQuery<PacPopupModel>("PO.Mrp.PacPopupList.Select", new { 
                YYYY_WK = args.Select_Popup_YYYY_WK,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Selett_Popup_Item_Cd
            });
        }
        public List<PoPopupModel> SelectPoPopupModels(MrpModelArgs args)
        {
            return PocketQuery<PoPopupModel>("PO.Mrp.PoPopupList.Select", new
            {
                YYYY_WK = args.Select_Popup_YYYY_WK,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Selett_Popup_Item_Cd
            });
        }

        public List<PoePopupModel> SelectPoePopupModels(MrpModelArgs args)
        {
            return PocketQuery<PoePopupModel>("PO.Mrp.PoePopupList.Select", new
            {
                YYYY_WK = args.Select_Popup_YYYY_WK,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Selett_Popup_Item_Cd
            });
        }

        public void SendMail(string emailList, string subject, string body, string bodyFormat)
        {
            PocketExecute("PO.Mrp.SendMail", new { 
                EMAIL_LIST = emailList,
                SUBJECT = subject,
                BODY = body,
                BODY_FORMAT = bodyFormat,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID
            });
        }
    }
}

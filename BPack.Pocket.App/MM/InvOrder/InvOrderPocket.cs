using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.InvOrder;

namespace BPack.Pocket.App.MM.InvOrder
{
    public class InvOrderPocket : PocketBase
    {
        public InvOrderPocket()
        {
            InitPocket("InvOrder");
        }

        public List<InvOrderModel> SelectInvOrderModels(InvOrderModelArgs args)
        {
            return PocketQuery<InvOrderModel>("MM.InvOrder.InvOrderList.Select", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                TARGET_INV_GR = args.Select_Main_Target_Inv_Gr
            });
        }

        public void SaveInvOrderModel(InvOrderModel invOrderModel)
        {
            try
            {
                PocketExecute("MM.InvOrder.InvOrderList.Save", GetParameters_StrapDisableParam(invOrderModel));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message); //todo : ExceptioProcess로 변경할 것
            }
            
        }

        public List<InvDetailModel> SelectInvDetailModels(InvOrderModelArgs args)
        {
            return PocketQuery<InvDetailModel>("MM.InvOrder.InvDetailList.Select", new
            {
                INV_NO = args.Select_Inv_No
            });
        }

        public void SaveInvDetailModel(InvDetailModel invDetailModel)
        {
            PocketExecute("MM.InvOrder.InvDetailList.Save", GetParameters_StrapDisableParam(invDetailModel));
        }

        public List<InvItemModel> SelectInvItemModels(InvOrderModelArgs args)
        {
            return PocketQuery<InvItemModel>("MM.InvOrder.InvItemList.Select", new
            {
                INVD_NO = args.Select_Invd_No
            });
        }

        public void SaveInvItemModel(InvItemModel invItemModel)
        {
            PocketExecute("MM.InvOrder.InvItemList.Save", GetParameters_StrapDisableParam(invItemModel));
        }

        public List<InvHuModel> SelectInvHuModels(InvOrderModelArgs args)
        {
            return PocketQuery<InvHuModel>("MM.InvOrder.InvHuList.Select", new
            {
                INVD_NO = args.Select_Invd_No,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Cd,
                ITEM_CD = args.Select_Item_Cd
            });
        }

        public void SaveInvHuModel(InvHuModel invHuModel)
        {
            PocketExecute("MM.InvOrder.InvHuList.Save", GetParameters_StrapDisableParam(invHuModel));
        }

        public void DropInvOrderModel(string invOrderNo)
        {
            Common.Config.SystemConfig.RefreshServerDateTime();
            PocketExecute("MM.InvOrder.DropInvOrder.BP", new 
            { 
                INV_NO = invOrderNo, 
                MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
            });
        }

        public void OpenInvOrderModel(string invOrderNo)
        {
            Common.Config.SystemConfig.RefreshServerDateTime();
            PocketExecute("MM.InvOrder.OpenInvOrder.BP", new
            {
                INV_NO = invOrderNo,
                MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
            });
        }
    }
}

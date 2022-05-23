using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.DlvOrder;

namespace BPack.Pocket.App.SD.DlvOrder
{
    public class DlvOrderPocket : PocketBase
    {
        public DlvOrderPocket()
        {
            InitPocket("DlvOrder");
        }

        public List<DlvPlanModel> SelectDlvPlanModels(DlvOrderModelArgs args)
        {
            return PocketQuery<DlvPlanModel>("SD.DlvOrder.PlanList.Select", new
            {
                START_DT = args.Select_Main_Plan_Start_Dt,
                END_DT = args.Select_Main_Plan_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1
            });
        }
        public List<DlvOrderModel> SelectDlvOrderModels(DlvOrderModelArgs args)
        {
            return PocketQuery<DlvOrderModel>("SD.DlvOrder.DlvOrder.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt
            });
        }

        public List<DlvOrderDetailModel> SelectDlvOrderDetailModels(DlvOrderModelArgs args)
        {
            return PocketQuery<DlvOrderDetailModel>("SD.DlvOrder.DlvOrderDetail.Select", new
            {
                DOH_NO = args.Select_Doh_No
            });
        }

        public void SaveDlvOrderModel(DlvOrderModel dlvOrderModel)
        {
            //PocketExecute("SD.DlvOrder.DlvOrder.Save", GetParameters_StrapDisableParam(dlvOrderModel));
            var rst = PocketQuery<DlvOrderModel>("SD.DlvOrder.DlvOrder.Save", GetParameters_StrapDisableParam(dlvOrderModel)).SingleOrDefault();
            if (dlvOrderModel.RowState == Common.Model.RowState.Added) dlvOrderModel.DOH_NO = rst?.DOH_NO;
        }

        public void SaveDlvOrderDetailModels(List<DlvOrderDetailModel> dlvOrderDetailModels)
        {
            PocketExecute("SD.DlvOrder.DlvOrderDetail.Save", GetParameters_StrapDisableParam(dlvOrderDetailModels));
        }

        public void BpConfirmDlvOrderModel(DlvOrderModel dlvOrderModel)
        {
            PocketExecute("SD.DlvOrder.ConfirmDlvOrder.BP", GetParameters_StrapDisableParam(dlvOrderModel));
        }

        public void BpCancelConfirmDlvOrderModel(DlvOrderModel dlvOrderModel)
        {
            PocketExecute("SD.DlvOrder.ConfirmDlvOrder.BP", GetParameters_StrapDisableParam(dlvOrderModel));
        }

        public List<ToReserveHuModel> SelectToReserveHuModels(DlvOrderModelArgs args)
        {
            return PocketQuery<ToReserveHuModel>("SD.DlvOrder.ToReserveHuList.Select", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Select_Item_Cd,
                DOH_NO = args.Select_Doh_No
            });
        }

        public List<ReservedHuModel> SelectReservedHuModels(DlvOrderModelArgs args)
        {
            return PocketQuery<ReservedHuModel>("SD.DlvOrder.ReservedHuList.Select", new
            {
                DOD_NO = args.Select_Dod_No
            });
        }

        public void SaveReservedHuModels(List<SaveReservedHuModel> saveReservedHuModels)
        {
            PocketExecute("SD.DlvOrder.ReservedHuList.Save", saveReservedHuModels);
        }

        public List<CheckItemAndHuQtyResultModel> CheckItemAndHuQty(DlvOrderModelArgs args)
        {
            return PocketQuery<CheckItemAndHuQtyResultModel>("SD.DlvOrder.CheckItemAndHuQty.Select", new { 
                DOH_NO = args.Select_Doh_No
            });
        }
    }
}

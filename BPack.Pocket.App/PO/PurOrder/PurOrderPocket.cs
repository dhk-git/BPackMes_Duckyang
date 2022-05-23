using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PO.PurOrder;

namespace BPack.Pocket.App.PO.PurOrder
{
    public class PurOrderPocket : PocketBase
    {
        public PurOrderPocket()
        {
            InitPocket("PurOrder");
        }

        public List<PurOrderModel> SelectPurOrderModels(PurOrderModelArgs args)
        {
            return PocketQuery<PurOrderModel>("PO.PurOrder.PurOrderList.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                BP_CD = args.Select_Main_Bp_Cd,
                POH_NO = args.Select_Main_Poh_No
            });
        }

        public List<PurOrderDetailModel> SelectPurOrderDetailModels(PurOrderModelArgs args)
        {
            return PocketQuery<PurOrderDetailModel>("PO.PurOrder.PurOrderDetailList.Select", new
            {
                POH_NO = args.Select_Poh_No
            });
        }

        public List<PorModel> SelectPorModels(PurOrderModelArgs args)
        {
            return PocketQuery<PorModel>("PO.PurOrder.PorList.Select", new {
                START_DT = args.Select_Main_Por_Start_Dt,
                END_DT = args.Select_Main_Por_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode
            });
        }

        public void SavePurOrderModel(PurOrderModel purOrderModel)
        {
            var rst = PocketQuery<PurOrderModel>("PO.PurOrder.PurOrderList.Save", GetParameters_StrapDisableParam(purOrderModel)).SingleOrDefault();
            if (purOrderModel.RowState == Common.Model.RowState.Added)
            {
                purOrderModel.POH_NO = rst?.POH_NO;
            }

        }

        public void SavePurOrderDetailModels(List<PurOrderDetailModel> purOrderDetailModels)
        {
            PocketExecute("PO.PurOrder.PurOrderDetailList.Save", GetParameters_StrapDisableParam(purOrderDetailModels));
        }

        public void BpPorListToPoPlan(PorListToPoModel porListToPoModel)
        {
            PocketExecute("PO.PurOrder.PorListToPoPlan.BP", porListToPoModel);
        }

        public void BpConfirmPo(PurOrderModelArgs args)
        {
            PocketExecute("PO.PurOrder.ConfirmPurOrder.BP", new {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                POH_NO = args.Select_Poh_No,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID
            });
        }

        public void BpCancelPo(PurOrderModelArgs args)
        {
            PocketExecute("PO.PurOrder.CancelPurOrder.BP", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                POH_NO = args.Select_Poh_No,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID
            });
        }

        public void BpSendMail(PurOrderModelArgs args)
        {
            PocketExecute("PO.PurOrder.SendMail.BP", new
            {
                POH_NO = args.Select_Poh_No
            });
        }

        public void UpdatePoReport(PurOrderAddReportModel purOrderAddReportModel)
        {
            PocketExecute("PO.PurOrder.PoReport.U", purOrderAddReportModel);
        }
    }
}

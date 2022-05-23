using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.SalesOrder;

namespace BPack.Pocket.App.SD.SalesOrder
{
    public class SalesOrderPocket : PocketBase
    {
        public SalesOrderPocket()
        {
            InitPocket("SalesOrder");
        }

        public List<SalesOrderModel> SelectSalesOrderModels(SalesOrderModelArgs args)
        {
            return PocketQuery<SalesOrderModel>("SD.SalesOrder.SalesOrderList.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                SOR_NO = args.Select_Main_Sor_No,
                CUSTOM_PO_NO = args.Select_Main_Custom_Po_No
            });
        }


        public List<SalesOrderDetailModel> SelectSalesOrderDetailModels(SalesOrderModelArgs args)
        {
            return PocketQuery<SalesOrderDetailModel>("SD.SalesOrder.SalesOrderDetailList.Select", new
            {
                SOR_NO = args.Select_Sor_No
            });
        }

        public void SaveSalesOrderModel(SalesOrderModel salesOrderModel)
        {
            var rst = PocketQuery<SalesOrderModel>("SD.SalesOrder.SalesOrderList.Save", GetParameters_StrapDisableParam(salesOrderModel)).SingleOrDefault();
            if (salesOrderModel.RowState == Common.Model.RowState.Added)
            {
                salesOrderModel.SOR_NO = rst.SOR_NO;
            }
        }

        public void SaveSalesOrderDetailModels(List<SalesOrderDetailModel> salesOrderDetailModels)
        {
            PocketExecute("SD.SalesOrder.SalesOrderDetailList.Save", GetParameters_StrapDisableParam(salesOrderDetailModels));
        }

        public void BpConfirmSalesOrder(SalesOrderModelArgs salesOrderModelArgs)
        {
            PocketExecute("SD.SalesOrder.ConfirmSalesOrder.BP", new
            {
                SOR_NO = salesOrderModelArgs.Select_Sor_No,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
            });
        }
        public void BpDropSalesOrder(SalesOrderModelArgs salesOrderModelArgs)
        {
            PocketExecute("SD.SalesOrder.DropSalesOrder.BP", new
            {
                SOR_NO = salesOrderModelArgs.Select_Sor_No,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
            });
        }
    }
}

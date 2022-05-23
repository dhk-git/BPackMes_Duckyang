using BPack.Common.Pocket;
using BPack.Model.App.PC.WorkOrder;
using System.Collections.Generic;

namespace BPack.Pocket.App.PC.WorkOrder
{
    public class WorkOrderPocket : PocketBase
    {
        public WorkOrderPocket()
        {
            InitPocket("WorkOrder");
        }

        public void SaveWorkOrderModel(WorkOrderModel workOrderModel)
        {
            PocketExecute("PC.WorkOrder.WorkOrderList.Save", GetParameters_StrapDisableParam(workOrderModel));
        }
        public void SaveWorkOrderStatus(WorkOrderModel Model,string Order_Status)
        {
            PocketExecute("PC.WorkOrder.WorkOrderStatus.Save", new {
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
                ,MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
                //,COMP_CD = Model.COMP_CD
                //,PLANT_CD= Model.PLANT_CD
                ,WO_NO_KEY=Model.WO_NO_KEY
                , ORDER_STATUS= Order_Status
            });
        }


        public List<WorkOrderModel> SelectWorkOrderModels(WorkOrderModelArgs args)
        {
            return PocketQuery<WorkOrderModel>("PC.WorkOrder.WorkOrderList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                START_DT = args.START_DT,
                END_DT = args.END_DT,
                WC_CD=args.WC_CD,

                ITEM_CD = args.ITEM_CD,
                ITEM_NM = args.ITEM_NM,
                SHIFT_GROUP_CD=args.SHIFT_GROUP_CD,
                SHIFT_CD=args.SHIFT_CD,
                DEL_FG=args.DEL_FG
            });
        }
        public List<WorkOrderBomModel> SelectWorkOrderBomModels(WorkOrderModelArgs args)
        {
            var _value= PocketQuery<WorkOrderBomModel>("PC.WorkOrder.Bom.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                WO_NO = args.WO_NO_KEY,
                ALLOW_PHANTOM = args.Allow_Phantom
            }) ;
            return _value;
        }

        



        public List<WorkOrderBomDModel> SelectWorkOrderBomDModels(WorkOrderModelArgs args)
        {
            return PocketQuery<WorkOrderBomDModel>("PC.WorkOrder.WorkOrderBomD.Select", new
            {
                COMP_CD=args.Select_Main_Comp_Code,
                PLANT_CD=args.Select_Main_Plant_Code,
                WO_NO = args.WO_NO_KEY,
            });
        }
        public void SaveWorkOrderBomModel(WorkOrderBomDModel workOrderBomDModel)
        {
            PocketExecute("PC.WorkOrder.WorkOrderBomD.Save", GetParameters_StrapDisableParam(workOrderBomDModel));
        }

        public void SaveWorkOrderBomModels(List<WorkOrderBomDModel> workOrderBomDModels)
        {
            PocketExecute("PC.WorkOrder.WorkOrderBomD.Save", GetParameters_StrapDisableParam(workOrderBomDModels));
        }




        public List<RouteMtrlModel> SelectRouteMtrlModels(WorkOrderModelArgs args)
        {
            return PocketQuery<RouteMtrlModel>("PC.WorkOrder.RouteMtrl.Select", new
            {
                //ROUTE_NO = args.Select_RouteNo
            });
        }
    }
}

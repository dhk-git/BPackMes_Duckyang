using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WorWorkOrder;

namespace BPack.Pocket.App.PC.WorWorkOrder
{
    public class WorWorkOrderPocket : PocketBase
    {
        public WorWorkOrderPocket()
        {
            InitPocket("WorWorkOrder");
        }

        public void SaveWorkOrderDetailModel(WorkOrderDetailModel workOrderDetailModel)
        {
            PocketExecute("PC.WorWorkOrder.WoDetail.Save", GetParameters_StrapDisableParam(workOrderDetailModel));
        }

        public void SaveWorkOrderDetailModels(List<WorkOrderDetailModel> workOrderDetailModels)
        {
            PocketExecute("PC.WorWorkOrder.WoDetail.Save", GetParameters_StrapDisableParam(workOrderDetailModels));
        }

        public void SaveWorkOrderHeaderModel(WorkOrderHeaderModel workOrderHeaderModel)
        {
            PocketExecute("PC.WorWorkOrder.WoHeader.BP", GetParameters_StrapDisableParam(workOrderHeaderModel));
        }

        public void SaveWorkOrderHeaderModelV2(WorkOrderHeaderModel workOrderHeaderModel)
        {
            PocketExecute("PC.WorWorkOrder.WoHeader.BPv2", GetParameters_StrapDisableParam(workOrderHeaderModel));
        }

        public void SaveWorkOrderHeaderModels(List<WorkOrderHeaderModel> workOrderHeaderModels)
        {
            //PocketExecute("PC.WorWorkOrder.WoHeader.Save", GetParameters_StrapDisableParam(workOrderHeaderModels));
        }

        public void SaveWorkOrderMaterialModel(WorkOrderMaterialModel workOrderMaterialModel)
        {
            PocketExecute("PC.WorWorkOrder.WoMaterial.Save", GetParameters_StrapDisableParam(workOrderMaterialModel));
        }

        public void SaveWorkOrderMaterialModels(List<WorkOrderMaterialModel> workOrderMaterialModels)
        {
            PocketExecute("PC.WorWorkOrder.WoMaterial.Save", GetParameters_StrapDisableParam(workOrderMaterialModels));
        }

        public List<WorkOrderDetailModel> SelectWorkOrderDetailModels(WorWorkOrderModelArgs args)
        {
            return PocketQuery<WorkOrderDetailModel>("PC.WorWorkOrder.WoDetail.Select", new
            {
                WO_NO = args.Select_Wo_No
            });
        }

        public List<WorkOrderHeaderModel> SelectWorkOrderHeaderModels(WorWorkOrderModelArgs args)
        {
            return PocketQuery<WorkOrderHeaderModel>("PC.WorWorkOrder.WoHeader.Select", new
            {
                COMP_CD = args.Select_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                WO_STATUS = args.Select_Main_Wo_Status
            });
        }

        public List<WorkOrderMaterialModel> SelectWorkOrderMaterialModels(WorWorkOrderModelArgs args)
        {
            return PocketQuery<WorkOrderMaterialModel>("PC.WorWorkOrder.WoMaterial.Select", new
            {
                WO_NO = args.Select_Wo_No,
                ROUTE_NO = args.Select_Route_No,
                OPER = args.Select_Oper
            });
        }
    }
}

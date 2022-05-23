using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdRouting;

namespace BPack.Pocket.App.MD.PrdRouting
{
    public class PrdRoutingPocket : PocketBase
    {
        public PrdRoutingPocket()
        {
            InitPocket("PrdRouting");
        }

        public void BpCopyRouting(RoutingModel routingModel)
        {
            PocketExecute("MD.PrdRouting.CopyRouting.BP", GetParameters_StrapDisableParam(routingModel));
        }

        public void SaveMaterialModel(MaterialModel materialModel)
        {
            PocketExecute("MD.PrdRouting.MaterialList.Save", GetParameters_StrapDisableParam(materialModel));
        }

        public void SaveMaterialModels(List<MaterialModel> materialModels)
        {
            PocketExecute("MD.PrdRouting.MaterialList.Save", GetParameters_StrapDisableParam(materialModels));
        }

        public void SaveOperationModel(OperationModel operationModel)
        {
            PocketExecute("MD.PrdRouting.OperationList.Save", GetParameters_StrapDisableParam(operationModel));
        }

        public void SaveOperationModels(List<OperationModel> operationModels)
        {
            PocketExecute("MD.PrdRouting.OperationList.Save", GetParameters_StrapDisableParam(operationModels));
        }

        public void SaveRoutingModel(RoutingModel routingModel)
        {
            var newData = PocketQuery<RoutingModel>("MD.PrdRouting.RoutingList.Save", GetParameters_StrapDisableParam(routingModel)).SingleOrDefault();
            routingModel.ROUTE_NO = newData?.ROUTE_NO;

        }

        public void SaveRoutingModels(List<RoutingModel> routingModels)
        {
            PocketExecute("MD.PrdRouting.RoutingList.Save", GetParameters_StrapDisableParam(routingModels));
        }

        public List<MaterialModel> SelectMaterialModels(PrdRoutingModelArgs args)
        {
            return PocketQuery<MaterialModel>("MD.PrdRouting.MaterialList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                ROUTE_NO = args.Select_RoutingList_Route_No,
                OPER = args.Select_OperationList_Oper,
            });
        }

        public List<OperationModel> SelectOperationModels(PrdRoutingModelArgs args)
        {
            return PocketQuery<OperationModel>("MD.PrdRouting.OperationList.Select", new
            {
                ROUTE_NO = args.Select_RoutingList_Route_No
            });
        }

        public List<RoutingModel> SelectRoutingModels(PrdRoutingModelArgs args)
        {
            return PocketQuery<RoutingModel>("MD.PrdRouting.RoutingList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                ITEM_CD = args.Select_Main_Item_Code,
                ROUTE_NO = args.Select_Main_Route_No
            });
        }

        public List<BomDetailModel> SelectBomDetailModels(PrdRoutingModelArgs args)
        {
            return PocketQuery<BomDetailModel>("MD.PrdRouting.BomDetail.Select",
                new
                {
                    COMP_CD = args.Select_Bom_Main_Comp_Code,
                    PLANT_CD = args.Select_Bom_Main_Plant_Code,
                    BOM_NO = args.Select_Bom_BomHeaderList_Bom_No,
                }
            );
        }

        public List<BomHeaderModel> SelectBomHeaderModels(PrdRoutingModelArgs args)
        {
            return PocketQuery<BomHeaderModel>("MD.PrdRouting.BomHeader.Select",
                new
                {
                    COMP_CD = args.Select_Bom_Main_Comp_Code,
                    PLANT_CD = args.Select_Bom_Main_Plant_Code,
                    ITEM_CD = args.Select_Bom_Main_Item_Code,
                }
            );
        }
    }
}

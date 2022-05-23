using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.ItmSales;

namespace BPack.Pocket.App.MD.ItmSales
{
    public class ItmSalesPocket : PocketBase
    {
        public ItmSalesPocket()
        {
            InitPocket("ItmSales");
        }

        public void SaveItmSalesItemModels(List<ItmSalesItemModel> itmSalesItemModels)
        {
            PocketExecute("MD.ItmSales.Item.Save", GetParameters_StrapDisableParam(itmSalesItemModels));
        }

        public void SaveItmSalesItemModel(ItmSalesItemModel itmSalesItemModel)
        {
            PocketExecute("MD.ItmSales.Item.Save", GetParameters_StrapDisableParam(itmSalesItemModel));
        }

        public List<ItmSalesGateModel> SelectItmSalesGateModels(ItmSalesModelArgs args)
        {
            return PocketQuery<ItmSalesGateModel>("MD.ItmSales.Gate.Select", new
            {
                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD,
            });
        }

        public List<ItmSalesItemModel> SelectItmSalesItemModels(ItmSalesModelArgs args)
        {
            return PocketQuery<ItmSalesItemModel>("MD.ItmSales.Item.Select", new
            {
                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD,
                BP_CD = args.Select_Main_BP_CD
            });
        }
    }
}

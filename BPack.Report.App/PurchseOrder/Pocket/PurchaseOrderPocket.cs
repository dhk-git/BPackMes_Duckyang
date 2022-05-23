using BPack.Common.Pocket;
using BPack.Report.App.PurchseOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.PurchseOrder.Pocket
{
    public class PurchaseOrderPocket : PocketBase
    {
        public PurchaseOrderPocket()
        {
            InitPocket("ReportQuerys");
        }

        public List<PoModel> SelectPoModels(PurchaseOrderModelArgs args)
        {
            var poModels = PocketQuery<PoModel>("Report.PurchaseOrder.Order.R", new {
                POH_NO_LIST = string.Join("^#^", args.Poh_No_List)
            });
            foreach (var model in poModels)
            {
                model.PoItemModels = PocketQuery<PoItemModel>("Report.PurchaseOrder.OrderItem.R", new { POH_NO = model.POH_NO });
            }
            return poModels;
        }

    }
}

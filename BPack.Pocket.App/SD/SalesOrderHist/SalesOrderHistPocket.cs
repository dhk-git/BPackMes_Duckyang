using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.SalesOrderHist;

namespace BPack.Pocket.App.SD.SalesOrderHist
{
    public class SalesOrderHistPocket : PocketBase
    {
        public SalesOrderHistPocket()
        {
            InitPocket("SalesOrderHist");
        }
        public List<SalesOrderHistModel> SelectSalesOrderHistModels(SalesOrderHistModelArgs args)
        {
            return PocketQuery<SalesOrderHistModel>("SD.SalesOrderHist.OrderListHist.Select", new
            {
                START_DT = args.Search_Main_START_DT
              ,
                END_DT = args.Search_Main_END_DT
              ,
                ITEM_CD = args.Search_Main_ITEM_CD
              ,
                ITEM_NM = args.Search_Main_ITEM_NM
              ,
                ITEM_GR1_CD = args.Search_Main_ITEM_GR1_CD
              ,
                BP_CD = args.Search_Main_ITEM_BP_CD

            });
        }

        public List<SalesOrderHistDetailModel> SelectSalesOrderHistDetailModels(SalesOrderHistModelArgs args)
        {
            return PocketQuery<SalesOrderHistDetailModel>("SD.SalesOrderHist.OrderListDetail.Select", new
            {
                SOR_DT = args.Select_Main_Sor_Dt
                ,
                BP_CD = args.Select_Main_BP_CD
                ,ITEM_CD = args.Select_Main_ITEM_CD
            });
        }
    }
}

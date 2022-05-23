using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.DlvOrderHist;

namespace BPack.Pocket.App.SD.DlvOrderHist
{
    public class DlvOrderHistPocket : PocketBase
    {
        public DlvOrderHistPocket()
        {
            InitPocket("DlvOrderHist");
        }
        public List<DlvOrderHistModel> SelectDlvOrderHistModels(DlvOrderHistModelArgs args)
        {
            return PocketQuery<DlvOrderHistModel>("SD.DlvOrderHist.OrderListHist.Select", new
            {
               START_DT = args.Search_Main_START_DT
              ,END_DT = args.Search_Main_END_DT
              ,ITEM_CD = args.Search_Main_ITEM_CD
              ,ITEM_NM = args.Search_Main_ITEM_NM
              ,ITEM_GR1_CD = args.Search_Main_ITEM_GR1_CD
              ,BP_CD = args.Search_Main_ITEM_BP_CD

            });
        }

        public List<DlvOrderHistDetailModel> SelectDlvOrderHistDetailModels(DlvOrderHistModelArgs args)
        {
            return PocketQuery<DlvOrderHistDetailModel>("SD.DlvOrderHist.OrderListDetail.Select", new
            {
                DLV_DT = args.Select_Main_Dlv_Dt
                ,BP_CD = args.Select_Main_BP_CD
                ,ITEM_CD = args.Select_Main_ITEM_CD
            });
        }

        public List<DlvOrderHistHuDetailModel> SelectDlvOrderHistHuDetailModels(DlvOrderHistModelArgs args)
        {
            var models= PocketQuery<DlvOrderHistHuDetailModel>("SD.DlvOrderHist.OrderListHuDetail.Select", new
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

            return models;


        }

    }
}

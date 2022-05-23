using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeResultBatch;

namespace BPack.Pocket.App.PC.WoeResultBatch
{
    public class WoeResultBatchPocket : PocketBase
    {
        public WoeResultBatchPocket()
        {
            InitPocket("WoeResultBatch");
        }

        public List<WoeResultBatchWorkOrderModel> SelectWoeResultBatchWorkOrderModels(WoeResultBatchModelArgs args)
        {
            return PocketQuery<WoeResultBatchWorkOrderModel>("PC.WoeResultBatch.WorkOrderList.Select", new { 
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                WC_CD = args.Select_Main_Wc_Cd
            });
        }
            
        public List<WoeResultBatchMatModel> SelectWoeresultBatchMatModels(WoeResultBatchModelArgs args)
        {
            return PocketQuery<WoeResultBatchMatModel>("PC.WoeResultBatch.MatList.Select", new { 
                WO_NO = args.Select_Wo_No
            });
        }

        public List<WoeResultBatchResultModel> SelectWoeResultBatchResultModels(WoeResultBatchModelArgs args)
        {
            return PocketQuery<WoeResultBatchResultModel>("PC.WoeResultBatch.ResultList.Select", new {
                WO_NO = args.Select_Wo_No
            });
        }

        public void BpWoeResultBatch(WoeResultBatchBpModel woeResultBatchBpModel)
        {
            PocketQuery("PC.WoeResultBatch.Hu.Bp", woeResultBatchBpModel);
        }
       
    }
}

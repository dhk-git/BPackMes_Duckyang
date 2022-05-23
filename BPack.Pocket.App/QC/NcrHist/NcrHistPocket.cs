using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.QC.NcrHist;

namespace BPack.Pocket.App.QC.NcrHist
{
    public class NcrHistPocket : PocketBase
    {
        public NcrHistPocket()
        {
            InitPocket("NcrHist");
        }

        public void SaveNcrHistHeaderModel(NcrHistHeaderModel model)
        {
            PocketExecute("QC.NcrHist.Header.Save", GetParameters_StrapDisableParam(model));
        }

        public void SaveNcrHistHeaderModels(List<NcrHistHeaderModel> models)
        {
            PocketExecute("QC.NcrHist.Header.Save", GetParameters_StrapDisableParam(models));
        }

        public void SaveNcrHistDetailModels(List<NcrHistDetailModel> models)
        {
            PocketExecute("QC.NcrHist.Detail.Save", GetParameters_StrapDisableParam(models));
        }

        public List<NcrHistHeaderModel> SelectNcrHistHeaderModels(NcrHistModelArgs args)
        {
            return PocketQuery<NcrHistHeaderModel>("QC.NcrHist.Header.Select",
                new
                {
                    COMP_CD = args.Select_Main_CompCode,
                    PLANT_CD = args.Select_Main_PlantCode,
                    INSP_DT_FROM = args.Select_Main_InspDateFrom,
                    INSP_DT_TO = args.Select_Main_InspDateTo,
                    SHIFT_CD = args.Select_Main_ShiftCode,
                    ITEM_TYPE = args.Select_Main_ItemType,
                    WC_CD = args.Select_Main_WorkCenterCode,
                    ITEM_GR_1 = args.Select_Main_ItemGroup1,
                    ITEM_CD = args.Select_Main_ItemCode,
                    NCR_STATUS = args.Select_Main_NcrStatus
                });
        }

        public List<NcrHistDetailModel> SelectNcrHistDetailModels(NcrHistModelArgs args)
        {
            return PocketQuery<NcrHistDetailModel>("QC.NcrHist.Detail.Select",
                new
                {
                    NCR_NO = args.Select_Header_NcrNo,
                });
        }

    }
}

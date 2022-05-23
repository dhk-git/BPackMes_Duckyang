using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.QC.AppHist;

namespace BPack.Pocket.App.QC.AppHist
{
    public class AppHistPocket : PocketBase
    {
        public AppHistPocket()
        {
            InitPocket("AppHist");
        }

        public List<AppHistHeaderModel> SelectAppHistHeaderModels(AppHistModelArgs args)
        {
            return PocketQuery<AppHistHeaderModel>("QC.AppHist.Header.Select", new
            {
                OPT = args.Select_Main_Opt,
                USER_ID = args.Select_Main_User_Id,
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                REQ_DT_FROM = args.Select_Main_Req_Dt_From,
                REQ_DT_TO = args.Select_Main_Req_Dt_To,
                INSP_APP_STATUS_LIST = args.Select_Main_Insp_App_Status_List,
                REF_NO = args.Select_Main_Ref_No
            });
        }
        public List<AppHistDetailModel> SelectAppHistDetailModels(AppHistModelArgs args)
        {
            return PocketQuery<AppHistDetailModel>("QC.AppHist.Detail.Select", new
            {
                REF_NO = args.Select_Ref_No
            });
        }

        public List<AppHistDetailInspModel> SelectAppHistDetailInspModels(AppHistModelArgs args)
        {
            return PocketQuery<AppHistDetailInspModel>("QC.AppHist.Detail.Insp.Select", new
            {
                INSP_NO = args.Select_Insp_No
            });
        }
    }
}

using BPack.Common.Pocket;
using BPack.Model.App.PC.NwtStatusInfo;
using System.Collections.Generic;

namespace BPack.Pocket.App.PC.NwtStatusInfo
{
    public class NwtStatusInfoPocket : PocketBase
    {
        public NwtStatusInfoPocket()
        {
            InitPocket("NwtStatusInfo");
        }

        public List<NwtStatusInfoModel> SelectNwtStatusInfoModels(NwtStatusInfoModelArgs args)
        {
            return PocketQuery<NwtStatusInfoModel>("PC.NwtStatusInfo.Main.R", new
            {
                COMP_CD=args.Select_Main_Comp_CD
                ,
                PLANT_CD=args.Select_Main_Plant_CD
                ,
                WC_CD=args.Select_Main_Wc_CD
                ,
                S_WORK_DT=args.Select_Main_Start_Dt
                ,
                E_WORK_DT=args.Select_Main_End_Dt
                
            });
        }

        public List<NwtStatusInfoListModel> SelectNwtStatusInfoListModels(NwtStatusInfoModelArgs args)
        {
            return PocketQuery<NwtStatusInfoListModel>("PC.NwtStatusInfo.Hist.R", new
            {
                COMP_CD = args.Select_Main_Comp_CD
                   ,
                PLANT_CD = args.Select_Main_Plant_CD
                   ,
                WC_CD = args.Select_Main_Wc_CD
                   ,
                WORK_DT = args.Work_Dt
                   ,
                SHIFT_CD = args.Shift_Cd

            });
        }

        public void SaveNwtStatusModel(NwtStatusInfoListModel nwtStatusInfoListModel)
        {
            PocketExecute("PC.NwtStatusInfo.Hist.S", GetParameters_StrapDisableParam(nwtStatusInfoListModel));
        }

    }
}

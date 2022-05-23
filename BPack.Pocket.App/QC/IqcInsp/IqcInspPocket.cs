using BPack.Common.Pocket;
using BPack.Model.App.QC.IqcInsp;
using System;
using System.Collections.Generic;

namespace BPack.Pocket.App.QC.IqcInsp
{
    public class IqcInspPocket : PocketBase
    {
        public IqcInspPocket()
        {
            InitPocket("IqcInsp");
        }


        public List<IqcInspModel> SelectHeaderModels(IqcInspModelArgs args)
        {
            return PocketQuery<IqcInspModel>("MM.IqcInsp.Header.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd
                ,
                PLANT_CD = args.Select_Main_Plant_Cd
                ,
                START_DT = args.Select_Main_Start_Dt
                ,
                END_DT = args.Select_Main_End_Dt

            });
        }

        public void SaveModel(IqcInspModel huModel)
        {
            PocketExecute("MM.IqcInsp.Header.Save", huModel);
        }

        public void SaveModels(List<IqcInspModel> huModels)
        {
            PocketExecute("MM.IqcInsp.Header.Save", huModels);
        }

        public void SaveInOutModel(IqcInspModel huModel)
        {
            PocketExecute("MM.IqcInsp.Header.INOUT.Save", GetParameters_StrapDisableParam(huModel));
        }

        public void SaveInOutModels(List<IqcInspModel> huModels)
        {
            PocketExecute("MM.IqcInsp.Header.INOUT.BP", GetParameters_StrapDisableParam(huModels));
        }

        public void SaveItemModel(IqcInspItemModel huModel)
        {
            PocketExecute("MM.IqcInsp.Detail.Save", GetParameters_StrapDisableParam(huModel));
        }

        public void SaveItemModels(List<IqcInspItemModel> huModels)
        {
            PocketExecute("MM.IqcInsp.Detail.Save", GetParameters_StrapDisableParam(huModels));
        }
        public List<IqcInspItemModel> SelectDetailModels(IqcInspModelArgs args)
        {
            return PocketQuery<IqcInspItemModel>("MM.IqcInsp.Detail.Select", new { IQC_NO = args.Select_Main_IQC_NO });
        }



        #region 불량정보 관련
        public List<IqcInspFailModel> SelectFailModels(IqcInspModelArgs args)
        {
            return PocketQuery<IqcInspFailModel>("MM.IqcInsp.Fail.Select", new
            {

                IQD_NO = args.Select_SUB_IQD_NO

            });
        }
        public void SaveFailModel(IqcInspFailModel huModel)
        {
            PocketExecute("MM.IqcInsp.Fail.Save", huModel);
        }

        public void SaveFailModels(List<IqcInspFailModel> huModels)
        {
            PocketExecute("MM.IqcInsp.Fail.Save", huModels);
        }
        #endregion
    }
}

using System.Collections.Generic;
using BPack.Common.Pocket;
using BPack.Model.App.MD.WcWorkTime;

namespace BPack.Pocket.App.MD.WcWorkTime
{
    public class WcWorkTimePocket : PocketBase
    {
        public WcWorkTimePocket()
        {
            InitPocket("WcWorkTime");
        }

        public void SaveWcWorkTimeWorkTimeModels(List<WcWorkTimeWorkTimeModel> models)
        {
            PocketExecute("MD.WcWorkTime.WorkTime.Save", GetParameters_StrapDisableParam(models));
        }

        public void SaveWcWorkTimeWorkTimeModel(WcWorkTimeWorkTimeModel model)
        {
            PocketExecute("MD.WcWorkTime.WorkTime.Save", GetParameters_StrapDisableParam(model));
        }

        public List<WcWorkTimeWorkCenterModel> SelectWcWorkTimeWorkCenterModels(WcWorkTimeModelArgs args)
        {
            return PocketQuery<WcWorkTimeWorkCenterModel>("MD.WcWorkTime.WorkCenter.Select", new
            {
                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD,
            });
        }

        public List<WcWorkTimeWorkTimeModel> SelectWcWorkTimeWorkTimeModels(WcWorkTimeModelArgs args)
        {
            return PocketQuery<WcWorkTimeWorkTimeModel>("MD.WcWorkTime.WorkTime.Select", new
            {
                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD,
                WC_CD = args.Select_WorkCenter_CD
            });
        }

    }
}

using BPack.Common.Pocket;
using BPack.Model.App.QC.AppLine;
using System.Collections.Generic;

namespace BPack.Pocket.App.QC.AppLine
{
    public class AppLinePocket : PocketBase
    {
        public AppLinePocket()
        {
            InitPocket("AppLine");
        }

        public List<AppLineModel> SelectAppLineListModels(AppLineModelArgs args)
        {
            return PocketQuery<AppLineModel>("MD.QciAppLine.List.Select", new
            {
                USER_ID = args.Select_User_ID
            });
        }
        public void SaveAppLineListModel(AppLineModel appLineModel)
        {
            PocketExecute("MD.QciAppLine.List.Save", GetParameters_StrapDisableParam(appLineModel));
        }

        public void SaveAppLineListModels(List<AppLineModel> appLineModels)
        {
            PocketExecute("MD.QciAppLine.List.Save", GetParameters_StrapDisableParam(appLineModels));
        }


    }
}

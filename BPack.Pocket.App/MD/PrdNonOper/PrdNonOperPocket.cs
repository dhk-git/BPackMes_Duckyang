using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdNonOper;

namespace BPack.Pocket.App.MD.PrdNonOper
{
    public class PrdNonOperPocket : PocketBase
    {
        public PrdNonOperPocket()
        {
            InitPocket("PrdNonOper");
        }

        public void SaveNonOperGroupModel(NonOperGroupModel model)
        {
            PocketExecute("MD.PrdNonOper.NonGroupList.Save", model);
        }

        public void SaveNonOperGroupModel(List<NonOperGroupModel> models)
        {
            PocketExecute("MD.PrdNonOper.NonGroupList.Save", models);
        }

        public List<NonOperGroupModel> SelectNonOperGroupModels(PrdNonOperModelArgs args)
        {
            return PocketQuery<NonOperGroupModel>("MD.PrdNonOper.NonGroupList.Select", new
            {
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
            });
        }
        public void SaveNonOperModel(NonOperModel model)
        {
            PocketExecute("MD.PrdNonOper.NonList.Save", model);
        }
        public void SaveNonOperModel(List<NonOperModel> models)
        {
            PocketExecute("MD.PrdNonOper.NonList.Save", models);
        }
        public List<NonOperModel> SelectNonOperModels(PrdNonOperModelArgs args)
        {
            return PocketQuery<NonOperModel>("MD.PrdNonOper.NonList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                NOTWORK_GROUP_CD = args.NOTWORK_GROUP_CD
            });
        }






    }
}

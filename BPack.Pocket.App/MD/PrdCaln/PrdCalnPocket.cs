using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdCaln;

namespace BPack.Pocket.App.MD.PrdCaln
{
    public class PrdCalnPocket : PocketBase
    {
        public static PrdCalnPocket prdCalnPocket;
        public PrdCalnPocket()
        {
            InitPocket("PrdCaln");
        }
        public static PrdCalnPocket GetInstance()
        {
            if (prdCalnPocket == null) prdCalnPocket = new PrdCalnPocket();
            return prdCalnPocket;
        }
        public void SaveCalnModel(CalnModel model)
        {
            PocketExecute("MD.PrdCaln.CalnList.Save", GetParameters_StrapDisableParam(model));
        }
        public void SaveCalnModel(List<CalnModel> models)
        {
            PocketExecute("MD.PrdCaln.CalnList.Save", GetParameters_StrapDisableParam(models));
        }
        public List<CalnModel> SelectCalnModel(PrdCalnModelArgs args)
        {
            return PocketQuery<CalnModel>("MD.PrdCaln.CalnList.Select", new
            {
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                YEAR_CD = args.Year_CD,
                Month_CD=args.Month_CD,
                WC_CD=args.Select_Main_Wc_Code
            });
        }
        public void CreateCalendar(CalnCreateModel model)
        {
            PocketExecute("MD.PrdCaln.CalnList.CreateBP", new
            {
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                COMP_CD = model.COMP_CD,
                PLANT_CD = model.PLANT_CD,
                YEAR_CD = model.YEAR_CD,
                MONTH_CD = model.MONTH_CD
            });
        }

    }
}

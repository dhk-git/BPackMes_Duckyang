using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdHoliday;

namespace BPack.Pocket.App.MD.PrdHoliday
{
    public class PrdHolidayPocket : PocketBase
    {
        public static PrdHolidayPocket prdHolidayPocket;
        public PrdHolidayPocket()
        {
            InitPocket("PrdHoliday");
        }
        public static PrdHolidayPocket GetInstance()
        {
            if (prdHolidayPocket == null) prdHolidayPocket = new PrdHolidayPocket();
            return prdHolidayPocket;
        }

        public void SaveHolidayModel(HolidayModel model)
        {
            PocketExecute("MD.PrdHoliday.HolidayList.Save", GetParameters_StrapDisableParam( model));
        }

        public void SaveHolidayModel(List<HolidayModel> models)
        {
            PocketExecute("MD.PrdHoliday.HolidayList.Save", GetParameters_StrapDisableParam(models));
        }

        public List<HolidayModel> SelectHolidayModels(PrdHolidayModelArgs args)
        {
            return PocketQuery<HolidayModel>("MD.PrdHoliday.HolidayList.Select", new
            {
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                YEAR = args.Year_CD
            });
        }

        public void CopyYearHoliday(HolidayCopyModel model)
        {
            PocketExecute("MD.PrdHoliday.HolidayList.CopyBP",new
            {
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                COMP_CD = model.COMP_CD,
                PLANT_CD = model.PLANT_CD,
                YEAR_CD = model.YEAR_CD,
                COPY_YEAR_CD=model.COPY_YEAR_CD

            } );
        }

    }
}

using BPack.Common.Pocket;
using BPack.Model.App.MI.UserInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MI.UserInfo
{
    public class UserInfoPocket : PocketBase
    {
        public UserInfoPocket()
        {
            _queryInfoModels = GetQueryInfoModels(new QueryInfoModelArgs { Select_Group1 = "UserInfo" });
        }

        public UserInfoModel CheckUserInfo(UserInfoModelArgs args)
        {
            return PocketQuery<UserInfoModel>("USP_MI_USERINFO_CHECK_R", new {USER_ID = args.Check_User_ID, USER_PW = args.Check_User_PW }).SingleOrDefault();
        }

        public UserInfoModel CheckUserInfo_LoginGuid(UserInfoModelArgs args)
        {
            return PocketQuery<UserInfoModel>("USP_MI_UserInfo_Check_LoginKey_R", new { LOGIN_GUID = args.Check_Login_Guid }).SingleOrDefault();
        }

        public UserInfoModel ReGetUserInfo(UserInfoModelArgs args)
        {
            return PocketQuery<UserInfoModel>("USP_MI_USERINFO_REGET_R", new { USER_ID = args.Check_User_ID }).SingleOrDefault();
        }

        public void SaveUserInfoModel(UserInfoModel userInfoModel)
        {
            PocketExecute("USP_MI_USERINFO_LIST_CUD", GetParameters_StrapDisableParam(userInfoModel));
        }

        public List<UserInfoModel> SelectUserInfoModels(UserInfoModelArgs args)
        {
            return PocketQuery<UserInfoModel>("USP_MI_USERINFO_LIST_R", new
            {
                USER_ID = args.Select_Main_User_ID,
                USER_NAME = args.Select_Main_User_Name,
                DEPT_CODE = args.Select_Main_Dept_Code,
                COMP_CODE = args.Select_Main_Comp_Code
            });
        }
    }
}

using BPack.Common.Pocket;
using BPack.Model.App.MD.OrgUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.OrgUser
{
    public class OrgUserPocket : PocketBase
    {
        public OrgUserPocket()
        {
            InitPocket("OrgUser");
        }

        public void SaveUserModel(UserModel userModel)
        {
            PocketExecute("MD.OrgUser.UserList.Save", userModel);
        }

        public List<DeptModel> SelectDeptModels(OrgUserModelArgs args)
        {
            return PocketQuery<DeptModel>("MD.OrgUser.DeptListTree.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
            });
        }

        public List<UserModel> SelectUserModels(OrgUserModelArgs args)
        {
            return PocketQuery<UserModel>("MD.OrgUser.UserList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                DEPT_CD = args.Select_Dept_Code,
                INCLUDE_DEL = args.Select_Main_Include_Del
            });
        }
    }
}

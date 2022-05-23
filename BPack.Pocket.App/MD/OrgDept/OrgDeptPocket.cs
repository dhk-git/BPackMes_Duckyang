using BPack.Common.Pocket;
using BPack.Model.App.MD.OrgDept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.OrgDept
{
    public class OrgDeptPocket : PocketBase
    {
        public OrgDeptPocket()
        {
            InitPocket("orgDept");
        }

        public void SaveDeptModel(DeptModel deptModel)
        {
            PocketExecute("MD.OrgDept.DeptList.Save", GetParameters_StrapDisableParam(deptModel));
        }

        public void SaveDeptModels(List<DeptModel> deptModels)
        {
            PocketExecute("MD.OrgDept.DeptList.Save", GetParameters_StrapDisableParam(deptModels));
        }

        public List<CompModel> SelectCompModels(OrgDeptModelArgs args)
        {
            return PocketQuery<CompModel>("MD.OrgDept.CompList.Select", new
            {
            });
        }

        public List<DeptModel> SelectDeptModels(OrgDeptModelArgs args)
        {
            return PocketQuery<DeptModel>("MD.OrgDept.DeptList.Select", new
            {
                COMP_CD = args.Select_Comp_Code,
                DEPT_CD = args.Select_Main_Dept_Code,
                DEPT_NM = args.Select_Main_Dept_Name
            });
        }
    }
}

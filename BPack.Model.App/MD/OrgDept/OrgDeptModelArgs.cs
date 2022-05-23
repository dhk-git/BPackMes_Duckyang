using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.OrgDept
{
    public class OrgDeptModelArgs : ModelArgsBase
    {
        public string Select_Comp_Code { get; set; }
        public string Select_Main_Dept_Code { get; set; }
        public string Select_Main_Dept_Name { get; set; }
    }
}

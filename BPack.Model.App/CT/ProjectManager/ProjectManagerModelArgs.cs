using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.CT.ProjectManager
{
    public class ProjectManagerModelArgs : ModelArgsBase
    {
        public string Select_Main_Pjt_No { get; set; }
        public string Select_Main_Pjt_Nm { get; set; }
        public string Select_Main_Pjt_Task_Cls { get; set; }
        public string Select_Pjt_No { get; set; }
        public string Select_Pjd_No { get; set; }
    }
}

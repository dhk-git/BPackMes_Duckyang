using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.CT.ProjectManager;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.CT
{
    public class ProjectManagerArgs : ArgsBase
    {
        public ProjectManagerModelArgs ProjectManagerModelArgs { get; set; } = new ProjectManagerModelArgs();
    }
}

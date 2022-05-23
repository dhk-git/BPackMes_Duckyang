using BPack.Model.App.MD.OrgPlant;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MD.OrgPlant
{
    public class OrgPlantArgs : ArgsBase
    {
        public OrgPlantModelArgs OrgPlantModelArgs { get; set; } = new OrgPlantModelArgs();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.PC.MaterialRequest;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.PC
{
    public class MaterialRequestArgs : ArgsBase
    {
        public MaterialRequestModelArgs MaterialRequestModelArgs { get; set; } = new MaterialRequestModelArgs();
    }
}

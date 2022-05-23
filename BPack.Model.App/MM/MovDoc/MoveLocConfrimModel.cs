using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.MovDoc
{
    public class MoveLocConfirmModel : ModelBase_CommonColumns
    {
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }
        public string MOV_NO_KEY { get; set; }
    }
}

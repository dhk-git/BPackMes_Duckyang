using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdHoliday
{
    public class HolidayCopyModel : ModelBase_CommonColumns
    {
        
        public string COMP_CD { get; set; }

        public string PLANT_CD { get; set; }

        public string YEAR_CD { get; set; }

        public string COPY_YEAR_CD { get; set; }
    }
}

using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.PurInbound
{
    public class InHuHeaderModel : ModelBase_CommonColumns
    { 

         public string PIH_NO_KEY { get; set; }
        public string PIH_NO { get; set; }
      
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
    
        public string WH_CD { get; set; }       //입고할 창고
      

    }
}

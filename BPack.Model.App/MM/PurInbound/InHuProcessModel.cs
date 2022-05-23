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
    public class InHuProcessModel : ModelBase_CommonColumns
    {
        public string PIH_NO { get; set; }
        public string PID_NO { get; set; }
        public string HU_NO { get; set; }
        public DateTime? IN_DTTM { get; set; }
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string ITEM_CD { get; set; }
        public decimal GR_QTY { get; set; }
        public string WH_CD { get; set; }       //입고할 창고
        //public string LOC_CD { get; set; }      //입고할 위치
        [StrapDisableParam]
        public override bool VALID { get => base.VALID; set => base.VALID = value; }
        [StrapDisableParam]
        public override float SORT_NO { get => base.SORT_NO; set => base.SORT_NO = value; }
        [StrapDisableParam]
        public override int ROW_SEQ { get => base.ROW_SEQ; set => base.ROW_SEQ = value; }
        public string REF_REMARK { get; set; }

    }
}

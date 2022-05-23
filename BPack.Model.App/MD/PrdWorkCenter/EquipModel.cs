﻿using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdWorkCenter
{
    public class EquipModel : ModelBase_CommonColumns_With_DelFlag
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string WC_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string COMP_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string PLANT_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string EQUIP_CD_KEY { get; set; }
        [Display(Name = "작업장코드")]
        [StrapVisible(false, false, false)]
        public string WC_CD { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }

        [Display(Name = "설비코드")]
        [StrapMinWidth(120)]
        public string EQUIP_CD { get; set; }

        [Display(Name = "설비명")]
        [StrapMinWidth(180)]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string EQUIP_NM { get; set; }
        [Display(Name = "설비분류")]
        [StrapMinWidth(120)]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string EQUIP_CLS { get; set; }
        [Display(Name = "바코드")]
        [StrapMinWidth(150)]
        [StrapDisableParam]
        [ReadOnly(true)]
        public string EQUIP_BARCODE { get; set; }



        [Display(Name = "비고")]
        [StrapVisible(false, false, false)]
        [StrapMemoEdit]
        [StrapMinWidth(200)]
        public override string REMARK { get; set; }

        //[Display(Name = "유효시작일")]
        //[StrapVisible(false, false, false)]
        //public DateTime VALID_FROM_DT { get; set; } = DateTime.Now;
        //[Display(Name = "유효종료일")]
        //[StrapVisible(false, false, false)]
        //public DateTime VALID_TO_DT { get; set; } = new DateTime(9999, 12, 31);

        [Display(Name = "삭제FLAG(Y=삭제)")]
        [StrapVisible(false, false, false)]
        public override string DEL_FG { get; set; } = "N";

        [Display(Name = "수정일시")]
        [StrapVisible(false, false, false)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        [ReadOnly(true)]
        [StrapDateEdit(FormatString = "yyyy-MM-dd HH:mm")]
        public override DateTime? MODIFY_DTTM { get; set; }
        [Display(Name = "수정자")]
        [StrapVisible(false, false, false)]
        [ReadOnly(true)]
        [StrapLookUpEditAllUsers]
        public override string MODIFY_USER_ID { get; set; }

    }
}

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

namespace BPack.Model.App.MD.DlvJisInfo
{
    public class DlvJisInfoJISModel : ModelBase_CommonColumns
    {
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
        public string DLV_PLC_CD_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int ALC_NO_KEY { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "납품장소코드")]
        [StrapVisible(false, false, false)]
        public string DLV_PLC_CD { get; set; }
        [StrapMinWidth(80)]
        [Display(Name = "ALC번호")]
        public int ALC_NO { get; set; }

        [Display(Name = "서열구분")]
        [StrapVisible(false, false, false)]
        public string ALC_DV { get; set; } = "JIS";

        [Display(Name = "서열유형")]
        public string ALC_TYPE { get; set; }
        [Display(Name = "서열유형명")]
        [StrapMinWidth(300)]
        public string ALC_TYPE_NM { get; set; }
        [Display(Name = "적재수량")]
        public int LOAD_QTY { get; set; }
        [Display(Name = "출력컬럼수")]
        public int PRINT_COL { get; set; }
        [Display(Name = "출력방향")]
        public string PRINT_WAY { get; set; } = "RTL";
        [Display(Name = "서열을 가지고 현재 출하지시(Bu")]
        [StrapVisible(false, false, false)]
        public string DEVICE_ID { get; set; }

        [Display(Name = "비고")]
        [StrapVisible(false, false, false)]
        [StrapMemoEdit]
        [StrapMinWidth(200)]
        public override string REMARK { get; set; }

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

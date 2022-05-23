using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WorWorkOrder
{
    public class WorkOrderDetailModel : ModelBase_CommonColumns
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string WO_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int OPER_KEY { get; set; }
        [Display(Name = "작업지시번호")]
        [StrapVisible(false, false, false)]
        public string WO_NO { get; set; }
        [Display(Name = "라우팅번호")]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO { get; set; }
        [Display(Name = "공정")]
        public int OPER { get; set; }
        [Display(Name = "공정설명")]
        public string OPER_DESC { get; set; }
        [Display(Name = "작업장")]
        public string WC_CD { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        [StrapVisible(false, false, false)]
        public string PLANT_CD { get; set; }
        [Display(Name = "품번")]
        [StrapVisible(false, false, false)]
        public string ITEM_CD { get; set; }
        [Display(Name = "사용금형코드")]
        [StrapVisible(false, false, false)]
        public string MOLD_CD { get; set; }
        [Display(Name = "실적식별표유형")]
        public string RST_HU_TYPE { get; set; }
        [Display(Name = "자재투입창고")]
        public string MAT_WH_CD { get; set; }
        [Display(Name = "자재투입위치")]
        public string MAT_LOC_CD { get; set; }
        [Display(Name = "생산입고창고")]
        public string GD_WH_CD { get; set; }
        [Display(Name = "생산입고위치")]
        public string GD_LOC_CD { get; set; }
        [Display(Name = "MES단말기")]
        public string DVC_ID { get; set; }
        [Display(Name = "단말기모드")]
        public string MODE_ID { get; set; }
        [Display(Name = "공정진행상태")]
        public string WOD_STATUS { get; set; }
        [Display(Name = "삭제FLAG")]
        [StrapVisible(false, false, false)]
        public string DEL_FG { get; set; }
    }
}

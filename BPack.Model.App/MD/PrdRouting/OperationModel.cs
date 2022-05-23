using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MD.PrdRouting
{
    public class OperationModel : ModelBase_CommonColumns_With_DelFlag 
    {
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string ROUTE_NO_KEY { get; set; }
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public int OPER_KEY { get; set; }
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "라우팅번호")]
        public string ROUTE_NO { get; set; }
        [Display(Name = "공정")]
        public int OPER { get; set; }
        [Display(Name = "공정명")]
        public string OPER_DESC { get; set; }
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "회사코드")]
        public string COMP_CD { get; set; }
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "작업장")]
        public string WC_CD { get; set; }
        [Display(Name = "실적식별표유형")]
        [StrapVisible(false, false, false)]
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
        [Display(Name = "SAP I/F 여부 (Y/N)")]
        [StrapVisible(false, false, false)]
        public string IS_IF { get; set; }
    }
}

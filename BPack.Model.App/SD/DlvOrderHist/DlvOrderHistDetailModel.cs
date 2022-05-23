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

namespace BPack.Model.App.SD.DlvOrderHist
{
    public class DlvOrderHistDetailModel : ModelBase
    {



        
        [ReadOnly(true)]
        [Key]
        [StrapVisible(false, false, false)]
        public string DRH_NO_KEY { get; set; }
        [Display(Name = "출하확정일자")]
        public DateTime DLV_DT { get; set; }
        [Display(Name = "거래처코드")]
        [StrapVisible(false, false, false)]
        public string BP_CD { get; set; }
        [Display(Name = "거래처")]
        public string BP_NM { get; set; }

        [Display(Name = "출하실적번호")]
        public string DRH_NO { get; set; }
        [Display(Name = "출하지시번호")]
        public string DOH_NO { get; set; }
        [Display(Name = "회사코드")]
        [StrapVisible(false, false, false)]
        public string COMP_CD { get; set; }

        
        [Display(Name = "등록일자(피킹일자)")]
        [StrapVisible(false, false, false)]
        public DateTime PICKING_DT { get; set; }
        
        [Display(Name = "출하확정시간")]
        [StrapVisible(false, false, false)]
        public string DLV_TM { get; set; }
        [Display(Name = "납품수량")]
        public string DLV_QTY { get; set; }
        [Display(Name = "반품수량")]
        public string RETURN_QTY { get; set; }
        [Display(Name = "납품완료수량")]
        public string CLOSE_QTY { get; set; }
        [Display(Name = "단위")]
        public string BASE_UNIT  {get;set;}
       [Display(Name = "출하실적상태")]
        [StrapVisible(false, false, false)]
        public string DRH_STATUS { get; set; }
        [Display(Name = "고객사납품번호")]
        public string CUST_DOH_NO { get; set; }
        [Display(Name = "차량번호")]
        public string VEHICLE_NO { get; set; }
        [Display(Name = "운전자")]
        public string DRIVER_NM { get; set; }
        [Display(Name = "비고")]
        [StrapVisible(false, false, false)]
        public string REMARK { get; set; }
        [Display(Name = "생성일시")]
        [StrapVisible(false, false, false)]
        public DateTime CREATE_DTTM { get; set; }
        [Display(Name = "수정일시")]
        [StrapVisible(false, false, false)]
        public DateTime MODIFY_DTTM { get; set; }
        [Display(Name = "생성자")]
        [StrapVisible(false, false, false)]
        public string CREATE_USER_ID { get; set; }
        [Display(Name = "수정자")]
        [StrapVisible(false, false, false)]
        public string MODIFY_USER_ID { get; set; }

      


    }
}

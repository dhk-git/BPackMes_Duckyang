using BPack.Model.Annotation.Common;
using System.ComponentModel.DataAnnotations;

namespace BPack.Model.App.SD.CiqDlvClose
{
    public class SkbaDataExcelUploadModel
    {

        [Display(Name = "납품번호(SKBA)")]
        public string CUST_DOH_NO { get; set; }

        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }

        [Display(Name = "반품수량")]
        public decimal RETURN_QTY { get; set; }

        [Display(Name = "납품완료수량")]
        public decimal CLOSE_QTY { get; set; }
    }

    public class BpSkbaDataExcelUploadModel
    {
        public string CUST_DOH_NO { get; set; }
        public string ITEM_CD { get; set; }
        public decimal RETURN_QTY { get; set; }
        public decimal CLOSE_QTY { get; set; }
        public string COMP_CD { get; set; }
        public string PLANT_CD { get; set; }
        public string CREATE_USER_ID { get; set; }
        public string LANG_CODE { get; set; }
    }
}

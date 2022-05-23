using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.MaterialRequest
{
    public class MaterialRequestHeaderModel
    {
        [DisplayName("T_바코드")]
        public string HEADER_BARCODE { get; set; }

        [DisplayName("T_자재불출요청서")]
        public string TITLE { get; set; }

        [DisplayName("T_요청정보")]
        public string HEADER_TITLE { get; set; }

        [DisplayName("T_요청번호")]
        public string MRQH_TITLE { get; set; }

        [DisplayName("요청번호")]
        public string MRH_NO { get; set; }

        [DisplayName("T_입고요청일")]
        public string MRH_DT_TITLE { get; set; }

        [DisplayName("입고요청일")]
        public DateTime MRH_DT { get; set; }

        [DisplayName("T_요청위치")]
        public string WC_CD_TITLE { get; set; }

        [DisplayName("요청위치")]
        public string WC_CD { get; set; }


        [DisplayName("T_작성자")]
        public string MODIFY_USER_ID_TITLE { get; set; }

        [DisplayName("작성자")]
        public string MODIFY_USER_ID { get; set; }

        [DisplayName("T_요청품목")]
        public string DETAIL_TITLE { get; set; }

        [DisplayName("T_출력일시")]
        public string PRINT_DTTM_TITLE { get; set; }

        [DisplayName("출력일시")]
        public DateTime PRINT_DTTM { get; set; }




        //*************데이터 헤더 영역******************//

        [DisplayName("D_SEQ")]
        public string D_SEQ { get; set; }

        [DisplayName("D_품번")]
        public string D_ITEM_CD { get; set; }

        [DisplayName("D_품명")]
        public string D_ITEM_NM { get; set; }

        [DisplayName("D_제품군")]
        public string D_ITEM_GROUP { get; set; }

        [DisplayName("D_품목유형")]
        public string D_ITEM_TYPE { get; set; }

        [DisplayName("D_위치")]
        public string D_LOC_NM { get; set; }

        [DisplayName("D_요청수량")]
        public string D_MRD_QTY { get; set; }

        [DisplayName("D_대포장 No.")]
        public string D_HU_NO { get; set; }

        [DisplayName("D_비고")]
        public string D_REMARK { get; set; }

        public List<MaterialRequestDetailModel> DetailModels { get; set; }
    }
}

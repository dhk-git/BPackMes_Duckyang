using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.PC.WoeEssLot
{
    public class WoeEssTreeModel : ModelBase_CommonColumns
    {
        [Display(Name = "생산일자")]
        [ReadOnly(true)]
        public string WORK_DT { get; set; }
        [ReadOnly(true)]
        public string LV { get; set; }

        [ReadOnly(true)]
        public string ID { get; set; }

        [ReadOnly(true)]
        public string P_ID { get; set; }

        [Display(Name = "상위 Barcode")]
        [ReadOnly(true)]
        public string P_LOT_NO { get; set; }

        [Display(Name = "제품군")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string ITEM_GR_1 { get; set; }

        [Display(Name = "품번")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string ITEM_CD { get; set; }

        [Display(Name = "품명")]
        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string ITEM_NM { get; set; }

        [Display(Name = "Barcode")]
        [ReadOnly(true)]
        public string LOT_NO { get; set; }

        [Display(Name = "유형")]
        [ReadOnly(true)]
        public string TYPE { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string SEQ1 { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string SEQ2 { get; set; }

        [ReadOnly(true)]
        [StrapVisible(false, false, false)]
        public string SEQ3 { get; set; }

        [Display(Name = "EOL")]
        [ReadOnly(true)]
        public string MODULE_EOL { get; set; }

        [Display(Name = "SIDE_LONG_BOLT_1")]
        [ReadOnly(true)]
        public string SIDE_LONG_BOLT_1 { get; set; }

        [Display(Name = "SIDE_LONG_BOLT_2")]
        [ReadOnly(true)]
        public string SIDE_LONG_BOLT_2 { get; set; }


        [Display(Name = "SIDE_LONG_BOLT_3")]
        [ReadOnly(true)]
        public string SIDE_LONG_BOLT_3 { get; set; }

        [Display(Name = "SIDE_LONG_BOLT_4")]
        [ReadOnly(true)]
        public string SIDE_LONG_BOLT_4 { get; set; }


        [Display(Name = "CENTER_LONG_BOLT_1")]
        [ReadOnly(true)]
        public string CENTER_LONG_BOLT_1 { get; set; }


        [Display(Name = "CENTER_LONG_BOLT_2")]
        [ReadOnly(true)]
        public string CENTER_LONG_BOLT_2 { get; set; }


        [Display(Name = "CENTER_LONG_BOLT_3")]
        [ReadOnly(true)]
        public string CENTER_LONG_BOLT_3 { get; set; }


        [Display(Name = "CENTER_LONG_BOLT_4")]
        [ReadOnly(true)]
        public string CENTER_LONG_BOLT_4 { get; set; }

        //2022.05.04 시작
        [Display(Name = "BMS_BARCODE")]
        [ReadOnly(true)]
        public string BMS_BARCODE { get; set; }

        [Display(Name = "BARCODE_LH_A")]
        [ReadOnly(true)]
        public string BARCODE_LH_A { get; set; }

        [Display(Name = "BARCODE_LH_B")]
        [ReadOnly(true)]
        public string BARCODE_LH_B { get; set; }

        [Display(Name = "BARCODE_RH_A")]
        [ReadOnly(true)]
        public string BARCODE_RH_A { get; set; }

        [Display(Name = "BARCODE_RH_B")]
        [ReadOnly(true)]
        public string BARCODE_RH_B { get; set; }

        //2022.05.04 종료

        [Display(Name = "L_T_PCB")]
        [ReadOnly(true)]
        public string L_T_PCB { get; set; }

        [Display(Name = "L_B_PCB")]
        [ReadOnly(true)]
        public string L_B_PCB { get; set; }

        [Display(Name = "R_T_PCB")]
        [ReadOnly(true)]
        public string R_T_PCB { get; set; }

        [Display(Name = "R_B_PCB")]
        [ReadOnly(true)]
        public string R_B_PCB { get; set; }

        [Display(Name = "OCV")]
        [ReadOnly(true)]
        public string OCV { get; set; }

        [Display(Name = "ACIR")]
        [ReadOnly(true)]
        public string ACIR { get; set; }


        [Display(Name = "AXIS1")]
        [ReadOnly(true)]
        public string AXIS1 { get; set; }

        [Display(Name = "AXIS1_판정")]
        [ReadOnly(true)]
        public string AXIS1_RESULT { get; set; }

        [Display(Name = "AXIS2")]
        [ReadOnly(true)]
        public string AXIS2 { get; set; }

        [Display(Name = "AXIS2_판정")]
        [ReadOnly(true)]
        public string AXIS2_RESULT { get; set; }

        [Display(Name = "AXIS3")]
        [ReadOnly(true)]
        public string AXIS3 { get; set; }

        [Display(Name = "AXIS3_판정")]
        [ReadOnly(true)]
        public string AXIS3_RESULT { get; set; }

        [Display(Name = "AXIS4")]
        [ReadOnly(true)]
        public string AXIS4 { get; set; }

        [Display(Name = "AXIS4_판정")]
        [ReadOnly(true)]
        public string AXIS4_RESULT { get; set; }

    
        


        
    }
}

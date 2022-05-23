using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.GirTotalStock
{
    public class LocStockModel
    {
        [Display(Name ="회사코드")]
        public string COMP_CD { get; set; }
        [Display(Name = "공장코드")]
        public string PLANT_CD { get; set; }
        [Display(Name = "창고코드")]
        public string WH_CD { get; set; }
        [Display(Name = "위치코드")]
        public string LOC_CD { get; set; }
        [Display(Name = "창고명")]
        public string WH_CDNM { get; set; }
        [Display(Name = "위치명")]
        public string LOC_CDNM { get; set; }
        [Display(Name = "품번")]
        public string ITEM_CD { get; set; }
        [Display(Name = "품명")]
        public string ITEM_NM { get; set; }
        [Display(Name = "차종")]
        public string ITEM_GR_1 { get; set; }
        [Display(Name = "ALC")]
        public string ALC_CD { get; set; }
        [Display(Name = "수량")]
        public decimal LOC_STOCK_QTY { get; set; }
    }
}

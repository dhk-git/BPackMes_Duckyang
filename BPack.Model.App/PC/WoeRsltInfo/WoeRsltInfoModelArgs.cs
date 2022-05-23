using BPack.Common.Model;
using System;

namespace BPack.Model.App.PC.WoeRsltInfo
{
    public class WoeRsltInfoModelArgs : ModelArgsBase
    {
        public string CompCd { get; set; }
        public string PlantCd { get; set; }
        public string WcCd { get; set; }
        public string ItemCd { get; set; }
        public string ItemNm { get; set; }
        public DateTime WoDtFrom { get; set; }
        public DateTime WoDtTo { get; set; }
        public string RouteNo { get; set; }
        public int Oper { get; set; }
        public string WoNo { get; set; }
        public string RstNo { get; set; }
        public string ItemGr1 { get; set; }
    }
}

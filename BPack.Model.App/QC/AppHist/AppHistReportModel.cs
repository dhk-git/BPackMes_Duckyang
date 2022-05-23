using BPack.Common.Model;
using System.Collections.Generic;
using System.Drawing;

namespace BPack.Model.App.QC.AppHist
{
    public class AppHistReportModel : ModelBase
    {
        public AppHistHeaderModel HeaderModel { get; set; }
        public AppHistDetailModel DetailModel { get; set; }

        public List<AppHistDetailInspModel> DetailInspModels { get; set; }

        public Image image { get; set; }
    }
}

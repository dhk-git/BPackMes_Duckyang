using System.Collections.Generic;
using System.Linq;

namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class NcrReturnReportA4 : DevExpress.XtraReports.UI.XtraReport
    {

        public NcrReturnReportA4()
        {
            InitializeComponent();
        }

        public void DataRefresh(object dataSource)
        {
            objectDataSource4.DataSource = dataSource;
        }

    }
}

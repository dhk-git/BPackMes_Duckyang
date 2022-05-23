namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class NcrTagReportA4 : DevExpress.XtraReports.UI.XtraReport
    {
        //private List<NcrHistHeaderModel> _ncrHistHeaderModel;
        //private NcrHistPocket _ncrHistPocket;

        //public NcrHistTag(NcrHistPocket ncrHistPocket)
        //{
        //    InitializeComponent();

        //    _ncrHistPocket = ncrHistPocket;
        //}

        public NcrTagReportA4()
        {
            InitializeComponent();
        }

        public void DataRefresh(object source, string reportType)
        {
            switch (reportType)
            {
                case "A":
                    xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::BPack.Report.App.Properties.Resources.부적합의심, true);
                    xrLabel4.Text = "등록자";
                    break;
                case "B":
                    xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::BPack.Report.App.Properties.Resources.부적합, true);
                    xrLabel4.Text = "판정자";
                    break;
                case "C":
                    xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::BPack.Report.App.Properties.Resources.특채, true);
                    xrLabel4.Text = "판정자";
                    break;
            }

            bindingSource1.DataSource = source;
        }

    }
}

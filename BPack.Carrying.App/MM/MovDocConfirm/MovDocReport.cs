using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BPack.Pocket.App.MM.MovDocConfirm;

namespace BPack.Carrying.App.MM.MovDocConfirm
{
    public partial class MovDocReport : DevExpress.XtraReports.UI.XtraReport
    {
        private MovDocConfirmArgs _movDocConfirmArgs;
        private MovDocConfirmPocket _movDocConfirmPocket;

        public MovDocReport()
        {
            InitializeComponent();
        }

        public MovDocReport(MovDocConfirmArgs movDocConfirmArgs, MovDocConfirmPocket movDocConfirmPocket) : this()
        {
            _movDocConfirmArgs = movDocConfirmArgs;
            _movDocConfirmPocket = movDocConfirmPocket;
        }

        public void DataRefresh(MovDocConfirmArgs movDocConfirmArgs)
        {
            objectDataSource1.DataSource = _movDocConfirmPocket.SelectMovDocReportModel(movDocConfirmArgs.MovDocConfirmModelArgs);

        }
    }
}

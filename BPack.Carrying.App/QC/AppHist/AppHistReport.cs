using BPack.Model.App.QC.AppHist;
using BPack.Pocket.App.QC.AppHist;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BPack.Carrying.App.QC.AppHist
{
    public partial class AppHistReport : DevExpress.XtraReports.UI.XtraReport
    {
        private const int MAX_ROW = 10;

        private AppHistReportModel _AppHistReportModel;
        //private AppHistPocket _AppHistPocket;
        //private string _Drt_No;

        public AppHistReport(AppHistHeaderModel _appHistHeaderModel, AppHistDetailModel _appHistDetailModel, List<AppHistDetailInspModel> _appHistDetailInspModels, Image _image)
        {
            InitializeComponent();

            _AppHistReportModel = new AppHistReportModel();
            _AppHistReportModel.HeaderModel = _appHistHeaderModel;
            _AppHistReportModel.DetailModel = _appHistDetailModel;
            _AppHistReportModel.DetailInspModels = _appHistDetailInspModels;
            _AppHistReportModel.image = _image;

            objectDataSource4.DataSource = _AppHistReportModel;
            this.gridControl1.DataSource = _AppHistReportModel.DetailInspModels;
            
            lblAPP_USER_NM_APP.Text = "aaa";
            //DataRefresh();
        }

        public void DataRefresh()
        {
            //AppHistReportModel _AppHistReportHeaderModel;
            //List<AppHistReportModel> headerModelList = new List<AppHistReportModel>();
            //_AppHistReportHeaderModel = _AppHistPocket.SelectAppHistReportHeaderModels(_Drt_No).First<AppHistReportModel>();

            // 검사값 리스트의 SPACE 공간대신 빈 줄을 채워넣기 위한 조치 
            //if(_AppHistReportModel.DetailInspModels.Count < MAX_ROW)
            //{
            //    for(int i = _AppHistReportModel.DetailInspModels.Count + 1; i<= MAX_ROW; i++)
            //    {
            //        AppHistDetailInspModel detailModel = new AppHistDetailInspModel();
            //        _AppHistReportModel.DetailInspModels.Add(detailModel);
            //    }
            //}
            //else if (_AppHistReportModel.DetailInspModels.Count > MAX_ROW)
            //{

            //}            
            
            //objectDataSource4.DataSource = _AppHistReportModel;
            //this.gridControl1.DataSource = _AppHistReportModel.DetailInspModels;
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (e.Column.FieldName == "INSP_DV_NM" || e.Column.FieldName == "INSP_NM" || e.Column.FieldName == "INSP_VAL_TYPE_NM" ||
                e.Column.FieldName == "BASE_VALUE" || e.Column.FieldName == "UPPER_LIMIT" || e.Column.FieldName == "LOWER_LIMIT")
            {
                if ((gridView1.GetRowCellDisplayText(e.RowHandle1, "INSP_ID") == gridView1.GetRowCellDisplayText(e.RowHandle2, "INSP_ID")) &&
                   (e.CellValue1?.ToString() == e.CellValue2?.ToString()))
                {
                    e.Merge = true;
                }
                else
                {
                    e.Merge = false;
                }
            }
            e.Handled = true;
        }

    }
}

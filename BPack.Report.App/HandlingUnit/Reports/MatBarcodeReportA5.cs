using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BPack.Common.Model;
using BPack.Common.Pocket;
using System.Collections.Generic;
using System.Linq;

namespace BPack.Report.App.HandlingUnit.Reports
{
    public partial class MatBarcodeReportA5 : DevExpress.XtraReports.UI.XtraReport
    {
        private List<SelectedLangWordModel> _langData = LangWordPocket.SelectLangWordModels(BPack.Common.LoginInfo.UserInfo.Sys_Language, "REPORT_HANDLING_UNIT");

        public MatBarcodeReportA5()
        {
            InitializeComponent();

            xrTableCell1.Text = _langData.Where(a => a.WORD_CODE == "Mat_ItemCd").SingleOrDefault()?.TR_WORD_NAME;
            xrTableCell3.Text = _langData.Where(a => a.WORD_CODE == "Mat_ItemNm").SingleOrDefault()?.TR_WORD_NAME;
            xrTableCell8.Text = _langData.Where(a => a.WORD_CODE == "Mat_AlcCd").SingleOrDefault()?.TR_WORD_NAME;  
            xrTableCell29.Text = _langData.Where(a => a.WORD_CODE == "Mat_StockQty").SingleOrDefault()?.TR_WORD_NAME;
            xrTableCell32.Text = _langData.Where(a => a.WORD_CODE == "Mat_WorkDt").SingleOrDefault()?.TR_WORD_NAME;
            xrTableCell35.Text = _langData.Where(a => a.WORD_CODE == "Mat_BpNm").SingleOrDefault()?.TR_WORD_NAME;
            xrTableCell38.Text = _langData.Where(a => a.WORD_CODE == "Mat_Remark").SingleOrDefault()?.TR_WORD_NAME;
            xrTableCell41.Text = _langData.Where(a => a.WORD_CODE == "Mat_CompName").SingleOrDefault()?.TR_WORD_NAME;
            xrLabel1.Text = _langData.Where(a => a.WORD_CODE == "Mat_Title").SingleOrDefault()?.TR_WORD_NAME;
            xrTableCell10.Text = _langData.Where(a => a.WORD_CODE == "Mat_CarModel").SingleOrDefault()?.TR_WORD_NAME;
        }

        public void DataRefresh(object dataSource)
        {
            //출력일시
            xrLabel3.Text = _langData.Where(a => a.WORD_CODE == "Mat_PrintDateTime").SingleOrDefault().TR_WORD_NAME + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            objectDataSource1.DataSource = dataSource;
        }

    }
}

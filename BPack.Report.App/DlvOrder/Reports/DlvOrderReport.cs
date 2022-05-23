using BPack.Common.LoginInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace BPack.Report.App.DlvOrder.Reports
{
    public partial class DlvOrderReport : DevExpress.XtraReports.UI.XtraReport
    {
        private List<XRControl> _xRControls;
        public DlvOrderReport()
        {
            InitializeComponent();
            _xRControls = new List<XRControl>();
            _xRControls.Add(lblTitle);      //출하지시서
            _xRControls.Add(xrTableCell1); //출하지시번호
            _xRControls.Add(xrTableCell5); //출하일자
            _xRControls.Add(xrTableCell7);  //출하회차
            _xRControls.Add(xrTableCell39);  //비고

            _xRControls.Add(xrTableCell3);  //거래처명
            _xRControls.Add(xrTableCell9);  //대표자명
            _xRControls.Add(xrTableCell35); //연락처
            _xRControls.Add(xrTableCell37); //주소

            _xRControls.Add(xrLabel1);      //출하품목
            _xRControls.Add(xrTableCell18); //품번
            _xRControls.Add(xrTableCell19); //품명
            _xRControls.Add(xrTableCell20); //제품군
            _xRControls.Add(xrTableCell21); //수량
            _xRControls.Add(xrTableCell22); //단위
            _xRControls.Add(xrTableCell23); //비고

            _xRControls.Add(xrTableCell28); //창고
            _xRControls.Add(xrTableCell29); //위치
            _xRControls.Add(xrTableCell30); //작업일
            _xRControls.Add(xrTableCell31); //바코드번호
            _xRControls.Add(xrTableCell32); //수량
            _xRControls.Add(xrTableCell33); //소계
            
            _xRControls.Add(xrTableCell41); //총계 

            string trLang;
            foreach (var item in _xRControls)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, item.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    item.Text = trLang;
                }
            }
        }

        public void DataRefresh(object datasource)
        {
            string lblPrint = "출력일시";
            string trLang;
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, lblPrint);
            if (!string.IsNullOrEmpty(trLang))
            {
                lblPrint = trLang;
            }
            xrLabel2.Text = lblPrint + " : " + DateTime.Now.ToString();
            objectDataSource1.DataSource = datasource;
        }
    }
}

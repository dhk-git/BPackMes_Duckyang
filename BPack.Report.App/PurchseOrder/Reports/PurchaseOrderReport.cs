using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BPack.Common.LoginInfo;
using System.Collections.Generic;

namespace BPack.Report.App.PurchseOrder.Reports
{
    public partial class PurchaseOrderReport : DevExpress.XtraReports.UI.XtraReport
    {

        private List<XRControl> _xRControls;
        public PurchaseOrderReport()
        {
            InitializeComponent();
            //lblTitle.Text = LanguagePack.GetTransWord();
            _xRControls = new List<XRControl>();
            _xRControls.Add(lblTitle);      //타이틀
            _xRControls.Add(xrTableCell29); //발주번호
            _xRControls.Add(xrTableCell27); //발주일자
            _xRControls.Add(xrTableCell5);  //수신처
            _xRControls.Add(xrTableCell1);  //발주처
            _xRControls.Add(xrTableCell3);  //입고공장
            _xRControls.Add(xrTableCell23); //주소
            _xRControls.Add(xrTableCell25); //전화번호
            _xRControls.Add(xrTableCell32); //비고

            _xRControls.Add(xrTableCell17); //품번
            _xRControls.Add(xrTableCell18); //품명
            _xRControls.Add(xrTableCell19); //규격
            _xRControls.Add(xrTableCell20); //수량
            _xRControls.Add(xrTableCell8); //단위
            _xRControls.Add(xrTableCell21); //납기일
            _xRControls.Add(xrTableCell22); //발주상세번호
            _xRControls.Add(xrTableCell7); //합계
            _xRControls.Add(xrLabel2); //발주품목

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
            string lblPrint =  "출력일시";
            string trLang;
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, lblPrint);
            if (!string.IsNullOrEmpty(trLang))
            {
                lblPrint = trLang;
            }
            xrLabel3.Text = lblPrint + " : " + DateTime.Now.ToString();
            objectDataSource1.DataSource = datasource;
        }

    }
}

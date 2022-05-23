using BPack.Common.LoginInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace BPack.Report.App.HandlingUnit.Reports.DY
{
    public partial class Dy_MPackingReport : DevExpress.XtraReports.UI.XtraReport
    {
        private List<XRControl> _xRControls;
        public Dy_MPackingReport()
        {
            InitializeComponent();

            //언어 변환 위해 binding 제거
            this.xrLabel1.ExpressionBindings.Clear();
            this.xrLabel2.ExpressionBindings.Clear();
            this.xrLabel3.ExpressionBindings.Clear();
            this.xrLabel4.ExpressionBindings.Clear();
            this.xrLabel5.ExpressionBindings.Clear();
            this.xrLabel6.ExpressionBindings.Clear();
            this.xrLabel5.ExpressionBindings.Clear();
            this.xrLabel8.ExpressionBindings.Clear(); 
            
            _xRControls = new List<XRControl>();
            _xRControls.Add(xrLabel1);      //타이틀 TAG
            _xRControls.Add(xrLabel2);      //공급사 SUPPLIER
            _xRControls.Add(xrLabel3);      //품번 P/NO
            _xRControls.Add(xrLabel4);      //품명 P/NAME
            _xRControls.Add(xrLabel5);      //수량 QUANTITY
            _xRControls.Add(xrLabel6);      //날짜 LOADING DATE 
            _xRControls.Add(xrLabel8);      //(주)덕양산업

        }
        public void DataRefresh(object data)
        {
            objectDataSource1.DataSource = data;
            LanguageConvert();
        }
        private void LanguageConvert()
        {

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

    }
}

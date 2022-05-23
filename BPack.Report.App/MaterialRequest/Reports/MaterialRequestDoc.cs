using BPack.Common.LoginInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace BPack.Report.App.MaterialRequest.Reports
{
    public partial class MaterialRequestDoc : DevExpress.XtraReports.UI.XtraReport
    {
        private List<XRControl> _xRControls;
        public MaterialRequestDoc()
        {
            InitializeComponent();

        }
        public MaterialRequestDoc(List<MaterialRequestHeaderModel> models)
        {
            InitializeComponent();

            //언어 변환 위해 binding 제거
            this.xrLabel1.ExpressionBindings.Clear();
            this.xrLabel2.ExpressionBindings.Clear();
            this.xrLabel3.ExpressionBindings.Clear();
            this.xrLabel5.ExpressionBindings.Clear();
            this.xrLabel7.ExpressionBindings.Clear();
            this.xrLabel9.ExpressionBindings.Clear();
            this.xrLabel13.ExpressionBindings.Clear();

            this.xrTableCell10.ExpressionBindings.Clear();
            this.xrTableCell11.ExpressionBindings.Clear();
            this.xrTableCell12.ExpressionBindings.Clear();
            this.xrTableCell13.ExpressionBindings.Clear();
            this.xrTableCell14.ExpressionBindings.Clear();
            this.xrTableCell15.ExpressionBindings.Clear();
            this.xrTableCell17.ExpressionBindings.Clear();




            _xRControls = new List<XRControl>();
            _xRControls.Add(xrLabel1);      //자재불출지시서
            _xRControls.Add(xrLabel2);      //지시번호
            _xRControls.Add(xrLabel3);      //지시번호
            _xRControls.Add(xrLabel5);      //지시요청일
            _xRControls.Add(xrLabel7);      //지시위치
            _xRControls.Add(xrLabel9);      //작성자
            _xRControls.Add(xrLabel13);      //지시품목

            _xRControls.Add(xrTableCell10);      //품번
            _xRControls.Add(xrTableCell11);      //품명
            _xRControls.Add(xrTableCell12);      //제품군
            _xRControls.Add(xrTableCell13);      //제품유형
            _xRControls.Add(xrTableCell14);      //위치
            _xRControls.Add(xrTableCell15);      //지시수량
            _xRControls.Add(xrTableCell17);      //비고


            objectDataSource1.DataSource = models;

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

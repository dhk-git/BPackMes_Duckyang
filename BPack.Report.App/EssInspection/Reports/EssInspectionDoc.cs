using BPack.Common.LoginInfo;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace BPack.Report.App.EssInspection.Reports
{
    public partial class EssInspectionDoc : DevExpress.XtraReports.UI.XtraReport
    {
        private List<XRControl> _xRControls;
        public EssInspectionDoc()
        {
            InitializeComponent();

            //언어 변환 위해 binding 제거
            this.xrLabel1.ExpressionBindings.Clear();
            this.xrLabel2.ExpressionBindings.Clear();
            this.xrLabel3.ExpressionBindings.Clear();
            this.xrLabel5.ExpressionBindings.Clear();
            this.xrLabel10.ExpressionBindings.Clear();
            this.xrLabel7.ExpressionBindings.Clear();
            this.xrLabel5.ExpressionBindings.Clear();
            this.xrLabel12.ExpressionBindings.Clear();

            _xRControls = new List<XRControl>();
            _xRControls.Add(xrLabel1);      //검사성적서
            _xRControls.Add(xrLabel2);      //출고일
            _xRControls.Add(xrLabel3);      //품번
            _xRControls.Add(xrLabel5);      //주소
            _xRControls.Add(xrLabel10);      //품명
            _xRControls.Add(xrLabel7);      //납품번호
            _xRControls.Add(xrLabel12);      //Assy lot 번호
            


        }
        //public EssInspectionDoc(object _data):this()
        //{
        //    this.objectDataSource1.DataSource = _data;
        //}
        public void Datarefresh(object _data)
        {
            this.objectDataSource1.DataSource = _data;
            
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

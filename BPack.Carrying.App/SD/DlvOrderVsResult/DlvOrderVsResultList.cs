using BPack.Model.App.SD.DlvOrderVsResult;
using BPack.Pocket.App.SD.DlvOrderVsResult;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.SD.DlvOrderVsResult
{
    public partial class DlvOrderVsResultList : StrapSubForm_Pivot
    {
        private DlvOrderVsResultArgs _dlvOrderVsResultArgs;
        private DlvOrderVsResultPocket _dlvOrderVsResultPocket;

        public DlvOrderVsResultList()
        {
            InitializeComponent();
        }

        public DlvOrderVsResultList(DlvOrderVsResultArgs dlvOrderVsResultArgs, DlvOrderVsResultPocket dlvOrderVsResultPocket) : this()
        {
            this._dlvOrderVsResultArgs = dlvOrderVsResultArgs;
            this._dlvOrderVsResultPocket = dlvOrderVsResultPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitField(new FieldArgs_StrapSubForm_Pivot {
                BindingSource = dlvOrderVsResultModelBindingSource,
                FormArgs = _dlvOrderVsResultArgs,
                InitModelType = typeof(DlvOrderVsResultModel),
                ModelArgs = _dlvOrderVsResultArgs.DlvOrderVsResultModelArgs,
                PivotGridControl = strapPivotControl1
            });
            InitZipperDelegate<DlvOrderVsResultModelArgs, DlvOrderVsResultModel>(_dlvOrderVsResultPocket.SelectDlvOrderVsResultModels, null);

            strapPivotControl1.OptionsView.ShowColumnHeaders = false;
            strapPivotControl1.OptionsView.ShowDataHeaders = false;
            strapPivotControl1.OptionsView.ShowFilterHeaders = false;
            strapPivotControl1.OptionsView.ShowRowGrandTotals = false;
            strapPivotControl1.OptionsView.ShowRowTotals = false;

            string langTrWord;
            foreach (DevExpress.XtraPivotGrid.PivotGridField item in strapPivotControl1.Fields)
            {
                langTrWord = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, item.Caption);
                if (!string.IsNullOrEmpty(langTrWord))
                {
                    item.Caption = langTrWord;
                }
                item.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                item.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
                item.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            }
            strapPivotControl1.CustomCellValue += StrapPivotControl1_CustomCellValue;
            strapPivotControl1.CustomAppearance += StrapPivotControl1_CustomAppearance;
            strapPivotControl1.CustomDrawFieldValue += StrapPivotControl1_CustomDrawFieldValue;
        }

        private void StrapPivotControl1_CustomDrawFieldValue(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventArgs e)
        {
            if (e.Area == DevExpress.XtraPivotGrid.PivotArea.ColumnArea && e.ValueType == DevExpress.XtraPivotGrid.PivotGridValueType.Value)
            {
                var a = ((DateTime)e.Value).DayOfWeek;
                if (a == DayOfWeek.Sunday || a == DayOfWeek.Saturday)
                {
                    e.Appearance.BackColor = Color.Red;
                }
            }
        }

        private void StrapPivotControl1_CustomAppearance(object sender, DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs e)
        {
            if (e.DataField == fieldQTY)
            {
                if (e.Value != null && (decimal)e.Value < 0)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private void StrapPivotControl1_CustomCellValue(object sender, DevExpress.XtraPivotGrid.PivotCellValueEventArgs e)
        {
            if (_dlvOrderVsResultArgs.DlvOrderVsResultModelArgs.Select_Main_IsTotalDate != null && _dlvOrderVsResultArgs.DlvOrderVsResultModelArgs.Select_Main_IsTotalDate.Equals("Y"))
            {
                decimal val;
                if (decimal.TryParse(e.Value?.ToString(), out val))
                {
                    if (val == 0)
                    {
                        e.Value = null;
                    }
                }
            }
        }


        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            strapPivotControl1.BestFitRowArea();
        }
    }
}

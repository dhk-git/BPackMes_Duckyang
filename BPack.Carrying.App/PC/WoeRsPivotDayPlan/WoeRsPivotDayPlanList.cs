using BPack.Model.App.PC.WoeRsPivotDayPlan;
using BPack.Pocket.App.PC.WoeRsPivotDayPlan;
using BPack.Strap.FormControls;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.WoeRsPivotDayPlan
{
    public partial class WoeRsPivotDayPlanList : StrapSubForm_Pivot
    {
        private WoeRsPivotDayPlanArgs _pivotDayPlanArgs;
        private WoeRsPivotDayPlanPocket _pivotDayPlanPocket;

        public WoeRsPivotDayPlanList()
        {
            InitializeComponent();
        }

        public WoeRsPivotDayPlanList(WoeRsPivotDayPlanArgs pivotDayPlanArgs, WoeRsPivotDayPlanPocket pivotDayPlanPocket):this()
        {
            this._pivotDayPlanArgs = pivotDayPlanArgs;
            this._pivotDayPlanPocket = pivotDayPlanPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitField(new FieldArgs_StrapSubForm_Pivot
            {
                BindingSource = rsPivotDayPlanModelBindingSource,
                FormArgs = _pivotDayPlanArgs,
                InitModelType = typeof(RsPivotDayPlanModel),
                ModelArgs = _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs,
                PivotGridControl = strapPivotControl1
            });
            
            InitZipperDelegate<WoeRsPivotDayPlanModelArgs, RsPivotDayPlanModel>(_pivotDayPlanPocket.SelectRsPivotDayPlanModels, null);

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
            strapPivotControl1.CustomCellDisplayText += StrapPivotControl1_CustomCellDisplayText;

        }

        private void StrapPivotControl1_CustomCellDisplayText(object sender, PivotCellDisplayTextEventArgs e)
        {
            if (e.Value == null) return;
            if (e.ColumnValueType == PivotGridValueType.Value)
            {
                if (strapPivotControl1.GetFieldValue(e.RowField, e.RowIndex).ToString().Substring(0, 1) == "4")
                {
                    e.DisplayText = e.Value.ToString() + " %";
                }
            }
            if ( e.ColumnValueType != PivotGridValueType.GrandTotal) return;

            //달성률인경우 그랜드 토탈 에서 안보이도록
            if (strapPivotControl1.GetFieldValue(e.RowField, e.RowIndex).ToString().Substring(0, 1) == "4")
            {
                int _ColumnIndex = e.ColumnIndex;
                int _RowIndex = e.RowIndex;
                float orderValue = Convert.ToInt32(strapPivotControl1.GetCellValue(e.ColumnIndex, e.RowIndex - 3));
                float resultValue = Convert.ToInt32(strapPivotControl1.GetCellValue(e.ColumnIndex, e.RowIndex - 2));
                if (orderValue == 0)
                {
                    e.DisplayText = "0";
                }
                else
                {
                    e.DisplayText = Math.Round((resultValue / orderValue * 100),2).ToString();

                }
                //e.DisplayText = "";
            }
            //if (Convert.ToSingle(e.Value) < 10)
            //    e.DisplayText = "Low";
            //else if (Convert.ToSingle(e.Value) > 20)
            //    e.DisplayText = "High";
            //else
            //    e.DisplayText = "Middle";
        }

        private void StrapPivotControl1_CustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e)
        {
            var aa = e.Field;
            //헤더 컬럼색상
            if (e.Area == DevExpress.XtraPivotGrid.PivotArea.ColumnArea && e.ValueType == DevExpress.XtraPivotGrid.PivotGridValueType.Value)
            {
                var a = ((DateTime)e.Value).DayOfWeek;
                if (a == DayOfWeek.Sunday || a == DayOfWeek.Saturday)
                {
                    e.Appearance.BackColor = Color.Red;
                    
                }
            }
        }

        private void StrapPivotControl1_CustomAppearance(object sender, PivotCustomAppearanceEventArgs e)
        {
            if (e.Value == null) return;
            //내용 
            if (e.DataField == fieldQTY1)
            {
                //달성률이 80%이하인 경우 빨간색
                string _type = strapPivotControl1.GetFieldValue(e.RowField, e.RowIndex).ToString();
                
                if (_type.Substring(0,1) == "4")
                {
                    try
                    {
                        decimal _Target = decimal.Parse(_type.Substring(_type.IndexOf('[') + 1, _type.IndexOf(']') - _type.IndexOf('[') - 1));
                        if (e.Value != null && (decimal)e.Value < _Target)
                        {
                            e.Appearance.ForeColor = Color.Red;
                        }
                    }
                    catch { }
                }
                //if (e.Value != null && (decimal)e.Value < 0)
                //{
                //    e.Appearance.ForeColor = Color.Red;
                //}
            }
        }

        private void StrapPivotControl1_CustomCellValue(object sender, PivotCellValueEventArgs e)
        {
         
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            strapPivotControl1.BestFitRowArea();
        }
    }
}

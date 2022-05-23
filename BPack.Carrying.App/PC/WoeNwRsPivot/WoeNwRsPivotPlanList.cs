using BPack.Model.App.PC.WoeNwRsPivot;
using BPack.Pocket.App.PC.WoeNwRsPivot;
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

namespace BPack.Carrying.App.PC.WoeNwRsPivot
{
    public partial class WoeNwRsPivotPlanList : StrapSubForm_Pivot
    {
        public event EventHandler<ArgsBase> UserCellClick;
        private WoeNwRsPivotArgs _woeNwRsPivotArgs;
        private WoeNwRsPivotPocket _woeNwRsPivotPocket;

        string trLang;
        public WoeNwRsPivotPlanList()
        {
            InitializeComponent();
        }

        public WoeNwRsPivotPlanList(WoeNwRsPivotArgs woeNwRsPivotArgs, WoeNwRsPivotPocket woeNwRsPivotPocket) :this()
        {
            this._woeNwRsPivotArgs = woeNwRsPivotArgs;
            this._woeNwRsPivotPocket = woeNwRsPivotPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitField(new FieldArgs_StrapSubForm_Pivot
            {
                BindingSource = nwRsPivotModelBindingSource,
                FormArgs = _woeNwRsPivotArgs,
                InitModelType = typeof(NwRsPivotModel),
                ModelArgs = _woeNwRsPivotArgs.WoeNwRsPivotModelArgs,
                PivotGridControl = strapPivotControl1
            });
            InitZipperDelegate<WoeNwRsPivotModelArgs, NwRsPivotModel>(_woeNwRsPivotPocket.SelectNwRsPivotModels, null);
            //strapPivotControl1.OptionsView.ShowColumnHeaders = false;
            strapPivotControl1.OptionsView.ShowDataHeaders = false;
            strapPivotControl1.OptionsView.ShowFilterHeaders = false;
            strapPivotControl1.OptionsView.ShowRowGrandTotals = false;
            strapPivotControl1.OptionsView.ShowRowTotals = false;
            //
            //PivotGridField fieldYear = new PivotGridField("WORK_DT", PivotArea.ColumnArea);
            //PivotGridField fieldMonth = new PivotGridField("WORK_DT", PivotArea.ColumnArea);
            //PivotGridField fieldWeek = new PivotGridField("WORK_DT", PivotArea.ColumnArea);

            //// Add the fields to the field collection.
            //strapPivotControl1.Fields.Add(fieldYear);
            //strapPivotControl1.Fields.Add(fieldMonth);
            //strapPivotControl1.Fields.Add(fieldWeek);
            //// Set the caption and group mode of the fields.
            //fieldYear.GroupInterval = PivotGroupInterval.DateYear;
            //fieldYear.Caption = "Year";
            //fieldYear.ExpandedInFieldsGroup = true;
            //fieldYear.AreaIndex = 0;
            //fieldMonth.GroupInterval = PivotGroupInterval.DateMonth;
            //fieldMonth.Caption = "Month";
            //fieldMonth.ExpandedInFieldsGroup = true;
            //fieldMonth.AreaIndex = 1;

            //fieldWeek.GroupInterval = PivotGroupInterval.DateWeekOfYear;
            //fieldWeek.Caption = "Week";
            //fieldWeek.ExpandedInFieldsGroup = true;
            //fieldWeek.AreaIndex = 2;

            //fieldWORKDT1.AreaIndex = 3;
            //





            foreach (DevExpress.XtraPivotGrid.PivotGridField item in strapPivotControl1.Fields)
            {
                trLang = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, item.Caption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    item.Caption = trLang;
                }
                item.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                //item.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
                //item.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            }
            strapPivotControl1.CustomCellValue += StrapPivotControl1_CustomCellValue;
            strapPivotControl1.CustomAppearance += StrapPivotControl1_CustomAppearance;
            strapPivotControl1.CustomDrawFieldValue += StrapPivotControl1_CustomDrawFieldValue;
            strapPivotControl1.CustomCellDisplayText += StrapPivotControl1_CustomCellDisplayText;

            strapPivotControl1.BestFit();

        }

        private void StrapPivotControl1_CustomCellDisplayText(object sender, PivotCellDisplayTextEventArgs e)
        {
            if (e.Value == null) return;
            if (e.ColumnValueType != PivotGridValueType.GrandTotal) return;

        }

        private void StrapPivotControl1_CustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e)
        {
            var aa = e.Field;
            //헤더 컬럼색상
            try
            {
                if (e.Area == DevExpress.XtraPivotGrid.PivotArea.ColumnArea && e.ValueType == DevExpress.XtraPivotGrid.PivotGridValueType.Value)
                {
                    if (DateTime.TryParse(e.Value.ToString(), out DateTime _value))
                    {
                        if (_value.DayOfWeek == DayOfWeek.Sunday || _value.DayOfWeek == DayOfWeek.Saturday)
                        {
                            e.Appearance.BackColor = Color.Red;

                        }
                    }

                    //var a = ((DateTime)e.Value).DayOfWeek;
                    //if (a == DayOfWeek.Sunday || a == DayOfWeek.Saturday)
                    //{
                    //    e.Appearance.BackColor = Color.Red;

                    //}
                }
            }
            catch { }
        }

        private void StrapPivotControl1_CustomAppearance(object sender, PivotCustomAppearanceEventArgs e)
        {
            if (e.Value == null) return;
        }

        private void StrapPivotControl1_CustomCellValue(object sender, PivotCellValueEventArgs e)
        {
            
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            switch (_woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_SearchType)
            {
                case "DAY":
                    fieldWORKDT1.Visible = true;
                    fieldWEEKCD.Visible = true;
                    break;
                case "WEEK":
                    fieldWORKDT1.Visible = false;
                    fieldWEEKCD.Visible = true;
                    break;
                case "MONTH":
                    fieldWORKDT1.Visible = false;
                    fieldWEEKCD.Visible = false;

                    break;
            }
            if (_woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_SearchType == "WEEK")
            {
                
            }

            strapPivotControl1.BestFit();
            //strapPivotControl1.BestFitRowArea();
            //strapPivotControl1.BestFitColumnArea();

            //strapPivotControl1.BestFitDataHeaders(true);
        }

        private void strapPivotControl1_CellClick(object sender, PivotCellEventArgs e)
        {
            if (e.ColumnField == null) return;
            switch (_woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_SearchType)
            {
                case "DAY":
                    if (e.ColumnField.Name == "fieldWORKDT1")
                    {
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Wc_Cd
                            = e.GetFieldValue(fieldWCCD1).ToString();
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Year_Cd
                            = int.Parse(e.GetFieldValue(fieldYEAR).ToString());
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Month_Cd
                            = int.Parse(e.GetFieldValue(fieldMONTHCD).ToString());
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Week_Cd
                            = int.Parse(e.GetFieldValue(fieldWEEKCD).ToString());
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Work_dt
                            = DateTime.Parse(e.GetFieldValue(fieldWORKDT1).ToString());

                        UserCellClick?.Invoke(this, _woeNwRsPivotArgs);
                    }
                    break;
                case "WEEK":
                    if (e.ColumnField.Name == "fieldWEEKCD")
                    {
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Wc_Cd
                            = e.GetFieldValue(fieldWCCD1).ToString();
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Year_Cd
                            = int.Parse(e.GetFieldValue(fieldYEAR).ToString());
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Month_Cd
                            = int.Parse(e.GetFieldValue(fieldMONTHCD).ToString());
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Week_Cd
                            = int.Parse(e.GetFieldValue(fieldWEEKCD).ToString());
                        //의미없는데이터 오류안나도록하기위해서
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Work_dt
                            = DateTime.Now;

                        UserCellClick?.Invoke(this, _woeNwRsPivotArgs);
                    }
                    break;
                case "MONTH":
                    if (e.ColumnField.Name == "fieldMONTHCD")
                    {
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Wc_Cd
                            = e.GetFieldValue(fieldWCCD1).ToString();
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Year_Cd
                            = int.Parse(e.GetFieldValue(fieldYEAR).ToString());
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Month_Cd
                            = int.Parse(e.GetFieldValue(fieldMONTHCD).ToString());
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Week_Cd
                            = 0;
                        _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Work_dt
                            = DateTime.Now;

                        UserCellClick?.Invoke(this, _woeNwRsPivotArgs);
                    }
                    break;
            }


            //if (e.ColumnField.Name == "fieldWORKDT1")
            //{
            //    _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Wc_Cd
            //        = e.GetFieldValue(fieldWCCD1).ToString();
            //    _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Year_Cd 
            //        = int.Parse( e.GetFieldValue(fieldYEAR).ToString());
            //    _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Month_Cd 
            //        = int.Parse( e.GetFieldValue(fieldMONTHCD).ToString());
            //    _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Week_Cd
            //        = int.Parse( e.GetFieldValue(fieldWEEKCD).ToString());
            //    _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Sub_Work_dt
            //        = DateTime.Parse(e.GetFieldValue(fieldWORKDT1).ToString());

            //    UserCellClick?.Invoke(this, _woeNwRsPivotArgs);
            //}

        }
    }
}

using BPack.Model.App.PC.WoeBadRsPivot;
using BPack.Pocket.App.PC.WoeBadRsPivot;
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

namespace BPack.Carrying.App.PC.WoeBadRsPivot
{
    public partial class WoeBadRsPivotList : StrapSubForm_Pivot
    {
        public event EventHandler<ArgsBase> UserCellClick;
        private WoeBadRsPivotArgs _woeBadRsPivotArgs;
        private WoeBadRsPivotPocket _woeBadRsPivotPocket;

        string trLang;
        public WoeBadRsPivotList()
        {
            InitializeComponent();
        }

        public WoeBadRsPivotList(WoeBadRsPivotArgs woeBadRsPivotArgs, WoeBadRsPivotPocket woeBadRsPivotPocket):this()
        {
            this._woeBadRsPivotArgs = woeBadRsPivotArgs;
            this._woeBadRsPivotPocket = woeBadRsPivotPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitField(new FieldArgs_StrapSubForm_Pivot
            {
                BindingSource = badRsPivotModelBindingSource,
                FormArgs = _woeBadRsPivotArgs,
                InitModelType = typeof(BadRsPivotModel),
                ModelArgs = _woeBadRsPivotArgs.WoeBadRsPivotModelArgs,
                PivotGridControl = strapPivotControl1
            });
            InitZipperDelegate<WoeBadRsPivotModelArgs, BadRsPivotModel>(_woeBadRsPivotPocket.SelectBadRsPivotModels, null);
            strapPivotControl1.OptionsView.ShowDataHeaders = false;
            strapPivotControl1.OptionsView.ShowFilterHeaders = false;
            strapPivotControl1.OptionsView.ShowRowGrandTotals = false;
            strapPivotControl1.OptionsView.ShowRowTotals = false;
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
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            switch (_woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_SearchType)
            {
                case "DAY":
                    fieldWORKDT1.Visible = true;
                    fieldWEEKCD1.Visible = true;
                    break;
                case "WEEK":
                    fieldWORKDT1.Visible = false;
                    fieldWEEKCD1.Visible = true;
                    break;
                case "MONTH":
                    fieldWORKDT1.Visible = false;
                    fieldWEEKCD1.Visible = false;

                    break;
            }
            if (_woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_SearchType == "WEEK")
            {

            }

            strapPivotControl1.BestFit();
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
            if (e.ColumnValueType == PivotGridValueType.GrandTotal)
            {
                e.DisplayText = "";
            }

            if (e.ColumnValueType != PivotGridValueType.Total) return;
            //달성률인경우 그랜드 토탈 에서 안보이도록
            if (strapPivotControl1.GetFieldValue(e.RowField, e.RowIndex).ToString().Substring(0, 1) == "4")
            {
                try
                {
                    int _ColumnIndex = e.ColumnIndex;
                    int _RowIndex = e.RowIndex;
                    float sumValue = Convert.ToInt32(strapPivotControl1.GetCellValue(e.ColumnIndex, e.RowIndex - 3));
                    float badValue = Convert.ToInt32(strapPivotControl1.GetCellValue(e.ColumnIndex, e.RowIndex - 1));
                    if (sumValue == 0)
                    {
                        e.DisplayText = "0";
                    }
                    else
                    {
                        e.DisplayText = Math.Ceiling(badValue / sumValue * 100).ToString() + " %";

                    }
                }
                catch
                {
                    e.DisplayText="";
                }
            }
        }

        private void StrapPivotControl1_CustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e)
        {
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
            
        }

        private void StrapPivotControl1_CustomCellValue(object sender, PivotCellValueEventArgs e)
        {
            if (e.Value == null) return;
        }

        private void strapPivotControl1_CellClick(object sender, PivotCellEventArgs e)
        {
            try
            {
                if (e.ColumnField == null) return;
                if (e.ColumnValueType == PivotGridValueType.Total)
                {
                    _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Wc_Cd
                                = null;
                    _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Year_Cd
                        = int.Parse(e.GetFieldValue(fieldYEAR1).ToString());
                    _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Month_Cd
                        = int.Parse(e.GetFieldValue(fieldMONTHCD1).ToString());
                    _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Week_Cd
                        = int.Parse(e.GetFieldValue(fieldWEEKCD1).ToString());
                    _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Work_dt
                        = null;
                    _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Item_Cd
                        = e.GetFieldValue(fieldITEMCD1).ToString();
                    UserCellClick?.Invoke(this, _woeBadRsPivotArgs);
                }
                else
                {
                    switch (_woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_SearchType)
                    {
                        case "DAY":
                            if (e.ColumnField.Name == "fieldWORKDT1")
                            {
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Wc_Cd
                                    = e.GetFieldValue(fieldWCCD1).ToString();
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Year_Cd
                                    = int.Parse(e.GetFieldValue(fieldYEAR1).ToString());
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Month_Cd
                                    = int.Parse(e.GetFieldValue(fieldMONTHCD1).ToString());
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Week_Cd
                                    = int.Parse(e.GetFieldValue(fieldWEEKCD1).ToString());
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Work_dt
                                    = DateTime.Parse(e.GetFieldValue(fieldWORKDT1).ToString());
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Item_Cd
                                    = e.GetFieldValue(fieldITEMCD1).ToString();
                                UserCellClick?.Invoke(this, _woeBadRsPivotArgs);
                            }
                            break;
                        case "WEEK":
                            if (e.ColumnField.Name == "fieldWEEKCD1")
                            {
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Wc_Cd
                                    = e.GetFieldValue(fieldWCCD1).ToString();
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Year_Cd
                                    = int.Parse(e.GetFieldValue(fieldYEAR1).ToString());
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Month_Cd
                                    = int.Parse(e.GetFieldValue(fieldMONTHCD1).ToString());
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Week_Cd
                                    = int.Parse(e.GetFieldValue(fieldWEEKCD1).ToString());

                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Work_dt
                                    = DateTime.Now;
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Item_Cd
                                    = e.GetFieldValue(fieldITEMCD1).ToString();
                                UserCellClick?.Invoke(this, _woeBadRsPivotArgs);
                            }
                            break;
                        case "MONTH":
                            if (e.ColumnField.Name == "fieldMONTHCD1")
                            {
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Wc_Cd
                                    = e.GetFieldValue(fieldWCCD1).ToString();
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Year_Cd
                                    = int.Parse(e.GetFieldValue(fieldYEAR1).ToString());
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Month_Cd
                                    = int.Parse(e.GetFieldValue(fieldMONTHCD1).ToString());
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Week_Cd
                                    = 0;
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Work_dt
                                    = DateTime.Now;
                                _woeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Item_Cd
                                    = e.GetFieldValue(fieldITEMCD1).ToString();
                                UserCellClick?.Invoke(this, _woeBadRsPivotArgs);
                            }
                            break;
                    }
                }
            }
            catch
            { 
               
            }
        }
    }
}

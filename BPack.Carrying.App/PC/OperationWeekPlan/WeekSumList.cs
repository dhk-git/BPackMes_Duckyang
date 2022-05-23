using BPack.Common.LoginInfo;
using BPack.Model.Annotation.Common;
using BPack.Model.App.PC.OperationWeekPlan;
using BPack.Pocket.App.PC.OperationWeekPlan;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows;

namespace BPack.Carrying.App.PC.OperationWeekPlan
{
    public partial class WeekSumList : StrapSubForm_Empty
    {
        private OperationWeekPlanArgs _monthPlanArgs;
        private OperationWeekPlanPocket _monthPlanPocket;

        private List<WeekPlanGrModel> HearderModel;
        DataTable ModelTable;
        DataTable OriginModel;
        DataTable ChangedModel;
        DataTable DetailGrModel_DataTable = new DataTable();

        string trLang;

        public WeekSumList()
        {
            InitializeComponent();
        }

        public WeekSumList(OperationWeekPlanArgs monthPlanArgs, OperationWeekPlanPocket monthPlanPocket) : this()
        {
            this._monthPlanArgs = monthPlanArgs;
            this._monthPlanPocket = monthPlanPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            gridView1.OptionsView.ColumnAutoWidth = false;
            InitColumns();
            gridView1.RowCellStyle += GridView1_RowCellStyle;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void InitColumns()
        {
            gridView1.Columns.Clear();
            ModelTable = new DataTable();
            DataColumn dtCol;
            //_dynamicStrapDataColumns = new List<DataColumn>();
            foreach (var prop in typeof(WeekPlanGrModel).GetProperties())
            {
                dtCol = new DataColumn();
                dtCol.ColumnName = prop.Name;
                dtCol.Caption = ((DisplayAttribute)prop.GetCustomAttributes(false).Where(a => a.GetType() == typeof(DisplayAttribute)).SingleOrDefault())?.Name;
                //2022.03.17 정수교 언어변환 
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, dtCol.Caption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    dtCol.Caption = trLang;
                }

                dtCol.DataType = prop.PropertyType;
                dtCol.ReadOnly = true;
                ModelTable.Columns.Add(dtCol);
            }

            dtCol = new DataColumn();
            dtCol.ColumnName = "PlanType";
            dtCol.Caption = "Type";
            dtCol.DataType = typeof(string);
            dtCol.ReadOnly = true;
            ModelTable.Columns.Add(dtCol);

            var _rows = from rows in DetailGrModel_DataTable.AsEnumerable()
                        group rows by new { SUM_COL_CD = rows.Field<string>("SUM_COL_CD"), SUM_COL_NM = rows.Field<string>("SUM_COL_NM") } into g
                        select new
                        {
                            SUM_COL_CD = g.Key.SUM_COL_CD
                            ,
                            SUM_COL_NM = g.Key.SUM_COL_NM
                        };
            foreach (var row in _rows)
            {
                dtCol = new DataColumn();
                dtCol.ColumnName = row.SUM_COL_CD;
                dtCol.Caption = row.SUM_COL_NM;
                dtCol.DataType = typeof(int);
                dtCol.ReadOnly = true;
                ModelTable.Columns.Add(dtCol);
            }

            strapGridControl1.DataSource = ModelTable;
            foreach (GridColumn col in gridView1.Columns)
            {
                var prop = typeof(WeekPlanGrModel).GetProperty(col.FieldName);
                if (prop != null)
                {
                    if (prop.GetCustomAttributes(false)
                    .Where(a => a.GetType() == typeof(StrapHiddenAttribute)).SingleOrDefault() != null ||
                    ((StrapVisibleAttribute)prop.GetCustomAttributes(false)
                    .Where(a => a.GetType() == typeof(StrapVisibleAttribute)).SingleOrDefault())?.WhenRead == false ||
                    col.FieldName.Equals("IsCheck")
                    )
                    {
                        col.Visible = false;
                    }
                    else
                    {
                        col.Fixed = FixedStyle.Left;
                        col.OptionsColumn.AllowEdit = false;
                    }
                    //2022.05.05 품목유형분류 숨김
                    if (col.FieldName.Equals("ITEM_TYPE_CLS"))
                    {
                        col.Visible = false;
                    }
                }
                else
                {
                    //합계

                    //DevExpress.XtraGrid.GridColumnSummaryItem gridColumnSummaryItem = new DevExpress.XtraGrid.GridColumnSummaryItem();
                    //gridColumnSummaryItem.FieldName = col.FieldName;
                    //gridColumnSummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    //gridColumnSummaryItem.DisplayFormat = "{0:#,##0}";
                    //col.Summary.Add(gridColumnSummaryItem);
                }
                col.AppearanceHeader.Options.UseTextOptions = true;
                col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                var propType = col.ColumnType;
                if (propType == typeof(decimal) || propType == typeof(float) || propType == typeof(int)
                    || propType == typeof(decimal?) || propType == typeof(float?) || propType == typeof(int?))
                {
                    col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    col.DisplayFormat.FormatString = "#,##0";
                }
                //열고정
                //if (col.FieldName == "Last_Year")
                //{
                //    col.Fixed = FixedStyle.Left;
                //}

                gridView1.BestFitColumns();
            }

        }

        public override void DataRefresh(ArgsBase args)
        {
            OriginModel = _monthPlanPocket.SelectWeekPlanDetailSumModel(((OperationWeekPlanArgs)args).OperationWeekPlanModelArgs);
        }
        public override void ExcelExport(ArgsBase args)
        {
            try
            {
                Strap.FormControls.CommonLib.ExcelExport_GridView excelExport = new Strap.FormControls.CommonLib.ExcelExport_GridView();
                excelExport.Export(gridView1, this.LayoutControlGroup.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        private void DataRefreshByList()
        {
            
            InitColumns();

            ModelTable.Rows.Clear();
            foreach (var model in HearderModel)
            {
                var row = ModelTable.NewRow();
                var Chagnedrow = ModelTable.NewRow();
                foreach (var prop in model.GetType().GetProperties())
                {
                    row.SetField(prop.Name, prop.GetValue(model));
                    Chagnedrow.SetField(prop.Name, prop.GetValue(model));
                }

                //원본
                row.SetField("PlanType", "YearPlan");
                Chagnedrow.SetField("PlanType", "MonthPlan");
                var Originrow = from rows in OriginModel.AsEnumerable().Where(v => v["YEAR_CD"].ToString() == model.YEAR_CD && v["ITEM_CD"].ToString() == model.ITEM_CD)
                                group rows by new { SUM_COL_CD = rows.Field<string>("SUM_COL_CD") } into g
                                select new
                                {
                                    SUM_COL_CD = g.Key.SUM_COL_CD
                                    ,
                                    PLAN_QTY = g.Sum(order => Convert.ToInt32(order.Field<string>("PLAN_QTY")))
                                };
                foreach (var col in Originrow)
                {
                    row.SetField(col.SUM_COL_CD, col.PLAN_QTY);
                }


                ModelTable.Rows.Add(row);

                var ChangeRows = from rows in ChangedModel.AsEnumerable().Where(v => v["YEAR_CD"].ToString() == model.YEAR_CD && v["ITEM_CD"].ToString() == model.ITEM_CD)
                                 group rows by new { SUM_COL_CD = rows.Field<string>("SUM_COL_CD") } into g
                                 select new
                                 {
                                     SUM_COL_CD = g.Key.SUM_COL_CD
                                     ,
                                     PLAN_QTY = g.Sum(order => Convert.ToInt32(order.Field<string>("PLAN_QTY")))
                                 };
                foreach (var col in ChangeRows)
                {
                    Chagnedrow.SetField(col.SUM_COL_CD, col.PLAN_QTY);
                }
                ModelTable.Rows.Add(Chagnedrow);
                
                strapGridControl1.DataSource = ModelTable;

                gridView1.BestFitColumns();


            }
        }
        private void GridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {

            //try
            //{
                var gridRow = gridView1.GetRow(e.RowHandle) as DataRowView;
                if (gridRow == null) return;
                var CellName = e.Column.FieldName;
                var CellType = gridRow["PlanType"].ToString();
                var CellWeekValue = 0;
                var CellMonthValue = 0;

                if (CellType == "YearPlan")
                {
                    e.Appearance.BackColor = Color.DarkGray;
                }
                else if (CellType == "MonthPlan" && CellName.Substring(CellName.Length - 2) == "MM")
                {
                    CellWeekValue = int.Parse(gridView1.GetRowCellValue(e.RowHandle, e.Column).ToString());
                    CellMonthValue = int.Parse(gridView1.GetRowCellValue(e.RowHandle - 1, e.Column).ToString());
                    //월간계획이 YearPlan 보다 큰경우
                    if (CellWeekValue > CellMonthValue)
                    {
                        e.Appearance.BackColor = Color.Red;
                    }
                    else if (CellWeekValue < CellMonthValue)
                    {
                        //월간계획이 YearPlan 보다 작은경우
                        e.Appearance.BackColor = Color.Yellow;

                    }

                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            //}
        }

        internal void ChangeModel(WeekPlanSumModel SumModel)
        {
            HearderModel = SumModel.headerGrModel;
            DetailGrModel_DataTable = SumModel.DetailGrModel_DataTable;
            ChangedModel = SumModel.ChangedModel;
            gridView1.BeginUpdate();
            ModelTable.BeginLoadData();
            DataRefreshByList();
            ModelTable.EndLoadData();
            gridView1.EndUpdate();
        }


    }
}

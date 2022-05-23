using BPack.Common.LoginInfo;
using BPack.Model.Annotation.Common;
using BPack.Model.App.PC.WoeRsPivotYearPlan;
using BPack.Pocket.App.PC.WoeRsPivotYearPlan;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.WoeRsPivotYearPlan
{
    public partial class WoeRsPivotYearPlanList : StrapSubForm_Empty
    {
        private WoeRsPivotYearPlanArgs _planModelArgs;
        private WoeRsPivotYearPlanPocket _planPocket;
        

        DataTable ModelTable;
        List<YearPlanGrModel> HearderModel;
        DataTable DetailModel_DataTable = new DataTable();
        DataTable ORiginDetailModel = new DataTable();

        List<YearPlanGrModel> SumModel;

        string trLang;

        public WoeRsPivotYearPlanList()
        {
            InitializeComponent();
        }

        public WoeRsPivotYearPlanList(WoeRsPivotYearPlanArgs planModelArgs, WoeRsPivotYearPlanPocket planPocket):this()
        {
            this._planModelArgs = planModelArgs;
            this._planPocket = planPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            gridView1.OptionsView.ColumnAutoWidth = false;
            InitColumns();
            //_isInit = false;
            //gridView1.CellValueChanged += GridView1_CellValueChanged;
            //gridView1.RowCellStyle += GridView1_RowCellStyle;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void InitColumns()
        {
            try
            {
                gridView1.Columns.Clear();
                ModelTable = new DataTable();
                DataColumn dtCol;

                foreach (var prop in typeof(YearPlanGrModel).GetProperties())
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
                for (int i = 1; i <= 12; i++)
                {
                    dtCol = new DataColumn();
                    dtCol.ColumnName = _planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plan_Year_cd
                                                    + "-" + i.ToString().PadLeft(2, '0');
                    dtCol.Caption = _planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plan_Year_cd
                                                                    + "-" + i.ToString().PadLeft(2, '0');
                    dtCol.DataType = typeof(int);
                    ModelTable.Columns.Add(dtCol);

                }
                strapGridControl1.DataSource = ModelTable;
                foreach (GridColumn col in gridView1.Columns)
                {
                    var prop = typeof(YearPlanGrModel).GetProperty(col.FieldName);
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
                }

                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }

        }

        public override void DataRefresh(ArgsBase args)
        {
            try
            {
                HearderModel
                    = _planPocket.SelectRsYearPlanGrModel(_planModelArgs.WoeRsPivotYearPlanModelArgs);

                DetailModel_DataTable = _planPocket.SelectRsYearPlanModel_DataTable(_planModelArgs.WoeRsPivotYearPlanModelArgs);
                SumModel = _planPocket.SelectRsYearPlanGrSumModel(_planModelArgs.WoeRsPivotYearPlanModelArgs);
                ORiginDetailModel = DetailModel_DataTable.Copy();


                DataRefreshByList(HearderModel, DetailModel_DataTable, SumModel, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        private void DataRefreshByList(List<YearPlanGrModel> hearderModel, DataTable detailModel_DataTable, List<YearPlanGrModel> SumModel, bool _refreshColumn)
        {
            try
            {
                if (_refreshColumn)
                {
                    InitColumns();
                }
                ModelTable.Rows.Clear();
                foreach (var model in HearderModel)
                {
                    var row = ModelTable.NewRow();

                    //좌측
                    foreach (var prop in model.GetType().GetProperties())
                    {
                        row.SetField(prop.Name, prop.GetValue(model));
                    }

                    var FilterRow = DetailModel_DataTable.AsEnumerable().Where(a => a["ITEM_CD"].ToString() == model.ITEM_CD
                                 && a["YEAR_CD"].ToString() == model.YEAR_CD
                                );

                    foreach (var dmodel in FilterRow)
                    {
                        switch (row["YEAR_SNOP_TYPE"].ToString())
                        {
                            case "SP": //판매계획
                                row.SetField(dmodel["YEAR_CD"].ToString() + "-" + dmodel["MONTH_CD"].ToString(), dmodel["SP_PLAN_QTY"].ToString());
                                break;
                            case "PP"://생산계획
                                row.SetField(dmodel["YEAR_CD"].ToString() + "-" + dmodel["MONTH_CD"].ToString(), dmodel["PP_PLAN_QTY"].ToString());
                                break;
                            case "PR":
                                row.SetField(dmodel["YEAR_CD"].ToString() + "-" + dmodel["MONTH_CD"].ToString(), dmodel["RST_QTY"].ToString());
                                break;
                        }
                    }
                    
                    ModelTable.Rows.Add(row);
                }
                var DetailSumModel = from b in DetailModel_DataTable.AsEnumerable()
                                     group b by new { YEAR_CD = b.Field<string>("YEAR_CD"), MONTH_CD = b.Field<string>("MONTH_CD") } into g
                                     select new
                                     {
                                         YEAR_CD = g.Key.YEAR_CD
                                         ,
                                         MONTH_CD = g.Key.MONTH_CD
                                         ,
                                         PP_PLAN_QTY = g.Sum(order => Convert.ToInt32(order.Field<string>("PP_PLAN_QTY")))
                                         ,
                                         SP_PLAN_QTY = g.Sum(order => Convert.ToInt32(order.Field<string>("SP_PLAN_QTY")))
                                         ,
                                         RST_QTY = g.Sum(order => Convert.ToInt32(order.Field<string>("RST_QTY")))
                                     };
                if (DetailSumModel.Count() > 1)
                {
                    //합계
                    foreach (var model in SumModel)
                    {
                        var row = ModelTable.NewRow();
                        //좌측
                        foreach (var prop in model.GetType().GetProperties())
                        {
                            row.SetField(prop.Name, prop.GetValue(model));
                        }
                       

                        for (int i = 1; i <= 12; i++)
                        {
                            switch (row["YEAR_SNOP_TYPE"].ToString())
                            {
                                case "SP": //판매계획
                                    var SP_Month_Value = DetailSumModel
                                    .Where(v => int.Parse(v.YEAR_CD) == int.Parse(_planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plan_Year_cd)
                                    && v.MONTH_CD == i.ToString().PadLeft(2, '0')).Select(v => v.SP_PLAN_QTY).Single();
                                    row.SetField(_planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plan_Year_cd
                                                        + "-" + i.ToString().PadLeft(2, '0')
                                        , SP_Month_Value);
                                    break;
                                case "PP"://생산계획
                                    var PP_Month_Value = DetailSumModel
                                    .Where(v => int.Parse(v.YEAR_CD) == int.Parse(_planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plan_Year_cd)
                                    && v.MONTH_CD == i.ToString().PadLeft(2, '0')).Select(v => v.PP_PLAN_QTY).Single();
                                    row.SetField(_planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plan_Year_cd
                                                        + "-" + i.ToString().PadLeft(2, '0')
                                        , PP_Month_Value);
                                    break;
                                case "PR": //생산실적
                                    var RST_Month_Value = DetailSumModel
                                    .Where(v => int.Parse(v.YEAR_CD) == int.Parse(_planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plan_Year_cd)
                                    && v.MONTH_CD == i.ToString().PadLeft(2, '0')).Select(v => v.RST_QTY).Single();
                                    row.SetField(_planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plan_Year_cd
                                                        + "-" + i.ToString().PadLeft(2, '0')
                                        , RST_Month_Value);
                                    break;
                            }

                        }

                        ModelTable.Rows.Add(row);
                    }
                }

                strapGridControl1.DataSource = ModelTable;
                gridView1.BestFitColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                e.Cancel = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }

            
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var gridRow = gridView1.GetRow(e.RowHandle) as DataRowView;
                if (gridRow == null) return;

                var CellItem = gridRow["ITEM_CD"].ToString();
                if (CellItem == "SUM")
                {
                    e.Appearance.BackColor = Color.DarkGray;
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            try
            {
                if (e.Column.FieldName == "YEAR_CD"
                    || e.Column.FieldName == "ITEM_TYPE_NM"
                    || e.Column.FieldName == "ITEM_GR_NM"
                    || e.Column.FieldName == "ITEM_CD"
                    || e.Column.FieldName == "ITEM_NM"
                    ) // Merge할 Cell의 Column FieldName 확인
                {
                    string class1 = view.GetRowCellValue(e.RowHandle1, "ITEM_CD").ToString();
                    string class2 = view.GetRowCellValue(e.RowHandle2, "ITEM_CD").ToString();
                    string value1 = view.GetRowCellValue(e.RowHandle1, e.Column).ToString();
                    string value2 = view.GetRowCellValue(e.RowHandle2, e.Column).ToString();

                    e.Merge = (class1 == class2) && (value1 == value2); // 응용으로, 위의 Class 속성이 같으면서 값이 같은 것들만 Merge하도록 제어
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Merge = false;
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }
    }
}

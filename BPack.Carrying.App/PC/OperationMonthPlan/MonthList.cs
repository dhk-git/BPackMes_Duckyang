using BPack.Carrying.App.SD.DlvPlan;
using BPack.Common.LoginInfo;
using BPack.Model.Annotation.Common;
using BPack.Model.App.PC.OperationMonthPlan;
using BPack.Pocket.App.PC.OperationMonthPlan;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BPack.Carrying.App.PC.OperationMonthPlan
{
    public partial class MonthList : StrapSubForm_Empty
    {
        OperationMonthPlanArgs _monthPlanArgs;
        OperationMonthPlanPocket _monthPlanPocket;
        DataTable ModelTable;
        private List<DataColumn> _dynamicStrapDataColumns;
        //private bool _isInit;

        List<MonthPlanGrModel> HearderModel;
        //List<MonthPlan> DetailModel;

        DataTable DetailModel_DataTable = new DataTable();
        DataTable ORiginDetailModel = new DataTable();

        List<MonthPlanGrModel> SumModel;
        const string DATE_FORMAT = "yyyy-M";

        string trLang;

        public MonthList()
        {
            InitializeComponent();
        }

        public MonthList(OperationMonthPlanArgs operationMonthPlanArgs, OperationMonthPlanPocket operationMonthPlanPocket)
            : this()
        {
            _monthPlanArgs = operationMonthPlanArgs;
            _monthPlanPocket = operationMonthPlanPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            gridView1.OptionsView.ColumnAutoWidth = false;
            InitColumns();
            //_isInit = false;
            gridView1.CellValueChanged += GridView1_CellValueChanged;
            gridView1.RowCellStyle += GridView1_RowCellStyle;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
        }

        public override void DataRefresh(ArgsBase args)
        {
            try
            {

                HearderModel
                    = _monthPlanPocket.SelectMonthPlanGrModel(_monthPlanArgs.OperationMonthPlanModelArgs);

              

                DetailModel_DataTable = _monthPlanPocket.SelectMonthPlanModel_DataTable(_monthPlanArgs.OperationMonthPlanModelArgs);
                SumModel = _monthPlanPocket.SelectMonthPlanGrSumModel(_monthPlanArgs.OperationMonthPlanModelArgs);
                ORiginDetailModel = DetailModel_DataTable.Copy();
                DataRefreshByList(HearderModel, DetailModel_DataTable, SumModel, true);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }
        public override void Save(ArgsBase args)
        {
            //base.Save(args);
            if (StrapMessageBox.Show("A001", 33, MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                List<MonthPlan> monthPlans = new List<MonthPlan>();

                foreach (var row in DetailModel_DataTable.AsEnumerable().Where( v=> v["MOD_YN"].ToString()=="Y"))
                {
                    monthPlans.Add(
                        new MonthPlan()
                        { 
                         COMP_CD= _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Comp_Cd
                         ,PLANT_CD= _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plant_Cd
                         , CREATE_DTTM=DateTime.Now
                         ,MODIFY_DTTM=DateTime.Now
                         ,CREATE_USER_ID=UserInfo.UserID
                         , MODIFY_USER_ID=UserInfo.UserID
                         , LANG_CODE=UserInfo.Sys_Language
                         , SNOP_NO=row["SNOP_NO"].ToString()
                         , IP_PLAN_QTY=decimal.Parse( row["IP_PLAN_QTY"].ToString())
                         , PP_PLAN_QTY= decimal.Parse(row["PP_PLAN_QTY"].ToString())
                         , SP_PLAN_QTY= decimal.Parse(row["SP_PLAN_QTY"].ToString())
                        } );;
                }

                _monthPlanPocket.SaveMonthPlanModel(monthPlans);
                DataRefresh(_monthPlanArgs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
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

        private void InitColumns()
        {
            try
            {
                gridView1.Columns.Clear();
                ModelTable = new DataTable();
                DataColumn dtCol;
                _dynamicStrapDataColumns = new List<DataColumn>();
                foreach (var prop in typeof(MonthPlanGrModel).GetProperties())
                {
                    dtCol = new StrapDataColumn();
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

                dtCol = new StrapDataColumn();
                dtCol.ColumnName = "Last_Year";
                dtCol.Caption = "기말재고";
                //2022.03.17 정수교 언어변환 
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, dtCol.Caption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    dtCol.Caption = trLang;
                }

                dtCol.DataType = typeof(int);
                //dtCol.IsDynamicColumn = true;

                ModelTable.Columns.Add(dtCol);
                _dynamicStrapDataColumns.Add(dtCol);


                for (int i = 1; i <= 12; i++)
                {
                    dtCol = new StrapDataColumn();
                    dtCol.ColumnName = _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd
                                                    + "-" + i.ToString().PadLeft(2, '0');
                    dtCol.Caption = _monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd
                                                                    + "-" + i.ToString().PadLeft(2, '0');
                    dtCol.DataType = typeof(int);
                    //dtCol.IsDynamicColumn = true;
                    ModelTable.Columns.Add(dtCol);
                    _dynamicStrapDataColumns.Add(dtCol);
                }

                strapGridControl1.DataSource = ModelTable;


                foreach (GridColumn col in gridView1.Columns)
                {
                    var prop = typeof(MonthPlanGrModel).GetProperty(col.FieldName);
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
                    if (col.FieldName == "Last_Year")
                    {
                        col.Fixed = FixedStyle.Left;
                    }
                }


                //if (_isInit)
                //{
                gridView1.BestFitColumns();
                //}
            }
            catch(Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        private void GridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                var gridRow = gridView1.GetRow(e.RowHandle) as DataRowView;

                if (gridRow == null) return;

                var CellItem = gridRow["ITEM_CD"].ToString();
                var CellSNOP_TYPE = gridRow["SNOP_TYPE"].ToString();
                var CellValue = gridView1.GetRowCellValue(e.RowHandle, e.Column);

                if (CellValue == null || CellValue.ToString() == "")
                {
                    CellValue = 0;
                }

                var CellName = e.Column.FieldName;
                var CellYear_cd = "";
                var CellMonth_cd = "";

                DateTime CulSelectDt;

                if (DateTime.TryParse(CellName, out CulSelectDt))
                {
                    CellYear_cd = CulSelectDt.Year.ToString().PadLeft(4, '0');
                    CellMonth_cd = CulSelectDt.Month.ToString().PadLeft(2, '0');
                }

                if (CellItem == "SUM")
                {
                    e.Appearance.BackColor = Color.DarkGray;
                }
                else
                {
                    if (CellYear_cd != "" && CellMonth_cd != "")
                    {
                        int IntValue;
                        int.TryParse(ORiginDetailModel.AsEnumerable()
                            .Where(v => v["ITEM_CD"].ToString() == CellItem
                                   && v["YEAR_CD"].ToString() == CellYear_cd
                                   && v["MONTH_CD"].ToString() == CellMonth_cd
                            ).Single()[CellSNOP_TYPE + "_PLAN_QTY"].ToString(), out IntValue);

                        if (IntValue != int.Parse(CellValue.ToString()))
                        {
                            e.Appearance.BackColor = Color.Red;
                            if (int.Parse(CellValue.ToString()) < 0)
                            {
                                e.Appearance.ForeColor = Color.Yellow;
                            }
                        }

                        //확정인 경우 수정 불가 색상
                        var SNOP_STATUS = ORiginDetailModel.AsEnumerable()
                           .Where(v => v["YEAR_CD"].ToString() == CellYear_cd
                                       && v["ITEM_CD"].ToString() == CellItem
                                       && v["MONTH_CD"].ToString() == CellMonth_cd)
                           .Select(v => v["SNOP_STATUS"]).Single().ToString();

                        if (SNOP_STATUS == "CLOSE")
                        {
                            e.Appearance.BackColor = Color.DarkGray;
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }

           

        }

        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                var focusedRowHandle = gridView1.FocusedRowHandle;
                gridView1.BeginUpdate();
                ModelTable.BeginLoadData();
                var gridRow = gridView1.GetRow(e.RowHandle) as DataRowView;
                var CellValue = gridView1.GetRowCellValue(e.RowHandle, e.Column);

                if (CellValue.ToString() == "")
                {
                    CellValue = 0;
                }

                var CellName = e.Column.FieldName;
                var CellMonth_cd = "";

                DateTime CulSelectDt;

                if (DateTime.TryParse(CellName, out CulSelectDt))
                {
                    CellMonth_cd = CulSelectDt.Month.ToString().PadLeft(2, '0');
                }

                var SNOP_TYPE = gridRow["SNOP_TYPE"].ToString();
                var Item_cd = gridRow["ITEM_CD"].ToString();
                var Year_cd = gridRow["YEAR_CD"].ToString();

                var ItemRows = DetailModel_DataTable.AsEnumerable().Where(v => v["ITEM_CD"].ToString() == Item_cd);
                var OriginItemRows = ORiginDetailModel.AsEnumerable().Where(v => v["ITEM_CD"].ToString() == Item_cd);

                //기말재고 업데이트
                foreach (var row in ItemRows
                     .Where(v => int.Parse(v["YEAR_CD"].ToString())
                                        == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd) - 1
                                && v["MONTH_CD"].ToString() == "12"
                     ))
                {
                    if (CellName == "Last_Year"
                        || SNOP_TYPE == "IP"
                        )
                    {
                        row["IP_PLAN_QTY"] = CellValue;
                        row["MOD_YN"] = "Y";
                    }
                }

                for (int i = 1; i <= 12; i++)
                {
                    int LastValue = 0;
                    int OriginLastValue = 0;
                    if (i == 1)
                    {
                        LastValue = int.Parse(ItemRows.Where(v =>
                                    int.Parse(v["YEAR_CD"].ToString())
                                        == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd) - 1
                                 && v["MONTH_CD"].ToString() == "12")
                            .Single()["IP_PLAN_QTY"].ToString());

                        OriginLastValue = int.Parse(OriginItemRows.Where(v =>
                                   int.Parse(v["YEAR_CD"].ToString())
                                       == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd) - 1
                                && v["MONTH_CD"].ToString() == "12")
                           .Single()["IP_PLAN_QTY"].ToString());

                    }
                    else
                    {
                        LastValue = int.Parse(ItemRows.Where(v =>
                                        int.Parse(v["YEAR_CD"].ToString())
                                            == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd)
                                     && v["MONTH_CD"].ToString() == (i - 1).ToString().PadLeft(2, '0'))
                            .Single()["IP_PLAN_QTY"].ToString());

                        OriginLastValue = int.Parse(OriginItemRows.Where(v =>
                                            int.Parse(v["YEAR_CD"].ToString())
                                                == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd)
                                         && v["MONTH_CD"].ToString() == (i - 1).ToString().PadLeft(2, '0'))
                                .Single()["IP_PLAN_QTY"].ToString());
                    }

                    //현재 Row
                    var Currow = ItemRows.Where(v =>
                                        int.Parse(v["YEAR_CD"].ToString())
                                              == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd)
                                       && v["MONTH_CD"].ToString() == (i).ToString().PadLeft(2, '0')).Single();
                    if (Currow["MONTH_CD"].ToString() == CellMonth_cd)
                    {
                        switch (SNOP_TYPE)
                        {
                            case "SP": //판매계획
                                Currow["SP_PLAN_QTY"] = CellValue;
                                Currow["MOD_YN"] = "Y";
                                break;
                            case "PP": //생산계획
                                Currow["PP_PLAN_QTY"] = CellValue;
                                Currow["MOD_YN"] = "Y";
                                break;
                        }
                    }
                    if (LastValue != OriginLastValue)
                    {
                        Currow["MOD_YN"] = "Y";
                    }

                    Currow["IP_PLAN_QTY"] = LastValue - int.Parse(Currow["SP_PLAN_QTY"].ToString())
                                                                   + int.Parse(Currow["PP_PLAN_QTY"].ToString());


                }
                DataRefreshByList(HearderModel, DetailModel_DataTable, SumModel,false);
                ModelTable.EndLoadData();
                gridView1.EndUpdate();
                gridView1.FocusedRowHandle = focusedRowHandle;
                //var aa=DetailModel_DataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
            finally
            {
                //gridView1.CellValueChanged += GridView1_CellValueChanged;
            }
        }

        private void DataRefreshByList(List<MonthPlanGrModel> HearderModel, DataTable DetailModel_DataTable
            , List<MonthPlanGrModel> SumModel ,bool _refreshColumn )
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
                        switch (row["SNOP_TYPE"].ToString())
                        {
                            case "SP": //판매계획
                                row.SetField(dmodel["YEAR_CD"].ToString() + "-" + dmodel["MONTH_CD"].ToString(), dmodel["SP_PLAN_QTY"].ToString());
                                break;
                            case "PP"://생산계획
                                row.SetField(dmodel["YEAR_CD"].ToString() + "-" + dmodel["MONTH_CD"].ToString(), dmodel["PP_PLAN_QTY"].ToString());
                                break;
                            case "IP":
                                row.SetField(dmodel["YEAR_CD"].ToString() + "-" + dmodel["MONTH_CD"].ToString(), dmodel["IP_PLAN_QTY"].ToString());
                                break;
                        }
                    }
                    var FilterRowLastYear = DetailModel_DataTable.AsEnumerable()
                        .Where(a => a["ITEM_CD"].ToString() == model.ITEM_CD
                        && int.Parse(a["YEAR_CD"].ToString()) == int.Parse(model.YEAR_CD) - 1);


                    foreach (var lastmodel in FilterRowLastYear)
                    {
                        switch (row["SNOP_TYPE"].ToString())
                        {
                            case "SP": //판매계획
                                row.SetField("Last_Year", lastmodel["SP_PLAN_QTY"].ToString());
                                break;
                            case "PP"://생산계획
                                row.SetField("Last_Year", lastmodel["PP_PLAN_QTY"].ToString());
                                break;
                            case "IP":
                                row.SetField("Last_Year", lastmodel["IP_PLAN_QTY"].ToString());
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
                                         IP_PLAN_QTY = g.Sum(order => Convert.ToInt32(order.Field<string>("IP_PLAN_QTY")))
                                     }
                               ;
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
                        switch (row["SNOP_TYPE"].ToString())
                        {

                            case "SP": //판매계획
                                var SP_value = DetailSumModel
                                    .Where(v => int.Parse(v.YEAR_CD) == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd) - 1
                                    && v.MONTH_CD == "12").Select(v => v.SP_PLAN_QTY).Single();
                                row.SetField("Last_Year", SP_value);
                                break;
                            case "PP"://생산계획
                                var PP_value = DetailSumModel
                                    .Where(v => int.Parse(v.YEAR_CD) == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd) - 1
                                    && v.MONTH_CD == "12").Select(v => v.PP_PLAN_QTY).Single();

                                row.SetField("Last_Year", PP_value);
                                break;
                            case "IP": //재고계획
                                var IP_value = DetailSumModel
                                    .Where(v => int.Parse(v.YEAR_CD) == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd) - 1
                                    && v.MONTH_CD == "12").Select(v => v.IP_PLAN_QTY).Single();

                                row.SetField("Last_Year", IP_value);
                                break;
                        }

                        for (int i = 1; i <= 12; i++)
                        {
                            switch (row["SNOP_TYPE"].ToString())
                            {
                                case "SP": //판매계획
                                    var SP_Month_Value = DetailSumModel
                                    .Where(v => int.Parse(v.YEAR_CD) == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd)
                                    && v.MONTH_CD == i.ToString().PadLeft(2, '0')).Select(v => v.SP_PLAN_QTY).Single();
                                    row.SetField(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd
                                                        + "-" + i.ToString().PadLeft(2, '0')
                                        , SP_Month_Value);
                                    break;
                                case "PP"://생산계획
                                    var PP_Month_Value = DetailSumModel
                                    .Where(v => int.Parse(v.YEAR_CD) == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd)
                                    && v.MONTH_CD == i.ToString().PadLeft(2, '0')).Select(v => v.PP_PLAN_QTY).Single();
                                    row.SetField(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd
                                                        + "-" + i.ToString().PadLeft(2, '0')
                                        , PP_Month_Value);
                                    break;
                                case "IP": //재고계획
                                    var IP_Month_Value = DetailSumModel
                                    .Where(v => int.Parse(v.YEAR_CD) == int.Parse(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd)
                                    && v.MONTH_CD == i.ToString().PadLeft(2, '0')).Select(v => v.IP_PLAN_QTY).Single();
                                    row.SetField(_monthPlanArgs.OperationMonthPlanModelArgs.Select_Main_Plan_Year_cd
                                                        + "-" + i.ToString().PadLeft(2, '0')
                                        , IP_Month_Value);
                                    break;
                            }

                        }

                        ModelTable.Rows.Add(row);
                    }
                }




                strapGridControl1.DataSource = ModelTable;
                gridView1.BestFitColumns();
                //gridView1.BeginDataUpdate();
                //try
                //{
                //    gridView1.ClearSorting();
                //    gridView1.Columns["ITEM_CD"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                //    gridView1.Columns["SORT_NO"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                //}
                //catch (Exception ex)
                //{
                //    string gaa = ex.Message;
                //}
                //finally
                //{
                //    gridView1.EndDataUpdate();
                //}

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
                //재고수량은 변경 못 하도록 해야함
                GridView view = sender as GridView;
                DataRow _dataRow = view.GetFocusedDataRow();
                //데이터 없는 경우 갱신 불가
                //합계인 경우
                if (string.IsNullOrEmpty(view.GetFocusedDataRow()["ITEM_CD"].ToString())
                    || view.GetFocusedDataRow()["ITEM_CD"].ToString() == "SUM"
                    )
                {
                    e.Cancel = true;
                }
                if (view.GetFocusedDataRow()["SNOP_TYPE"].ToString() == "IP"
                    && view.FocusedColumn.FieldName != "Last_Year"
                    )
                {
                    e.Cancel = true;
                }
                if (view.FocusedColumn.FieldName == "Last_Year"
                    && view.GetFocusedDataRow()["SNOP_TYPE"].ToString() != "IP"
                    )
                {
                    e.Cancel = true;
                }

                var CellName = view.FocusedColumn.FieldName;
                var year_cd= _dataRow["YEAR_CD"].ToString();
                var item_cd = _dataRow["ITEM_CD"].ToString();
                DateTime _date;
                
                if (e.Cancel == false)
                {
                    //확정된 경우 수정 불가.
                    if (DateTime.TryParse(CellName, out _date))
                    {
                      var SNOP_STATUS=  ORiginDetailModel.AsEnumerable()
                            .Where(v => v["YEAR_CD"].ToString() == year_cd
                                        && v["ITEM_CD"].ToString() == item_cd
                                        && v["MONTH_CD"].ToString() == _date.Month.ToString().PadLeft(2, '0'))
                            .Select(v => v["SNOP_STATUS"]).Single().ToString();

                        if (SNOP_STATUS == "CLOSE")
                        {
                            e.Cancel = true;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }



        }

        private void gridView1_CellMerge(object sender, CellMergeEventArgs e)
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

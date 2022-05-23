using BPack.Common.LoginInfo;
using BPack.Model.Annotation.Common;
using BPack.Model.App.PC.OperationDayPlan;
using BPack.Pocket.App.PC.OperationDayPlan;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.OperationDayPlan
{
    public partial class DayList : StrapSubForm_Empty
    {
        private OperationDayPlanArgs _dayPlanArgs;
        private OperationDayPlanPocket _dayPlanPocket;
        DataTable ModelTable;
        DataTable DetailGrModel_DataTable = new DataTable();
        DataTable DetailModel_DataTable = new DataTable();
        DataTable OriginDetailModel = new DataTable();

        string _grid_orderby = "ITEM_CD";
        //최초실행시 헤더 만듬.
        List<DayPlanGrModel> HearderModel;

        public event EventHandler<DayPlanSumModel> ChagneDetailPlan;

        string trLang;

        public DayList()
        {
            InitializeComponent();
        }

        public DayList(OperationDayPlanArgs operationDayPlanArgs, OperationDayPlanPocket operationDayPlanPocket) : this()
        {
            this._dayPlanArgs = operationDayPlanArgs;
            this._dayPlanPocket = operationDayPlanPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            gridView1.OptionsView.ColumnAutoWidth = false;
            InitColumns();
            gridView1.CellValueChanged += GridView1_CellValueChanged;
            gridView1.RowCellStyle += GridView1_RowCellStyle;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
        }
        public override void DataRefresh(ArgsBase args)
        {
            //base.DataRefresh(args);
            HearderModel
                = _dayPlanPocket.SelectDayPlanGrModel(_dayPlanArgs.OperationDayPlanModelArgs);

            //상세 데이터 컬럼
            DetailGrModel_DataTable = _dayPlanPocket.SelectDayPlanDetailGrModel(_dayPlanArgs.OperationDayPlanModelArgs);

            //상세 데이터 
            DetailModel_DataTable = _dayPlanPocket.SelectDayPlanDetailModel(_dayPlanArgs.OperationDayPlanModelArgs);
            OriginDetailModel = DetailModel_DataTable.Copy();

            DataRefreshByList(true);

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
            gridView1.Columns.Clear();
            ModelTable = new DataTable();
            DataColumn dtCol;
            foreach (var prop in typeof(DayPlanGrModel).GetProperties())
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

            string PreWeek = "";
            for (int i = 0; i < DetailGrModel_DataTable.Rows.Count; i++)
            {

                var row = DetailGrModel_DataTable.Rows[i];
                if (i == 0)
                {
                    PreWeek = row["MONTH_WEEK_CD"].ToString();
                }
                if (PreWeek != row["MONTH_WEEK_CD"].ToString())
                {
                    dtCol = new DataColumn();
                    dtCol.Caption = row["PRE_WEEK_SUM_NM"].ToString();
                    //2022.03.17 정수교 언어변환 
                    trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, dtCol.Caption);
                    if (!string.IsNullOrEmpty(trLang))
                    {
                        dtCol.Caption = trLang;
                    }

                    dtCol.ColumnName = row["PRE_WEEK_SUM_CD"].ToString();
                    dtCol.DataType = typeof(int);
                    dtCol.ReadOnly = true;
                    if (ModelTable.Columns.Contains(row["PRE_WEEK_SUM_CD"].ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        ModelTable.Columns.Add(dtCol);
                    }
                }
                dtCol = new DataColumn();
                dtCol.Caption = ((DateTime)row["WORK_DT_NM"]).ToString("MM-dd");
                dtCol.ColumnName = ((DateTime)row["WORK_DT_CD"]).ToString("yyyy-MM-dd");
                dtCol.DataType = typeof(int);
                if (ModelTable.Columns.Contains(((DateTime)row["WORK_DT_CD"]).ToString("yyyy-MM-dd")))
                {
                    continue;
                }
                else
                {
                    ModelTable.Columns.Add(dtCol);
                }


                PreWeek = row["MONTH_WEEK_CD"].ToString();

                //마지막월 합계자동 추가
                if (i == DetailGrModel_DataTable.Rows.Count - 1)
                {
                    dtCol = new DataColumn();
                    dtCol.Caption = row["WEEK_SUM_NM"].ToString();
                    dtCol.ColumnName = row["WEEK_SUM_CD"].ToString();
                    dtCol.DataType = typeof(int);
                    dtCol.ReadOnly = true;

                    ModelTable.Columns.Add(dtCol);
                }

            }
            strapGridControl1.DataSource = ModelTable;
            foreach (GridColumn col in gridView1.Columns)
            {
                var prop = typeof(DayPlanGrModel).GetProperty(col.FieldName);
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
                //열고정
                //if (col.FieldName == "Last_Year")
                //{
                //    col.Fixed = FixedStyle.Left;
                //}
            }

        }

        internal void ChnageOrderby(string _orderby)
        {
            _grid_orderby = _orderby;
            if (_grid_orderby == "ITEM_CD")
            {
                gridView1.Columns["YEAR_CD"].VisibleIndex = 0;
                gridView1.Columns["ITEM_TYPE_NM"].VisibleIndex = 1;
                gridView1.Columns["ITEM_GR_NM"].VisibleIndex = 2;
                gridView1.Columns["ITEM_CD"].VisibleIndex = 3;
                gridView1.Columns["ITEM_NM"].VisibleIndex = 4;
                //gridView1.Columns["WC_CD"].VisibleIndex = 4;
                gridView1.Columns["WC_NM"].VisibleIndex = 5;
                gridView1.Columns["SHIFT_NM"].VisibleIndex = 6;
            }
            else
            {
                gridView1.Columns["YEAR_CD"].VisibleIndex = 0;
                //gridView1.Columns["WC_CD"].VisibleIndex = 0;
                gridView1.Columns["WC_NM"].VisibleIndex = 1;
                gridView1.Columns["ITEM_TYPE_NM"].VisibleIndex = 2;
                gridView1.Columns["ITEM_GR_NM"].VisibleIndex = 3;
                gridView1.Columns["ITEM_CD"].VisibleIndex = 4;
                gridView1.Columns["ITEM_NM"].VisibleIndex = 5;
                gridView1.Columns["SHIFT_NM"].VisibleIndex = 6;
            }




            gridView1.RefreshData();
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
                List<DayPlanModel> weekPlans = new List<DayPlanModel>();
                foreach (var row in DetailModel_DataTable.AsEnumerable().Where(v => v["MOD_YN"].ToString() == "Y"))
                {
                    weekPlans.Add(new DayPlanModel()
                    {
                        COMP_CD = _dayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd
                         ,
                        PLANT_CD = _dayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd
                         ,
                        CREATE_DTTM = DateTime.Now
                         ,
                        MODIFY_DTTM = DateTime.Now
                        ,
                        CREATE_USER_ID = UserInfo.UserID
                        ,
                        MODIFY_USER_ID = UserInfo.UserID
                        ,
                        SNOP_DY_NO = row["SNOP_DY_NO"].ToString()
                        ,
                        PLAN_QTY = decimal.Parse(row["PLAN_QTY"].ToString())
                    });
                }
                _dayPlanPocket.SaveDayPlanModel(weekPlans);
                DataRefresh(_dayPlanArgs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void DayPlanConfirm(string Wc_cd, DateTime Start_dt, DateTime End_dt, string SnopType)
        {
            if (StrapMessageBox.Show("A001", 33, MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                DayConfirmModel model = new DayConfirmModel()
                {
                    COMP_CD = _dayPlanArgs.OperationDayPlanModelArgs.Select_Main_Comp_Cd
                    ,
                    PLANT_CD = _dayPlanArgs.OperationDayPlanModelArgs.Select_Main_Plant_Cd
                    ,
                    CREATE_DTTM = DateTime.Now
                    ,
                    MODIFY_DTTM = DateTime.Now
                    ,
                    CREATE_USER_ID = UserInfo.UserID
                    ,
                    MODIFY_USER_ID = UserInfo.UserID
                    ,
                    LANG_CODE = UserInfo.Sys_Language
                    ,
                    SNOP_TYPE = SnopType
                    ,
                    START_DT = Start_dt
                    ,
                    END_DT = End_dt
                    ,
                    WC_CD = Wc_cd
                };
                _dayPlanPocket.SaveDayPlanConfirm(model);
                StrapMessageBox.Show("A001", 18);
                DataRefresh(_dayPlanArgs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        private void DataRefreshByList(bool _refreshColumn)
        {
            if (_refreshColumn)
            {
                InitColumns();
            }
            ModelTable.Rows.Clear();
            foreach (var model in HearderModel)
            {
                var row = ModelTable.NewRow();
                foreach (var prop in model.GetType().GetProperties())
                {
                    row.SetField(prop.Name, prop.GetValue(model));
                }
                var FilterRow = DetailModel_DataTable.AsEnumerable()
                                        .Where(v =>
                                        v["WC_CD"].ToString() == model.WC_CD
                                        && v["YEAR_CD"].ToString() == model.YEAR_CD
                                        && v["ITEM_CD"].ToString() == model.ITEM_CD
                                        && v["SHIFT_GROUP_CD"].ToString() == model.SHIFT_GROUP_CD
                                        && v["SHIFT_CD"].ToString() == model.SHIFT_CD
                                        );
                foreach (var dmodel in FilterRow)
                {
                    row.SetField(((DateTime)dmodel["WORK_DT"]).ToString("yyyy-MM-dd"), int.Parse(dmodel["PLAN_QTY"].ToString()));
                }

                //주차별 합계
                var DetailSumModel = from b in FilterRow
                                     group b by
                                         new
                                         {
                                             MONTH_CD = b.Field<string>("MONTH_CD")
                                                 ,
                                             MONTH_WEEK_CD = b.Field<string>("MONTH_WEEK_CD")
                                         } into g
                                     select new
                                     {
                                         WEEK_SUM_CD = g.Key.MONTH_CD + "M" + g.Key.MONTH_WEEK_CD
                                         ,
                                         PLAN_QTY = g.Sum(order => Convert.ToInt32(order.Field<string>("PLAN_QTY")))
                                     };
                foreach (var _sum in DetailSumModel)
                {
                    row.SetField(_sum.WEEK_SUM_CD, _sum.PLAN_QTY);
                }


                ModelTable.Rows.Add(row);
            }
            strapGridControl1.DataSource = ModelTable;

            gridView1.BestFitColumns();
            gridView1.BeginDataUpdate();
            try
            {
                gridView1.ClearSorting();
                gridView1.Columns["WC_CD"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView1.Columns["ITEM_CD"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                gridView1.Columns["SHIFT_CD"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            }
            finally
            {
                gridView1.EndDataUpdate();
            }

            DayPlanSumModel dayPlanSumModel = new DayPlanSumModel();
            dayPlanSumModel.headerGrModel = HearderModel;
            dayPlanSumModel.DetailGrModel_DataTable = DetailGrModel_DataTable;
            dayPlanSumModel.ChangedModel = DetailModel_DataTable;
            ChagneDetailPlan?.Invoke(this, dayPlanSumModel);

        }

        private void GridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                var _dataRow = gridView1.GetRow(e.RowHandle) as DataRowView;
                if (_dataRow == null) return;
                var _year = _dataRow["YEAR_CD"].ToString();
                var _wc_cd = _dataRow["WC_CD"].ToString();
                var _shift_group_cd = _dataRow["SHIFT_GROUP_CD"].ToString();
                var _shift_cd = _dataRow["SHIFT_CD"].ToString();
                var _Item_cd = _dataRow["ITEM_CD"].ToString();
                var _shift_uph= decimal.Parse( _dataRow["SHIFT_UPH"].ToString());  
                var _cell_cd = e.Column.FieldName;
                Regex regex = new Regex(@"[0-9]{2}[M][0-9]{2}$");
                Regex regex2 = new Regex(@"[0-9]{4}[-][0-9]{2}[-][0-9]{2}$");
                var CellValue = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                //주차별 합계
                if (regex.IsMatch(_cell_cd.ToString()))
                {
                    e.Appearance.BackColor = Color.DarkGray;
                }
                else if (regex2.IsMatch(_cell_cd.ToString()))
                {
                    //휴무일
                    var Row = DetailModel_DataTable.AsEnumerable()
                        .Where(v => v["YEAR_CD"].ToString() == _year
                                        && v["WC_CD"].ToString() == _wc_cd
                                        && v["SHIFT_GROUP_CD"].ToString() == _shift_group_cd
                                        && v["SHIFT_CD"].ToString() == _shift_cd
                                        && v["ITEM_CD"].ToString() == _Item_cd
                                        && DateTime.Parse(v["WORK_DT"].ToString()) == DateTime.Parse(_cell_cd)
                        );
                    string _work_type = Row.Select(v => v["WORK_TYPE"]).Single().ToString();
                    if (_work_type == "WT002")
                    {
                        //2021.12.23 휴일도 수정가능
                        e.Appearance.BackColor = Color.FromArgb(242,242,242);
                        
                    }

                    //값 변경에 따른
                    int _PreValue;
                    int.TryParse(OriginDetailModel.AsEnumerable()
                            .Where(v => v["YEAR_CD"].ToString() == _year
                                        && v["WC_CD"].ToString() == _wc_cd
                                        && v["SHIFT_GROUP_CD"].ToString() == _shift_group_cd
                                        && v["SHIFT_CD"].ToString() == _shift_cd
                                        && v["ITEM_CD"].ToString() == _Item_cd
                                        && DateTime.Parse(v["WORK_DT"].ToString()) == DateTime.Parse(_cell_cd)

                            ).Single()["PLAN_QTY"].ToString(), out _PreValue);
                    if (_PreValue != int.Parse(CellValue.ToString()))
                    {
                        e.Appearance.BackColor = Color.Red;
                    }

                    if (int.Parse(CellValue.ToString()) >= _shift_uph)
                    {
                        Font _font = new Font("Tahoma", 12, FontStyle.Bold);
                        e.Appearance.Font = _font;
                        e.Appearance.ForeColor = Color.Turquoise;
                    }
                    else
                    {
                        e.Appearance.Font = WindowsFormsSettings.DefaultFont;
                    }

                    //확정 여부
                    string _snop_status = Row.Select(v => v["SNOP_STATUS"]).Single().ToString();
                    if (_snop_status == "CLOSE")
                    {
                        e.Appearance.BackColor = Color.DarkGray;
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
                DataRow _dataRow = (sender as GridView).GetFocusedDataRow();
                var _year = _dataRow["YEAR_CD"].ToString();
                var _wc_cd = _dataRow["WC_CD"].ToString();
                var _shift_group_cd = _dataRow["SHIFT_GROUP_CD"].ToString();
                var _shift_cd = _dataRow["SHIFT_CD"].ToString();
                var _Item_cd = _dataRow["ITEM_CD"].ToString();
                var _work_dt = e.Column.FieldName;
                var CellValue = gridView1.GetRowCellValue(e.RowHandle, e.Column);

                if (CellValue.ToString() == "")
                {
                    CellValue = 0;
                }

                var ItemRows = DetailModel_DataTable.AsEnumerable()
                    .Where(v => v["YEAR_CD"].ToString() == _year
                                    && v["WC_CD"].ToString() == _wc_cd
                                    && v["SHIFT_GROUP_CD"].ToString() == _shift_group_cd
                                    && v["SHIFT_CD"].ToString() == _shift_cd
                                    && v["ITEM_CD"].ToString() == _Item_cd
                                    && DateTime.Parse(v["WORK_DT"].ToString()) == DateTime.Parse(_work_dt)
                    );

                foreach (var row in ItemRows)
                {
                    row["PLAN_QTY"] = CellValue;
                    row["MOD_YN"] = "Y";
                }
                DataRefreshByList(false);
                ModelTable.EndLoadData();
                gridView1.EndUpdate();
                gridView1.FocusedRowHandle = focusedRowHandle;

            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView _view = sender as GridView;
            DataRow _dataRow = _view.GetFocusedDataRow();
            var _year = _dataRow["YEAR_CD"].ToString();
            var _wc_cd = _dataRow["WC_CD"].ToString();
            var _shift_group_cd = _dataRow["SHIFT_GROUP_CD"].ToString();
            var _shift_cd = _dataRow["SHIFT_CD"].ToString();
            var _Item_cd = _dataRow["ITEM_CD"].ToString();
            var _work_dt = _view.FocusedColumn.FieldName;

            //휴일 금지
            Regex regex = new Regex(@"[0-9]{2}[M][0-9]{2}$");
            //주차별 합계
            if (regex.IsMatch(_work_dt.ToString()))
            {
                e.Cancel = true;
            }

            if (e.Cancel == false)
            {
                var Row = DetailModel_DataTable.AsEnumerable()
                     .Where(v => v["YEAR_CD"].ToString() == _year
                                     && v["WC_CD"].ToString() == _wc_cd
                                     && v["SHIFT_GROUP_CD"].ToString() == _shift_group_cd
                                     && v["SHIFT_CD"].ToString() == _shift_cd
                                     && v["ITEM_CD"].ToString() == _Item_cd
                                     && DateTime.Parse(v["WORK_DT"].ToString()) == DateTime.Parse(_work_dt)
                     );
                string _work_type = Row.Select(v => v["WORK_TYPE"]).Single().ToString();
                if (_work_type == "WT002")
                {
                    //2021.12.23 휴일도 수정가능
                    //e.Cancel = true;
                }

                //확정인경우 
                string _snop_status = Row.Select(v => v["SNOP_STATUS"]).Single().ToString();
                if (e.Cancel == false)
                {
                    if (_snop_status == "CLOSE")
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void gridView1_CellMerge(object sender, CellMergeEventArgs e)
        {
            GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            try
            {
                if (e.Column.FieldName == "YEAR_CD"
                   || e.Column.FieldName == "ITEM_TYPE_NM"
                   || e.Column.FieldName == "ITEM_GR_NM"
                   || e.Column.FieldName == "ITEM_CD"
                   || e.Column.FieldName == "ITEM_NM"
                   || e.Column.FieldName == "WC_NM"
                   || e.Column.FieldName == "WC_CD"

                   ) // Merge할 Cell의 Column FieldName 확인
                {
                    string class1 = "";
                    string class2 = "";
                    string value1 = "";
                    string value2 = "";

                    if (_grid_orderby == "WC_CD")
                    {
                        class1 = view.GetRowCellValue(e.RowHandle1, "WC_CD").ToString();
                        class2 = view.GetRowCellValue(e.RowHandle2, "WC_CD").ToString();
                        value1 = view.GetRowCellValue(e.RowHandle1, e.Column).ToString();
                        value2 = view.GetRowCellValue(e.RowHandle2, e.Column).ToString();
                    }
                    else if (_grid_orderby == "ITEM_CD")
                    {
                        class1 = view.GetRowCellValue(e.RowHandle1, "ITEM_CD").ToString();
                        class2 = view.GetRowCellValue(e.RowHandle2, "ITEM_CD").ToString();
                        value1 = view.GetRowCellValue(e.RowHandle1, e.Column).ToString();
                        value2 = view.GetRowCellValue(e.RowHandle2, e.Column).ToString();
                    }
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

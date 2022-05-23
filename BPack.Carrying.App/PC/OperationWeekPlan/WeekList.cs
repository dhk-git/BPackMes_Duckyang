using BPack.Common.LoginInfo;
using BPack.Model.Annotation.Common;
using BPack.Model.App.PC.OperationWeekPlan;
using BPack.Pocket.App.PC.OperationWeekPlan;
using BPack.Strap.FormControls;
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
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.OperationWeekPlan
{
    public partial class WeekList : StrapSubForm_Empty
    {
        private OperationWeekPlanArgs _weekPlanArgs;
        private OperationWeekPlanPocket _weekPlanPocket;
        DataTable ModelTable;
        //private List<DataColumn> _dynamicStrapDataColumns;

        //최초실행시 헤더 만듬.
        List<WeekPlanGrModel> HearderModel;
        DataTable DetailModel_DataTable = new DataTable();
        DataTable DetailGrModel_DataTable = new DataTable();

        DataTable OriginDetailModel = new DataTable();

        WeekPlanSumModel weekPlanSumModel;
        public event EventHandler<WeekPlanSumModel> ChagneDetailPlan;

        string trLang;


        public WeekList()
        {
            InitializeComponent();
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
        public WeekList(OperationWeekPlanArgs weekPlanArgs, OperationWeekPlanPocket weekPlanPocket) : this()
        {
            this._weekPlanArgs = weekPlanArgs;
            this._weekPlanPocket = weekPlanPocket;
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
            HearderModel
                = _weekPlanPocket.SelectWeekPlanGrModel(_weekPlanArgs.OperationWeekPlanModelArgs);

            //상세 데이터 컬럼
            DetailGrModel_DataTable = _weekPlanPocket.SelectWeekPlanDetailGrModel(_weekPlanArgs.OperationWeekPlanModelArgs);

            //상세 데이터 
            DetailModel_DataTable = _weekPlanPocket.SelectWeekPlanDetailModel(_weekPlanArgs.OperationWeekPlanModelArgs);

            OriginDetailModel = DetailModel_DataTable.Copy();

            DataRefreshByList(true);
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
                List<WeekPlanModel> weekPlans = GetChangedWeekModel();

                _weekPlanPocket.SaveWeekPlanModel(weekPlans);
                DataRefresh(_weekPlanArgs);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }

        }

        /// <summary>
        /// 현재 변경된 이력
        /// </summary>
        /// <returns></returns>
        public List<WeekPlanModel> GetChangedWeekModel()
        {
            List<WeekPlanModel> weekPlans = new List<WeekPlanModel>();
            foreach (var row in DetailModel_DataTable.AsEnumerable().Where(v => v["MOD_YN"].ToString() == "Y"))
            {
                weekPlans.Add(new WeekPlanModel
                {
                    COMP_CD = _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Comp_Cd
                     ,
                    PLANT_CD = _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plant_Cd
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
                    SNOP_WK_NO = row["SNOP_WK_NO"].ToString()
                    ,
                    PLAN_QTY = decimal.Parse(row["PLAN_QTY"].ToString())
                });
            }

            return weekPlans;
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
                var FilterRow = DetailModel_DataTable.AsEnumerable().Where(a => a["ITEM_CD"].ToString() == model.ITEM_CD);

                DataRow _year = FilterRow.Take(1).First();
                row.SetField("YEAR_CD", _year["YEAR_CD"].ToString());

                foreach (var dmodel in FilterRow)
                {
                    row.SetField(dmodel["COL_CD"].ToString(), int.Parse(dmodel["PLAN_QTY"].ToString()));
                }
                //년도
                //합계 
                //DateTime start_dt = _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plan_Start_dt;
                //DateTime end_dt = _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plan_End_dt;
                //int Months = TotalMonths(_weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plan_End_dt
                //            , _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plan_Start_dt
                //            );
                var DetailSumModel = from b in FilterRow
                                     group b by new { SUM_COL_CD = b.Field<string>("SUM_COL_CD") } into g
                                     select new
                                     {
                                         SUM_COL_CD = g.Key.SUM_COL_CD
                                         ,
                                         PLAN_QTY = g.Sum(order => Convert.ToInt32(order.Field<string>("PLAN_QTY")))
                                     }
                        ;
                foreach (var _sum in DetailSumModel)
                {
                    row.SetField(_sum.SUM_COL_CD, _sum.PLAN_QTY);
                }
                ModelTable.Rows.Add(row);
            }
            
            strapGridControl1.DataSource = ModelTable;

            gridView1.BestFitColumns();

            //항상 이벤트 발생

            //if (DetailModel_DataTable.AsEnumerable().Where(V => V["MOD_YN"].ToString() == "Y").Count() > 0)
            //{
            weekPlanSumModel = new WeekPlanSumModel();
            weekPlanSumModel.headerGrModel = HearderModel;
            weekPlanSumModel.DetailGrModel_DataTable = DetailGrModel_DataTable;
            weekPlanSumModel.ChangedModel = DetailModel_DataTable;

            ChagneDetailPlan?.Invoke(this, weekPlanSumModel);
            //}

        }

       

        private void GridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                var gridRow = gridView1.GetRow(e.RowHandle) as DataRowView;

                if (gridRow == null) return;
                var CellName = e.Column.FieldName;

                var CellItem = gridRow["ITEM_CD"].ToString();
                var CellYear = gridRow["YEAR_CD"].ToString();
                var CellValue = gridView1.GetRowCellValue(e.RowHandle, e.Column);

                //합계인 경우 수정불가
                if (CellName.Substring(CellName.Length - 2) == "MM")
                {
                    e.Appearance.BackColor = Color.DarkGray;
                    var SumQty = (from b in OriginDetailModel.AsEnumerable()
                                  where b["ITEM_CD"].ToString() == CellItem
                                         && b["YEAR_CD"].ToString() == CellYear
                                         && b["MONTH_CD"].ToString() == CellName.Split('.')[1].Replace("MM", "")
                                  group b by new { Item_cd = b.Field<string>("ITEM_CD") } into g
                                  select new
                                  {
                                      Item_cd = g.Key.Item_cd
                                      ,
                                      PLAN_QTY = g.Sum(order => Convert.ToInt32(order.Field<string>("PLAN_QTY")))
                                  }).First().PLAN_QTY;
                    if (SumQty != int.Parse(CellValue.ToString()))
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }
                else
                {
                    //var CellItem = gridRow["ITEM_CD"].ToString();
                    //var CellYear = gridRow["YEAR_CD"].ToString();
                    //var CellValue = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                    var CellMonth = "";
                    var CellMonthWeek = "";
                    if (CellName.Contains('.'))
                    {
                        CellMonth = CellName.Split('.')[0];
                        CellMonthWeek = CellName.Split('.')[1];
                    }
                    if (CellMonth != "" && CellMonthWeek != "")
                    {
                        //값인경우 
                        int IntValue;
                        int.TryParse(OriginDetailModel.AsEnumerable()
                            .Where(v => v["ITEM_CD"].ToString() == CellItem
                                   && v["YEAR_CD"].ToString() == CellYear
                                   && v["MONTH_CD"].ToString() == CellMonth
                                    && v["MONTH_WEEK_CD"].ToString() == CellMonthWeek

                            ).Single()["PLAN_QTY"].ToString(), out IntValue);

                        if (IntValue != int.Parse(CellValue.ToString()))
                        {
                            e.Appearance.BackColor = Color.Red;
                        }

                        string _status = (from v in DetailModel_DataTable.AsEnumerable()
                                          where v["YEAR_CD"].ToString() == CellYear
                                              && v["MONTH_CD"].ToString() == CellMonth
                                             && v["ITEM_CD"].ToString() == CellItem
                                          select v["SNOP_STATUS"]).First().ToString();
                        // 확정 인 경우 수정 불가
                        if (_status == "CLOSE")
                        {
                            e.Appearance.BackColor = Color.DarkGray;
                        }

                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                throw;
            }

        }

        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            try
            {
                var focusedRowHandel = gridView1.FocusedRowHandle;
                gridView1.BeginUpdate();
                ModelTable.BeginLoadData();
                GridView _view = sender as GridView;
                DataRow _dataRow = _view.GetFocusedDataRow();
                var _year = _dataRow["YEAR_CD"].ToString();
                var _Item_cd = _dataRow["ITEM_CD"].ToString();
                var CellValue = gridView1.GetRowCellValue(e.RowHandle, e.Column);

                if (CellValue.ToString() == "")
                {
                    CellValue = 0;
                }
                string CellName = e.Column.FieldName;
                string CellMonth_cd = CellName.Split('.')[0]; //월 01 02 
                string CellMonthWeek_cd = CellName.Split('.')[1]; //주 01 02 
                //현재 데이터 업데이트 
                var ItemRows = DetailModel_DataTable.AsEnumerable()
                    .Where(v => v["ITEM_CD"].ToString() == _Item_cd
                                    && v["YEAR_CD"].ToString() == _year
                                    && v["MONTH_CD"].ToString() == CellMonth_cd
                                    && v["MONTH_WEEK_CD"].ToString() == CellMonthWeek_cd
                    );
                foreach (var row in ItemRows)
                {
                    row["PLAN_QTY"] = CellValue;
                    row["MOD_YN"] = "Y";
                }
                DataRefreshByList(false);

                ModelTable.EndLoadData();
                gridView1.EndUpdate();
                gridView1.FocusedRowHandle = focusedRowHandel;

            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
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

            string Pre_month_CD = "";
            for (int i = 0; i < DetailGrModel_DataTable.Rows.Count; i++)
            {

                var row = DetailGrModel_DataTable.Rows[i];

                //헤더 이름 은 [월][주차][시작일(MM-dd)]
                if (i == 0)
                {
                    Pre_month_CD = row["MONTH_CD"].ToString();
                }
                //만약이 월이 바뀌는 경우 이전 월에 대한 계획/실적 데이터 넣기
                if (Pre_month_CD != row["MONTH_CD"].ToString())
                {
                    dtCol = new DataColumn();
                    dtCol.Caption = row["PRE_SUM_COL_NM"].ToString();
                    //2022.03.17 정수교 언어변환 
                    trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, dtCol.Caption);
                    if (!string.IsNullOrEmpty(trLang))
                    {
                        dtCol.Caption = trLang;
                    }
                    dtCol.ColumnName = row["PRE_SUM_COL_CD"].ToString();
                    dtCol.DataType = typeof(int);
                    if (ModelTable.Columns.Contains(row["PRE_SUM_COL_CD"].ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        ModelTable.Columns.Add(dtCol);
                    }
                }
                dtCol = new DataColumn();
                dtCol.Caption = row["COL_NM"].ToString();
                //2022.03.17 정수교 언어변환 
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, dtCol.Caption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    dtCol.Caption = trLang;
                }
                dtCol.ColumnName = row["COL_CD"].ToString();
                dtCol.DataType = typeof(int);
                if (ModelTable.Columns.Contains(row["COL_CD"].ToString()))
                {
                    continue;
                }
                else
                {
                    ModelTable.Columns.Add(dtCol);
                }


                Pre_month_CD = row["MONTH_CD"].ToString();

                //마지막월 합계자동 추가
                if (i == DetailGrModel_DataTable.Rows.Count - 1)
                {
                    dtCol = new DataColumn();
                    dtCol.Caption = row["SUM_COL_NM"].ToString();
                    //2022.03.17 정수교 언어변환 
                    trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, dtCol.Caption);
                    if (!string.IsNullOrEmpty(trLang))
                    {
                        dtCol.Caption = trLang;
                    }
                    dtCol.ColumnName = row["SUM_COL_CD"].ToString();
                    dtCol.DataType = typeof(int);
                    ModelTable.Columns.Add(dtCol);
                }
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
            }

        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                GridView _view = sender as GridView;
                DataRow _dataRow = _view.GetFocusedDataRow();

                if (_view.FocusedColumn.FieldName.Substring(_view.FocusedColumn.FieldName.Length - 2) == "MM")
                {
                    //합계 컬럼 수정 불가
                    e.Cancel = true;
                }

                if (e.Cancel == false)
                {
                    var _year = _dataRow["YEAR_CD"].ToString();
                    var _Item_cd = _dataRow["ITEM_CD"].ToString();
                    var _col = _view.FocusedColumn.FieldName;
                    var _month = _col.Substring(0, 2);


                    string _status = (from v in DetailModel_DataTable.AsEnumerable()
                                      where v["YEAR_CD"].ToString() == _year
                                          && v["MONTH_CD"].ToString() == _month
                                         && v["ITEM_CD"].ToString() == _Item_cd
                                      select v["SNOP_STATUS"]).First().ToString();
                    // 확정 인 경우 수정 불가
                    if (_status == "CLOSE")
                    {
                        e.Cancel = true;
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        
        /// <summary>
        /// 주간 계획 확정/취소
        /// </summary>
        /// <param name="Confirm_dt"></param>
        /// <param name="MonthWeek"></param>
        /// <param name="snop_status"></param>
        internal void WeekPlanConfirm(string Item_Cds, DateTime Confirm_dt, string snop_status)
        {
            if (StrapMessageBox.Show("A001", 33, MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                WeekConfirmModel model = new WeekConfirmModel()
                {
                    COMP_CD = _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Comp_Cd,
                    PLANT_CD = _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plant_Cd,
                    CREATE_DTTM = DateTime.Now,
                    MODIFY_DTTM = DateTime.Now,
                    CREATE_USER_ID = UserInfo.UserID,
                    MODIFY_USER_ID = UserInfo.UserID,
                    LANG_CODE = UserInfo.Sys_Language,
                    SNOP_STATUS = snop_status,
                    ITEM_CDS=Item_Cds,
                    CONFIRM_DT = Confirm_dt
                };
                _weekPlanPocket.SaveWeekPlanConfirm(model);
                StrapMessageBox.Show("A001", 18);
                DataRefresh(_weekPlanArgs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

    }
}

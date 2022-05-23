using BPack.Common.LoginInfo;
using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.App.SD.DlvPlan;
using BPack.Pocket.App.SD.DlvPlan;
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

namespace BPack.Carrying.App.SD.DlvPlan
{
    public partial class SalesOrderAndPlanList : StrapSubForm_Empty
    {
        private DlvPlanArgs _dlvPlanArgs;
        private DlvPlanPocket _dlvPlanPocket;
        private DataTable _selectedData;
        private SalesOrderSummaryModel _selectedSalesOrderSummaryModel;
        private List<SalesOrderSummaryModel> _selectedSalesOrderSummaryModels;
        private DlvPlanModel _selectedDlvPlanModel;
        private List<DlvPlanModel> _selectedDlvPlanModels;
        private List<DateModel> _dateModels;
        private List<StrapDataColumn> _dynamicStrapDataColumns;
        private bool _isInit = true;    //최초화면 오픈시 구분
        private string _currentSodNo;
        private string _currentItemCd;
        private DataRowView _gridRow;
        const string DATE_FORMAT = "MM-dd(ddd)";
        private string editableErrMsg = StrapMessageBox.GetMessage("A002", 13);//"출하지시 생성건은 수정할 수 없습니다."
        private string _sumDplusDateColName;

        string trLang;

        public SalesOrderAndPlanList()
        {
            InitializeComponent();
        }

        public SalesOrderAndPlanList(DlvPlanArgs dlvPlanArgs, DlvPlanPocket dlvPlanPocket) : this()
        {
            this._dlvPlanArgs = dlvPlanArgs;
            this._dlvPlanPocket = dlvPlanPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            gridView1.OptionsView.ColumnAutoWidth = false;
            //gridView1.OptionsSelection.MultiSelect = true;
            //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            InitColumns();
            _isInit = false;
            gridView1.CellValueChanged += GridView1_CellValueChanged;
            gridView1.RowCellStyle += GridView1_RowCellStyle;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.ValidatingEditor += GridView1_ValidatingEditor;
            gridView1.CellValueChanging += GridView1_CellValueChanging;
            gridView1.ShowingEditor += GridView1_ShowingEditor;
        }

        private void GridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            //if (_selectedDlvPlanModel != null && !_selectedDlvPlanModel.DPL_STATUS.Equals("WAIT"))
            //{
            //    e.Cancel = true;
            //}
        }

        private void GridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            _gridRow = gridView1.GetRow(e.RowHandle) as DataRowView;
            _currentSodNo = _gridRow["SOD_NO"].ToString();
            _currentItemCd = _gridRow["ITEM_CD"].ToString();
            _selectedSalesOrderSummaryModel = _selectedSalesOrderSummaryModels.Where(a => a.SOD_NO == _currentSodNo).SingleOrDefault();
            _selectedDlvPlanModel = _selectedDlvPlanModels.Where(a => a.SOD_NO == _currentSodNo &&
                    a.PLAN_DT.Date.ToString() == e.Column.FieldName).SingleOrDefault();
        }

        
        private void GridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (!_dlvPlanArgs.DlvPlanModelArgs.Select_Main_Checked_Calc)
            {
                if (e.Value != null && e.Value.ToString().ToUpper().IndexOf("P") > 0)
                {
                    int qty = Convert.ToInt32(e.Value.ToString().ToUpper().Replace("P", ""));
                    if (qty != 0)
                    {
                        e.Value = Convert.ToInt32(qty * _selectedSalesOrderSummaryModel.BOX_SIZE);
                    }
                }
            }
            if (e.Value != null && int.TryParse(e.Value.ToString(), out _) && !string.IsNullOrEmpty(e.Value.ToString()) && Convert.ToInt32(e.Value) < 0)
            {
                e.Valid = false;
                e.ErrorText = "less than 0";
            }
            if (_selectedDlvPlanModel != null && !_selectedDlvPlanModel.DPL_STATUS.Equals("WAIT"))
            {
                e.Valid = false;
                e.ErrorText = editableErrMsg;
            }
        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var checkColumn = _dynamicStrapDataColumns.Where(a => a.ColumnName == e.Column.FieldName).SingleOrDefault();
            if (checkColumn != null) 
            {
                var sodNo = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["SOD_NO"]).ToString();
                var currentPlanModel = _selectedDlvPlanModels.Where(a => a.SOD_NO == sodNo && a.PLAN_DT == ConvertStringToDateTime(e.Column.FieldName)).FirstOrDefault();
                if (currentPlanModel != null)
                {
                    if (!currentPlanModel.DPL_STATUS.Equals("WAIT"))
                    {
                        e.Appearance.BackColor = Color.Gray;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.White;
                    }
                    if (currentPlanModel.RowState == RowState.Added)
                    {
                        e.Appearance.BackColor = Color.IndianRed;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    }
                    if (currentPlanModel.RowState == RowState.Modified || currentPlanModel.RowState == RowState.Deleted)
                    {
                        e.Appearance.BackColor = Color.LightSeaGreen;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //var gridRow = gridView1.GetRow(e.RowHandle) as DataRowView;
            //var currentSodNo = gridRow["SOD_NO"].ToString();
            //var currentItemCd = gridRow["ITEM_CD"].ToString();
            //_selectedSalesOrderSummaryModel = _selectedSalesOrderSummaryModels.Where(a => a.SOD_NO == currentSodNo).SingleOrDefault();
            //_selectedDlvPlanModel = _selectedDlvPlanModels.Where(a => a.SOD_NO == currentSodNo &&
            //        a.PLAN_DT.ToString(DATE_FORMAT) == e.Column.FieldName).SingleOrDefault();
            if (_selectedDlvPlanModel == null && !string.IsNullOrEmpty(e.Value.ToString())) //모델이 없고 값이 빈게 아닐때
            {
                DateTime planDt;
                DateTime.TryParse(e.Column.FieldName,out planDt);
                _selectedDlvPlanModels.Add(new DlvPlanModel
                {
                    SOD_NO = _currentSodNo,
                    COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                    PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                    ITEM_CD = _currentItemCd,
                    PLAN_DT = planDt, //ConvertStringToDateTime(e.Column.FieldName),
                    PLAN_QTY = Convert.ToInt32(e.Value),
                    DPL_STATUS = "WAIT",
                    CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    RowState = RowState.Added
                });
            }
            else
            {
                if (string.IsNullOrEmpty(e.Value.ToString()) || e.Value.ToString() == "0")
                {
                    _selectedDlvPlanModel.PLAN_QTY = 0;
                    if (_selectedDlvPlanModel.RowState == RowState.Added)
                    {
                        _selectedDlvPlanModels.Remove(_selectedDlvPlanModel);
                    }
                    else
                    {
                        _selectedDlvPlanModel.RowState = RowState.Deleted;
                    }
                }
                else
                {
                    _selectedDlvPlanModel.PLAN_QTY = Convert.ToInt32(e.Value);
                    if (_selectedDlvPlanModel.RowState == RowState.UnChanged || _selectedDlvPlanModel.RowState == RowState.Deleted)
                    {
                        _selectedDlvPlanModel.RowState = RowState.Modified;
                    }
                }
            }
            var sumPlanQty = _selectedDlvPlanModels.Where(a => a.SOD_NO == _currentSodNo).Sum(a => a.PLAN_QTY);
            //var sumPlanQtyRemain = _selectedSalesOrderSummaryModel.SOD_QTY_REMAIN - sumPlanQty;
            //_gridRow["DISPLAY_SUM_PLAN_QTY"] = _selectedSalesOrderSummaryModel.SUM_PLAN_QTY + sumPlanQty;
            //_gridRow["DISPLAY_PLAN_QTY_REMAIN"] = _selectedSalesOrderSummaryModel.PLAN_QTY_REMAIN - sumPlanQty;
            _gridRow["DISPLAY_SUM_PLAN_QTY"] = sumPlanQty;
            _gridRow["DISPLAY_PLAN_QTY_REMAIN"] = _selectedSalesOrderSummaryModel.SOD_QTY_REMAIN - sumPlanQty;
            ////BOX 잔량 계산 추가 20220405
            //if(_selectedSalesOrderSummaryModel.BOX_SIZE != 0)
            //{
            //    _gridRow["DISPLAY_PLAN_QTY_REMAIN_BOX"] = (_selectedSalesOrderSummaryModel.SOD_QTY_REMAIN - sumPlanQty) / _selectedSalesOrderSummaryModel.BOX_SIZE;
            //}
        }

        private void InitColumns()
        {
            _dateModels = new List<DateModel>();
            var startDay = _dlvPlanArgs.DlvPlanModelArgs.Select_Main_Start_Dt.Day;
            var diffCnt = startDay + (_dlvPlanArgs.DlvPlanModelArgs.Select_Main_End_Dt - _dlvPlanArgs.DlvPlanModelArgs.Select_Main_Start_Dt).Days;
            if (_isInit == false)
            {
                int iday = 0;
                for (int i = startDay; i <= diffCnt; i++)
                {
                    _dateModels.Add(new DateModel { Dt = _dlvPlanArgs.DlvPlanModelArgs.Select_Main_Start_Dt.AddDays(iday) });
                    iday += 1;
                }
            }
            gridView1.Columns.Clear();
            _selectedData = new DataTable();
            StrapDataColumn dtCol;
            foreach (var prop in typeof(SalesOrderSummaryModel).GetProperties())
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
                _selectedData.Columns.Add(dtCol);
            }
            
            _dynamicStrapDataColumns = new List<StrapDataColumn>();
            foreach (var dateModel in _dateModels)
            {
                dtCol = new StrapDataColumn();
                dtCol.ColumnName = dateModel.Dt.Date.ToString();
                dtCol.Caption = dateModel.Dt.ToString(DATE_FORMAT);
                //2022.03.17 정수교 언어변환 
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, dtCol.Caption);
                if (!string.IsNullOrEmpty(trLang))
                {
                    dtCol.Caption = trLang;
                }

                //dtCol.Caption = dtCol.ColumnName;
                dtCol.DataType = typeof(decimal);
                dtCol.IsDynamicColumn = true;
                _selectedData.Columns.Add(dtCol);
                _dynamicStrapDataColumns.Add(dtCol);
            }
            //날짜 하루더 
            if (!_isInit)
            {
                dtCol = new StrapDataColumn();
                _sumDplusDateColName = _dlvPlanArgs.DlvPlanModelArgs.Select_Main_End_Dt.AddDays(1).ToString(DATE_FORMAT);
                dtCol.ColumnName = _sumDplusDateColName;
                dtCol.Caption = "Sum(" + dtCol.ColumnName + "~)";
                dtCol.DataType = typeof(decimal);
                dtCol.IsDynamicColumn = true;
                _selectedData.Columns.Add(dtCol);
                _dynamicStrapDataColumns.Add(dtCol);
            }

            gridControl1.DataSource = _selectedData;
            foreach (GridColumn col in gridView1.Columns)
            {
                var prop = typeof(SalesOrderSummaryModel).GetProperty(col.FieldName);
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
                    if (ConvertStringToDateTime(col.FieldName).DayOfWeek == DayOfWeek.Sunday)
                    {
                        col.AppearanceHeader.ForeColor = Color.Red;
                    }
                    if (ConvertStringToDateTime(col.FieldName).DayOfWeek == DayOfWeek.Saturday)
                    {
                        col.AppearanceHeader.ForeColor = Color.Blue;
                    }
                    if (_dlvPlanArgs.DlvPlanModelArgs.Select_Main_Checked_Calc) //계산기 모드
                    {
                        col.ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
                    }
                    DevExpress.XtraGrid.GridColumnSummaryItem gridColumnSummaryItem = new DevExpress.XtraGrid.GridColumnSummaryItem();
                    gridColumnSummaryItem.FieldName = col.FieldName;
                    gridColumnSummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    gridColumnSummaryItem.DisplayFormat = "{0:#,##0}";
                    col.Summary.Add(gridColumnSummaryItem);
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
            gridView1.Columns["SUM_PLAN_QTY"].Visible = false;
            gridView1.Columns["PLAN_QTY_REMAIN"].Visible = false;
            if (_isInit)
            {
                gridView1.BestFitColumns();
            }
            else
            {
                gridView1.Columns[_sumDplusDateColName].OptionsColumn.AllowEdit = false;
                gridView1.Columns[_sumDplusDateColName].AppearanceCell.BackColor = Color.Gray;
                gridView1.Columns[_sumDplusDateColName].AppearanceCell.Font = new Font(this.Font, FontStyle.Bold);
                gridView1.Columns[_sumDplusDateColName].AppearanceCell.ForeColor = Color.White;
            }
        }

        public override void DataRefresh(ArgsBase args)
        {
            _selectedSalesOrderSummaryModels = _dlvPlanPocket.SelectSalesOrderSummaryModels(_dlvPlanArgs.DlvPlanModelArgs);
            _selectedDlvPlanModels = _dlvPlanPocket.SelectDlvPlanModels(_dlvPlanArgs.DlvPlanModelArgs);

            InitColumns();
            decimal sumDplusDateQty;
            _selectedData.BeginLoadData();
            foreach (var model in _selectedSalesOrderSummaryModels)
            {
                //model.DISPLAY_SUM_PLAN_QTY = model.SUM_PLAN_QTY;
                //model.DISPLAY_PLAN_QTY_REMAIN = model.PLAN_QTY_REMAIN;
                //model.DISPLAY_SUM_PLAN_QTY = model.SUM_PLAN_QTY;
                //model.DISPLAY_PLAN_QTY_REMAIN = model.SOD_QTY_REMAIN;
                var dr = _selectedData.NewRow();
                foreach (var prop in model.GetType().GetProperties())
                {
                    dr.SetField(prop.Name, prop.GetValue(model));
                }
                var filteredDlvPlanModels = _selectedDlvPlanModels.Where(a => a.SOD_NO == model.SOD_NO);
                var sumPlanQty = filteredDlvPlanModels.Sum(a => a.PLAN_QTY);
                dr.SetField("DISPLAY_SUM_PLAN_QTY", sumPlanQty);    //계획합계계산
                dr.SetField("DISPLAY_PLAN_QTY_REMAIN", model.SOD_QTY_REMAIN - sumPlanQty); //계획잔량계산
                ////박스잔량계산 추가 20220405
                //if (model.BOX_SIZE != 0)
                //{
                //    dr.SetField("DISPLAY_PLAN_QTY_REMAIN_BOX", (model.SOD_QTY_REMAIN - sumPlanQty) / model.BOX_SIZE);
                //}
                sumDplusDateQty = 0;
                foreach (var dlvmodel in filteredDlvPlanModels)
                {
                    if (dlvmodel.PLAN_DT > _dlvPlanArgs.DlvPlanModelArgs.Select_Main_End_Dt)
                    {
                        sumDplusDateQty += dlvmodel.PLAN_QTY;
                        dr.SetField(_sumDplusDateColName, sumDplusDateQty);
                    }
                    else
                    {
                        //dr.SetField(dlvmodel.PLAN_DT.ToString(DATE_FORMAT), dlvmodel.PLAN_QTY);
                        dr.SetField(dlvmodel.PLAN_DT.Date.ToString(), dlvmodel.PLAN_QTY);
                    }
                    
                }
                _selectedData.Rows.Add(dr);
            }
            _selectedData.EndLoadData();
            gridControl1.DataSource = _selectedData;
            gridView1.BestFitColumns();
            gridView1.Columns["ITEM_NM"].Width = 120;
        }

        private DateTime ConvertStringToDateTime(string strDate)
        {
            DateTime dateTime;
            DateTime.TryParse(strDate, out dateTime);
            return dateTime;
            //return new DateTime(2021, Convert.ToInt32(strDate.Substring(0, 2)), Convert.ToInt32(strDate.Substring(3, 2)));
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
                gridView1.PostEditor();
                _dlvPlanPocket.SaveDlvPlanModels(_selectedDlvPlanModels);
                DataRefresh(_dlvPlanArgs);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

    public class DateModel
    {
        public DateTime Dt { get; set; }
    }

    public class StrapDataColumn : DataColumn
    {
        /// <summary>
        /// 동적으로 추가되는 컬럼인지 아닌지 구분한다.
        /// </summary>
        public bool IsDynamicColumn { get; set; } = false;
    }
}

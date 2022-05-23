using BPack.Common.LoginInfo;
using BPack.Model.App.PO.Mrp;
using BPack.Pocket.App.PO.Mrp;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
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

namespace BPack.Carrying.App.PO.Mrp
{
    public partial class MrpList : StrapSubForm_Empty
    {
        private MrpArgs _mrpArgs;
        private MrpPocket _mrpPocket;
        private bool _isInit = true;    //최초화면 오픈시 구분
        private DataTable _selectedData;
        private string _sysLang = UserInfo.Sys_Language;
        private List<MrpmModel> _mrpmModels;
        private List<MrpdModel> _mrpdModels;
        private List<FixedColumInfo> _fixedColumnsInfo;
        private List<StrapDataColumn> _dynamicColumns;
        private List<ToPorItem> _toPorItems;
        private PopupList _popupList;
        private string _nonArrivalQty_MMdd;

        public MrpList()
        {
            InitializeComponent();
        }

        public MrpList(MrpArgs mrpArgs, MrpPocket mrpPocket) : this()
        {
            this._mrpArgs = mrpArgs;
            this._mrpPocket = mrpPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsPrint.AutoWidth = false;   //true하면 exportToHtml에서 사이즈 엉망됨
            gridView1.OptionsView.AllowCellMerge = true;
            gridView1.OptionsFilter.AllowFilterEditor = false;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            //gridView1.OptionsSelection.MultiSelect = true;
            //gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            gridView1.CellMerge += GridView1_CellMerge;
            gridView1.RowCellStyle += GridView1_RowCellStyle;
            gridView1.DoubleClick += GridView1_DoubleClick;

            _popupList = new PopupList(_mrpArgs, _mrpPocket);

            _fixedColumnsInfo = new List<FixedColumInfo>();
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "ITEM_CD", Caption = "품번", Type = typeof(string) });
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "ITEM_NM", Caption = "품명", Type = typeof(string) });
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "ITEM_GR_1", Caption = "제품군", Type = typeof(string) });
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "LT", Caption = "리드타임(주)", Type = typeof(decimal), FormatString = "{0:#,##0}" });
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "WH_STOCK_QTY", Caption = "현재고", Type = typeof(decimal), FormatString = "{0:#,##0}" });
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "NON_ARRIVAL_QTY", Caption = "미착품", Type = typeof(decimal), FormatString = "{0:#,##0}" });
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "SAFETY_TERM", Caption = "안전재고기간(주)", Type = typeof(decimal), FormatString = "{0:#,##0}" });
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "TO_POR_QTY", Caption = "발주필요수량", Type = typeof(decimal), FormatString = "{0:#,##0}" });
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "MRP_CLS_CD", Caption = "구분코드", Type = typeof(string) });
            _fixedColumnsInfo.Add(new FixedColumInfo { FieldName = "MRP_CLS_NM", Caption = "구분", Type = typeof(string) });

            InitColumns();
            _isInit = false;
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo gridHitInfo = ((GridView)sender).CalcHitInfo(mouseEventArgs.Location);
            if (gridHitInfo.InRowCell)
            {
                var clsValue = gridView1.GetFocusedRowCellValue(gridView1.Columns["MRP_CLS_CD"]);
                if (clsValue.Equals("PAC_QTY"))
                {
                    var col = gridHitInfo.Column;
                    var row = gridView1.GetFocusedRow() as DataRowView;
                    if (Convert.ToDecimal(row[col.FieldName]) > 0)
                    {
                        _mrpArgs.MrpModelArgs.Select_Popup_YYYY_WK = col.FieldName;
                        _mrpArgs.MrpModelArgs.Selett_Popup_Item_Cd = row["ITEM_CD"].ToString();
                        _popupList.DataRefresh_PacPopup();
                        _popupList.ShowDialog();
                    }
                }
                if (clsValue.Equals("POD_QTY"))
                {
                    var col = gridHitInfo.Column;
                    var row = gridView1.GetFocusedRow() as DataRowView;
                    if (Convert.ToDecimal(row[col.FieldName]) > 0)
                    {
                        _mrpArgs.MrpModelArgs.Select_Popup_YYYY_WK = col.FieldName;
                        _mrpArgs.MrpModelArgs.Selett_Popup_Item_Cd = row["ITEM_CD"].ToString();
                        _popupList.DataRefresh_PoPopup();
                        _popupList.ShowDialog();
                    }
                }
                if (clsValue.Equals("POE_QTY"))
                {
                    var col = gridHitInfo.Column;
                    var row = gridView1.GetFocusedRow() as DataRowView;
                    if (Convert.ToDecimal(row[col.FieldName]) > 0)
                    {
                        _mrpArgs.MrpModelArgs.Select_Popup_YYYY_WK = col.FieldName;
                        _mrpArgs.MrpModelArgs.Selett_Popup_Item_Cd = row["ITEM_CD"].ToString();
                        _popupList.DataRefresh_PoePopup();
                        _popupList.ShowDialog();
                    }
                }

            }
        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var row = gridView1.GetRow(e.RowHandle) as DataRowView;

            var weekData = _mrpdModels.Where(a => a.ITEM_CD == row["ITEM_CD"].ToString() && a.YEAR_CD + "-" + a.WEEK_CD == e.Column.FieldName).SingleOrDefault();
            if (weekData != null && weekData.IsLeadTimeCheckCell == true)
            {
                e.Appearance.BackColor = Color.Yellow;
            }
            if (row["MRP_CLS_CD"].ToString().Equals("DIFF_QTY"))
            {
                if (e.Column.FieldName.Equals("MRP_CLS_NM") || _dynamicColumns.Where(a => a.ColumnName == e.Column.FieldName).Any())
                {
                    e.Appearance.BackColor = Color.Orange;
                }
            }
            if ((row["MRP_CLS_CD"].ToString().Equals("POE_QTY")
                            || row["MRP_CLS_CD"].ToString().Equals("POD_QTY")
                            || row["MRP_CLS_CD"].ToString().Equals("PAC_QTY"))
                        && _dynamicColumns.Where(a => a.ColumnName == e.Column.FieldName).Any())
            {
                decimal qty;
                if (decimal.TryParse(e.CellValue.ToString(), out qty))
                {
                    if (qty > 0)
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    }
                }
            }
            if (weekData != null && weekData.IsLeadTimeOverCell == true)
            {
                e.Appearance.BackColor = Color.LightSlateGray;
            }
            if (weekData != null && row["MRP_CLS_CD"].ToString().Equals("DIFF_QTY") && weekData.IsPorCheckCell == true)
            {
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                e.Appearance.ForeColor = Color.White;
                e.Appearance.BackColor = Color.Red;
            }
        }

        private void GridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            var itemCd_1 = gridView1.GetRowCellValue(e.RowHandle1, "ITEM_CD");
            var itemCd_2 = gridView1.GetRowCellValue(e.RowHandle2, "ITEM_CD");
            if (e.CellValue1.Equals(e.CellValue2) && itemCd_1.Equals(itemCd_2))
            {
                e.Merge = true;
            }
            else
            {
                e.Merge = false;
            }
            e.Handled = true;
        }

        private void InitColumns()
        {
            _selectedData = new DataTable();
            InitMrpMasterInfoColumns();
            if (_isInit)
            {
                gridControl1.DataSource = _selectedData;
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
                {
                    col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                }
                gridView1.Columns["MRP_CLS_CD"].Visible = false;
                gridView1.BestFitColumns();
            }
            if (!_isInit)
            {
                InitMrpDetailColums();    //동적컬럼 초기화
            }
            _isInit = false;
        }

        private void InitMrpMasterInfoColumns()
        {
            _selectedData.Clear();
            gridView1.Columns.Clear();
            StrapDataColumn dtCol;
            foreach (var col in _fixedColumnsInfo)
            {
                dtCol = new StrapDataColumn();
                dtCol.ColumnName = col.FieldName;
                dtCol.Caption = LanguagePack.GetTransWord(_sysLang, col.Caption) ?? col.Caption;
                dtCol.DataType = col.Type;
                _selectedData.Columns.Add(dtCol);
            }
        }

        private void InitMrpDetailColums()
        {
            _dynamicColumns = new List<StrapDataColumn>();
            var dynamicColumns = _mrpdModels.Select(a => new { a.YEAR_CD, a.WEEK_CD, a.WEEK_START_DT, a.WEEK_END_DT }).Distinct();
            StrapDataColumn dtCol;
            foreach (var col in dynamicColumns)
            {
                dtCol = new StrapDataColumn();
                dtCol.ColumnName = col.YEAR_CD + "-" + col.WEEK_CD;
                dtCol.Caption = col.WEEK_CD + "WK" + col.YEAR_CD.Substring(2) + "Y" + " "
                                        + col.WEEK_START_DT.ToString("MM-dd") + "~" + col.WEEK_END_DT.ToString("MM-dd");
                //Environment.NewLine
                dtCol.DataType = typeof(decimal);
                _selectedData.Columns.Add(dtCol);
                _dynamicColumns.Add(dtCol);
            }
        }

        public override void DataRefresh(ArgsBase args)
        {
            //_mrpArgs.MrpModelArgs.Select_Main_Mrh_No = "MRH20220103-00000001";
            gridView1.BeginUpdate();
            //Mrp Data
            _mrpmModels = _mrpPocket.SelectMrpmModels(_mrpArgs.MrpModelArgs);
            _mrpdModels = _mrpPocket.SelectMrpdModels(_mrpArgs.MrpModelArgs);

            _selectedData.BeginLoadData();
            InitColumns();  //컬럼 초기화
            SetMrpData();
            _selectedData.EndLoadData();

            gridControl1.DataSource = _selectedData;

            gridView1.BestFitColumns();
            //컬럼 설정
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                var containFixedColumn = _fixedColumnsInfo.Where(a => a.FieldName == col.FieldName).SingleOrDefault();
                if (containFixedColumn != null) //고정된 컬럼이면
                {
                    if (!string.IsNullOrEmpty(containFixedColumn.FormatString))
                    {
                        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        col.DisplayFormat.FormatString = containFixedColumn.FormatString;
                    }
                    if (!col.FieldName.Equals("MRP_CLS_NM"))    //구분은 제외하고 머지
                    {
                        col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                    }
                    else
                    {
                        col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                    }
                    if (!col.FieldName.Equals("TO_POR_QTY")) //발주필요수량 컬럼 제외하고 필터기능 없앰
                    {
                        col.OptionsFilter.AllowFilter = false;
                    }
                    col.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                }
                else
                {
                    col.OptionsFilter.AllowFilter = false;
                    col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                }
                if (_dynamicColumns.Where(a => a.ColumnName == col.FieldName).Any())
                {
                    col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    col.DisplayFormat.FormatString = "{0:#,##0}";
                    if (_mrpArgs.IsAutoRunAndSendMailMode)
                    {
                        col.Width = 150;
                    }
                    else
                    {
                        col.Width = 100;
                    }
                }
            }
            gridView1.Columns["MRP_CLS_CD"].Visible = false;
            //미착품뒤에 날짜표시
            string trLang = LanguagePack.GetTransWord(_sysLang, _fixedColumnsInfo.Where(a => a.FieldName == "NON_ARRIVAL_QTY").SingleOrDefault().Caption) ?? _fixedColumnsInfo.Where(a => a.FieldName == "NON_ARRIVAL_QTY").SingleOrDefault().Caption;
            gridView1.Columns["NON_ARRIVAL_QTY"].Caption = trLang + " (~" + _nonArrivalQty_MMdd + ")";
            gridView1.Columns["ITEM_NM"].Width = 150;
            if (_mrpArgs.IsAutoRunAndSendMailMode)
            {
                gridView1.Columns["NON_ARRIVAL_QTY"].Width = 150;
            }
            gridView1.EndUpdate();
        }

        private void SetMrpData()
        {
            DataRow dr;
            int totalRowCnt = 0;
            int itemRowCnt = 0;
            string beforeItemCd = string.Empty;
            decimal beforePlanStockQty = 0;
            _toPorItems = new List<ToPorItem>();

            foreach (var mrpmModel in _mrpmModels)
            {
                if (totalRowCnt == 0)
                {
                    beforeItemCd = mrpmModel.ITEM_CD;
                    _nonArrivalQty_MMdd = _mrpdModels.First().WEEK_START_DT.AddDays(-1).ToString("MM/dd");
                }
                else
                {
                    if (beforeItemCd != mrpmModel.ITEM_CD)
                    {
                        beforeItemCd = mrpmModel.ITEM_CD;
                        itemRowCnt = 0;
                    }
                }
                dr = _selectedData.NewRow();
                dr.SetField("ITEM_CD", mrpmModel.ITEM_CD);
                dr.SetField("ITEM_NM", mrpmModel.ITEM_NM);
                dr.SetField("ITEM_GR_1", mrpmModel.ITEM_GR_1);
                dr.SetField("LT", mrpmModel.LT);
                dr.SetField("WH_STOCK_QTY", mrpmModel.WH_STOCK_QTY);
                dr.SetField("NON_ARRIVAL_QTY", mrpmModel.NON_ARRIVAL_QTY);  //20220408 추가
                dr.SetField("SAFETY_TERM", mrpmModel.SAFETY_TERM);
                dr.SetField("TO_POR_QTY", mrpmModel.TO_POR_QTY);
                dr.SetField("MRP_CLS_CD", mrpmModel.MRP_CLS_CD);
                //구분 언어변환
                string trLang = "";
                trLang = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, mrpmModel.MRP_CLS_NM);
                if (!string.IsNullOrEmpty(trLang))
                {
                    dr.SetField("MRP_CLS_NM", trLang);
                }
                else
                {
                    dr.SetField("MRP_CLS_NM", mrpmModel.MRP_CLS_NM);
                }
                //디테일데이터
                var mrpdModelsByItem = _mrpdModels.Where(a => a.ITEM_CD == mrpmModel.ITEM_CD);
                int weekCnt = 0;
                foreach (var mrpdModel in mrpdModelsByItem)
                {
                    if (mrpmModel.LT == weekCnt) //if (mrpmModel.LT - 1 == weekCnt)
                    {
                        mrpdModel.IsLeadTimeCheckCell = true;
                    }
                    else if (mrpmModel.LT < weekCnt) //else if (mrpmModel.LT - 1 < weekCnt)
                    {
                        mrpdModel.IsLeadTimeOverCell = true;
                    }
                    switch (mrpmModel.MRP_CLS_CD)
                    {
                        case "POE_QTY":
                            dr.SetField(mrpdModel.YEAR_CD + "-" + mrpdModel.WEEK_CD, mrpdModel.POE_QTY);
                            break;
                        case "POD_QTY":
                            dr.SetField(mrpdModel.YEAR_CD + "-" + mrpdModel.WEEK_CD, mrpdModel.POD_QTY);
                            break;
                        case "PAC_QTY":
                            dr.SetField(mrpdModel.YEAR_CD + "-" + mrpdModel.WEEK_CD, mrpdModel.PAC_QTY);
                            break;
                        case "USAGE_QTY":
                            dr.SetField(mrpdModel.YEAR_CD + "-" + mrpdModel.WEEK_CD, mrpdModel.USAGE_QTY);
                            break;
                        case "SAFETY_QTY":
                            dr.SetField(mrpdModel.YEAR_CD + "-" + mrpdModel.WEEK_CD, mrpdModel.SAFETY_QTY);
                            break;
                        case "DIFF_QTY":
                            if (weekCnt == 0)
                            {
                                //mrpmModel.NON_ARRIVAL_QTY 미착품 추가 20220408
                                mrpdModel.DIFF_QTY = mrpmModel.WH_STOCK_QTY + mrpmModel.NON_ARRIVAL_QTY + mrpdModel.POD_QTY + mrpdModel.PAC_QTY - mrpdModel.SAFETY_QTY - mrpdModel.USAGE_QTY;
                                beforePlanStockQty = mrpdModel.DIFF_QTY + mrpdModel.SAFETY_QTY;
                            }
                            else
                            {
                                mrpdModel.DIFF_QTY = beforePlanStockQty + mrpdModel.POD_QTY + mrpdModel.PAC_QTY - mrpdModel.SAFETY_QTY - mrpdModel.USAGE_QTY;
                                beforePlanStockQty = mrpdModel.DIFF_QTY + mrpdModel.SAFETY_QTY;
                            }
                            if (mrpmModel.LT == weekCnt && mrpdModel.DIFF_QTY < 0) //if (mrpmModel.LT - 1 == weekCnt && mrpdModel.DIFF_QTY < 0)
                            {
                                mrpdModel.IsPorCheckCell = true;
                                _toPorItems.Add(new ToPorItem()
                                {
                                    ITEM_CD = mrpdModel.ITEM_CD,
                                    TO_POR_QTY = Math.Abs(mrpdModel.DIFF_QTY),
                                    //DUE_DT = DateTime.Now.Date.AddDays(mrpmModel.LT * 7)
                                    DUE_DT = mrpdModel.WEEK_END_DT.Date.AddDays(-2)     //주차종료일이 일요일이라 2일전 금요일로
                                });
                            }
                            dr.SetField(mrpdModel.YEAR_CD + "-" + mrpdModel.WEEK_CD, mrpdModel.DIFF_QTY);
                            break;
                        case "PLAN_STOCK_QTY":
                            mrpdModel.PLAN_STOCK_QTY = mrpdModel.SAFETY_QTY + mrpdModel.DIFF_QTY;
                            dr.SetField(mrpdModel.YEAR_CD + "-" + mrpdModel.WEEK_CD, mrpdModel.PLAN_STOCK_QTY);
                            break;
                        default:
                            break;
                    }
                    weekCnt += 1;
                }
                _selectedData.Rows.Add(dr);
                totalRowCnt += 1;
                if (mrpmModel.MRP_CLS_CD.Equals("PLAN_STOCK_QTY"))
                {
                    itemRowCnt += 1;
                }
                foreach (DataRow row in _selectedData.Rows)
                {
                    var toPorItem = _toPorItems.Where(a => a.ITEM_CD == row["ITEM_CD"].ToString());
                    if (toPorItem.Any())
                    {
                        row.SetField("TO_POR_QTY", Math.Abs(toPorItem.SingleOrDefault().TO_POR_QTY));
                    }
                }
            }
        }

        public string GetMailBody()
        {
            gridView1.ActiveFilterCriteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("TO_POR_QTY > 0");
            if (gridView1.RowCount == 0)
            {
                return "";
            }
            string body;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            gridView1.ExportToHtml(ms, new DevExpress.XtraPrinting.HtmlExportOptions
            {
                Title = "자재소요계획"
            });
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            string mailBodyTitle = StrapMessageBox.GetMessage("A001", 52); //부족자재현황
            string mailBodyFooter = StrapMessageBox.GetMessage("A001", 53); //※ DYA MES에서 자동으로 발송된 메일입니다. 
            using (System.IO.StreamReader reader = new System.IO.StreamReader(ms, Encoding.UTF8))
            {
                body = reader.ReadToEnd();
            }
            body = $"<h3>{ mailBodyTitle }</h3> <h5>({_mrpArgs.MrpModelArgs.Select_Main_Mrh_Dttm })</h5>"
                + body
                + $"<h5>{ mailBodyFooter } ({ DateTime.Now.ToString() })</h5>";
            return body;
        }

        public List<ToPorItem> ToPorItems
        {
            get
            {
                return _toPorItems;
            }
        }

        public override void ExcelExport(ArgsBase args)
        {
            //base.ExcelExport(args);
            Strap.FormControls.CommonLib.ExcelExport_GridView excelExport = new Strap.FormControls.CommonLib.ExcelExport_GridView();
            excelExport.Export(gridView1, this.LayoutControlGroup.Text);
        }
    }

    public class StrapDataColumn : DataColumn
    {
        /// <summary>
        /// 동적으로 추가되는 컬럼인지 아닌지 구분한다.
        /// </summary>
        public bool IsDynamicColumn { get; set; } = false;
    }

    public class FixedColumInfo
    {
        public string FieldName { get; set; }
        public string Caption { get; set; }
        public Type Type { get; set; }
        public string FormatString { get; set; } = null;
    }

    public class ToPorItem
    {
        public string ITEM_CD { get; set; }
        public decimal TO_POR_QTY { get; set; }
        public DateTime DUE_DT { get; set; }
    }

}

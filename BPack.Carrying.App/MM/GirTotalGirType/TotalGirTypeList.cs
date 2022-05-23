using BPack.Pocket.App.MM.GirTotalGirType;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Linq;

namespace BPack.Carrying.App.MM.GirTotalGirType
{
    public partial class TotalGirTypeList : StrapSubForm_Empty
    {
        private GirTotalGirTypeArgs _girTotalStockArgs;
        private GirTotalGirTypePocket _girTotalStockPocket;

        public TotalGirTypeList()
        {
            InitializeComponent();

            bandedGridView1.OptionsView.ShowFooter = true;
            bandedGridView1.OptionsView.ShowColumnHeaders = false;
            bandedGridView1.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            bandedGridView1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
        }

        public TotalGirTypeList(GirTotalGirTypeArgs girTotalStockArgs, GirTotalGirTypePocket girTotalStockPocket) : this()
        {
            _girTotalStockArgs = girTotalStockArgs;
            _girTotalStockPocket = girTotalStockPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            bandedGridView1.CustomDrawRowIndicator += (object sender, RowIndicatorCustomDrawEventArgs e) =>
            {
                if (e.RowHandle >= 0) e.Info.DisplayText = (e.RowHandle + 1).ToString();
            };
            bandedGridView1.OptionsSelection.MultiSelect = true;
            bandedGridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;
            strapGridControl1.UseEmbeddedNavigator = true;
            strapGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            strapGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            strapGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            strapGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            strapGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
        }
        public override void ExcelExport(ArgsBase args)
        {
            //base.ExcelExport(args);
            //gridView1.ExportToXlsx()
            try
            {
                Strap.FormControls.CommonLib.ExcelExport_GridView excelExport = new Strap.FormControls.CommonLib.ExcelExport_GridView();
                excelExport.Export(bandedGridView1, this.LayoutControlGroup.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }

        }
        public override void DataRefresh(ArgsBase args)
        {
            //base.DataRefresh(args);

            var source = _girTotalStockPocket.SelectTotalStockModels(_girTotalStockArgs.GirTotalGirTypeModelArgs);
            if (source == null || source.Rows.Count == 0)
            {
                strapGridControl1.DataSource = null;
                return;
            }
            strapGridControl1.DataSource = source;
            try
            {
                bandedGridView1.BeginUpdate();

                bandedGridView1.PopulateColumns();
                bandedGridView1.Bands.Clear();

                foreach (BandedGridColumn col in bandedGridView1.Columns)
                {
                    col.Visible = true;

                    if (col.FieldName.Contains("GR")) // 입고 밴드 추가
                    {
                        var gridBandGrCaption = "입고";
                        var gridBandGrName = "gridBandGR";

                        if (bandedGridView1.Bands.Where(r => r.Name == gridBandGrName).Count() < 1)
                        {
                            var gridBandGR = new GridBand();
                            gridBandGR.Caption = gridBandGrCaption;
                            gridBandGR.Name = gridBandGrName;
                            bandedGridView1.Bands.Add(gridBandGR);
                        }

                        var gridBand = new GridBand();
                        gridBand.Caption = col.FieldName;
                        gridBand.Name = gridBandGrName + col.FieldName;

                        gridBand.Columns.Add(col); // 밴드 내 컬럼 추가
                        var parentsBand = bandedGridView1.Bands.Where(r => r.Name == gridBandGrName).FirstOrDefault();
                        if (parentsBand != null) parentsBand.Children.Add(gridBand);

                    }
                    else if (col.FieldName.Contains("GI")) // 출고 밴드 추가
                    {
                        var gridBandGiCaption = "출고";
                        var gridBandGiName = "gridBandGI";

                        if (bandedGridView1.Bands.Where(r => r.Name == gridBandGiName).Count() < 1)
                        {
                            var gridBandGI = new GridBand();
                            gridBandGI.Name = gridBandGiName;
                            gridBandGI.Caption = gridBandGiCaption;
                            bandedGridView1.Bands.Add(gridBandGI);
                        }


                        var gridBand = new GridBand();
                        gridBand.Caption = col.FieldName;
                        gridBand.Name = gridBandGiName + col.FieldName;

                        gridBand.Columns.Add(col); // 밴드 내 컬럼 추가
                        var parentsBand = bandedGridView1.Bands.Where(r => r.Name == gridBandGiName).FirstOrDefault();
                        if (parentsBand != null) parentsBand.Children.Add(gridBand);

                    }
                    else // 기타 밴드 추가
                    {
                        var gridBandHeader = new GridBand();
                        gridBandHeader.Caption = col.FieldName;
                        gridBandHeader.Name = "gridBand" + col.FieldName;

                        gridBandHeader.Columns.Add(col); // 밴드 내 컬럼 추가
                        bandedGridView1.Bands.Add(gridBandHeader);
                    }

                    // 필터 및 정렬 처리
                    if (col.AbsoluteIndex > 4)
                    {
                        col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                        col.MinWidth = 120;

                        DevExpress.XtraGrid.GridColumnSummaryItem gridColumnSummaryItem = new DevExpress.XtraGrid.GridColumnSummaryItem();
                        gridColumnSummaryItem.FieldName = col.FieldName;
                        gridColumnSummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                        gridColumnSummaryItem.DisplayFormat = "{0:#,##0.#}";

                        if (col.Summary.Count == 0)
                        {
                            col.Summary.Add(gridColumnSummaryItem);
                        }
                    }

                }

                string trLangword;
                foreach (GridBand band in bandedGridView1.Bands)
                {
                    trLangword = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, band.Caption);
                    if (!string.IsNullOrEmpty(trLangword))
                    {
                        band.Caption = trLangword;
                    }
                }
                if (bandedGridView1.Columns["창고코드"] != null)
                {
                    bandedGridView1.Columns["창고코드"].Visible = false;
                    bandedGridView1.Columns["창고코드"].OwnerBand.Visible = false;
                }
                bandedGridView1.Bands["gridBand창고명"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                bandedGridView1.Bands["gridBand품번"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                bandedGridView1.Bands["gridBand품명"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
            finally
            {
                bandedGridView1.BestFitColumns();
                bandedGridView1.EndUpdate();
            }

        }

        public override void DataClear(ArgsBase args)
        {
            //base.DataClear(args);

            strapGridControl1.DataSource = null;
        }

    }
}

using BPack.Pocket.App.MM.GirTotalStock;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;

namespace BPack.Carrying.App.MM.GirTotalStock
{
    public partial class TotalStockList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirTotalStockArgs _girTotalStockArgs;
        private GirTotalStockPocket _girTotalStockPocket;

        public TotalStockList()
        {
            InitializeComponent();
        }

        public TotalStockList(GirTotalStockArgs girTotalStockArgs, GirTotalStockPocket girTotalStockPocket) : this()
        {
            _girTotalStockArgs = girTotalStockArgs;
            _girTotalStockPocket = girTotalStockPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
      
            gridView1.CustomDrawRowIndicator += (object sender, RowIndicatorCustomDrawEventArgs e) => 
            {
                if (e.RowHandle >= 0) e.Info.DisplayText = (e.RowHandle + 1).ToString(); 
            };
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

        public override void DataRefresh(ArgsBase args)
        {
            //base.DataRefresh(args);

            var source = _girTotalStockPocket.SelectTotalStockModels(_girTotalStockArgs.GirTotalStockModelArgs);
            strapGridControl1.DataSource = source;

            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
            gridView1.OptionsView.ShowFooter = true;

            foreach (GridColumn col in gridView1.Columns)
            {
                if (col.VisibleIndex > 4)
                {
                    col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;

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
        }

        public override void DataClear(ArgsBase args)
        {
            //base.DataClear(args);

            strapGridControl1.DataSource = null;
        }

    }
}

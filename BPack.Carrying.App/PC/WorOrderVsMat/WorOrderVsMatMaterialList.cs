using BPack.Common.Pocket;
using BPack.CommonMes.Config;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WorOrderVsMat;
using BPack.Pocket.App.PC.WorOrderVsMat;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Unicode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BPack.Carrying.App.PC.WorOrderVsMat
{
    public partial class WorOrderVsMatMaterialList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorOrderVsMatArgs _worOrderVsMatArgs;
        private WorOrderVsMatPocket _worOrderVsMatPocket;

        public WorOrderVsMatMaterialList()
        {
            InitializeComponent();

            //colLOC_STOCK_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colD_A_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colD_B_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colD_C_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colD_D_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colD_E_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colN_A_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colN_B_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colN_C_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colN_D_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colN_E_TIME_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
        }

        public WorOrderVsMatMaterialList(WorOrderVsMatArgs worOrderVsMatArgs, WorOrderVsMatPocket worOrderVsMatPocket) : this()
        {
            _worOrderVsMatArgs = worOrderVsMatArgs;
            _worOrderVsMatPocket = worOrderVsMatPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = worOrderVsMatHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _worOrderVsMatArgs,
                GridView = gridView1,
                InitModelType = typeof(WorOrderVsMatMaterialModel),
                ModelArgs = _worOrderVsMatArgs.WorOrderVsMatModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WorOrderVsMatModelArgs, WorOrderVsMatMaterialModel>(_worOrderVsMatPocket.SelectMaterialModels, null);

        }

        public override void DataRefresh(ArgsBase args)
        {
            var simplePocket = SimplePocket.GetInstance();
            var source = simplePocket.SelectData("Locations_WithWarehouse", new
            {
                COMP_CD = _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Main_Comp_Cd,
                PLANT_CD = _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Main_Plant_Cd,
                WH_CD = ""
            });
            var rps = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source);
            colMAT_LOC_CD.ColumnEdit = rps;

            base.DataRefresh(args);

            var models = (strapGridControl1.DataSource as System.Windows.Forms.BindingSource).DataSource as List<WorOrderVsMatMaterialModel>;

            if (models == null) return;

            var addModels = new List<WorOrderVsMatMaterialModel>();
            foreach (var model in models)
            {
                var addModel = (WorOrderVsMatMaterialModel)model.Copy();
                var remainStock = model.LOC_STOCK_QTY;
                addModel.GUBUN = "잔량";
                addModel.TOTAL_QTY = null;

                remainStock = remainStock - model.D_A_TIME_QTY;
                addModel.D_A_TIME_QTY = remainStock;

                remainStock = remainStock - model.D_B_TIME_QTY;
                addModel.D_B_TIME_QTY = remainStock;

                remainStock = remainStock - model.D_C_TIME_QTY;
                addModel.D_C_TIME_QTY = remainStock;

                remainStock = remainStock - model.D_D_TIME_QTY;
                addModel.D_D_TIME_QTY = remainStock;

                remainStock = remainStock - model.D_E_TIME_QTY;
                addModel.D_E_TIME_QTY = remainStock;

                remainStock = remainStock - model.N_A_TIME_QTY;
                addModel.N_A_TIME_QTY = remainStock;

                remainStock = remainStock - model.N_B_TIME_QTY;
                addModel.N_B_TIME_QTY = remainStock;

                remainStock = remainStock - model.N_C_TIME_QTY;
                addModel.N_C_TIME_QTY = remainStock;

                remainStock = remainStock - model.N_D_TIME_QTY;
                addModel.N_D_TIME_QTY = remainStock;

                remainStock = remainStock - model.N_E_TIME_QTY;
                addModel.N_E_TIME_QTY = remainStock;

                addModels.Add(addModel);
            }

            models.AddRange(addModels);

            models = models.OrderBy(r => r.MAT_LOC_CD).ThenBy(r => r.ITEM_CD).ThenBy(r => r.GUBUN).ToList();
            worOrderVsMatHeaderModelBindingSource.DataSource = models;
            (strapGridControl1.DataSource as System.Windows.Forms.BindingSource).ResetBindings(false);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            switch (e.Column.FieldName)
            {
                case "LOC_STOCK_QTY":
                case "D_A_TIME_QTY":
                case "D_B_TIME_QTY":
                case "D_C_TIME_QTY":
                case "D_D_TIME_QTY":
                case "D_E_TIME_QTY":
                case "N_A_TIME_QTY":
                case "N_B_TIME_QTY":
                case "N_C_TIME_QTY":
                case "N_D_TIME_QTY":
                case "N_E_TIME_QTY":
                case "TOTAL_QTY":
                    var cellValue = Convert.ToDecimal(e.CellValue ?? 0);
                    if (cellValue < 0)
                        e.Appearance.ForeColor = GlobalSettings.NgColor;
                    else
                        e.Appearance.ForeColor = Color.Black;
                    break;
            }
        }

        private void gridView1_CellMerge(object sender, CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            switch (e.Column.FieldName)
            {
                case "LOC_STOCK_QTY":
                case "ITEM_GR_1":
                    string text1 = view.GetRowCellDisplayText(e.RowHandle1, "ITEM_CD");
                    string text2 = view.GetRowCellDisplayText(e.RowHandle2, "ITEM_CD");
                    e.Merge = (text1 == text2);
                    e.Handled = true;
                    break;
            }
        }
    }
}

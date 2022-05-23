using BPack.Model.App.PC.WoeResult;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WoeResult;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.PC.WoeResult
{
    public partial class WoeOrderMaterialList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultArgs _woeResultArgs;
        private WoeResultPocket _woeResultPocket;

        public WoeOrderMaterialList()
        {
            InitializeComponent();
        }

        public WoeOrderMaterialList(WoeResultArgs woeResultArgs, WoeResultPocket woeResultPocket) :this()
        {
            _woeResultArgs = woeResultArgs;
            _woeResultPocket = woeResultPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = woeOrderMaterialModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultArgs,
                GridView = gridView1,
                InitModelType = typeof(WoeOrderMaterialModel),
                ModelArgs = _woeResultArgs.WoeResultModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeResultModelArgs, WoeOrderMaterialModel>(_woeResultPocket.SelectWoeOrderMaterialModels, _woeResultPocket.SaveWoeOrderMaterialModel);
            LookUpEditHelper.SetGridColumnSysCode(colMAT_INPUT_TYPE, "MAT_INPUT_TYPE");
            LookUpEditHelper.SetGridColumnSysCode(colORMA_STATUS, "ORMA_STATUS");

            gridView1.OptionsView.AllowCellMerge = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in gridView1.Columns)
            {
                col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            }
            colITEM_CD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colOPER_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colIS_BACKFLUSH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colMAT_INPUT_TYPE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            gridView1.CellMerge += GridView1_CellMerge;
        }

        private void GridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            var itemCd_1 = gridView1.GetRowCellValue(e.RowHandle1, colITEM_CD);
            var itemCd_2 = gridView1.GetRowCellValue(e.RowHandle2, colITEM_CD);
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

        internal void BpAutoInsertMaterial()
        {
            if (StrapMessageBox.Show("A001", 23, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _woeResultPocket.BpAutoInsertMaterial(_woeResultArgs.WoeResultModelArgs);
                }
                catch (Exception ex)
                {

                    StrapMessageBox.Show(ex.Message);
                }
            };
        }

        internal void BpManualInsertMaterial()
        {
            if (string.IsNullOrWhiteSpace(_woeResultArgs.WoeResultModelArgs.Scaned_Hu_No))
            {
                StrapMessageBox.Show("Scan!!");
                return;
            }
            if (StrapMessageBox.Show("A001", 24, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _woeResultPocket.BpManualInsertMaterial(_woeResultArgs.WoeResultModelArgs);
                    DataRefresh(_woeResultArgs);
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(ex.Message);
                }
            };
        }
    }
}

using BPack.Model.App.MM.HumEmptyLabel;
using BPack.Pocket.App.MM.HumEmptyLabel;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.HumEmptyLabel
{
    public partial class PrintedBarcodeList : StrapSubForm_OnlyOneGrid_V2
    {
        private HumEmptyLabelArgs _humEmptyLabelArgs;
        private HumEmptyLabelPocket _humEmptyLabelPocket;

        public PrintedBarcodeList()
        {
            InitializeComponent();

            gridView1.BeginDataUpdate();
            try
            {
                gridView1.ClearSorting();
                gridView1.Columns["CREATE_DTTM"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            }
            finally
            {
                gridView1.EndDataUpdate();
            }
        }

        public PrintedBarcodeList(HumEmptyLabelArgs humEmptyLabelArgs, HumEmptyLabelPocket humEmptyLabelPocket) : this()
        {
            this._humEmptyLabelArgs = humEmptyLabelArgs;
            this._humEmptyLabelPocket = humEmptyLabelPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid { 
                BindingSource = barcodeModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _humEmptyLabelArgs,
                GridView = gridView1,
                InitModelType = typeof(BarcodeModel),
                ModelArgs = _humEmptyLabelArgs.HumEmptyLabelModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<HumEmptyLabelModelArgs, BarcodeModel>(_humEmptyLabelPocket.SelectBarcodeModels, _humEmptyLabelPocket.SaveBarcodeModel, null);
            colIsCheck.VisibleIndex = 0;
            colIsCheck.Visible = false;
            //gridView1.OptionsBehavior.Editable = true;
            //colIsCheck.OptionsColumn.AllowEdit = true; 
            //gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }

        public List<BarcodeModel> GetCheckedData()
        {
            List<BarcodeModel> checkedBarcodeModels = new List<BarcodeModel>();
            //checkedBarcodeModels = ((List<BarcodeModel>)SelectedModels).Where(a => a.IsCheck == true).ToList();
            var selectedRowHandlers = gridView1.GetSelectedRows();
            foreach (var selectedRowHandler in selectedRowHandlers)
            {
                checkedBarcodeModels.Add(gridView1.GetRow(selectedRowHandler) as BarcodeModel);
            }
            //checkedBarcodeModels = gridView1.GetSelectedRows();
            return checkedBarcodeModels;
        }
    }
}

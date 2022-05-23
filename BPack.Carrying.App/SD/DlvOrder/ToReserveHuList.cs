using BPack.Model.App.SD.DlvOrder;
using BPack.Pocket.App.SD.DlvOrder;
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

namespace BPack.Carrying.App.SD.DlvOrder
{
    public partial class ToReserveHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvOrderArgs _dlvOrderArgs;
        private DlvOrderPocket _dlvOrderPocket;
        public event EventHandler<RowCheckChangedEventArgs> RowCheckChanged;
        public ToReserveHuList()
        {
            InitializeComponent();
        }

        public ToReserveHuList(DlvOrderArgs dlvOrderArgs, DlvOrderPocket dlvOrderPocket) : this()
        {
            this._dlvOrderArgs = dlvOrderArgs;
            this._dlvOrderPocket = dlvOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = bindingSource1,
                ExcelUploadModelType = null,
                FormArgs = _dlvOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(ToReserveHuModel),
                ModelArgs = _dlvOrderArgs.DlvOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvOrderModelArgs, ToReserveHuModel>(_dlvOrderPocket.SelectToReserveHuModels, null);
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.SelectionChanged += GridView1_SelectionChanged;
        }

        private void GridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var checkedRows = gridView1.GetSelectedRows();
            RowCheckChangedEventArgs rowCheckChangedEventArgs = new RowCheckChangedEventArgs();
            foreach (var rowHandle in checkedRows)
            {
                rowCheckChangedEventArgs.SumQtyCheckedRow += ((ToReserveHuModel)gridView1.GetRow(rowHandle)).STOCK_QTY;
            }
            RowCheckChanged?.Invoke(this, rowCheckChangedEventArgs);
        }

        public void AutoCheck(decimal autoCheckingQty)
        {
            decimal sumQty = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                sumQty += ((ToReserveHuModel)gridView1.GetRow(i)).STOCK_QTY;
                gridView1.SelectRow(i);
                if (sumQty >= autoCheckingQty)
                {
                    return;
                }
            }
        }

        internal List<ToReserveHuModel> GetSelectedModels()
        {
            List<ToReserveHuModel> toReserveHuModels = new List<ToReserveHuModel>();
            var checkedRows = gridView1.GetSelectedRows();
            foreach (var rowHandle in checkedRows)
            {
                toReserveHuModels.Add(gridView1.GetRow(rowHandle) as ToReserveHuModel);
            }
            return toReserveHuModels;
        }
    }

    public class RowCheckChangedEventArgs : EventArgs
    {
        public decimal SumQtyCheckedRow { get; set; }
    }
}

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
    public partial class ReservedHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvOrderArgs _dlvOrderArgs;
        private DlvOrderPocket _dlvOrderPocket;

        public ReservedHuList()
        {
            InitializeComponent();
        }

        public ReservedHuList(DlvOrderArgs dlvOrderArgs, DlvOrderPocket dlvOrderPocket) : this()
        {
            this._dlvOrderArgs = dlvOrderArgs;
            this._dlvOrderPocket = dlvOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bindingSource1,
                ExcelUploadModelType = null,
                FormArgs = _dlvOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(ReservedHuModel),
                ModelArgs = _dlvOrderArgs.DlvOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvOrderModelArgs, ReservedHuModel>(_dlvOrderPocket.SelectReservedHuModels, null);
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.OptionsBehavior.Editable = false;
        }

        internal decimal GetReservedSumQty()
        {
            return ((List<ReservedHuModel>)this.SelectedModels).Sum(a => a.STOCK_QTY);
        }

        internal List<ReservedHuModel> GetSelectedModels()
        {
            List<ReservedHuModel> reservedHuModels = new List<ReservedHuModel>();
            var checkedRows = gridView1.GetSelectedRows();
            foreach (var rowHandle in checkedRows)
            {
                reservedHuModels.Add(gridView1.GetRow(rowHandle) as ReservedHuModel);
            }
            return reservedHuModels;
        }
    }
}

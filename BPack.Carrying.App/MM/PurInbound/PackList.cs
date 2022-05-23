using BPack.Model.App.MM.PurInbound;
using BPack.Pocket.App.MM.PurInbound;
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

namespace BPack.Carrying.App.MM.PurInbound
{
    public partial class PackList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurInboundArgs _purInboundArgs;
        private PurInboundPocket _purInboundPocket;

        public PackList()
        {
            InitializeComponent();
        }

        public PackList(PurInboundArgs purInboundArgs, PurInboundPocket purInboundPocket) : this()
        {
            this._purInboundArgs = purInboundArgs;
            this._purInboundPocket = purInboundPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = purPackModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _purInboundArgs,
                GridView = gridView1,
                InitModelType = typeof(PurPackModel),
                ModelArgs = _purInboundArgs.PurInboundModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<PurInboundModelArgs, PurPackModel>(_purInboundPocket.SelectPurPackModels, null);
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
        }

        public List<PurPackModel> GetSelectedModels()
        {
            List<PurPackModel> purPackModels = new List<PurPackModel>();
            var selectedRows = gridView1.GetSelectedRows();

            foreach (var row in selectedRows)
            {
                purPackModels.Add(gridView1.GetRow(row) as PurPackModel);
            }
            return purPackModels;
        }
    }
}

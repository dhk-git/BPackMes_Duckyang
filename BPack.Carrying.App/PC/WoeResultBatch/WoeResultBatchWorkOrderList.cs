using BPack.Model.App.PC.WoeResultBatch;
using BPack.Pocket.App.PC.WoeResultBatch;
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

namespace BPack.Carrying.App.PC.WoeResultBatch
{
    public partial class WoeResultBatchWorkOrderList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultBatchArgs _woeResultBatchArgs;
        private WoeResultBatchPocket _woeResultBatchPocket;

        public WoeResultBatchWorkOrderList()
        {
            InitializeComponent();
        }

        public WoeResultBatchWorkOrderList(WoeResultBatchArgs woeResultBatchArgs, WoeResultBatchPocket woeResultBatchPocket) : this()
        {
            this._woeResultBatchArgs = woeResultBatchArgs;
            this._woeResultBatchPocket = woeResultBatchPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = woeResultBatchWorkOrderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultBatchArgs,
                GridView = gridView1,
                InitModelType = typeof(WoeResultBatchWorkOrderModel),
                ModelArgs = _woeResultBatchArgs.WoeResultBatchModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeResultBatchModelArgs, WoeResultBatchWorkOrderModel>(_woeResultBatchPocket.SelectWoeResultBatchWorkOrderModels, null, null);
        }
    }
}

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
    public partial class WoeResultBatchMatList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultBatchArgs _woeResultBatchArgs;
        private WoeResultBatchPocket _woeResultBatchPocket;

        public WoeResultBatchMatList()
        {
            InitializeComponent();
        }

        public WoeResultBatchMatList(WoeResultBatchArgs woeResultBatchArgs, WoeResultBatchPocket woeResultBatchPocket) : this()
        {
            this._woeResultBatchArgs = woeResultBatchArgs;
            this._woeResultBatchPocket = woeResultBatchPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = woeResultBatchMatModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultBatchArgs,
                GridView = gridView1,
                InitModelType = typeof(WoeResultBatchMatModel),
                ModelArgs = _woeResultBatchArgs.WoeResultBatchModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<WoeResultBatchModelArgs, WoeResultBatchMatModel>(_woeResultBatchPocket.SelectWoeresultBatchMatModels, null, null);
        }

        public List<WoeResultBatchMatModel> GetSelectedHuList()
        {
            return ((List<WoeResultBatchMatModel>)woeResultBatchMatModelBindingSource.DataSource)
                .Where(a => a.IsCheck == true).ToList();
        }
    }
}

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
    public partial class WoeResultBatchResultList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultBatchArgs _woeResultBatchArgs;
        private WoeResultBatchPocket _woeResultBatchPocket;

        public WoeResultBatchResultList()
        {
            InitializeComponent();
        }

        public WoeResultBatchResultList(WoeResultBatchArgs woeResultBatchArgs, WoeResultBatchPocket woeResultBatchPocket) : this()
        {
            this._woeResultBatchArgs = woeResultBatchArgs;
            this._woeResultBatchPocket = woeResultBatchPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = woeResultBatchResultModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultBatchArgs,
                GridView = gridView1,
                InitModelType = typeof(WoeResultBatchResultModel),
                ModelArgs = _woeResultBatchArgs.WoeResultBatchModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<WoeResultBatchModelArgs, WoeResultBatchResultModel>(_woeResultBatchPocket.SelectWoeResultBatchResultModels, null, null);
        }

        internal void OpenResultForm()
        {
            WoeResultBatchAddResult woeResultBatchAddResult = new WoeResultBatchAddResult(_woeResultBatchArgs, _woeResultBatchPocket);
            woeResultBatchAddResult.AddedResult += WoeResultBatchAddResult_AddedResult;
            woeResultBatchAddResult.ShowDialog();
        }

        private void WoeResultBatchAddResult_AddedResult(object sender, EventArgs e)
        {
            DataRefresh(_woeResultBatchArgs);
        }

        public List<WoeResultBatchResultModel> GetSelectedHuList()
        {
            return ((List<WoeResultBatchResultModel>)woeResultBatchResultModelBindingSource.DataSource)
                .Where(a => a.IsCheck == true).ToList();
        }

    }
}

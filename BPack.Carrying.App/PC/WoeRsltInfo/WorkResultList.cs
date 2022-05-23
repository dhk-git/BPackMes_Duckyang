using BPack.Model.App.PC.WoeRsltInfo;
using BPack.Pocket.App.PC.WoeRsltInfo;
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

namespace BPack.Carrying.App.PC.WoeRsltInfo
{
    public partial class WorkResultList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeRsltInfoArgs _woeRsltInfoArgs;
        private WoeRsltInfoPocket _woeRsltInfoPocket;

        public WorkResultList()
        {
            InitializeComponent();
        }

        public WorkResultList(WoeRsltInfoArgs woeRsltInfoArgs, WoeRsltInfoPocket woeRsltInfoPocket) : this()
        {
            this._woeRsltInfoArgs = woeRsltInfoArgs;
            this._woeRsltInfoPocket = woeRsltInfoPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = workResultModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeRsltInfoArgs,
                GridView = gridView1,
                InitModelType = typeof(WorkResultModel),
                ModelArgs = _woeRsltInfoArgs.woeRsltInfoModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeRsltInfoModelArgs, WorkResultModel>(_woeRsltInfoPocket.SelectWorkResultModels, null, null);
        }


    }
}

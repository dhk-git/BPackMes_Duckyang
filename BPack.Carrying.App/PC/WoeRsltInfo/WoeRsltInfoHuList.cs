using BPack.Common.Model;
using BPack.Model.App.PC.WoeRsltInfo;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WoeRsltInfo;

namespace BPack.Carrying.App.PC.WoeRsltInfo
{
    public partial class WoeRsltInfoHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeRsltInfoArgs _WoeRsltInfoArgs;
        private WoeRsltInfoPocket _WoeRsltInfoPocket;

        public WoeRsltInfoHuList(WoeRsltInfoArgs WoeRsltInfoArgs, WoeRsltInfoPocket WoeRsltInfoPocket)
        {
            InitializeComponent();

            _WoeRsltInfoArgs = WoeRsltInfoArgs;
            _WoeRsltInfoPocket = WoeRsltInfoPocket;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bsList,
                FormArgs = _WoeRsltInfoArgs,
                ModelArgs = _WoeRsltInfoArgs.woeRsltInfoModelArgs,
                InitModelType = typeof(WoeRsltInfoHuModel),
                GridView = gridView1
            });
            InitPocketDelegate<WoeRsltInfoModelArgs, WoeRsltInfoHuModel>(_WoeRsltInfoPocket.SelectWoeRsltInfoHuModels, null);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
        }
    }
}

using BPack.Common.Model;
using BPack.Model.App.PC.WoeRsltInfo;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WoeRsltInfo;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.PC.WoeRsltInfo
{
    public partial class WoeRsltInfoRsList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeRsltInfoArgs _WoeRsltInfoArgs;
        private WoeRsltInfoPocket _WoeRsltInfoPocket;

        public WoeRsltInfoRsList(WoeRsltInfoArgs WoeRsltInfoArgs, WoeRsltInfoPocket WoeRsltInfoPocket)
        {
            InitializeComponent();

            _WoeRsltInfoArgs = WoeRsltInfoArgs;
            _WoeRsltInfoPocket = WoeRsltInfoPocket;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource =bsList,
                FormArgs = _WoeRsltInfoArgs,
                ModelArgs = _WoeRsltInfoArgs.woeRsltInfoModelArgs,
                InitModelType = typeof(WoeRsltInfoRsModel),
                GridView = gridView1
            });
            InitPocketDelegate<WoeRsltInfoModelArgs, WoeRsltInfoRsModel>(_WoeRsltInfoPocket.SelectWoeRsltInfoRsModels, null);

            LookUpEditHelper.SetGridColumnSysCode(colRST_STATUS, "RST_STATUS");

        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
        }
    }
}

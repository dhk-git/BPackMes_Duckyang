using BPack.Common.Model;
using BPack.Model.App.PC.WoeRsltInfo;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WoeRsltInfo;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.PC.WoeRsltInfo
{
    public partial class WoeRsltInfoList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeRsltInfoArgs _WoeRsltInfoArgs;
        private WoeRsltInfoPocket _WoeRsltInfoPocket;

        public WoeRsltInfoList(WoeRsltInfoArgs WoeRsltInfoArgs, WoeRsltInfoPocket WoeRsltInfoPocket)
        {
            InitializeComponent();

            _WoeRsltInfoArgs = WoeRsltInfoArgs;
            _WoeRsltInfoPocket = WoeRsltInfoPocket;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bsList,
                FormArgs = _WoeRsltInfoArgs,
                ModelArgs = _WoeRsltInfoArgs.woeRsltInfoModelArgs,
                InitModelType = typeof(WoeRsltInfoModel),
                GridView = gridView1
            });
            InitPocketDelegate<WoeRsltInfoModelArgs, WoeRsltInfoModel>(_WoeRsltInfoPocket.SelectWoeRsltInfoModels, null);

            LookUpEditHelper.SetGridColumnSysCode(colWO_STATUS, "WO_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colWOD_STATUS, "WOD_STATUS");
            LookUpEditHelper.SetGridColumnByQuery(colSHIFT_CD, "ShiftList", new {
                COMP_CD = _WoeRsltInfoArgs.woeRsltInfoModelArgs.CompCd,
                PLANT_CD = _WoeRsltInfoArgs.woeRsltInfoModelArgs.PlantCd
            }, "근무조코드", "근무조명");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }
    }
}

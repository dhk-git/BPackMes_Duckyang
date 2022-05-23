using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvJisTrtRule;
using BPack.Pocket.App.MD.DlvJisTrtRule;
using BPack.Strap.FormControls;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvJisTrtRule
{
    public partial class DlvJisTrtRuleDetail : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvJisTrtRuleArgs _DlvJisTrtRuleArgs;
        private DlvJisTrtRulePocket _DlvJisTrtRulePocket;

        private DataGridView dataGridView1 = new DataGridView();

        public DlvJisTrtRuleDetail(DlvJisTrtRuleArgs DlvJisTrtRuleArgs, DlvJisTrtRulePocket DlvJisTrtRulePocket)
        {
            InitializeComponent();

            _DlvJisTrtRuleArgs = DlvJisTrtRuleArgs;
            _DlvJisTrtRulePocket = DlvJisTrtRulePocket;

        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvJisTrtRuleDetailBindingSource,
                FormArgs = _DlvJisTrtRuleArgs,
                ModelArgs = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs,
                InitModelType = typeof(DlvJisTrtRuleDetailModel),
                GridView = gridView1,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<DlvJisTrtRuleModelArgs, DlvJisTrtRuleDetailModel>(_DlvJisTrtRulePocket.SelectDlvJisTrtRuleDetailModels, _DlvJisTrtRulePocket.SaveDlvJisTrtRuleDetailModel, _DlvJisTrtRulePocket.SaveDlvJisTrtRuleDetailModels);

            colREMARK.Visible = false;
            colMODIFY_DTTM.Visible = false;
            colMODIFY_USER_ID.Visible = false;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((DlvJisTrtRuleDetailModel)model).COMP_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Comp_Cd;
            ((DlvJisTrtRuleDetailModel)model).PLANT_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Plant_Cd;
            ((DlvJisTrtRuleDetailModel)model).DLV_PLC_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Dlv_Plc_Cd;
            ((DlvJisTrtRuleDetailModel)model).TRT_RULE_ID = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Trt_Rule_ID;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }
    }
}

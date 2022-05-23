using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvJisTrtRule;
using BPack.Pocket.App.MD.DlvJisTrtRule;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MD.DlvJisTrtRule
{
    public partial class DlvJisTrtRuleHeader : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvJisTrtRuleArgs _DlvJisTrtRuleArgs;
        private DlvJisTrtRulePocket _DlvJisTrtRulePocket;

        public DlvJisTrtRuleHeader(DlvJisTrtRuleArgs DlvJisTrtRuleArgs, DlvJisTrtRulePocket DlvJisTrtRulePocket)
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
                BindingSource = dlvJisTrtRuleHeaderlBindingSource,
                FormArgs = _DlvJisTrtRuleArgs,
                ModelArgs = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs,
                InitModelType = typeof(DlvJisTrtRuleHeaderModel),
                GridView = gridView1
            });
            InitPocketDelegate<DlvJisTrtRuleModelArgs, DlvJisTrtRuleHeaderModel>(_DlvJisTrtRulePocket.SelectDlvJisTrtRuleHeaderModels, _DlvJisTrtRulePocket.SaveDlvJisTrtRuleHeaderModel);

            LookUpEditHelper.SetGridColumnSysCode(colALC_TRT_TYPE, "ALC_TRT_TYPE");
            LookUpEditHelper.SetGridColumnSysCode(colALC_TRT_METHOD, "ALC_TRT_METHOD");
            LookUpEditHelper.SetGridColumnSysCode(colALC_NO_SOURCE, "ALC_NO");
            LookUpEditHelper.SetGridColumnSysCode(colALC_NO_TARGET, "ALC_NO");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode", new { COMP_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Comp_Cd, PLANT_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명");

            colMODIFY_DTTM.Visible = false;
            colMODIFY_USER_ID.Visible = false;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((DlvJisTrtRuleHeaderModel)model).COMP_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Comp_Cd;
            ((DlvJisTrtRuleHeaderModel)model).PLANT_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Plant_Cd;
            ((DlvJisTrtRuleHeaderModel)model).DLV_PLC_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Dlv_Plc_Cd;
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode", new { COMP_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Comp_Cd, PLANT_CD = _DlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명");

            base.DataRefresh(args);

            gridView1.BestFitColumns();
        }

    }
}

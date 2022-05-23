using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvJisTrtRule;
using BPack.Pocket.App.MD.DlvJisTrtRule;
using BPack.Strap.FormControls;
using System;

namespace BPack.Carrying.App.MD.DlvJisTrtRule
{
    public partial class DlvJisTrtRuleMain : StrapMainForm
    {
        private DlvJisTrtRulePocket _dlvJisTrtRulePocket;
        private DlvJisTrtRuleArgs _dlvJisTrtRuleArgs;
        private DlvJisTrtRuleHeader _dlvJisTrtRuleHeader;
        private DlvJisTrtRuleDetail _dlvJisTrtRuleDetail;

        public DlvJisTrtRuleMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _dlvJisTrtRuleArgs = new DlvJisTrtRuleArgs();
            _dlvJisTrtRulePocket = new DlvJisTrtRulePocket();
            _dlvJisTrtRuleHeader = new DlvJisTrtRuleHeader(_dlvJisTrtRuleArgs, _dlvJisTrtRulePocket);
            _dlvJisTrtRuleDetail = new DlvJisTrtRuleDetail(_dlvJisTrtRuleArgs, _dlvJisTrtRulePocket);            

            AddSubForm(this, _dlvJisTrtRuleHeader, lcgHeader);
            AddSubForm(this, _dlvJisTrtRuleDetail, lcgDetail);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _dlvJisTrtRuleArgs,
                InitlistForm = _dlvJisTrtRuleHeader,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            _dlvJisTrtRuleHeader.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _dlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Comp_Cd = ((DlvJisTrtRuleHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                _dlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Plant_Cd = ((DlvJisTrtRuleHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
                _dlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Dlv_Plc_Cd = ((DlvJisTrtRuleHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_PLC_CD;
                _dlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Trt_Rule_ID = ((DlvJisTrtRuleHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).TRT_RULE_ID;
                _dlvJisTrtRuleDetail.DataRefresh(_dlvJisTrtRuleArgs);

                if(((DlvJisTrtRuleHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).ALC_TRT_TYPE == "ALC")
                {
                    lcgDetail.Enabled = true;
                    lcgDetail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                }
                else
                {
                    lcgDetail.Enabled = false;
                    lcgDetail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _dlvJisTrtRuleHeader) { SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true); }
                if (this.SelectedSubForm == _dlvJisTrtRuleDetail) { SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save:true); }
            };

            lueCOMP_CD.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(luePLANT_CD, new { COMP_CD = lueCOMP_CD.EditValue?.ToString() }, isFirstSelect:true);
            };

            luePLANT_CD.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetDeliveryPlace(lueDLV_PLC_CD, lueCOMP_CD.EditValue?.ToString(), luePLANT_CD.EditValue?.ToString(), isFirstSelect: true);
            };

            LookUpEditHelper.SetCompCode(lueCOMP_CD, isFirstSelect:true);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            lueCOMP_CD.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _dlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
            _dlvJisTrtRuleArgs.DlvJisTrtRuleModelArgs.Select_Main_Dlv_Plc_Cd = lueDLV_PLC_CD.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
            _dlvJisTrtRuleHeader.SelectModelAndRaiseEvent(0);
        }

        private void lueDLV_PLC_CD_EditValueChanged(object sender, EventArgs e)
        {
            Refresh_From_ExecuteByRibbonButton();
        }
    }
}

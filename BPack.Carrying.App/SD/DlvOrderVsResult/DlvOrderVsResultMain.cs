using BPack.CommonMes.Helpers;
using BPack.Pocket.App.SD.DlvOrderVsResult;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.SD.DlvOrderVsResult
{
    public partial class DlvOrderVsResultMain : StrapMainForm
    {
        private DlvOrderVsResultArgs _dlvOrderVsResultArgs;
        private DlvOrderVsResultPocket _dlvOrderVsResultPocket;
        private DlvOrderVsResultList _dlvOrderVsResultList;

        public DlvOrderVsResultMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _dlvOrderVsResultArgs = new DlvOrderVsResultArgs();
            _dlvOrderVsResultPocket = new DlvOrderVsResultPocket();
            _dlvOrderVsResultList = new DlvOrderVsResultList(_dlvOrderVsResultArgs, _dlvOrderVsResultPocket);
            AddSubForm(this, _dlvOrderVsResultList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _dlvOrderVsResultArgs,
                InitlistForm = _dlvOrderVsResultList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
            LookUpEditHelper.SetBusinessPartner(strapLookUpEdit2, Common.LoginInfo.UserInfo.CompCode, false, true, true, false, false);
        }
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvOrderVsResultArgs.DlvOrderVsResultModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _dlvOrderVsResultArgs.DlvOrderVsResultModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _dlvOrderVsResultArgs.DlvOrderVsResultModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _dlvOrderVsResultArgs.DlvOrderVsResultModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _dlvOrderVsResultArgs.DlvOrderVsResultModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit1.EditValue?.ToString();
            _dlvOrderVsResultArgs.DlvOrderVsResultModelArgs.Select_Main_Bp_Cd = strapLookUpEdit2.EditValue?.ToString();
            _dlvOrderVsResultArgs.DlvOrderVsResultModelArgs.Select_Main_IsTotalDate = checkEdit1.Checked ? "Y" : "N";

            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

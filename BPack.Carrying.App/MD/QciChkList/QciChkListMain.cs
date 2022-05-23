using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.QciChkList;
using System;

namespace BPack.Carrying.App.MD.QciChkList
{
    public partial class QciChkListMain : StrapMainForm
    {
        private QciChkListArgs _qciChkListArgs;
        private QciChkListPocket _qciChkListPocket;
        private QciChkList _qciChkList;

        public QciChkListMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _qciChkListArgs = new QciChkListArgs();
            _qciChkListPocket = new QciChkListPocket();
            _qciChkList = new QciChkList(_qciChkListArgs, _qciChkListPocket);
            AddSubForm(this, _qciChkList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _qciChkListArgs,
                InitlistForm = _qciChkList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
                LookUpEditHelper.SetCommonCode(strapLookUpEdit3, strapLookUpEdit1.EditValue?.ToString(), "INSP_DV", isFirstSelect: true);
            };
            
            strapLookUpEdit1.EditValue = BPack.Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _qciChkListArgs.QciChkListModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _qciChkListArgs.QciChkListModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            _qciChkListArgs.QciChkListModelArgs.Select_Main_Insp_Dv = strapLookUpEdit3.EditValue?.ToString();
            
            base.Refresh_From_ExecuteByRibbonButton();
        }


    }
}

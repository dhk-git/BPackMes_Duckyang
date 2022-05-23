using BPack.Common.LoginInfo;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.QciNcr;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.QciNcr;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;

namespace BPack.Carrying.App.MD.QciNcr
{
    public partial class QciNcrMain : StrapMainForm
    {
        private QciNcrArgs _QciNcrArgs;
        private QciNcrPocket _QciNcrPocket;
        private NcrTypeList _ncrTypeList;
        private NcrCodeList _ncrCodeList;

        public QciNcrMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _QciNcrArgs = new QciNcrArgs();
            _QciNcrPocket = new QciNcrPocket();
            _ncrTypeList = new NcrTypeList(_QciNcrArgs, _QciNcrPocket);
            _ncrCodeList = new NcrCodeList(_QciNcrArgs, _QciNcrPocket);

            AddSubForm(this, _ncrTypeList, layoutControlGroup2);
            AddSubForm(this, _ncrCodeList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _QciNcrArgs,
                InitlistForm = _ncrTypeList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                _QciNcrArgs.QciNcrModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();

                _ncrTypeList.DataRefresh(_QciNcrArgs);
                _ncrCodeList.DataRefresh(_QciNcrArgs);
            };

            _ncrTypeList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _QciNcrArgs.QciNcrModelArgs.Select_Type_Ncr_Type = ((QciNcrTypeModel)e.SelectedModelArgsBase.SelectedModelBase).NCR_TYPE;
                _ncrCodeList.DataRefresh(_QciNcrArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _ncrTypeList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
                if (this.SelectedSubForm == _ncrCodeList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _QciNcrArgs.QciNcrModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

   
    }
}

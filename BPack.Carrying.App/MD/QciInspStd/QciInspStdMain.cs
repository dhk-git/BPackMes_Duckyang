using BPack.Common.LoginInfo;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.QciInspStd;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.QciInspStd;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;

namespace BPack.Carrying.App.MD.QciInspStd
{
    public partial class QciInspStdMain : StrapMainForm
    {
        private QciInspStdArgs _qciInspStdArgs;
        private QciInspStdPocket _qciInspStdPocket;
        private StandardList _standardList;
        private RevisionList _revisionList;
        private CheckList _checkList;
        private CopyRevisionForm _copyRevisionForm;
        private CopyRevisionMultiForm _copyRevisionMultiForm;

        public QciInspStdMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _qciInspStdArgs = new QciInspStdArgs();
            _qciInspStdPocket = new QciInspStdPocket();
            _standardList = new StandardList(_qciInspStdArgs, _qciInspStdPocket);
            _revisionList = new RevisionList(_qciInspStdArgs, _qciInspStdPocket);
            _checkList = new CheckList(_qciInspStdArgs, _qciInspStdPocket);

            AddSubForm(this, _standardList, layoutControlGroup2);
            AddSubForm(this, _revisionList, layoutControlGroup3);
            AddSubForm(this, _checkList, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _qciInspStdArgs,
                InitlistForm = _standardList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
            strapButtonEdit_ItemMaster1.InitStrap();

            LookUpEditHelper.SetSysCode(strapLookUpEdit3, "INSP_TYPE", isFirstSelect: true);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);

                strapButtonEdit_ItemMaster1.InitCompCode(strapLookUpEdit1.EditValue?.ToString());
            };
            
            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                strapButtonEdit_ItemMaster1.InitPlantCode(strapLookUpEdit2.EditValue?.ToString());
            };

            _standardList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Insp_Std_ID = ((InspectionStandardModel)e.SelectedModelArgsBase.SelectedModelBase).INSP_STD_ID;
                _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Insp_type = ((InspectionStandardModel)e.SelectedModelArgsBase.SelectedModelBase).INSP_TYPE;
                _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Item_CD = ((InspectionStandardModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
                _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Max_Revision = ((InspectionStandardModel)e.SelectedModelArgsBase.SelectedModelBase).MAX_REVISION;
                _qciInspStdArgs.QciInspStdModelArgs.Select_Revision_Revision = null;

                _revisionList.DataRefresh(_qciInspStdArgs);
                _checkList.DataClear(_qciInspStdArgs);
                //_checkList.DataRefresh(_qciInspStdArgs);

            };

            _revisionList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _qciInspStdArgs.QciInspStdModelArgs.Select_Revision_Revision = ((InspectionRevisionModel)e.SelectedModelArgsBase.SelectedModelBase).REVISION;

                _checkList.DataRefresh(_qciInspStdArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _standardList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true); }
                if (this.SelectedSubForm == _revisionList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
                if (this.SelectedSubForm == _checkList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
            //strapLookUpEdit2.EditValue = Common.LoginInfo.UserInfo.PlantCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Insp_Type = strapLookUpEdit3.EditValue?.ToString();
            _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Item_CD = strapButtonEdit_ItemMaster1.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }


        /// <summary>
        /// 리비전 복사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void layoutControlGroup3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (_qciInspStdArgs.QciInspStdModelArgs.Select_Revision_Revision == null)
            {
                StrapMessageBox.Show("A001", 9);
                return;
            }

            switch (e.Button.Properties.Tag.ToString())
            {
                case "Insp_Revision_Copy":
                    _copyRevisionForm = new CopyRevisionForm(_qciInspStdArgs);
                    _copyRevisionForm.DataRefresh(_revisionList.GetSelectedUserModel());
                    _copyRevisionForm.Height = _copyRevisionForm.Height + 10;
                    _copyRevisionForm.ShowDialog();

                    _standardList.DataRefresh(_qciInspStdArgs);
                    _revisionList.DataRefresh(_qciInspStdArgs);
                    _checkList.DataRefresh(_qciInspStdArgs);
                    break;
                case "Insp_Revision_CopyMulti":
                    _copyRevisionMultiForm = new CopyRevisionMultiForm(_qciInspStdArgs);
                    _copyRevisionMultiForm.DataRefresh(_revisionList.GetSelectedUserModel());
                    _copyRevisionMultiForm.Height = _copyRevisionMultiForm.Height + 10;
                    _copyRevisionMultiForm.ShowDialog();

                    _standardList.DataRefresh(_qciInspStdArgs);
                    _revisionList.DataRefresh(_qciInspStdArgs);
                    _checkList.DataRefresh(_qciInspStdArgs);
                    break;
            }
        }
    }
}

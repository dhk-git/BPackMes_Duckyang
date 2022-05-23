using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.GirClose;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirClose;
using System;
using System.Windows.Forms;
using BPack.Common.LoginInfo;

namespace BPack.Carrying.App.MM.GirClose
{
    public partial class GirCloseMain : StrapMainForm
    {
        private GirCloseArgs _girCloseArgs;
        private GirClosePocket _girClosePocket;
        private CloseDateList _closeDateList;
        private CloseWhList _closeWhList;
        //private CloseLocList _closeLocList;
        private CloseGirTypeList _closeGirTypeList;

        string trLang;

        public GirCloseMain()
        {
            InitializeComponent();

            strapDateEdit1.DateTime = DateTime.Now.AddDays(-30);
            strapDateEdit2.DateTime = DateTime.Now;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _girCloseArgs = new GirCloseArgs();
            _girClosePocket = new GirClosePocket();
            _closeDateList = new CloseDateList(_girCloseArgs, _girClosePocket);
            _closeWhList = new CloseWhList(_girCloseArgs, _girClosePocket);
            //_closeLocList = new CloseLocList(_girCloseArgs, _girClosePocket);
            _closeGirTypeList = new CloseGirTypeList(_girCloseArgs, _girClosePocket);

            AddSubForm(this, _closeDateList, layoutControlGroup2);
            AddSubForm(this, _closeWhList, layoutControlGroup4);
            //AddSubForm(this, _closeLocList, layoutControlGroup5);
            AddSubForm(this, _closeGirTypeList, layoutControlGroup7);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _girCloseArgs,
                InitlistForm = _closeDateList,
                StrapLayout = strapLayout1
            });

            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, isFirstSelect: true);

            InitRibbonButtons(true);

            _closeDateList.ModelSelectedEvent += CloseDateList_ModelSelectedEvent;

            //2022.03.17 정수교 언어변환 
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, xtraTabPage1.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                xtraTabPage1.Text = trLang;
            }
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, xtraTabPage2.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                xtraTabPage2.Text = trLang;
            }

            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup4.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup4.Text = trLang;
            }
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup5.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup5.Text = trLang;
            }
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup7.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup7.Text = trLang;
            }


        }

        private void CloseDateList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _girCloseArgs.GirCloseModelArgs.Select_Close_Dt = ((CloseDateModel)e.SelectedModelArgsBase.SelectedModelBase).CLOSE_DT;
            _girCloseArgs.GirCloseModelArgs.Select_Gir_Close_Status = ((CloseDateModel)e.SelectedModelArgsBase.SelectedModelBase).GIR_CLOSE_STATUS;
            if (_girCloseArgs.GirCloseModelArgs.Select_Gir_Close_Status != null 
                && _girCloseArgs.GirCloseModelArgs.Select_Gir_Close_Status.Equals("S002"))
            {
                btnClose.Enabled = false;
            }
            else
            {
                btnClose.Enabled = true;
            }

            SearchDetailTab();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            SearchDetailTab();
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _girCloseArgs.GirCloseModelArgs.Select_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _girCloseArgs.GirCloseModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;//(DateTime)strapDateEdit1.EditValue;
            _girCloseArgs.GirCloseModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _girCloseArgs.GirCloseModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
            //if (xtraTabControl1.SelectedTabPageIndex == 0) base.Refresh_From_ExecuteByRibbonButton();
            //else if (xtraTabControl1.SelectedTabPageIndex == 1) _closeGirTypeList.DataRefresh(_girCloseArgs);
        }

        // 선택일 마감 버튼
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("A001", 19, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택된 행의 일자까지 마감처리 합니다.
            {
                var selectedModel = _closeDateList.GetSelectedModel();
                try
                {
                    //_girClosePocket.BpCloseGir(selectedModel);
                    _girClosePocket.BpCloseGir_Batch(selectedModel);
                    Common.Config.SystemConfig.RefreshServerDateTime();
                    selectedModel.CREATE_DTTM = Common.Config.SystemConfig.ServerDateTime;
                    selectedModel.MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime;
                    //_closeDateList.RowRefresh();
                    //_closeDateList.Focus();
                    _closeDateList.DataRefresh(_girCloseArgs);
                    SearchDetailTab();
                }
                catch (Exception ex)
                {
                    //selectedModel.GIR_CLOSE_STATUS = "S001";
                    _closeDateList.DataRefresh(_girCloseArgs);
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex)); 
                }
            };
        }

        private void SearchDetailTab()
        {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                _closeWhList.DataRefresh(_girCloseArgs);
                //_closeLocList.DataRefresh(_girCloseArgs);
            }
            else if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                _closeGirTypeList.DataRefresh(_girCloseArgs);
            }
        }
        //선택일 마감취소 버튼
        private void btnCloseCancel_Click(object sender, EventArgs e)
        {
            string msg = StrapMessageBox.GetMessage("A001", 106) + ((DateTime)_girCloseArgs.GirCloseModelArgs.Select_Close_Dt).ToString("MM-dd-yyyy");
            if (StrapMessageBox.Show(msg, MessageBoxButtons.YesNo) == DialogResult.Yes) //"선택일 이후 모든 마감이 삭제됩니다.\r\n 선택일 : 
            {
                var selectedModel = _closeDateList.GetSelectedModel();
                try
                {
                    //_closeDateList.CloseCancelGir();
                    _girClosePocket.BpCloseGirCancel(selectedModel);
                    _closeDateList.DataRefresh(_girCloseArgs);
                    _closeWhList.DataClear(_girCloseArgs);
                    //_closeLocList.DataClear(_girCloseArgs);
                    _closeGirTypeList.DataClear(_girCloseArgs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }

            };
        }
    }
}

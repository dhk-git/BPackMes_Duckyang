using BPack.Carrying.App.QC.AppLine;
using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.AppHist;
using BPack.Pocket.App.QC.AppHist;
using BPack.Strap.FormControls;
using BPack.Strap.FormControls.CommonLib;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.AppHist
{
    public partial class AppHistRequestMain : StrapMainForm
    {
        private AppHistArgs _AppHistArgs;
        private AppHistPocket _AppHistPocket;

        private AppHistHeaderList _AppHistHeaderList;
        private AppHistDetailList _AppHistDetailList;
        private AppHistDetailInspList _AppHistDetailInspList;

        public AppHistRequestMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _AppHistArgs = new AppHistArgs();
            _AppHistArgs.AppHistModelArgs.Select_Main_Opt = "1";
            _AppHistArgs.AppHistModelArgs.Select_Main_User_Id = UserInfo.UserID;

            _AppHistPocket = new AppHistPocket();
            _AppHistHeaderList = new AppHistHeaderList(_AppHistArgs, _AppHistPocket);
            _AppHistDetailList = new AppHistDetailList(_AppHistArgs, _AppHistPocket);
            _AppHistDetailInspList = new AppHistDetailInspList(_AppHistArgs, _AppHistPocket);

            AddSubForm(this, _AppHistHeaderList, lcgHeader);
            AddSubForm(this, _AppHistDetailList, lcgDetail);
            AddSubForm(this, _AppHistDetailInspList, lcgDetailInsp);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _AppHistArgs,
                InitlistForm = _AppHistHeaderList,
                StrapLayout = strapLayout1
            });

            dteREQ_DT_FROM.EditValue = dteREQ_DT_TO.EditValue = DateTime.Now;

            InitRibbonButtons(true, false, false, false);

            /*
            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _AppHistHeaderJISList) { SetRibbonButtonsEnable_ByAuth(true);}
                else if (this.SelectedSubForm == _AppHistHeaderJITList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                else if (this.SelectedSubForm == _AppHistDetailList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                else if (this.SelectedSubForm == _AppHistDetailJITList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                else if (this.SelectedSubForm == _AppHistDetailInspList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                else { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
            };
            */

            // 권한에 따라 버튼 제어 
            ControlAuth();

            LookUpEditHelper.SetSysCode(lueINSP_APP_STATUS, "INSP_APP_STATUS", isFirstSelect: true);

            LookUpEditHelper.SetCompCode(lueCOMP_CD, isFirstSelect: true);
            lueCOMP_CD.EditValue = BPack.Common.LoginInfo.UserInfo.CompCode;

            lueCOMP_CD.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(luePLANT_CD, new { COMP_CD = lueCOMP_CD.EditValue?.ToString() }, isFirstSelect: true);
            };

            LookUpEditHelper.SetPlantCode(luePLANT_CD, lueCOMP_CD.EditValue?.ToString(), isFirstSelect: true);

            lueINSP_APP_STATUS.EditValueChanged += txtREF_NO_EditValueChanged;
            dteREQ_DT_FROM.EditValueChanged += txtREF_NO_EditValueChanged;
            dteREQ_DT_TO.EditValueChanged += txtREF_NO_EditValueChanged;

            _AppHistHeaderList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _AppHistArgs.AppHistModelArgs.Select_Ref_No = ((AppHistHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).REF_NO;
                _AppHistDetailList.DataRefresh(_AppHistArgs);
                _AppHistDetailList.SelectModelAndRaiseEvent(0);
            };

            _AppHistDetailList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                // 현재 검사번호와 새로 선택된 검사번호가 다른 경우 
                if(_AppHistArgs.AppHistModelArgs.Select_Insp_No != ((AppHistDetailModel)e.SelectedModelArgsBase.SelectedModelBase).INSP_NO)
                {
                    _AppHistArgs.AppHistModelArgs.Select_Insp_No = ((AppHistDetailModel)e.SelectedModelArgsBase.SelectedModelBase).INSP_NO;
                    _AppHistArgs.AppHistModelArgs.Select_File_Name = ((AppHistDetailModel)e.SelectedModelArgsBase.SelectedModelBase).FILE_NAME;
                    _AppHistArgs.AppHistModelArgs.Select_File_Name_In_Server = ((AppHistDetailModel)e.SelectedModelArgsBase.SelectedModelBase).FILE_NAME_IN_SERVER;

                    _AppHistDetailInspList.DataRefresh(_AppHistArgs);

                    RefreshImage();
                }
            };

            txtREF_NO_EditValueChanged(this, null);
        }

        private void RefreshAppHistHeader()
        {
            _AppHistHeaderList.DataClear(_AppHistArgs);
            _AppHistDetailList.DataClear(_AppHistArgs);
            _AppHistDetailInspList.DataClear(_AppHistArgs);

            _AppHistArgs.AppHistModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _AppHistArgs.AppHistModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
            _AppHistArgs.AppHistModelArgs.Select_Main_Req_Dt_From = (DateTime)dteREQ_DT_FROM.EditValue;
            _AppHistArgs.AppHistModelArgs.Select_Main_Req_Dt_To = (DateTime)dteREQ_DT_TO.EditValue;
            _AppHistArgs.AppHistModelArgs.Select_Main_Ref_No = txtREF_NO.Text;
            _AppHistArgs.AppHistModelArgs.Select_Main_Insp_App_Status_List = lueINSP_APP_STATUS.EditValue?.ToString();

            _AppHistArgs.AppHistModelArgs.Select_Ref_No = null;
            _AppHistArgs.AppHistModelArgs.Select_Insp_No = null;
            _AppHistArgs.AppHistModelArgs.Select_File_Name = null;
            _AppHistArgs.AppHistModelArgs.Select_File_Name_In_Server = null;

            _AppHistHeaderList.DataRefresh(_AppHistArgs);
            _AppHistHeaderList.SelectModelAndRaiseEvent(0);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            lueINSP_APP_STATUS.EditValueChanged -= txtREF_NO_EditValueChanged;
            dteREQ_DT_FROM.EditValueChanged -= txtREF_NO_EditValueChanged;
            dteREQ_DT_TO.EditValueChanged -= txtREF_NO_EditValueChanged;

            _AppHistArgs.AppHistModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _AppHistArgs.AppHistModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
            _AppHistArgs.AppHistModelArgs.Select_Main_Req_Dt_From = (DateTime)dteREQ_DT_FROM.EditValue;
            _AppHistArgs.AppHistModelArgs.Select_Main_Req_Dt_To = (DateTime)dteREQ_DT_TO.EditValue;
            _AppHistArgs.AppHistModelArgs.Select_Main_Ref_No = txtREF_NO.Text;
            _AppHistArgs.AppHistModelArgs.Select_Main_Insp_App_Status_List = lueINSP_APP_STATUS.EditValue?.ToString();

            _AppHistArgs.AppHistModelArgs.Select_Ref_No = null;
            _AppHistArgs.AppHistModelArgs.Select_Insp_No = null;
            _AppHistArgs.AppHistModelArgs.Select_File_Name = null;
            _AppHistArgs.AppHistModelArgs.Select_File_Name_In_Server = null;

            base.Refresh_From_ExecuteByRibbonButton();

            _AppHistHeaderList.SelectModelAndRaiseEvent(0);

            lueINSP_APP_STATUS.EditValueChanged += txtREF_NO_EditValueChanged;
            dteREQ_DT_FROM.EditValueChanged += txtREF_NO_EditValueChanged;
            dteREQ_DT_TO.EditValueChanged += txtREF_NO_EditValueChanged;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AppHistDetailInspList.GetSelectedModels().Count == 0)
                    return;

                var printSys = new PrintingSystem();
                printSys.ShowMarginsWarning = false;

                var dlvReport = new AppHistReport(_AppHistHeaderList.GetSelectedModel()
                                                 , _AppHistDetailList.GetSelectedModel()
                                                 , _AppHistDetailInspList.GetSelectedModels()
                                                 , picImage.Image);
                dlvReport.CreateDocument();
                printSys.Pages.AddRange(dlvReport.Pages);

                if (printSys.Pages.Count < 1) return;

                var printTool = new DevExpress.XtraPrinting.PrintTool(printSys);
                printTool.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
            }
        }

        private void txtREF_NO_EditValueChanged(object sender, EventArgs e)
        {
            RefreshAppHistHeader();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (_AppHistHeaderList.GetSelectedModels() == null)
                {
                    StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                    _AppHistHeaderList.Focus();
                    return;
                }

                var checkedModels = ((List<AppHistHeaderModel>)_AppHistHeaderList.SelectedModels).Where(a => a.IsCheck == true).ToList();
                if (checkedModels.Count == 0)
                {
                    StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                    _AppHistHeaderList.Focus();
                    return;
                }

                // 선택된  행들을 가지고, 결재요청 popup을 띄운다. 
                AppHistRequest _appHistRequest = new AppHistRequest(UserInfo.UserID, (List<AppHistHeaderModel>)checkedModels);
                
                if(_appHistRequest.ShowDialog() == DialogResult.OK)
                {
                    RefreshAppHistHeader();
                }
            }
            catch(Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
            }
        }
        private void ControlAuth()
        {
            if (LoginMenuAuthModel.UPDATE_AUTH == true)
            {
                btnAppLine.Enabled = true;
                btnRequest.Enabled = true;
                btnRemark.Enabled = true;
            }
            else
            {
                btnAppLine.Enabled = false;
                btnRequest.Enabled = false;
                btnRemark.Enabled = false;
            }
        }

        private void RefreshImage()
        {
            try
            {
                picImage.Image = null;

                if (_AppHistArgs.AppHistModelArgs.Select_File_Name_In_Server == null ||
                    _AppHistArgs.AppHistModelArgs.Select_File_Name_In_Server == string.Empty)
                    return;

                FileUpDownloader fud = new FileUpDownloader();
                FileDownloadModel fileDownloadModel = new FileDownloadModel()
                {
                    FileName = _AppHistArgs.AppHistModelArgs.Select_File_Name,
                    FileNameInServer = _AppHistArgs.AppHistModelArgs.Select_File_Name_In_Server,
                    //SavingPath = KnownFolders.Downloads.Path
                    //SavingPath = "C:\\Temp\\Images\\"
                };

                MemoryStream stream = new MemoryStream(fud.DownloadImage(fileDownloadModel));
                picImage.Image = Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
            }
        }

        private void btnAppLine_Click(object sender, EventArgs e)
        {
            try
            {
                // 결재선 관리 popup을 띄운다.
                AppLineList _appLineList  = new AppLineList(UserInfo.UserID);
                _appLineList.ShowDialog();
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
            }
        }
    }
}

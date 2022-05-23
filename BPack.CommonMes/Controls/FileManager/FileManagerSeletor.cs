using BPack.Common.Model;
using BPack.Strap.FormControls;
using BPack.Strap.FormControls.CommonLib;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BPack.CommonMes.Controls.FileManager
{
    public partial class FileManagerSeletor : DevExpress.XtraEditors.XtraForm
    {
        public FileManagerModelArgs _FileManagerModelArgs;
        private FileManagerPocket _FileManagerPocket;
        private FileManagerSaveEventArgs _FileManagerSelectedEventArgs;
        public event EventHandler<FileManagerSaveEventArgs> SaveComplate;

        private FileManagerFileGroupModel _fileManagerFileGroupModel;

        public FileManagerSeletor()
        {
            InitializeComponent();

            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            _FileManagerModelArgs = new FileManagerModelArgs();
            _FileManagerPocket = new FileManagerPocket();
            _FileManagerSelectedEventArgs = new FileManagerSaveEventArgs();
            gridView1.OptionsView.ColumnAutoWidth = false;
            StrapEdit_FromModelAnnotation sefma = new StrapEdit_FromModelAnnotation();
            sefma.SetGridColumn(typeof(FileManagerFileModel), gridView1);
            this.KeyPreview = true;
        }

        //조회버튼
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataRefresh();
        }

        //취소버튼
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //업로드버튼
        private void btnUpload_Click(object sender, EventArgs e)
        {
            FileUpDownloader fud = new FileUpDownloader();
            fud.MultiFileChanged += Fud_MultiFileChanged;

            var source = (fileManagerFileModelBindingSource.DataSource as List<FileManagerFileModel>);
            if (source.Count > _FileManagerModelArgs.FileCountLimit)
            {
                StrapMessageBox.Show("A003", 16, MessageBoxButtons.OK);
                return;
            }

            FileUploadModel fileUploadModel = new FileUploadModel()
            {
                SaveSubDir = _FileManagerModelArgs.SaveSubDir,
                FilterString = _FileManagerModelArgs.FilterString,
                UserID = Common.LoginInfo.UserInfo.UserID
            };

            var uploadFileList = fud.UploadMultiWithDialog(fileUploadModel);
            if (uploadFileList == null || uploadFileList.Count < 1)
            {
                return;
            }
            if (_FileManagerModelArgs.FileCountLimit != 0 && uploadFileList.Count > _FileManagerModelArgs.FileCountLimit)
            {
                StrapMessageBox.Show("A003", 16, MessageBoxButtons.OK);
                return;
            }

            UploadFiles(uploadFileList);
            DataRefresh();
            SelectComplate();
        }

        //삭제버튼
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // WebAPI 호출 - 파일 삭제 기능 구현하여 적용
        }

        //다운로드버튼
        private void btnDownload_Click(object sender, EventArgs e)
        {
            FileUpDownloader fud = new FileUpDownloader();
            List<FileDownloadModel> fileDownloadModels = new List<FileDownloadModel>();
            var models = (fileManagerFileModelBindingSource?.DataSource as List<FileManagerFileModel>).Where(r => r.IsCheck);
            if (models.Count() == 0)
            {
                StrapMessageBox.Show("A001", 9, MessageBoxButtons.OK);
                return;
            }

            foreach (var model in models)
            {

                fileDownloadModels.Add(new FileDownloadModel()
                {
                    FileName = model.FILE_NAME,
                    FileNameInServer = model.FILE_NAME_IN_SERVER,
                    SavingPath = KnownFolders.Downloads.Path,
                    UserID = Common.LoginInfo.UserInfo.UserID
                });
            }
            fud.DownloadMulti(fileDownloadModels);
            System.Diagnostics.Process.Start(KnownFolders.Downloads.Path);
        }


        public void DataRefresh()
        {
            strapTextEdit1.EditValue = _FileManagerModelArgs.Select_Main_File_Group_ID;
            strapTextEdit3.EditValue = _FileManagerModelArgs.FileCountLimit;

            if (_FileManagerModelArgs.Select_Main_File_Group_ID != null)
            {
                _fileManagerFileGroupModel = _FileManagerPocket.SelectFileManagerFileGroupModels(_FileManagerModelArgs);
                strapTextEdit2.EditValue = _fileManagerFileGroupModel?.FILE_GROUP_NM;
            }
            else
            {
                strapTextEdit2.EditValue = null;
            }

            fileManagerFileModelBindingSource.DataSource = _FileManagerPocket.SelectFileManagerFileModels(_FileManagerModelArgs);

            gridView1.BestFitColumns();
            gridView1.Focus();

        }

        public void DataClear()
        {
            fileManagerFileModelBindingSource.Clear();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //base.OnClosing(e);
            e.Cancel = true;
            this.Hide();
        }

        //ESC로 닫히도록
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void SelectComplate()
        {
            _FileManagerSelectedEventArgs.SelectedFileGroupId = _FileManagerModelArgs.Select_Main_File_Group_ID;
            SaveComplate?.Invoke(this, _FileManagerSelectedEventArgs);

            this.Hide();
        }


        private void FileManagerSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DataRefresh();
            }
        }

        private void Fud_MultiFileChanged(object sender, MultiFileChangedEventArgs e)
        {
            System.Diagnostics.Debug.Print(e.FileName);
        }

        public void UploadFiles(List<FileUploadReturnModel> fileUploadReturnModels)
        {
            FileManagerFileModel FileManagerFileModel;
            List<FileManagerFileModel> FileManagerFileModels = new List<FileManagerFileModel>();

            if (string.IsNullOrEmpty(_FileManagerModelArgs.Select_Main_File_Group_ID?.ToString().Trim()))
            {
                _FileManagerModelArgs.Select_Main_File_Group_ID = _FileManagerPocket.CreateFileGroupID();
                strapTextEdit1.EditValue = _FileManagerModelArgs.Select_Main_File_Group_ID;
            }

            string fileGroupNm = "";
            foreach (var model in fileUploadReturnModels)
            {
                fileGroupNm += model.FileName;
                fileGroupNm += ", ";
            }

            foreach (var model in fileUploadReturnModels)
            {
                FileManagerFileModel = new FileManagerFileModel();
                FileManagerFileModel.RowState = RowState.Added;
                FileManagerFileModel.CREATE_DTTM = DateTime.Now;
                FileManagerFileModel.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                FileManagerFileModel.MODIFY_DTTM = DateTime.Now;
                FileManagerFileModel.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
                FileManagerFileModel.LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language;

                FileManagerFileModel.FILE_GROUP_ID_KEY = _FileManagerModelArgs.Select_Main_File_Group_ID;
                FileManagerFileModel.FILE_GROUP_ID = _FileManagerModelArgs.Select_Main_File_Group_ID;
                FileManagerFileModel.FILE_GROUP_NM = fileGroupNm;
                FileManagerFileModel.MENU_ID = _FileManagerModelArgs.Select_Main_Menu_ID;

                FileManagerFileModel.FILE_NAME = model.FileName;
                FileManagerFileModel.FILE_NAME_IN_SERVER = model.FileNameInServer;
                FileManagerFileModels.Add(FileManagerFileModel);
            }

            if (FileManagerFileModels.Count > 0)
                _FileManagerPocket.SaveFileManagerFileModelModels(FileManagerFileModels);
        }

    }
}

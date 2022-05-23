using BPack.Strap.EditControls;
using System;
using System.ComponentModel;

namespace BPack.CommonMes.Controls.FileManager
{
    [ToolboxItem(true)]
    public class FileManagerButtonEdit : StrapButtonEdit
    {
        private FileManagerSeletor _FileManagerSelector;
        public event EventHandler<FileManagerSaveEventArgs> SaveComplate;

        public FileManagerButtonEdit()
        {
            
        }

        public void InitStrap(string menuID, string saveSubDir, string filterString = "*.*|*.*", int fileCountLimit = 0)
        {
            this.ToolTip = "우측(···)버튼 혹은 F1 키를 누르면 파일관리창이 뜹니다.";
            _FileManagerSelector = new FileManagerSeletor();
            _FileManagerSelector.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ButtonClick += StrapButtonEdit_ButtonClick;
            this.KeyDown += StrapButtonEdit_KeyDown;
            _FileManagerSelector.SaveComplate += FileManagerSelector_SelectedComplate;
            this.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

            _FileManagerSelector._FileManagerModelArgs.Select_Main_Menu_ID  = menuID;
            _FileManagerSelector._FileManagerModelArgs.SaveSubDir = saveSubDir;
            _FileManagerSelector._FileManagerModelArgs.FilterString = filterString;
            _FileManagerSelector._FileManagerModelArgs.FileCountLimit = fileCountLimit;
        }

        public void SetFileGroupID(string fileGroupID)
        {
            _FileManagerSelector._FileManagerModelArgs.Select_Main_File_Group_ID = fileGroupID;
        }

        private void FileManagerSelector_SelectedComplate(object sender, FileManagerSaveEventArgs e)
        {
            this.EditValue = e.SelectedFileGroupId;
            SaveComplate?.Invoke(this, e);
        }

        private void StrapButtonEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.F1)
            {
                _FileManagerSelector.DataRefresh();
                _FileManagerSelector.ShowDialog();
            }
        }

        private void StrapButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _FileManagerSelector.DataRefresh();
            _FileManagerSelector.ShowDialog();
        }

        public void DataClear()
        {
            _FileManagerSelector.DataClear();
        }

    }
}

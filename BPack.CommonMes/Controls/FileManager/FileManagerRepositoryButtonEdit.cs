using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;

namespace BPack.CommonMes.Controls.FileManager
{
    public class FileManagerRepositoryButtonEdit : DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    {
        private FileManagerSeletor _FileManagerSelector;
        private GridColumn _gridColumn;
        private GridView _gridView;
        public event EventHandler<FileManagerSaveEventArgs> SaveComplete;

        public FileManagerRepositoryButtonEdit(GridColumn gridColumn, GridView gridView)
        {
            _gridColumn = gridColumn;
            _gridView = gridView;
            _gridColumn.ColumnEdit = this;
        }

        public void InitStrap(string menuID, string saveSubDir, string filterString = "*.*|*.*", int fileCountLimit = 0)
        {
            this.Buttons[0].ToolTip = "우측(···)버튼 혹은 F1 키를 누르면 파일관리창이 뜹니다.";
            _FileManagerSelector = new FileManagerSeletor();
            _FileManagerSelector.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ButtonClick += StrapButtonEdit_ButtonClick;
            this.KeyDown += StrapButtonEdit_KeyDown;
            _FileManagerSelector.SaveComplate += FileManagerSelector_SelectedComplate; ;
            this.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

            _FileManagerSelector._FileManagerModelArgs.Select_Main_Menu_ID = menuID;
            _FileManagerSelector._FileManagerModelArgs.SaveSubDir = saveSubDir;
            _FileManagerSelector._FileManagerModelArgs.FilterString = filterString;
            _FileManagerSelector._FileManagerModelArgs.FileCountLimit = fileCountLimit;
        }

        private void FileManagerSelector_SelectedComplate(object sender, FileManagerSaveEventArgs e)
        {
            if (_gridView.ActiveEditor != null)
            {
                this._gridView.ActiveEditor.EditValue = e.SelectedFileGroupId;
            } 
            this.SaveComplete?.Invoke(this, e);
        }

        private void StrapButtonEdit_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "등록되지 않은 품번 입니다.";
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
            var buttonEdit = sender as ButtonEdit;
            _FileManagerSelector._FileManagerModelArgs.Select_Main_File_Group_ID = buttonEdit?.EditValue?.ToString();
            _FileManagerSelector.DataRefresh();
            _FileManagerSelector.ShowDialog();
        }

    }
}

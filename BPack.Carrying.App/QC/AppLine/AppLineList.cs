using BPack.Common.Model;
using BPack.Model.App.QC.AppLine;
using BPack.Pocket.App.QC.AppLine;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.AppLine
{
    public partial class AppLineList : DevExpress.XtraEditors.XtraForm 
    {
        private AppLineArgs _appLineArgs;
        private AppLinePocket _appLinePocket;
        private LookUpEditPocket _lep;

        public AppLineList(string User_ID)
        {
            InitializeComponent();

            _appLineArgs = new AppLineArgs();
            _appLinePocket = new AppLinePocket();

            _appLineArgs.AppLineModelArgs.Select_User_ID = User_ID;

            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            //gridView1.OptionsView.ColumnAutoWidth = false;
            this.KeyPreview = true;

            _lep = LookUpEditPocket.GetInstance();
            _lep.SetGridColumnByQuery(colAPP_USER_ID_REQ, "AllUsers", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "사용자ID", "사용자명");
            _lep.SetGridColumnByQuery(colAPP_USER_ID_REV, "AllUsers", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "사용자ID", "사용자명");
            _lep.SetGridColumnByQuery(colAPP_USER_ID_APP, "AllUsers", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "사용자ID", "사용자명");
            ((DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)colAPP_USER_ID_REQ.ColumnEdit).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ((DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)colAPP_USER_ID_REV.ColumnEdit).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            ((DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)colAPP_USER_ID_APP.ColumnEdit).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            colIsCheck.VisibleIndex = 0;
            colIsCheck.Width = 45;

            btnSearch_Click(this, null);
        }

        public AppLineModel GetSelectedModel()
        {
            return (AppLineModel)AppLineModelBindingSource.Current;
        }

        public List<AppLineModel> GetSelectedModels()
        {
            return (List<AppLineModel>)AppLineModelBindingSource.DataSource;
        }

        public void DataRefresh()
        {
            AppLineModelBindingSource.DataSource = _appLinePocket.SelectAppLineListModels(_appLineArgs.AppLineModelArgs);

            //gridView1.BestFitColumns();
            gridView1.Focus();
        }

        public void Save()
        {
            if (gridView1.RowCount == 0)
            {
                StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                return;
            }

            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            List<AppLineModel> models = new List<AppLineModel>();

            foreach (AppLineModel model in this.GetSelectedModels())
            {
                if (model.IsCheck == true)
                {
                    if (model.APP_LINE_NO != null)
                        model.RowState = RowState.Modified;
                    models.Add(model);
                }
            }

            if (models.Count == 0)
            {
                StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                return;
            }

            try
            {
                _appLinePocket.SaveAppLineListModels(models);
                StrapMessageBox.Show("A001", 35); // 저장하였습니다.
                btnSearch.PerformClick();
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
            }
        }

        public void Delete()
        {
            if (gridView1.RowCount == 0)
            {
                StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                return;
            }

            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
            List<AppLineModel> models = new List<AppLineModel>();

            foreach (AppLineModel model in this.GetSelectedModels())
            {
                if (model.IsCheck == true)
                {
                    model.RowState = RowState.Deleted;
                    models.Add(model);
                }
            }

            if (models.Count == 0)
            {
                StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                return;
            }

            if (StrapMessageBox.Show("A001", 10, MessageBoxButtons.YesNo) == DialogResult.Yes)  // 선택한 행을 삭제하시겠습니까?
            {
                try
                {
                    _appLinePocket.SaveAppLineListModels(models);
                    StrapMessageBox.Show("A001", 57);
                    btnSearch.PerformClick();
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(ex.Message);
                }
            }
        }

        //조회버튼
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataRefresh();
        }

        //취소버튼
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //업로드버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        //삭제버튼
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //추가버튼
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(this.AppLineModelBindingSource.DataSource is System.Collections.IList)) 
            {
                //MessageBox.Show("데이터가 바인딩 되지 않았습니다. 조회를 하거나 리스트에서 선택해주십시오");
                StrapMessageBox.Show("A001", 11);
                return;
            }

            this.gridView1.AddNewRow();
            ((ModelBase)AppLineModelBindingSource.Current).RowState = RowState.Added;
            ((ModelBase)AppLineModelBindingSource.Current).IsCheck = true;

            // 행추가시 결재요청자를 default로 삽입 
            ((AppLineModel)AppLineModelBindingSource.Current).CREATE_USER_ID = _appLineArgs.AppLineModelArgs.Select_User_ID;
            ((AppLineModel)AppLineModelBindingSource.Current).MODIFY_USER_ID = _appLineArgs.AppLineModelArgs.Select_User_ID;
            ((AppLineModel)AppLineModelBindingSource.Current).APP_USER_ID_REQ = _appLineArgs.AppLineModelArgs.Select_User_ID;

            gridView1.UpdateCurrentRow();
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

        private void AppLineList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)   // 조회
            {
                btnSearch.PerformClick();
            }
            else if(e.KeyCode == Keys.F3)   // 추가
            {
                btnAdd.PerformClick();
            }
            else if(e.KeyCode == Keys.F4)   // 삭제
            {
                btnDelete.PerformClick();
            }
            else if(e.KeyCode == Keys.F8)   // 저장 
            {
                btnSave.PerformClick();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //((ModelBase)AppLineModelBindingSource.Current).IsCheck = true;
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ((ModelBase)AppLineModelBindingSource.Current).IsCheck = true;
        }
    }
}

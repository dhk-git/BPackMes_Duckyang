using BPack.Common.LoginInfo;
using BPack.Common.Pocket;
using BPack.Model.App.QC.AppHist;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.AppHist
{
    public partial class AppHistApproval : DevExpress.XtraEditors.XtraForm 
    {
        public enum APP_STATUS
        {
            APP,
            RET
        }

        private APP_STATUS _status;
        private List<AppHistHeaderModel> _models;

        public AppHistApproval(APP_STATUS status, List<AppHistHeaderModel> models)
        {
            InitializeComponent();

            _status = status;

            _models = models;
            AppHistHeaderModelBindingSource.DataSource = _models;

            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.KeyPreview = true;

            gridView1.OptionsBehavior.Editable = false;

            this.Text = btnSave.Text = (_status == APP_STATUS.APP ? "승인" : "반려");
        }

        public void Save()
        {
            try
            {
                if (gridView1.RowCount ==0)
                {
                    StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                    gridView1.Focus();
                    return;
                }

                // 결재번호리스트를 문자열로 변환 
                string AppNoList = string.Empty;

                foreach(AppHistHeaderModel model in _models)
                {
                    AppNoList += "^#^" + model.APP_NO;
                }
                if (AppNoList != string.Empty)
                    AppNoList = AppNoList.Substring(3);

                // 승인 또는 반려 
                SimplePocket sp = SimplePocket.GetInstance();
                if(_status == APP_STATUS.APP)
                {
                    sp.SimplePocketExecute("QC.AppHist.Approval", new
                    {
                        @USER_ID = UserInfo.UserID,
                        @LANG_CODE = UserInfo.Sys_Language,
                        @APP_NO_LIST = AppNoList,
                        @REMARK = memRemark.Text
                    });

                    StrapMessageBox.Show("A001", 59);   // 승인완료되었습니다.
                }
                else if (_status == APP_STATUS.RET)
                {
                    sp.SimplePocketExecute("QC.AppHist.Return", new
                    {
                        @USER_ID = UserInfo.UserID,
                        @LANG_CODE = UserInfo.Sys_Language,
                        @APP_NO_LIST = AppNoList,
                        @REMARK = memRemark.Text
                    });

                    StrapMessageBox.Show("A001", 60);   // 반려되었습니다.
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
            }
        }

        //취소버튼
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
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
        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView gv = (GridView)sender;

            if (e.RowHandle == gv.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Blue;
                e.Appearance.ForeColor = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.Black;
            }
        }
    }
}

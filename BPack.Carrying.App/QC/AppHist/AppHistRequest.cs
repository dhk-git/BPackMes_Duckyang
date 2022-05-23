using BPack.Common.LoginInfo;
using BPack.Common.Pocket;
using BPack.Model.App.QC.AppHist;
using BPack.Model.App.QC.AppLine;
using BPack.Pocket.App.QC.AppLine;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.AppHist
{
    public partial class AppHistRequest : DevExpress.XtraEditors.XtraForm 
    {
        private AppLineArgs _appLineArgs;
        private AppLinePocket _appLinePocket;
        private LookUpEditPocket _lep;
        private List<AppHistHeaderModel> _models;

        public AppHistRequest(string User_ID, List<AppHistHeaderModel> models)
        {
            InitializeComponent();

            _appLineArgs = new AppLineArgs();
            _appLinePocket = new AppLinePocket();

            _appLineArgs.AppLineModelArgs.Select_User_ID = User_ID;

            _models = models;
            AppHistHeaderModelBindingSource.DataSource = _models;

            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.KeyPreview = true;

            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;

            _lep = LookUpEditPocket.GetInstance();
            _lep.SetGridColumnByQuery(colAPP_USER_ID_REV, "AllUsers", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "사용자ID", "사용자명");
            _lep.SetGridColumnByQuery(colAPP_USER_ID_APP, "AllUsers", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "사용자ID", "사용자명");
            //((DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)colAPP_USER_ID_REQ.ColumnEdit).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //((DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)colAPP_USER_ID_REV.ColumnEdit).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //((DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)colAPP_USER_ID_APP.ColumnEdit).TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;

            LoadAppLine();
        }

        public AppLineModel GetSelectedModel()
        {
            return (AppLineModel)AppLineModelBindingSource.Current;
        }

        public List<AppLineModel> GetSelectedModels()
        {
            return (List<AppLineModel>)AppLineModelBindingSource.DataSource;
        }

        public void LoadAppLine()
        {
            AppLineModelBindingSource.DataSource = _appLinePocket.SelectAppLineListModels(_appLineArgs.AppLineModelArgs);
            gridView2.Focus();
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

                if (gridView2.FocusedRowHandle < 0)
                {
                    StrapMessageBox.Show("A001", 56);   // 결재선을 선택해 주세요.
                    gridView2.Focus();
                    return;
                }

                // 출하지시리스트를 문자열로 변환 
                string RefNoList = string.Empty;

                foreach(AppHistHeaderModel model in _models)
                {
                    RefNoList += "^#^" + model.REF_NO;
                }
                if (RefNoList != string.Empty)
                    RefNoList = RefNoList.Substring(3);

                // 결재요청
                SimplePocket sp = SimplePocket.GetInstance();
                sp.SimplePocketExecute("QC.AppHist.Request", new
                {
                    @USER_ID = UserInfo.UserID,
                    @LANG_CODE = UserInfo.Sys_Language,
                    @APP_LINE_NO = gridView2.GetFocusedRowCellValue("APP_LINE_NO").ToString(),
                    @REF_NO_LIST = RefNoList,
                    @REMARK = memRemark.Text
                }) ; 

                StrapMessageBox.Show("A001", 58);   // 결재요청하였습니다. 
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

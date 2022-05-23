using BPack.CommonMes.Helpers;
using BPack.Model.App.CT.ProjectManager;
using BPack.Pocket.App.CT.ProjectManager;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.CT.ProjectManager
{
    public partial class ProjectDetailEditForm : StrapForm
    {
        private ProjectManagerArgs _projectManagerArgs;
        private ProjectManagerPocket _projectManagerPocket;
        //private LookUpEditPocket _lep;
        private ProjectDetailModel _projectDetailModel;
        private bool _isDataBindedAndNotModified = false;
        public event EventHandler<ProjectDetailModel> UpdateButtonClick;

        public ProjectDetailEditForm()
        {
            InitializeComponent();
            PARENT_PJD_NOLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            MEMB_NM_1LookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            MEMB_NM_2LookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            PJT_CLSLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            PJT_CLSLookUpEdit.ProcessNewValue += PJT_CLSLookUpEdit_ProcessNewValue;
            this.KeyDown += ProjectDetailEditForm_KeyDown;
            foreach (var control in this.strapDataLayout1.Controls)
            {
                if (control is BaseEdit)
                {
                    ((BaseEdit)control).EditValueChanged += (s, e) =>
                    {
                        if (_isDataBindedAndNotModified == true)
                        {
                            if (_projectDetailModel.RowState != Common.Model.RowState.Added) //신규가 아니면 업데이트로 바꾼다. TODO : 변경체크후 적용할것
                            {
                                _projectDetailModel.RowState = Common.Model.RowState.Modified;
                                _isDataBindedAndNotModified = false;
                                //System.Diagnostics.Debug.Print("Modified");
                            }
                        }
                    };
                }
            }
        }

        private void PJT_CLSLookUpEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            ((List<LookUpEditDefaultModel>)PJT_CLSLookUpEdit.Properties.DataSource)
       .Add(new LookUpEditDefaultModel() { CODE = e.DisplayValue.ToString(), NAME = e.DisplayValue.ToString() });
            e.Handled = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _isDataBindedAndNotModified = true;
            PJT_TASKTextEdit.Focus();
        }
        private void ProjectDetailEditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                this.Close();
                RaiseUpdateEvent();
            }
        }

        public ProjectDetailEditForm(ProjectManagerArgs projectManagerArgs, ProjectManagerPocket projectManagerPocket) : this()
        {
            _projectManagerArgs = projectManagerArgs;
            _projectManagerPocket = projectManagerPocket;
            LookUpEditHelper.SetSysCode(PJT_DETAIL_STATUSLookUpEdit, "PJT_DETAIL_STATUS");
            this.CancelButton = this.strapButton2;
        }


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                _isDataBindedAndNotModified = false;
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        public void DataRefresh(ProjectDetailModel projectDetailModel)
        {
            _projectDetailModel = projectDetailModel;
            projectDetailModelBindingSource.DataSource = _projectDetailModel;
            projectDetailModelBindingSource.ResetBindings(false);
            LookUpEditHelper.SetByQuery(PJT_CLSLookUpEdit, "ProjectManager_Pjt_Cls",
                new { PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No }, "분류", "분류");
            PJT_CLSLookUpEdit.Properties.Columns["CODE"].Visible = false;

            LookUpEditHelper.SetByQuery(PARENT_PJD_NOLookUpEdit, "ProjectManager_Pjt_Task",
                new { PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No }, "작업번호", "작업명");

            LookUpEditHelper.SetByQuery(MEMB_NM_1LookUpEdit, "ProjectManager_Pjt_Member",
                new { PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No }, "구성원", "구성원");
            MEMB_NM_1LookUpEdit.Properties.Columns["CODE"].Visible = false;

            LookUpEditHelper.SetByQuery(MEMB_NM_2LookUpEdit, "ProjectManager_Pjt_Member",
                new { PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No }, "구성원", "구성원");
            MEMB_NM_2LookUpEdit.Properties.Columns["CODE"].Visible = false;
        }
        //Update 버튼
        private void strapButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            _isDataBindedAndNotModified = false;
            RaiseUpdateEvent();
        }
        //Cancel 버튼
        private void strapButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            _isDataBindedAndNotModified = false;
        }

        private void RaiseUpdateEvent()
        {
            //if (_projectDetailModel.RowState != Common.Model.RowState.Added) //신규가 아니면 업데이트로 바꾼다. TODO : 변경체크후 적용할것
            //{
            //    _projectDetailModel.RowState = Common.Model.RowState.Modified;
            //}
            projectDetailModelBindingSource.EndEdit();
            UpdateButtonClick?.Invoke(this, _projectDetailModel);
        }
    }
}

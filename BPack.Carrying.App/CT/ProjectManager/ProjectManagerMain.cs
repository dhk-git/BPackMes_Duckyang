using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.CT.ProjectManager;
using BPack.Pocket.App.CT.ProjectManager;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
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
    public partial class ProjectManagerMain : StrapMainForm
    {
        private ProjectManagerArgs _projectManagerArgs;
        private ProjectHeader _projectHeader;
        private ProjectDetail _projectDetail;
        private ProjectMember _projectMember;
        private ProjectActivity _projectActivity;
        private ProjectManagerPocket _projectManagerPocket;
        private ProjectDetailList _projectDetailList;
        //private LookUpEditPocket _lep;

        public ProjectManagerMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _projectManagerArgs = new ProjectManagerArgs();
            _projectManagerPocket = new ProjectManagerPocket();
            _projectHeader = new ProjectHeader(_projectManagerArgs, _projectManagerPocket);
            _projectDetail = new ProjectDetail(_projectManagerArgs, _projectManagerPocket);
            _projectDetailList = new ProjectDetailList(_projectManagerArgs, _projectManagerPocket);
            _projectMember = new ProjectMember(_projectManagerArgs, _projectManagerPocket);
            _projectActivity = new ProjectActivity(_projectManagerArgs, _projectManagerPocket);

            AddSubForm(this, _projectHeader, layoutControlGroup2);
            AddSubForm(this, _projectDetail, layoutControlGroup3);
            AddSubForm(this, _projectActivity, layoutControlGroup4);
            AddSubForm(this, _projectMember, layoutControlGroup5);
            AddSubForm(this, _projectDetailList, layoutControlGroup6);
            _projectHeader.AddRefreshTargetSubForm(_projectMember);
            _projectHeader.AddRefreshTargetSubForm(_projectActivity);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _projectManagerArgs,
                InitlistForm = _projectHeader,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });
            InitRibbonButtons(true, true, false, true, true);
            _projectHeader.ModelSelectedEvent += ProjectHeader_ModelSelectedEvent;
            _projectDetail.ModelSelectedEvent += ProjectDetail_ModelSelectedEvent;
            _projectDetailList.ModelSelectedEvent += ProjectDetailList_ModelSelectedEvent;
            this.SelectedSubFormChanged += ProjectManagerMain_SelectedSubFormChanged;
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ProjectManager_Pjt_Task_Cls", new { PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No }, "분류", "분류");
            LookUpEditHelper.SetByQuery(strapPjtNoLookUpedit, "ProjectManager_Pjt_List", null, "PJTNO", "PJTNM", isFirstSelect: true);
            this.SelectedSubFormChanged += ProjectManagerMain_SelectedSubFormChanged1;
            this.strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            strapPjtNoLookUpedit.EditValueChanged += StrapPjtNoLookUpedit_EditValueChanged;
        }

        private void StrapPjtNoLookUpedit_EditValueChanged(object sender, EventArgs e)
        {
            //_projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No = strapPjtNoLookUpedit.EditValue?.ToString();
            //_projectManagerArgs.ProjectManagerModelArgs.Select_Main_Pjt_Task_Cls = strapLookUpEdit1.EditValue?.ToString();
            //_projectDetail.DataRefresh(_projectManagerArgs);
            //_projectDetailList.DataRefresh(_projectManagerArgs);
            //_projectMember.DataRefresh(_projectManagerArgs);
            //_projectActivity.DataClear(_projectManagerArgs);
            //LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ProjectManager_Pjt_Task_Cls", new { PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No }, "분류", "분류");
        }

        private void ProjectDetailList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _projectManagerArgs.ProjectManagerModelArgs.Select_Pjd_No = ((ProjectDetailModel)e.SelectedModelArgsBase.SelectedModelBase).PJD_NO;
            _projectActivity.DataRefresh(_projectManagerArgs);
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            _projectManagerArgs.ProjectManagerModelArgs.Select_Main_Pjt_Task_Cls = strapLookUpEdit1.EditValue?.ToString();
            _projectDetail.DataRefresh(_projectManagerArgs);
        }

        private void ProjectManagerMain_SelectedSubFormChanged1(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _projectDetail)
            {
                SetRibbonButtonsEnable_ByAuth(edit: true, save: false, excelExport: true);
            }
            else if (this.SelectedSubForm == _projectHeader)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, save: false, excelExport: true);
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(edit: false, save: true, excelExport: false);
            }
        }

        private void ProjectManagerMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _projectDetail)
            {
                SetRibbonButtonsEnable_ByAuth(excelImport: true);
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(excelImport: false);
            }
        }

        private void ProjectDetail_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _projectManagerArgs.ProjectManagerModelArgs.Select_Pjd_No = ((ProjectDetailModel)e.SelectedModelArgsBase.SelectedModelBase).PJD_NO;
            _projectActivity.DataRefresh(_projectManagerArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _projectManagerArgs.ProjectManagerModelArgs.Select_Main_Pjt_No = strapPjtNoLookUpedit.EditValue?.ToString();
            _projectManagerArgs.ProjectManagerModelArgs.Select_Main_Pjt_Nm = strapTextEdit2.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
            _projectHeader.SelectModelAndRaiseEvent(0);
        }
        private void ProjectHeader_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No = ((ProjectHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PJT_NO;
            _projectManagerArgs.ProjectManagerModelArgs.Select_Main_Pjt_Task_Cls = strapLookUpEdit1.EditValue?.ToString();
            _projectDetail.DataRefresh(_projectManagerArgs);
            _projectDetailList.DataRefresh(_projectManagerArgs);
            _projectMember.DataRefresh(_projectManagerArgs);
            _projectActivity.DataClear(_projectManagerArgs);
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ProjectManager_Pjt_Task_Cls", new { PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No }, "분류", "분류");
        }

        //public override void InitPocket(PocketBase Pocket)
        //{
        //    base.InitPocket(Pocket);
        //    _projectManagerPocket = Pocket as ProjectManagerPocket;
        //}
        protected override void SetControlAndGroupDicSort()
        {
            //_controlAndGroupDic = new Dictionary<string, ControlAndGroup>
            //{
            //    { strapTextEdit1.Name, null },
            //    { strapTextEdit2.Name, null },
            //    { _projectHeader.Name, null },
            //    { strapLookUpEdit1.Name, null },
            //    { _projectDetail.Name, null },
            //    { _projectActivity.Name, null },
            //    { _projectMember.Name, null }
            //};
            base.SetControlAndGroupDicSort();
        }
    }
}

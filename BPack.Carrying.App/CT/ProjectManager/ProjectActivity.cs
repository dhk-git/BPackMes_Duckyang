using BPack.Common.Model;
using BPack.Model.App.CT.ProjectManager;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.CT.ProjectManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.CT.ProjectManager
{
    public partial class ProjectActivity : StrapSubForm_OnlyOneGrid_V2
    {
        private ProjectManagerArgs _projectManagerArgs;
        private ProjectManagerPocket _projectManagerPocket;
       // private LookUpEditPocket _lep;
        private ProjectActivityEditForm _projectActivityEditForm;
        public ProjectActivity()
        {
            InitializeComponent();
        }

        public ProjectActivity(ProjectManagerArgs projectManagerArgs, ProjectManagerPocket projectManagerPocket) : this()
        {
            _projectManagerArgs = projectManagerArgs;
            _projectManagerPocket = projectManagerPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = projectActivityModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _projectManagerArgs,
                GridView = gridView1,
                InitModelType = typeof(ProjectActivityModel),
                ModelArgs = _projectManagerArgs.ProjectManagerModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<ProjectManagerModelArgs, ProjectActivityModel>(_projectManagerPocket.SelectProjectActivityModels, _projectManagerPocket.SavePrjectActivityModel, _projectManagerPocket.SavePrjectActivityModels);
            LookUpEditHelper.SetGridColumnSysCode(colPJT_ACT_CLS, "PJT_ACT_CLS");
            _projectActivityEditForm = new ProjectActivityEditForm(_projectManagerArgs, _projectManagerPocket);
            gridView1.OptionsEditForm.CustomEditFormLayout = _projectActivityEditForm;
            gridView1.EditFormPrepared += GridView1_EditFormPrepared;
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colMEMB_NM, "ProjectManager_Pjt_Member", new { PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No }, "구성원", "구성원");
            ((DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)colMEMB_NM.ColumnEdit).Columns["CODE"].Visible = false;
            base.DataRefresh(args);
        }

        private void GridView1_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
        {
            _projectActivityEditForm.DataRefresh(projectActivityModelBindingSource.Current);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ProjectActivityModel)model).PJD_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjd_No;
            base.SetInsertDefaultValue(model);
        }
    }
}

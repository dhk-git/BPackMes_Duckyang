using BPack.Common.Model;
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
    public partial class ProjectMember : StrapSubForm_OnlyOneGrid_V2
    {
        private ProjectManagerArgs _projectManagerArgs;
        private ProjectManagerPocket _projectManagerPocket;
        //private LookUpEditPocket _lep;
        public ProjectMember()
        {
            InitializeComponent();
        }

        public ProjectMember(ProjectManagerArgs projectManagerArgs, ProjectManagerPocket projectManagerPocket) : this()
        {
            _projectManagerArgs = projectManagerArgs;
            _projectManagerPocket = projectManagerPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = projectMemberModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _projectManagerArgs,
                GridView = gridView1,
                InitModelType = typeof(ProjectMemberModel),
                ModelArgs = _projectManagerArgs.ProjectManagerModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<ProjectManagerModelArgs, ProjectMemberModel>(_projectManagerPocket.SelectProjectMemberModels, _projectManagerPocket.SavePrjectMemberModel, _projectManagerPocket.SavePrjectMemberModels);
            LookUpEditHelper.SetGridColumnSysCode(colPJT_MEMB_ROLE, "PJT_MEMB_ROLE");
            LookUpEditHelper.SetGridColumnSysCode(colPJT_MEMB_STATUS, "PJT_MEMB_STATUS");
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ProjectMemberModel)model).PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No;
            base.SetInsertDefaultValue(model);
        }

    }
}

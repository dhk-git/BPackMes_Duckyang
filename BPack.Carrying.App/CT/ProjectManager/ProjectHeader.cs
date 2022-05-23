using BPack.CommonMes.Helpers;
using BPack.Model.App.CT.ProjectManager;
using BPack.Pocket.App.CT.ProjectManager;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
//using BPack.Pocket.App.CT.ProjectManager;
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
    public partial class ProjectHeader : StrapSubForm_OnlyOneGrid_V2
    {
        private ProjectManagerArgs _projectManagerArgs;
        private ProjectManagerPocket _projectManagerPocket;
        //private LookUpEditPocket _lep;

        public ProjectHeader()
        {
            InitializeComponent();
        }

        public ProjectHeader(ProjectManagerArgs projectManagerArgs, ProjectManagerPocket projectManagerPocket) : this()
        {
            _projectManagerArgs = projectManagerArgs;
            _projectManagerPocket = projectManagerPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = projectHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _projectManagerArgs,
                GridView = gridView1,
                InitModelType = typeof(ProjectHeaderModel),
                ModelArgs = _projectManagerArgs.ProjectManagerModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<ProjectManagerModelArgs, ProjectHeaderModel>(_projectManagerPocket.SelectProjectHeaderModels, _projectManagerPocket.SavePrjectHeaderModel, _projectManagerPocket.SavePrjectHeaderModels);
            LookUpEditHelper.SetGridColumnSysCode(colPJT_CLS, "PJT_CLS");
            LookUpEditHelper.SetGridColumnSysCode(colPJT_STATUS, "PJT_STATUS");
        }
    }
}

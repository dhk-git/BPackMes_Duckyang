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
    public partial class ProjectActivityEditForm : StrapEditForm
    {
        private ProjectManagerArgs _projectManagerArgs;
        private ProjectManagerPocket _projectManagerPocket;
        private ProjectActivityModel _projectActivityModel;
        //private LookUpEditPocket _lep;
        public ProjectActivityEditForm()
        {
            InitializeComponent();
        }

        public ProjectActivityEditForm(ProjectManagerArgs projectManagerArgs, ProjectManagerPocket projectManagerPocket) : this()
        {
            _projectManagerArgs = projectManagerArgs;
            _projectManagerPocket = projectManagerPocket;
            InitBoundFieldName<ProjectActivityModel>(strapDataLayout1);
            LookUpEditHelper.SetSysCode(PJT_ACT_CLSLookUpEdit, "PJT_ACT_CLS");
        }

        internal void DataRefresh(object current)
        {
            LookUpEditHelper.SetByQuery(MEMB_NMLookUpEdit, "ProjectManager_Pjt_Member",
                new { PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No }, "구성원", "구성원");
            _projectActivityModel = current as ProjectActivityModel;
            projectActivityModelBindingSource.ResetBindings(false);
        }
    }
}

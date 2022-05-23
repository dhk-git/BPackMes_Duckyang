using BPack.CommonMes.Helpers;
using BPack.Model.App.CT.ProjectManager;
using BPack.Pocket.App.CT.ProjectManager;
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
    public partial class ProjectDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private ProjectManagerArgs _projectManagerArgs;
        private ProjectManagerPocket _projectManagerPocket;

        public ProjectDetailList()
        {
            InitializeComponent();
        }

        public ProjectDetailList(ProjectManagerArgs projectManagerArgs, ProjectManagerPocket projectManagerPocket) : this()
        {
            this._projectManagerArgs = projectManagerArgs;
            this._projectManagerPocket = projectManagerPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = projectDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _projectManagerArgs,
                GridView = gridView1,
                InitModelType = typeof(ProjectDetailModel),
                ModelArgs = _projectManagerArgs.ProjectManagerModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<ProjectManagerModelArgs, ProjectDetailModel>(_projectManagerPocket.SelectProjectDetailModels, null, _projectManagerPocket.SavePrjectDetialModels);
            LookUpEditHelper.SetGridColumnSysCode(colPJT_DETAIL_STATUS, "PJT_DETAIL_STATUS");
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colPARENT_PJD_NO, "ProjectManager_Pjt_Group", null, "GroupNo", "GroupNm");
            base.DataRefresh(args);
        }
    }
}

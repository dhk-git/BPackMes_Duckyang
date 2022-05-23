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
    public partial class ProjectDetail : StrapSubForm_TreeList
    {
        private ProjectManagerArgs _projectManagerArgs;
        private ProjectManagerPocket _projectManagerPocket;
        //private LookUpEditPocket _lep;
        private ProjectDetailEditForm _projectDetailEditForm;
        private ExcelUploadForm _excelUploadForm;
        public ProjectDetail()
        {
            InitializeComponent();
        }

        public ProjectDetail(ProjectManagerArgs projectManagerArgs, ProjectManagerPocket projectManagerPocket) : this()
        {
            _projectManagerArgs = projectManagerArgs;
            _projectManagerPocket = projectManagerPocket;

        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_TreeList()
            {
                BindingSource = projectDetailModelBindingSource,
                FormArgs = _projectManagerArgs,
                TreeList = strapTreeList1,
                InitModelType = typeof(ProjectDetailModel),
                ModelArgs = _projectManagerArgs.ProjectManagerModelArgs
            });
            InitZipperDelegate<ProjectManagerModelArgs, ProjectDetailModel>(_projectManagerPocket.SelectProjectDetailModels, _projectManagerPocket.SavePrjectDetialModel);
            _projectDetailEditForm = new ProjectDetailEditForm(_projectManagerArgs, _projectManagerPocket);
            _projectDetailEditForm.StartPosition = FormStartPosition.CenterParent;
            _projectDetailEditForm.UpdateButtonClick += ProjectDetailEditForm_UpdateButtonClick;
            LookUpEditHelper.SetTreeColumnSysCode(colPJT_DETAIL_STATUS, "PJT_DETAIL_STATUS");
            strapTreeList1.OptionsBehavior.Editable = false;
            _excelUploadForm = new ExcelUploadForm();
        }
        private void ProjectDetailEditForm_UpdateButtonClick(object sender, ProjectDetailModel e)
        {
            _projectManagerPocket.SavePrjectDetialModel(e);
            DataRefresh(_projectManagerArgs);

            //projectDetailModelBindingSource.Position = _focusModelIndex;
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            strapTreeList1.ExpandAll();
        }
        public override void DataClear(ArgsBase args)
        {
            //base.DataClear(args);  
            projectDetailModelBindingSource.Clear();
        }
        //protected override void SetInsertDefaultValue(ModelBase model)
        //{
        //    ((ProjectDetailModel)model).PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No;
        //    base.SetInsertDefaultValue(model);
        //}
        public override void Edit(ArgsBase args)
        {
            //base.Edit(args);
            strapTreeList1.FocusedNode = strapTreeList1.SelectedNode;
            _projectDetailEditForm.DataRefresh(projectDetailModelBindingSource.Current as ProjectDetailModel);
            _projectDetailEditForm.ShowDialog();
        }
        //private int _focusModelIndex;
        
        public override void AddNew(ArgsBase args)
        {
            //_focusModelIndex = projectDetailModelBindingSource.Position;
            //base.AddNew(args);
            ProjectDetailModel newModel = new ProjectDetailModel()
            {
                PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                PJT_TASK_CLS = ((ProjectDetailModel)strapTreeList1.SelectedModel)?.PJT_TASK_CLS,
                PARENT_PJD_NO = ((ProjectDetailModel)strapTreeList1.SelectedModel)?.PJD_NO,
                RowState = RowState.Added
            };
            _projectDetailEditForm.DataRefresh(newModel);
            _projectDetailEditForm.ShowDialog();
        }

        public override void Delete(ArgsBase args)
        {
            //base.Delete(args);
            //if (_treeList.SelectedModelIndex == null)
            //{
            //    StrapMessageBox.Show("A001", 9);
            //    return;
            //}
            if (StrapMessageBox.Show("현재 커서 위치에 있는 행을 삭제합니다 \r\n TODO : 선택된 행 삭제 구현 예정 ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var model = projectDetailModelBindingSource.Current as ProjectDetailModel;
                    model.RowState = RowState.Deleted;
                    _projectManagerPocket.SavePrjectDetialModel(model);
                    DataRefresh(_projectManagerArgs);
                }
                catch (Exception)
                {

                    throw;
                }
            };
        }

        public override void ExcelImport(ArgsBase args)
        {
            //base.ExcelImport(args);
            if (!(_bindingSource.DataSource is System.Collections.IList))
            {
                //MessageBox.Show("데이터가 바인딩 되지 않았습니다. 조회를 하거나 리스트에서 선택해주십시오");
                StrapMessageBox.Show("A001", 11);
                return;
            }
            ShowImportForm(typeof(ProjectDetailUploadModel));
        }

        public void ShowImportForm(Type modelType)
        {
            _excelUploadForm = new ExcelUploadForm();
            _excelUploadForm.UploadButtonClick += ExcelUploadForm_UploadButtonClick;
            _excelUploadForm.SetColumns(modelType);
            _excelUploadForm.ShowDialog();
        }
        private void ExcelUploadForm_UploadButtonClick(object sender, EventArgs e)
        {
            //var data = _excelUploadForm.GetData();
            try
            {
                if (ExcelImportDataUpload(_excelUploadForm.GetData()))
                {
                    //MessageBox.Show("등록 되었습니다.");
                    StrapMessageBox.Show("A001", 12);
                    this.DataRefresh(_argsBase);    //엑셀 업로드성공후 데이터 갱신 20190520
                    _excelUploadForm.Close();
                }
                else
                {
                    //MessageBox.Show("정상처리 되지 않았습니다.");
                    StrapMessageBox.Show("A001", 13);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool ExcelImportDataUpload(object newModels)
        {
            List<ProjectDetailModel> models = new List<ProjectDetailModel>();

            foreach (var model in newModels as List<ProjectDetailUploadModel>)
            {
                models.Add(new ProjectDetailModel()
                {
                    PJT_NO = _projectManagerArgs.ProjectManagerModelArgs.Select_Pjt_No,
                    PJT_TASK = model.PJT_TASK,
                    PJT_TASK_CLS = model.PJT_CLS,
                    MEMB_NM_1 = model.MEMB_NM_1,
                    MEMB_NM_2 = model.MEMB_NM_2,
                    ACT_END_DT = model.ACT_END_DT,
                    ACT_START_DT = model.ACT_START_DT,
                    PJT_DETAIL_STATUS = model.PJT_DETAIL_STATUS,
                    PLAN_START_DT = model.PLAN_START_DT,
                    PLAN_END_DT = model.PLAN_END_DT,
                    REMARK = model.REMARK,
                    PARENT_PJD_NO = model.PARENT_PJD_NO,
                    LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                    RowState = RowState.Added
                });
            }

            return true;
        }
    }
}

using BPack.Model.App.MD.WcWorkTime;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.WcWorkTime;
using DevExpress.XtraEditors.Repository;
using BPack.CommonMes.Helpers;
using BPack.Common.Model;

namespace BPack.Carrying.App.MD.WcWorkTime
{
    public partial class WcWorkTimeWorkTimeList : StrapSubForm_OnlyOneGrid_V2
    {
        private WcWorkTimeArgs _wcWorkTimeArgs;
        private WcWorkTimePocket _wcWorkTimePocket;

        public WcWorkTimeWorkTimeList()
        {
            InitializeComponent();
        }

        public WcWorkTimeWorkTimeList(WcWorkTimeArgs wcWorkTimeArgs, WcWorkTimePocket wcWorkTimePocket) : this()
        {
            _wcWorkTimeArgs = wcWorkTimeArgs;
            _wcWorkTimePocket = wcWorkTimePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            
            //IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = wcWorkTimeWorkTimeModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _wcWorkTimeArgs,
                GridView = gridView1,
                InitModelType = typeof(WcWorkTimeWorkTimeModel),
                ModelArgs = _wcWorkTimeArgs.WcWorkTimeModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<WcWorkTimeModelArgs, WcWorkTimeWorkTimeModel>(_wcWorkTimePocket.SelectWcWorkTimeWorkTimeModels, _wcWorkTimePocket.SaveWcWorkTimeWorkTimeModel, _wcWorkTimePocket.SaveWcWorkTimeWorkTimeModels);

            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colSTART_TM);
            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colEND_TM);

            
            LookUpEditHelper.SetGridColumnSysCode(colWTM_TYPE, "WTM_TYPE");
            LookUpEditHelper.SetGridColumnCommonCode(colTM_NM, Common.LoginInfo.UserInfo.CompCode, "TM_NM");

        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colSHIFT_CD, "ShiftList_WithCode", new { COMP_CD = _wcWorkTimeArgs.WcWorkTimeModelArgs.Select_Main_Comp_CD, PLANT_CD = _wcWorkTimeArgs.WcWorkTimeModelArgs.Select_Main_Plant_CD }, "코드", "명칭");

            base.DataRefresh(args);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((WcWorkTimeWorkTimeModel)model).COMP_CD = _wcWorkTimeArgs.WcWorkTimeModelArgs.Select_Main_Comp_CD;
            ((WcWorkTimeWorkTimeModel)model).PLANT_CD = _wcWorkTimeArgs.WcWorkTimeModelArgs.Select_Main_Plant_CD;
            ((WcWorkTimeWorkTimeModel)model).WC_CD = _wcWorkTimeArgs.WcWorkTimeModelArgs.Select_WorkCenter_CD;

            base.SetInsertDefaultValue(model);
        }
    }
}

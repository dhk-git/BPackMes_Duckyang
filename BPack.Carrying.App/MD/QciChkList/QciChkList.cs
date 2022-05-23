using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.QciChkList;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.QciChkList;

namespace BPack.Carrying.App.MD.QciChkList
{
    public partial class QciChkList : StrapSubForm_OnlyOneGrid_V2
    {
        private QciChkListArgs _qciChkListArgs;
        private QciChkListPocket _qciChkListPocket;
        private QciChkListEditForm _qciChkListEditForm;

        public QciChkList()
        {
            InitializeComponent();
        }

        public QciChkList(QciChkListArgs qciChkListArgs, QciChkListPocket qciChkListPocket) : this()
        {
            _qciChkListArgs = qciChkListArgs;
            _qciChkListPocket = qciChkListPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = qciChkListModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qciChkListArgs,
                GridView = gridView1,
                InitModelType = typeof(CheckListModel),
                ModelArgs = _qciChkListArgs.QciChkListModelArgs
            });
            InitPocketDelegate<QciChkListModelArgs, CheckListModel>(_qciChkListPocket.SelectChkListModels, _qciChkListPocket.SaveChkListModel);

            LookUpEditHelper.SetGridColumnSysCode(colINSP_VAL_TYPE, "INSP_VAL_TYPE");

            _qciChkListEditForm = new QciChkListEditForm(_qciChkListArgs);
            gridView1.OptionsEditForm.CustomEditFormLayout = _qciChkListEditForm;
            gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            {
                _qciChkListEditForm.DataRefresh(qciChkListModelBindingSource.Current);
            };
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((CheckListModel)model).COMP_CD = _qciChkListArgs.QciChkListModelArgs.Select_Main_Comp_CD;
            ((CheckListModel)model).PLANT_CD = _qciChkListArgs.QciChkListModelArgs.Select_Main_Plant_CD;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnCommonCode(colINSP_DV, _qciChkListArgs.QciChkListModelArgs.Select_Main_Comp_CD, "INSP_DV");
            LookUpEditHelper.SetGridColumnCommonCode(colINSP_METHOD, _qciChkListArgs.QciChkListModelArgs.Select_Main_Comp_CD, "INSP_METHOD");
            LookUpEditHelper.SetGridColumnCommonCode(colUNIT, _qciChkListArgs.QciChkListModelArgs.Select_Main_Comp_CD, "UNIT");
        }
    }
}

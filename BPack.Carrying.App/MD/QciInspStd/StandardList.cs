using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.QciInspStd;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Strap.FormControls.PopUp;
using BPack.Pocket.App.MD.QciInspStd;
using DevExpress.ChartRangeControlClient.Core;
using DevExpress.XtraEditors.Repository;

namespace BPack.Carrying.App.MD.QciInspStd
{
    public partial class StandardList : StrapSubForm_OnlyOneGrid_V2
    {
        private QciInspStdArgs _qciInspStdArgs;
        private QciInspStdPocket _qciInspStdPocket;
        private StrapRepositoryItemButtonEdit_ItemMaster _buttonItem;
        StandardListEditForm _standardListEditForm;

        public StandardList(QciInspStdArgs qciInspStdArgs, QciInspStdPocket qciInspStdPocket)
        {
            InitializeComponent();
            
            _qciInspStdArgs = qciInspStdArgs;
            _qciInspStdPocket = qciInspStdPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = inspectionStandardModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qciInspStdArgs,
                GridView = gridView1,
                InitModelType= typeof(InspectionStandardModel),
                ModelArgs = _qciInspStdArgs.QciInspStdModelArgs
            });
            InitPocketDelegate<QciInspStdModelArgs, InspectionStandardModel>(_qciInspStdPocket.SelectInspectionStandardModels, _qciInspStdPocket.SaveInspectionStandardModel);

            LookUpEditHelper.SetGridColumnSysCode(colINSP_TYPE, "INSP_TYPE");

            _buttonItem = new StrapRepositoryItemButtonEdit_ItemMaster(colITEM_CD, gridView1);
            _buttonItem.ItemMasterModelSelected += _buttonItem_ItemMasterModelSelected;

            _standardListEditForm = new StandardListEditForm(_qciInspStdArgs);
            gridView1.OptionsEditForm.CustomEditFormLayout = _standardListEditForm;
            gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            {
                _standardListEditForm.DataRefresh(inspectionStandardModelBindingSource.Current);
            };
        }

        private void _buttonItem_ItemMasterModelSelected(object sender, Strap.FormControls.PopUp.ItemMasterSelectedEventArgs e)
        {
            gridView1.PostEditor();
            ((InspectionStandardModel)inspectionStandardModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
            gridView1.UpdateCurrentRow();
            gridView1.BestFitColumns();
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((InspectionStandardModel)model).COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD;
            ((InspectionStandardModel)model).PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD;
            ((InspectionStandardModel)model).INSP_TYPE = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Insp_Type;
            ((InspectionStandardModel)model).ITEM_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Item_CD;

        }

        public override void DataRefresh(ArgsBase args)
        {
            _buttonItem.InitCompCode(_qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD);
            _buttonItem.InitPlantCode(_qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD);

            base.DataRefresh(args);
        }

    }
}

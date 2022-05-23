using BPack.Common.Model;
using BPack.Model.App.PC.WorkOrder;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WorkOrder;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.PC.WorkOrder
{
    public partial class WoMtrlList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorkOrderArgs _WorkOrderArgs;
        private WorkOrderPocket _WorkOrderPocket;

        ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public WoMtrlList(WorkOrderArgs WorkOrderArgs, WorkOrderPocket WorkOrderPocket)
        {
            InitializeComponent();

            _WorkOrderArgs = WorkOrderArgs;
            _WorkOrderPocket = WorkOrderPocket;

        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = workOrderBomDModelBindingSource,
                FormArgs = _WorkOrderArgs,
                ModelArgs = _WorkOrderArgs.WorkOrderModelArgs,
                InitModelType = typeof(WorkOrderBomDModel),
                //todo 2021.10.12 batch 로 하는 경우 에러 발생
                StrapEditMode = StrapEditMode.Default,
                GridView = gridView1
            });

            //todo 2021.10.07 bom조회 주석처리
            InitPocketDelegate<WorkOrderModelArgs, WorkOrderBomDModel>(
                _WorkOrderPocket.SelectWorkOrderBomDModels
                , _WorkOrderPocket.SaveWorkOrderBomModel
                , _WorkOrderPocket.SaveWorkOrderBomModels
                );

            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((WorkOrderBomDModel)workOrderBomDModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((WorkOrderBomDModel)workOrderBomDModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };

        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((WorkOrderBomDModel)model).WO_NO_KEY = _WorkOrderArgs.WorkOrderModelArgs.WO_NO_KEY;
            ((WorkOrderBomDModel)model).COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code;
            ((WorkOrderBomDModel)model).PLANT_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code;


        }
        public override void DataRefresh(ArgsBase args)
        {
            //_WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code=
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType"
                , new { COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code
                        , PLANT_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code }, "품목유형코드", "품목유형명");
        }
    }
}

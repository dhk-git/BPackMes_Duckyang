using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.MD.PrdRouting;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdRouting;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.PrdRouting
{
    public partial class MaterialList : StrapSubForm_OnlyOneGrid_V2
    {
        PrdRoutingArgs _prdRoutingArgs;
        PrdRoutingPocket _prdRoutingPocket;

        private ItemMasterModelArgs _itemMasterModelArgs;
        private ItemMasterPocket _itemMasterPocket;
        private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public MaterialList(PrdRoutingArgs prdRoutingArgs, PrdRoutingPocket prdRoutingPocket)
        {
            InitializeComponent();

            _prdRoutingArgs = prdRoutingArgs;
            _prdRoutingPocket = prdRoutingPocket;
        }

        public override void InitStrap()
        {
            
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = materialModelBindingSource,
                FormArgs = _prdRoutingArgs,
                GridView = gridView1,
                InitModelType = typeof(MaterialModel),
                ModelArgs = _prdRoutingArgs.PrdRoutingModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdRoutingModelArgs, MaterialModel>(_prdRoutingPocket.SelectMaterialModels, _prdRoutingPocket.SaveMaterialModel, _prdRoutingPocket.SaveMaterialModels);

            _itemMasterModelArgs = new ItemMasterModelArgs();
            _itemMasterPocket = new ItemMasterPocket();

            LookUpEditHelper.SetGridColumnSysCode(colMAT_INPUT_TYPE, "MAT_INPUT_TYPE");

            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += ItemMasterRepositoryButtonEdit_ItemMasterModelSelected;
        }

        private void ItemMasterRepositoryButtonEdit_ItemMasterModelSelected(object sender, ItemMasterSelectedEventArgs e)
        {
            gridView1.PostEditor();
            ((MaterialModel)materialModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
            ((MaterialModel)materialModelBindingSource.Current).ITEM_SPEC = e.SeletedItemMasterModel.ITEM_SPEC;
            gridView1.UpdateCurrentRow();
            gridView1.BestFitColumns();
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((MaterialModel)model).COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code;
            ((MaterialModel)model).PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code;
            ((MaterialModel)model).ROUTE_NO = _prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Route_No;
            ((MaterialModel)model).OPER = _prdRoutingArgs.PrdRoutingModelArgs.Select_OperationList_Oper;

            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnCommonCode(colOPER_UNIT, _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code, "UNIT");

            _itemMasterRepositoryButtonEdit.InitCompCode(_prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code);

            base.DataRefresh(args);
        }
    }
}

using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.GirLocStock;
using BPack.Pocket.App.MM.GirLocStock;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM.GirLocStock
{
    public partial class LocStockList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirLocStockArgs _girLocStockArgs;
        private GirLocStockPocket _girLocStockPocket;

        public LocStockList()
        {
            InitializeComponent();
        }

        public LocStockList(GirLocStockArgs girLocStockArgs, GirLocStockPocket girLocStockPocket) : this()
        {
            _girLocStockArgs = girLocStockArgs;
            _girLocStockPocket = girLocStockPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = locStockModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girLocStockArgs,
                GridView = gridView1,
                InitModelType = typeof(LocStockModel),
                ModelArgs = _girLocStockArgs.GirLocStockModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirLocStockModelArgs, LocStockModel>(_girLocStockPocket.SelectLocStockModels, null);
            colIsCheck.Visible = false;

            LookUpEditHelper.SetGridColumnCommonCode(colBASE_UNIT, _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd, "UNIT");
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode", new { COMP_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd, PLANT_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_2, "ItemGroup_WithCode", new { COMP_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd, PLANT_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_2" }, "제품군", "제품군명");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE, "ItemType", new { COMP_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Comp_Cd }, "품목유형코드", "품목유형명");

            base.DataRefresh(args);
        }

    }
}

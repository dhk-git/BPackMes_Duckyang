using BPack.Model.App.MM.GirLocStock;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirLocStock;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MM.GirLocStock
{
    public partial class LocGirList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirLocStockArgs _girLocStockArgs;
        private GirLocStockPocket _girLocStockPocket;

        public LocGirList()
        {
            InitializeComponent();
        }

        public LocGirList(GirLocStockArgs girLocStockArgs, GirLocStockPocket girLocStockPocket) : this()
        {
            _girLocStockArgs = girLocStockArgs;
            _girLocStockPocket = girLocStockPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = locGirModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girLocStockArgs,
                GridView = gridView1,
                InitModelType = typeof(LocGirModel),
                ModelArgs = _girLocStockArgs.GirLocStockModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirLocStockModelArgs, LocGirModel>(_girLocStockPocket.SelectLocGirModels, null);
            LookUpEditHelper.SetGridColumnByQuery(colGIR_TYPE_CD, "GirType", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "수불유형코드", "수불유형명");
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colLOC_CD, "Locations_WithCode", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Plant_Cd, WH_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Wh_Cd }, "위치코드", "위치명");
            LookUpEditHelper.SetGridColumnByQuery(colTARGET_WH_CD, "WareHouses_WithCode", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Plant_Cd }, "창고코드", "창고명");
            LookUpEditHelper.SetGridColumnByQuery(colTARGET_LOC_CD, "Locations_WithCode", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _girLocStockArgs.GirLocStockModelArgs.Select_Main_Plant_Cd, WH_CD = "" }, "위치코드", "위치명");
            base.DataRefresh(args);
        }
    }
}

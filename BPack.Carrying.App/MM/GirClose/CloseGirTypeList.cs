using BPack.Model.App.MM.GirClose;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirClose;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MM.GirClose
{
    public partial class CloseGirTypeList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirCloseArgs _girCloseArgs;
        private GirClosePocket _girClosePocket;

        public CloseGirTypeList()
        {
            InitializeComponent();
        }

        public CloseGirTypeList(GirCloseArgs girCloseArgs, GirClosePocket girClosePocket) : this()
        {
            _girCloseArgs = girCloseArgs;
            _girClosePocket = girClosePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = closeGirTypeModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girCloseArgs,
                GridView = gridView1,
                InitModelType = typeof(CloseGirTypeModel),
                ModelArgs = _girCloseArgs.GirCloseModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirCloseModelArgs, CloseGirTypeModel>(_girClosePocket.SelectCloseGirTypeModels, null);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetWareHouse(colWH_CD, _girCloseArgs.GirCloseModelArgs.Select_Comp_Cd, _girCloseArgs.GirCloseModelArgs.Select_Main_Plant_Cd);
            LookUpEditHelper.SetGirType(colGIR_TYPE_CD, _girCloseArgs.GirCloseModelArgs.Select_Comp_Cd);

            gridView1.BestFitColumns();
        }
    }
}

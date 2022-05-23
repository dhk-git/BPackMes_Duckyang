using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WorOrderRead;
using BPack.Pocket.App.PC.WorOrderRead;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraRichEdit.Unicode;

namespace BPack.Carrying.App.PC.WorOrderRead
{
    public partial class WorOrderReadHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorOrderReadArgs _worOrderReadArgs;
        private WorOrderReadPocket _worOrderReadPocket;
        //private LookUpEditPocket _lep;

        public WorOrderReadHeaderList()
        {
            InitializeComponent();
        }

        public WorOrderReadHeaderList(WorOrderReadArgs worOrderReadArgs, WorOrderReadPocket worOrderReadPocket) : this()
        {
            _worOrderReadArgs = worOrderReadArgs;
            _worOrderReadPocket = worOrderReadPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = worOrderReadHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _worOrderReadArgs,
                GridView = gridView1,
                InitModelType = typeof(WorOrderReadHeaderModel),
                ModelArgs = _worOrderReadArgs.WorOrderReadModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WorOrderReadModelArgs, WorOrderReadHeaderModel>(_worOrderReadPocket.SelectWorkOrderHeaderModels, null);

        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colSHIFT_CD, "ShiftList_WithCode", new { COMP_CD = _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_Comp_Cd, PLANT_CD = _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_Plant_Cd }, "작업장코드", "작업장명");
            LookUpEditHelper.SetWorkCenter(colWC_CD, _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_Comp_Cd, _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_Plant_Cd, _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_ParentWorkCenter_Cd);
            LookUpEditHelper.SetGridColumnCommonCode(colPARENT_WC_CD, _worOrderReadArgs.WorOrderReadModelArgs.Select_Main_Comp_Cd, "LINE");

            base.DataRefresh(args);
        }

    }
}

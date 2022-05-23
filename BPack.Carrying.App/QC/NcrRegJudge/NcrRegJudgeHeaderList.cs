using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrRegJudge;
using BPack.Pocket.App.QC.NcrRegJudge;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC.NcrRegJudge
{
    public partial class NcrRegJudgeHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private NcrRegJudgePocket _regPocket;
        private NcrRegJudgeArgs _ncrRegArgs;

        public NcrRegJudgHeaderModel SelectedGridRow = null;

        public NcrRegJudgeHeaderList()
        {
            InitializeComponent();
        }

        public NcrRegJudgeHeaderList(NcrRegJudgePocket regPocket, NcrRegJudgeArgs ncrRegArgs):this()
        {
            this._regPocket = regPocket;
            this._ncrRegArgs = ncrRegArgs;

          

        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = nccrRegJudgHeaderModelBindingSource,
                FormArgs = _ncrRegArgs,
                ModelArgs = _ncrRegArgs.NcrRegJudgModelArgs,
                InitModelType = typeof(NcrRegJudgHeaderModel),
                GridView = gridView1
            });

            InitPocketDelegate<NcrRegJudgeModelArgs, NcrRegJudgHeaderModel>
                (_regPocket.SelectNcrRegJudgHeaderModels, null);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnSysCode(colNCH_TYPE, "NCH_TYPE");
            LookUpEditHelper.SetGridColumnSysCode(colREF_DOC_TYPE, "DOC_TYPE");
            LookUpEditHelper.SetGridColumnByQuery(colNCR_WH_CD, "WareHouses",
                new
                {
                    COMP_CD = ((NcrRegJudgeArgs)args).NcrRegJudgModelArgs.Select_Main_Comp_Cd
                    ,
                    PLANT_CD = ((NcrRegJudgeArgs)args).NcrRegJudgModelArgs.Select_Main_Plant_Cd
                }
                , "Code", "Name");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup"
                , new
                {
                    COMP_CD = ((NcrRegJudgeArgs)args).NcrRegJudgModelArgs.Select_Main_Comp_Cd,
                    PLANT_CD = ((NcrRegJudgeArgs)args).NcrRegJudgModelArgs.Select_Main_Plant_Cd,
                    ITEM_GR_CLS = "ITEM_GR_1"
                }
                , "Code", "Name");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType"
            , new
            {
                COMP_CD = ((NcrRegJudgeArgs)args).NcrRegJudgModelArgs.Select_Main_Comp_Cd
            }, "Code", "Name");

            LookUpEditHelper.SetGridColumnCommonCode
                (
                    colDEFECT_CD
                    , ((NcrRegJudgeArgs)args).NcrRegJudgModelArgs.Select_Main_Comp_Cd
                    , "DEFECT_CD"
                    
                );
            LookUpEditHelper.SetGridColumnSysCode(colJUDGE_RESULT, "JUDGE_RESULT");
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SelectedGridRow = gridView1.GetRow(e.RowHandle) as NcrRegJudgHeaderModel;
        }

        public void GridSelectByKey()
        {
            SaveSuccess(SelectedGridRow);
            //var aa=strapGridControl1.SelectedModel;

            //gridView1.UpdateCurrentRow();

            nccrRegJudgHeaderModelBindingSource.ResetBindings(false);
            int _rowindex = gridView1.LocateByValue("NCD_NO_KEY", SelectedGridRow.NCD_NO);
            if (_rowindex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                gridView1.FocusedRowHandle = _rowindex;
            SelectedGridRow = gridView1.GetRow(_rowindex) as NcrRegJudgHeaderModel;
            if (SelectedGridRow != null)
            { 
                SelectedGridRow.SelectedCheck = 1;  
            }
            

        }
    }
}

using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchNcrRegRead;
using BPack.Pocket.App.QC.QchNcrRegRead;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC.QchNcrRegRead
{
    public partial class QchNcrRegReadDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private QchNcrRegReadArgs _readArgs;
        private QchNcrRegReadPocket _regReadPocket;

        public QchNcrRegReadDetailList()
        {
            InitializeComponent();
        }

        public QchNcrRegReadDetailList(QchNcrRegReadArgs readArgs, QchNcrRegReadPocket regReadPocket) : this()
        {
            this._readArgs = readArgs;
            this._regReadPocket = regReadPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = qchNcrRegReadDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _readArgs,
                GridView = gridView1,
                InitModelType = typeof(QchNcrRegReadDetailModel),
                ModelArgs = _readArgs.QchNcrRegReadModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<QchNcrRegReadModelArgs, QchNcrRegReadDetailModel>(_regReadPocket.SelectQchNcrRegReadDetailModels, null);
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnSysCode(colNCH_TYPE, "NCH_TYPE");
            LookUpEditHelper.SetGridColumnByQuery(colFROM_WH_CD, "WareHouses",
            new
            {
                COMP_CD = ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Comp_Cd
                ,
                PLANT_CD = ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Plant_Cd
            }
            , "Code", "Name");
            LookUpEditHelper.SetGridColumnByQuery(colNCR_WH_CD, "WareHouses",
            new
            {
                COMP_CD = ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Comp_Cd
                ,
                PLANT_CD = ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Plant_Cd
            }
            , "Code", "Name");
            LookUpEditHelper.SetGridColumnSysCode(colNCH_STATUS, "NCH_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colREF_DOC_TYPE, "DOC_TYPE");
            LookUpEditHelper.SetGridColumnCommonCode(colDEFECT_CD, ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Comp_Cd, "DEFECT_CD");
            LookUpEditHelper.SetGridColumnSysCode(colJUDGE_CD, "JUDGE_CD");
            LookUpEditHelper.SetGridColumnByQuery(colTO_WH_CD, "WareHouses",
            new
            {
                COMP_CD = ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Comp_Cd
                ,
                PLANT_CD = ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Plant_Cd
            }
            , "Code", "Name");
            LookUpEditHelper.SetGridColumnSysCode(colJUDGE_STATUS, "JUDGE_STATUS");
        }
    }
}

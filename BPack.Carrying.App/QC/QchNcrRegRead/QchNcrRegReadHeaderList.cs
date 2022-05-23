using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchNcrRegRead;
using BPack.Pocket.App.QC.QchNcrRegRead;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.QC.QchNcrRegRead
{
    public partial class QchNcrRegReadHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private QchNcrRegReadArgs _readArgs;
        private QchNcrRegReadPocket _regReadPocket;

        public QchNcrRegReadHeaderList()
        {
            InitializeComponent();
        }

        public QchNcrRegReadHeaderList(QchNcrRegReadArgs readArgs, QchNcrRegReadPocket regReadPocket) : this()
        {
            this._readArgs = readArgs;
            this._regReadPocket = regReadPocket;

           
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = qchNcrRegReadHeaderModelBindingSource,
                FormArgs = _readArgs,
                ModelArgs = _readArgs.QchNcrRegReadModelArgs,
                InitModelType = typeof(QchNcrRegReadHeaderModel),
                GridView = gridView1,
                StrapEditMode = StrapEditMode.Default
            });

            InitPocketDelegate<QchNcrRegReadModelArgs, QchNcrRegReadHeaderModel>
            (_regReadPocket.SelectQchNcrRegReadHeaderModels, null);
            gridView1.Columns["ITEM_CD"].GroupIndex = 0;
            //gridView1.OptionsView.ColumnAutoWidth = false;
            //gridView1.BestFitColumns(true);
            colITEM_CD.MinWidth = 200;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup"
               , new
               {
                   COMP_CD = ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Comp_Cd,
                   PLANT_CD = ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Plant_Cd,
                   ITEM_GR_CLS = "ITEM_GR_1"
               }
               , "Code", "Name");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType"
            , new
            {
                COMP_CD = ((QchNcrRegReadArgs)args).QchNcrRegReadModelArgs.Select_Main_Comp_Cd
            }, "Code", "Name");

            gridView1.ExpandAllGroups();

            
        }
    }
}

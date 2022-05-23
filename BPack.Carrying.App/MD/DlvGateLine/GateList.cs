using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvGateLine;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.DlvGateLine;
using System.Data;
using BPack.Common.Pocket;
using DevExpress.XtraGrid.Views.Grid;

namespace BPack.Carrying.App.MD.DlvGateLine
{
    public partial class GateList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvGateLineArgs _dlvGateLineArgs;
        private DlvGateLinePocket _dlvGateLinePocket;
        //private GateListEditForm _gateListEditForm;

        public GateList(DlvGateLineArgs dlvGateLineArgs, DlvGateLinePocket dlvGateLinePocket)
        {
            InitializeComponent();

            _dlvGateLineArgs = dlvGateLineArgs;
            _dlvGateLinePocket = dlvGateLinePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = gateModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvGateLineArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvGateLineGateModel),
                ModelArgs = _dlvGateLineArgs.DlvGateLineModelArgs,
                StrapEditMode = StrapEditMode.Batch

            });
            InitPocketDelegate<DlvGateLineModelArgs, DlvGateLineGateModel>(_dlvGateLinePocket.SelectGateModels, _dlvGateLinePocket.SaveGateModel, _dlvGateLinePocket.SaveGateModels);

            LookUpEditHelper.SetGridColumnSysCode(colINSP_OPT, "INSP_OPT");


            //_gateListEditForm = new GateListEditForm(_dlvGateLineArgs);
            //gridView1.OptionsEditForm.CustomEditFormLayout = _gateListEditForm;
            //gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            //{
            //    _gateListEditForm.DataRefresh(gateModelBindingSource.Current);
            //};
        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((DlvGateLineGateModel)model).COMP_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code;
            ((DlvGateLineGateModel)model).PLANT_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Plant_Code;
            ((DlvGateLineGateModel)model).GATE_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Partners_Gate_Code;

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnCommonCode(colDLV_AUTO_FG, _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code, "FG_YN");
            LookUpEditHelper.SetGridColumnCommonCode(colCHK_CUST_FG, _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code, "FG_YN");

            LookUpEditHelper.SetGridColumnByQuery(colWH_CD, "WareHouses_WithCode", new { COMP_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code, PLANT_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Plant_Code }, "출하품입고창고코드", "출하품입고창고명");
            LookUpEditHelper.SetGridColumnByQuery(colLOC_CD, "Locations_WithCode", new { COMP_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code, PLANT_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Plant_Code, WH_CD = "" }, "출하품입고위치코드", "출하품입고위치명");
            LookUpEditHelper.SetGridColumnByQuery(colDLV_WH_CD, "WareHouses_WithCode", new { COMP_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code, PLANT_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Plant_Code }, "출하창고코드", "출하창고명");
            LookUpEditHelper.SetGridColumnByQuery(colDLV_LOC_CD, "Locations_WithCode", new { COMP_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code, PLANT_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Plant_Code, WH_CD = "" }, "출하위치코드", "출하위치명");
        }


        private void gridView1_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            SimplePocket simplePocket;
            DataTable source;
            //DataRow emptyRow;

            switch (e.Column.FieldName)
            {
                case "LOC_CD":

                    simplePocket = SimplePocket.GetInstance();
                    source = simplePocket.SelectData("Locations_WithAllCode", new
                    {
                        COMP_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code,
                        PLANT_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Plant_Code,
                        WH_CD = grv.GetRowCellValue(e.RowHandle, colWH_CD)

                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "출하품입고위치코드", displayCaption: "출하품입고위치명");

                    break;
                case "DLV_LOC_CD":

                    simplePocket = SimplePocket.GetInstance();
                    source = simplePocket.SelectData("Locations_WithAllCode", new
                    {
                        COMP_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code,
                        PLANT_CD = _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Plant_Code,
                        WH_CD = grv.GetRowCellValue(e.RowHandle, colDLV_WH_CD)
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "출하위치코드", displayCaption: "출하위치명");

                    break;
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var curModel = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(e.RowHandle) as DlvGateLineGateModel;

            switch (e.Column.FieldName)
            {
                case "WH_CD":
                    curModel.LOC_CD = "";
                    break;
                case "DLV_WH_CD":
                    curModel.DLV_LOC_CD = "";
                    break;
                case "DLV_AUTO_FG":
                    if (curModel.DLV_AUTO_FG == "Y")
                    {
                        curModel.CHK_CUST_FG = "N";
                        colCHK_CUST_FG.OptionsColumn.AllowEdit = false;
                    }
                    else
                    {
                        colCHK_CUST_FG.OptionsColumn.AllowEdit = true;
                    }
                    break;
            }
        }
    }
}

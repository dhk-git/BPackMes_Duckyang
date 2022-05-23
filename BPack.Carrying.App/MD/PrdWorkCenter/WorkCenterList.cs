using BPack.Common.Model;
using BPack.Model.App.MD.PrdWorkCenter;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdWorkCenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.MD.PrdWorkCenter
{
    public partial class WorkCenterList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdWorkCenterPocket _prdWorkCenterPocket;
        private PrdWorkCenterArgs _prdWorkCenterArgs;
      

        public WorkCenterList(PrdWorkCenterArgs prdWorkCenterArgs, PrdWorkCenterPocket prdWorkCenterPocket)
        {
            InitializeComponent();

            _prdWorkCenterArgs = prdWorkCenterArgs;
            _prdWorkCenterPocket = prdWorkCenterPocket;

        }

        public override void InitStrap()
        {
            base.InitStrap();
           

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = workCenterModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _prdWorkCenterArgs,
                GridView = gridView1,
                InitModelType = typeof(WorkCenterModel),
                ModelArgs = _prdWorkCenterArgs.PrdWorkCenterModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<PrdWorkCenterModelArgs, WorkCenterModel>(_prdWorkCenterPocket.SelectWorkCenterModels, _prdWorkCenterPocket.SaveWorkCenterModel, _prdWorkCenterPocket.SaveWorkCenterModels);

            LookUpEditHelper.SetGridColumnSysCode(colWC_TYPE, "WC_TYPE");
            LookUpEditHelper.SetGridColumnSysCode(colWC_GR, "WC_GR");
            LookUpEditHelper.SetGridColumnByQuery(
                colSHIFT_GROUP_CD,
                "MD.SHIH.Select",
                new {  
                    COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
                    PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD  }
                , "근무조그룹"
                , "근무조그룹명");

            //LookUpEditHelper.SetGridColumnSysCode(colWC_BASE_ROUTE, "WC_BASE_ROUTE");
            //colGD_WH_CD.ToolTip = "라우팅 생성 기준값";
            //colGD_LOC_CD.ToolTip = "라우팅 생성 기준값";
            //colMAT_WH_CD.ToolTip = "라우팅 생성 기준값";
            //colMAT_LOC_CD.ToolTip = "라우팅 생성 기준값";
            //colDVC_ID.ToolTip = "라우팅 생성 기준값";
            //colMODE_ID.ToolTip = "라우팅 생성 기준값";
            //colWC_BASE_ROUTE.ToolTip = "작업지시 생성시 기준값\r\n - 하나의 작업장에 상이한 공정이 있을경우에 표준라우팅 혹은 품목별라우팅 사용";
            //_gridView.CustomRowCellEditForEditing += _gridView_CustomRowCellEditForEditing;
        }

        //private void _gridView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        //{
        //    var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
        //    SimplePocket simplePocket;
        //    DataTable source;

        //    switch (e.Column.FieldName)
        //    {
        //        //case "MAT_LOC_CD":

        //        //    simplePocket = SimplePocket.GetInstance();
        //        //    source = simplePocket.SelectData("Locations_WithCode", new
        //        //    {
        //        //        COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code,
        //        //        PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code,
        //        //        WH_CD = grv.GetRowCellValue(e.RowHandle, colMAT_WH_CD)

        //        //    });
        //        //    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "위치코드", displayCaption: "위치명");

        //        //    break;
        //        //case "GD_LOC_CD":

        //        //    simplePocket = SimplePocket.GetInstance();
        //        //    source = simplePocket.SelectData("Locations_WithCode", new
        //        //    {
        //        //        COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code,
        //        //        PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code,
        //        //        WH_CD = grv.GetRowCellValue(e.RowHandle, colGD_WH_CD)
        //        //    });
        //        //    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "위치코드", displayCaption: "위치명");

        //        //    break;
        //        case "DVC_ID":

        //            simplePocket = SimplePocket.GetInstance();
        //            source = simplePocket.SelectData("DeviceList_WithCode", new
        //            {
        //                COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
        //                PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Plant_CD,
        //                WC_CD = grv.GetRowCellValue(e.RowHandle, colWC_CD)
        //            });
        //            e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "단말기ID", displayCaption: "단말기명");
        //            break;
        //    }
        //}



        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((WorkCenterModel)model).COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD;
            ((WorkCenterModel)model).PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD;
            ((WorkCenterModel)model).WC_TYPE = "ASSEMBLY";
            ((WorkCenterModel)model).WC_GR = "ESS";

        }

        public override void DataRefresh(ArgsBase args)
        {

            LookUpEditHelper.SetGridColumnSysCode(colWC_GR, "WC_GR");
            LookUpEditHelper.SetGridColumnByQuery(
                colSHIFT_GROUP_CD,
                "MD.SHIH.Select",
                new
                {
                    COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
                    PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD
                }
                , "근무조그룹"
                , "근무조그룹명");



            //LookUpEditHelper.SetGridColumnCommonCode(colPARENT_WC_CD, _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD, "LINE");
            //LookUpEditHelper.SetGridColumnByQuery(colMAT_WH_CD, "WareHouses_WithCode", new { COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD, PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Plant_CD }, "창고코드", "창고명");
            //LookUpEditHelper.SetGridColumnByQuery(colGD_WH_CD, "WareHouses_WithCode", new { COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD, PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Plant_CD }, "창고코드", "창고명");
            //LookUpEditHelper.SetGridColumnByQuery(colMAT_LOC_CD, "Locations_WithCode", new { COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD, PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Plant_CD, WH_CD = "" }, "위치코드", "위치명");
            //LookUpEditHelper.SetGridColumnByQuery(colGD_LOC_CD, "Locations_WithCode", new { COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD, PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Plant_CD, WH_CD = "" }, "위치코드", "위치명");

            base.DataRefresh(args);
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            //var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            //object wareHouseCode;
            //SimplePocket simplePocket;
            //DataTable source;

            //switch (e.Column.FieldName)
            //{
            //    case "MAT_LOC_CD":
            //        wareHouseCode = grv.GetRowCellValue(e.RowHandle, "MAT_WH_CD");

            //        simplePocket = SimplePocket.GetInstance();
            //        source = simplePocket.SelectData("Locations_WithCode", new
            //        {
            //            COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
            //            PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Plant_CD,
            //            WH_CD = wareHouseCode
            //        });
            //        e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "위치코드", displayCaption: "위치명");

            //        break;
            //    case "GD_LOC_CD":
            //        wareHouseCode = grv.GetRowCellValue(e.RowHandle, "GD_WH_CD");

            //        simplePocket = SimplePocket.GetInstance();
            //        source = simplePocket.SelectData("Locations_WithCode", new
            //        {
            //            COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
            //            PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Plant_CD,
            //            WH_CD = wareHouseCode
            //        });
            //        e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "위치코드", displayCaption: "위치명");

            //        break;
            //}
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var curModel = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(e.RowHandle) as WorkCenterModel;

          
        }
    }
}

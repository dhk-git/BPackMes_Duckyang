using BPack.Common.Model;
using BPack.Model.App.MD.PrdRouting;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdRouting;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using DevExpress.XtraGrid;
using BPack.Strap.Grid;
using DevExpress.Office.Drawing;

namespace BPack.Carrying.App.MD.PrdRouting
{
    public partial class OperationList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdRoutingArgs _prdRoutingArgs;
        private PrdRoutingPocket _prdRoutingPocket;

        public OperationList(PrdRoutingArgs prdRoutingArgs, PrdRoutingPocket prdRoutingPocket)
        {
            InitializeComponent();

            _prdRoutingArgs = prdRoutingArgs;
            _prdRoutingPocket = prdRoutingPocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = operationModelBindingSource,
                FormArgs = _prdRoutingArgs,
                GridView = gridView1,
                InitModelType = typeof(OperationModel),
                ModelArgs = _prdRoutingArgs.PrdRoutingModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdRoutingModelArgs, OperationModel>(_prdRoutingPocket.SelectOperationModels, _prdRoutingPocket.SaveOperationModel, _prdRoutingPocket.SaveOperationModels);

            LookUpEditHelper.SetGridColumnCommonCode(colOPER_DESC, Common.LoginInfo.UserInfo.CompCode, "PROC");
            LookUpEditHelper.SetGridColumnSysCode(colRST_HU_TYPE, "RST_HU_TYPE");
            colOPER.OptionsColumn.ReadOnly = true;

        }



        protected override void SetInsertDefaultValue(ModelBase model)
        {
            if (operationModelBindingSource.Count > 1)
            {
                MessageBox.Show("공정은 10번공정 1개만 등록되도록 제한되어있습니다.");
                operationModelBindingSource.RemoveCurrent();
                return;
            }
            ((OperationModel)model).ROUTE_NO = _prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Route_No;
            ((OperationModel)model).COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code;
            ((OperationModel)model).PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code;
            ((OperationModel)model).RST_HU_TYPE = "N/A";
            ((OperationModel)model).IS_IF = "N";
            ((OperationModel)model).DEL_FG = "N";
            ((OperationModel)model).OPER = 10;
            ((OperationModel)model).MODE_ID = "M01";
            base.SetInsertDefaultValue(model);
        }

        public OperationModel GetSelectedUserModel()
        {
            return (OperationModel)strapGridControl1.SelectedModel;
        }

        public void LookupEditDataRefresh()
        {
            CommonMes.Helpers.LookUpEditHelper.SetWorkCenter(colWC_CD, _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code, _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code);
            LookUpEditHelper.SetGridColumnByQuery(colMAT_WH_CD, "ItmItem.WareHouse", new
            {
                COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code,
                PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code,
                WH_GR = "PROD"
            }, "창고코드", "창고명");
            LookUpEditHelper.SetGridColumnByQuery(colGD_WH_CD, "ItmItem.WareHouse", new
            {
                COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code,
                PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code,
                WH_GR = "PROD,FinalGoods"
            }, "창고코드", "창고명");
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colMAT_LOC_CD, "Locations_WithCode", new { COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code, PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code, WH_CD = "" }, "위치코드", "위치명");
            LookUpEditHelper.SetGridColumnByQuery(colGD_LOC_CD, "Locations_WithCode", new { COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code, PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code, WH_CD = "" }, "위치코드", "위치명");
            LookUpEditHelper.SetGridColumnByQuery(colDVC_ID, "DeviceList", new { COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code, PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code, WC_CD = "" }, "단말기코드", "단말기명");

            base.DataRefresh(args);
        }

        public StrapGridControl GetGridControl()
        {
            return this.strapGridControl1;
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            SimplePocket simplePocket;
            DataTable source;

            switch (e.Column.FieldName)
            {
                case "MAT_LOC_CD":

                    simplePocket = SimplePocket.GetInstance();
                    source = simplePocket.SelectData("Locations_WithCode", new
                    {
                        COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code,
                        PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code,
                        WH_CD = grv.GetRowCellValue(e.RowHandle, colMAT_WH_CD)

                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "위치코드", displayCaption: "위치명");

                    break;
                case "GD_LOC_CD":

                    simplePocket = SimplePocket.GetInstance();
                    source = simplePocket.SelectData("Locations_WithCode", new
                    {
                        COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code,
                        PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code,
                        WH_CD = grv.GetRowCellValue(e.RowHandle, colGD_WH_CD)
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "위치코드", displayCaption: "위치명");

                    break;
                case "DVC_ID":

                    simplePocket = SimplePocket.GetInstance();
                    source = simplePocket.SelectData("DeviceList_WithCode", new
                    {
                        COMP_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code,
                        PLANT_CD = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code,
                        WC_CD = grv.GetRowCellValue(e.RowHandle, colWC_CD)
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "단말기코드", displayCaption: "단말기명");

                    break;
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var curModel = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(e.RowHandle) as OperationModel;

            switch (e.Column.FieldName)
            {
                case "WC_CD":
                    curModel.DVC_ID = "";
                    break;
            }
        }
    }
}

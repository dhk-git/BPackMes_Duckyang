using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdWorkCenter;
using BPack.Pocket.App.MD.PrdWorkCenter;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Base;
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

namespace BPack.Carrying.App.MD.PrdWorkCenter
{
    public partial class WorkCenterItemList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdWorkCenterPocket _prdWorkCenterPocket;
        private PrdWorkCenterArgs _prdWorkCenterArgs;
        ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;
        public WorkCenterItemList(PrdWorkCenterArgs prdWorkCenterArgs, PrdWorkCenterPocket prdWorkCenterPocket)
        {
            InitializeComponent();
            _prdWorkCenterArgs = prdWorkCenterArgs;
            _prdWorkCenterPocket = prdWorkCenterPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();

            this.IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = workCenterItemModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _prdWorkCenterArgs,
                GridView = gridView1,
                InitModelType = typeof(WorkCenterItemModel),
                ModelArgs = _prdWorkCenterArgs.PrdWorkCenterModelArgs,
                StrapEditMode = StrapEditMode.Batch,
                
            });
            InitPocketDelegate<PrdWorkCenterModelArgs, WorkCenterItemModel>
                (_prdWorkCenterPocket.SelectItemModels, _prdWorkCenterPocket.SaveItemModel, _prdWorkCenterPocket.SaveItemModels);
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);

            gridView1.CellValueChanged += GridView1_CellValueChanged;
            gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((WorkCenterItemModel)workCenterItemModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((WorkCenterItemModel)workCenterItemModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };
            gridView1.BestFitColumns();
            SetLookUpEdit();
        }



        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            SetLookUpEdit();
            //LookUpEditHelper.SetGridColumnByQuery(colTM_CD, "ShiftList_WithCode", new { COMP_CD = _orgPlantArgs.OrgPlantModelArgs.Select_Comp_Code}, "코드", "명칭");
            gridView1.BestFitColumns();
        }
        private void gridView1_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            SimplePocket simplePocket;
            DataTable source;
            switch (e.Column.FieldName)
            {
                case "GD_LOC_CD":
                    simplePocket = SimplePocket.GetInstance();

                    source = simplePocket.SelectData("Locations_WithCode_Common", new
                    {
                        COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
                        PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD,
                        WH_CD = grv.GetRowCellValue(e.RowHandle, colGD_WH_CD)
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "Code", displayCaption: "Name");
                    break;
            }
        }
        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var curModel = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(e.RowHandle) as WorkCenterItemModel;
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((WorkCenterItemModel)workCenterItemModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, "");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                }
                else
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, itemModel.ITEM_TYPE_CD);
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                }
            }
        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((WorkCenterItemModel)model).COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD;
            ((WorkCenterItemModel)model).PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD;
            ((WorkCenterItemModel)model).WC_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_WorkCenter_WC_CD;
            ((WorkCenterItemModel)model).MAT_WH_CD = "10";
            ((WorkCenterItemModel)model).GD_WH_CD = "20";
            //((WorkCenterItemModel)model).GD_LOC_CD = "2001";


            _itemMasterRepositoryButtonEdit.InitCompCode(_prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD);

            ((WorkCenterItemModel)model).VALID_DT = DateTime.Now.Date;
            ((WorkCenterItemModel)model).VALID_DT_KEY = DateTime.Now.Date;

            base.SetInsertDefaultValue(model);
        }
        public void SetLookUpEdit()
        {
            LookUpEditHelper.SetGridColumnByQuery(colMAT_WH_CD, "WareHouses", new
            {
                COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
                PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD
            }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colGD_WH_CD, "WareHouses", new
            {
                COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
                PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD
            }, "CODE", "NAME");

            //품목유형
            LookUpEditHelper.SetGridColumnByQuery(
                colITEM_TYPE_CD, 
                "ItemType", 
                new { COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD, 
                    PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD }
                , "Code", "Name");
            //제품군
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup",
             new
             {
                 COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
                 PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD,
                 ITEM_GR_CLS = "ITEM_GR_1"
             }, "Code", "Name");

            //위치 
            LookUpEditHelper.SetGridColumnByQuery(
                colGD_LOC_CD
                , "Locations_WithCode_Common"
                , new 
                    { 
                        COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD
                        , PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD
                        , WH_CD = "" }
                , "Code", "Name");


        }
    }
}

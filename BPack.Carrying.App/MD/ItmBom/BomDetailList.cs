using BPack.Common.Model;
using BPack.Model.App.MD.ItmBom;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmBom;
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
using BPack.CommonMes.Controls.ItemMaster;

namespace BPack.Carrying.App.MD.ItmBom
{
    public partial class BomDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmBomArgs _ItmBomArgs;
        private ItmBomPocket _itmBomPocket;
        private BomDetailEditForm _bomDetailEditForm;

        ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public BomDetailList(ItmBomArgs ItmBomMainArgs, ItmBomPocket itmBomPocket)
        {
            InitializeComponent();

            _ItmBomArgs = ItmBomMainArgs;
            _itmBomPocket = itmBomPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bomDetailModelBindingSource,
                FormArgs = _ItmBomArgs,
                ModelArgs = _ItmBomArgs.itmBomModelArgs,
                InitModelType = typeof(BomDetailModel),
                GridView = gridView1,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<ItmBomModelArgs, BomDetailModel>(_itmBomPocket.SelectBomDetailModels, _itmBomPocket.SaveBomDetail, _itmBomPocket.SaveBomDetails);

            _bomDetailEditForm = new BomDetailEditForm(_ItmBomArgs, _itmBomPocket);
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((BomDetailModel)bomDetailModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((BomDetailModel)bomDetailModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
                ((BomDetailModel)bomDetailModelBindingSource.Current).ITEM_TYPE_CD = e.SeletedItemMasterModel.ITEM_TYPE_CD;
                ((BomDetailModel)bomDetailModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };
            colITEM_CD.MinWidth = 170;
            colITEM_NM.MinWidth = 220;


            //gridView1.OptionsEditForm.CustomEditFormLayout = _bomDetailEditForm;
            //gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            //{
            //    _bomDetailEditForm.DataRefresh(bomDetailModelBindingSource.Current);
            //};
        }


        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((BomDetailModel)model).COMP_CD = _ItmBomArgs.itmBomModelArgs.Select_Comp_Code;
            ((BomDetailModel)model).PLANT_CD = _ItmBomArgs.itmBomModelArgs.Select_Plant_Code;
            ((BomDetailModel)model).BOM_NO = _ItmBomArgs.itmBomModelArgs.Select_Bom_No;
            ((BomDetailModel)model).BOM_UNIT = "EA";
            ((BomDetailModel)model).BOM_QTY = 1;

            _itemMasterRepositoryButtonEdit.InitCompCode(_ItmBomArgs.itmBomModelArgs.Select_Comp_Code);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_ItmBomArgs.itmBomModelArgs.Select_Plant_Code);
        }

        public override void DataRefresh(ArgsBase args)
        {
            
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnCommonCode(colBOM_UNIT, _ItmBomArgs.itmBomModelArgs.Select_Main_Comp_Code, "UNIT");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType", new { COMP_CD = _ItmBomArgs.itmBomModelArgs.Select_Main_Comp_Code, PLANT_CD = _ItmBomArgs.itmBomModelArgs.Select_Main_Plant_Code }, "품목유형코드", "품목유형명");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup",
             new
             {
                 COMP_CD = _ItmBomArgs.itmBomModelArgs.Select_Comp_Code,
                 PLANT_CD = _ItmBomArgs.itmBomModelArgs.Select_Main_Plant_Code,
                 ITEM_GR_CLS = "ITEM_GR_1"
             }, "제품군", "제품군");
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((BomDetailModel)bomDetailModelBindingSource.Current).ITEM_CD;
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
    }
}

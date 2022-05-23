using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.MaterialRequest;
using BPack.Pocket.App.PC.MaterialRequest;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.MaterialRequest
{
    public partial class MrqdList : StrapSubForm_OnlyOneGrid_V2
    {
        private MaterialRequestArgs _materialRequestArgs;
        private MaterialRequestPocket _materialRequestPocket;

        ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public MrqdList(MaterialRequestArgs materialRequestArgs, MaterialRequestPocket materialRequestPocket)
        {
            InitializeComponent();
            this._materialRequestArgs = materialRequestArgs;
            this._materialRequestPocket = materialRequestPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = true;
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {

                BindingSource = mrqdListModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _materialRequestArgs,
                GridView = gridView1,
                InitModelType = typeof(MrqdListModel),
                ModelArgs = _materialRequestArgs.MaterialRequestModelArgs,
                StrapEditMode = StrapEditMode.Batch

            }) ;
            InitPocketDelegate<MaterialRequestModelArgs, MrqdListModel>
                (_materialRequestPocket.SelectMrqdListModels
                    , _materialRequestPocket.SaveMrqdListModel
                    , _materialRequestPocket.SaveMrqdListModels
                );
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.InitCompCode(_materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD);
            gridView1.CellValueChanged += GridView1_CellValueChanged;
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((MrqdListModel)mrqdListModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((MrqdListModel)mrqdListModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
                ((MrqdListModel)mrqdListModelBindingSource.Current).ITEM_TYPE_CD = e.SeletedItemMasterModel.ITEM_TYPE_CD;
                ((MrqdListModel)mrqdListModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;


                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
                colITEM_CD.Width = 130;
            };
            //gridView1.OptionsView.ColumnAutoWidth = true;

        }

        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((MrqdListModel)mrqdListModelBindingSource.Current).ITEM_CD;
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
           
            ((MrqdListModel)model).COMP_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD;
            ((MrqdListModel)model).PLANT_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD;
            _itemMasterRepositoryButtonEdit.InitCompCode(_materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD);
            ((MrqdListModel)model).MRH_NO_KEY = _materialRequestArgs.MaterialRequestModelArgs.MRH_NO_KEY;
            ((MrqdListModel)model).MRD_STATUS = "WAIT";

            base.SetInsertDefaultValue(model);
        }


        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnSysCode(colMRD_STATUS, "MRD_STATUS");

            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType"
               , new
               {
                   COMP_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD
                       ,
                   PLANT_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD
               }, "품목유형코드", "품목유형명");

            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup",
             new
             {
                 COMP_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD
                       ,
                 PLANT_CD = _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD
                 ,
                 ITEM_GR_CLS = "ITEM_GR_1"
             }, "제품군", "제품군");

            gridView1.BestFitColumns();

            colITEM_CD.Width = 130;
        }
    }
}

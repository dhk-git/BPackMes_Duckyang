using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.MM.MovLoc;
using BPack.Pocket.App.MM.MovLoc;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.MovLoc
{
    public partial class MovLocItemList : StrapSubForm_OnlyOneGrid_V2
    {
        MovLocArgs _movLocArgs;
        MovLocPocket _movLocPocket;
        ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;
        public MovLocItemList()
        {
            InitializeComponent();
        }
        public MovLocItemList(MovLocArgs movLocArgs, MovLocPocket movLocPocket) : this()
        {
            _movLocArgs = movLocArgs;
            _movLocPocket = movLocPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = movLocItemModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _movLocArgs,
                GridView = gridView1,
                InitModelType = typeof(MovLocItemModel),
                ModelArgs = _movLocArgs.MovLocModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            
            InitPocketDelegate<MovLocModelArgs, MovLocItemModel>(_movLocPocket.SelectDetailModels, _movLocPocket.SaveItemModel,_movLocPocket.SaveItemModels);
            
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((MovLocItemModel)movLocItemModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((MovLocItemModel)movLocItemModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
                ((MovLocItemModel)movLocItemModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;
                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };

        }
        public override void DataRefresh(ArgsBase args)
        {
            //LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode", new { COMP_CD = _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd, PLANT_CD = _girHistArgs.GirHistModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명");
            //LookUpEditHelper.SetGridColumnByQuery(colGIR_TYPE_CD, "GirType", new { COMP_CD = _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd }, "수불유형코드", "수불유형명");
            //LookUpEditHelper.SetItemType(colITEM_TYPE, _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd);

            base.DataRefresh(args);

            _itemMasterRepositoryButtonEdit.InitCompCode(_movLocArgs.MovLocModelArgs.Select_Main_Comp_cd);
            _itemMasterRepositoryButtonEdit.InitCompCode(_movLocArgs.MovLocModelArgs.Select_Main_Plant_cd);

        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
            ((MovLocItemModel)model).COMP_CD = _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd;
            ((MovLocItemModel)model).PLANT_CD = _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd;

            _itemMasterRepositoryButtonEdit.InitCompCode(_movLocArgs.MovLocModelArgs.Select_Main_Comp_cd);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_movLocArgs.MovLocModelArgs.Select_Main_Plant_cd);
            ((MovLocItemModel)model).MOV_NO = _movLocArgs.MovLocModelArgs.Select_Main_MOV_NO;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((MovLocItemModel)movLocItemModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                }
                else
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                  
                }
            }
        }
    }
}

using BPack.Common.Model;
using BPack.Model.App.MD.MolItem;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.MolItem;
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

namespace BPack.Carrying.App.MD.MolItem
{
    public partial class ItemList : StrapSubForm_OnlyOneGrid_V2
    {
        private MolItemArgs _molItemArgs;
        private MolItemPocket _molItemPocket;
        private StrapRepositoryItemButtonEdit_ItemMaster _buttonItem;
        private Strap.MasterDataControls.MD.ItemMasterPocket _itemMasterPocket;
        private Strap.MasterDataControls.MD.ItemMasterModelArgs _itemMasterModelArgs;

        public ItemList(MolItemArgs molItemArgs, MolItemPocket molItemPocket)
        {
            InitializeComponent();

            _molItemArgs = molItemArgs;
            _molItemPocket = molItemPocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = itemListModelBindingSource,
                FormArgs = _molItemArgs,
                GridView = gridView1,
                InitModelType = typeof(ItemListModel),
                ModelArgs = _molItemArgs.MolItemModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<MolItemModelArgs, ItemListModel>(_molItemPocket.SelectItemListModels, _molItemPocket.SaveItemListModel, _molItemPocket.SaveItemListModels);
            _itemMasterModelArgs = new Strap.MasterDataControls.MD.ItemMasterModelArgs();
            _itemMasterPocket = new Strap.MasterDataControls.MD.ItemMasterPocket();

            _buttonItem = new StrapRepositoryItemButtonEdit_ItemMaster(colITEM_CD, gridView1);
            _buttonItem.ItemMasterModelSelected += _buttonItem_ItemMasterModelSelected;
            gridView1.ValidatingEditor += GridView1_ValidatingEditor;
        }

        /// <summary>
        /// 입력 품번 유효성 검사
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if ((sender as GridView).FocusedColumn.Name != "colITEM_CD") return;

            _itemMasterModelArgs.Select_Comp_Cd = _molItemArgs.MolItemModelArgs.Select_Main_Comp_Code;
            _itemMasterModelArgs.Select_Plant_Cd = _molItemArgs.MolItemModelArgs.Select_Main_Plant_Code;
            _itemMasterModelArgs.Select_Item_Cd = e.Value?.ToString();

            var inputItem = _itemMasterPocket.SelectItemMasterModel(_itemMasterModelArgs);
            if (inputItem == null)
            {
                e.Valid = false;
                e.ErrorText = "유효하지 않은 품번입니다.";
                return;
            }
            else
            {
                ((ItemListModel)itemListModelBindingSource.Current).ITEM_NM = inputItem.ITEM_NM;
                ((ItemListModel)itemListModelBindingSource.Current).ITEM_SPEC = inputItem.ITEM_SPEC;
            }
            //var duplicateItem = ((List<ItemListModel>)itemListModelBindingSource.DataSource).Where(r => r.ITEM_CD == inputItem.ITEM_CD).FirstOrDefault();
            //if (duplicateItem != null)
            //{
            //    e.Valid = false;
            //    e.ErrorText = "이미 등록된 품번 입니다.";
            //    ((ItemListModel)itemListModelBindingSource.Current).IsCheck = false;
            //    strapGridControl1.RefreshDataSource();
            //    return;
            //}
            //((ItemListModel)itemListModelBindingSource.Current).IsCheck = true;
            //strapGridControl1.RefreshDataSource();
        }

        private void _buttonItem_ItemMasterModelSelected(object sender, Strap.FormControls.PopUp.ItemMasterSelectedEventArgs e)
        {
            ((ItemListModel)itemListModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
            ((ItemListModel)itemListModelBindingSource.Current).ITEM_SPEC = e.SeletedItemMasterModel.ITEM_SPEC;

            strapGridControl1.RefreshDataSource();
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((ItemListModel)model).COMP_CD = _molItemArgs.MolItemModelArgs.Select_Main_Comp_Code;
            ((ItemListModel)model).PLANT_CD = _molItemArgs.MolItemModelArgs.Select_Main_Plant_Code;
            ((ItemListModel)model).MOLD_CD= _molItemArgs.MolItemModelArgs.Select_Mold_Code;
        }

        public override void DataRefresh(ArgsBase args)
        {
            _buttonItem.InitCompCode(_molItemArgs.MolItemModelArgs.Select_Main_Comp_Code);
            _buttonItem.InitPlantCode(_molItemArgs.MolItemModelArgs.Select_Main_Plant_Code);

            base.DataRefresh(args);
        }
    }
}

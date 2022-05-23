using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.EquItemCheckList;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.EquItemCheckList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Strap.EditControls;

namespace BPack.Carrying.App.MD.EquItemCheckList
{
    public partial class ItemList : StrapSubForm_OnlyOneGrid_V2
    {
        EquItemCheckListArgs _equItemCheckListArgs;
        EquItemCheckListPocket _equItemCheckListPocket;
        ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public ItemList(EquItemCheckListArgs equItemCheckListArgs, EquItemCheckListPocket equItemCheckListPocket)
        {
            InitializeComponent();

            _equItemCheckListArgs = equItemCheckListArgs;
            _equItemCheckListPocket = equItemCheckListPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = equItemCheckListItemModelBindingSource,
                FormArgs = _equItemCheckListArgs,
                GridView = gridView1,
                InitModelType = typeof(EquItemCheckListItemModel),
                ModelArgs = _equItemCheckListArgs.EquItemCheckListModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<EquItemCheckListModelArgs, EquItemCheckListItemModel>(_equItemCheckListPocket.SelectItemModels, null, _equItemCheckListPocket.SaveItemModels);

            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((EquItemCheckListItemModel)equItemCheckListItemModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((EquItemCheckListItemModel)equItemCheckListItemModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;
                //((EquItemCheckListItemModel)equItemCheckListItemModelBindingSource.Current).ALC_CD = e.SeletedItemMasterModel.ALC_CD;
                //((EquItemCheckListItemModel)equItemCheckListItemModelBindingSource.Current).ITEM_TYPE = e.SeletedItemMasterModel.ITEM_TYPE;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((EquItemCheckListItemModel)model).COMP_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code;
            ((EquItemCheckListItemModel)model).PLANT_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Plant_Code;
            ((EquItemCheckListItemModel)model).EQUIP_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Equip_Code;

            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE, "ItemType", new { COMP_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code }, "품목유형코드", "품목유형명");

            _itemMasterRepositoryButtonEdit.InitCompCode(_equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Plant_Code);

            base.DataRefresh(args);
        }
    }
}

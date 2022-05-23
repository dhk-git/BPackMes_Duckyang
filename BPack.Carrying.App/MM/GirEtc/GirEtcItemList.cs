using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.MM.GirEtc;
using BPack.Pocket.App.MM.GirEtc;
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

namespace BPack.Carrying.App.MM.GirEtc
{
    public partial class GirEtcItemList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirEtcArgs _girEtcArgs;
        private GirEtcPocket _girEtcPocket;
        private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;
        public GirEtcItemList()
        {
            InitializeComponent();
        }
        public GirEtcItemList(GirEtcArgs girEtcArgs, GirEtcPocket girEtcPocket) : this()
        {
            _girEtcArgs = girEtcArgs;
            _girEtcPocket = girEtcPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = girEtcItemModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girEtcArgs,
                GridView = gridView1,
                InitModelType = typeof(GirEtcItemModel),
                ModelArgs = _girEtcArgs.GirEtcModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<GirEtcModelArgs, GirEtcItemModel>(_girEtcPocket.SelectDetailModels, _girEtcPocket.SaveItemModel,_girEtcPocket.SaveItemModels);
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.InitCompCode(Common.LoginInfo.UserInfo.CompCode);
            _itemMasterRepositoryButtonEdit.InitPlantCode(Common.LoginInfo.UserInfo.PlantCode);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((GirEtcItemModel)girEtcItemModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((GirEtcItemModel)girEtcItemModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;
                ((GirEtcItemModel)girEtcItemModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;
                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };
            gridView1.CellValueChanged += GridView1_CellValueChanged;            
        }

        private SimplePocket _sp = SimplePocket.GetInstance();
        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var currentModel = (GirEtcItemModel)girEtcItemModelBindingSource.Current;
                var itemcd = currentModel.ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    //gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    //gridView1.SetFocusedRowCellValue(colITEM_SPEC, "");
                    //gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                    currentModel.ITEM_NM = "NotFound ItemCode";
                    currentModel.ITEM_GR_1 = "";
                    StrapMessageBox.Show("A002", 5); //존재하지 않는 품목이 있습니다.
                }
                else
                {
                    if (((List<GirEtcItemModel>)this.SelectedModels).Where(a => a.ITEM_CD == itemModel.ITEM_CD).Count() > 1)
                    {
                        //gridView1.SetFocusedRowCellValue(colITEM_CD, "");
                        //gridView1.SetFocusedRowCellValue(colITEM_NM, "");
                        currentModel.ITEM_CD = "";
                        currentModel.ITEM_NM = "";
                        StrapMessageBox.Show("A002", 20); // 동일한 품목이 존재합니다.
                        return;
                    }
                    //gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    ////gridView1.SetFocusedRowCellValue(colITEM_SPEC, itemModel.ITEM_SPEC);
                    //gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                    currentModel.ITEM_NM = itemModel.ITEM_NM;
                    currentModel.ITEM_GR_1 = itemModel.ITEM_GR_1;
                }
            }
        }

        public override void DataRefresh(ArgsBase args)
        {
            //LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode", new { COMP_CD = _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd, PLANT_CD = _girHistArgs.GirHistModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명");
            //LookUpEditHelper.SetGridColumnByQuery(colGIR_TYPE_CD, "GirType", new { COMP_CD = _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd }, "수불유형코드", "수불유형명");
            //LookUpEditHelper.SetItemType(colITEM_TYPE, _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd);

            base.DataRefresh(args);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((GirEtcItemModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((GirEtcItemModel)model).PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
            ((GirEtcItemModel)model).ETG_NO = _girEtcArgs.GirEtcModelArgs.Select_Etg_No;
            base.SetInsertDefaultValue(model);
        }

    }
}

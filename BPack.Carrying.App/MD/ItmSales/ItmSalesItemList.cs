using BPack.Common.Model;
using BPack.Model.App.MD.ItmSales;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmSales;
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
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.ItmSales
{
    public partial class ItmSalesItemList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmSalesPocket _itmSalesPocket;
        private ItmSalesArgs _itmSalesArgs;
        private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public ItmSalesItemList()
        {
            InitializeComponent();
        }

        public ItmSalesItemList(ItmSalesArgs itmListArgs, ItmSalesPocket itmListPocket) : this()
        {
            _itmSalesArgs = itmListArgs;
            _itmSalesPocket = itmListPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = false;
            
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = itmSalesItemModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _itmSalesArgs,
                GridView = gridView1,
                InitModelType = typeof(ItmSalesItemModel),
                ModelArgs = _itmSalesArgs.ItmSalesModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<ItmSalesModelArgs, ItmSalesItemModel>(_itmSalesPocket.SelectItmSalesItemModels, _itmSalesPocket.SaveItmSalesItemModel, _itmSalesPocket.SaveItmSalesItemModels);
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((ItmSalesItemModel)itmSalesItemModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((ItmSalesItemModel)itmSalesItemModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };
            if (!this.AuthModel.DUMMY1_AUTH)
            {
                colSL_PRICE.Visible = false;
                colSL_PRICE.OptionsColumn.ShowInCustomizationForm = false;
                colCURRENCY_TYPE.Visible = false;
                colCURRENCY_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            }

            LookUpEditHelper.SetGridColumnSysCode(colCURRENCY_TYPE, "CURRENCY_TYPE");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "CODE", "NAME");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {


            ((ItmSalesItemModel)model).COMP_CD = _itmSalesArgs.ItmSalesModelArgs.Select_Main_Comp_CD;
            ((ItmSalesItemModel)model).PLANT_CD = _itmSalesArgs.ItmSalesModelArgs.Select_Main_Plant_CD;
            ((ItmSalesItemModel)model).BP_CD = _itmSalesArgs.ItmSalesModelArgs.Select_Main_BP_CD;

            ((ItmSalesItemModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((ItmSalesItemModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);
            ((ItmSalesItemModel)model).CURRENCY_TYPE = CommonMes.Config.GlobalSettings.CURRENCY_TYPE;
            base.SetInsertDefaultValue(model);

        }

        public override void DataRefresh(ArgsBase args)
        {
            _itemMasterRepositoryButtonEdit.InitCompCode(_itmSalesArgs.ItmSalesModelArgs.Select_Main_Comp_CD);
            _itemMasterRepositoryButtonEdit.InitPlantCode(_itmSalesArgs.ItmSalesModelArgs.Select_Main_Plant_CD);

            base.DataRefresh(args);
        }

        public override void DataClear(ArgsBase args)
        {
            base.DataClear(args);
        }


        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((ItmSalesItemModel)itmSalesItemModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                    gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, "");
                    //gridView1.SetFocusedRowCellValue(colitem, "");
                    //gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                }
                else
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                    gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, itemModel.ITEM_TYPE_CD);
                    //gridView1.SetFocusedRowCellValue(colITEM_SPEC, itemModel.ITEM_SPEC);
                    //gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                }
            }
        }
    }
}

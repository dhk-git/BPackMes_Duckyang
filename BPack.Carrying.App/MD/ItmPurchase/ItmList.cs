using BPack.Common.Model;
using BPack.Model.App.MD.ItmPurchase;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmPurchase;
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
using DevExpress.XtraGrid.Views.Base;

namespace BPack.Carrying.App.MD.ItmPurchase
{
    public partial class ItmList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmPurchasePocket _itmPurchasePocket;
        private ItmPurchaseArgs _itmPurchaseArgs;

        ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public ItmList()
        {
            InitializeComponent();
        }

        public ItmList(ItmPurchaseArgs itmPurchaseArgs, ItmPurchasePocket itmPurchasePocket) : this()
        {
            _itmPurchaseArgs = itmPurchaseArgs;
            _itmPurchasePocket = itmPurchasePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = itmListModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _itmPurchaseArgs,
                GridView = gridView1,
                InitModelType = typeof(ItmListModel),
                ModelArgs = _itmPurchaseArgs.ItmPurchaseModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<ItmPurchaseModelArgs, ItmListModel>(_itmPurchasePocket.SelectItmListModels, _itmPurchasePocket.SaveItmListModel, _itmPurchasePocket.SaveItmListModels);
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.InitCompCode(Common.LoginInfo.UserInfo.CompCode);
            _itemMasterRepositoryButtonEdit.InitPlantCode(Common.LoginInfo.UserInfo.PlantCode);
            gridView1.CellValueChanged += GridView1_CellValueChanged;
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((ItmListModel)itmListModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((ItmListModel)itmListModelBindingSource.Current).ITEM_CD = e.SeletedItemMasterModel.ITEM_CD;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };

            if (!this.AuthModel.DUMMY1_AUTH)
            {
                colPUR_PRICE.Visible = false;
                colPUR_PRICE.OptionsColumn.ShowInCustomizationForm = false;
                colCURRENCY_TYPE.Visible = false;
                colCURRENCY_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            }

            LookUpEditHelper.SetGridColumnSysCode(colCURRENCY_TYPE, "CURRENCY_TYPE");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "CODE", "NAME");
        }

        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {

            if (e.Column == colITEM_CD)
            {
                var itemcd = ((ItmListModel)itmListModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    //gridView1.SetFocusedRowCellValue(colITEM_SPEC, "");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                    gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, "");
                }
                else
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    //gridView1.SetFocusedRowCellValue(colITEM_SPEC, itemModel.ITEM_SPEC);
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                    gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, itemModel.ITEM_TYPE_CD);
                    //var price = _sp.SelectData<dynamic>("GetPrice", new
                    //{
                    //    COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                    //    PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                    //    BP_CD = _salesOrderArgs.SalesOrderModelArgs.Select_Bp_Cd,
                    //    ITEM_CD = itemModel.ITEM_CD
                    //}).SingleOrDefault();
                    //if (price != null)
                    //{
                    //    gridView1.SetFocusedRowCellValue(colSOD_PRICE, price.PRICE);
                    //    gridView1.SetFocusedRowCellValue(colCURRENCY_TYPE, price.CURRENCY_TYPE);
                    //}
                    //else
                    //{
                    //    gridView1.SetFocusedRowCellValue(colSOD_PRICE, 0);
                    //}
                }
            }
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ItmListModel)model).COMP_CD = _itmPurchaseArgs.ItmPurchaseModelArgs.Select_Comp_CD;
            ((ItmListModel)model).PLANT_CD = _itmPurchaseArgs.ItmPurchaseModelArgs.Select_Plant_CD;
            ((ItmListModel)model).BP_CD = _itmPurchaseArgs.ItmPurchaseModelArgs.Select_Bp_CD;
            
            ((ItmListModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((ItmListModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);
            ((ItmListModel)model).CURRENCY_TYPE = CommonMes.Config.GlobalSettings.CURRENCY_TYPE;

            base.SetInsertDefaultValue(model);
        }

    }
}

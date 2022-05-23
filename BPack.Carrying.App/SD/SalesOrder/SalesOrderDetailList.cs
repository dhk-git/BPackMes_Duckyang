using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.SalesOrder;
using BPack.Pocket.App.SD.SalesOrder;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace BPack.Carrying.App.SD.SalesOrder
{
    public partial class SalesOrderDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private SalesOrderArgs _salesOrderArgs;
        private SalesOrderPocket _salesOrderPocket;
        private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public SalesOrderDetailList()
        {
            InitializeComponent();
        }

        public SalesOrderDetailList(SalesOrderArgs salesOrderArgs, SalesOrderPocket salesOrderPocket) : this()
        {
            this._salesOrderArgs = salesOrderArgs;
            this._salesOrderPocket = salesOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = salesOrderDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _salesOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(SalesOrderDetailModel),
                ModelArgs = _salesOrderArgs.SalesOrderModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<SalesOrderModelArgs, SalesOrderDetailModel>(_salesOrderPocket.SelectSalesOrderDetailModels, null, _salesOrderPocket.SaveSalesOrderDetailModels);
            LookUpEditHelper.SetGridColumnSysCode(colCURRENCY_TYPE, "CURRENCY_TYPE");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _salesOrderArgs.SalesOrderModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME");
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.InitCompCode(Common.LoginInfo.UserInfo.CompCode);
            _itemMasterRepositoryButtonEdit.InitPlantCode(Common.LoginInfo.UserInfo.PlantCode);

            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((SalesOrderDetailModel)salesOrderDetailModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                //((DlvOrderDetailModel)dlvOrderDetailModelBindingSource.Current).ITEM_SPEC = e.SeletedItemMasterModel.ITEM_SPEC;
                ((SalesOrderDetailModel)salesOrderDetailModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };
            gridView1.CellValueChanged += GridView1_CellValueChanged;
            gridView1.OptionsView.ShowFooter = true;
            GridUnboundColumn.SetUnboundColumn(gridView1, colSOD_AMOUNT
                , typeof(SalesOrderDetailModel), "SOD_AMOUNT", "[SOD_QTY] * [SOD_PRICE]", true);
            //var prop = typeof(SalesOrderDetailModel).GetProperty("SOD_AMOUNT");
            //var caption = ((DisplayAttribute)prop.GetCustomAttributes().Where(a => a.GetType() == typeof(DisplayAttribute)).SingleOrDefault()).Name;

            //colSOD_AMOUNT.FieldName = "UnboundSod_Amount";
            //colSOD_AMOUNT.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            //colSOD_AMOUNT.UnboundExpression = "[SOD_QTY] * [SOD_PRICE]";

            //DevExpress.XtraGrid.GridColumnSummaryItem gridColumnSummaryItem = new DevExpress.XtraGrid.GridColumnSummaryItem();
            //gridColumnSummaryItem.FieldName = colSOD_AMOUNT.FieldName;
            //gridColumnSummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //gridColumnSummaryItem.DisplayFormat = "{0:#,##0.#}";
            //colSOD_AMOUNT.Summary.Add(gridColumnSummaryItem);

            //var trLang = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, caption);
            //if (!string.IsNullOrEmpty(trLang))
            //{
            //    colSOD_AMOUNT.Caption = trLang;
            //}
            //else
            //{
            //    colSOD_AMOUNT.Caption = caption;
            //}
            if (!this.AuthModel.DUMMY1_AUTH)
            {
                colSOD_PRICE.Visible = false;
                colSOD_PRICE.OptionsColumn.ShowInCustomizationForm = false;
                colSOD_AMOUNT.Visible = false;
                colSOD_AMOUNT.OptionsColumn.ShowInCustomizationForm = false;
                colCURRENCY_TYPE.Visible = false;
                colCURRENCY_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            }
        }
        private SimplePocket _sp = SimplePocket.GetInstance();
        private void GridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((SalesOrderDetailModel)salesOrderDetailModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    gridView1.SetFocusedRowCellValue(colITEM_SPEC, "");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                    StrapMessageBox.Show("A002", 5); //존재하지 않는 품목이 있습니다.
                }
                else
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    gridView1.SetFocusedRowCellValue(colITEM_SPEC, itemModel.ITEM_SPEC);
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                    var price = _sp.SelectData<dynamic>("GetSalesPrice", new
                    {
                        COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                        PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                        BP_CD = _salesOrderArgs.SalesOrderModelArgs.Select_Bp_Cd,
                        ITEM_CD = itemModel.ITEM_CD
                    }).SingleOrDefault();
                    if (price != null)
                    {
                        gridView1.SetFocusedRowCellValue(colSOD_PRICE, price.PRICE);
                        gridView1.SetFocusedRowCellValue(colCURRENCY_TYPE, price.CURRENCY_TYPE);
                    }
                    else
                    {
                        gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                        gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                        StrapMessageBox.Show("A002", 18); //해당 거래처에 등록되지 않은 품목 입니다.
                    }
                }
            }
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((SalesOrderDetailModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((SalesOrderDetailModel)model).PLANT_CD = _salesOrderArgs.SalesOrderModelArgs.Select_Main_Plant_Cd;
            ((SalesOrderDetailModel)model).SOR_NO = _salesOrderArgs.SalesOrderModelArgs.Select_Sor_No;
            ((SalesOrderDetailModel)model).SOR_DT = DateTime.Now.Date;
            ((SalesOrderDetailModel)model).DUE_DT = DateTime.Now.Date;
            ((SalesOrderDetailModel)model).SOD_STATUS = "INIT";
            ((SalesOrderDetailModel)model).SOD_DLV_STATUS = "WAIT";
            ((SalesOrderDetailModel)model).CURRENCY_TYPE = CommonMes.Config.GlobalSettings.CURRENCY_TYPE;
            ((SalesOrderDetailModel)model).SOD_SEQ = gridView1.RowCount;
            base.SetInsertDefaultValue(model);
        }

        public string ValidateConfirmSalesOrder()
        {
            string msg = "";
            if (salesOrderDetailModelBindingSource == null || salesOrderDetailModelBindingSource.Count == 0)
            {
                //주문 품목 데이터가 존재하지 않습니다.
                msg = StrapMessageBox.GetMessage("A002", 1);
            }
            foreach (var model in this.SelectedModels)
            {
                if (string.IsNullOrWhiteSpace(((SalesOrderDetailModel)model).CUSTOM_PO_NO))
                {
                    //고객사 발주번호가 없는 행이 존재합니다.
                    msg = StrapMessageBox.GetMessage("A002", 2);
                    break;
                }
                if (((SalesOrderDetailModel)model).RowState != RowState.UnChanged) //저장되지 않은 데이터가 존재합니다. 저장후 다시 시도바랍니다.
                {
                    msg = StrapMessageBox.GetMessage("A002", 4);
                    break;
                }
            }

            return msg;
        }

        public List<SalesOrderDetailModel> GetSelectedModels()
        {
            List<SalesOrderDetailModel> selectedModels = new List<SalesOrderDetailModel>();
            selectedModels = ((List<SalesOrderDetailModel>)this.SelectedModels).Where(a => a.IsCheck == true).ToList();
            return selectedModels;
        }

    }
}

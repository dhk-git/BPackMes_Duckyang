using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PO.PurOrder;
using BPack.Pocket.App.PO.PurOrder;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.PO.PurOrder
{
    public partial class PurOrderDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurOrderArgs _purOrderArgs;
        private PurOrderPocket _purOrderPocket;
        private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;
        public PurOrderDetailList()
        {
            InitializeComponent();
        }

        public PurOrderDetailList(PurOrderArgs purOrderArgs, PurOrderPocket purOrderPocket) : this()
        {
            this._purOrderArgs = purOrderArgs;
            this._purOrderPocket = purOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = purOrderDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _purOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(PurOrderDetailModel),
                ModelArgs = _purOrderArgs.PurOrderModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PurOrderModelArgs, PurOrderDetailModel>(_purOrderPocket.SelectPurOrderDetailModels,null, _purOrderPocket.SavePurOrderDetailModels);
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.InitCompCode(Common.LoginInfo.UserInfo.CompCode);
            _itemMasterRepositoryButtonEdit.InitPlantCode(Common.LoginInfo.UserInfo.PlantCode);
            //_itemMasterRepositoryButtonEdit.InitStrap();
            
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((PurOrderDetailModel)purOrderDetailModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                ((PurOrderDetailModel)purOrderDetailModelBindingSource.Current).ITEM_SPEC = e.SeletedItemMasterModel.ITEM_SPEC;
                ((PurOrderDetailModel)purOrderDetailModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };

            gridView1.CellValueChanged += GridView1_CellValueChanged;
            LookUpEditHelper.SetGridColumnSysCode(colCURRENCY_TYPE, "CURRENCY_TYPE");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "CODE", "NAME");

            gridView1.OptionsView.ShowFooter = true;
            var prop = typeof(PurOrderDetailModel).GetProperty("POD_AMOUNT");
            var caption = ((DisplayAttribute)prop.GetCustomAttributes().Where(a => a.GetType() == typeof(DisplayAttribute)).SingleOrDefault()).Name;
            colPOD_AMOUNT.FieldName = "UnboundPod_Amount";
            colPOD_AMOUNT.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            colPOD_AMOUNT.UnboundExpression = "[POD_QTY] * [POD_PRICE]";
            
            DevExpress.XtraGrid.GridColumnSummaryItem gridColumnSummaryItem = new DevExpress.XtraGrid.GridColumnSummaryItem();
            gridColumnSummaryItem.FieldName = colPOD_AMOUNT.FieldName;
            gridColumnSummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridColumnSummaryItem.DisplayFormat = "{0:#,##0.#}";
            colPOD_AMOUNT.Summary.Add(gridColumnSummaryItem);

            var trLang = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, caption);
            if (!string.IsNullOrEmpty(trLang))
            {
                colPOD_AMOUNT.Caption = trLang;
            }
            else
            {
                colPOD_AMOUNT.Caption = caption;
            }
            if (!this.AuthModel.DUMMY1_AUTH)
            {
                colPOD_PRICE.Visible = false;
                colPOD_PRICE.OptionsColumn.ShowInCustomizationForm = false;
                colPOD_AMOUNT.Visible = false;
                colPOD_AMOUNT.OptionsColumn.ShowInCustomizationForm = false;
                colCURRENCY_TYPE.Visible = false;
                colCURRENCY_TYPE.OptionsColumn.ShowInCustomizationForm = false;
            }
        }
        private SimplePocket _sp = SimplePocket.GetInstance();
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((PurOrderDetailModel)purOrderDetailModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    gridView1.SetFocusedRowCellValue(colITEM_SPEC, "");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                    gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, "");
                }
                else
                {
                    //gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    //gridView1.SetFocusedRowCellValue(colITEM_SPEC, itemModel.ITEM_SPEC);
                    //gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                    var price = _sp.SelectData<dynamic>("GetPurchasePrice", new
                    {
                        COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                        PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                        BP_CD = _purOrderArgs.PurOrderModelArgs.Select_Bp_Cd,
                        ITEM_CD = itemModel.ITEM_CD
                    }).SingleOrDefault();
                    if (price != null)
                    {
                        gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                        gridView1.SetFocusedRowCellValue(colITEM_SPEC, itemModel.ITEM_SPEC);
                        gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                        gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, itemModel.ITEM_TYPE_CD);
                        gridView1.SetFocusedRowCellValue(colPUR_SIZE, itemModel.PUR_SIZE);
                        gridView1.SetFocusedRowCellValue(colPOD_PRICE, price.PRICE);
                        gridView1.SetFocusedRowCellValue(colCURRENCY_TYPE, price.CURRENCY_TYPE);
                    }
                    else
                    {
                        gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                        gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                        gridView1.SetFocusedRowCellValue(colITEM_TYPE_CD, "");
                        gridView1.SetFocusedRowCellValue(colITEM_SPEC, "");
                        gridView1.SetFocusedRowCellValue(colPUR_SIZE, "");
                        gridView1.SetFocusedRowCellValue(colPOD_PRICE, "");
                        StrapMessageBox.Show("A002", 18); //해당 거래처에 등록되지 않은 품목 입니다.
                    }
                }
            }
            if (e.Column == colPOD_QTY)
            {
                var currentModel = ((PurOrderDetailModel)purOrderDetailModelBindingSource.Current);
                try
                {
                    var quo = Convert.ToInt32(currentModel.POD_QTY) / Convert.ToInt32(currentModel.PUR_SIZE);
                    var mod = currentModel.POD_QTY % currentModel.PUR_SIZE;
                    if (mod > 0)
                    {
                        currentModel.POD_QTY = (quo + 1) * currentModel.PUR_SIZE;
                    }
                    else
                    {
                        currentModel.POD_QTY = quo * currentModel.PUR_SIZE;
                    }
                }
                catch (DivideByZeroException)
                {
                    StrapMessageBox.Show("A002", 25);//"발주단위수량이 등록되지 않았거나 0 입니다. 품목정보에서 발주단위수량을 등록바랍니다."
                }
                
                
            }
        }

        internal string CheckConfirmOrder()
        {
            string returnMsg = "";
            if (!this.SelectedModels.Any())
            {
                returnMsg = StrapMessageBox.GetMessage("A002", 24); //발주 품목이 존재하지 않습니다.
                return returnMsg;
            }
            foreach (var model in this.SelectedModels)
            {
                if (((PurOrderDetailModel)model).RowState != RowState.UnChanged)
                {
                    returnMsg = StrapMessageBox.GetMessage("A002", 4); //저장되지 않은 데이터가 존재합니다. 저장후 다시 시도바랍니다.
                    break;
                }
                if (string.IsNullOrEmpty(((PurOrderDetailModel)model).POD_QTY.ToString()) || ((PurOrderDetailModel)model).POD_QTY == 0)
                {
                    returnMsg = StrapMessageBox.GetMessage("A002", 23); //수량이 0 인 데이터가 존재합니다.
                    break;
                }
            }

            return returnMsg;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((PurOrderDetailModel)model).POH_NO = _purOrderArgs.PurOrderModelArgs.Select_Poh_No;
            ((PurOrderDetailModel)model).DUE_DT = DateTime.Now.Date;
            ((PurOrderDetailModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((PurOrderDetailModel)model).PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
            ((PurOrderDetailModel)model).CURRENCY_TYPE = CommonMes.Config.GlobalSettings.CURRENCY_TYPE;
            ((PurOrderDetailModel)model).POD_STATUS = "WAIT";
            ((PurOrderDetailModel)model).DEL_FG = "N";
            ((PurOrderDetailModel)model).IS_BATCH_FROM_POR = "N";
            base.SetInsertDefaultValue(model);
        }
        public override void Save(ArgsBase args)
        {
            foreach (var model in this.SelectedModels)
            {
                if (((PurOrderDetailModel)model).ITEM_NM.Contains("NotFound"))
                {
                    StrapMessageBox.Show("A002", 5);
                    return;
                }
            }
            base.Save(args);
        }

        public void AddPurOrderDetailFromPorData(List<PurOrderDetailModel> purOrderDetailModels)
        {
            //foreach (var model in purOrderDetailModels)
            //{
            //    ((List<PurOrderDetailModel>)this.SelectedModels).Add(model);
            //}
            //purOrderDetailModelBindingSource.ResetBindings(false);
            try
            {
                _purOrderPocket.SavePurOrderDetailModels(purOrderDetailModels);
                this.DataRefresh(_purOrderArgs);
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
            
        }
    }
}

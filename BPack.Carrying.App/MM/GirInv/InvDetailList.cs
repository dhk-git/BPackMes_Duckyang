using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.MM.GirInv;
using BPack.Pocket.App.MM.GirInv;
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

namespace BPack.Carrying.App.MM.GirInv
{
    public partial class InvDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirInvArgs _girInvArgs;
        private GirInvPocket _girInvPocket;
        private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public InvDetailList()
        {
            InitializeComponent();
        }

        public InvDetailList(GirInvArgs girInvArgs, GirInvPocket girInvPocket) : this()
        {
            this._girInvArgs = girInvArgs;
            this._girInvPocket = girInvPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bindingSource1,
                ExcelUploadModelType = null,
                FormArgs = _girInvArgs,
                GridView = gridView1,
                InitModelType = typeof(InvDetailModel),
                ModelArgs = _girInvArgs.GirInvModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<GirInvModelArgs, InvDetailModel>(_girInvPocket.SelectInvDetailModels, null, _girInvPocket.SaveInvDetailModels);
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.InitCompCode(Common.LoginInfo.UserInfo.CompCode);
            _itemMasterRepositoryButtonEdit.InitPlantCode(Common.LoginInfo.UserInfo.PlantCode);
            
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((InvDetailModel)bindingSource1.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                //((DlvOrderDetailModel)dlvOrderDetailModelBindingSource.Current).ITEM_SPEC = e.SeletedItemMasterModel.ITEM_SPEC;
                ((InvDetailModel)bindingSource1.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };

            gridView1.CellValueChanged += GridView1_CellValueChanged;
            gridView1.OptionsView.ShowFooter = true;
            CommonMes.Helpers.GridUnboundColumn.SetUnboundColumn(gridView1, colDIFF_QTY
                , typeof(InvDetailModel), "DIFF_QTY", "[PHYSI_STOCK_QTY] - [LOGI_STOCK_QTY]", true);

            gridView1.RowCellStyle += GridView1_RowCellStyle;

        }

        
        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column == colDIFF_QTY)
            {
                if (e.CellValue != null && decimal.Parse(e.CellValue.ToString()) < 0)
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.ForeColor = Color.Red;
                }
                else
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Regular);
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((InvDetailModel)bindingSource1.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    //gridView1.SetFocusedRowCellValue(colITEM_SPEC, "");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                }
                else
                {
                    if (((List<InvDetailModel>)this.SelectedModels).Where(a => a.ITEM_CD == itemModel.ITEM_CD).Count() > 1)
                    {
                        gridView1.SetFocusedRowCellValue(colITEM_CD, "");
                        gridView1.SetFocusedRowCellValue(colITEM_NM, "");
                        StrapMessageBox.Show("A002", 20); // 동일한 품목이 존재합니다.
                        return;
                    }
                    gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    //gridView1.SetFocusedRowCellValue(colITEM_SPEC, itemModel.ITEM_SPEC);
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                }
            }
        }
        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (((InvDetailModel)gridView1.GetRow(e.FocusedRowHandle))?.RowState == RowState.Added)
            {
                colITEM_CD.OptionsColumn.ReadOnly = false;
                colITEM_CD.OptionsColumn.AllowEdit = true;
            }
            else
            {
                colITEM_CD.OptionsColumn.ReadOnly = true;
                colITEM_CD.OptionsColumn.AllowEdit = false;
            }
            if (_girInvArgs.GirInvModelArgs.Select_Inv_Status != null && _girInvArgs.GirInvModelArgs.Select_Inv_Status.Equals("CLOSE"))
            {
                colREMARK.OptionsColumn.ReadOnly = false;
                colREMARK.OptionsColumn.AllowEdit = true;
            }
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            InvDetailModel invDetailList = (InvDetailModel)model;
            invDetailList.INV_NO = _girInvArgs.GirInvModelArgs.Select_Inv_No;
            invDetailList.COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            invDetailList.PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;

            base.SetInsertDefaultValue(model);
        }

        internal void AddItem(List<StockModel> selectedStockModels)
        {
            List<InvDetailModel> invDetailModels = new List<InvDetailModel>();
            foreach (var model in selectedStockModels)
            {
                invDetailModels.Add(new InvDetailModel {
                    COMP_CD = model.COMP_CD,
                    PLANT_CD = model.PLANT_CD,
                    ITEM_CD = model.ITEM_CD,
                    CLOSE_STOCK_QTY = model.WH_STOCK_QTY,
                    AFTER_GR_QTY = model.AFTER_GR_QTY,
                    AFTER_GI_QTY = model.AFTER_GI_QTY,
                    PHYSI_STOCK_QTY = model.LOGI_QTY,
                    INV_NO = _girInvArgs.GirInvModelArgs.Select_Inv_No,
                    CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,

                    RowState = RowState.Added
                });
            }
            _girInvPocket.SaveInvDetailModels(invDetailModels);
            DataRefresh(_girInvArgs);
        }
        public override void DataRefresh(ArgsBase args)
        {
            if (_girInvArgs.GirInvModelArgs.Select_Inv_Status != null && _girInvArgs.GirInvModelArgs.Select_Inv_Status.Equals("OPEN"))
            {
                colPHYSI_STOCK_QTY.OptionsColumn.AllowEdit = true;
                colPHYSI_STOCK_QTY.AppearanceCell.ForeColor = Color.Black;
            }
            else
            {
                colPHYSI_STOCK_QTY.OptionsColumn.AllowEdit = false;
                colPHYSI_STOCK_QTY.AppearanceCell.ForeColor = Color.FromArgb(130, 130, 130);
            }
            base.DataRefresh(args);
            colITEM_NM.Width = 200;
        }
        //public List<InvDetailModel> GetCurrentModels()
        //{
        //    return this.SelectedModels
        //}
    }
}

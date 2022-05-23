using BPack.Common.Model;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.SD.DlvOrder;
using BPack.Pocket.App.SD.DlvOrder;
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

namespace BPack.Carrying.App.SD.DlvOrder
{
    public partial class DlvOrderDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvOrderArgs _dlvOrderArgs;
        private DlvOrderPocket _dlvOrderPocket;
        private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public DlvOrderDetailList()
        {
            InitializeComponent();
        }

        public DlvOrderDetailList(DlvOrderArgs dlvOrderArgs, DlvOrderPocket dlvOrderPocket) : this()
        {
            this._dlvOrderArgs = dlvOrderArgs;
            this._dlvOrderPocket = dlvOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = dlvOrderDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _dlvOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvOrderDetailModel),
                ModelArgs = _dlvOrderArgs.DlvOrderModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<DlvOrderModelArgs, DlvOrderDetailModel>(_dlvOrderPocket.SelectDlvOrderDetailModels, null, _dlvOrderPocket.SaveDlvOrderDetailModels);
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.InitCompCode(Common.LoginInfo.UserInfo.CompCode);
            _itemMasterRepositoryButtonEdit.InitPlantCode(Common.LoginInfo.UserInfo.PlantCode);

            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((DlvOrderDetailModel)dlvOrderDetailModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                //((DlvOrderDetailModel)dlvOrderDetailModelBindingSource.Current).ITEM_SPEC = e.SeletedItemMasterModel.ITEM_SPEC;
                ((DlvOrderDetailModel)dlvOrderDetailModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };

            gridView1.CellValueChanged += GridView1_CellValueChanged;
        }
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((DlvOrderDetailModel)dlvOrderDetailModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    //gridView1.SetFocusedRowCellValue(colITEM_SPEC, "");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                }
                else
                {
                    if (((List<DlvOrderDetailModel>)this.SelectedModels).Where(a => a.ITEM_CD == itemModel.ITEM_CD).Count() > 1)
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

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((DlvOrderDetailModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((DlvOrderDetailModel)model).PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
            ((DlvOrderDetailModel)model).DOH_NO = _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No;
            base.SetInsertDefaultValue(model);
        }

        internal string CheckConfirmOrder()
        {
            string returnMsg = "";
            foreach (var model in this.SelectedModels)
            {
                if (((DlvOrderDetailModel)model).RowState != RowState.UnChanged)
                {
                    returnMsg = StrapMessageBox.GetMessage("A002", 4);
                    break;
                }
            }
            return returnMsg;
        }

        public override void Save(ArgsBase args)
        {
            foreach (var model in this.SelectedModels)
            {
                if (((DlvOrderDetailModel)model).ITEM_NM.Contains("NotFound"))
                {
                    StrapMessageBox.Show("A002", 5); //존재하지 않는 품목이 있습니다.
                    return;
                }
                if (string.IsNullOrEmpty(((DlvOrderDetailModel)model).ITEM_CD))
                {
                    StrapMessageBox.Show("A002", 21); //품번에 빈값이 존재합니다.
                    return;
                }
            }
            base.Save(args);
        }

        public List<DlvOrderDetailModel> GetSelectedData()
        {
            return this.SelectedModels as List<DlvOrderDetailModel>;
        }

        internal void AddDlvPlanModels(List<DlvPlanModel> checkedDlvPlanModels)
        {
            var currentDttm = DateTime.Now;
            foreach (var dlvPlanModel in checkedDlvPlanModels)
            {
                ((List<DlvOrderDetailModel>)this.SelectedModels).Add(new DlvOrderDetailModel
                {
                    COMP_CD = dlvPlanModel.COMP_CD,
                    BASE_UNIT = dlvPlanModel.BASE_UNIT,
                    CREATE_DTTM = currentDttm,
                    CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    DOD_QTY = dlvPlanModel.DIFF_QTY, //계획잔량으로 변경 dlvPlanModel.PLAN_QTY,
                    DPL_NO = dlvPlanModel.DPL_NO,
                    CUSTOM_PO_NO = dlvPlanModel.CUSTOM_PO_NO,
                    DOH_NO = _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No,
                    ITEM_CD = dlvPlanModel.ITEM_CD,
                    ITEM_GR_1 = dlvPlanModel.ITEM_GR_1,
                    ITEM_NM = dlvPlanModel.ITEM_NM,
                    LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                    IsCheck = true,
                    PLANT_CD = dlvPlanModel.PLANT_CD,
                    MODIFY_DTTM = currentDttm,
                    MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    RowState = RowState.Added
                });
            }
            dlvOrderDetailModelBindingSource.ResetBindings(false);
            this.Save(_dlvOrderArgs);
        }

        public bool CheckConfirm(out string msg)
        {
            bool isValid = true;
            msg = null;
            if (this.SelectedModels.Count() == 0)
            {
                msg = StrapMessageBox.GetMessage("A002", 10); //출하지시 품목이 존재하지 않습니다.
                isValid = false;
                return isValid;
            }
            var inValidedData = ((List<DlvOrderDetailModel>)this.SelectedModels).Where(a => a.RowState != RowState.UnChanged);
            if (inValidedData.Count() != 0)
            {
                msg = StrapMessageBox.GetMessage("A002", 4); //저장되지 않은 데이터가 존재합니다. 저장후 다시 시도바랍니다.
                isValid = false;
                return isValid;
            }
            return isValid;
        }

        internal void SetFocus(DlvOrderArgs dlvOrderArgs)
        {
            int selectRowHandle = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if(((DlvOrderDetailModel)gridView1.GetRow(i)).DOD_NO == dlvOrderArgs.DlvOrderModelArgs.Select_Dod_No)
                {
                    selectRowHandle = i;
                    break;
                }
            }
            _bindingSource.Position = _bindingSource.IndexOf(_gridView.GetRow(selectRowHandle)); //그리드가 필터링이나 소트되어있을때 인덱스가 달라서 수정함 20190328
            ((ModelBase)_bindingSource.Current).SelectedCheck = 1;
            strapGridControl1.SelectedModelIndex = selectRowHandle;
            strapGridControl1.SelectedModel = _bindingSource.Current as DlvOrderDetailModel;
            _gridView.FocusedRowHandle = selectRowHandle;
        }
    }
}

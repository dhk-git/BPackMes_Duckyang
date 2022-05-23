using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Controls.ItemMaster;
using BPack.Model.App.PO.PurPack;
using BPack.Pocket.App.PO.PurPack;
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

namespace BPack.Carrying.App.PO.PurPack
{
    public partial class PurPackList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurPackArgs _purPackArgs;
        private PurPackPocket _purPackPocket;
        private ItemMasterRepositoryButtonEdit _itemMasterRepositoryButtonEdit;

        public PurPackList()
        {
            InitializeComponent();
        }

        public PurPackList(PurPackArgs purPackArgs, PurPackPocket purPackPocket) : this()
        {
            this._purPackArgs = purPackArgs;
            this._purPackPocket = purPackPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = purPackModelBindingSource,
                ExcelUploadModelType = typeof(PurPackExcelUploadModel),
                FormArgs = _purPackArgs,
                GridView = gridView1,
                InitModelType = typeof(PurPackModel),
                ModelArgs = _purPackArgs.PurPackModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PurPackModelArgs, PurPackModel>(_purPackPocket.SelectPurPackModels, null, _purPackPocket.SavePurPackModels);
            _itemMasterRepositoryButtonEdit = new ItemMasterRepositoryButtonEdit(colITEM_CD, gridView1);
            _itemMasterRepositoryButtonEdit.InitCompCode(Common.LoginInfo.UserInfo.CompCode);
            _itemMasterRepositoryButtonEdit.InitPlantCode(Common.LoginInfo.UserInfo.PlantCode);
            _itemMasterRepositoryButtonEdit.ItemMasterModelSelected += (object sender, ItemMasterSelectedEventArgs e) =>
            {
                gridView1.PostEditor();
                ((PurPackModel)purPackModelBindingSource.Current).ITEM_NM = e.SeletedItemMasterModel.ITEM_NM;
                //((PurPackModel)purPackModelBindingSource.Current).ITEM_SPEC = e.SeletedItemMasterModel.ITEM_SPEC;
                ((PurPackModel)purPackModelBindingSource.Current).ITEM_GR_1 = e.SeletedItemMasterModel.ITEM_GR_1;

                gridView1.UpdateCurrentRow();
                gridView1.BestFitColumns();
            };
            gridView1.CellValueChanged += GridView1_CellValueChanged;
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colITEM_CD)
            {
                var itemcd = ((PurPackModel)purPackModelBindingSource.Current).ITEM_CD;
                var itemModel = _itemMasterRepositoryButtonEdit.GetItemMasterModel(itemcd);
                if (itemModel == null)
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, "NotFound ItemCode");
                    //gridView1.SetFocusedRowCellValue(colITEM_SPEC, "");
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, "");
                }
                else
                {
                    gridView1.SetFocusedRowCellValue(colITEM_NM, itemModel.ITEM_NM);
                    gridView1.SetFocusedRowCellValue(colITEM_GR_1, itemModel.ITEM_GR_1);
                }
            }

        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((PurPackModel)model).INVOICE_NO = _purPackArgs.PurPackModelArgs.Select_Invoice_No;
            ((PurPackModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((PurPackModel)model).PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
            ((PurPackModel)model).CREATE_DT = DateTime.Now.Date;
            ((PurPackModel)model).PAC_STATUS = "WAIT";
            base.SetInsertDefaultValue(model);
        }

        private enum PurPackType
        {
            Departed,
            Arrived
        }
        //private PurPackType _purPackType;
        //public override void ExcelImport(ArgsBase args)
        //{
        //    SelectPurPackType selectPurPackType = new SelectPurPackType();
        //    var rst = selectPurPackType.ShowDialog();
        //    if (rst == DialogResult.OK)
        //    {
        //        _purPackType = PurPackType.Departed;
        //        //ShowImportForm(typeof(PurPackExcelUploadModel));
        //        base.ExcelImport(args);
        //    }
        //    else if (rst == DialogResult.Yes)
        //    {
        //        _purPackType = PurPackType.Arrived;
        //        //ShowImportForm(typeof(PurPackExcelUploadModel));
        //        base.ExcelImport(args);
        //    }
        //    else
        //    {

        //    }
        //}

        public override bool ExcelImportDataUpload(object uploadData)
        {
            //string purType;
            //if (_purPackType == PurPackType.Departed)
            //{
            //    purType = "DEPARTED";
            //}
            //else
            //{
            //    purType = "WAIT";
            //}

            List <PurPackModel> purPackModels = new List<PurPackModel>();
            foreach (var model in (List<PurPackExcelUploadModel>)uploadData)
            {
                purPackModels.Add(new PurPackModel
                {
                    //BARCODE_NO = model.BARCODE_NO,
                    COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                    CREATE_DT = model.WORK_DT,
                    CREATE_DTTM = DateTime.Now,
                    CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    //DY_PO_NO = model.DY_PO_NO,
                    //INVOICE_NO = model.INVOICE_NO,
                    //INVOICE_NO = _purPackArgs.PurPackModelArgs.Select_Invoice_No,
                    INVOICE_NO = model.ORDER_NO + "^#^" + model.CONTAINER_NO,
                    ITEM_CD = model.ITEM_CD,
                    LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                    MODIFY_DTTM = DateTime.Now,
                    MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    PAC_QTY = model.PAC_QTY,
                    PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                    //PAC_STATUS = _purPackArgs.PurPackModelArgs.Select_Invoice_Status,
                    PAC_STATUS = "DEPARTED",
                    BARCODE_NO = model.BARCODE_NO,
                    RowState = RowState.Added,
                    //헤더생성용 추가 20220425
                    INVOICE_DT = _purPackArgs.PurPackModelArgs.ExcelImport_InvoiceDt,
                    BP_CD = _purPackArgs.PurPackModelArgs.ExcelImport_BpCd,
                    INVOICE_NO_2 = model.ORDER_NO,
                    CONTAINER_NO = model.CONTAINER_NO,
                    ETA_DT = _purPackArgs.PurPackModelArgs.ExcelImport_EtaDt
                });
            }
            try
            {
                //_purPackPocket.ExcelUploadPurPackModels(purPackModels);
                _purPackPocket.SavePurPackModels(purPackModels);
                this.DataRefresh(_purPackArgs);
                return true;
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                return false;
            }

            
        }
    }
}

using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.CiqDlvClose;
using BPack.Pocket.App.SD.CiqDlvClose;
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

namespace BPack.Carrying.App.SD.CiqDlvClose
{
    public partial class DlvResultDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private CiqDlvCloseArgs _ciqDlvCloseArgs;
        private CiqDlvClosePocket _ciqDlvClosePocket;

        public DlvResultDetailList()
        {
            InitializeComponent();
        }

        public DlvResultDetailList(CiqDlvCloseArgs ciqDlvCloseArgs, CiqDlvClosePocket ciqDlvClosePocket) : this()
        {
            this._ciqDlvCloseArgs = ciqDlvCloseArgs;
            this._ciqDlvClosePocket = ciqDlvClosePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid { 
                BindingSource = dlvResultDetailModelBindingSource,
                ExcelUploadModelType = typeof(SkbaDataExcelUploadModel),
                FormArgs = _ciqDlvCloseArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvResultDetailModel),
                ModelArgs = _ciqDlvCloseArgs.CiqDlvCloseModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<CiqDlvCloseModelArgs, DlvResultDetailModel>(_ciqDlvClosePocket.SelectDlvResultDetailModels, null, _ciqDlvClosePocket.SaveDlvResultDetailModels);
            LookUpEditHelper.SetGridBusinessPartner(colBP_CD, Common.LoginInfo.UserInfo.CompCode, false, true);
            gridView1.CellValueChanged += GridView1_CellValueChanged;
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colRETURN_QTY)
            {
                var model = gridView1.GetFocusedRow() as DlvResultDetailModel;
                var dlvQty = model.DLV_QTY ;
                var returnQty = model.RETURN_QTY;
                gridView1.SetFocusedRowCellValue(colCLOSE_QTY, dlvQty - returnQty);
            }
        }

        public override bool ExcelImportDataUpload(object uploadData)
        {
            try
            {
                List<BpSkbaDataExcelUploadModel> newModels = new List<BpSkbaDataExcelUploadModel>();
                foreach (var model in (List<SkbaDataExcelUploadModel>)uploadData)
                {
                    newModels.Add(new BpSkbaDataExcelUploadModel {
                        CLOSE_QTY = model.CLOSE_QTY,
                        COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        CUST_DOH_NO = model.CUST_DOH_NO,
                        ITEM_CD = model.ITEM_CD,
                        LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                        PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                        RETURN_QTY   = model.RETURN_QTY
                    });
                }
                _ciqDlvClosePocket.BpExcelUpload(newModels);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                return false;
            }

        }
    }
}

using BPack.CommonMes.Helpers;
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
    public partial class PurPackMain : StrapMainForm
    {
        private PurPackArgs _purPackArgs;
        private PurPackPocket _purPackPocket;
        private PurPackList _purPackList;
        private InvoiceList _invoiceList;
        private InvoiceInfo _invoiceInfo;
        

        public PurPackMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _purPackArgs = new PurPackArgs();
            _purPackPocket = new PurPackPocket();
            _purPackList = new PurPackList(_purPackArgs, _purPackPocket);
            _invoiceList = new InvoiceList(_purPackArgs, _purPackPocket);
            AddSubForm(this, _invoiceList, layoutControlGroup2);
            AddSubForm(this, _purPackList, layoutControlGroup3);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _purPackArgs,
                InitlistForm = _invoiceList,
                IsAutoDataRefreshOnShown = true,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, false, true, true, excelImport:true);
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
            LookUpEditHelper.SetSysCode(lepInvoiceStatus, "INVOICE_STATUS");
            _invoiceList.ModelSelectedEvent += InvoiceList_ModelSelectedEvent;
            this.SelectedSubFormChanged += PurPackMain_SelectedSubFormChanged;
            _purPackList.AddRefreshTargetSubForm(_purPackList);
        }

        private void PurPackMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            ChangeEnable();
        }

        private void InvoiceList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            var selectedModel = (InvoiceModel)e.SelectedModelArgsBase.SelectedModelBase;
            _purPackArgs.PurPackModelArgs.Select_Invoice_No = selectedModel.INVOICE_NO;
            _purPackArgs.PurPackModelArgs.Select_Invoice_Status = selectedModel.INVOICE_STATUS;
            _purPackList.DataRefresh(_purPackArgs);
            ChangeEnable();
        }

        private void ChangeEnable()
        {
            if (this.SelectedSubForm == _invoiceList)
            {
                if (_purPackArgs.PurPackModelArgs.Select_Invoice_Status != null 
                    && _purPackArgs.PurPackModelArgs.Select_Invoice_Status.Equals("DEPARTED"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: true, edit: true, delete: true, save: false, excelImport: true);
                    btnArrival.Enabled = true;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: true, edit: false, delete: false, save: false, excelImport: true);
                    btnArrival.Enabled = false;
                }
            }
            if (this.SelectedSubForm == _purPackList)
            {
                if (_purPackArgs.PurPackModelArgs.Select_Invoice_Status != null
                    && _purPackArgs.PurPackModelArgs.Select_Invoice_Status.Equals("DEPARTED"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: true, edit: true, delete: true, save: true, excelImport: true);
                    btnArrival.Enabled = true;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, delete: false, save: false, excelImport: true);
                    btnArrival.Enabled = false;
                }
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _purPackArgs.PurPackModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _purPackArgs.PurPackModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _purPackArgs.PurPackModelArgs.Select_Main_Item_Cd = txtInvoiceNo.EditValue?.ToString();
            _purPackArgs.PurPackModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _purPackArgs.PurPackModelArgs.Select_Main_Item_Gr_1 = strapTextEdit3.EditValue?.ToString();
            _purPackArgs.PurPackModelArgs.Select_Main_Invoice_Status = lepInvoiceStatus.EditValue?.ToString();
            _purPackArgs.PurPackModelArgs.Select_Main_Invoice_No = txtInvoiceNo.EditValue?.ToString();
            _purPackArgs.PurPackModelArgs.Select_Invoice_No = null;
            _purPackArgs.PurPackModelArgs.Select_Invoice_Status = null;
            btnArrival.Enabled = false;
            base.Refresh_From_ExecuteByRibbonButton();
        }
        //도착처리 버튼
        private void btnArrival_Click(object sender, EventArgs e)
        {

            InvoiceModel invoiceModel = _invoiceList.GetSelectedModel();
            InputArrivalDt inputArrivalDt = new InputArrivalDt();
            //if (StrapMessageBox.Show("A001", 97, MessageBoxButtons.YesNo) == DialogResult.Yes)
            if (inputArrivalDt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    invoiceModel.INVOICE_STATUS = "WAIT";
                    invoiceModel.ARRIVAL_DT = inputArrivalDt.ArrivalDt;
                    invoiceModel.ARRIVAL_DTTM = DateTime.Now;
                    invoiceModel.RowState = Common.Model.RowState.Modified;
                    _purPackPocket.SaveInvoiceModel(invoiceModel);
                    _invoiceList.DataRefresh(_purPackArgs);
                    _purPackList.DataClear(_purPackArgs);
                    StrapMessageBox.Show("A001", 18); //처리완료 되었습니다.
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }

        }

        protected override void ExcelImport_From_ExecuteByRibbonButton()
        {
            _invoiceInfo = new InvoiceInfo(_purPackArgs, _purPackPocket);
            _invoiceInfo.StartPosition = FormStartPosition.CenterParent;
            var rst = _invoiceInfo.ShowDialog();
            if (rst == DialogResult.OK)
            {
                _purPackList.DataRefresh(_purPackArgs);
                _purPackList.ExcelImport(_purPackArgs);
                _invoiceList.DataRefresh(_purPackArgs);
                _purPackList.DataClear(_purPackArgs);
            }
            
            //base.ExcelImport_From_ExecuteByRibbonButton();
        }
    }
}

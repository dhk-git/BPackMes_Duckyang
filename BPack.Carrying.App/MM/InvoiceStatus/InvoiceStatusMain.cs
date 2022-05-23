using BPack.CommonMes.Helpers;
using BPack.Pocket.App.MM.InvoiceStatus;
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

namespace BPack.Carrying.App.MM.InvoiceStatus
{
    public partial class InvoiceStatusMain : StrapMainForm
    {
        private InvoiceStatusArgs _invoiceStatusArgs;
        private InvoiceStatusPocket _invoiceStatusPocket;
        private InvoiceStatusHeaderList _invoiceStatusHeaderList;
        public InvoiceStatusMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _invoiceStatusArgs = new InvoiceStatusArgs();
            _invoiceStatusPocket = new InvoiceStatusPocket();
            _invoiceStatusHeaderList = new InvoiceStatusHeaderList(_invoiceStatusArgs, _invoiceStatusPocket);
            AddSubForm(this, _invoiceStatusHeaderList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _invoiceStatusArgs,
                InitlistForm = _invoiceStatusHeaderList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, isFirstSelect: true);

            strapDateEdit1.DateTime = DateTime.Now;
            strapDateEdit2.DateTime = DateTime.Now;
        }
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_Invoice_No = strapTextEdit1.EditValue?.ToString();
            _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_Item_Cd = strapTextEdit11.EditValue?.ToString();
            _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_Bp_Cd = strapTextEdit3.EditValue?.ToString();
            _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_Bp_Nm = strapTextEdit4.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

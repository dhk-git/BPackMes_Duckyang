using BPack.Common.Model;
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
    public partial class InvoiceList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurPackArgs _purPackArgs;
        private PurPackPocket _purPackPocket;

        public InvoiceList()
        {
            InitializeComponent();
        }

        public InvoiceList(PurPackArgs purPackArgs, PurPackPocket purPackPocket) : this()
        {
            this._purPackArgs = purPackArgs;
            this._purPackPocket = purPackPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = invoiceModelBindingSource,
                ExcelUploadModelType = typeof(PurPackExcelUploadModel),
                FormArgs = _purPackArgs,
                GridView = gridView1,
                InitModelType = typeof(InvoiceModel),
                ModelArgs = _purPackArgs.PurPackModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<PurPackModelArgs, InvoiceModel>(_purPackPocket.SelectInvoiceModels, _purPackPocket.SaveInvoiceModel);
            LookUpEditHelper.SetGridBusinessPartner(colBP_CD, Common.LoginInfo.UserInfo.CompCode, true, false);
        }


        internal InvoiceModel GetSelectedModel()
        {
            return invoiceModelBindingSource.Current as InvoiceModel;
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            var newModel = model as InvoiceModel;
            newModel.COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            newModel.INVOICE_STATUS = "DEPARTED";
            newModel.INVOICE_DT = DateTime.Now.Date;
            newModel.ETA_DT = DateTime.Now.Date.AddDays(70);
            base.SetInsertDefaultValue(model);
        }
    }
}

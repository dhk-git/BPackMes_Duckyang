using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.InvoiceStatus;
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
    public partial class InvoiceStatusHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private InvoiceStatusArgs _invoiceStatusArgs;
        private InvoiceStatusPocket _invoiceStatusPocket;

        public InvoiceStatusHeaderList()
        {
            InitializeComponent();
        }

        public InvoiceStatusHeaderList(InvoiceStatusArgs invoiceStatusArgs, InvoiceStatusPocket invoiceStatusPocket) :this()
        {
            this._invoiceStatusArgs = invoiceStatusArgs;
            this._invoiceStatusPocket = invoiceStatusPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = invoiceStatusHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _invoiceStatusArgs,
                GridView = gridView1,
                InitModelType = typeof(InvoiceStatusHeaderModel),
                ModelArgs = _invoiceStatusArgs.InvoiceStatusModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<InvoiceStatusModelArgs, InvoiceStatusHeaderModel>(_invoiceStatusPocket.SelectInvoiceStatusHeaderModels, null, null);
            colPAC_QTY.AppearanceCell.Font = new Font(colPAC_QTY.AppearanceCell.Font.Name, colPAC_QTY.AppearanceCell.Font.Size, FontStyle.Bold);
            colPAC_QTY.AppearanceCell.Options.UseFont = true;
            colINVOICE_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }
        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnSysCode(colBP_CD, "");
            LookUpEditHelper.SetGridColumnByQuery(colBP_CD, "MM.PurInbound.BpList", new
            {
                COMP_CD= _invoiceStatusArgs.InvoiceStatusModelArgs.Select_Main_Comp_Cd
            },"CODE","NAME");
            gridView1.BestFitColumns();
        }
    }
}


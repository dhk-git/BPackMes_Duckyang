using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Pocket.App.PO.PurPack;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors;
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
    public partial class InvoiceInfo : XtraForm
    {
        private PurPackArgs _purPackArgs;
        private PurPackPocket _purPackPocket;

        public InvoiceInfo()
        {
            InitializeComponent();
        }

        public InvoiceInfo(PurPackArgs purPackArgs, PurPackPocket purPackPocket) : this()
        {
            this._purPackArgs = purPackArgs;
            this._purPackPocket = purPackPocket;
            //레이블 언어변환
            labelControl1.Text = LanguagePack.GetTransWord(UserInfo.Sys_Language, labelControl1.Text) ?? labelControl1.Text;
            labelControl2.Text = LanguagePack.GetTransWord(UserInfo.Sys_Language, labelControl2.Text) ?? labelControl2.Text;
            labelControl3.Text = LanguagePack.GetTransWord(UserInfo.Sys_Language, labelControl3.Text) ?? labelControl3.Text;


            LookUpEditHelper.SetBusinessPartner(lupBpCd, Common.LoginInfo.UserInfo.CompCode, true, false, false, false, true);
            dteInvoiceDT.DateTime = DateTime.Now.Date;
            dteEtaDt.DateTime = dteInvoiceDT.DateTime.AddDays(70);
           
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lupBpCd.EditValue == null)
            {
                StrapMessageBox.Show("A001", 49); //필수 항목이 누락되었습니다.
                return;
            }
            if (dteInvoiceDT.DateTime == null || dteEtaDt.DateTime == null)
            {
                StrapMessageBox.Show("A001", 49); //필수 항목이 누락되었습니다.
                return;
            }
            _purPackArgs.PurPackModelArgs.ExcelImport_BpCd = lupBpCd.EditValue.ToString();
            _purPackArgs.PurPackModelArgs.ExcelImport_InvoiceDt = dteInvoiceDT.DateTime;
            _purPackArgs.PurPackModelArgs.ExcelImport_EtaDt = dteEtaDt.DateTime;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dteInvoiceDT_EditValueChanged(object sender, EventArgs e)
        {
            dteEtaDt.DateTime = dteInvoiceDT.DateTime.AddDays(70);
        }
    }
}

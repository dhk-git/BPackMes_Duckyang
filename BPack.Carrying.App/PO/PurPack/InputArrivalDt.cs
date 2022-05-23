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
    public partial class InputArrivalDt : XtraForm
    {
        public InputArrivalDt()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, "도착처리") ?? "도착처리";
            labelControl2.Text = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, "도착일자") ?? "도착일자";
            labelControl1.Text = StrapMessageBox.GetMessage("A001", 97);

            strapDateEdit1.DateTime = DateTime.Now.Date;
        }

        public DateTime ArrivalDt { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (strapDateEdit1.EditValue == null)
            {
                StrapMessageBox.Show("A001", 49); //필수 항목이 누락되었습니다.
                return;
            }
            ArrivalDt = strapDateEdit1.DateTime;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

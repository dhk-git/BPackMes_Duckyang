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
    public partial class SelectPurPackType : Form
    {
        public SelectPurPackType()
        {
            InitializeComponent();
            string trLangWord;
            trLangWord = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, this.Text);
            if (!string.IsNullOrEmpty(trLangWord))
            {
                this.Text = trLangWord;
            }
            trLangWord = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, simpleButton1.Text);
            if (!string.IsNullOrEmpty(trLangWord))
            {
                simpleButton1.Text = trLangWord;
            }
            trLangWord = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, simpleButton2.Text);
            if (!string.IsNullOrEmpty(trLangWord))
            {
                simpleButton2.Text = trLangWord;
            }
            trLangWord = Common.LoginInfo.LanguagePack.GetTransWord(Common.LoginInfo.UserInfo.Sys_Language, simpleButton3.Text);
            if (!string.IsNullOrEmpty(trLangWord))
            {
                simpleButton3.Text = trLangWord;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}

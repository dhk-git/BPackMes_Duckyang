using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Model.App.MD.OrgUser;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgUser;
using BPack.Common.Model;
using DevExpress.Utils.Extensions;
using DevExpress.PivotGrid.Criteria;
using DevExpress.CodeParser;
using DevExpress.Charts.Native;

namespace BPack.Carrying.App.MD.OrgUser
{
    public partial class PassWordChage : StrapMdiForm
    {
        private OrgUserArgs _orgUserArgs;
        private OrgUserPocket _orgUserPocket;
        private UserModel _userModel;
        private Char nullChar = '\0';

        public PassWordChage(OrgUserArgs orgUserArgs, OrgUserPocket orgUserPocket)
        {
            InitializeComponent();

            _orgUserArgs = orgUserArgs;
            _orgUserPocket = orgUserPocket;
        }

        public void DataRefresh(UserModel userModel)
        {
            _userModel = userModel;
            strapTextEdit1.Text = _userModel.USER_ID;
            strapTextEdit2.Text = _userModel.USER_NM;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(strapTextEdit3.Text) || String.IsNullOrWhiteSpace(strapTextEdit4.Text))
            {
                StrapMessageBox.Show("A001", 31, MessageBoxButtons.OK);
                return;
            }
            
            if (strapTextEdit3.Text != strapTextEdit4.Text)
            {
                StrapMessageBox.Show("A001", 32, MessageBoxButtons.OK);
                return;
            }

            if(StrapMessageBox.Show("A001", 30, MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                _userModel.USER_PW = strapTextEdit3.Text;
                _userModel.RowState = RowState.Modified;
                _orgUserPocket.SaveUserModel(_userModel);
                StrapMessageBox.Show("A001", 18, MessageBoxButtons.OK);

                strapTextEdit3 = null;
                strapTextEdit4 = null;

            }
            if (_userModel.RowState == RowState.Modified)
            {
                //_userModel.RowState = RowState.UnChanged;
                //_orgUserPocket.SaveUserModel(_userModel);
                this.Close();
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as DevExpress.XtraEditors.CheckEdit;
            if (checkBox.Checked)
            {
                strapTextEdit3.Properties.PasswordChar = nullChar;
                strapTextEdit4.Properties.PasswordChar = nullChar;
            }
            else
            {
                strapTextEdit3.Properties.PasswordChar = '*';
                strapTextEdit4.Properties.PasswordChar = '*';
            }
        }
    }
}

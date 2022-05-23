using BPack.Common.Pocket;
using BPack.Common.Model;
using BPack.Model.App.MD.OrgUser;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Strap.Grid;
using BPack.Pocket.App.MD.OrgUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.OrgUser
{
    public partial class OrgUserMain : StrapMainForm
    {
        private OrgUserList _orgUserList;
        private OrgUserArgs _orgUserArgs;
        private OrgUserPocket _orgUserPocket;
        private PassWordChage _passWordChange;

        
        public OrgUserMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _orgUserArgs = new OrgUserArgs();
            _orgUserPocket = new OrgUserPocket();
            //_orgDeptList = new OrgDeptList(_orgUserArgs, _orgUserPocket);
            _orgUserList = new OrgUserList(_orgUserArgs, _orgUserPocket);
            

            //_orgDeptList.ModelSelectedEvent += OrgDeptList_SelectedEvent;

            //this.SelectedSubFormChanged += OrgUserMain_SelectedSubFormChanged;

            //AddSubForm(this, _orgDeptList, layoutControlGroup2);
            AddSubForm(this, _orgUserList, layoutControlGroup3);
             
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _orgUserArgs,
                InitlistForm = _orgUserList,
                StrapLayout = strapLayout1
            });
            //InitRibbonButtons(true, true, true, true);

            //수정 권한 체크
            if(LoginMenuAuthModel.DUMMY1_AUTH != true)
            {
                InitRibbonButtons(false, false, false, false);
                MessageBox.Show("권한이 없습니다.");
            }
            else
            {
                InitRibbonButtons(true, true, true, true);
            }

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        } 

        protected override void Save_From_ExecuteByRibbonButton()
        {
            showPasswordChange();

            base.Save_From_ExecuteByRibbonButton();
        }

        /*protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }*/

        /*protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _orgUserArgs.orgUserModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }*/

        /*private void OrgDeptList_SelectedEvent(object sender, ArgsBase e)
        {
            
            _orgUserArgs.orgUserModelArgs.Select_Dept_Code = ((DeptModel)e.SelectedModelArgsBase.SelectedModelBase).DEPT_CD;

            _orgUserList.DataRefresh(_orgUserArgs);
        }*/

        /*private void OrgUserMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _orgDeptList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false);
            }
            if (this.SelectedSubForm == _orgUserList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true);
            }
        }*/

  
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _orgUserArgs.orgUserModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _orgUserArgs.orgUserModelArgs.Select_Main_Include_Del = checkEdit1.Checked ? "Y" : "N";
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void strapButton1_Click(object sender, EventArgs e)
        {
            
            if (LoginMenuAuthModel.DUMMY1_AUTH == true)
            {
                showPasswordChange();
            }
            else
            {
                MessageBox.Show("권한이 없습니다.");
            }
            //d_passWordChange.DataRefresh(_orgUserArgs);


            /*if (layoutControlGroup3.SelectedItems != null)
            {
                passWordChage.ShowDialog();
                passWordChage.Location = new Point(50, 50);
            }
            else
            {
                StrapMessageBox.Show("A001", 9);
                return;
            }*/
        }

        private void showPasswordChange()
        {
            if (_orgUserArgs.SelectedModelArgsBase.SelectedModelBase == null)
            {
                StrapMessageBox.Show("A001", 9, MessageBoxButtons.OK);
                return;
            }
            else
            {
                _passWordChange = new PassWordChage(_orgUserArgs, _orgUserPocket);
                _passWordChange.DataRefresh(_orgUserList.GetSelectedUserModel());
                _passWordChange.Height = _passWordChange.Height + 10;
                _passWordChange.ShowDialog();
            }
        }

    }
}

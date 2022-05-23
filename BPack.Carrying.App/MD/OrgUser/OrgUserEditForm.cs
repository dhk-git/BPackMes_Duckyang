using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Strap.FormControls;
using BPack.Model.App.MD.OrgUser;
using BPack.Strap.EditControls;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.OrgUser
{
    public partial class OrgUserEditForm : StrapEditForm
    {
        private UserModel _userModel;
        private OrgUserArgs _orgUserArgs;

        public OrgUserEditForm(OrgUserArgs orgUserArgs)
        {
            InitializeComponent();

            _orgUserArgs = orgUserArgs;

            InitBoundFieldName<UserModel>(dataLayoutControl1);
        }

        public void DataRefresh()
        {
            LookUpEditHelper.SetByQuery(DEPT_CDLookUpEdit, "DeptList", new { COMP_CD = _orgUserArgs.orgUserModelArgs.Select_Main_Comp_Code }, "CODE", "NAME");
        }

        public void DataRefresh(object datasource)
        {
            _userModel = (UserModel)datasource;
            userModelBindingSource.DataSource = _userModel;

            if (_userModel.RowState == Common.Model.RowState.UnChanged)
            {
                ItemForUSER_PW.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                ItemForUSER_PW.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
    }
}

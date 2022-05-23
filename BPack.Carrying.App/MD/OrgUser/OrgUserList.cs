using BPack.Common.Model;
using BPack.Model.App.MD.OrgUser;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgDept;
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
using DevExpress.XtraEditors;
using BPack.Strap.EditControls;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.OrgUser
{
    public partial class OrgUserList : StrapSubForm_OnlyOneGrid_V2
    {
        private OrgUserArgs _orgUserArgs;
        private OrgUserPocket _orgUserPocket;
        private OrgUserEditForm _orgUserEditForm;

        public OrgUserList(OrgUserArgs orgUserArgs, OrgUserPocket orgUserPocket)
        {
            InitializeComponent();

            _orgUserArgs = orgUserArgs;
            _orgUserPocket = orgUserPocket;
        }

        public override void InitStrap()
        {
            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = gridView1,
                BindingSource = userModelBindingSource,
                FormArgs = _orgUserArgs,
                ModelArgs = _orgUserArgs.orgUserModelArgs,
                InitModelType = typeof(UserModel)
            });
            InitPocketDelegate<OrgUserModelArgs, UserModel>(_orgUserPocket.SelectUserModels, _orgUserPocket.SaveUserModel);

            LookUpEditHelper.SetCompCode(colCOMP_CD);

            _orgUserEditForm = new OrgUserEditForm(_orgUserArgs);
            gridView1.OptionsEditForm.CustomEditFormLayout = _orgUserEditForm;
            gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            {
                _orgUserEditForm.DataRefresh(userModelBindingSource.Current);
            };
            colRECEIVE_MQTT_TOPIC.ToolTip = "TOPIC별로 \"/\" 로구분하여 등록";
            
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colDEPT_CD, "DeptList", new { COMP_CD = _orgUserArgs.orgUserModelArgs.Select_Main_Comp_Code }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colPLANT_CD, "PlantList", new { COMP_CD = _orgUserArgs.orgUserModelArgs.Select_Main_Comp_Code }, "CODE", "NAME");
            _orgUserEditForm.DataRefresh();

            base.DataRefresh(args);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);
            ((UserModel)model).COMP_CD = _orgUserArgs.orgUserModelArgs.Select_Main_Comp_Code;
            //((UserModel)model).DEPT_CD = _orgUserArgs.orgUserModelArgs.Select_Dept_Code;
            ((UserModel)model).PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
            ((UserModel)model).DEPT_CD = "D100" ;
            ((UserModel)model).DEL_FG = "N";
            ((UserModel)model).CREATE_DTTM = DateTime.Now;
            ((UserModel)model).MODIFY_DTTM = DateTime.Now;

        }

        public UserModel GetSelectedUserModel()
        {
            return (UserModel)strapGridControl1.SelectedModel;
        }
    }
}

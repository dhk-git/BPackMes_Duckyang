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
using BPack.Strap.EditControls;
using BPack.Model.App.MM.MovDoc;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MM.MovDoc
{
    public partial class MovDocEditForm : StrapEditForm
    {
        private MovDocArgs _movDocArgs;
        private MovDocModel _movDocModel;

        public MovDocEditForm(MovDocArgs movDocArgs)
        {
            InitializeComponent();
            _movDocArgs = movDocArgs;
            InitBoundFieldName<MovDocModel>(strapDataLayout1);
            LookUpEditHelper.SetSysCode(MOV_TYPE_CDLookUpEdit, "MOV_TYPE_CD", false);
            LookUpEditHelper.SetSysCode(MOV_STATUSLookUpEdit, "MOV_STATUS", false);
            LookUpEditHelper.SetByQuery(FROM_USER_IDLookUpEdit, "AllUsers", null, "", "");
            LookUpEditHelper.SetByQuery(TO_USER_IDLookUpEdit, "AllUsers", null, "", "");
            FROM_WH_CDLookUpEdit.EditValueChanged += FROM_WH_CDLookUpEdit_EditValueChanged;
            TO_WH_CDLookUpEdit.EditValueChanged += TO_WH_CDLookUpEdit_EditValueChanged;
        }

        public void InitStrap()
        {

        }

        private void TO_WH_CDLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            TO_WH_CDLookUpEdit.DataBindings[0]?.WriteValue();
            CommonMes.Helpers.LookUpEditHelper.SetLocation(TO_LOC_CDLookUpEdit, Common.LoginInfo.UserInfo.CompCode
              , _movDocArgs.Select_Extra_Plant_Cd, TO_WH_CDLookUpEdit.EditValue?.ToString(), isFirstSelect: true);
            TO_LOC_CDLookUpEdit.DataBindings[0]?.WriteValue();
            //TODO : 창고/위치 LOOKUPEDIT  선택시 문제 해결할 것!!!!!!! 20191127 해결했음 20200820

        }

        private void FROM_WH_CDLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            FROM_WH_CDLookUpEdit.DataBindings[0]?.WriteValue();
            CommonMes.Helpers.LookUpEditHelper.SetLocation(FROM_LOC_CDLookUpEdit, Common.LoginInfo.UserInfo.CompCode,
                _movDocArgs.Select_Extra_Plant_Cd, FROM_WH_CDLookUpEdit.EditValue?.ToString(), isFirstSelect:true);
            FROM_LOC_CDLookUpEdit.DataBindings[0]?.WriteValue();
        }

        public void RefreshWareHouseInfo()
        {
            CommonMes.Helpers.LookUpEditHelper.SetWareHouse(FROM_WH_CDLookUpEdit, Common.LoginInfo.UserInfo.CompCode, _movDocArgs.Select_Extra_Plant_Cd);
            CommonMes.Helpers.LookUpEditHelper.SetWareHouse(TO_WH_CDLookUpEdit, Common.LoginInfo.UserInfo.CompCode, _movDocArgs.Select_Extra_Plant_Cd);
        }
        public void DataRefresh(object datasource)
        {
            _movDocModel = datasource as MovDocModel;
            movDocModelBindingSource.DataSource = _movDocModel;
            movDocModelBindingSource.ResetBindings(false);
        }


    }
}

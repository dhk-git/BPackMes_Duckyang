using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Model.App.MM.MovDocConfirm;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.MovDocConfirm;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MM.MovDocConfirm
{
    public partial class MovDocList : StrapSubForm_OnlyOneGrid_V2
    {
        private MovDocConfirmArgs _movDocConfirmArgs;
        private MovDocConfirmPocket _movDocConfirmPocket;

        public MovDocList()
        {
            InitializeComponent();
        }

        public MovDocList(MovDocConfirmArgs movDocConfirmArgs, MovDocConfirmPocket movDocConfirmPocket) : this()
        {
            _movDocConfirmArgs = movDocConfirmArgs;
            _movDocConfirmPocket = movDocConfirmPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = movDocModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _movDocConfirmArgs,
                GridView = gridView1,
                InitModelType = typeof(MovDocModel),
                ModelArgs = _movDocConfirmArgs.MovDocConfirmModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<MovDocConfirmModelArgs, MovDocModel>(_movDocConfirmPocket.SelectMovDocModels, null);
            LookUpEditHelper.SetGridColumnSysCode(colMOV_STATUS, "MOV_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colMOV_TYPE_CD, "MOV_TYPE_CD");
        }

        public void MovDocConfirm()
        {
            try
            {
                var model = (MovDocModel)strapGridControl1.SelectedModel;
                model.MOV_STATUS = "S003";
                model.CLOSE_DTTM = DateTime.Now;
//                model.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                model.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
                _movDocConfirmPocket.BpMovDocConfirm(model);
                StrapMessageBox.Show("A001", 18);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

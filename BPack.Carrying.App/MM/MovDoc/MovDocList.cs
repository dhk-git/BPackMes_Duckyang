using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Common.Model;
using BPack.Model.App.MM.MovDoc;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.MovDoc;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MM.MovDoc
{
    public partial class MovDocList : StrapSubForm_OnlyOneGrid_V2
    {
        private MovDocArgs _movDocArgs;
        private MovDocPocket _movDocPocket;
        private MovDocEditForm _movDocEditForm;

        public MovDocList()
        {
            InitializeComponent();
        }

        public MovDocList(MovDocArgs movDocArgs, MovDocPocket movDocPocket) : this()
        {
            this._movDocArgs = movDocArgs;
            this._movDocPocket = movDocPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _movDocEditForm = new MovDocEditForm(_movDocArgs);
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = gridview1,
                BindingSource = movDocbindingSource,
                FormArgs = _movDocArgs,
                ModelArgs = _movDocArgs.MovDocModelArgs,
                InitModelType = typeof(MovDocModel)
            });
            InitPocketDelegate<MovDocModelArgs, MovDocModel>(_movDocPocket.SelectMovDocModels, _movDocPocket.SaveMovDocModel);
            //grvMovDoc.OptionsView.ColumnAutoWidth = true;
            gridview1.OptionsEditForm.CustomEditFormLayout = _movDocEditForm;
            //gridview1.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Cached;
            //gridview1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.
            gridview1.EditFormPrepared += GrvMovDoc_EditFormPrepared;
            LookUpEditHelper.SetGridColumnSysCode(colMOV_STATUS, "MOV_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colMOV_TYPE_CD, "MOV_TYPE_CD");

        }

        private void GrvMovDoc_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
        {
            _movDocEditForm.DataRefresh(movDocbindingSource.Current);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((MovDocModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((MovDocModel)model).PLANT_CD = _movDocArgs.Select_Extra_Plant_Cd;
            ((MovDocModel)model).MOV_STATUS = CommonMes.Enums.SysCode.MovStatus.TEMP_SAVE;
            ((MovDocModel)model).DEL_FG = "N";
            base.SetInsertDefaultValue(model);
        }
        public override void DataRefresh(ArgsBase args)
        {
            _movDocEditForm.RefreshWareHouseInfo();
            base.DataRefresh(args);
        }

        public void Publish()
        {
            var model = strapGridControl1.SelectedModel as MovDocModel;
            model.MOV_STATUS = CommonMes.Enums.SysCode.MovStatus.PUBLISH;
            model.PUBLISH_DTTM = DateTime.Now;
            model.RowState = RowState.Modified;
            _movDocPocket.SaveMovDocModel(model);
        }
    }
}

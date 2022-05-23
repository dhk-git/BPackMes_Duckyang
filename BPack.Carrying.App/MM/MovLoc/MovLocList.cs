using BPack.Common.Config;
using BPack.Common.LoginInfo;
using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.MovDoc;
using BPack.Model.App.MM.MovLoc;
using BPack.Pocket.App.MM.MovLoc;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.MovLoc
{
    public partial class MovLocList : StrapSubForm_OnlyOneGrid_V2
    {
        private MovLocArgs _movLocArgs;
        private MovLocPocket _movLocPocket;

        public MovLocList()
        {
            InitializeComponent();
        }
        public MovLocList(MovLocArgs movLocArgs, MovLocPocket movLocPocket) : this()
        {
            _movLocArgs = movLocArgs;
            _movLocPocket = movLocPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = movLocModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _movLocArgs,
                GridView = gridView1,
                InitModelType = typeof(MovLocModel),
                ModelArgs = _movLocArgs.MovLocModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<MovLocModelArgs, MovLocModel>(_movLocPocket.SelectHeaderModels, _movLocPocket.SaveModel, _movLocPocket.SaveModels);

        }
        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colFROM_WH_CD, "WareHouses",
                new
                {
                    COMP_CD = _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd,
                    PLANT_CD = _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd
                }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colTO_WH_CD, "WareHouses",
                new
                {
                    COMP_CD = _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd,
                    PLANT_CD = _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd
                }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnSysCode(colMOV_STATUS, "MOV_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colMOV_TYPE_CD, "MOV_TYPE_CD");
            base.DataRefresh(args);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((MovLocModel)model).COMP_CD = _movLocArgs.MovLocModelArgs.Select_Main_Comp_cd;
            ((MovLocModel)model).PLANT_CD = _movLocArgs.MovLocModelArgs.Select_Main_Plant_cd;
            ((MovLocModel)model).PUBLISH_DT = DateTime.Now;
            ((MovLocModel)model).MOV_STATUS = "WAIT";
            base.SetInsertDefaultValue(model);

        }


        internal MovLocModel GetSelectedModel()
        {
            return movLocModelBindingSource.Current as MovLocModel;
        }

        internal void MovLoc_Confirm(MovLocModel model)
        {
            MoveLocConfirmModel confrimModel = new MoveLocConfirmModel()
            {
                COMP_CD = model.COMP_CD,
                PLANT_CD = model.PLANT_CD,
                CREATE_DTTM = model.CREATE_DTTM,
                MODIFY_DTTM = model.MODIFY_DTTM,
                CREATE_USER_ID = UserInfo.UserID,
                MODIFY_USER_ID = UserInfo.UserID,
                LANG_CODE = UserInfo.Sys_Language,
                MOV_NO_KEY = model.MOV_NO_KEY
            };

            _movLocPocket.SaveInOuptModelConfirm(confrimModel);
        }
    }
}

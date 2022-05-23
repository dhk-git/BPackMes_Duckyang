using BPack.Common.Model;
using BPack.Model.App.PC.WoeResult;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WoeResult;
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

namespace BPack.Carrying.App.PC.WoeResult
{
    public partial class WoeWorkResultList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultArgs _woeResultArgs;
        private WoeResultPocket _woeResultPocket;

        public WoeWorkResultList()
        {
            InitializeComponent();
        }

        public WoeWorkResultList(WoeResultArgs woeResultArgs, WoeResultPocket woeResultPocket) : this()
        {
            _woeResultArgs = woeResultArgs;
            _woeResultPocket = woeResultPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = woeWorkResultModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultArgs,
                GridView = gridView1,
                InitModelType = typeof(WoeWorkResultModel),
                ModelArgs = _woeResultArgs.WoeResultModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeResultModelArgs, WoeWorkResultModel>(_woeResultPocket.SelectWoeWorkResultModels, _woeResultPocket.SaveWoeWorkResultModel);

            LookUpEditHelper.SetGridColumnSysCode(colRST_STATUS, "RST_STATUS");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((WoeWorkResultModel)model).WO_NO = _woeResultArgs.WoeResultModelArgs.Select_Wo_No;
            ((WoeWorkResultModel)model).ROUTE_NO = _woeResultArgs.WoeResultModelArgs.Select_Route_No;
            ((WoeWorkResultModel)model).OPER = _woeResultArgs.WoeResultModelArgs.Select_Oper;
            ((WoeWorkResultModel)model).DEL_FG = "N";
            ((WoeWorkResultModel)model).RST_STATUS = "RUN";
            base.SetInsertDefaultValue(model);
        }

        internal void BpCloseWorkResult()
        {
            if (StrapMessageBox.Show("A001", 27, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Common.Config.SystemConfig.RefreshServerDateTime();
                WoeWorkResultCloseModel woeWorkResultCloseModel = new WoeWorkResultCloseModel()
                {
                    COMP_CD = _woeResultArgs.WoeResultModelArgs.Select_Comp_Cd,
                    CREATE_DTTM = Common.Config.SystemConfig.ServerDateTime,
                    CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    GD_LOC_CD = _woeResultArgs.WoeResultModelArgs.Select_Gd_Loc_Cd,
                    GD_WH_CD = _woeResultArgs.WoeResultModelArgs.Select_Gd_Wh_Cd,
                    MAT_LOC_CD = _woeResultArgs.WoeResultModelArgs.Select_Mat_Loc_Cd,
                    MAT_WH_CD = _woeResultArgs.WoeResultModelArgs.Select_Mat_Wh_Cd,
                    MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime,
                    MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    PLANT_CD = _woeResultArgs.WoeResultModelArgs.Select_Main_Plant_Cd,
                    RST_HU_TYPE = _woeResultArgs.WoeResultModelArgs.Select_Rst_Hu_Type,
                    RST_NO = _woeResultArgs.WoeResultModelArgs.Select_Rst_No,
                    LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
                    

                };
                _woeResultPocket.BpCloseWorkResult(woeWorkResultCloseModel);
            };
        }
    }
}

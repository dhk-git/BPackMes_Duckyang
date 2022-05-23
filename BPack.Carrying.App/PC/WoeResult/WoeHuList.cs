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
using BPack.Common.Config;
using BPack.Common.LoginInfo;

namespace BPack.Carrying.App.PC.WoeResult
{
    public partial class WoeHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultArgs _woeResultArgs;
        private WoeResultPocket _woeResultPocket;

        public WoeHuList()
        {
            InitializeComponent();
        }

        public WoeHuList(WoeResultArgs woeResultArgs, WoeResultPocket woeResultPocket) : this()
        {
            _woeResultArgs = woeResultArgs;
            _woeResultPocket = woeResultPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = woeHuModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultArgs,
                GridView = gridView1,
                InitModelType = typeof(WoeHuModel),
                ModelArgs = _woeResultArgs.WoeResultModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeResultModelArgs, WoeHuModel>(_woeResultPocket.SelectWoeHuModels, _woeResultPocket.SaveWoeHuModel);
            LookUpEditHelper.SetGridColumnSysCode(colOK_NG, "OK_NG");
        }

        internal void AddHuAndReg()
        {
            if (StrapMessageBox.Show("A001", 22, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SystemConfig.RefreshServerDateTime();
                    WoeAddHuBpModel woeAddHuBpModel = new WoeAddHuBpModel
                    {
                        COMP_CD = _woeResultArgs.WoeResultModelArgs.Select_Comp_Cd,
                        PLANT_CD = _woeResultArgs.WoeResultModelArgs.Select_Main_Plant_Cd,
                        ITEM_CD = _woeResultArgs.WoeResultModelArgs.Select_Item_Cd,
                        OK_NG = _woeResultArgs.Ok_Ng,
                        RST_NO = _woeResultArgs.WoeResultModelArgs.Select_Rst_No,
                        HU_QTY = _woeResultArgs.HuQty,
                        WORK_DT = SystemConfig.ServerDateTime.Date,
                        HU_TYPE = "SER",
                        RowState = Common.Model.RowState.Added,
                        LANG_CODE = UserInfo.Sys_Language,
                        CREATE_DTTM = SystemConfig.ServerDateTime,
                        MODIFY_DTTM = SystemConfig.ServerDateTime,
                        CREATE_USER_ID = UserInfo.UserID,
                        MODIFY_USER_ID = UserInfo.UserID,
                        WO_NO = _woeResultArgs.WoeResultModelArgs.Select_Wo_No,
                        OPER = _woeResultArgs.WoeResultModelArgs.Select_Oper
                    };
                    _woeResultPocket.BpAddWoeHuModel(woeAddHuBpModel);
                    DataRefresh(_woeResultArgs);
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(ex.Message);
                }

            };
        }
    }
}

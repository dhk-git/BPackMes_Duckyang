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
    public partial class WoeParentHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private WoeResultArgs _woeResultArgs;
        private WoeResultPocket _woeResultPocket;

        public WoeParentHuList()
        {
            InitializeComponent();
        }

        public WoeParentHuList(WoeResultArgs woeResultArgs, WoeResultPocket woeResultPocket) : this()
        {
            _woeResultArgs = woeResultArgs;
            _woeResultPocket = woeResultPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = woeParentHuModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _woeResultArgs,
                GridView = gridView1,
                InitModelType = typeof(WoeParentHuModel),
                ModelArgs = _woeResultArgs.WoeResultModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WoeResultModelArgs, WoeParentHuModel>(_woeResultPocket.SelectWoeParentHuModels, _woeResultPocket.SaveWoeParentHuModel);
            LookUpEditHelper.SetGridColumnSysCode(colOK_NG, "OK_NG");
        }

        internal void BpAddWoeParentHuByAll()
        {
            if (StrapMessageBox.Show("A001", 25, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    WoeAddParentHuBpModel woeAddParentHuBpModel = new WoeAddParentHuBpModel() {
                        COMP_CD = _woeResultArgs.WoeResultModelArgs.Select_Comp_Cd,
                        PLANT_CD = _woeResultArgs.WoeResultModelArgs.Select_Main_Plant_Cd,
                        ITEM_CD = _woeResultArgs.WoeResultModelArgs.Select_Item_Cd,
                        RST_NO = _woeResultArgs.WoeResultModelArgs.Select_Rst_No,
                        WORK_DT = DateTime.Now.Date,
                        OK_NG = "OK",
                        RowState = Common.Model.RowState.Added,
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
                    };
                    _woeResultPocket.BpAddWoeParentHuByAll(woeAddParentHuBpModel);
                    DataRefresh(_woeResultArgs);
                }
                catch (Exception ex)
                {

                    StrapMessageBox.Show(ex.Message);
                }
            };
        }

        internal void BpAddWoeParentHuByDivideOkNg()
        {
            if (StrapMessageBox.Show("A001", 26, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    WoeAddParentHuBpModel woeAddParentHuBpModel = new WoeAddParentHuBpModel()
                    {
                        COMP_CD = _woeResultArgs.WoeResultModelArgs.Select_Comp_Cd,
                        PLANT_CD = _woeResultArgs.WoeResultModelArgs.Select_Main_Plant_Cd,
                        ITEM_CD = _woeResultArgs.WoeResultModelArgs.Select_Item_Cd,
                        RST_NO = _woeResultArgs.WoeResultModelArgs.Select_Rst_No,
                        WORK_DT = DateTime.Now.Date,
                        RowState = Common.Model.RowState.Added,
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
                    };
                    _woeResultPocket.BpAddWoeParentHuByDivideOkNg(woeAddParentHuBpModel);
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

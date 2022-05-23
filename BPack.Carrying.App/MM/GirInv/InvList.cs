using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.GirInv;
using BPack.Pocket.App.MM.GirInv;
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

namespace BPack.Carrying.App.MM.GirInv
{
    public partial class InvList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirInvArgs _girInvArgs;
        private GirInvPocket _girInvPocket;

        public InvList()
        {
            InitializeComponent();
        }

        public InvList(GirInvArgs girInvArgs, GirInvPocket girInvPocket) : this()
        {
            this._girInvArgs = girInvArgs;
            this._girInvPocket = girInvPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = bindingSource1,
                ExcelUploadModelType = null,
                FormArgs = _girInvArgs,
                GridView = gridView1,
                InitModelType = typeof(InvModel),
                ModelArgs = _girInvArgs.GirInvModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirInvModelArgs, InvModel>(_girInvPocket.SelectInvModels, _girInvPocket.SaveInvModel);
            LookUpEditHelper.SetWareHouse(colWH_CD, Common.LoginInfo.UserInfo.CompCode, Common.LoginInfo.UserInfo.PlantCode);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            InvModel invModel = (InvModel)model;
            invModel.COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            invModel.PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
            invModel.INV_GIR_DT = CommonMes.Config.GlobalSettings.GetWorkDt();
            invModel.IS_INCLUDE_AFTER_GIR = "N";
            invModel.INV_STATUS = "WAIT";

            base.SetInsertDefaultValue(model);
        }

        //public void OpenInv()
        //{
        //    //var selectedModel = bindingSource1.Current as InvModel;
        //    //selectedModel.INV_STATUS = "OPEN";
        //    //selectedModel.RowState = RowState.Modified;
        //    //selectedModel.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
        //    _girInvPocket.BpOpenInv(_girInvArgs.GirInvModelArgs);
        //    DataRefresh(_girInvArgs);
        //}
    }
}

using BPack.Common.Model;
using BPack.Model.App.MM.InvOrder;
using BPack.Pocket.App.MM.InvOrder;
using BPack.Strap.EditControls;
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

namespace BPack.Carrying.App.MM.InvOrder
{
    public partial class InvDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private InvOrderArgs _invOrderArgs;
        private InvOrderPocket _invOrderPocket;
        private LookUpEditPocket _lep;
        public InvDetailList()
        {
            InitializeComponent();
        }

        public InvDetailList(InvOrderArgs invOrderArgs, InvOrderPocket invOrderPocket) : this()
        {
            this._invOrderArgs = invOrderArgs;
            this._invOrderPocket = invOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _lep = LookUpEditPocket.GetInstance();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = invDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _invOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(InvDetailModel),
                ModelArgs = _invOrderArgs.InvOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<InvOrderModelArgs, InvDetailModel>(_invOrderPocket.SelectInvDetailModels, _invOrderPocket.SaveInvDetailModel, null);
            _lep.SetGridColumnSysCode(colINV_GR, "INV_GR");
            _lep.SetGridColumnSysCode(colINVD_STATUS, "INVD_STATUS");
        }
        public override void DataRefresh(ArgsBase args)
        {
            CommonMes.Helpers.LookUpEditHelper.SetWareHouse(colWH_CD, Common.LoginInfo.UserInfo.CompCode, _invOrderArgs.InvOrderModelArgs.Select_Main_Plant_Cd);
            CommonMes.Helpers.LookUpEditHelper.SetLocation(colLOC_CD, Common.LoginInfo.UserInfo.CompCode, _invOrderArgs.InvOrderModelArgs.Select_Main_Plant_Cd, _invOrderArgs.InvOrderModelArgs.Select_Target_Wh_Cd);
            base.DataRefresh(args);
        }
        public override void AddNew(ArgsBase args)
        {
            if (!_invOrderArgs.InvOrderModelArgs.Select_Inv_Type.Equals("PARTIAL"))
            {
                StrapMessageBox.Show("부분실사에서만 등록가능합니다.");
                return;
            }
            if (!_invOrderArgs.InvOrderModelArgs.Select_Inv_Status.Equals("WAIT"))
            {
                StrapMessageBox.Show("실사지시가 대기상태에서만 등록가능합니다.");
                return;
            }
            base.AddNew(args);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            Common.Config.SystemConfig.RefreshServerDateTime();
            ((InvDetailModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((InvDetailModel)model).PLANT_CD = _invOrderArgs.InvOrderModelArgs.Select_Main_Plant_Cd;
            ((InvDetailModel)model).INV_NO = _invOrderArgs.InvOrderModelArgs.Select_Inv_No;
            ((InvDetailModel)model).WH_CD = _invOrderArgs.InvOrderModelArgs.Select_Target_Wh_Cd;
            ((InvDetailModel)model).INV_GR = _invOrderArgs.InvOrderModelArgs.Select_Main_Target_Inv_Gr;
            ((InvDetailModel)model).INVD_STATUS = "WAIT";
            ((InvDetailModel)model).START_DTTM = Common.Config.SystemConfig.ServerDateTime;
            ((InvDetailModel)model).DEL_FG = "N";
            base.SetInsertDefaultValue(model);
        }
    }
}

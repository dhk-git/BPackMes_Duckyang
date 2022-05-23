using BPack.Common.Model;
using BPack.CommonMes.Helpers;
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
    public partial class InvOrderList : StrapSubForm_OnlyOneGrid_V2
    {
        private InvOrderArgs _invOrderArgs;
        private InvOrderPocket _invOrderPocket;
        private LookUpEditPocket _lep;

        public InvOrderList()
        {
            InitializeComponent();
        }

        public InvOrderList(InvOrderArgs invOrderArgs, InvOrderPocket invOrderPocket) : this()
        {
            this._invOrderArgs = invOrderArgs;
            this._invOrderPocket = invOrderPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _lep = LookUpEditPocket.GetInstance();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid {
                BindingSource = invOrderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _invOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(InvOrderModel),
                ModelArgs = _invOrderArgs.InvOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<InvOrderModelArgs, InvOrderModel>(_invOrderPocket.SelectInvOrderModels, _invOrderPocket.SaveInvOrderModel, null);
            _lep.SetGridColumnSysCode(colINV_STATUS, "INV_STATUS");
            _lep.SetGridColumnSysCode(colINV_TYPE, "INV_TYPE");
            _lep.SetGridColumnSysCode(colTARGET_INV_GR, "INV_GR");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            Common.Config.SystemConfig.RefreshServerDateTime();
            var currentDttm = Common.Config.SystemConfig.ServerDateTime;
            ((InvOrderModel)model).ORDER_DTTM = currentDttm;
            ((InvOrderModel)model).INV_STATUS = "WAIT";
            ((InvOrderModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((InvOrderModel)model).PLANT_CD = _invOrderArgs.InvOrderModelArgs.Select_Main_Plant_Cd;
            ((InvOrderModel)model).TARGET_INV_GR = _invOrderArgs.InvOrderModelArgs.Select_Main_Target_Inv_Gr;
            ((InvOrderModel)model).TARGET_GIR_DT = currentDttm;
            ((InvOrderModel)model).DEL_FG = "N";
            ((InvOrderModel)model).INV_TYPE = "TOTAL";
            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetWareHouse(colTARGET_WH_CD, Common.LoginInfo.UserInfo.CompCode, _invOrderArgs.InvOrderModelArgs.Select_Main_Plant_Cd);
            base.DataRefresh(args);
        }

        public void DropSelectedInvOrder()
        {
            var selectedInvOrderNo = ((InvOrderModel)invOrderModelBindingSource.Current).INV_NO_KEY;
            _invOrderPocket.DropInvOrderModel(selectedInvOrderNo);
        }

        internal void OpenSelectedInvOrder()
        {
            var selectedInvOrderNo = ((InvOrderModel)invOrderModelBindingSource.Current).INV_NO_KEY;
            _invOrderPocket.OpenInvOrderModel(selectedInvOrderNo);
        }
    }
}

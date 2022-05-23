using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PO.PurOrder;
using BPack.Pocket.App.PO.PurOrder;
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

namespace BPack.Carrying.App.PO.PurOrder
{
    public partial class PurOrderList : StrapSubForm_OnlyOneGrid_V2
    {
        private PurOrderArgs _purOrderArgs;
        private PurOrderPocket _purOrderPocket;

        public PurOrderList()
        {
            InitializeComponent();
        }

        public PurOrderList(PurOrderArgs purOrderArgs, PurOrderPocket purOrderPocket) : this()
        {
            this._purOrderArgs = purOrderArgs;
            this._purOrderPocket = purOrderPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = purOrderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _purOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(PurOrderModel),
                ModelArgs = _purOrderArgs.PurOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<PurOrderModelArgs, PurOrderModel>(_purOrderPocket.SelectPurOrderModels, _purOrderPocket.SavePurOrderModel);

            LookUpEditHelper.SetGridBusinessPartner(colBP_CD, Common.LoginInfo.UserInfo.CompCode, true, false);
            LookUpEditHelper.SetGridColumnSysCode(colPOH_STATUS, "POH_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colPOH_INTER_CLS, "POH_INTER_CLS");
            LookUpEditHelper.SetGridColumnSysCode(colPOH_CREATE_CLS, "POH_CREATE_CLS");

        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((PurOrderModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((PurOrderModel)model).POH_DT = DateTime.Now.Date;
            ((PurOrderModel)model).POH_STATUS = "WAIT";
            if (string.IsNullOrEmpty(_purOrderArgs.PurOrderModelArgs.Select_Main_Poh_Inter_Cls))
            {
                ((PurOrderModel)model).POH_INTER_CLS = "IMPORT";
            }
            else
            {
                ((PurOrderModel)model).POH_INTER_CLS = _purOrderArgs.PurOrderModelArgs.Select_Main_Poh_Inter_Cls;
            }
            ((PurOrderModel)model).POH_CREATE_CLS = "NORMAL";
            ((PurOrderModel)model).DVL_PLACE = "TEMP";
            ((PurOrderModel)model).DEL_FG = "N";
            base.SetInsertDefaultValue(model);
        }

        internal string CheckConfirmOrder()
        {
            string returnMsg = "";
            if (string.IsNullOrEmpty(_purOrderArgs.PurOrderModelArgs.Select_Poh_No))
            {
                returnMsg = StrapMessageBox.GetMessage("A001", 61);
                return returnMsg;
            }
            if (_purOrderArgs.PurOrderModelArgs.Select_Poh_Status.Equals("CLOSE"))
            {
                returnMsg = StrapMessageBox.GetMessage("A002", 3);
                return returnMsg;
            }
            return returnMsg;
        }

    }
}

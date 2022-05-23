using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.SalesOrder;
using BPack.Pocket.App.SD.SalesOrder;
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

namespace BPack.Carrying.App.SD.SalesOrder
{
    public partial class SalesOrderList : StrapSubForm_OnlyOneGrid_V2
    {
        private SalesOrderArgs _salesOrderArgs;
        private SalesOrderPocket _salesOrderPocket;

        public SalesOrderList()
        {
            InitializeComponent();
        }

        public SalesOrderList(SalesOrderArgs salesOrderArgs, SalesOrderPocket salesOrderPocket) : this()
        {
            this._salesOrderArgs = salesOrderArgs;
            this._salesOrderPocket = salesOrderPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = salesOrderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _salesOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(SalesOrderModel),
                ModelArgs = _salesOrderArgs.SalesOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<SalesOrderModelArgs, SalesOrderModel>(_salesOrderPocket.SelectSalesOrderModels, _salesOrderPocket.SaveSalesOrderModel);
            LookUpEditHelper.SetGridColumnByQuery(colBP_CD, "BusinessPartner_IsPur_Sales", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                IS_PURCHASE = "0",
                IS_SALES = "1"
            }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnSysCode(colSOR_STATUS, "SOR_STATUS");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((SalesOrderModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((SalesOrderModel)model).SOR_DT = DateTime.Now.Date;
            ((SalesOrderModel)model).SOR_STATUS = "WAIT";
            ((SalesOrderModel)model).SOR_CLOSE_DTTM = null;
            base.SetInsertDefaultValue(model);
        }

        public string ValidateConfirmSalesOrder()
        {
            string msg = "";
            if (strapGridControl1.SelectedModel == null)
            {
                msg = "Select Row";
                return msg;
            }
            if (((SalesOrderModel)strapGridControl1.SelectedModel).SOR_STATUS.Equals("CLOSE"))
            {
                msg = StrapMessageBox.GetMessage("A002", 3);//이미 확정된 주문서 입니다.
                return msg;
            }
            return msg;
        }
    }
}

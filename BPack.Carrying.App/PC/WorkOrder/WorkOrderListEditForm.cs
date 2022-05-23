using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WorkOrder;
using BPack.Pocket.App.PC.WorkOrder;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using System.Collections.Generic;

namespace BPack.Carrying.App.PC.WorkOrder
{
    public partial class WorkOrderListEditForm : StrapEditForm
    {
        private WorkOrderModel _WorkOrderModel;
        private WorkOrderArgs _WorkOrderArgs;
        private WorkOrderPocket _WorkOrderPocket;
        
        public WorkOrderListEditForm(WorkOrderArgs workOrderArgs, WorkOrderPocket workOrderPocket)
        {
            InitializeComponent();

            _WorkOrderArgs = workOrderArgs;
            _WorkOrderPocket = workOrderPocket;

            InitBoundFieldName<WorkOrderModel>(strapDataLayout1);

            LookUpEditHelper.SetByQuery(this.SHIFT_CDLookUpEdit, "ShiftList", null, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnSysCode(colMAT_INPUT_TYPE, "MAT_INPUT_TYPE");
        }

        public void DataRefresh(object datasource)
        {
            _WorkOrderModel = (WorkOrderModel)datasource;
            bsWorkOrder.DataSource = _WorkOrderModel;

            LookUpEditHelper.SetByQuery(this.ITEM_CDLookUpEdit, "ItemList"
                            , new { COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.CompCd, PLANT_CD = _WorkOrderArgs.WorkOrderModelArgs.PlantCd, ITEM_TYPE = string.Empty  }
                            , new Dictionary<string, string>() { { "CODE", "품목코드" }, { "NAME", "품목명" } }
                            ,"CODE", "CODE");
        }

        private void ROUTE_NOLookUpEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            if (ROUTE_NOLookUpEdit.Text != (this.ROUTE_NOLookUpEdit.EditValue == null? string.Empty : this.ROUTE_NOLookUpEdit.EditValue.ToString()))
                return;

            _WorkOrderArgs.WorkOrderModelArgs.Select_RouteNo = this.ROUTE_NOLookUpEdit.EditValue == null ? string.Empty : this.ROUTE_NOLookUpEdit.EditValue.ToString();

            if (ROUTE_NOLookUpEdit.EditValue != null && ROUTE_NOLookUpEdit.EditValue.ToString() != string.Empty)
            {
                this.VALID_FROM_DTDateEdit.EditValue = this.ROUTE_NOLookUpEdit.GetColumnValue("VALID_FROM_DT");
                this.VALID_TO_DTDateEdit.EditValue = this.ROUTE_NOLookUpEdit.GetColumnValue("VALID_TO_DT");
                this.BOM_BASE_QTYTextEdit.EditValue = this.ROUTE_NOLookUpEdit.GetColumnValue("BOM_BASE_QTY");
                this.BOM_BASE_UNITTextEdit.EditValue = this.ROUTE_NOLookUpEdit.GetColumnValue("BOM_BASE_UNIT");

                bsRouteMtrl.DataSource = _WorkOrderPocket.SelectRouteMtrlModels(_WorkOrderArgs.WorkOrderModelArgs);
                bsRouteMtrl.ResetBindings(false);
                gvRouteMtrl.BestFitColumns();
            }
            else
            {
                this.VALID_FROM_DTDateEdit.EditValue = null;
                this.VALID_TO_DTDateEdit.EditValue = null;
                this.BOM_BASE_QTYTextEdit.EditValue = null;
                this.BOM_BASE_UNITTextEdit.EditValue = null;

                bsRouteMtrl.DataSource = null;
            }
        }

        private void ITEM_CDLookUpEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            _WorkOrderArgs.WorkOrderModelArgs.Select_ItemCd = this.ITEM_CDLookUpEdit.EditValue == null ? string.Empty : this.ITEM_CDLookUpEdit.EditValue.ToString();

            LookUpEditHelper.SetByQuery(ROUTE_NOLookUpEdit, "RouteList"
                            , new { COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.CompCd, PLANT_CD = _WorkOrderArgs.WorkOrderModelArgs.PlantCd, ITEM_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_ItemCd}
                            , new Dictionary<string, string>() { { "ROUTE_NO", "ROUTE_NO" }, { "VALID_FROM_DT", "유효기간시작일" }, { "VALID_TO_DT", "유효기간종료일" }, { "BOM_BASE_QTY", "라우팅기준수량" }, { "BOM_BASE_UNIT", "라우팅기준단위" } }
                            , "ROUTE_NO", "ROUTE_NO");
            if(this.ITEM_CDLookUpEdit.EditValue != null && this.ITEM_CDLookUpEdit.EditValue.ToString() == ((WorkOrderModel)bsWorkOrder.Current).ITEM_CD)
                this.ROUTE_NOLookUpEdit.EditValue = ((WorkOrderModel)bsWorkOrder.Current).ROUTE_NO;
            else
                this.ROUTE_NOLookUpEdit.EditValue = null;

            this.ITEM_NMTextEdit.EditValue = this.ITEM_CDLookUpEdit.GetColumnValue("NAME");
        }
    }
}

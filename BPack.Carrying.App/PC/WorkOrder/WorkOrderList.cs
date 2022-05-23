using BPack.Common.Model;
using BPack.Model.App.PC.WorkOrder;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WorkOrder;
using BPack.CommonMes.Helpers;
using System;
using System.Collections.Generic;

namespace BPack.Carrying.App.PC.WorkOrder
{
    public partial class WorkOrderList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorkOrderArgs _WorkOrderArgs;
        private WorkOrderPocket _WorkOrderPocket;
        private WorkOrderEditForm _workOrderEditForm;
        int _WorkOrderEditFormWidth;

        public WorkOrderList(WorkOrderArgs WorkOrderArgs, WorkOrderPocket WorkOrderPocket)
        {
            InitializeComponent();

            _WorkOrderArgs = WorkOrderArgs;
            _WorkOrderPocket = WorkOrderPocket;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = bsList,
                FormArgs = _WorkOrderArgs,
                ModelArgs = _WorkOrderArgs.WorkOrderModelArgs,
                InitModelType = typeof(WorkOrderModel),
                GridView = gridView1
            });
            InitPocketDelegate<WorkOrderModelArgs, WorkOrderModel>(_WorkOrderPocket.SelectWorkOrderModels, _WorkOrderPocket.SaveWorkOrderModel);

            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            //LookUpEditHelper.SetGridColumnSysCode(colWO_STATUS, "WO_STATUS");
            //LookUpEditHelper.SetGridColumnByQuery(colSHIFT_CD, "ShiftList", null, "근무조코드", "근무조명");




            _workOrderEditForm = new WorkOrderEditForm(_WorkOrderArgs, _WorkOrderPocket);
            _WorkOrderEditFormWidth = _workOrderEditForm.Width;

            gridView1.OptionsEditForm.CustomEditFormLayout = _workOrderEditForm;
            gridView1.EditFormPrepared += (object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e) =>
            {
                _workOrderEditForm.DataRefresh(bsList.Current);
                e.Panel.Parent.Width = _WorkOrderEditFormWidth + 113;
            };


        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {

            ((WorkOrderModel)model).COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code;
            ((WorkOrderModel)model).PLANT_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code;
            ((WorkOrderModel)model).WO_DT = _WorkOrderArgs.WorkOrderModelArgs.START_DT;
            ((WorkOrderModel)model).ORDER_TYPE = "NP";
            ((WorkOrderModel)model).LOT_SIZE = 1;

            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetWorkCenter(
                colWC_CD
                , _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code
                , _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
                );

            LookUpEditHelper.SetGridColumnSysCode(colORDER_STATUS, "ORDER_STATUS");
            LookUpEditHelper.SetGridColumnSysCode(colORDER_TYPE, "ORDER_TYPE");



            LookUpEditHelper.SetGridColumnByQuery(
            colSHIFT_GROUP_CD,
            "MD.SHIH.Select",
            new
            {
                COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code,
                PLANT_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
            }
            , "근무조그룹"
            , "근무조그룹명");

            LookUpEditHelper.SetGridColumnByQuery(
           colSHIFT_CD,
           "MD.SHID.SelectALL",
           new
           {
               COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code,
               PLANT_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
           }
           , "근무조"
           , "근무조명");

            //자재창고
            LookUpEditHelper.SetGridColumnByQuery(
           colMAT_WH_CD,
           "WareHouses_Raw",
           new
           {
               COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code,
               PLANT_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
           }
           , "창고"
           , "창고명");

            //제품창고
            LookUpEditHelper.SetGridColumnByQuery(
           colGD_WH_CD,
           "WareHouses_FinalGoods",
           new
           {
               COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code,
               PLANT_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
           }
           , "창고"
           , "창고명");

            gridView1.BestFitColumns();

        }

        public List<WorkOrderModel> GetCheckedData()
        {
            List<WorkOrderModel> Models = new List<WorkOrderModel>();
            var selectedRowHandlers = gridView1.GetSelectedRows();
            foreach (var selectedRowHandler in selectedRowHandlers)
            {
                Models.Add(gridView1.GetRow(selectedRowHandler) as WorkOrderModel);
            }
            //checkedBarcodeModels = gridView1.GetSelectedRows();
            return Models;
        }


        internal void UpdateStatus_Confirm(List<WorkOrderModel> datas)
        {
            foreach (WorkOrderModel model in datas)
            {
                _WorkOrderPocket.SaveWorkOrderStatus(model, "C");
            }
        }
        internal void UpdateStatus_Wait(List<WorkOrderModel> datas)
        {
            foreach (WorkOrderModel model in datas)
            {
                _WorkOrderPocket.SaveWorkOrderStatus(model, "W");
            }
        }
    }
}

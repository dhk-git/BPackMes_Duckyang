using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WorkOrder;
using BPack.Pocket.App.PC.WorkOrder;
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

namespace BPack.Carrying.App.PC.WorkOrder
{
    public partial class WorkBomTreeList : StrapSubForm_TreeList
    {
        private WorkOrderArgs _WorkOrderArgs;
        private WorkOrderPocket _WorkOrderPocket;

        public WorkBomTreeList(WorkOrderArgs workOrderArgs, WorkOrderPocket workOrderPocket)
        {

            InitializeComponent();
            _WorkOrderArgs = workOrderArgs;
            _WorkOrderPocket = workOrderPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_TreeList
            {
                BindingSource = workOrderBomModelBindingSource,
                FormArgs = _WorkOrderArgs,
                ModelArgs = _WorkOrderArgs.WorkOrderModelArgs,
                TreeList = strapTreeList1,
                InitModelType = typeof(WorkOrderBomModel)
            });
            InitPocketDelegate<WorkOrderModelArgs, WorkOrderBomModel>(_WorkOrderPocket.SelectWorkOrderBomModels,null);

            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE, "ItemType", new { COMP_CD = _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code }, "품목유형", "품목유형명");
            strapTreeList1.OptionsView.AutoWidth = false;

            colBOM_QTY.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            colBOM_QTY.Format.FormatString = "#,##0.######";

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            strapTreeList1.ExpandAll();
            strapTreeList1.BestFitColumns();
        }
        public override void DataClear(ArgsBase args)
        {
            base.DataClear(args);
        }

    }
}

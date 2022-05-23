using BPack.Model.App.PC.WorWorkOrder;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WorWorkOrder;
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
using BPack.Common.Model;

namespace BPack.Carrying.App.PC.WorWorkOrder
{
    public partial class WorkOrderMaterialList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorWorkOrderArgs _worWorkOrderArgs;
        private WorWorkOrderPocket _worWorkOrderPocket;
        public WorkOrderMaterialList()
        {
            InitializeComponent();
        }

        public WorkOrderMaterialList(WorWorkOrderArgs worWorkOrderArgs, WorWorkOrderPocket worWorkOrderPocket) : this()
        {
            _worWorkOrderArgs = worWorkOrderArgs;
            _worWorkOrderPocket = worWorkOrderPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = workOrderMaterialModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _worWorkOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(WorkOrderMaterialModel),
                ModelArgs = _worWorkOrderArgs.WorWorkOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<WorWorkOrderModelArgs, WorkOrderMaterialModel>(_worWorkOrderPocket.SelectWorkOrderMaterialModels, _worWorkOrderPocket.SaveWorkOrderMaterialModel, _worWorkOrderPocket.SaveWorkOrderMaterialModels);
            LookUpEditHelper.SetGridColumnSysCode(colMAT_INPUT_TYPE, "MAT_INPUT_TYPE");
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((WorkOrderMaterialModel)model).COMP_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd;
            ((WorkOrderMaterialModel)model).PLANT_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd;
            ((WorkOrderMaterialModel)model).WO_NO = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Wo_No;
            ((WorkOrderMaterialModel)model).ROUTE_NO = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Route_No;
            ((WorkOrderMaterialModel)model).OPER = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Oper;
            ((WorkOrderMaterialModel)model).DEL_FG = "N";
            base.SetInsertDefaultValue(model);
        }
    }
}

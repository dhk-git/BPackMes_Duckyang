using BPack.Common.Model;
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

namespace BPack.Carrying.App.PC.WorWorkOrder
{
    public partial class WorkOrderHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private WorWorkOrderArgs _worWorkOrderArgs;
        private WorWorkOrderPocket _worWorkOrderPocket;
        private WorkOrderHeaderEditForm _workOrderHeaderEditForm;
        //private LookUpEditPocket _lep;
        public WorkOrderHeaderList()
        {
            InitializeComponent();
        }

        public WorkOrderHeaderList(WorWorkOrderArgs worWorkOrderArgs, WorWorkOrderPocket worWorkOrderPocket) : this()
        {
            _worWorkOrderArgs = worWorkOrderArgs;
            _worWorkOrderPocket = worWorkOrderPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = workOrderHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _worWorkOrderArgs,
                GridView = gridView1,
                InitModelType = typeof(WorkOrderHeaderModel),
                ModelArgs = _worWorkOrderArgs.WorWorkOrderModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            _workOrderHeaderEditForm = new WorkOrderHeaderEditForm(_worWorkOrderArgs, _worWorkOrderPocket);
            _gridView.OptionsEditForm.CustomEditFormLayout = _workOrderHeaderEditForm;
            _gridView.EditFormPrepared += GridView_EditFormPrepared;
            InitPocketDelegate<WorWorkOrderModelArgs, WorkOrderHeaderModel>(_worWorkOrderPocket.SelectWorkOrderHeaderModels, _worWorkOrderPocket.SaveWorkOrderHeaderModelV2, null); //_worWorkOrderPocket.SaveWorkOrderHeaderModels
            LookUpEditHelper.SetGridColumnSysCode(colWO_STATUS, "WO_STATUS");
        }

        private void GridView_EditFormPrepared(object sender, DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs e)
        {
            _workOrderHeaderEditForm.DataRefresh(_bindingSource.Current);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            //((WorkOrderHeaderModel)model).CLOSE_DT = DateTime.Now.Date;
            ((WorkOrderHeaderModel)model).COMP_CD = Common.LoginInfo.UserInfo.CompCode;
            ((WorkOrderHeaderModel)model).PLANT_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd;
            ((WorkOrderHeaderModel)model).WO_DT = DateTime.Now.Date;
            ((WorkOrderHeaderModel)model).WO_STATUS = "WAIT";
            base.SetInsertDefaultValue(model);
        }
        public void DataRefresh_ShiftLookupEdit()
        {
            LookUpEditHelper.SetGridColumnByQuery(colSHIFT_CD, "ShiftList", new
            {
                COMP_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd,
                PLANT_CD = _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd
            }, "조코드", "조명");
        }
    }
}

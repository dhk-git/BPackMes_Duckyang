using BPack.Common.Pocket;
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
    public partial class WorWorkOrderMain : StrapMainForm
    {
        private WorWorkOrderArgs _worWorkOrderArgs;
        private WorWorkOrderPocket _worWorkOrderPocket;
        private WorkOrderHeaderList _workOrderHeaderList;
        private WorkOrderDetailList _workOrderDetailList;
        private WorkOrderMaterialList _workOrderMaterialList;

        public WorWorkOrderMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _worWorkOrderArgs = new WorWorkOrderArgs();
            _worWorkOrderPocket = new WorWorkOrderPocket();
            _workOrderHeaderList = new WorkOrderHeaderList(_worWorkOrderArgs, _worWorkOrderPocket);
            _workOrderDetailList = new WorkOrderDetailList(_worWorkOrderArgs, _worWorkOrderPocket);
            _workOrderMaterialList = new WorkOrderMaterialList(_worWorkOrderArgs, _worWorkOrderPocket);
            AddSubForm(this, _workOrderHeaderList, layoutControlGroup2);
            AddSubForm(this, _workOrderDetailList, layoutControlGroup3);
            AddSubForm(this, _workOrderMaterialList, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm() {
                FormArgs = _worWorkOrderArgs,
                InitlistForm = _workOrderHeaderList,
                StrapLayout = strapLayout1
            });
            strapDateEdit2.EditValue = DateTime.Now.Date.AddDays(1);
            _workOrderHeaderList.ModelSelectedEvent += WorkOrderHeaderList_ModelSelectedEvent;
            _workOrderDetailList.ModelSelectedEvent += WorkOrderDetailList_ModelSelectedEvent;
            InitRibbonButtons(true, true, true, true);
            LookUpEditHelper.SetCompCode(lookUpEdit1);
            lookUpEdit1.EditValueChanged += LookUpEdit1_EditValueChanged;
            CommonMes.Helpers.LookUpEditHelper.SetPlantCode(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, false);
            lookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
            this.SelectedSubFormChanged += WorWorkOrderMain_SelectedSubFormChanged;
        }

        private void WorWorkOrderMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _workOrderHeaderList)
            {
                SetRibbonButtonsEnable_ByAuth(true, true, false, true);
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(true, true, true, true);
            }
        }

        private void LookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            CommonMes.Helpers.LookUpEditHelper.SetPlantCode(strapLookUpEdit1, lookUpEdit1.EditValue?.ToString(), false, true);
        }

        private void WorkOrderDetailList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Route_No = ((WorkOrderDetailModel)e.SelectedModelArgsBase.SelectedModelBase).ROUTE_NO;
            _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Oper = ((WorkOrderDetailModel)e.SelectedModelArgsBase.SelectedModelBase).OPER;
            _workOrderMaterialList.DataRefresh(_worWorkOrderArgs);

        }

        private void WorkOrderHeaderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Wo_No = ((WorkOrderHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).WO_NO;
            _workOrderDetailList.DataRefresh(_worWorkOrderArgs);
            _workOrderDetailList.SelectModelAndRaiseEvent(0);
            //_workOrderMaterialList.DataClear(_worWorkOrderArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Comp_Cd = lookUpEdit1.EditValue?.ToString();
            _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _worWorkOrderArgs.WorWorkOrderModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _workOrderHeaderList.DataRefresh_ShiftLookupEdit();
            _workOrderDetailList.DataRefresh_LookupEdit();
            base.Refresh_From_ExecuteByRibbonButton();
        }



        protected override void SetControlAndGroupDicSort()
        {
            _controlAndGroupDic = new Dictionary<string, ControlAndGroup>
            {
                { strapDateEdit1.Name, null },
                { strapDateEdit2.Name, null },
                { strapLookUpEdit1.Name, null },
                { _workOrderHeaderList.Name, null },
                { _workOrderDetailList.Name, null },
                { _workOrderMaterialList.Name, null }
            };
            base.SetControlAndGroupDicSort();
        }
    }
}

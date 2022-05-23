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
    public partial class SalesOrderMain : StrapMainForm
    {
        private SalesOrderArgs _salesOrderArgs;
        private SalesOrderPocket _salesOrderPocket;
        private SalesOrderList _salesOrderList;
        private SalesOrderDetailList _salesOrderDetailList;
        public SalesOrderMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _salesOrderArgs = new SalesOrderArgs();
            _salesOrderPocket = new SalesOrderPocket();
            _salesOrderList = new SalesOrderList(_salesOrderArgs, _salesOrderPocket);
            _salesOrderDetailList = new SalesOrderDetailList(_salesOrderArgs, _salesOrderPocket);
            AddSubForm(this, _salesOrderList, layoutControlGroup2);
            AddSubForm(this, _salesOrderDetailList, layoutControlGroup3);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _salesOrderArgs,
                InitlistForm = _salesOrderList,
                IsAutoDataRefreshOnShown = true,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, isFirstSelect: true);
            this.SelectedSubFormChanged += SalesOrderMain_SelectedSubFormChanged;
            _salesOrderList.ModelSelectedEvent += SalesOrderList_ModelSelectedEvent;
            _salesOrderList.ModelDeletedEvent += SalesOrderList_ModelDeletedEvent;
        }

        private void SalesOrderList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _salesOrderDetailList.DataClear(_salesOrderArgs);
        }

        private void SalesOrderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _salesOrderArgs.SalesOrderModelArgs.Select_Sor_No = ((SalesOrderModel)e.SelectedModelArgsBase.SelectedModelBase).SOR_NO;
            _salesOrderArgs.SalesOrderModelArgs.Select_Sor_Status = ((SalesOrderModel)e.SelectedModelArgsBase.SelectedModelBase).SOR_STATUS;
            _salesOrderArgs.SalesOrderModelArgs.Select_Bp_Cd = ((SalesOrderModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            _salesOrderDetailList.DataRefresh(_salesOrderArgs);
            ChangeEnable();
            
        }

        private void SalesOrderMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            ChangeEnable();
        }

        private void ChangeEnable()
        {
            if (this.SelectedSubForm == _salesOrderList)
            {
                if (_salesOrderArgs.SalesOrderModelArgs.Select_Sor_Status != null && _salesOrderArgs.SalesOrderModelArgs.Select_Sor_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save: false);
                    btnConfirm.Enabled = true;
                    btnDrop.Enabled = false;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save: false);
                    btnConfirm.Enabled = false;
                    btnDrop.Enabled = true;
                }
            }
            if (this.SelectedSubForm == _salesOrderDetailList)
            {
                if (_salesOrderArgs.SalesOrderModelArgs.Select_Sor_Status != null && _salesOrderArgs.SalesOrderModelArgs.Select_Sor_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save: true);
                    btnConfirm.Enabled = true;
                    btnDrop.Enabled = false;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: false);
                    btnConfirm.Enabled = false;
                    btnDrop.Enabled = true;
                }

            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _salesOrderArgs.SalesOrderModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _salesOrderArgs.SalesOrderModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _salesOrderArgs.SalesOrderModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _salesOrderArgs.SalesOrderModelArgs.Select_Main_Sor_No = txtSorNo.EditValue?.ToString();
            _salesOrderArgs.SalesOrderModelArgs.Select_Main_Custom_Po_No = txtCustomPoNo.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
            btnConfirm.Enabled = false;
            btnDrop.Enabled = false;
        }

        //선택행 확정버튼
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string validationMsg;
            validationMsg = _salesOrderList.ValidateConfirmSalesOrder();
            if (!string.IsNullOrWhiteSpace(validationMsg))
            {
                MessageBox.Show(validationMsg);
                return;
            }

            validationMsg = _salesOrderDetailList.ValidateConfirmSalesOrder();
            if (!string.IsNullOrWhiteSpace(validationMsg))
            {
                MessageBox.Show(validationMsg);
                return;
            }
            if (StrapMessageBox.Show("A001", 20, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택행 확정처리 합니다.
            {
                try
                {
                    _salesOrderPocket.BpConfirmSalesOrder(_salesOrderArgs.SalesOrderModelArgs);
                    _salesOrderList.DataRefresh(_salesOrderArgs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }
        }
        
        //강제종료 버튼
        private void btnDrop_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("A001", 23, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택행 강제종료 처리 합니다.
            {
                try
                {
                    _salesOrderPocket.BpDropSalesOrder(_salesOrderArgs.SalesOrderModelArgs);
                    _salesOrderList.DataRefresh(_salesOrderArgs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }
        }

        //주문상세 선택행 강제종료
        private void btnSodDrop_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("A001", 23, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택행 강제종료 처리 합니다.
            {
                try
                {
                    var models = _salesOrderDetailList.GetSelectedModels();
                    foreach (var model in models)
                    {
                        model.SOD_STATUS = "DROP";
                        model.RowState = Common.Model.RowState.Modified;
                        model.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
                    }
                    _salesOrderPocket.SaveSalesOrderDetailModels(models);
                    _salesOrderDetailList.DataRefresh(_salesOrderArgs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }
        }
    }
}

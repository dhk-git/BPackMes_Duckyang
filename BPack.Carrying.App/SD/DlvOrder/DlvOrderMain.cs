using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvOrder;
using BPack.Pocket.App.SD.DlvOrder;
using BPack.Report.App.Factory;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.SD.DlvOrder
{
    public partial class DlvOrderMain : StrapMainForm
    {
        private DlvOrderArgs _dlvOrderArgs;
        private DlvOrderPocket _dlvOrderPocket;
        private DlvPlanList _dlvPlanList;
        private DlvOrderList _dlvOrderList;
        private DlvOrderDetailList _dlvOrderDetailList;
        private ToReserveHuList _toReserveHuList;
        private ReservedHuList _reservedHuList;
        private decimal _sumQtyCheckedRow;

        string trLang;
        public DlvOrderMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _dlvOrderArgs = new DlvOrderArgs();
            _dlvOrderPocket = new DlvOrderPocket();
            _dlvPlanList = new DlvPlanList(_dlvOrderArgs, _dlvOrderPocket);
            _dlvOrderList = new DlvOrderList(_dlvOrderArgs, _dlvOrderPocket);
            _dlvOrderDetailList = new DlvOrderDetailList(_dlvOrderArgs, _dlvOrderPocket);
            _toReserveHuList = new ToReserveHuList(_dlvOrderArgs, _dlvOrderPocket);
            _reservedHuList = new ReservedHuList(_dlvOrderArgs, _dlvOrderPocket);
            AddSubForm(this, _dlvPlanList, layoutControlGroup2);
            AddSubForm(this, _dlvOrderList, layoutControlGroup3);
            AddSubForm(this, _dlvOrderDetailList, layoutControlGroup4);
            AddSubForm(this, _toReserveHuList, layoutControlGroup6);
            AddSubForm(this, _reservedHuList, layoutControlGroup7);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _dlvOrderArgs,
                InitlistForm = _dlvOrderList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });

            InitRibbonButtons(true);
            this.SelectedSubFormChanged += DlvOrderMain_SelectedSubFormChanged;
            _dlvOrderList.ModelSelectedEvent += DlvOrderList_ModelSelectedEvent;
            _dlvOrderList.ModelDeletedEvent += DlvOrderList_ModelDeletedEvent;
            _dlvOrderDetailList.ModelSelectedEvent += DlvOrderDetailList_ModelSelectedEvent;
            _dlvOrderDetailList.ModelDeletedEvent += DlvOrderDetailList_ModelDeletedEvent;
            _dlvOrderDetailList.ModelUpdatedEvent += DlvOrderDetailList_ModelUpdatedEvent;
            _toReserveHuList.RowCheckChanged += ToReserveHuList_RowCheckChanged;
            _dlvOrderList.AddRefreshTargetSubForm(_dlvOrderDetailList);
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);

            btnConfirm.Enabled = false;
            btnCancel.Enabled = false;
            Refresh_From_ExecuteByRibbonButton();//초기 데이터 조회를 위해...

            //2022.03.17 정수교 언어변환 
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup2.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup2.Text = trLang;
            }
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup5.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup5.Text = trLang;
            }
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup6.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup6.Text = trLang;
            }
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup7.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup7.Text = trLang;
            }

            List<LayoutControlItem> items = new List<LayoutControlItem>();
            items.Add(layoutControlItem9);
            items.Add(layoutControlItem3);
            items.Add(layoutControlItem4);
            items.Add(layoutControlItem5);
            items.Add(layoutControlItem14);
            foreach (LayoutControlItem item in items)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, item.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    item.Text = trLang;
                }
            }
            List<SimpleButton> buttons = new List<SimpleButton>();
            buttons.Add(btnSearchPlan);
            buttons.Add(btnAddPlanToDetail);
            buttons.Add(btnAddReserv);
            buttons.Add(btnCancelReserv);
            foreach (SimpleButton item in buttons)
            {
                trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, item.Text);
                if (!string.IsNullOrEmpty(trLang))
                {
                    item.Text = trLang;
                }
            }
            



        }

        private void DlvOrderDetailList_ModelUpdatedEvent(object sender, ArgsBase e)
        {
            _dlvPlanList.DataRefresh(_dlvOrderArgs);
        }

        private void ToReserveHuList_RowCheckChanged(object sender, RowCheckChangedEventArgs e)
        {
            _sumQtyCheckedRow = e.SumQtyCheckedRow;
            txtSumQtyCheckedRow.Text = _sumQtyCheckedRow.ToString("#,##0");
        }

        private void DlvOrderDetailList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _dlvOrderArgs.DlvOrderModelArgs.Select_Dod_No = ((DlvOrderDetailModel)e.SelectedModelArgsBase.SelectedModelBase).DOD_NO;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Item_Cd = ((DlvOrderDetailModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Dod_Qty = ((DlvOrderDetailModel)e.SelectedModelArgsBase.SelectedModelBase).DOD_QTY;
            _toReserveHuList.DataRefresh(_dlvOrderArgs);
            _reservedHuList.DataRefresh(_dlvOrderArgs);
            txtSumQtyCheckedRow.Text = "";
            decimal sumReservedQty = _reservedHuList.GetReservedSumQty();
            decimal autoCheckingQty = _dlvOrderArgs.DlvOrderModelArgs.Select_Dod_Qty - sumReservedQty;
            if (autoCheckingQty > 0)
            {
                _toReserveHuList.AutoCheck(autoCheckingQty);
            }
            

        }

        private void DlvOrderDetailList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _dlvPlanList.DataRefresh(_dlvOrderArgs);
        }

        private void DlvOrderList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _dlvOrderDetailList.DataClear(_dlvOrderArgs);
            _dlvPlanList.DataRefresh(_dlvOrderArgs);
        }

        private void DlvOrderMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            ChangeEnable();
        }

        private void DlvOrderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No = ((DlvOrderModel)e.SelectedModelArgsBase.SelectedModelBase).DOH_NO;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status = ((DlvOrderModel)e.SelectedModelArgsBase.SelectedModelBase).DOH_STATUS;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Bp_Cd = ((DlvOrderModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            _toReserveHuList.DataClear(_dlvOrderArgs);
            _reservedHuList.DataClear(_dlvOrderArgs);
            ChangeEnable();
            _dlvOrderDetailList.DataRefresh(_dlvOrderArgs);

        }

        private void ChangeEnable()
        {
    
            if (this.SelectedSubForm == _dlvPlanList)
            {
                SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, save: false, delete: false);
            }
            if (this.SelectedSubForm == _dlvOrderList)
            {
                //SetRibbonButtonsEnable_ByAuth(true, add: true, edit: true, save: false, delete: true);
                if (_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status != null && _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: true, edit: true, save: false, delete: true);
                    btnConfirm.Enabled = true;
                    btnCancel.Enabled = false;
                    btnAddPlanToDetail.Enabled = true;
                    btnAddReserv.Enabled = true;
                    btnCancelReserv.Enabled = true;
                    btnPrintDlvOrder.Enabled = false;
                }
                else if (_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status != null && _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status.Equals("OPEN"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: true, edit: false, save: false, delete: false);
                    btnConfirm.Enabled = false;
                    btnCancel.Enabled = true;
                    btnAddPlanToDetail.Enabled = false;
                    btnAddReserv.Enabled = false;
                    btnCancelReserv.Enabled = false;
                    btnPrintDlvOrder.Enabled = true;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: true, edit: false, save: false, delete: false);
                    btnConfirm.Enabled = false;
                    btnCancel.Enabled = false;
                    btnAddPlanToDetail.Enabled = false;
                    btnAddReserv.Enabled = false;
                    btnCancelReserv.Enabled = false;
                    btnPrintDlvOrder.Enabled = false;
                }
            }
            if (this.SelectedSubForm == _dlvOrderDetailList)
            {
                if (_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status == null)
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, save: false, delete: false);
                }
                else
                {
                    if (_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status != null && _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status.Equals("WAIT"))
                    {
                        SetRibbonButtonsEnable_ByAuth(true, add: true, edit: false, save: true, delete: true);
                        btnConfirm.Enabled = true;
                        btnCancel.Enabled = false;
                        btnAddPlanToDetail.Enabled = true;
                        btnAddReserv.Enabled = true;
                        btnCancelReserv.Enabled = true;
                    }
                    else
                    {
                        SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, save: false, delete: false);
                        btnConfirm.Enabled = false;
                        btnCancel.Enabled = false;
                        btnAddPlanToDetail.Enabled = false;
                        btnAddReserv.Enabled = false;
                        btnCancelReserv.Enabled = false;
                    }
                }
            }
            if (this.SelectedSubForm == _toReserveHuList || this.SelectedSubForm == _reservedHuList)
            {
                SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, save: false, delete: false);
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No = null;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status = null;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Bp_Cd = null;
            btnConfirm.Enabled = false;
            btnCancel.Enabled = false;
            btnAddPlanToDetail.Enabled = false;
            btnPrintDlvOrder.Enabled = false;

            base.Refresh_From_ExecuteByRibbonButton();

            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Plan_Start_Dt = strapDateEdit3.DateTime;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Plan_End_Dt = strapDateEdit4.DateTime;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit1.EditValue?.ToString();
            _dlvPlanList.DataRefresh(_dlvOrderArgs);
            _toReserveHuList.DataClear(_dlvOrderArgs);
            _reservedHuList.DataClear(_dlvOrderArgs);
        }

        //출하지시 상세 생성 버튼
        private void btnAddPlanToDetail_Click(object sender, EventArgs e)
        {
            if (_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No == null)
            {
                StrapMessageBox.Show("A002", 6); //선택된 출하지시 건이 없습니다.
                return;
            }
            if (!_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status.Equals("WAIT"))
            {
                StrapMessageBox.Show("A002", 7); //선택된 출하지시는 확정된 건입니다.
                return;
            }

            List<DlvPlanModel> checkedDlvPlanModels = _dlvPlanList.GetSelectedDlvPlanModels();
            if (checkedDlvPlanModels.Count == 0)
            {
                StrapMessageBox.Show("A002", 9); //선택된 출하계획 건이 없습니다.
                return;
            }

            var checkBpCd = checkedDlvPlanModels.Where(a => a.BP_CD != _dlvOrderArgs.DlvOrderModelArgs.Select_Bp_Cd);
            if (checkBpCd.Any())
            {
                StrapMessageBox.Show("A002", 35); //출하지시의 거래처와 출하계획의 거래처가 상이합니다.
                return;
            }

            var selectedOrderDetailModels = _dlvOrderDetailList.GetSelectedData();
            foreach (var model in checkedDlvPlanModels)
            {
                if (model.DPL_STATUS.Equals("CLOSE"))
                {
                    StrapMessageBox.Show("A002", 8); //출하지시 생성한 출하계획이 선택되었습니다.
                    return;
                }
                if (selectedOrderDetailModels.Where(a => a.DPL_NO == model.DPL_NO).Any())
                {
                    StrapMessageBox.Show("A002", 17); //동일한 출하계획건이 이미 등록 되어있습니다.
                    return;
                }
                if (selectedOrderDetailModels.Where(a => a.ITEM_CD == model.ITEM_CD).Any())
                {
                    StrapMessageBox.Show("A002", 20); // 동일한 품목이 존재합니다.
                    return;
                }
            }

            if (StrapMessageBox.Show("A001", 82, MessageBoxButtons.YesNo) == DialogResult.Yes)//선택된 출하계획을 추가 합니다.
            {
                _dlvOrderDetailList.AddDlvPlanModels(checkedDlvPlanModels);
                _dlvPlanList.DeleteCheckedDlvPlanModels(checkedDlvPlanModels);
            }
        }
        //확정버튼
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No == null)
            {
                StrapMessageBox.Show("A002", 6); //선택된 출하지시 건이 없습니다.
                return;
            }

            if (_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status.Equals("OPEN"))
            {
                StrapMessageBox.Show("A002", 7); //선택된 출하지시는 확정된 건입니다.
                return;
            }
            if (_dlvOrderDetailList.CheckConfirm(out string msg) == false)
            {
                StrapMessageBox.Show(msg);
                return;
            }
            var checkRstModels = _dlvOrderPocket.CheckItemAndHuQty(_dlvOrderArgs.DlvOrderModelArgs);
            foreach (var model in checkRstModels)
            {
                if (model.DIFF_QTY != 0)
                {
                    var diffModels = checkRstModels.Where(a => a.DIFF_QTY != 0);
                    string extMsg = "\r\n";
                    foreach (var diffModel in diffModels)
                    {
                        extMsg += "\r\n" + diffModel.ITEM_CD + "\t" + diffModel.ITEM_NM + "\tOrderQty : " + diffModel.DOD_QTY.ToString("#,##0")
                            + "\tReservedQty : " + diffModel.RESERVED_QTY.ToString("#,##0") + "\tDiffQty : " + diffModel.DIFF_QTY.ToString("#,##0");
                    }
                    string warnnigMsg = StrapMessageBox.GetMessage("A002", 37) + extMsg; //출하지시수량과 식별표 예약수량이 일치하지 않습니다.
                    StrapMessageBox.Show(warnnigMsg); 
                    return;
                }
            }

            if (StrapMessageBox.Show("A001", 20, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _dlvOrderList.GetSelectedModel().DOH_STATUS = "OPEN";
                try
                {
                    _dlvOrderPocket.BpConfirmDlvOrderModel(_dlvOrderList.GetSelectedModel());
                    _dlvOrderList.DataRefresh(_dlvOrderArgs);
                    _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No = null;
                    _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status = null;
                    _dlvOrderDetailList.DataClear(_dlvOrderArgs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
                //_dlvOrderList.SetConfirmDlvOrder();
            }

        }
        //확정취소 버튼
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status.Equals("OPEN"))
            {
                StrapMessageBox.Show("A002", 11); //취소할수 없는 상태입니다.
                return;
            }
            if (StrapMessageBox.Show("A001", 83, MessageBoxButtons.YesNo) == DialogResult.Yes) //확정취소 합니다.
            {
                _dlvOrderList.GetSelectedModel().DOH_STATUS = "WAIT";
                _dlvOrderPocket.BpCancelConfirmDlvOrderModel(_dlvOrderList.GetSelectedModel());
                _dlvOrderList.DataRefresh(_dlvOrderArgs);
                _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No = null;
                _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_Status = null;
                _dlvOrderDetailList.DataClear(_dlvOrderArgs);
                //_dlvOrderList.SetCancelConfirmDlvOrder();
            }
        }
        //생산계획 조회 버튼
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Plan_Start_Dt = strapDateEdit3.DateTime;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Plan_End_Dt = strapDateEdit4.DateTime;
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _dlvOrderArgs.DlvOrderModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit1.EditValue?.ToString();
            _dlvPlanList.DataRefresh(_dlvOrderArgs);
        }
        //선택행 예약등록 버튼
        private void btnAddReserv_Click(object sender, EventArgs e)
        {
            //if (_sumQtyCheckedRow > _dlvOrderArgs.DlvOrderModelArgs.Select_Dod_Qty)
            //{
            //    StrapMessageBox.Show("A002", 36); //선택한 식별표의 수량이 출하지시 수량보다 많습니다. 출하지시수량을 변경하거나 식별표 수량을 다시 선택하십시오
            //    return;
            //}
            if (((List<DlvOrderDetailModel>)_dlvOrderDetailList.SelectedModels).Where(a => a.RowState != Common.Model.RowState.UnChanged).Any())
            {
                StrapMessageBox.Show("A002", 4); //저장되지 않은 데이터가 존재합니다. 저장후 다시 시도바랍니다.
                return;
            }
            var selectedToReserveHuModels = _toReserveHuList.GetSelectedModels();
            if (!selectedToReserveHuModels.Any())
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }
            decimal reservedSumQty = _reservedHuList.GetReservedSumQty();
            if ((_sumQtyCheckedRow + reservedSumQty) > _dlvOrderArgs.DlvOrderModelArgs.Select_Dod_Qty)
            {
                StrapMessageBox.Show("A002", 36); //선택한 식별표의 수량이 출하지시 수량보다 많습니다. 출하지시수량을 변경하거나 식별표 수량을 다시 선택하십시오
                return;
            }
            try
            {
                List<SaveReservedHuModel> saveReservedHuModels = new List<SaveReservedHuModel>();
                SaveReservedHuModel saveReservedHuModel ;
                foreach (var model in selectedToReserveHuModels)
                {
                    saveReservedHuModel = new SaveReservedHuModel
                    { 
                       DOH_NO = _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No,
                       DOD_NO = _dlvOrderArgs.DlvOrderModelArgs.Select_Dod_No,
                       HU_NO = model.HU_NO,
                       CREATE_DTTM = DateTime.Now,
                       MODIFY_DTTM = DateTime.Now,
                       CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                       MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                       LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                       RowState = Common.Model.RowState.Added
                    };
                    saveReservedHuModels.Add(saveReservedHuModel);
                }
                _dlvOrderPocket.SaveReservedHuModels(saveReservedHuModels);
                _toReserveHuList.DataRefresh(_dlvOrderArgs);
                _reservedHuList.DataRefresh(_dlvOrderArgs);
                _dlvOrderDetailList.DataRefresh(_dlvOrderArgs);
                _dlvOrderDetailList.SetFocus(_dlvOrderArgs);
                txtSumQtyCheckedRow.Text = "";
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }


        }
        //선택행 예약취소 버튼
        private void btnCancelReserv_Click(object sender, EventArgs e)
        {
            var selectedReservedHuModels = _reservedHuList.GetSelectedModels();
            if (!selectedReservedHuModels.Any())
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }
            try
            {
                List<SaveReservedHuModel> saveReservedHuModels = new List<SaveReservedHuModel>();
                SaveReservedHuModel saveReservedHuModel;
                foreach (var model in selectedReservedHuModels)
                {
                    saveReservedHuModel = new SaveReservedHuModel
                    {
                        DOH_NO = _dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No,
                        DOD_NO = _dlvOrderArgs.DlvOrderModelArgs.Select_Dod_No,
                        HU_NO = model.HU_NO,
                        CREATE_DTTM = DateTime.Now,
                        MODIFY_DTTM = DateTime.Now,
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                        RowState = Common.Model.RowState.Deleted
                    };
                    saveReservedHuModels.Add(saveReservedHuModel);
                }
                _dlvOrderPocket.SaveReservedHuModels(saveReservedHuModels);
                _toReserveHuList.DataRefresh(_dlvOrderArgs);
                _reservedHuList.DataRefresh(_dlvOrderArgs);
                _dlvOrderDetailList.DataRefresh(_dlvOrderArgs);
                _dlvOrderDetailList.SetFocus(_dlvOrderArgs);
                txtSumQtyCheckedRow.Text = "";
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }

        //출하지시서 출력버튼
        private void btnPrintDlvOrder_Click(object sender, EventArgs e)
        {
            List<string> selectedDohNo = new List<string>();
            selectedDohNo.Add(_dlvOrderArgs.DlvOrderModelArgs.Select_Doh_No);
            DlvOrderReportFactory rf = DlvOrderReportFactory.GetInstance();
            rf.ShowReport_DlvOrder(selectedDohNo).ShowPreviewDialog();
        }
    }
}

using BPack.CommonMes.Helpers;
using BPack.Model.App.PO.PurOrder;
using BPack.Pocket.App.PO.PurOrder;
using BPack.Report.App.Factory;
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
    public partial class PurOrderMain : StrapMainForm
    {
        private PurOrderArgs _purOrderArgs;
        private PurOrderPocket _purOrderPocket;
        private PurOrderList _purOrderList;
        private PurOrderDetailList _purOrderDetailList;
        private PorList _porList;

        public PurOrderMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _purOrderArgs = new PurOrderArgs();
            _purOrderPocket = new PurOrderPocket();
            _purOrderList = new PurOrderList(_purOrderArgs, _purOrderPocket);
            _purOrderDetailList = new PurOrderDetailList(_purOrderArgs, _purOrderPocket);
            _porList = new PorList(_purOrderArgs, _purOrderPocket);
            AddSubForm(this, _purOrderList, layoutControlGroup2);
            AddSubForm(this, _purOrderDetailList, layoutControlGroup3);
            AddSubForm(this, _porList, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _purOrderArgs,
                InitlistForm = _purOrderList,
                IsAutoDataRefreshOnShown = true,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            LookUpEditHelper.SetSysCode(strapLookUpEdit2, "POH_INTER_CLS");
            LookUpEditHelper.SetBusinessPartner(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, true, false, true, false, false);

            this.SelectedSubFormChanged += PurOrderMain_SelectedSubFormChanged;
            _purOrderList.ModelSelectedEvent += PurOrderList_ModelSelectedEvent;
            _purOrderList.AddRefreshTargetSubForm(_purOrderDetailList);
            _purOrderList.ModelDeletedEvent += PurOrderList_ModelDeletedEvent;
            chkSendMail.CheckState = CheckState.Checked;
            chkSendMail.ToolTip = StrapMessageBox.GetMessage("A001", 46); //확정 혹은 취소시 지정된 수신자에게 메일을 발송합니다.(수신자수정 : 콩통코드관리)
        }

        private void PurOrderList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _purOrderDetailList.DataClear(_purOrderArgs);
            SetRibbonButtonsEnable_ByAuth(add: true, edit: false, save: false, delete: false);
        }

        private void PurOrderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _purOrderArgs.PurOrderModelArgs.Select_Poh_No = ((PurOrderModel)e.SelectedModelArgsBase.SelectedModelBase).POH_NO;
            _purOrderArgs.PurOrderModelArgs.Select_Poh_Status = ((PurOrderModel)e.SelectedModelArgsBase.SelectedModelBase).POH_STATUS;
            _purOrderArgs.PurOrderModelArgs.Select_Bp_Cd = ((PurOrderModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            _purOrderDetailList.DataRefresh(_purOrderArgs);
            ChangeEnable();
            //if (_purOrderArgs.PurOrderModelArgs.Select_Poh_Status != null && _purOrderArgs.PurOrderModelArgs.Select_Poh_Status.Equals("WAIT"))
            //{
            //    SetRibbonButtonsEnable_ByAuth(add: true, edit: true, save: false, delete: true);
            //}
            //else
            //{
            //    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, save: false, delete: false);
            //}
        }

        private void PurOrderMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            ChangeEnable();
        }

        private void ChangeEnable()
        {
            if (this.SelectedSubForm == _purOrderList)
            {
                if (_purOrderArgs.PurOrderModelArgs.Select_Poh_Status != null && _purOrderArgs.PurOrderModelArgs.Select_Poh_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: true, save: false, delete: true);
                    btnConfirm.Enabled = true;
                    btnPrint.Enabled = false;
                    btnAddPor.Enabled = true;
                    btnCancel.Enabled = false;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, save: false, delete: false);
                    btnConfirm.Enabled = false;
                    btnPrint.Enabled = true;
                    btnAddPor.Enabled = false;
                    btnCancel.Enabled = true;
                }

            }
            if (this.SelectedSubForm == _purOrderDetailList)
            {
                if (_purOrderArgs.PurOrderModelArgs.Select_Poh_Status != null && _purOrderArgs.PurOrderModelArgs.Select_Poh_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, save: true, delete: true);
                    btnConfirm.Enabled = true;
                    btnPrint.Enabled = false;
                    btnAddPor.Enabled = true;
                    btnCancel.Enabled = false;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: false, edit: false, save: false, delete: false);
                    btnConfirm.Enabled = false;
                    btnPrint.Enabled = true;
                    btnAddPor.Enabled = false;
                    btnCancel.Enabled = true;
                }
            }
            if (this.SelectedSubForm == _porList)
            {
                if (_purOrderArgs.PurOrderModelArgs.Select_Poh_Status != null && _purOrderArgs.PurOrderModelArgs.Select_Poh_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: false, edit: false, save: false, delete: false);
                    btnConfirm.Enabled = true;
                    btnPrint.Enabled = false;
                    btnAddPor.Enabled = true;
                    btnCancel.Enabled = false;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: false, edit: false, save: false, delete: false);
                    btnConfirm.Enabled = false;
                    btnPrint.Enabled = true;
                    btnAddPor.Enabled = false;
                    btnCancel.Enabled = true;
                }
            }

        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _purOrderArgs.PurOrderModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _purOrderArgs.PurOrderModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _purOrderArgs.PurOrderModelArgs.Select_Main_Bp_Cd = strapLookUpEdit1.EditValue?.ToString();
            _purOrderArgs.PurOrderModelArgs.Select_Main_Poh_Inter_Cls = strapLookUpEdit2.EditValue?.ToString();
            _purOrderArgs.PurOrderModelArgs.Select_Poh_No = null;
            _purOrderArgs.PurOrderModelArgs.Select_Poh_Status = null;
            _purOrderArgs.PurOrderModelArgs.Select_Main_Por_Start_Dt = strapDateEdit3.DateTime;
            _purOrderArgs.PurOrderModelArgs.Select_Main_Por_End_Dt = strapDateEdit4.DateTime;
            base.Refresh_From_ExecuteByRibbonButton();
            _porList.DataRefresh(_purOrderArgs);
            btnConfirm.Enabled = false;
            btnPrint.Enabled = false;
            btnAddPor.Enabled = false;
            btnCancel.Enabled = false;
        }

        //확정버튼
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string returnMsg = "";
            returnMsg = _purOrderList.CheckConfirmOrder();
            if (!string.IsNullOrEmpty(returnMsg))
            {
                StrapMessageBox.Show(returnMsg);
                return;
            }
            returnMsg = _purOrderDetailList.CheckConfirmOrder();
            if (!string.IsNullOrEmpty(returnMsg))
            {
                StrapMessageBox.Show(returnMsg);
                return;
            }
            if (StrapMessageBox.Show("A001", 20, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택행 확정처리 합니다.
            {
                try
                {
                    _purOrderPocket.BpConfirmPo(_purOrderArgs.PurOrderModelArgs);
                    //발주서 메일발송
                    if (chkSendMail.CheckState == CheckState.Checked)
                    {
                        UpdatePoReport(); //메일보낼 레포트 내용 업데이트 20220414
                        _purOrderPocket.BpSendMail(_purOrderArgs.PurOrderModelArgs);
                    }
                    _purOrderList.DataRefresh(_purOrderArgs);
                    _purOrderDetailList.DataClear(_purOrderArgs);
                    _porList.DataRefresh(_purOrderArgs);
                    btnConfirm.Enabled = false;
                    btnPrint.Enabled = false;
                    StrapMessageBox.Show("A001", 18); //처리완료 되었습니다.
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }
        }

        //확정 취소 버튼
        private void btnCancel_Click(object sender, EventArgs e)
        {
            

            if (StrapMessageBox.Show("A001", 83, MessageBoxButtons.YesNo) == DialogResult.Yes) //확정 취소 합니다.
            {
                try
                {
                    _purOrderPocket.BpCancelPo(_purOrderArgs.PurOrderModelArgs);
                    //취소메일 발송
                    if (chkSendMail.CheckState == CheckState.Checked)
                    {
                        _purOrderPocket.BpSendMail(_purOrderArgs.PurOrderModelArgs);
                    }
                    _purOrderList.DataRefresh(_purOrderArgs);
                    _purOrderDetailList.DataClear(_purOrderArgs);
                    _porList.DataRefresh(_purOrderArgs);
                    btnConfirm.Enabled = false;
                    btnPrint.Enabled = false;
                    StrapMessageBox.Show("A001", 18); //처리완료 되었습니다.
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }
        }

        //선택행 발주상세 생성
        private void btnAddPor_Click(object sender, EventArgs e)
        {
            var checkedPorModels = _porList.GetCheckedModels();
            if (!checkedPorModels.Any())
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }

            //구매요청에 거래처가 있으면 한번에 넣도록 했는데 ㅡㅡ 구매요청에서 거래처 빼는 바람에 사용을 못함...
            //var chkBpCds = checkedPorModels.Select(a => a.BP_CD).Distinct();
            //if (chkBpCds.Count() > 1)
            //{
            //    StrapMessageBox.Show("A002", 16); //서로 다른 거래처를 선택하였습니다. 동일한 거래처를 선택바랍니다.
            //    return;
            //}


            try
            {
                //구매요청에 거래처가 있으면 한번에 넣도록 했는데 ㅡㅡ 구매요청에서 거래처 빼는 바람에 사용을 못함...
                //PorListToPoModel porListToPoModel = new PorListToPoModel();
                //porListToPoModel.BP_CD = chkBpCds.First().ToString();
                //porListToPoModel.COMP_CD = Common.LoginInfo.UserInfo.CompCode;
                //porListToPoModel.PLANT_CD = Common.LoginInfo.UserInfo.PlantCode;
                //porListToPoModel.LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language;
                //porListToPoModel.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                //porListToPoModel.SEPAR = "^#^";
                //porListToPoModel.POE_LIST = string.Join("^#^", checkedPorModels.Select(a => a.POE_NO).ToArray());
                //_purOrderPocket.BpPorListToPoPlan(porListToPoModel);
                //_purOrderList.DataRefresh(_purOrderArgs);

                List<PurOrderDetailModel> purOrderDetailModels = new List<PurOrderDetailModel>();
                foreach (var model in checkedPorModels)
                {
                    purOrderDetailModels.Add(new PurOrderDetailModel
                    {
                        COMP_CD = model.COMP_CD,
                        PLANT_CD = model.PLANT_CD,
                        ITEM_CD = model.ITEM_CD,
                        ITEM_NM = model.ITEM_NM,
                        ITEM_GR_1 = model.ITEM_GR_1,
                        LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                        DUE_DT = model.POE_DUE_DT,
                        POH_NO = _purOrderArgs.PurOrderModelArgs.Select_Poh_No,
                        POR_NO = model.POR_NO,
                        POE_NO = model.POE_NO,
                        POD_QTY = model.POE_QTY,
                        CURRENCY_TYPE = CommonMes.Config.GlobalSettings.CURRENCY_TYPE,
                        POD_STATUS = "WAIT",
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        DEL_FG = "N",
                        IS_BATCH_FROM_POR = "Y",
                        RowState = Common.Model.RowState.Added
                    });
                }
                _purOrderDetailList.AddPurOrderDetailFromPorData(purOrderDetailModels);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }

        }
        //Por 조회버튼
        private void strapButton2_Click(object sender, EventArgs e)
        {
            _purOrderArgs.PurOrderModelArgs.Select_Main_Por_Start_Dt = strapDateEdit3.DateTime;
            _purOrderArgs.PurOrderModelArgs.Select_Main_Por_End_Dt = strapDateEdit4.DateTime;
            _porList.DataRefresh(_purOrderArgs);
        }
        //발주서 출력 버튼
        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<string> pohList = new List<string>();
            pohList.Add(_purOrderArgs.PurOrderModelArgs.Select_Poh_No);
            //pohList.Add("POH20211228-00000001");
            //pohList.Add("POH20211228-00000002");
            PurchaseOrderReportFactory rf = PurchaseOrderReportFactory.GetInstance();
            rf.ShowReport_PurchaseOrder(pohList).ShowPreviewDialog();
        }

        private void UpdatePoReport()
        {
            List<string> pohList = new List<string>();
            pohList.Add(_purOrderArgs.PurOrderModelArgs.Select_Poh_No);
            PurchaseOrderReportFactory rf = PurchaseOrderReportFactory.GetInstance();
            var ipoReport = rf.ShowReport_PurchaseOrder(pohList);
            var poReport = ipoReport.GetReport();

            poReport.ExportOptions.Html.ExportMode = DevExpress.XtraPrinting.HtmlExportMode.SingleFilePageByPage;
            poReport.ExportOptions.Html.EmbedImagesInHTML = true;
            poReport.ExportOptions.Html.TableLayout = true;
            //poReport.ExportOptions.Html.PageBorderColor = Color.White;
            string strHtml;
            byte[] byteArrayPdf;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                poReport.ExportToHtml(ms);
                ms.Seek(0, System.IO.SeekOrigin.Begin);
                using (System.IO.StreamReader reader = new System.IO.StreamReader(ms, Encoding.UTF8))
                {
                    strHtml = reader.ReadToEnd();
                }
            }
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                poReport.ExportToPdf(ms);
                byteArrayPdf = ms.ToArray();
            }
            try
            {
                _purOrderPocket.UpdatePoReport(new PurOrderAddReportModel
                {
                    LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                    POH_NO = _purOrderArgs.PurOrderModelArgs.Select_Poh_No,
                    PO_REPORT_HTML = strHtml,
                    PO_REPORT_PDF = byteArrayPdf
                });
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }

}

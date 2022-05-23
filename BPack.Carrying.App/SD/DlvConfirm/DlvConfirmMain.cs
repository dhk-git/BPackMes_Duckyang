using BPack.Common.LoginInfo;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvConfirm;
using BPack.Pocket.App.SD.DlvConfirm;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Data;

namespace BPack.Carrying.App.SD.DlvConfirm
{
    public partial class DlvConfirmMain : StrapMainForm
    {
        private const string DLV_STATUS_READY = "SHIP_READY";
        private const int IDX_JIS = 0;
        private const int IDX_JIT = 1;

        private DlvConfirmArgs _DlvConfirmArgsJIS;
        private DlvConfirmArgs _DlvConfirmArgsJIT;
        private DlvConfirmPocket _DlvConfirmPocket;

        private DlvConfirmHeaderList _DlvConfirmHeaderJISList;
        private DlvConfirmHeaderList _DlvConfirmHeaderJITList;
        private DlvConfirmDetailJISList _DlvConfirmDetailJISList;
        private DlvConfirmDetailJITList _DlvConfirmDetailJITList;
        private DlvConfirmDetailHUList _DlvConfirmDetailHUList;

        public DlvConfirmMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _DlvConfirmArgsJIS = new DlvConfirmArgs();
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Dlv_Type = "JIS";

            _DlvConfirmArgsJIT = new DlvConfirmArgs();
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Dlv_Type = "JIT";

            _DlvConfirmPocket = new DlvConfirmPocket();
            _DlvConfirmHeaderJISList = new DlvConfirmHeaderList(_DlvConfirmArgsJIS, _DlvConfirmPocket);
            _DlvConfirmHeaderJITList = new DlvConfirmHeaderList(_DlvConfirmArgsJIT, _DlvConfirmPocket);

            _DlvConfirmDetailJISList = new DlvConfirmDetailJISList(_DlvConfirmArgsJIS, _DlvConfirmPocket);
            _DlvConfirmDetailJITList = new DlvConfirmDetailJITList(_DlvConfirmArgsJIT, _DlvConfirmPocket);
            _DlvConfirmDetailHUList = new DlvConfirmDetailHUList(_DlvConfirmArgsJIT, _DlvConfirmPocket);

            AddSubForm(this, _DlvConfirmHeaderJISList, lcgJISHeader);
            AddSubForm(this, _DlvConfirmHeaderJITList, lcgJITHeader);
            AddSubForm(this, _DlvConfirmDetailJISList, lcgJISDetail);
            AddSubForm(this, _DlvConfirmDetailJITList, lcgJITDetail);
            AddSubForm(this, _DlvConfirmDetailHUList, lcgJITDetailHU);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _DlvConfirmArgsJIS,
                InitlistForm = _DlvConfirmHeaderJISList,
                StrapLayout = strapLayout1
            });

            dteREQ_DT_FROM.EditValue = dteREQ_DT_TO.EditValue = DateTime.Now;

            InitRibbonButtons(true, false, false, false);

            // 출하상태 조건에 따라 컨트롤 제어 
            rdgDLV_STATUS_SelectedIndexChanged(this, null);

            /*
            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _DlvConfirmHeaderJISList) { SetRibbonButtonsEnable_ByAuth(true);}
                else if (this.SelectedSubForm == _DlvConfirmHeaderJITList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                else if (this.SelectedSubForm == _DlvConfirmDetailJISList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                else if (this.SelectedSubForm == _DlvConfirmDetailJITList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                else if (this.SelectedSubForm == _DlvConfirmDetailHUList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                else { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
            };
            */

            LookUpEditHelper.SetCompCode(lueCOMP_CD);

            lueCOMP_CD.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(luePLANT_CD, new { COMP_CD = lueCOMP_CD.EditValue?.ToString() }, isFirstSelect: true);
            };

            luePLANT_CD.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetDeliveryPlace(lueDLV_PLC_CD, lueCOMP_CD.EditValue?.ToString(), luePLANT_CD.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true);
            };

            lueDLV_PLC_CD.EditValueChanged += lueDLV_PLC_CD_EditValueChanged;
            dteREQ_DT_FROM.EditValueChanged += lueDLV_PLC_CD_EditValueChanged;
            dteREQ_DT_TO.EditValueChanged += lueDLV_PLC_CD_EditValueChanged;
            rdgDLV_STATUS.EditValueChanged += lueDLV_PLC_CD_EditValueChanged;
            txtCAR_NO.TextChanged += lueDLV_PLC_CD_EditValueChanged;
            txtDOH_NO.TextChanged += lueDLV_PLC_CD_EditValueChanged; 

            _DlvConfirmHeaderJISList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Cp_No = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).CP_NO;
                _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Cp_Seq = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).CP_SEQ;
                _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Doh_No = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DOH_NO;
                _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Load_Seq = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).LOAD_SEQ;
                _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Drt_No = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DRT_NO;

                if (((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DRT_NO != null)  // 출하확정후
                {
                    dteDLV_DT_JIS.EditValue = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_DT;
                }
                else  // 출하확정전 
                {
                    Common.Config.SystemConfig.RefreshServerDateTime();
                    if (BPack.Common.Config.SystemConfig.ServerDateTime.Hour < 4)
                    {
                        dteDLV_DT_JIS.EditValue = DateTime.Now.AddDays(-1); // 전일 
                    }
                    else
                    {
                        dteDLV_DT_JIS.EditValue = DateTime.Now; // 당일 
                    }
                }

                if (((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).CAR_NO != null)
                {
                    DataTable dt = lueCAR_NO_JIS.Properties.DataSource as DataTable;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["CAR_NO"].ToString() == ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).CAR_NO)
                        {
                            lueCAR_NO_JIS.EditValue = dt.Rows[i]["CAR_KEY"];
                            break;
                        }
                    }
                    txtDRIV_NM_JIS.EditValue = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DRIV_NM;
                    txtPHONE_NO_JIS.EditValue = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PHONE_NO;

                    tseDLV_TM_JIS.EditValue = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_TM;
                }

                if (dteDLV_DT_JIS.EditValue == null)
                    dteDLV_DT_JIS.EditValue = DateTime.Now;

                if (tseDLV_TM_JIS.EditValue == null)
                    tseDLV_TM_JIS.EditValue = DateTime.Now.ToString("HH:mm");

                _DlvConfirmDetailJISList.DataRefresh(_DlvConfirmArgsJIS);
            };

            _DlvConfirmHeaderJITList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Cp_No = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).CP_NO;
                _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Cp_Seq = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).CP_SEQ;
                _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Doh_No = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DOH_NO;
                _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Load_Seq = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).LOAD_SEQ;
                _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Drt_No = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DRT_NO;

                txtCAR_NO_JIT.EditValue = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).CAR_NO;
                txtDRIV_NM_JIT.EditValue = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DRIV_NM;
                txtPHONE_NO_JIT.EditValue = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PHONE_NO;
                dteDLV_DT_JIT.EditValue = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_DT;
                tseDLV_TM_JIT.EditValue = ((DlvConfirmHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_TM;

                if (dteDLV_DT_JIT.EditValue == null)
                    dteDLV_DT_JIT.EditValue = DateTime.Now;

                if (tseDLV_TM_JIT.EditValue == null)
                    tseDLV_TM_JIT.EditValue = DateTime.Now.ToString("HH:mm");

                _DlvConfirmDetailJITList.DataRefresh(_DlvConfirmArgsJIT);
                _DlvConfirmDetailJITList.SelectModelAndRaiseEvent(0);
            };

            _DlvConfirmDetailJITList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Dod_No = ((DlvConfirmDetailJITModel)e.SelectedModelArgsBase.SelectedModelBase).DOD_NO;

                _DlvConfirmDetailHUList.DataRefresh(_DlvConfirmArgsJIT);
            };

            lueCOMP_CD.EditValue = BPack.Common.LoginInfo.UserInfo.CompCode;

        }

        private void RefreshDlvConfirmHeader()
        {
            DlvResultClear();

            // 차량번호 리스트 가져오기 
            LookUpEditHelper.SetByQuery(lueCAR_NO_JIS, "SD.DlvConfirm.CarNo.Select",
                            new
                            {
                                COMP_CD = lueCOMP_CD.EditValue?.ToString(),
                                DEL_FG = rdgDLV_STATUS.EditValue?.ToString() == DLV_STATUS_READY ? "N" : string.Empty
                            },
                            new Dictionary<string, string>() { { "CAR_NO", "CarNo" }, { "DRIV_NM", "Driver" }, { "PHONE_NO", "Phone" }, { "BP_CD", "Vender" }}, "CAR_KEY", "CAR_NO");

            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Dlv_Plc_Cd = lueDLV_PLC_CD.EditValue?.ToString();
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Req_Dt_From = (DateTime)dteREQ_DT_FROM.EditValue;
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Req_Dt_To = (DateTime)dteREQ_DT_TO.EditValue;
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Dlv_Status = rdgDLV_STATUS.EditValue?.ToString();
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Car_No = txtCAR_NO.Text;
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Doh_No = txtDOH_NO.Text;

            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Dlv_Plc_Cd = lueDLV_PLC_CD.EditValue?.ToString();
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Req_Dt_From = (DateTime)dteREQ_DT_FROM.EditValue;
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Req_Dt_To = (DateTime)dteREQ_DT_TO.EditValue;
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Dlv_Status = rdgDLV_STATUS.EditValue?.ToString();
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Car_No = txtCAR_NO.Text;
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Doh_No = txtDOH_NO.Text;

            _DlvConfirmHeaderJISList.DataRefresh(_DlvConfirmArgsJIS);
            _DlvConfirmHeaderJITList.DataRefresh(_DlvConfirmArgsJIT);

            _DlvConfirmHeaderJISList.SelectModelAndRaiseEvent(0);
            _DlvConfirmHeaderJITList.SelectModelAndRaiseEvent(0);

        }

        private void DlvResultClear()
        {
            if(tabConfirm.SelectedTabPageIndex == IDX_JIS)
            {
                lueCAR_NO_JIS.EditValue = "";
                txtDRIV_NM_JIS.EditValue = "";
                txtPHONE_NO_JIS.EditValue = "";
                dteDLV_DT_JIS.EditValue = DateTime.Now;
                tseDLV_TM_JIS.EditValue = DateTime.Now.ToString("HH:mm");

                _DlvConfirmHeaderJISList.DataClear(_DlvConfirmArgsJIS);
                _DlvConfirmDetailJISList.DataClear(_DlvConfirmArgsJIS);
            }
            else
            {
                txtCAR_NO_JIT.EditValue = "";
                txtDRIV_NM_JIT.EditValue = "";
                txtPHONE_NO_JIT.EditValue = "";
                dteDLV_DT_JIT.EditValue = DateTime.Now;
                tseDLV_TM_JIT.EditValue = DateTime.Now.ToString("HH:mm");

                _DlvConfirmHeaderJITList.DataClear(_DlvConfirmArgsJIT);
                _DlvConfirmDetailJITList.DataClear(_DlvConfirmArgsJIT);
                _DlvConfirmDetailHUList.DataClear(_DlvConfirmArgsJIT);
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            lueDLV_PLC_CD.EditValueChanged -= lueDLV_PLC_CD_EditValueChanged;
            dteREQ_DT_FROM.EditValueChanged -= lueDLV_PLC_CD_EditValueChanged;
            dteREQ_DT_TO.EditValueChanged -= lueDLV_PLC_CD_EditValueChanged;
            rdgDLV_STATUS.EditValueChanged -= lueDLV_PLC_CD_EditValueChanged;
            txtCAR_NO.TextChanged -= lueDLV_PLC_CD_EditValueChanged;
            txtDOH_NO.TextChanged -= lueDLV_PLC_CD_EditValueChanged;

            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Dlv_Plc_Cd = lueDLV_PLC_CD.EditValue?.ToString();
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Req_Dt_From = dteREQ_DT_FROM.DateTime;// (DateTime)dteREQ_DT_FROM.EditValue;
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Req_Dt_To = dteREQ_DT_TO.DateTime;// (DateTime)dteREQ_DT_TO.EditValue;
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Dlv_Status = rdgDLV_STATUS.EditValue?.ToString();
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Car_No = txtCAR_NO.Text;
            _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Main_Doh_No = txtDOH_NO.Text;

            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Plant_Cd = luePLANT_CD.EditValue?.ToString();
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Dlv_Plc_Cd = lueDLV_PLC_CD.EditValue?.ToString();
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Req_Dt_From = dteREQ_DT_FROM.DateTime;// (DateTime)dteREQ_DT_FROM.EditValue;
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Req_Dt_To = dteREQ_DT_TO.DateTime;// (DateTime)dteREQ_DT_TO.EditValue;
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Dlv_Status = rdgDLV_STATUS.EditValue?.ToString();
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Car_No = txtCAR_NO.Text;
            _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Main_Doh_No = txtDOH_NO.Text;
            tseDLV_TM_JIS.EditValue = DateTime.Now.ToString("HH:mm"); //조회시 출하시간 갱신 추가 20210525
            tseDLV_TM_JIT.EditValue = DateTime.Now.ToString("HH:mm"); //조회시 출하시간 갱신 추가 20210525
            base.Refresh_From_ExecuteByRibbonButton();
            _DlvConfirmHeaderJITList.DataRefresh(_DlvConfirmArgsJIT);

            _DlvConfirmHeaderJISList.SelectModelAndRaiseEvent(0);
            _DlvConfirmHeaderJITList.SelectModelAndRaiseEvent(0);

            lueDLV_PLC_CD.EditValueChanged += lueDLV_PLC_CD_EditValueChanged;
            dteREQ_DT_FROM.EditValueChanged += lueDLV_PLC_CD_EditValueChanged;
            dteREQ_DT_TO.EditValueChanged += lueDLV_PLC_CD_EditValueChanged;
            rdgDLV_STATUS.EditValueChanged += lueDLV_PLC_CD_EditValueChanged;
            txtCAR_NO.TextChanged += lueDLV_PLC_CD_EditValueChanged;
            txtDOH_NO.TextChanged += lueDLV_PLC_CD_EditValueChanged;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StrapButton btn = (StrapButton)sender;
            DlvConfirmHeaderList headerList = null;

            if (btn == btnPrint_JIS)
                headerList = _DlvConfirmHeaderJISList;
            else
                headerList = _DlvConfirmHeaderJITList;

            if(headerList.GetSelectedModel() == null)
            {
                StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                headerList.Focus();
                return;
            }

            var printSys = new PrintingSystem();
            printSys.ShowMarginsWarning = false;

            var dlvCard = new DlvConfirmCard(_DlvConfirmPocket, headerList.GetSelectedModel().DRT_NO);
            //dlvCard.DataRefresh();
            dlvCard.CreateDocument();
            printSys.Pages.AddRange(dlvCard.Pages);

            if (printSys.Pages.Count < 1) return;

            var printTool = new DevExpress.XtraPrinting.PrintTool(printSys);
            printTool.ShowPreviewDialog();
        }

        private void lueDLV_PLC_CD_EditValueChanged(object sender, EventArgs e)
        {
            RefreshDlvConfirmHeader();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                StrapButton btn = (StrapButton)sender;

                // 유효성 체크 
                DlvConfirmHeaderList headerList = null;
                StrapTextEdit txtDRIV_NM = null;
                StrapTextEdit txtPHONE_NO = null;
                StrapDateEdit dteDLV_DT = null;
                TimeSpanEdit tseDLV_TM = null;
                string CarNo = string.Empty;
                string CpNo = string.Empty;

                if (btn == btnConfirm_JIS)
                {
                    headerList = _DlvConfirmHeaderJISList;
                    CpNo = _DlvConfirmArgsJIS.DlvConfirmModelArgs.Select_Cp_No;
                    CarNo = (lueCAR_NO_JIS.GetColumnValue("CAR_NO") == null ? string.Empty : lueCAR_NO_JIS.GetColumnValue("CAR_NO").ToString());
                    //CarNo = (lueCAR_NO_JIS.EditValue == null ? string.Empty : lueCAR_NO_JIS.EditValue.ToString());
                    txtDRIV_NM = txtDRIV_NM_JIS;
                    txtPHONE_NO = txtPHONE_NO_JIS;
                    dteDLV_DT = dteDLV_DT_JIS;
                    tseDLV_TM = tseDLV_TM_JIS;
                }
                else
                {
                    headerList = _DlvConfirmHeaderJITList;
                    CpNo = _DlvConfirmArgsJIT.DlvConfirmModelArgs.Select_Cp_No;
                    CarNo = txtCAR_NO_JIT.Text;
                    txtDRIV_NM = txtDRIV_NM_JIT;
                    txtPHONE_NO = txtPHONE_NO_JIT;
                    dteDLV_DT = dteDLV_DT_JIT;
                    tseDLV_TM = tseDLV_TM_JIT;
                }

                var model = headerList.GetSelectedModel();
                if (model == null)
                {
                    StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                    headerList.Focus();
                    return;
                }

                if (CarNo.Trim() == string.Empty)
                {
                    StrapMessageBox.Show("A001", 45);   // 차량번호를 입력해 주세요.
                    
                    if (btn == btnConfirm_JIS)
                        lueCAR_NO_JIS.Focus();
                    else 
                        txtCAR_NO_JIT.Focus();

                    return;
                }

                if (txtDRIV_NM.Text.Trim() == string.Empty)
                {
                    StrapMessageBox.Show("A001", 46);   // 운전자를 입력해 주세요.
                    txtDRIV_NM.Focus();
                    return;
                }

                if (dteDLV_DT.EditValue == null)
                {
                    StrapMessageBox.Show("A001", 47);   // 납품일자를 선택해 주세요.
                    dteDLV_DT.Focus();
                    return;
                }

                if (tseDLV_TM.EditValue == null)
                {
                    StrapMessageBox.Show("A001", 48);   // 출고시간을 선택해 주세요.
                    tseDLV_TM.Focus();
                    return;
                }

                // 출하확정
                SimplePocket sp = SimplePocket.GetInstance();
                sp.SimplePocketExecute("SD.DlvConfirm.Save", new
                {
                    @OPT = "1",
                    @USER_ID = UserInfo.UserID,
                    @LANG_CODE = UserInfo.Sys_Language,
                    @CP_NO = CpNo,
                    @DLV_DT = dteDLV_DT.DateTime.ToShortDateString(),
                    @DLV_TM = tseDLV_TM.TimeSpan,
                    @CAR_NO = CarNo,
                    @DRIV_NM = txtDRIV_NM.Text,
                    @PHONE_NO = txtPHONE_NO.Text
                }); ;

                StrapMessageBox.Show("A001", 49);

                // Data Refresh
                DlvResultClear();
                //headerList.DataClear(btn == btnConfirm_JIS ? _DlvConfirmArgsJIS : _DlvConfirmArgsJIT);  // Added by SKJIN (2020/11/24) 
                headerList.DataRefresh(btn == btnConfirm_JIS ? _DlvConfirmArgsJIS : _DlvConfirmArgsJIT);
                headerList.SelectModelAndRaiseEvent(0);
            }
            catch(Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
            }
        }
        private void rdgDLV_STATUS_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 출하확정 권한 부여 
            if (rdgDLV_STATUS.EditValue?.ToString() == DLV_STATUS_READY)
            {
                lciREQ_DT_FROM.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciREQ_DT_TO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                btnPrint_JIS.Enabled = false;
                btnPrint_JIT.Enabled = false;

                if (LoginMenuAuthModel.UPDATE_AUTH == true)
                {
                    btnConfirm_JIS.Enabled = true;
                    btnConfirm_JIT.Enabled = true;
                }
                else
                {
                    btnConfirm_JIS.Enabled = false;
                    btnConfirm_JIT.Enabled = false;
                }

                _DlvConfirmHeaderJISList.ControlGrid(1);
                _DlvConfirmHeaderJITList.ControlGrid(1);
            }
            else
            {
                lciREQ_DT_FROM.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciREQ_DT_TO.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

                btnPrint_JIS.Enabled = true;
                btnPrint_JIT.Enabled = true;
                btnConfirm_JIS.Enabled = false;
                btnConfirm_JIT.Enabled = false;

                _DlvConfirmHeaderJISList.ControlGrid(2);
                _DlvConfirmHeaderJITList.ControlGrid(2);
            }

            if (rdgDLV_STATUS.EditValue?.ToString() == DLV_STATUS_READY && LoginMenuAuthModel.UPDATE_AUTH == true)
            {
                lueCAR_NO_JIS.ReadOnly = false;
                //dteDLV_DT_JIS.ReadOnly = false;
                tseDLV_TM_JIS.ReadOnly = false;

                //dteDLV_DT_JIT.ReadOnly = false;
                tseDLV_TM_JIT.ReadOnly = false;
            }
            else
            {
                lueCAR_NO_JIS.ReadOnly = true;
                //dteDLV_DT_JIS.ReadOnly = true;
                tseDLV_TM_JIS.ReadOnly = true;

                //dteDLV_DT_JIT.ReadOnly = true;
                tseDLV_TM_JIT.ReadOnly = true;
            }
        }

        private void lueCAR_NO_JIS_EditValueChanged(object sender, EventArgs e)
        {
            if (lueCAR_NO_JIS.EditValue?.ToString() != string.Empty)
            {
                txtDRIV_NM_JIS.Text = lueCAR_NO_JIS.GetColumnValue("DRIV_NM")?.ToString();
                txtPHONE_NO_JIS.Text = lueCAR_NO_JIS.GetColumnValue("PHONE_NO")?.ToString();
            }
            else
            {
                txtDRIV_NM_JIS.Text = string.Empty;
                txtPHONE_NO_JIS.Text = string.Empty;
            }
        }
    }
}

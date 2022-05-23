using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PO.Mrp;
using BPack.Pocket.App.PO.Mrp;
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

namespace BPack.Carrying.App.PO.Mrp
{
    public partial class MrpMain : StrapMainForm
    {
        private MrpArgs _mrpArgs;
        private MrpPocket _mrpPocket;
        private MrpList _mrpList;
        private PorList _porList;
        private PorDetailList _porDetailList;
        private Dictionary<string, string> _mrhListHeader;
        private MrphModel _selectedMrphModel;
        private Timer _timer;

        public MrpMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _mrpArgs = new MrpArgs();
            _mrpPocket = new MrpPocket();
            _mrpList = new MrpList(_mrpArgs, _mrpPocket);
            _porList = new PorList(_mrpArgs, _mrpPocket);
            _porDetailList = new PorDetailList(_mrpArgs, _mrpPocket);
            AddSubForm(this, _mrpList, layoutControlGroup2);
            AddSubForm(this, _porList, layoutControlGroup3);
            AddSubForm(this, _porDetailList, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _mrpArgs,
                InitlistForm = _mrpList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            this.SelectedSubFormChanged += MrpMain_SelectedSubFormChanged;
            _porList.ModelSelectedEvent += PorList_ModelSelectedEvent;
            _porList.ModelAddedEvent += PorList_ModelAddedEvent;
            _porList.ModelDeletedEvent += PorList_ModelDeletedEvent;

            _mrhListHeader = new Dictionary<string, string>();
            _mrhListHeader.Add("MRH_NO", "MRH_NO");
            _mrhListHeader.Add("MRH_DTTM", "MRH_DTTM");
            _mrhListHeader.Add("MRH_STATUS", "MRH_STATUS");
            //LookUpEditHelper.SetByQuery(lueMrhNo, "PO.Mrp.MrpNoTopList.Select", null, _mrhListHeader , "MRH_NO", "DTTM_DESC", false, true, false);
            txtMrhNo.ReadOnly = true;
            txtMrhStatus.ReadOnly = true;
            DataRefreshMrpHeaderListAndSelect();
            btnAddPorData.Enabled = false;
            btnConfirmPor.Enabled = false;
            btnCancelPor.Enabled = false;
            btnMrpHist.Enabled = false;
            chkAgent.CheckState = CheckState.Unchecked;
            chkAgent.CheckedChanged += ChkAgent_CheckedChanged;
            //테스트버튼 숨김
            if (this.AuthModel.GROUP_USER_ID.Contains("ROOT"))
            {
                locBtnAuto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                locBtnAuto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            if (this.AuthModel.DUMMY1_AUTH == true)
            {
                locChkAgent.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
                locChkAgent.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void ChkAgent_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgent.CheckState == CheckState.Checked)
            {
                if (_timer == null)
                {
                    _timer = new Timer();
                    _timer.Interval = 60000;
                    _timer.Tick += Timer_Tick;
                    _timer.Enabled = true;
                }
                else
                {
                    _timer.Enabled = true;
                }
            }
            else
            {
                _timer.Enabled = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;
            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                return;
            }
            _timer.Enabled = false;
            BPack.Pocket.App.MI.CommonCodeManager.CommonCodeManagerPocket commonCodePocket = new Pocket.App.MI.CommonCodeManager.CommonCodeManagerPocket();
            var tm = commonCodePocket.SelectChildeCodeModels(new Model.App.MI.CommonCodeManager.CommonCodeManagerModelArgs
            {
                Select_Comp_Code = Common.LoginInfo.UserInfo.CompCode,
                Select_PCode = "MRP_SEND_TM"
            }); //부족자재발송시간
            string[] autoSendingDttm = tm.Where(a => a.VALID == true).Select(a => a.C_NAME).ToArray();

            if (autoSendingDttm.Contains(DateTime.Now.ToString("HH:mm"))) //현재시간과 비교하여 있으면 보냄
            {
                //System.Diagnostics.Debug.Print(DateTime.Now.ToString("HH:mm:ss"));
                AutoRunAndSendMail();
            }
            _timer.Enabled = true;
        }

        private void PorList_ModelAddedEvent(object sender, ArgsBase e)
        {
            _selectedMrphModel = _mrpPocket.SelectMrphModels(_mrpArgs.MrpModelArgs).SingleOrDefault();
            _mrpArgs.MrpModelArgs.Select_Mrh_No = _selectedMrphModel.MRH_NO;
            _mrpArgs.MrpModelArgs.Select_Mrh_Status = _selectedMrphModel.MRH_STATUS;
            txtMrhNo.Text = _selectedMrphModel.MRH_NO;
            txtMrhStatus.Text = _selectedMrphModel.MRH_STATUS;
        }

        private void PorList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _selectedMrphModel = _mrpPocket.SelectMrphModels(_mrpArgs.MrpModelArgs).SingleOrDefault();
            _mrpArgs.MrpModelArgs.Select_Mrh_No = _selectedMrphModel.MRH_NO;
            _mrpArgs.MrpModelArgs.Select_Mrh_Status = _selectedMrphModel.MRH_STATUS;
            txtMrhNo.Text = _selectedMrphModel.MRH_NO;
            txtMrhStatus.Text = _selectedMrphModel.MRH_STATUS;
        }


        private void DataRefreshMrpHeaderListAndSelect()
        {
            LookUpEditHelper.SetByQuery(lueMrhNo, "PO.Mrp.MrpNoTopList.Select", null, _mrhListHeader, "MRH_NO", "MRH_DTTM", false, true, false);
            _mrpArgs.MrpModelArgs.Select_Main_Mrh_No = lueMrhNo.EditValue?.ToString();
            _selectedMrphModel = _mrpPocket.SelectMrphModels(_mrpArgs.MrpModelArgs).SingleOrDefault();
            _mrpArgs.MrpModelArgs.Select_Mrh_No = _selectedMrphModel?.MRH_NO;
            _mrpArgs.MrpModelArgs.Select_Mrh_Status = _selectedMrphModel?.MRH_STATUS;
            txtMrhNo.Text = _selectedMrphModel?.MRH_NO;
            txtMrhStatus.Text = _selectedMrphModel?.MRH_STATUS;
        }

        private void MrpMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            ChangeEnable();
        }

        private void PorList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _mrpArgs.MrpModelArgs.Select_Por_No = ((PorModel)e.SelectedModelArgsBase.SelectedModelBase).POR_NO;
            _mrpArgs.MrpModelArgs.Select_Por_Status = ((PorModel)e.SelectedModelArgsBase.SelectedModelBase).POR_STATUS;
            _mrpArgs.MrpModelArgs.Select_Por_Mrh_No = ((PorModel)e.SelectedModelArgsBase.SelectedModelBase).MRH_NO;
            ChangeEnable();
            _porDetailList.DataRefresh(_mrpArgs);
        }

        private void ChangeEnable()
        {
            if (this.SelectedSubForm == _mrpList)
            {
                SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, delete: false, save: false);
                if (_mrpArgs.MrpModelArgs.Select_Por_Status != null && _mrpArgs.MrpModelArgs.Select_Por_Status.Equals("WAIT"))
                {
                    btnAddPorData.Enabled = true;
                    btnConfirmPor.Enabled = true;
                    btnCancelPor.Enabled = false;
                    btnMrpHist.Enabled = false;
                }
                else
                {
                    btnAddPorData.Enabled = false;
                    btnConfirmPor.Enabled = false;
                    btnMrpHist.Enabled = true;
                    if (_mrpArgs.MrpModelArgs.Select_Por_Status != null && _mrpArgs.MrpModelArgs.Select_Por_Status.Equals("OPEN"))
                    {
                        btnCancelPor.Enabled = true;
                    }
                    else
                    {
                        btnCancelPor.Enabled = false;
                    }
                }
            }
            if (this.SelectedSubForm == _porList)
            {
                if (_mrpArgs.MrpModelArgs.Select_Por_Status != null && _mrpArgs.MrpModelArgs.Select_Por_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: true, edit: true, delete: true, save: false);
                    btnAddPorData.Enabled = true;
                    btnConfirmPor.Enabled = true;
                    btnCancelPor.Enabled = false;
                    btnMrpHist.Enabled = false;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: true, edit: false, delete: false, save: false);
                    btnAddPorData.Enabled = false;
                    btnConfirmPor.Enabled = false;
                    btnMrpHist.Enabled = true;
                    if (_mrpArgs.MrpModelArgs.Select_Por_Status != null && _mrpArgs.MrpModelArgs.Select_Por_Status.Equals("OPEN"))
                    {
                        btnCancelPor.Enabled = true;
                    }
                    else
                    {
                        btnCancelPor.Enabled = false;
                    }
                }
            }
            if (this.SelectedSubForm == _porDetailList)
            {
                if (_mrpArgs.MrpModelArgs.Select_Por_Status != null && _mrpArgs.MrpModelArgs.Select_Por_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, delete: true, save: false);
                    btnAddPorData.Enabled = true;
                    btnConfirmPor.Enabled = true;
                    btnMrpHist.Enabled = false;
                }
                else
                {
                    btnAddPorData.Enabled = false;
                    btnMrpHist.Enabled = true;
                    SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, delete: false, save: false);
                    if (_mrpArgs.MrpModelArgs.Select_Por_Status != null && _mrpArgs.MrpModelArgs.Select_Por_Status.Equals("OPEN"))
                    {
                        btnCancelPor.Enabled = true;
                    }
                    else
                    {
                        btnCancelPor.Enabled = false;
                    }
                }
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _mrpArgs.MrpModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _mrpArgs.MrpModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;

            if (lueMrhNo.GetColumnValue("MRH_DTTM") == null)
            {
                return;
            }
            _mrpArgs.MrpModelArgs.Select_Main_Mrh_No = lueMrhNo.EditValue?.ToString();
            _mrpArgs.MrpModelArgs.Select_Main_Mrh_Dttm = lueMrhNo.GetColumnValue("MRH_DTTM").ToString();
            _selectedMrphModel = _mrpPocket.SelectMrphModels(_mrpArgs.MrpModelArgs).SingleOrDefault();
            _mrpArgs.MrpModelArgs.Select_Mrh_No = _selectedMrphModel.MRH_NO;
            _mrpArgs.MrpModelArgs.Select_Mrh_Status = _selectedMrphModel.MRH_STATUS;
            txtMrhNo.Text = _selectedMrphModel.MRH_NO;
            txtMrhStatus.Text = _selectedMrphModel.MRH_STATUS;

            base.Refresh_From_ExecuteByRibbonButton();

            _porList.DataRefresh(_mrpArgs);
            btnAddPorData.Enabled = false;
            btnConfirmPor.Enabled = false;
            btnCancelPor.Enabled = false;
            btnMrpHist.Enabled = false;
        }
        //구매요청서 조회 버튼
        private void btnPorSearch_Click(object sender, EventArgs e)
        {
            _mrpArgs.MrpModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _mrpArgs.MrpModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _porList.DataRefresh(_mrpArgs);
        }

        //구매요청 데이터 생성 버튼
        private void btnAddPorData_Click(object sender, EventArgs e)
        {
            if (!_selectedMrphModel.MRH_STATUS.Equals("OPEN"))  //MRP 헤더 OPEN이 아니면 구매요청데이터는 추가할수 없다
            {
                StrapMessageBox.Show("A002", 38); //이미 사용된 데이터입니다. 자재소요계획 재생성 혹은 구매요청서 취소후 일괄등록 가능합니다.
                return;
            }

            List<PorDetailModel> newPorDetailModels = new List<PorDetailModel>();
            CommonMes.Controls.ItemMaster.ItemMasterPocket imp = new CommonMes.Controls.ItemMaster.ItemMasterPocket();
            CommonMes.Controls.ItemMaster.ItemMasterModelArgs impArgs = new CommonMes.Controls.ItemMaster.ItemMasterModelArgs();
            foreach (var toPorItem in _mrpList.ToPorItems)
            {
                impArgs.Select_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
                impArgs.Select_Plant_Cd = Common.LoginInfo.UserInfo.PlantCode;
                impArgs.Select_Item_Cd = toPorItem.ITEM_CD;
                var itemInfo = imp.SelectItemMasterModel(impArgs);
                newPorDetailModels.Add(new PorDetailModel
                {
                    COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                    PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                    ITEM_CD = toPorItem.ITEM_CD,
                    ITEM_GR_1 = itemInfo.ITEM_GR_1,
                    ITEM_NM = itemInfo.ITEM_NM,
                    PUR_SIZE = itemInfo.PUR_SIZE,
                    POE_DUE_DT = toPorItem.DUE_DT,
                    POE_QTY = ConvertPurSize(itemInfo.PUR_SIZE, toPorItem.TO_POR_QTY),
                    POR_NO = _mrpArgs.MrpModelArgs.Select_Por_No,
                    CREATE_DTTM = DateTime.Now,
                    CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    MODIFY_DTTM = DateTime.Now,
                    MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                    LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                    POE_STATUS = "WAIT",
                    RowState = Common.Model.RowState.Added
                });
            }
            _porDetailList.AddPorData(newPorDetailModels);
        }

        private decimal ConvertPurSize(decimal purSize, decimal poeQty)
        {
            var quo = Convert.ToInt32(poeQty) / Convert.ToInt32(purSize);
            decimal convertPoeQty;
            var mod = poeQty % purSize;
            if (mod > 0)
            {
                convertPoeQty = (quo + 1) * purSize;
            }
            else
            {
                convertPoeQty = quo * purSize;
            }
            return convertPoeQty;
        }

        //자재소요계획 실행
        private void btnRunMrp_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("A001", 24, MessageBoxButtons.YesNo) == DialogResult.Yes) //현재시간 기준으로 자재소요계획 데이터를 다시 생성합니다.
            {
                StrapSplashScreenManager splash = new StrapSplashScreenManager(new StrapWaitForm());
                splash.ShowWaitForm();
                try
                {
                    _mrpPocket.BpRunMrp(_mrpArgs.MrpModelArgs);
                    DataRefreshMrpHeaderListAndSelect();
                    _mrpList.DataRefresh(_mrpArgs);
                    _porList.DataRefresh(_mrpArgs);
                    _porDetailList.DataClear(_mrpArgs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
                finally
                {
                    splash.CloseWaitForm();
                }
            }
        }
        //확정 버튼 - 구매요청서
        private void btnConfirmPor_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("A001", 20, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택행 확정처리 합니다.
            {
                try
                {
                    _mrpArgs.MrpModelArgs.Select_New_Por_Status = "OPEN";
                    _mrpPocket.BpConfirmOrCancelPor(_mrpArgs.MrpModelArgs);
                    DataRefreshMrpHeaderListAndSelect();
                    _porList.DataRefresh(_mrpArgs);
                    _porDetailList.DataClear(_mrpArgs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }
        }
        //확정 취소 버튼 - 구매요청서
        private void btnCancelPor_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("A001", 83, MessageBoxButtons.YesNo) == DialogResult.Yes) //확정 취소 합니다.
            {
                try
                {
                    _mrpArgs.MrpModelArgs.Select_New_Por_Status = "WAIT";
                    _mrpPocket.BpConfirmOrCancelPor(_mrpArgs.MrpModelArgs);
                    DataRefreshMrpHeaderListAndSelect();
                    _porList.DataRefresh(_mrpArgs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }
        }

        private void btnMrpHist_Click(object sender, EventArgs e)
        {
            StrapSplashScreenManager splash = new StrapSplashScreenManager(new StrapWaitForm());
            try
            {
                splash.ShowWaitForm();
                MrpArgs mrpArgs = new MrpArgs();
                MrpPocket mrpPocket = new MrpPocket();
                mrpArgs.MrpModelArgs.Select_Main_Mrh_No = _mrpArgs.MrpModelArgs.Select_Por_Mrh_No;
                mrpArgs.MrpModelArgs.Select_Mrh_No = _mrpArgs.MrpModelArgs.Select_Por_Mrh_No;
                MrpList mrpList = new MrpList(mrpArgs, mrpPocket);
                mrpList.Text = "MRP History";
                mrpList.IconOptions.ShowIcon = false;
                mrpList.InitStrap();
                mrpList.Size = this.Size;
                mrpList.DataRefresh(mrpArgs);
                mrpList.StartPosition = FormStartPosition.CenterParent;
                splash.CloseWaitForm();
                mrpList.ShowDialog();
            }
            catch (Exception ex)
            {
                splash.CloseWaitForm();
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
        }
        //자동계산 메일발송 버튼
        private void btnAuto_Click(object sender, EventArgs e)
        {
            AutoRunAndSendMail(true);
        }

        private void AutoRunAndSendMail(bool isTest = false)
        {
            _mrpArgs.IsAutoRunAndSendMailMode = true;
            try
            {
                if (!isTest)
                {
                    //계산 및 데이터 갱신
                    _mrpPocket.BpRunMrp(_mrpArgs.MrpModelArgs);
                    DataRefreshMrpHeaderListAndSelect();
                    _mrpArgs.MrpModelArgs.Select_Main_Mrh_No = lueMrhNo.EditValue?.ToString();
                    _mrpArgs.MrpModelArgs.Select_Main_Mrh_Dttm = lueMrhNo.GetColumnValue("MRH_DTTM").ToString();
                    _mrpList.DataRefresh(_mrpArgs);
                    //_porList.DataRefresh(_mrpArgs);
                    //_porDetailList.DataClear(_mrpArgs);
                }

                //메일보내기
                BPack.Pocket.App.MI.CommonCodeManager.CommonCodeManagerPocket commonCodePocket = new Pocket.App.MI.CommonCodeManager.CommonCodeManagerPocket();
                var mailList = commonCodePocket.SelectChildeCodeModels(new Model.App.MI.CommonCodeManager.CommonCodeManagerModelArgs
                {
                    Select_Comp_Code = Common.LoginInfo.UserInfo.CompCode,
                    Select_PCode = "MAIL_LIST_MRP"
                }); //공통코드에 받는사람 메일리스트
                var arrMailList = mailList.Where(a => a.VALID == true).Select(a => a.C_CODE).ToArray();
                var strMailList = string.Join(";", arrMailList);
                string mailTitle = StrapMessageBox.GetMessage("A001", 51); //DYA MES - 부족자재현황
                string body = _mrpList.GetMailBody();
                if (!string.IsNullOrEmpty(body))
                {
                    _mrpPocket.SendMail(strMailList, $"{ mailTitle } ({_mrpArgs.MrpModelArgs.Select_Main_Mrh_Dttm})", body, "HTML");
                }
            }
            catch (Exception ex)
            {
                var errMsg = Common.Command.ExceptionProcess.AlertMessage(ex);
                //StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                try
                {
                    //메일보내기
                    BPack.Pocket.App.MI.CommonCodeManager.CommonCodeManagerPocket commonCodePocket = new Pocket.App.MI.CommonCodeManager.CommonCodeManagerPocket();
                    var mailList = commonCodePocket.SelectChildeCodeModels(new Model.App.MI.CommonCodeManager.CommonCodeManagerModelArgs
                    {
                        Select_Comp_Code = Common.LoginInfo.UserInfo.CompCode,
                        Select_PCode = "MAIL_LIST_MRP"
                    }); //공통코드에 받는사람 메일리스트
                    var arrMailList = mailList.Where(a => a.VALID == true).Select(a => a.C_CODE).ToArray();
                    var strMailList = string.Join(";", arrMailList);
                    string errMailTitle = StrapMessageBox.GetMessage("A001", 54); //DYA MES - 부족자재현황(기준정보 및 계획 확인 요망)
                    string errMailBodyTitle = StrapMessageBox.GetMessage("A001", 55); //아래 내용으로 인해 자재소요계획을 생성하지 못하였습니다.
                    errMsg = $"{errMailBodyTitle}\r\n" + errMsg;
                    _mrpPocket.SendMail(strMailList, errMailTitle, errMsg, "TEXT");
                }
                catch (Exception ex1)
                {
                    Common.Command.ExceptionProcess.AlertMessage(ex1);
                }
                finally
                {
                    _mrpArgs.IsAutoRunAndSendMailMode = false;
                }
            }
            finally
            {
                _mrpArgs.IsAutoRunAndSendMailMode = false;
            }


        }
        protected override void OnClosed(EventArgs e)
        {
            if (_timer != null)
            {
                _timer.Enabled = false;
                _timer.Dispose();
            }
            base.OnClosed(e);
        }
    }
}

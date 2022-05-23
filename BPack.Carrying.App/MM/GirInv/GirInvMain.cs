using BPack.Carrying.Core.CommonLib;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.GirInv;
using BPack.Pocket.App.MM.GirInv;
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

namespace BPack.Carrying.App.MM.GirInv
{
    public partial class GirInvMain : StrapMainForm
    {
        private GirInvArgs _girInvArgs;
        private GirInvPocket _girInvPocket;
        private InvList _invList;
        private InvDetailList _invDetailList;
        private StockList _stockList;

        public GirInvMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _girInvArgs = new GirInvArgs();
            _girInvPocket = new GirInvPocket();
            _invList = new InvList(_girInvArgs, _girInvPocket);
            _invDetailList = new InvDetailList(_girInvArgs, _girInvPocket);
            
            AddSubForm(this, _invList, layoutControlGroup2);
            AddSubForm(this, _invDetailList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _girInvArgs,
                InitlistForm = _invList,
                IsAutoDataRefreshOnShown = true,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            this.SelectedSubFormChanged += GirInvMain_SelectedSubFormChanged;
            _invList.ModelSelectedEvent += InvList_ModelSelectedEvent;
            _invList.ModelDeletedEvent += InvList_ModelDeletedEvent;
            _invList.AddRefreshTargetSubForm(_invDetailList);
            LookUpEditHelper.SetWareHouse(lupWareHouse, Common.LoginInfo.UserInfo.CompCode, Common.LoginInfo.UserInfo.PlantCode);
            LookUpEditHelper.SetByQuery(lupItemGr1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
            dteLastCloseDt.Enabled = false;
        }

        private void InvList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            Refresh_From_ExecuteByRibbonButton();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            dteLastCloseDt.DateTime = _girInvPocket.GetLastCloseDt(_girInvArgs.GirInvModelArgs);
        }

        private void GirInvMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            ChangeEnable();
        }

        private void ChangeEnable()
        {
            if (this.SelectedSubForm == _invList)
            {
                if (_girInvArgs.GirInvModelArgs.Select_Inv_Status != null
                    && _girInvArgs.GirInvModelArgs.Select_Inv_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: false);
                    btnOpenInv.Enabled = true;
                    btnOpenCancel.Enabled = false;
                    btnAdjust.Enabled = false;
                    btnSelectItem.Enabled = true;
                }
                else if (_girInvArgs.GirInvModelArgs.Select_Inv_Status != null
                   && _girInvArgs.GirInvModelArgs.Select_Inv_Status.Equals("OPEN"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save: false);
                    btnOpenInv.Enabled = false;
                    btnOpenCancel.Enabled = true;
                    btnAdjust.Enabled = true;
                    btnSelectItem.Enabled = false;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: false, save: false);
                    btnOpenInv.Enabled = false;
                    btnOpenCancel.Enabled = false;
                    btnAdjust.Enabled = false;
                    btnSelectItem.Enabled = false;
                }
            }
            if (this.SelectedSubForm == _invDetailList)
            {
                if (_girInvArgs.GirInvModelArgs.Select_Inv_Status != null
                    && _girInvArgs.GirInvModelArgs.Select_Inv_Status.Equals("WAIT"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save: true);
                    btnSelectItem.Enabled = true;
                }
                else if (_girInvArgs.GirInvModelArgs.Select_Inv_Status != null
                   && _girInvArgs.GirInvModelArgs.Select_Inv_Status.Equals("OPEN"))
                {
                    SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save: true);
                    btnSelectItem.Enabled = false;
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: true);
                    btnSelectItem.Enabled = false;
                }
            }
        }

        private void InvList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            InvModel invModel = (InvModel)e.SelectedModelArgsBase.SelectedModelBase;
            _girInvArgs.GirInvModelArgs.Select_Inv_No = invModel.INV_NO;
            _girInvArgs.GirInvModelArgs.Select_Inv_Status = invModel.INV_STATUS;
            _girInvArgs.GirInvModelArgs.Select_Wh_Cd = invModel.WH_CD;
            _girInvArgs.GirInvModelArgs.Select_Inv_Gir_Dt = invModel.INV_GIR_DT;
            _girInvArgs.GirInvModelArgs.Select_Is_Include_After_Gir = invModel.IS_INCLUDE_AFTER_GIR;
            ChangeEnable();
            _invDetailList.DataRefresh(_girInvArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _girInvArgs.GirInvModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _girInvArgs.GirInvModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _girInvArgs.GirInvModelArgs.Select_Main_Wh_Cd = lupWareHouse.EditValue?.ToString();
            _girInvArgs.GirInvModelArgs.Select_Main_Item_Cd = textEdit1.EditValue?.ToString();
            _girInvArgs.GirInvModelArgs.Select_Main_Item_Nm = textEdit2.EditValue?.ToString();
            _girInvArgs.GirInvModelArgs.Select_Main_Item_Gr_1 = lupItemGr1.EditValue?.ToString();
            _girInvArgs.GirInvModelArgs.Select_Inv_No = null;
            _girInvArgs.GirInvModelArgs.Select_Inv_Status = null;
            btnOpenInv.Enabled = false;
            btnOpenCancel.Enabled = false;
            btnAdjust.Enabled = false;
            btnSelectItem.Enabled = false;
            dteLastCloseDt.DateTime = _girInvPocket.GetLastCloseDt(_girInvArgs.GirInvModelArgs);
            base.Refresh_From_ExecuteByRibbonButton();
        }

        //품목선택 버튼
        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            _stockList = new StockList(_girInvArgs, _girInvPocket);
            _stockList.OkButtonClick += StockList_OkButtonClick;
            _stockList.DataRefresh();
            _stockList.StartPosition = FormStartPosition.CenterScreen;
            _stockList.ShowDialog();
        }

        private void StockList_OkButtonClick(object sender, StockList.OkButtonClickEventArgs e)
        {
            try
            {
                _invDetailList.AddItem(e.SelectedStockModels);
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }
            
        }
        //실사진행 버튼
        private void btnOpenInv_Click(object sender, EventArgs e)
        {
            if (!_invDetailList.SelectedModels.Any())
            {
                StrapMessageBox.Show("A002", 26); //실사할 품목이 존재하지 않습니다. 품목을 추가 등록바랍니다.
                return;
            }
            
            if (StrapMessageBox.Show("A001", 100, MessageBoxButtons.YesNo) == DialogResult.Yes) //"선택 행 실사를 진행합니다. 실사진행시 해당창고의 실사중인 품목은 수불처리가 불가능 합니다."
            {
                try
                {
                    //_invList.OpenInv();
                    _girInvPocket.BpOpenInv(_girInvArgs.GirInvModelArgs);
                    _invList.DataRefresh(_girInvArgs);
                    _girInvArgs.GirInvModelArgs.Select_Inv_Status = "OPEN";
                    _invDetailList.DataRefresh(_girInvArgs);
                    btnOpenInv.Enabled = false;
                    btnOpenCancel.Enabled = false;
                    btnAdjust.Enabled = false;
                    btnSelectItem.Enabled = false;
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex)); 
                }
                
            }
        }
        //실사진행 취소 버튼
        private void btnOpenCancel_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("A001", 105, MessageBoxButtons.YesNo) == DialogResult.Yes) //진행중인 실사를 취소합니다.
            {
                try
                {
                    _girInvPocket.BpOpenCancelInv(_girInvArgs.GirInvModelArgs);
                    _invList.DataRefresh(_girInvArgs);
                    _girInvArgs.GirInvModelArgs.Select_Inv_Status = "WAIT";
                    _invDetailList.DataRefresh(_girInvArgs);
                    btnOpenInv.Enabled = false;
                    btnOpenCancel.Enabled = false;
                    btnAdjust.Enabled = false;
                    btnSelectItem.Enabled = false;
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }

            }
        }
        //조정반영 버튼
        private void btnAdjust_Click(object sender, EventArgs e)
        {
            if (StrapMessageBox.Show("A001", 101, MessageBoxButtons.YesNo) == DialogResult.Yes) //"조정반영 처리합니다. 전산재고를 실재고 수량으로 반영하기 위해 과부족 수량만큼 입/ 출고를 등록합니다."
            {
                try
                {
                    _girInvPocket.BpAdjustInv(_girInvArgs.GirInvModelArgs);
                    _invList.DataRefresh(_girInvArgs);
                    _invDetailList.DataRefresh(_girInvArgs);
                    btnOpenInv.Enabled = false;
                    btnOpenCancel.Enabled = false;
                    btnAdjust.Enabled = false;
                    btnSelectItem.Enabled = false;
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }

            }
        }
        //재고마감 바로가기
        private void btnGoGirClose_Click(object sender, EventArgs e)
        {
            OpenFormByMainForm("GirClose");
            
        }
    }
}

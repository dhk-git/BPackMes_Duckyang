using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.InvAdjust;
using BPack.Pocket.App.MM.InvAdjust;
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

namespace BPack.Carrying.App.MM.InvAdjust
{
    public partial class InvAdjustMain : StrapMainForm
    {
        private InvAdjustArgs _invAdjustArgs;
        private InvAdjustPocket _invAdjustPocket;
        private InvAdjOrderList _invAdjOrderList;
        private InvAdjDetailList _invAdjDetailList;
        private InvAdjItemList _invAdjItemList;
        private InvAdjHuList _invAdjHuList;
        public InvAdjustMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _invAdjustArgs = new InvAdjustArgs();
            _invAdjustPocket = new InvAdjustPocket();
            _invAdjOrderList = new InvAdjOrderList(_invAdjustArgs, _invAdjustPocket);
            _invAdjDetailList = new InvAdjDetailList(_invAdjustArgs, _invAdjustPocket);
            _invAdjItemList = new InvAdjItemList(_invAdjustArgs, _invAdjustPocket);
            _invAdjHuList = new InvAdjHuList(_invAdjustArgs, _invAdjustPocket);
            AddSubForm(this, _invAdjOrderList, layoutControlGroup2);
            AddSubForm(this, _invAdjDetailList, layoutControlGroup3);
            AddSubForm(this, _invAdjItemList, layoutControlGroup4);
            AddSubForm(this, _invAdjHuList, layoutControlGroup5);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _invAdjustArgs,
                InitlistForm = _invAdjOrderList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });
            strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            strapLookUpEdit2.EditValueChanged += StrapLookUpEdit2_EditValueChanged;
            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, isFirstSelect: true);
            LookUpEditHelper.SetSysCode(strapLookUpEdit2, "INV_GR", total: false, isFirstSelect: true);
            InitRibbonButtons(true);
            _invAdjOrderList.ModelSelectedEvent += InvAdjOrderList_ModelSelectedEvent;
            _invAdjDetailList.ModelSelectedEvent += InvAdjDetailList_ModelSelectedEvent;
            _invAdjItemList.ModelSelectedEvent += InvAdjItemList_ModelSelectedEvent;
            this.SelectedSubFormChanged += InvAdjustMain_SelectedSubFormChanged;
            _invAdjHuList.AdjHuSaved += InvAdjHuList_AdjHuSaved;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _invAdjustArgs.InvAdjustModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _invAdjustArgs.InvAdjustModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void StrapLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            _invAdjustArgs.InvAdjustModelArgs.Select_Main_Taget_Inv_Gr = strapLookUpEdit2.EditValue?.ToString();
        }

        private void InvAdjHuList_AdjHuSaved(object sender, EventArgs e)
        {
            _invAdjItemList.DataRefresh(_invAdjustArgs);
            _invAdjItemList.SetPreRowSelect();
        }

        private void InvAdjustMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _invAdjHuList)
            {
                if (_invAdjustArgs.InvAdjustModelArgs.Select_Invd_Status == "OPEN" || _invAdjustArgs.InvAdjustModelArgs.Select_Invd_Status == "WAIT")
                {
                    SetRibbonButtonsEnable_ByAuth(refresh: true, add: true, save: true, delete: true);
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(refresh: true, add: false, save: false, delete: false);
                }
                
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(refresh: true, add: false, save: false, delete: false);
            }
        }
        private void InvAdjDetailList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _invAdjustArgs.InvAdjustModelArgs.Select_Invd_No = ((InvAdjDetailModel)e.SelectedModelArgsBase.SelectedModelBase).INVD_NO;
            _invAdjustArgs.InvAdjustModelArgs.Select_Item_Cd = null;
            _invAdjustArgs.InvAdjustModelArgs.Select_Invd_Status = ((InvAdjDetailModel)e.SelectedModelArgsBase.SelectedModelBase).INVD_STATUS;
            if (_invAdjustArgs.InvAdjustModelArgs.Select_Invd_Status == "OPEN" || _invAdjustArgs.InvAdjustModelArgs.Select_Invd_Status == "WAIT")
            {
                strapButton1.Enabled = true;
            }
            else
            {
                strapButton1.Enabled = false;
            }
            _invAdjItemList.DataRefresh(_invAdjustArgs);
            _invAdjHuList.DataRefresh(_invAdjustArgs);
        }

        private void InvAdjItemList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _invAdjustArgs.InvAdjustModelArgs.Select_Item_Cd = ((InvAdjItemModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
            _invAdjHuList.DataRefresh(_invAdjustArgs);
        }

        private void InvAdjOrderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _invAdjustArgs.InvAdjustModelArgs.Select_Inv_No = ((InvAdjOrderModel)e.SelectedModelArgsBase.SelectedModelBase).INV_NO;
            //_invAdjustArgs.InvAdjustModelArgs.Select_Inv_Type = ((InvOrderModel)e.SelectedModelArgsBase.SelectedModelBase).INV_TYPE;
            //_invAdjustArgs.InvAdjustModelArgs.Select_Inv_Status = ((InvOrderModel)e.SelectedModelArgsBase.SelectedModelBase).INV_STATUS;
            _invAdjDetailList.DataRefresh(_invAdjustArgs);
            _invAdjItemList.DataClear(_invAdjustArgs);
            _invAdjHuList.DataClear(_invAdjustArgs);
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            _invAdjustArgs.InvAdjustModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
        }
        //선택행 일괄 등록
        private void strapButton1_Click(object sender, EventArgs e)
        {
            var selectedInvAdjHuModels = _invAdjHuList.GetSelectedInvAdjHuModels();
            if (selectedInvAdjHuModels.Count == 0)
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }
            if (StrapMessageBox.Show("A001", 64, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택된 행을 전산재고와 동일하게 실사등록 처리합니다.
            {
                try
                {
                    _invAdjHuList.AddInvResultLikeLogi(selectedInvAdjHuModels);
                    _invAdjItemList.DataRefresh(_invAdjustArgs);
                    _invAdjHuList.DataRefresh(_invAdjustArgs);
                    _invAdjItemList.SetPreRowSelect();
                    StrapMessageBox.Show("A001", 12); //등록되었습니다.
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        //선택행 실사반영 버튼
        private void strapButton2_Click(object sender, EventArgs e)
        {
            var selectedInvAdjDetailModels = _invAdjDetailList.GetSelectedInvAdjDetailModels();
            if (selectedInvAdjDetailModels.Count == 0)
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }
            if (selectedInvAdjDetailModels.Where(a => a.INVD_STATUS.Equals("ADJUST")).ToList().Count > 0)
            {
                StrapMessageBox.Show("A001", 62); //조정완료건이 선택되어있습니다.\r\n조정완료건은 제외바랍니다.
                return;
            }
            if (StrapMessageBox.Show("A001", 63, MessageBoxButtons.YesNo) == DialogResult.Yes) //"선택된 행 실사반영 처리합니다."
            {
                try
                {
                    _invAdjDetailList.AdjustInvDetail(selectedInvAdjDetailModels);
                    _invAdjDetailList.DataRefresh(_invAdjustArgs);
                    StrapMessageBox.Show("A001", 12); //등록되었습니다.
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}

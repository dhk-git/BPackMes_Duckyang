using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.InvOrder;
using BPack.Pocket.App.MM.InvOrder;
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

namespace BPack.Carrying.App.MM.InvOrder
{
    public partial class InvOrderMain : StrapMainForm
    {
        private InvOrderArgs _invOrderArgs;
        private InvOrderPocket _invOrderPocket;
        private InvOrderList _invOrderList;
        private InvDetailList _invDetailList;
        private InvItemList _invItemList;
        private InvHuList _invHuList;

        public InvOrderMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _invOrderArgs = new InvOrderArgs();
            _invOrderPocket = new InvOrderPocket();
            _invOrderList = new InvOrderList(_invOrderArgs, _invOrderPocket);
            _invDetailList = new InvDetailList(_invOrderArgs, _invOrderPocket);
            _invItemList = new InvItemList(_invOrderArgs, _invOrderPocket);
            _invHuList = new InvHuList(_invOrderArgs, _invOrderPocket);
            AddSubForm(this, _invOrderList, layoutControlGroup2);
            AddSubForm(this, _invDetailList, layoutControlGroup4);
            AddSubForm(this, _invItemList, layoutControlGroup3);
            AddSubForm(this, _invHuList, layoutControlGroup5);
            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _invOrderArgs,
                InitlistForm = _invOrderList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });
            strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            strapLookUpEdit2.EditValueChanged += StrapLookUpEdit2_EditValueChanged;
            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, isFirstSelect: true);
            LookUpEditHelper.SetSysCode(strapLookUpEdit2, "INV_GR", total: false, isFirstSelect: true);

            InitRibbonButtons(true, true, true, true);
            _invOrderList.ModelSelectedEvent += InvOrderList_ModelSelectedEvent;
            _invDetailList.ModelSelectedEvent += InvDetailList_ModelSelectedEvent;
            _invItemList.ModelSelectedEvent += InvItemList_ModelSelectedEvent;
            this.SelectedSubFormChanged += InvOrderMain_SelectedSubFormChanged;
        }

        private void StrapLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            _invOrderArgs.InvOrderModelArgs.Select_Main_Target_Inv_Gr = strapLookUpEdit2.EditValue?.ToString();
        }

        private void InvOrderMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _invOrderList || this.SelectedSubForm == _invDetailList)
            {
                SetRibbonButtonsEnable_ByAuth(true, true, true, true);
                //if (this.SelectedSubForm == _invDetailList)
                //{
                //    if (_invOrderArgs.InvOrderModelArgs.Select_Inv_Type == "TOTAL")
                //    {
                //        SetRibbonButtonsEnable_ByAuth(true, false, false, false);
                //    }
                //}
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(true, false, false, false);
            }
        }

        private void InvItemList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _invOrderArgs.InvOrderModelArgs.Select_Item_Cd = ((InvItemModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
            _invHuList.DataRefresh(_invOrderArgs);
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            _invOrderArgs.InvOrderModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
        }

        private void InvDetailList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _invOrderArgs.InvOrderModelArgs.Select_Invd_No = ((InvDetailModel)e.SelectedModelArgsBase.SelectedModelBase).INVD_NO;
            _invOrderArgs.InvOrderModelArgs.Select_Item_Cd = null;
            _invItemList.DataRefresh(_invOrderArgs);
            _invHuList.DataRefresh(_invOrderArgs);
        }

        private void InvOrderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _invOrderArgs.InvOrderModelArgs.Select_Inv_No = ((InvOrderModel)e.SelectedModelArgsBase.SelectedModelBase).INV_NO;
            _invOrderArgs.InvOrderModelArgs.Select_Inv_Type = ((InvOrderModel)e.SelectedModelArgsBase.SelectedModelBase).INV_TYPE;
            _invOrderArgs.InvOrderModelArgs.Select_Inv_Status = ((InvOrderModel)e.SelectedModelArgsBase.SelectedModelBase).INV_STATUS;
            _invOrderArgs.InvOrderModelArgs.Select_Target_Wh_Cd = ((InvOrderModel)e.SelectedModelArgsBase.SelectedModelBase).TARGET_WH_CD;
            _invDetailList.DataRefresh(_invOrderArgs);
            _invItemList.DataClear(_invOrderArgs);
            _invHuList.DataClear(_invOrderArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _invOrderArgs.InvOrderModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _invOrderArgs.InvOrderModelArgs.Select_Main_End_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _invOrderArgs.InvOrderModelArgs.Select_Inv_No = null;
            base.Refresh_From_ExecuteByRibbonButton();
        }
        //선택행 강제종료
        private void strapButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_invOrderArgs.InvOrderModelArgs.Select_Inv_No))
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }
            if (_invOrderArgs.InvOrderModelArgs.Select_Inv_Status.Equals("ADJUST"))
            {
                StrapMessageBox.Show("A001", 62); //조정완료건이 선택되어있습니다.조정완료건은 제외바랍니다.
                return;
            }
            if (StrapMessageBox.Show("A001", 65, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택행 강제종료 합니다.
            {
                _invOrderList.DropSelectedInvOrder();
                _invOrderList.DataRefresh(_invOrderArgs);
            }
        }
        //지시확정 버튼
        private void strapButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_invOrderArgs.InvOrderModelArgs.Select_Inv_No))
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }
            if (_invOrderArgs.InvOrderModelArgs.Select_Inv_Status.Equals("OPEN"))
            {
                StrapMessageBox.Show("이미 확정된 실사지시입니다.");
                return;
            }
            if (_invOrderArgs.InvOrderModelArgs.Select_Inv_Status.Equals("ADJUST") || _invOrderArgs.InvOrderModelArgs.Select_Inv_Status.Equals("DROP"))
            {
                StrapMessageBox.Show("이미 종료된 실사지시입니다.");
                return;
            }
            if (StrapMessageBox.Show("재고실사지시를 확정합니다.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _invOrderList.OpenSelectedInvOrder();
                _invOrderList.DataRefresh(_invOrderArgs);
            }
        }
    }
}

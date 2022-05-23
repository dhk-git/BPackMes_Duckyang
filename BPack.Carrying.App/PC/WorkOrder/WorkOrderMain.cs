using BPack.Common.Pocket;
using BPack.Model.App.PC.WorkOrder;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WorkOrder;
using System;
using BPack.CommonMes.Helpers;
using BPack.Common.LoginInfo;
using System.Linq;
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.WorkOrder
{
    public partial class WorkOrderMain : StrapMainForm
    {
        private WorkOrderPocket _WorkOrderPocket;
        private WorkOrderArgs _WorkOrderArgs;
        private WorkOrderList _WorkOrderList;

        private WoMtrlList _WoMtrlList;
        private WorkBomTreeList _WorkBomTreeList;

        string trLang;

        public WorkOrderMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            De_Start_dt.EditValue = DateTime.Now;
            De_End_dt.EditValue = DateTime.Now.AddDays(+7);
            _WorkOrderArgs = new WorkOrderArgs();
            _WorkOrderPocket = new WorkOrderPocket();
            _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code = Common.LoginInfo.UserInfo.CompCode;

            _WorkOrderList = new WorkOrderList(_WorkOrderArgs, _WorkOrderPocket);
            _WoMtrlList = new WoMtrlList(_WorkOrderArgs, _WorkOrderPocket);
            _WorkBomTreeList = new WorkBomTreeList(_WorkOrderArgs, _WorkOrderPocket);

            AddSubForm(this, _WorkOrderList, layoutControlGroup2);

            AddSubForm(this, _WorkBomTreeList, layoutControlGroup3);
            AddSubForm(this, _WoMtrlList, layoutControlGroup4);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _WorkOrderArgs,
                InitlistForm = _WorkOrderList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(sleCompCd);

            sleCompCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
                _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code = sleCompCd.EditValue?.ToString();
            };

            slePlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetWorkCenter(
                    sleWC_cd,
                    sleCompCd.EditValue?.ToString()
                    , slePlantCd.EditValue?.ToString()
                    , isTotalRow: true, isFirstSelect: true);
                _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code = slePlantCd.EditValue?.ToString();
            };
            sleCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;



            _WorkOrderList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _WorkOrderArgs.WorkOrderModelArgs.WO_NO_KEY = ((WorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).WO_NO;
                _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code = ((WorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code = ((WorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;

                WorkOrderBomDataRefresh();
                _WoMtrlList.DataRefresh(_WorkOrderArgs);
                _WoMtrlList.SelectModelAndRaiseEvent(0);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _WorkOrderList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true); }

                //20211126 정수교 bom cud 금지(쿼리는 있음)
                if (this.SelectedSubForm == _WoMtrlList) { SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save:false); }
                if (this.SelectedSubForm == _WorkBomTreeList) { SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false); }

            };


            //2022.03.17 정수교 언어변환 
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup4.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup4.Text = trLang;
            }
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup3.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup3.Text = trLang;
            }



        }

        private void WorkOrderBomDataRefresh()
        {
            if (checkEdit2.Checked)
            {
                _WorkOrderArgs.WorkOrderModelArgs.Allow_Phantom = "Y";
            }
            else
            {
                _WorkOrderArgs.WorkOrderModelArgs.Allow_Phantom = "N";
            }

            _WorkBomTreeList.DataRefresh(_WorkOrderArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code = sleCompCd.EditValue?.ToString();
            _WorkOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code = slePlantCd.EditValue?.ToString();
            _WorkOrderArgs.WorkOrderModelArgs.WC_CD = sleWC_cd.EditValue?.ToString();
            _WorkOrderArgs.WorkOrderModelArgs.START_DT = De_Start_dt.DateTime;
            _WorkOrderArgs.WorkOrderModelArgs.END_DT = De_End_dt.DateTime;
            _WorkOrderArgs.WorkOrderModelArgs.ITEM_CD = stxtItemCd.EditValue?.ToString();
            _WorkOrderArgs.WorkOrderModelArgs.ITEM_NM = stxtItemNm.EditValue?.ToString();
            if (checkEdit1.Checked)
                _WorkOrderArgs.WorkOrderModelArgs.DEL_FG = "Y";
            else
                _WorkOrderArgs.WorkOrderModelArgs.DEL_FG = "N";
            base.Refresh_From_ExecuteByRibbonButton();

            //조회후 이벤트 발생 
            _WorkOrderList.SelectModelAndRaiseEvent(0);

        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            WorkOrderBomDataRefresh();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            var datas =_WorkOrderList.GetCheckedData();
            if (datas.Count < 1)
            {
                //선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                StrapMessageBox.Show("A001", 9);
                return;
            }
            if (datas.Exists(v => v.ORDER_STATUS == "CONFIRM"))
            {
                //todo 이미 확정된 작업지시가 있습니다.
                StrapMessageBox.Show("A001", 77);
                return;
            }
            //확인 후 저장 : 저장하시겠습니까?
            if (StrapMessageBox.Show("A001", 33, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _WorkOrderList.UpdateStatus_Confirm(datas);
                _WorkOrderList.DataRefresh(_WorkOrderArgs);
            }
            
        }

        private void Btn_Wait_Click(object sender, EventArgs e)
        {
            var datas = _WorkOrderList.GetCheckedData();
            if (datas.Count < 1)
            {
                //선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                StrapMessageBox.Show("A001", 9);
                return;
            }
            if (datas.Exists(v => v.ORDER_STATUS == "WAIT"))
            {
                //todo 이미 대기중인 작업지시가 있습니다.
                StrapMessageBox.Show("A001", 78);
                return;
            }
            //확인 후 저장 : 저장하시겠습니까?
            if (StrapMessageBox.Show("A001", 33, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _WorkOrderList.UpdateStatus_Wait(datas);
                _WorkOrderList.DataRefresh(_WorkOrderArgs);
            }
        }
    }
}

using BPack.Common.LoginInfo;
using BPack.CommonMes.Enums;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.OperationWeekPlan;
using BPack.Pocket.App.PC.OperationWeekPlan;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace BPack.Carrying.App.PC.OperationWeekPlan
{
    public partial class WeekMain : StrapMainForm
    {
        OperationWeekPlanArgs _weekPlanArgs;
        OperationWeekPlanPocket _weekPlanPocket;
        WeekList _weekList;

        WeekSumList _weekSumList;
        public WeekMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _weekPlanArgs = new OperationWeekPlanArgs();
            _weekPlanPocket = new OperationWeekPlanPocket();
            _weekList = new WeekList(_weekPlanArgs, _weekPlanPocket);
            _weekList.ChagneDetailPlan += _weekList_ChagneDetailPlan;
            _weekSumList = new WeekSumList(_weekPlanArgs, _weekPlanPocket);

            AddSubForm(this, _weekList, layoutControlGroup2);
            AddSubForm(this, _weekSumList, layoutControlGroup3);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _weekPlanArgs,
                InitlistForm = _weekList,
                //IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });

            InitRibbonButtons(true, save: true);

            //회사
            LookUpEditHelper.SetCompCode(ctl_ComCd);
            ctl_ComCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                //SetEditorValue(ctl_ComCd, ctl_ComCd.EditValue);
                LookUpEditHelper.SetPlantCode(ctl_PlantCd, new { COMP_CD = ctl_ComCd.EditValue?.ToString() }, isFirstSelect: true);
                _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
            };
            strapButtonEdit_ItemMaster1.InitStrap();
            //공장
            ctl_PlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                //SetEditorValue(ctl_ComCd, ctl_ComCd.EditValue);
                _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
                _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plant_Cd = ctl_PlantCd.EditValue?.ToString();

                //제품군
                LookUpEditHelper.SetByQuery(ctl_ItemGr, "MasterDataControls.Item.ItemGr1"
                    , new
                    {
                        COMP_CD = _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Comp_Cd
                            ,
                        PLANT_CD = _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plant_Cd
                    }
                    , "Code", "Name");
                strapButtonEdit_ItemMaster1.InitPlantCode(_weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plant_Cd);

            };
            //제품군
            ctl_ItemGr.EditValueChanged += (object sender, EventArgs e) =>
            {
                _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Item_Group_cd = ctl_ItemGr.EditValue?.ToString();
            };

            ctl_ComCd.EditValue = UserInfo.CompCode;
            ctl_PlantCd.EditValue = UserInfo.PlantCode;
            ctl_Plan_Start_dt.EditValueChanged += Ctl_Plan_Start_dt_EditValueChanged;
            ctl_Plan_Start_dt.EditValue = DateTime.Now;
            ctl_Confirm_dt.EditValue = DateTime.Now;

            if (DateTime.Now.AddMonths(3).Year == DateTime.Now.Year)
            {
                ctl_Plan_End_dt.EditValue = DateTime.Now.AddMonths(3);
            }
            else
            {
                ctl_Plan_End_dt.EditValue = new DateTime(DateTime.Now.Year, 12, 1);
            }

            
            strapButtonEdit_ItemMaster1.InitCompCode(UserInfo.CompCode);
            strapButtonEdit_ItemMaster1.InitPlantCode(UserInfo.PlantCode);

        }



        private void Ctl_Plan_Start_dt_EditValueChanged(object sender, EventArgs e)
        {
            ctl_Confirm_dt.EditValue = DateTime.Parse(ctl_Plan_Start_dt.DateTime.ToString("yyyy-MM-01"));
        }

        private void _weekList_ChagneDetailPlan(object sender, Model.App.PC.OperationWeekPlan.WeekPlanSumModel e)
        {
            checkedComboBoxEdit1.Properties.DataSource = e.headerGrModel;
            checkedComboBoxEdit1.Properties.ValueMember = "ITEM_CD";
            checkedComboBoxEdit1.Properties.DisplayMember = "ITEM_CD";
            checkedComboBoxEdit1.Properties.PopupWidthMode = PopupWidthMode.ContentWidth;
            checkedComboBoxEdit1.Properties.PopupFormMinSize = new Size(checkedComboBoxEdit1.Size.Width, 500);
            checkedComboBoxEdit1.CheckAll();

            _weekSumList.ChangeModel(e);


        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Comp_Cd
               = ctl_ComCd.EditValue?.ToString();
            _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plant_Cd
                = ctl_PlantCd.EditValue?.ToString();

            if (ctl_Plan_End_dt.DateTime.Year != ctl_Plan_Start_dt.DateTime.Year)
            {
                StrapMessageBox.Show("A001", 84);


            }

            DateTime Start_dt = new DateTime(ctl_Plan_Start_dt.DateTime.Year, ctl_Plan_Start_dt.DateTime.Month, 1);
            DateTime End_dt = new DateTime(ctl_Plan_End_dt.DateTime.Year, ctl_Plan_End_dt.DateTime.Month, 1);

            _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plan_Start_dt
                = Start_dt;
            _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plan_End_dt
                = End_dt;
            _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Item_Group_cd
                = ctl_ItemGr.EditValue?.ToString();
            _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Item_cd
                = strapButtonEdit_ItemMaster1.EditValue?.ToString();

            //원본데이터도 먼저 sum에 조회
            _weekSumList.DataRefresh(_weekPlanArgs);

            base.Refresh_From_ExecuteByRibbonButton();


        }


        private void Btn_CreatePlan_Click(object sender, EventArgs e)
        {
            DateTime Start_dt = new DateTime(ctl_Plan_Start_dt.DateTime.Year, ctl_Plan_Start_dt.DateTime.Month, 1);
            DateTime End_dt = new DateTime(ctl_Plan_End_dt.DateTime.Year, ctl_Plan_End_dt.DateTime.Month, 1);
            _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plan_Start_dt
                = Start_dt;
            _weekPlanArgs.OperationWeekPlanModelArgs.Select_Main_Plan_End_dt
                = End_dt;
            //계획 생성 팝업창
            WeekPlanItemSelector itemSeletor
                = new WeekPlanItemSelector(_weekPlanArgs.OperationWeekPlanModelArgs
                                , _weekPlanPocket);
            if (itemSeletor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _weekList.DataRefresh(_weekPlanArgs);
            }
        }

        //월간 계획 확정
        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            
            //변경된 내용이 있습니다 변경된 내용을 저장 후 처리하십시오.
            if (_weekList.GetChangedWeekModel().Count > 0)
            {
                StrapMessageBox.Show("A001", 96);
            }
            else
            {
                string Item_Cds=checkedComboBoxEdit1.EditValue?.ToString().Replace(", ", SysCode.Separator.Parameter);
                _weekList.WeekPlanConfirm(Item_Cds, ctl_Confirm_dt.DateTime, "CLOSE");
            }
        }

        //월간 계획 확정 취소
        private void Btn_ConfirmCancle_Click(object sender, EventArgs e)
        {
            string Item_Cds = checkedComboBoxEdit1.EditValue?.ToString().Replace(", ", SysCode.Separator.Parameter);
            _weekList.WeekPlanConfirm(Item_Cds, ctl_Confirm_dt.DateTime, "WAIT");
           
        }

    }
}

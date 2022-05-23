using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WorkOrder;
using BPack.Pocket.App.PC.WorkOrder;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.WorkOrder
{
    public partial class WorkOrderEditForm : StrapEditForm
    {
        private WorkOrderArgs _workOrderArgs;
        private WorkOrderPocket _workOrderPocket;
        private WorkOrderModel _workOrderModel;
        public WorkOrderEditForm()
        {
            InitializeComponent();
        }

        public WorkOrderEditForm(WorkOrderArgs workOrderArgs, WorkOrderPocket workOrderPocket) : this()
        {
            this._workOrderArgs = workOrderArgs;
            this._workOrderPocket = workOrderPocket;
            InitBoundFieldName<WorkOrderModel>(strapLayout1);
            ctl_WC_GR.EditValueChanged += Ctl_WC_GR_EditValueChanged;
            ctl_WC_CD.EditValueChanged += Ctl_WC_CD_EditValueChanged;
            ctl_ITEM_CD2.EditValueChanged += Ctl_ITEM_CD2_EditValueChanged;

            ctl_SHIFT_GROUP_CD.EditValueChanged += Ctl_SHIFT_GROUP_CD_EditValueChanged;

            
            ctl_DEL_FG.CheckedChanged += Ctl_DEL_FG_CheckedChanged;

            
            this.Validating += WorkOrderEditForm_Validating;
            CreateValidate();

        }

        private void CreateValidate()
        {
            ConditionValidationRule _rule_String = new ConditionValidationRule();
            _rule_String.ConditionOperator = ConditionOperator.IsNotBlank;
            _rule_String.ErrorText = "필수입력값 입니다.";

            ConditionValidationRule _rule_Int = new ConditionValidationRule();
            _rule_Int.ConditionOperator = ConditionOperator.Greater;
            _rule_Int.ErrorText = "1보다 큰값 입력.";
            _rule_Int.Value1 = 0;
            //작업장
            dxValidationProvider1.SetValidationRule(ctl_WC_CD, _rule_String);

            //품번 ctl_ITEM_CD2
            dxValidationProvider1.SetValidationRule(ctl_ITEM_CD2, _rule_String);

            //ctl_WORK_DT
            dxValidationProvider1.SetValidationRule(ctl_WORK_DT, _rule_String);

            //ctl_LOT_SIZE
            //dxValidationProvider1.SetValidationRule(ctl_LOT_SIZE, _rule_Int);

            //ctl_SHIFT_GROUP_CD
            dxValidationProvider1.SetValidationRule(ctl_SHIFT_GROUP_CD, _rule_String);

            //ctl_SHIFT_CD
            dxValidationProvider1.SetValidationRule(ctl_SHIFT_CD, _rule_String);

            //ctl_WOR_QTY
            dxValidationProvider1.SetValidationRule(ctl_WOR_QTY, _rule_Int);

            //ctl_UPH_QTY
            dxValidationProvider1.SetValidationRule(ctl_UPH_QTY, _rule_Int);

            //ctl_MAT_WH_CD
            dxValidationProvider1.SetValidationRule(ctl_MAT_WH_CD, _rule_String);

            //ctl_GD_WH_CD
            dxValidationProvider1.SetValidationRule(ctl_GD_WH_CD, _rule_String);
        }

        private void WorkOrderEditForm_Validating(object sender, CancelEventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                e.Cancel = true;
            }
            //ctl_WC_CD.DoValidate( PopupCloseMode.Normal);
            //e.Cancel = true;
        }

        private void Ctl_DEL_FG_CheckedChanged(object sender, EventArgs e)
        {
            if (ctl_DEL_FG.Checked)
            {
                _workOrderModel.DEL_FG = "Y";
            }
            else
            {
                _workOrderModel.DEL_FG = "N";
            }
        }
        private void SetEditorValue(BaseEdit editor, object value)
        {
            if (Visible)
            {
                editor.EditValue = value;
                foreach (Binding i in editor.DataBindings)
                {
                    i.WriteValue();
                }
            }
        }


        private void Ctl_BOM_NO_EditValueChanged(object sender, EventArgs e)
        {
            //SetEditorValue(ctl_BOM_NO, ctl_BOM_NO.EditValue);
        }

        private void Ctl_WC_GR_EditValueChanged(object sender, EventArgs e)
        {
            //작업장
            LookUpEditHelper.SetWorkCenterInfo(
                ctl_WC_CD,
                _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code,
                _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
                , ctl_WC_GR.EditValue?.ToString()
                    , new Dictionary<string, string>
                    {
                        { "WC_CD","작업장코드"}
                        ,{ "WC_NM","작업장명"}
                        ,{ "SHIFT_GROUP_CD","근무조그룹"}
                        ,{ "SHIFT_GROUP_NM","근무조그룹명"}
                        ,{ "REMARK","비고"}
                    }
                );
        }
        private void Ctl_WC_CD_EditValueChanged(object sender, EventArgs e)
        {
            //다른 LookupEdit에 영향줄 경우
            SetEditorValue(ctl_WC_CD, ctl_WC_CD.EditValue);

            //근무조그룹
            ctl_SHIFT_GROUP_CD.EditValue = ctl_WC_CD.GetColumnValue("SHIFT_GROUP_CD");
            //작업장 변경시 초기화
            ctl_ITEM_NM.EditValue = "";
            
            ctl_WOR_QTY.EditValue = 1;
            ctl_UPH_QTY.EditValue = 0;
            SetEditorValue(ctl_UPH_QTY, ctl_UPH_QTY.EditValue);

            ctl_MAT_WH_CD.EditValue = "";
            ctl_GD_WH_CD.EditValue = "";


            LookUpEditHelper.SetByQuery(
                ctl_ITEM_CD2,
                "MD.WCITEM.Select",
                new
                {
                    COMP_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code
                    ,
                    PLANT_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
                    ,
                    WC_CD = ctl_WC_CD.EditValue?.ToString()
                },
                new Dictionary<string, string>() {
                            // {"COMP_CD","회사코드"}
                            //,{"PLANT_CD","공장코드"}
                            {"ITEM_CD","Code"}
                            ,{"ITEM_NM","Name"}
                            ,{"ITEM_SPEC","Spec"}
                            //,{"ITEM_DESC_1","품목설명1"}
                            //,{"ITEM_DESC_2","품목설명2"}
                            //,{"ITEM_DESC_3","품목설명3"}
                            //,{"ITEM_TYPE_CD","품목유형코드"}
                            ,{"ITEM_TYPE_NM","Type"}
                            //,{"ITEM_GR_1","품목그룹1"}
                            ,{"ITEM_GR_NM","Group"}
                            
                            //,{"ITEM_GR_2","품목그룹2"}
                            //,{"ITEM_GR_3","품목그룹3"}
                            //,{"ITEM_GR_4","품목그룹4"}
                            //,{"ITEM_GR_5","품목그룹5"}
                            //,{"PUR_SIZE","구매단위수량"}
                            //,{"MID_PACK_SIZE","중포장수량"}
                            //,{"LARGE_PACK_SIZE","대포장수량"}
                            //,{"PROD_OUT_SIZE","불출단위수량"}
                            //,{"BOX_SIZE","제품OX적재수량"}
                            //,{"PALLET_SIZE","파렛트적재수량"}
                            //,{"FIFO_CHK_YN","FIFO체크여부"}
                            //,{"SAFETY_QTY","안전재고"}
                            ,{"BASE_UNIT","Base Unit"}
                            //,{"WEIGHT","중량"}
                            //,{"WEIGHT_UNIT","중량단위"}
                            //
                           ,{"ITEM_UPH","UPH"}
                           ,{"MAT_WH_CD","Input WareHouse"}
                           ,{"GD_WH_CD","Production  WhareHouse"}

                            //,{"REMARK","비고"}
                            //,{"VALID_FROM_DT","유효시작일"}
                            //,{"VALID_TO_DT","유효종료일"}
                            //,{"DEL_FG","삭제FLAG(Y=삭제)"}
                            //,{"CREATE_DTTM","생성일시"}
                            //,{"MODIFY_DTTM","수정일시"}
                            //,{"CREATE_USER_ID","생성자"}
                            //,{"MODIFY_USER_ID","수정자"}
                                                },
            "ITEM_CD", "ITEM_CD");

            //2021.11.26 UPH 수량 변경
        }

        private void Ctl_ITEM_CD2_EditValueChanged(object sender, EventArgs e)
        {
            SetEditorValue(ctl_ITEM_CD2, ctl_ITEM_CD2.EditValue);

            ctl_ITEM_NM.EditValue = ctl_ITEM_CD2.GetColumnValue("ITEM_NM");
            SetEditorValue(ctl_ITEM_NM, ctl_ITEM_NM.EditValue);


            ctl_UPH_QTY.EditValue = ctl_ITEM_CD2.GetColumnValue("ITEM_UPH");
            SetEditorValue(ctl_UPH_QTY, ctl_UPH_QTY.EditValue);


            ctl_MAT_WH_CD.EditValue = ctl_ITEM_CD2.GetColumnValue("MAT_WH_CD");
            SetEditorValue(ctl_MAT_WH_CD, ctl_MAT_WH_CD.EditValue);

            ctl_GD_WH_CD.EditValue = ctl_ITEM_CD2.GetColumnValue("GD_WH_CD");
            SetEditorValue(ctl_GD_WH_CD, ctl_GD_WH_CD.EditValue);

        }

     

        private void Ctl_SHIFT_GROUP_CD_EditValueChanged(object sender, EventArgs e)
        {
            SetEditorValue(ctl_SHIFT_GROUP_CD, ctl_SHIFT_GROUP_CD.EditValue);
            LookUpEditHelper.SetByQuery(
             ctl_SHIFT_CD,
             "MD.SHID.Select",
             new
             {
                 COMP_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code,
                 PLANT_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code,
                 SHIFT_GROUP_CD = ctl_SHIFT_GROUP_CD.EditValue?.ToString()
             }
             , "근무조"
             , "근무조명"
             );
        }



        internal void DataRefresh(object current)
        {

            _workOrderModel = current as WorkOrderModel;

            //workOrderModelBindingSource.DataSource = _workOrderModel;
            //workOrderModelBindingSource.ResetBindings(false);

            ctl_WC_GR.Properties.Columns.Clear();

            if (_workOrderModel.RowState == Common.Model.RowState.Added)
            {
                //신규
                ctl_WC_GR.Enabled = true;
                ctl_WC_CD.Enabled = true;
                ctl_ITEM_CD2.Enabled = true;
                ctl_DEL_FG.Enabled = false;
            }
            else
            {
                //수정
                //ctl_SHIFT_GROUP_CD.Enabled = true;
                //ctl_SHIFT_CD.Enabled = true;
                //ctl_WOR_QTY.Enabled = true;
                //ctl_UPH_QTY.Enabled = true;
                //ctl_MAT_WH_CD.Enabled = true;
                //ctl_GD_WH_CD.Enabled = true;
                //ctl_DEL_FG.Enabled = true;
                //ctl_REMARK.Enabled = true;

                //불가능
                ctl_WC_GR.Enabled = false;
                ctl_WC_CD.Enabled = false;
                ctl_ITEM_CD2.Enabled = false;
                ctl_DEL_FG.Enabled = true;
            }

            if (_workOrderModel.DEL_FG == "Y")
            {
                ctl_DEL_FG.Checked = true;
            }
            else
            {
                ctl_DEL_FG.Checked = false;
            }

            //작업장 그룹
            LookUpEditHelper.SetSysCode(ctl_WC_GR, "WC_GR");

            //작업장
            LookUpEditHelper.SetWorkCenterInfo(
                ctl_WC_CD,
                _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code,
                _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
                , ctl_WC_GR.EditValue?.ToString()
                    , new Dictionary<string, string>
                    {
                        { "WC_CD","작업장코드"}
                        ,{ "WC_NM","작업장명"}
                        ,{ "SHIFT_GROUP_CD","근무조그룹"}
                        ,{ "SHIFT_GROUP_NM","근무조그룹명"}
                        ,{ "UPH","UPH"}

                        ,{ "REMARK","비고"}
                    }
                , isFirstSelect: true);

            //근무조 그룹
            LookUpEditHelper.SetByQuery(
              ctl_SHIFT_GROUP_CD,
              "MD.SHIH.Select",
              new
              {
                  COMP_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code,
                  PLANT_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
              }
              , "근무조그룹"
              , "근무조그룹명"
              );

            //근무조
            LookUpEditHelper.SetByQuery(
              ctl_SHIFT_CD,
              "MD.SHID.Select",
              new
              {
                  COMP_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code,
                  PLANT_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code,
                  SHIFT_GROUP_CD = ctl_SHIFT_GROUP_CD.EditValue?.ToString()
              }
              , "근무조"
              , "근무조명"
              );

            //자재창고
            LookUpEditHelper.SetByQuery(ctl_MAT_WH_CD, "WareHouses_Raw"
                , new
                {
                    COMP_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code
                    ,
                    PLANT_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
                }
                , "Code", "Name",isFirstSelect:true);

            //제품창고
            LookUpEditHelper.SetByQuery(ctl_GD_WH_CD, "WareHouses_FinalGoods"
                , new
                {
                    COMP_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code
                    ,
                    PLANT_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
                }
                , "Code", "Name", isFirstSelect: true);

            //자재창고
            LookUpEditHelper.SetByQuery(ctl_MAT_WH_CD, "WareHouses_Raw"
                , new
                {
                    COMP_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code
                    ,
                    PLANT_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
                }
                , "Code", "Name", isFirstSelect: true);

            //제품창고
            LookUpEditHelper.SetByQuery(ctl_GD_WH_CD, "WareHouses_FinalGoods"
                , new
                {
                    COMP_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Comp_Code
                    ,
                    PLANT_CD = _workOrderArgs.WorkOrderModelArgs.Select_Main_Plant_Code
                }
                , "Code", "Name", isFirstSelect: true);


        }


    }
}

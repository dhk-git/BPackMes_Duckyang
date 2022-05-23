using BPack.Common.Pocket;
using BPack.Model.App.PC.WoeResult;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WoeResult;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.PC.WoeResult
{
    public partial class WoeResultMain : StrapMainForm
    {
        private WoeResultArgs _woeResultArgs;
        private WoeResultPocket _woeResultPocket;
        private WoeWorkOrderList _woeWorkOrderList;
        private WoeWorkResultList _woeWorkResultList;
        private WoeHuList _woeHuList;
        private WoeOrderMaterialList _woeOrderMaterialList;
        private WoeParentHuList _woeParentHuList;
        private WoeUsedMaterialList _woeUsedMaterialList;

        public WoeResultMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _woeResultArgs = new WoeResultArgs();
            _woeResultPocket = new WoeResultPocket();
            _woeWorkOrderList = new WoeWorkOrderList(_woeResultArgs, _woeResultPocket);
            _woeWorkResultList = new WoeWorkResultList(_woeResultArgs, _woeResultPocket);
            _woeHuList = new WoeHuList(_woeResultArgs, _woeResultPocket);
            _woeOrderMaterialList = new WoeOrderMaterialList(_woeResultArgs, _woeResultPocket);
            _woeParentHuList = new WoeParentHuList(_woeResultArgs, _woeResultPocket);
            _woeUsedMaterialList = new WoeUsedMaterialList(_woeResultArgs, _woeResultPocket);

            AddSubForm(this, _woeWorkOrderList, layoutControlGroup2);
            AddSubForm(this, _woeWorkResultList, layoutControlGroup3);
            AddSubForm(this, _woeHuList, layoutControlGroup4);
            AddSubForm(this, _woeOrderMaterialList, layoutControlGroup5);
            AddSubForm(this, _woeParentHuList, layoutControlGroup6);
            AddSubForm(this, _woeUsedMaterialList, layoutControlGroup7);
            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _woeResultArgs,
                InitlistForm = _woeWorkOrderList,
                StrapLayout = strapLayout1

            });
            _woeWorkOrderList.ModelSelectedEvent += WoeWorkOrderList_ModelSelectedEvent;
            _woeWorkResultList.ModelSelectedEvent += WoeWorkResultList_ModelSelectedEvent;
            _woeHuList.ModelSelectedEvent += WoeHuList_ModelSelectedEvent;
            strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            CommonMes.Helpers.LookUpEditHelper.SetPlantCode(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, true);
            strapSpinEdit1.EditValue = 1;
            radioGroup1.EditValue = "OK";
            InitRibbonButtons(true, true, true, true);
        }

        private void WoeHuList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _woeResultArgs.WoeResultModelArgs.Select_Hu_No = ((WoeHuModel)e.SelectedModelArgsBase.SelectedModelBase).HU_NO;
            _woeUsedMaterialList.DataRefresh(_woeResultArgs);
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            CommonMes.Helpers.LookUpEditHelper.SetWorkCenter(strapLookUpEdit2, Common.LoginInfo.UserInfo.CompCode, strapLookUpEdit1.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true);
        }

        private void WoeWorkResultList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _woeResultArgs.WoeResultModelArgs.Select_Rst_No = ((WoeWorkResultModel)e.SelectedModelArgsBase.SelectedModelBase).RST_NO;
            _woeResultArgs.WoeResultModelArgs.Select_Hu_No = null;
            _woeHuList.DataRefresh(_woeResultArgs);
            _woeUsedMaterialList.DataRefresh(_woeResultArgs);
            _woeParentHuList.DataRefresh(_woeResultArgs);
        }

        private void WoeWorkOrderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _woeResultArgs.WoeResultModelArgs.Select_Wo_No = ((WoeWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).WO_NO;
            _woeResultArgs.WoeResultModelArgs.Select_Oper = ((WoeWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).OPER;
            _woeResultArgs.WoeResultModelArgs.Select_Route_No = ((WoeWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).ROUTE_NO;
            _woeResultArgs.WoeResultModelArgs.Select_Item_Cd = ((WoeWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
            _woeResultArgs.WoeResultModelArgs.Select_Mat_Wh_Cd = ((WoeWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).MAT_WH_CD;
            _woeResultArgs.WoeResultModelArgs.Select_Mat_Loc_Cd = ((WoeWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).MAT_LOC_CD;
            _woeResultArgs.WoeResultModelArgs.Select_Gd_Wh_Cd = ((WoeWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).GD_WH_CD;
            _woeResultArgs.WoeResultModelArgs.Select_Gd_Loc_Cd = ((WoeWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).GD_LOC_CD;
            _woeResultArgs.WoeResultModelArgs.Select_Rst_Hu_Type = ((WoeWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).RST_HU_TYPE;
            strapTextEdit2.Text = _woeResultArgs.WoeResultModelArgs.Select_Mat_Wh_Cd + "/" + _woeResultArgs.WoeResultModelArgs.Select_Mat_Loc_Cd;
            _woeWorkResultList.DataRefresh(_woeResultArgs);
            _woeOrderMaterialList.DataRefresh(_woeResultArgs);
            _woeHuList.DataClear(_woeResultArgs);
            _woeParentHuList.DataClear(_woeResultArgs);
            _woeUsedMaterialList.DataClear(_woeResultArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _woeResultArgs.WoeResultModelArgs.Select_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _woeResultArgs.WoeResultModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _woeResultArgs.WoeResultModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _woeResultArgs.WoeResultModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _woeResultArgs.WoeResultModelArgs.Select_Main_Wc_Cd = strapLookUpEdit2.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }

  
        //식별표생성 및 등록
        private void strapButton1_Click(object sender, EventArgs e)
        {
            _woeResultArgs.Ok_Ng = radioGroup1.EditValue.ToString();
            _woeResultArgs.HuQty = (decimal)strapSpinEdit1.EditValue;
            _woeHuList.AddHuAndReg();
        }
        //자동투입처리 버튼
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _woeOrderMaterialList.BpAutoInsertMaterial();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            _woeResultArgs.WoeResultModelArgs.Scaned_Hu_No = strapTextEdit1.EditValue?.ToString();
            _woeOrderMaterialList.BpManualInsertMaterial();
        }
        //전체적입
        private void strapButton2_Click(object sender, EventArgs e)
        {
            _woeParentHuList.BpAddWoeParentHuByAll();
        }
        //양/불 분리적입
        private void strapButton3_Click(object sender, EventArgs e)
        {
            _woeParentHuList.BpAddWoeParentHuByDivideOkNg();
        }
        //실적완료
        private void strapButton4_Click(object sender, EventArgs e)
        {
            _woeWorkResultList.BpCloseWorkResult();
        }
        //작업지시 종료 버튼
        private void strapButton6_Click(object sender, EventArgs e)
        {

        }
    }
}

using BPack.CommonMes.Helpers;
using BPack.Pocket.App.PC.WoeResultPivot;
using BPack.Strap.FormControls;
using System;

namespace BPack.Carrying.App.PC.WoeResultPivot
{
    public partial class WoeResultPivotMain : StrapMainForm
    {
        private WoeResultPivotArgs _woeResultPivotArgs;
        private WoeResultPivotPocket _woeResultPivotPocket;
        private ResultPivotList _resultPivotList;
        private ResultEachList _resultEachList;

        public WoeResultPivotMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _woeResultPivotArgs = new WoeResultPivotArgs();
            _woeResultPivotPocket = new WoeResultPivotPocket();
            _resultPivotList = new ResultPivotList(_woeResultPivotArgs, _woeResultPivotPocket);
            _resultEachList = new ResultEachList(_woeResultPivotArgs, _woeResultPivotPocket);
            AddSubForm(this, _resultPivotList, layoutControlGroup2);
            AddSubForm(this, _resultEachList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _woeResultPivotArgs,
                InitlistForm = _resultPivotList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });
            InitRibbonButtons(true);

            strapDateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            strapDateEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            strapDateEdit1.EditValue = DateTime.Now.Date;
            strapDateEdit2.EditValue = DateTime.Now.Date;
            LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, isTotalRow: false, isFirstSelect: true);
            LookUpEditHelper.SetShiftCode(strapLookUpEdit3, Common.LoginInfo.UserInfo.CompCode, strapLookUpEdit2.EditValue.ToString(), isTotalRow: false, isFirstSelect: true);
            LookUpEditHelper.SetWorkCenter(strapLookUpEdit4, Common.LoginInfo.UserInfo.CompCode, strapLookUpEdit2.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true);
            LookUpEditHelper.SetItemType(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, true, true, false);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_Plant_Cd = strapLookUpEdit2.EditValue?.ToString();
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_Wc_Cd = strapLookUpEdit4.EditValue?.ToString();
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_Item_Type_Cd = strapLookUpEdit1.EditValue?.ToString();
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_Item_Gr_1 = strapTextEdit3.EditValue?.ToString();
            _woeResultPivotArgs.WoeResultPivotModelArgs.Select_Main_Alc_Cd = strapTextEdit4.EditValue?.ToString();
            if (tabbedControlGroup1.SelectedTabPageIndex == 0)
            {
                _resultPivotList.DataRefresh(_woeResultPivotArgs);
            }
            else
            {
                _resultEachList.DataRefresh(_woeResultPivotArgs);
            }

            //base.Refresh_From_ExecuteByRibbonButton();
        }

    }

    
}

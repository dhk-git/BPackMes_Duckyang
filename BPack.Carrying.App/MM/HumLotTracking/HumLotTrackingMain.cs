using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.HumLotTracking;
using BPack.Pocket.App.MM.HumLotTracking;
using BPack.Strap.FormControls;
using System;

namespace BPack.Carrying.App.MM.HumLotTracking
{
    public partial class HumLotTrackingMain : StrapMainForm
    {
        private HumLotTrackingArgs _humLotTrackingArgs;
        private HumLotTrackingPocket _humLotTrackingPocket;
        private HumHeaderForwardList _humHeaderForwardList;
        private HumHeaderReverseList _humHeaderReverseListList;
        private HumDetailForwardList _humDetailFowardList;
        private HumDetailReverseList _humDetailReverseList;

        public HumLotTrackingMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            strapDateEdit1.EditValue = DateTime.Now.Date;
            strapDateEdit2.EditValue = DateTime.Now.Date;

            _humLotTrackingArgs = new HumLotTrackingArgs();
            _humLotTrackingPocket = new HumLotTrackingPocket();
            _humHeaderForwardList = new HumHeaderForwardList(_humLotTrackingArgs, _humLotTrackingPocket);
            _humHeaderReverseListList = new HumHeaderReverseList(_humLotTrackingArgs, _humLotTrackingPocket); //Backward
            _humDetailFowardList = new HumDetailForwardList(_humLotTrackingArgs, _humLotTrackingPocket);
            _humDetailReverseList = new HumDetailReverseList(_humLotTrackingArgs, _humLotTrackingPocket);


            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _humLotTrackingArgs,
                InitlistForm = _humHeaderReverseListList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayoutControl1
            });
            AddSubForm(this, _humHeaderReverseListList, layoutControlGroup3);
            AddSubForm(this, _humDetailReverseList, layoutControlGroup7);
            AddSubForm(this, _humHeaderForwardList, layoutControlGroup2);
            AddSubForm(this, _humDetailFowardList, layoutControlGroup6);

            InitRibbonButtons(true);

            LookUpEditHelper.SetCompCode(lueComp);

            lueComp.EditValueChanged += (object sender, EventArgs e) =>
            {
                _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Comp_CD = lueComp.EditValue?.ToString();

                LookUpEditHelper.SetPlantCode(luePlant, _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Comp_CD, isFirstSelect: true);
            };

            luePlant.EditValueChanged += (object sender, EventArgs e) =>
            {
                _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Plant_CD = luePlant.EditValue?.ToString();
            };

            itemMasterButtonEdit1.ButtonClick += (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) =>
            {
                itemMasterButtonEdit1.InitCompCode(_humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Comp_CD);
                itemMasterButtonEdit1.InitPlantCode(_humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Plant_CD);
                itemMasterButtonEdit1.DataClear();
            };

            itemMasterButtonEdit1.InitStrap();

            lueComp.EditValue = Common.LoginInfo.UserInfo.CompCode;

            _humHeaderReverseListList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Header_Hu_No = ((HumHeaderReverseModel)e.SelectedModelArgsBase.SelectedModelBase).HU_NO;
                _humDetailReverseList.DataRefresh(_humLotTrackingArgs);
                //SearchDetailTab();
            };

            _humHeaderForwardList.ModelSelectedEvent += HumHeaderForwardList_ModelSelectedEvent;
            checkEdit1.CheckState = System.Windows.Forms.CheckState.Unchecked;
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Checked_Semi = checkEdit1.CheckState.ToString();
            checkEdit1.CheckedChanged += CheckEdit1_CheckedChanged;
        }

        private void CheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Checked_Semi = checkEdit1.CheckState.ToString();
            if (checkEdit1.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                _humHeaderForwardList.SetCheckedSemi(checkEdit1.CheckState);
                _humHeaderReverseListList.SetCheckedSemi(checkEdit1.CheckState);

                _humHeaderForwardList.DataClear(_humLotTrackingArgs);
                _humHeaderReverseListList.DataClear(_humLotTrackingArgs);
                _humDetailFowardList.DataClear(_humLotTrackingArgs);
                _humDetailReverseList.DataClear(_humLotTrackingArgs);
            }
            else
            {
                layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                _humHeaderForwardList.SetCheckedSemi(checkEdit1.CheckState);
                _humHeaderReverseListList.SetCheckedSemi(checkEdit1.CheckState);

                _humHeaderForwardList.DataClear(_humLotTrackingArgs);
                _humHeaderReverseListList.DataClear(_humLotTrackingArgs);
                _humDetailFowardList.DataClear(_humLotTrackingArgs);
                _humDetailReverseList.DataClear(_humLotTrackingArgs);
            }
        }

        private void HumHeaderForwardList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Header_Hu_No = ((HumHeaderForwardModel)e.SelectedModelArgsBase.SelectedModelBase).HU_NO;
            _humDetailFowardList.DataRefresh(_humLotTrackingArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Item_CD = itemMasterButtonEdit1.EditValue?.ToString();
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Hu_No= txtHuNo.EditValue?.ToString();
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Hu_Barcode = txtHuBarcode.EditValue?.ToString();
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Body_No = txtBodyNo.EditValue?.ToString();

            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;

            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Do_No = strapTextEdit3.EditValue?.ToString();
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Alc_Cd = strapTextEdit2.EditValue?.ToString();
            _humLotTrackingArgs.HumLotTrackingModelArgs.Select_Main_Pbs_Seq = strapTextEdit4.EditValue?.ToString();

            SearchDetailTab();
            //base.Refresh_From_ExecuteByRibbonButton();
        }

        private void SearchDetailTab()
        {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                _humHeaderReverseListList.DataRefresh(_humLotTrackingArgs);
            }
            else if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                //_humHeaderReverseListList.DataRefresh(_humLotTrackingArgs);
                _humHeaderForwardList.DataRefresh(_humLotTrackingArgs);
            }
        }

        //private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        //{
        //    SearchDetailTab();
        //}
    }
}

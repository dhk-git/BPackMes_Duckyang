using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.ItmSales;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmSales;
using System;

namespace BPack.Carrying.App.MD.ItmSales
{
    public partial class ItmSalesMain : StrapMainForm
    {
        private ItmSalesArgs _itmSalesArgs;
        private ItmSalesGateList _itmSalesGateList;
        private ItmSalesItemList _itmSalesItemList;
        private ItmSalesPocket _itmSalesPocket;
        
        public ItmSalesMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _itmSalesArgs = new ItmSalesArgs();
            _itmSalesPocket = new ItmSalesPocket();
            _itmSalesGateList = new ItmSalesGateList(_itmSalesArgs, _itmSalesPocket);
            _itmSalesItemList = new ItmSalesItemList(_itmSalesArgs, _itmSalesPocket);

            AddSubForm(this, _itmSalesGateList, layoutControlGroup2);
            AddSubForm(this, _itmSalesItemList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _itmSalesArgs,
                InitlistForm = _itmSalesGateList,
                StrapLayout = strapLayout1
            });
            _itmSalesGateList.AddRefreshTargetSubForm(_itmSalesItemList);
            InitRibbonButtons(true, true, true, true);



            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };






            _itmSalesGateList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _itmSalesArgs.ItmSalesModelArgs.Select_Main_Comp_CD = ((ItmSalesGateModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                _itmSalesArgs.ItmSalesModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
                _itmSalesArgs.ItmSalesModelArgs.Select_Main_BP_CD = ((ItmSalesGateModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
                _itmSalesItemList.DataRefresh(_itmSalesArgs);

            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _itmSalesGateList) { SetRibbonButtonsEnable_ByAuth(add: true, save: false, edit: false, delete: false); }
                if (this.SelectedSubForm == _itmSalesItemList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _itmSalesArgs.ItmSalesModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _itmSalesArgs.ItmSalesModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

    }
}

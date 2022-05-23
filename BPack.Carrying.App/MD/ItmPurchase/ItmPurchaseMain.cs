using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.ItmPurchase;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmPurchase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.ItmPurchase
{
    public partial class ItmPurchaseMain : StrapMainForm
    {
        private ItmPurchaseArgs _ItmPurchaseArgs;
        private ItmPurchaseList _itmPurchaseList;
        private ItmList _itmList;
        private ItmPurchasePocket _itmPurchasePocket;
        
        public ItmPurchaseMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _ItmPurchaseArgs = new ItmPurchaseArgs();
            _itmPurchasePocket = new ItmPurchasePocket();
            _itmPurchaseList = new ItmPurchaseList(_ItmPurchaseArgs, _itmPurchasePocket);
            _itmList = new ItmList(_ItmPurchaseArgs, _itmPurchasePocket);
            AddSubForm(this, _itmPurchaseList, layoutControlGroup2);
            AddSubForm(this, _itmList, layoutControlGroup3);
            _itmPurchaseList.AddRefreshTargetSubForm(_itmList);
            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _ItmPurchaseArgs,
                InitlistForm = _itmPurchaseList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, isFirstSelect: true);
            };

            _itmPurchaseList.ModelSelectedEvent += PlantList_ModelSelectedEvent;
            this.SelectedSubFormChanged += ItmPurchasePocketMain_SelectedSubFormChanged;
            InitRibbonButtons(true);
        }

        private void ItmPurchasePocketMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _itmPurchaseList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, save: false, delete: false);
            }
            if (this.SelectedSubForm == _itmList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, save: true, delete:true);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
            base.OnShown(e);
        }

        private void PlantList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _ItmPurchaseArgs.ItmPurchaseModelArgs.Select_Comp_CD = ((ItmPurchaseModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _ItmPurchaseArgs.ItmPurchaseModelArgs.Select_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            _ItmPurchaseArgs.ItmPurchaseModelArgs.Select_Bp_CD = ((ItmPurchaseModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            _itmList.DataRefresh(_ItmPurchaseArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _ItmPurchaseArgs.ItmPurchaseModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _ItmPurchaseArgs.ItmPurchaseModelArgs.Select_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }

        

    }
}

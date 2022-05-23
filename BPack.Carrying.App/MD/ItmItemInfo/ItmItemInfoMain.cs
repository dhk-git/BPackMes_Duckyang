using BPack.Common.Pocket;
using BPack.Model.App.MD.ItmItemInfo;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmItemInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.ItmItemType;

namespace BPack.Carrying.App.MD.ItmItemInfo
{
    public partial class ItmItemInfoMain : StrapMainForm
    {
        private ItmItemInfoPocket _itmItemInfoPocket;
        private ItmItemInfoArgs _itmItemInfoArgs;
        private ItemList _itemList;
        private ConvFactorList _convFactorList;

        public ItmItemInfoMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _itmItemInfoArgs = new ItmItemInfoArgs();
            _itmItemInfoPocket = new ItmItemInfoPocket();
            _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code = Common.LoginInfo.UserInfo.CompCode;

            _itemList = new ItemList(_itmItemInfoArgs, _itmItemInfoPocket);
            _convFactorList = new ConvFactorList(_itmItemInfoArgs, _itmItemInfoPocket);

            AddSubForm(this, _itemList, layoutControlGroup2);
            AddSubForm(this, _convFactorList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _itmItemInfoArgs,
                InitlistForm = _itemList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });
            InitRibbonButtons(true, true, false, true, true);

            //공장정보 조회조건
            layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            //LookUpEditHelper.SetByQuery(strapTextEdit4, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME");
            _itemList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _itmItemInfoArgs.itmItemInfoModelArgs.Select_Comp_Code = ((ItemInfoModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                _itmItemInfoArgs.itmItemInfoModelArgs.Select_Plant_Code = ((ItemInfoModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
                _itmItemInfoArgs.itmItemInfoModelArgs.Select_Item_Code = ((ItemInfoModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;

                itemInfoModelBindingSource.DataSource = e.SelectedModelArgsBase.SelectedModelBase;

                _convFactorList.DataRefresh(_itmItemInfoArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _itemList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true); }
                if (this.SelectedSubForm == _convFactorList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true); }
            };

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
                LookUpEditHelper.SetItemType(strapLookUpEdit3, strapLookUpEdit1.EditValue?.ToString(), isTotalRow: false, isFirstSelect: true);
            };
            strapLookUpEdit2.EditValueChanged += StrapLookUpEdit2_EditValueChanged;
            //단위환산 탭 비활성 
            tabbedControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            splitterItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void StrapLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetByQuery(strapLookUpEditItem_Gr_1, "ItemGroupDetail", new { COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code, PLANT_CD = strapLookUpEdit2.EditValue?.ToString(), ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
        }

        protected override void OnShown(EventArgs e)
        {
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
            base.OnShown(e);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Item_Type_CD = strapLookUpEdit3.EditValue?.ToString();
            _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Item_Type = strapLookUpEdit3.EditValue?.ToString();
            _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Item_Code = strapTextEdit1.EditValue?.ToString();
            _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Item_Name = strapTextEdit2.EditValue?.ToString();
            // _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Main_Model = strapTextEdit3.EditValue?.ToString();
            _itmItemInfoArgs.itmItemInfoModelArgs.Select_Main_Item_Group1 = strapLookUpEditItem_Gr_1.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }


    }
}

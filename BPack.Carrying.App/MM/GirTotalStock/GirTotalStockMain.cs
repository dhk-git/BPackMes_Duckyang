using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirTotalStock;
using System;
using BPack.IStrap.Forms;
using BPack.CommonMes.Enums;
using BPack.CommonMes.Helpers;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.MM.GirTotalStock
{
    public partial class GirTotalStockMain : StrapMainForm
    {
        private GirTotalStockArgs _totalGirStockArgs;
        private GirTotalStockPocket _totalGirStockPocket;
        private TotalStockList _totalStockList;
        private GirTotalLocStockPivot _girTotalLocStockPivot;

        public GirTotalStockMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            
            _totalGirStockArgs = new GirTotalStockArgs();
            _totalGirStockPocket = new GirTotalStockPocket();
            _totalStockList = new TotalStockList(_totalGirStockArgs, _totalGirStockPocket);
            _girTotalLocStockPivot = new GirTotalLocStockPivot(_totalGirStockArgs, _totalGirStockPocket);

            AddSubForm(this, _totalStockList, layoutControlGroup3);
            AddSubForm(this, _girTotalLocStockPivot, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _totalGirStockArgs,
                InitlistForm = _totalStockList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });

            InitRibbonButtons(true);

            _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;

            LookUpEditHelper.SetCompCode(lueCompCd);

            lueCompCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Comp_Cd = lueCompCd.EditValue?.ToString();

                LookUpEditHelper.SetPlantCode(luePlantCd, new { COMP_CD = _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Comp_Cd }, isFirstSelect: true);
                LookUpEditHelper.SetByQuery(lueItemType, "ItemType", new { COMP_CD = _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Comp_Cd }, "품목유형코드", "품목유형명", isTotalRow: true, isFirstSelect: true);

            };

            luePlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Plant_Cd = luePlantCd.EditValue?.ToString();

                LookUpEditHelper.SetWareHouse(cbxWareHouse, _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Comp_Cd, _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Plant_Cd);
            };

            cbxWareHouse.EditValueChanged += (object sender, EventArgs e) =>
            {
                _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Wh_Cd_List = cbxWareHouse.EditValue?.ToString().Replace(", ", SysCode.Separator.Parameter);
            };

            lueItemType.EditValueChanged += (object sender, EventArgs e) =>
            {
                _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Item_Type = lueItemType.EditValue?.ToString();
            };

            lueCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;

        }

        public override void ExecuteByRibbonButton(ButtonKind buttonKind)
        {
            base.ExecuteByRibbonButton(buttonKind);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Item_Cd = txtItemCd.EditValue?.ToString();
            _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Item_Nm = txtItemNm.EditValue?.ToString();
            _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Item_Group_1 = txtItemGr1.EditValue?.ToString();
            _totalGirStockArgs.GirTotalStockModelArgs.Select_Main_Item_Group_3 = txtItemGr3.EditValue?.ToString();

            if (tabbedControlGroup1.SelectedTabPage == layoutControlGroup3)
            {
                _totalStockList.DataRefresh(_totalGirStockArgs);
            }
            else
            {
                _girTotalLocStockPivot.DataRefresh(_totalGirStockArgs);
            }

            //base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}

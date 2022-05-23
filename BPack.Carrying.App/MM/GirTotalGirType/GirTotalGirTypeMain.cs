using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirTotalGirType;
using System;
using BPack.IStrap.Forms;
using BPack.CommonMes.Enums;
using BPack.CommonMes.Helpers;
using BPack.Common.Pocket;

namespace BPack.Carrying.App.MM.GirTotalGirType
{
    public partial class GirTotalGirTypeMain : StrapMainForm
    {
        private GirTotalGirTypeArgs _girTotalGirTypeArgs;
        private GirTotalGirTypePocket _girTotalGirTypePocket;
        private TotalGirTypeList _totalGirTypeList;

        public GirTotalGirTypeMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            
            _girTotalGirTypeArgs = new GirTotalGirTypeArgs();
            _girTotalGirTypePocket = new GirTotalGirTypePocket();
            _totalGirTypeList = new TotalGirTypeList(_girTotalGirTypeArgs, _girTotalGirTypePocket);

            AddSubForm(this, _totalGirTypeList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _girTotalGirTypeArgs,
                InitlistForm = _totalGirTypeList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });

            InitRibbonButtons(true);

            _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;

            LookUpEditHelper.SetCompCode(lueCompCd);

            lueCompCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Comp_Cd = lueCompCd.EditValue?.ToString();

                LookUpEditHelper.SetPlantCode(luePlantCd, new { COMP_CD = _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Comp_Cd }, isFirstSelect: true);
                LookUpEditHelper.SetByQuery(lueItemType, "ItemType", new { COMP_CD = _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Comp_Cd }, "품목유형코드", "품목유형명", isTotalRow: true, isFirstSelect: true);

            };

            luePlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Plant_Cd = luePlantCd.EditValue?.ToString();

                LookUpEditHelper.SetWareHouse(cbxWareHouse, _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Comp_Cd, _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Plant_Cd);
            };

            cbxWareHouse.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Wh_Cd_List = cbxWareHouse.EditValue?.ToString().Replace(", ", SysCode.Separator.Parameter);
            };

            lueItemType.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Item_Type = lueItemType.EditValue?.ToString();
            };

            lueCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;

        }

        public override void ExecuteByRibbonButton(ButtonKind buttonKind)
        {
            base.ExecuteByRibbonButton(buttonKind);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_From_Dt = dteFromdt.DateTime;// (DateTime)dteFromdt.EditValue;
            _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_To_Dt = dteTodt.DateTime;// (DateTime)dteTodt.EditValue;
            if (_girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_From_Dt > _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_To_Dt)
            {
                StrapMessageBox.Show("A001", 38); //종료일은 시작일보다 크거나 같아야 합니다.
                return;
            }
            _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Item_Cd = txtItemCd.EditValue?.ToString();
            _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Item_Nm = txtItemNm.EditValue?.ToString();
            _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Item_Group_1 = txtItemGr1.EditValue?.ToString();
            _girTotalGirTypeArgs.GirTotalGirTypeModelArgs.Select_Main_Item_Group_3 = txtItemGr3.EditValue?.ToString();

            //var source = _girTotalGirTypePocket.SelectCloseCheck(_girTotalGirTypeArgs.GirTotalGirTypeModelArgs);
            //if (source == null || source.Rows.Count == 0)
            //{
            //    StrapMessageBox.Show("A001", 66); // 해당 날짜의 마감 데이터가 없습니다. 재고마감 여부를 확인해주세요.
            //    return;
            //}

            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

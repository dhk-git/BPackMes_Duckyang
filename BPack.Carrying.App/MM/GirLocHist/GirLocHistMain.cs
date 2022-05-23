using BPack.CommonMes.Helpers;
using BPack.Pocket.App.MM.GirLocHist;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MM.GirLocHist
{
    public partial class GirLocHistMain : StrapMainForm
    {
        private GirLocHistArgs _girLocHistArgs;
        private GirLocHistPocket _girLocHistPocket;

        private GirLocInHistList _girLocInHistList;
        private GirLocOutHistList _girLocOutHist;
        public GirLocHistMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _girLocHistArgs = new GirLocHistArgs();
            _girLocHistPocket = new GirLocHistPocket();
            _girLocInHistList = new GirLocInHistList(_girLocHistArgs, _girLocHistPocket);
            _girLocOutHist= new GirLocOutHistList(_girLocHistArgs, _girLocHistPocket);
            AddSubForm(this, _girLocInHistList, layoutControlGroup3);
            AddSubForm(this, _girLocOutHist, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _girLocHistArgs,
                InitlistForm = _girLocInHistList,
                IsAutoDataRefreshOnShown = true,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, false, false, false, false);


            //회사
            LookUpEditHelper.SetCompCode(lueCompCd);
            lueCompCd.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            lueCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;

            //공장
            luePlantCd.EditValueChanged += LuePlantCd_EditValueChanged;
            luePlantCd.EditValue = Common.LoginInfo.UserInfo.PlantCode;
            LuePlantCd_EditValueChanged(null, null);
        }

      

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetPlantCode(luePlantCd
                , new { COMP_CD = lueCompCd.EditValue?.ToString() }
                , isFirstSelect: true);
            
            //품목유형
            LookUpEditHelper.SetByQuery(
                lueItemType
                , "ItemType"
                , new { COMP_CD = lueCompCd.EditValue?.ToString() }
                , "Code", "Name", isTotalRow: true, isFirstSelect: true);
            
        }

        private void LuePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            //item gr 1
            LookUpEditHelper.SetByQuery(
                lueItemGroup1
                , "ItemGroupDetail"
                , new
                {
                    COMP_CD = lueCompCd.EditValue?.ToString(),
                    PLANT_CD = luePlantCd.EditValue?.ToString(),
                    ITEM_GR_CLS = "ITEM_GR_1"
                }, "CODE", "NAME", isTotalRow: true);
            //창고
            LookUpEditHelper.SetWareHouse(
                lueWhCd
                , lueCompCd.EditValue?.ToString()
                , luePlantCd.EditValue?.ToString(), isFirstSelect: true);

            //Loc In Type
            LookUpEditHelper.SetSysCode(lueLocInType, "LOC_IN_TYPE");
            //Loc Out Type
            LookUpEditHelper.SetSysCode(lueLocOutType, "LOC_OUT_TYPE");

        }
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_Comp_Cd = lueCompCd.EditValue?.ToString();
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_Plant_Cd = luePlantCd.EditValue?.ToString();
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_Start_Dt = strapDateEdit11.DateTime;
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_Wh_Cd = lueWhCd.EditValue?.ToString();
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_Item_Type_Cd = lueItemType.EditValue?.ToString();
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_Item_Cd = txtItemCd.EditValue?.ToString();
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_Item_Nm = txtItemNm.EditValue?.ToString();
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_Item_Gr_1 = lueItemGroup1.EditValue?.ToString();
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_LocInType = lueLocInType.EditValue?.ToString();
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_LocOutType = lueLocOutType.EditValue?.ToString();
            _girLocHistArgs.GirLocHistModelArgs.Select_Main_BarcodeText = txtBarcode.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();

            _girLocOutHist.DataRefresh(_girLocHistArgs);
        }

        private void lueLocInType_EditValueChanged(object sender, EventArgs e)
        {
            Refresh_From_ExecuteByRibbonButton();
        }

        private void lueLocOutType_EditValueChanged(object sender, EventArgs e)
        {
            Refresh_From_ExecuteByRibbonButton();
        }
    }
}

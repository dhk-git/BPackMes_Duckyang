using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BPack.Strap.FormControls;
using BPack.CommonMes.Helpers;
using BPack.Pocket.App.MM.GirHist;
using BPack.Common.Pocket;
using BPack.CommonMes.Enums;

namespace BPack.Carrying.App.MM.GirHist
{
    public partial class GirHistMain : StrapMainForm
    {
        private GirHistArgs _girHistArgs;
        private GirHistPocket _girHistPocket;
        private GirHistList _girHistList;

        public GirHistMain() 
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {

            _girHistArgs = new GirHistArgs();
            _girHistPocket = new GirHistPocket();
            _girHistList = new GirHistList(_girHistArgs, _girHistPocket);

            AddSubForm(this, _girHistList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _girHistArgs,
                InitlistForm = _girHistList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });

            InitRibbonButtons(true);

            _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;

            luePlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girHistArgs.GirHistModelArgs.Select_Main_Plant_Cd = luePlantCd.EditValue?.ToString();

                LookUpEditHelper.SetWareHouse(cbxWarehouse, _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd, _girHistArgs.GirHistModelArgs.Select_Main_Plant_Cd);
            };

            cbxWarehouse.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girHistArgs.GirHistModelArgs.Select_Main_Wh_Cd_List = cbxWarehouse.EditValue?.ToString().Replace(", ", SysCode.Separator.Parameter);

                LookUpEditHelper.SetLocation(cbxLocation, _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd, _girHistArgs.GirHistModelArgs.Select_Main_Plant_Cd, _girHistArgs.GirHistModelArgs.Select_Main_Wh_Cd_List);
            };

            cbxLocation.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girHistArgs.GirHistModelArgs.Select_Main_Loc_Cd_List = cbxLocation.EditValue?.ToString().Replace(", ", SysCode.Separator.Parameter);
            };

            lueItemType.EditValueChanged += (object sender, EventArgs e) =>
            {
                _girHistArgs.GirHistModelArgs.Select_Main_Item_Type = lueItemType.EditValue?.ToString();
            };

            LookUpEditHelper.SetPlantCode(luePlantCd, new { COMP_CD = _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd }, isFirstSelect: true);
            LookUpEditHelper.SetGirType(lueGirType, _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd, isTotalRow: true, isFirstSelect: true);
            LookUpEditHelper.SetItemType(lueItemType, _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd, isTotalRow: true, isFirstSelect: true);
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
        }

        protected override void Refresh_From_ExecuteByRibbonButton() 
        {
            _girHistArgs.GirHistModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _girHistArgs.GirHistModelArgs.Select_Main_Plant_Cd = luePlantCd.EditValue?.ToString();
            _girHistArgs.GirHistModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _girHistArgs.GirHistModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _girHistArgs.GirHistModelArgs.Select_Main_Gir_Type_Cd = lueGirType.EditValue?.ToString();

            _girHistArgs.GirHistModelArgs.Select_Main_Item_Cd = txtItemCd.EditValue?.ToString();
            _girHistArgs.GirHistModelArgs.Select_Main_Item_Nm = txtItemNm.EditValue?.ToString();
            _girHistArgs.GirHistModelArgs.Select_Main_Item_Group_1 = strapLookUpEdit1.EditValue?.ToString();
            _girHistArgs.GirHistModelArgs.Select_Main_Item_Group_3 = txtItemGr3.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}
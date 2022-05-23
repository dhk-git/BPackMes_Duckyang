using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Pocket.App.PC.WoeEssLot;
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

namespace BPack.Carrying.App.PC.WoeEssLot
{
    public partial class EssLotMain : StrapMainForm
    {
        private WoeEssLotArgs _woeEssLotArgs;
        private WoeEssLotPocket _woeEssLotPocket;
        private EssLotList _LotList;
        public EssLotMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _woeEssLotArgs = new WoeEssLotArgs();
            _woeEssLotPocket = new WoeEssLotPocket();
            _LotList = new EssLotList(_woeEssLotArgs, _woeEssLotPocket);
            AddSubForm(this, _LotList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _woeEssLotArgs,
                InitlistForm = _LotList,
                //IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(refresh: true);
            //회사
            LookUpEditHelper.SetCompCode(ctl_ComCd);
            ctl_ComCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                //SetEditorValue(ctl_ComCd, ctl_ComCd.EditValue);
                LookUpEditHelper.SetPlantCode(ctl_PlantCd, new { COMP_CD = ctl_ComCd.EditValue?.ToString() }, isFirstSelect: true);
                _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
            };
            strapButtonEdit_ItemMaster1.InitStrap();

            //공장
            ctl_PlantCd.EditValueChanged += Ctl_PlantCd_EditValueChanged;
            //제품군
            ctl_ItemGr.EditValueChanged += (object sender, EventArgs e) =>
            {
                _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Item_Group_cd = ctl_ItemGr.EditValue?.ToString();
            };
            ctl_ComCd.EditValue = UserInfo.CompCode;
            ctl_PlantCd.EditValue = UserInfo.PlantCode;

            strapButtonEdit_ItemMaster1.InitCompCode(UserInfo.CompCode);
            strapButtonEdit_ItemMaster1.InitPlantCode(UserInfo.PlantCode);
            ctl_Start_dt.EditValue = DateTime.Now;
            ctl_End_dt.EditValue = DateTime.Now;
            
            LookUpEditHelper.SetSysCode(strapLookUpEdit1, "DIRECTION_TREE",total:false, isFirstSelect: true);

        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {

            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Comp_Cd
                = ctl_ComCd.EditValue?.ToString();
            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Plant_Cd
                = ctl_PlantCd.EditValue?.ToString();
            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Start_dt
                   = ctl_Start_dt.DateTime;
            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_End_dt
                    = ctl_End_dt.DateTime;
            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Item_Group_cd
                = ctl_ItemGr.EditValue?.ToString();
            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Item_cd
                = strapButtonEdit_ItemMaster1.EditValue?.ToString();
            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_direction
                = strapLookUpEdit1.EditValue?.ToString();
            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Barcode
                = strapTextEdit1.EditValue?.ToString();


            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void Ctl_PlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
            _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Plant_Cd = ctl_PlantCd.EditValue?.ToString();
            //제품군
            LookUpEditHelper.SetByQuery(ctl_ItemGr, "MasterDataControls.Item.ItemGr1"
                , new
                {
                    COMP_CD = _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Comp_Cd
                        ,
                    PLANT_CD = _woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Plant_Cd
                }
                , "Code", "Name");
            strapButtonEdit_ItemMaster1.InitCompCode(_woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Comp_Cd);
            strapButtonEdit_ItemMaster1.InitPlantCode(_woeEssLotArgs.WoeEssLotModelArgs.Select_Main_Plant_Cd);
        }
    }
}

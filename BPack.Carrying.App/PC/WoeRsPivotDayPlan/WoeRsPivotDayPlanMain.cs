using BPack.CommonMes.Helpers;
using BPack.Pocket.App.PC.WoeRsPivotDayPlan;
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

namespace BPack.Carrying.App.PC.WoeRsPivotDayPlan
{
    public partial class WoeRsPivotDayPlanMain : StrapMainForm
    {
        private WoeRsPivotDayPlanArgs _pivotDayPlanArgs;
        private WoeRsPivotDayPlanPocket _pivotDayPlanPocket;
        private WoeRsPivotDayPlanList _pivotDayPlanList;
        public WoeRsPivotDayPlanMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _pivotDayPlanArgs = new WoeRsPivotDayPlanArgs();
            _pivotDayPlanPocket = new WoeRsPivotDayPlanPocket();
            _pivotDayPlanList = new WoeRsPivotDayPlanList(_pivotDayPlanArgs, _pivotDayPlanPocket);
            AddSubForm(this, _pivotDayPlanList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _pivotDayPlanArgs,
                InitlistForm = _pivotDayPlanList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown=false
            });
            InitRibbonButtons(true, false, false, false);
            ctl_Start_dt.EditValue = DateTime.Now.AddDays(-7);
            ctl_End_dt.EditValue = DateTime.Now;
            LookUpEditHelper.SetCompCode(sleCompCd);
            sleCompCd.EditValueChanged += SleCompCd_EditValueChanged;
            slePlantCd.EditValueChanged += SlePlantCd_EditValueChanged;
            sleCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            slePlantCd.EditValue = Common.LoginInfo.UserInfo.PlantCode;
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Start_Dt = ctl_Start_dt.DateTime;
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_End_Dt = ctl_End_dt.DateTime;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Start_Dt = ctl_Start_dt.DateTime;
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_End_Dt = ctl_End_dt.DateTime;
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Item_Gr_1 = ctl_Item_gr_1.EditValue?.ToString();
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Item_Type_Cd = ctl_Item_Type.EditValue?.ToString();
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Item_Cd = ctl_Item_cd.EditValue?.ToString();
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Item_Nm = ctl_Item_nm.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
            //_pivotDayPlanList.DataRefresh(_pivotDayPlanArgs);
        }


        private void SleCompCd_EditValueChanged(object sender, EventArgs e)
        {
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Comp_Cd
                = sleCompCd.EditValue?.ToString();
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);

            LookUpEditHelper.SetItemType(ctl_Item_Type, Common.LoginInfo.UserInfo.CompCode, true, true, false);
        }
        private void SlePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
         

            LookUpEditHelper.SetByQuery(ctl_Item_gr_1
                                , "ItemGroup"
                                , new
                                {
                                    COMP_CD = _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Comp_Cd,
                                    PLANT_CD = _pivotDayPlanArgs.WoeRsPivotDayPlanModelArgs.Select_Main_Plant_Cd,
                                    ITEM_GR_CLS = "ITEM_GR_1"
                                }
                                , "Code", "Name", isTotalRow: true);
        }
    }
}

using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WoeRsPivotYearPlan;
using BPack.Pocket.App.PC.WoeRsPivotYearPlan;
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

namespace BPack.Carrying.App.PC.WoeRsPivotYearPlan
{
    public partial class WoeRsPivotYearPlanMain : StrapMainForm
    {
        WoeRsPivotYearPlanArgs _planModelArgs;
        WoeRsPivotYearPlanPocket _planPocket;
        WoeRsPivotYearPlanList _planList;
        public WoeRsPivotYearPlanMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            base.InitStrap();
            _planModelArgs = new WoeRsPivotYearPlanArgs();
            _planPocket = new WoeRsPivotYearPlanPocket();
            _planList = new WoeRsPivotYearPlanList(_planModelArgs, _planPocket);

            AddSubForm(this, _planList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _planModelArgs,
                InitlistForm = _planList,
                //IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            LookUpEditHelper.SetCompCode(ctl_ComCd);
            ctl_ComCd.EditValueChanged += Ctl_ComCd_EditValueChanged;
            ctl_PlantCd.EditValueChanged += Ctl_PlantCd_EditValueChanged;

            ctl_ComCd.EditValue = UserInfo.CompCode;
            ctl_PlantCd.EditValue = UserInfo.PlantCode;
        }


        private void Ctl_ComCd_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetPlantCode(ctl_PlantCd, new { COMP_CD = ctl_ComCd.EditValue?.ToString() }, isFirstSelect: true);
            _planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
        }
        private void Ctl_PlantCd_EditValueChanged(object sender, EventArgs e)
        {
            //SetEditorValue(ctl_ComCd, ctl_ComCd.EditValue);
            _planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Comp_Cd = ctl_ComCd.EditValue?.ToString();
            _planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plant_Cd = ctl_PlantCd.EditValue?.ToString();

        }
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Comp_Cd
                = ctl_ComCd.EditValue?.ToString();
            _planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plant_Cd
                = ctl_PlantCd.EditValue?.ToString();
            _planModelArgs.WoeRsPivotYearPlanModelArgs.Select_Main_Plan_Year_cd
                = ctl_PlanYear.DateTime.ToString("yyyy");
            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

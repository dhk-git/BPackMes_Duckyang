using BPack.CommonMes.Helpers;
using BPack.Pocket.App.SD.DlvPlan;
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

namespace BPack.Carrying.App.SD.DlvPlan
{
    public partial class DlvPlanMain : StrapMainForm
    {
        private DlvPlanArgs _dlvPlanArgs;
        private DlvPlanPocket _dlvPlanPocket;
        private SalesOrderAndPlanList _salesOrderAndPlanList;

        public DlvPlanMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _dlvPlanArgs = new DlvPlanArgs();
            _dlvPlanPocket = new DlvPlanPocket();
            _salesOrderAndPlanList = new SalesOrderAndPlanList(_dlvPlanArgs, _dlvPlanPocket);
            _dlvPlanArgs.DlvPlanModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _dlvPlanArgs.DlvPlanModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            AddSubForm(this, _salesOrderAndPlanList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _dlvPlanArgs,
                InitlistForm = _salesOrderAndPlanList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, save: true);
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
            strapDateEdit2.DateTime = DateTime.Now.Date.AddDays(7);
            chkCalc.Checked = false;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvPlanArgs.DlvPlanModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _dlvPlanArgs.DlvPlanModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _dlvPlanArgs.DlvPlanModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _dlvPlanArgs.DlvPlanModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _dlvPlanArgs.DlvPlanModelArgs.Select_Main_Item_Gr_1 = strapLookUpEdit1.EditValue?.ToString();
            _dlvPlanArgs.DlvPlanModelArgs.Select_Main_Checked_Calc = chkCalc.Checked;

            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

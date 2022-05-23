using BPack.CommonMes.Helpers;
using BPack.Pocket.App.PC.WoeNwRsPivot;
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

namespace BPack.Carrying.App.PC.WoeNwRsPivot
{
    public partial class WoeNwRsPivotMain : StrapMainForm
    {
        private WoeNwRsPivotArgs _woeNwRsPivotArgs;
        private WoeNwRsPivotPocket _woeNwRsPivotPocket;
        private WoeNwRsPivotPlanList _woeNwRsPivotPlanList;
        private WoeNwRsPivotNotWorkList _woeNwRsPivotNotWorkList;
        public WoeNwRsPivotMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _woeNwRsPivotArgs = new WoeNwRsPivotArgs();
            _woeNwRsPivotPocket = new WoeNwRsPivotPocket();
            _woeNwRsPivotPlanList = new WoeNwRsPivotPlanList(_woeNwRsPivotArgs, _woeNwRsPivotPocket);
            _woeNwRsPivotNotWorkList= new WoeNwRsPivotNotWorkList(_woeNwRsPivotArgs, _woeNwRsPivotPocket);
            _woeNwRsPivotNotWorkList.ModelAddedEvent += _woeNwRsPivotNotWorkList_ModelEvent;
            _woeNwRsPivotNotWorkList.ModelDeletedEvent+= _woeNwRsPivotNotWorkList_ModelEvent;
            _woeNwRsPivotNotWorkList.ModelUpdatedEvent += _woeNwRsPivotNotWorkList_ModelEvent;
            AddSubForm(this, _woeNwRsPivotPlanList, layoutControlGroup2);
            AddSubForm(this, _woeNwRsPivotNotWorkList, layoutControlGroup3);


            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _woeNwRsPivotArgs,
                InitlistForm = _woeNwRsPivotPlanList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });
            InitRibbonButtons(true, false, false, false);
            ctl_Start_dt.EditValue = DateTime.Now.AddDays(-7);
            ctl_End_dt.EditValue = DateTime.Now;
            LookUpEditHelper.SetCompCode(sleCompCd);
            LookUpEditHelper.SetSysCode(ctl_SearchType, "WoeNwRsPivot_SearchCondition"
                ,total:false,isFirstSelect:true,isTotalRow:false);

            sleCompCd.EditValueChanged += SleCompCd_EditValueChanged;
            slePlantCd.EditValueChanged += SlePlantCd_EditValueChanged;
            sleCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;
            slePlantCd.EditValue = Common.LoginInfo.UserInfo.PlantCode;
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Start_Dt = ctl_Start_dt.DateTime;
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_End_Dt = ctl_End_dt.DateTime;

            this.SelectedSubFormChanged += WoeNwRsPivotMain_SelectedSubFormChanged;

            _woeNwRsPivotPlanList.UserCellClick += _woeNwRsPivotPlanList_UserCellClick;

        }

        private void _woeNwRsPivotNotWorkList_ModelEvent(object sender, ArgsBase e)
        {
            _woeNwRsPivotPlanList.DataRefresh(_woeNwRsPivotArgs);
        }

        private void _woeNwRsPivotPlanList_UserCellClick(object sender, ArgsBase e)
        {
            _woeNwRsPivotNotWorkList.DataRefresh(e);
        }

        private void WoeNwRsPivotMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _woeNwRsPivotPlanList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false);
            }
            else if (this.SelectedSubForm == _woeNwRsPivotNotWorkList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true,save:true);
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Wc_Cd = ctl_Wc_Cd.EditValue?.ToString();
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Start_Dt= ctl_Start_dt.DateTime;
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_End_Dt = ctl_End_dt.DateTime;
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_SearchType = ctl_SearchType.EditValue?.ToString();


            base.Refresh_From_ExecuteByRibbonButton();
        }


        private void SleCompCd_EditValueChanged(object sender, EventArgs e)
        {
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd
                = sleCompCd.EditValue?.ToString();
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);

            
        }
        private void SlePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();


            LookUpEditHelper.SetWorkCenter(ctl_Wc_Cd
                    , _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Comp_Cd
                    , _woeNwRsPivotArgs.WoeNwRsPivotModelArgs.Select_Main_Plant_Cd
                    , isTotalRow: true);
        }

    }
}

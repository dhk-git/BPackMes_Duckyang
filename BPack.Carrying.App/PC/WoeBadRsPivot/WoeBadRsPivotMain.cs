using BPack.CommonMes.Helpers;
using BPack.Pocket.App.PC.WoeBadRsPivot;
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

namespace BPack.Carrying.App.PC.WoeBadRsPivot
{
    public partial class WoeBadRsPivotMain : StrapMainForm
    {
        private WoeBadRsPivotArgs _WoeBadRsPivotArgs;
        private WoeBadRsPivotPocket _woeBadRsPivotPocket;
        private WoeBadRsPivotList _woeBadRsPivotList;
        private WoeBadRsPivotBadList _woeBadRsPivotBadList;

        public WoeBadRsPivotMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _WoeBadRsPivotArgs = new WoeBadRsPivotArgs();
            _woeBadRsPivotPocket = new WoeBadRsPivotPocket();
            _woeBadRsPivotList = new WoeBadRsPivotList(_WoeBadRsPivotArgs, _woeBadRsPivotPocket);
            _woeBadRsPivotBadList = new WoeBadRsPivotBadList(_WoeBadRsPivotArgs, _woeBadRsPivotPocket);
            _woeBadRsPivotBadList.ModelAddedEvent += _woeBadRsPivotBadList_ModelEvent;
            _woeBadRsPivotBadList.ModelDeletedEvent += _woeBadRsPivotBadList_ModelEvent;
            _woeBadRsPivotBadList.ModelUpdatedEvent += _woeBadRsPivotBadList_ModelEvent;
            AddSubForm(this, _woeBadRsPivotList, layoutControlGroup2);
            AddSubForm(this, _woeBadRsPivotBadList, layoutControlGroup3);
            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _WoeBadRsPivotArgs,
                InitlistForm = _woeBadRsPivotList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });
            InitRibbonButtons(true, false, false, false);
            ctl_Start_dt.EditValue = DateTime.Now.AddDays(-7);
            ctl_End_dt.EditValue = DateTime.Now;
            LookUpEditHelper.SetCompCode(sleCompCd);
            LookUpEditHelper.SetSysCode(ctl_SearchType, "WoeBadRsPivot_SearchCondition"
                , total: false, isFirstSelect: true, isTotalRow: false);

            sleCompCd.EditValueChanged += SleCompCd_EditValueChanged;
            slePlantCd.EditValueChanged += SlePlantCd_EditValueChanged;
            sleCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;
            slePlantCd.EditValue = Common.LoginInfo.UserInfo.PlantCode;

            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Start_Dt = ctl_Start_dt.DateTime;
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_End_Dt = ctl_End_dt.DateTime;
            this.SelectedSubFormChanged += WoeBadRsPivotMain_SelectedSubFormChanged; ;
            _woeBadRsPivotList.UserCellClick += _woeBadRsPivotList_UserCellClick; ;
        }

        private void SlePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();


            LookUpEditHelper.SetWorkCenter(ctl_Wc_Cd
                    , _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd
                    , _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Plant_Cd
                    , isTotalRow: true);
        }

        private void SleCompCd_EditValueChanged(object sender, EventArgs e)
        {
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd
                = sleCompCd.EditValue?.ToString();
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
        }

        private void WoeBadRsPivotMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _woeBadRsPivotList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false);
            }
            else if (this.SelectedSubForm == _woeBadRsPivotBadList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: true);
            }
        }

        private void _woeBadRsPivotList_UserCellClick(object sender, ArgsBase e)
        {
            _woeBadRsPivotBadList.DataRefresh(e);
        }

        private void _woeBadRsPivotBadList_ModelEvent(object sender, ArgsBase e)
        {
            _woeBadRsPivotList.DataRefresh(e);
            _woeBadRsPivotBadList.DataRefresh(_WoeBadRsPivotArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Wc_Cd = ctl_Wc_Cd.EditValue?.ToString();
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_Start_Dt = ctl_Start_dt.DateTime;
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_End_Dt = ctl_End_dt.DateTime;
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Main_SearchType = ctl_SearchType.EditValue?.ToString();
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Item_Cd = "";
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Item_Nm = "";
            _WoeBadRsPivotArgs.WoeBadRsPivotModelArgs.Select_Sub_Work_dt = null;
            




            base.Refresh_From_ExecuteByRibbonButton();

            _woeBadRsPivotBadList.DataRefresh(_WoeBadRsPivotArgs);
        }
    }
}

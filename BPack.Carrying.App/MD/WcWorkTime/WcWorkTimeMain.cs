using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.WcWorkTime;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.WcWorkTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.WcWorkTime
{
    public partial class WcWorkTimeMain : StrapMainForm
    {
        private WcWorkTimeArgs _wcWorkTimeArgs;
        private WcWorkTimeWorkCenterList _wcWorkTimeWorkCenterList;
        private WcWorkTimeWorkTimeList _wcWorkTimeWorkTimeList;
        private WcWorkTimePocket _wcWorkTimePocket;
        
        public WcWorkTimeMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _wcWorkTimeArgs = new WcWorkTimeArgs();
            _wcWorkTimePocket = new WcWorkTimePocket();
            _wcWorkTimeWorkCenterList = new WcWorkTimeWorkCenterList(_wcWorkTimeArgs, _wcWorkTimePocket);
            _wcWorkTimeWorkTimeList = new WcWorkTimeWorkTimeList(_wcWorkTimeArgs, _wcWorkTimePocket);

            AddSubForm(this, _wcWorkTimeWorkCenterList, layoutControlGroup2);
            AddSubForm(this, _wcWorkTimeWorkTimeList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _wcWorkTimeArgs,
                InitlistForm = _wcWorkTimeWorkCenterList,
                StrapLayout = strapLayout1
            });
            _wcWorkTimeWorkCenterList.AddRefreshTargetSubForm(_wcWorkTimeWorkTimeList);
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                _wcWorkTimeArgs.WcWorkTimeModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
                _wcWorkTimeWorkCenterList.DataRefresh(_wcWorkTimeArgs);
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _wcWorkTimeArgs.WcWorkTimeModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
                _wcWorkTimeWorkTimeList.DataRefresh(_wcWorkTimeArgs);
            };

            _wcWorkTimeWorkCenterList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _wcWorkTimeArgs.WcWorkTimeModelArgs.Select_WorkCenter_CD = ((WcWorkTimeWorkCenterModel)e.SelectedModelArgsBase.SelectedModelBase).WC_CD;
                _wcWorkTimeWorkTimeList.DataRefresh(_wcWorkTimeArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _wcWorkTimeWorkCenterList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                if (this.SelectedSubForm == _wcWorkTimeWorkTimeList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}

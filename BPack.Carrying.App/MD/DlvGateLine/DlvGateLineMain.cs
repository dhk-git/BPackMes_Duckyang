using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvGateLine;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.DlvGateLine;
using DevExpress.Utils.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvGateLine
{
    public partial class DlvGateLineMain : StrapMainForm
    {
        private DlvGateLineArgs _dlvGateLineArgs;
        private DlvGateLinePocket _dlvGateLinePocket;
        private PartnerList _partnerList;
        private GateList _gateList;

        public DlvGateLineMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _dlvGateLineArgs = new DlvGateLineArgs();
            _dlvGateLinePocket = new DlvGateLinePocket();
            _partnerList = new PartnerList(_dlvGateLineArgs, _dlvGateLinePocket);
            _gateList = new GateList(_dlvGateLineArgs, _dlvGateLinePocket);

            AddSubForm(this, _partnerList, layoutControlGroup2);
            AddSubForm(this, _gateList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs= _dlvGateLineArgs,
                InitlistForm = _partnerList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);

                _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();

                _partnerList.DataRefresh(_dlvGateLineArgs);
                _gateList.DataRefresh(_dlvGateLineArgs);
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

                _partnerList.DataRefresh(_dlvGateLineArgs);
                _gateList.DataRefresh(_dlvGateLineArgs);
            };

            _partnerList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _dlvGateLineArgs.DlvGateLineModelArgs.Select_Partners_Gate_Code = ((DlvGateLinePartnerModel)e.SelectedModelArgsBase.SelectedModelBase).GATE_CD;

                _gateList.DataRefresh(_dlvGateLineArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _partnerList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                if (this.SelectedSubForm == _gateList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;

        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _dlvGateLineArgs.DlvGateLineModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }
     }
}

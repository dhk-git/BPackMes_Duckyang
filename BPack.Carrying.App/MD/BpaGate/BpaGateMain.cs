using BPack.Common.Pocket;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.BpaGate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.BpaGate
{
    public partial class BpaGateMain : StrapMainForm
    {
        BpaGateArgs _bpaGateArgs;
        BpaGatePocket _bpaGatePocket;
        BpList _bpList;
        GateList _gateList;

        public BpaGateMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _bpaGateArgs = new BpaGateArgs();
            _bpaGatePocket = new BpaGatePocket();
            _bpList = new BpList(_bpaGateArgs, _bpaGatePocket);
            _gateList = new GateList(_bpaGateArgs, _bpaGatePocket);

            _bpList.ModelSelectedEvent += ParentCode_SelectedEvent;
            this.SelectedSubFormChanged += BpaInfoMain_SelectedSubFormChanged;

            AddSubForm(this, _bpList, layoutControlGroup2);
            AddSubForm(this, _gateList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _bpaGateArgs,
                InitlistForm = _bpList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true, true);

            LookUpEditHelper.SetByQuery(lueCOMP_CD, "CompList", null, "CODE", "NAME");
        }

        private void ParentCode_SelectedEvent(object sender, ArgsBase e)
        {
            _bpaGateArgs.bpaGateModelArgs.Select_Comp_Cd = ((Model.App.MD.BpaGate.BparModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _bpaGateArgs.bpaGateModelArgs.Select_Bp_Cd   = ((Model.App.MD.BpaGate.BparModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            _gateList.DataRefresh(_bpaGateArgs);
        }

        private void BpaInfoMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _bpList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false);
            }
            if (this.SelectedSubForm == _gateList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            lueCOMP_CD.EditValue = Common.LoginInfo.UserInfo.CompCode;
            base.OnShown(e);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _bpaGateArgs.bpaGateModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString() ?? "";

            base.Refresh_From_ExecuteByRibbonButton();
        }

        //public override void InitPocket(PocketBase Pocket)
        //{
        //    _bpaGatePocket = (BpaGatePocket)Pocket;
        //}
    }

}

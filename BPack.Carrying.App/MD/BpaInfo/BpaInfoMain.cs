using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.BpaInfo;
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

namespace BPack.Carrying.App.MD.BpaInfo
{
    public partial class BpaInfoMain : StrapMainForm
    {

        private BpaInfoArgs _bpaInfoArgs;
        private BpaInfoPocket _bpaInfoPocket;
        private BpList _bpList;
        private ContactList _contactList;

        public BpaInfoMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _bpaInfoArgs = new BpaInfoArgs();
            _bpaInfoPocket = new BpaInfoPocket();
            _bpList = new BpList(_bpaInfoArgs, _bpaInfoPocket);
            _contactList = new ContactList(_bpaInfoArgs, _bpaInfoPocket);

            _bpList.ModelSelectedEvent += ParentCode_SelectedEvent;
            this.SelectedSubFormChanged += BpaInfoMain_SelectedSubFormChanged;

            AddSubForm(this, _bpList, layoutControlGroup2);
            AddSubForm(this, _contactList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _bpaInfoArgs,
                InitlistForm = _bpList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true,true,true,true,true);

            LookUpEditHelper.SetByQuery(lueCOMP_CD, "CompList", null, "CODE", "NAME");
            
        }

        private void BpaInfoMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _bpList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save:false);
            }
            if (this.SelectedSubForm == _contactList)
            {
                SetRibbonButtonsEnable_ByAuth(save: true, edit: false);
            }
        }

        private void ParentCode_SelectedEvent(object sender, ArgsBase e)
        {
            //_bpaInfoArgs.bpaInfoModelArgs.Select_Comp_Cd = ((Model.App.MD.BpaInfo.BparModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            //_bpaInfoArgs.bpaInfoModelArgs.Select_Bp_Cd = ((Model.App.MD.BpaInfo.BparModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            //_contactList.DataRefresh(_bpaInfoArgs);
        }

        protected override void OnShown(EventArgs e)
        {
            lueCOMP_CD.EditValue = Common.LoginInfo.UserInfo.CompCode;
            base.OnShown(e);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _bpaInfoArgs.bpaInfoModelArgs.Select_Main_Comp_Cd = lueCOMP_CD.EditValue?.ToString();
            _bpaInfoArgs.bpaInfoModelArgs.Select_Main_Bp_Cd = txtBP_CD.EditValue?.ToString();
            _bpaInfoArgs.bpaInfoModelArgs.Select_Main_Bp_Nm = txtBP_NM.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }
                
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Common.Pocket;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MI.CommonCodeManager;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MI.CommonCodeManager
{
    public partial class CommonCodeManagerMain : Strap.FormControls.StrapMainForm
    {
        private CommonCodeManagerArgs _commonCodeManagerArgs;
        private CommonCodeManagerPocket _commonCodeManagerPocket;
        private ParentCode _parentCode;
        private ChildCode _childCode;

        public CommonCodeManagerMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _commonCodeManagerArgs = new CommonCodeManagerArgs();
            _commonCodeManagerPocket = new CommonCodeManagerPocket();
            _parentCode = new ParentCode(_commonCodeManagerArgs, _commonCodeManagerPocket);
            _childCode = new ChildCode(_commonCodeManagerArgs, _commonCodeManagerPocket);
            AddSubForm(this, _parentCode, layoutControlGroup3);
            AddSubForm(this, _childCode, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _commonCodeManagerArgs,
                InitlistForm = _parentCode,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });
            InitRibbonButtons(true, true, true, true);
            _parentCode.ModelSelectedEvent += ParentCode_ModelSelectedEvent;
            LookUpEditHelper.SetCompCode(lookUpEdit1);
            lookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
            this.SelectedSubFormChanged += CommonCodeManagerMain_SelectedSubFormChanged;
        }

        private void CommonCodeManagerMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _parentCode)
            {
                SetRibbonButtonsEnable_ByAuth(edit: true, save: false);
            }
            else if (this.SelectedSubForm == _childCode)
            {
                SetRibbonButtonsEnable_ByAuth(edit: false, save: true);
            }
            
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _commonCodeManagerArgs.CommonCodeManagerModelArgs.Select_Comp_Code = lookUpEdit1.EditValue?.ToString();
            _commonCodeManagerArgs.CommonCodeManagerModelArgs.Select_Main_PCode = strapTextEdit1.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void ParentCode_ModelSelectedEvent(object sender, Strap.FormControls.ArgsBase e)
        {
            _commonCodeManagerArgs.CommonCodeManagerModelArgs.Select_PCode = ((Model.App.MI.CommonCodeManager.ParentCodeModel)e.SelectedModelArgsBase.SelectedModelBase).P_CODE;
            _childCode.DataRefresh(e);
        }

 
    }
}

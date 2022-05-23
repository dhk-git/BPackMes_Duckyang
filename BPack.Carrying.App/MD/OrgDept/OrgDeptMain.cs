using BPack.Common.Pocket;
using BPack.Model.App.MD.OrgDept;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgDept;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.OrgDept
{
    public partial class OrgDeptMain : StrapMainForm
    {
        OrgDeptArgs _orgDeptArgs;
        OrgDeptPocket _orgDeptPocket;
        OrgDeptList _orgDeptList;
        OrgCompList _orgCompList;

        public OrgDeptMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _orgDeptArgs = new OrgDeptArgs();
            _orgDeptPocket = new OrgDeptPocket();
            _orgDeptList = new OrgDeptList(_orgDeptArgs, _orgDeptPocket);
            _orgCompList = new OrgCompList(_orgDeptArgs, _orgDeptPocket);
            AddSubForm(this, _orgCompList, layoutControlGroup2);
            AddSubForm(this, _orgDeptList, layoutControlGroup3);
            _orgCompList.AddRefreshTargetSubForm(_orgDeptList);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _orgDeptArgs,
                InitlistForm = _orgCompList,
                StrapLayout = strapLayout1
            });
            _orgCompList.ModelSelectedEvent += ParentCode_SelectedEvent;
            this.SelectedSubFormChanged += OrgDeptMain_SelectedSubFormChanged;
            InitRibbonButtons(true);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void OrgDeptMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _orgCompList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false);
            }
            if (this.SelectedSubForm == _orgDeptList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true);
            }
        }

        private void ParentCode_SelectedEvent(object sender, ArgsBase e)
        {
            _orgDeptArgs.orgDeptModelArgs.Select_Comp_Code = ((CompModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _orgDeptArgs.orgDeptModelArgs.Select_Main_Dept_Code = strapTextEdit1.EditValue?.ToString();
            _orgDeptArgs.orgDeptModelArgs.Select_Main_Dept_Name = strapTextEdit2.EditValue?.ToString();
            _orgDeptList.DataRefresh(_orgDeptArgs);
        }


    }
}

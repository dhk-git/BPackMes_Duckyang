using BPack.Common.Pocket;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.OrgComp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.OrgComp
{
    public partial class OrgCompMain : StrapMainForm
    {
        private OrgCompArgs _orgCompArgs;
        private OrgCompPocket _orgCompPocket;
        private OrgCompList _orgCompList;

        public OrgCompMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _orgCompArgs = new OrgCompArgs();
            _orgCompPocket = new OrgCompPocket();
            _orgCompList = new OrgCompList(_orgCompArgs, _orgCompPocket);
            AddSubForm(this, _orgCompList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _orgCompArgs,
                InitlistForm = _orgCompList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _orgCompArgs.orgCompModelArgs.Select_Main_Comp_Code = strapTextEdit1.EditValue?.ToString();
            _orgCompArgs.orgCompModelArgs.Select_Main_Comp_Name = strapTextEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

 
    }
}

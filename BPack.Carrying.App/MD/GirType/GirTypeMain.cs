using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.GirType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.GirType
{
    public partial class GirTypeMain : StrapMainForm
    {
        private GirTypePocket _girTypePocket;
        private GirTypeArgs _girTypeArgs;
        private GirTypeList _girTypeList;

        public GirTypeMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _girTypeArgs = new GirTypeArgs();
            _girTypePocket = new GirTypePocket();
            _girTypeList = new GirTypeList(_girTypeArgs, _girTypePocket);

            AddSubForm(this, _girTypeList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _girTypeArgs,
                InitlistForm = _girTypeList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _girTypeArgs.girTypeModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

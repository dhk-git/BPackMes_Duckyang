using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.MolInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.MolInfo
{
    public partial class MolInfoMain : StrapMainForm
    {
        MolInfoPocket _molInfoPocket;
        MolInfoArgs _molInfoArgs;
        MoldList _moldList;

        public MolInfoMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _molInfoArgs = new MolInfoArgs();
            _molInfoPocket = new MolInfoPocket();
            _moldList = new MoldList(_molInfoArgs, _molInfoPocket);

            AddSubForm(this, _moldList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _molInfoArgs,
                InitlistForm = _moldList,
               StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };


        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _molInfoArgs.MolInfoModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _molInfoArgs.MolInfoModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _molInfoArgs.MolInfoModelArgs.Select_Main_Mold_Code = strapTextEdit1.EditValue?.ToString();
            _molInfoArgs.MolInfoModelArgs.Select_Main_Mold_Name = strapTextEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}

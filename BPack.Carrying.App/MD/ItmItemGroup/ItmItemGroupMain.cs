using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmItemGroup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.ItmItemGroup
{
    public partial class ItmItemGroupMain : StrapMainForm
    {
        private ItmItemGroupPocket _itmItemGroupPocket;
        private ItmItemGroupArgs _itmItemGroupArgs;
        private ItemGroupList _itemGroupList;

        public ItmItemGroupMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _itmItemGroupArgs = new ItmItemGroupArgs();
            _itmItemGroupPocket = new ItmItemGroupPocket();
            _itemGroupList = new ItemGroupList(_itmItemGroupArgs, _itmItemGroupPocket);

            AddSubForm(this, _itemGroupList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _itmItemGroupArgs,
                InitlistForm = _itemGroupList,
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
            _itmItemGroupArgs.itmItemGroupModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _itmItemGroupArgs.itmItemGroupModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

        
    }
}

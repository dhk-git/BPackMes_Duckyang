using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.MolItem;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.MolInfo;
using BPack.Pocket.App.MD.MolItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.MolItem
{
    public partial class MolItemMain : StrapMainForm
    {
        private MolItemArgs _molItemArgs;
        private MolItemPocket _molItemPocket;
        private MoldList _moldList;
        private ItemList _itemList;

        public MolItemMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _molItemArgs = new MolItemArgs();
            _molItemPocket = new MolItemPocket();
            _moldList = new MoldList(_molItemArgs, _molItemPocket);
            _itemList = new ItemList(_molItemArgs, _molItemPocket);

            AddSubForm(this, _moldList, layoutControlGroup2);
            AddSubForm(this, _itemList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _molItemArgs,
                InitlistForm = _moldList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };

            _moldList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _molItemArgs.MolItemModelArgs.Select_Mold_Code = ((MoldListModel)e.SelectedModelArgsBase.SelectedModelBase).MOLD_CD;

                _itemList.DataRefresh(_molItemArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _moldList) { SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false); }
                if (this.SelectedSubForm == _itemList) { SetRibbonButtonsEnable_ByAuth(add: true, save:true, delete: true); }
            };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _molItemArgs.MolItemModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _molItemArgs.MolItemModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _molItemArgs.MolItemModelArgs.Select_Main_Mold_Code = strapTextEdit1.EditValue?.ToString();
            _molItemArgs.MolItemModelArgs.Select_Main_Mold_Name = strapTextEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}

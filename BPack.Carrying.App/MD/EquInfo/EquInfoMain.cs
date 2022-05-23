using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.EquInfo;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.EquInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.EquInfo
{
    public partial class EquInfoMain : StrapMainForm
    {
        EquInfoArgs _equInfoArgs;
        EquInfoPocket _equInfoPocket;

        EquList _equList;
        CheckList _checkList;

        public EquInfoMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _equInfoArgs = new EquInfoArgs();
            _equInfoPocket = new EquInfoPocket();
            _equList = new EquList(_equInfoArgs, _equInfoPocket);
            _checkList = new CheckList(_equInfoArgs, _equInfoPocket);

            AddSubForm(this, _equList, layoutControlGroup2);
            AddSubForm(this, _checkList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _equInfoArgs,
                InitlistForm = _equList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(refresh: true, add: true, delete: true, save: true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _equList) { SetRibbonButtonsEnable_ByAuth(refresh: true, add: true, delete: true, save: true); }
                if (this.SelectedSubForm == _checkList) { SetRibbonButtonsEnable_ByAuth(refresh: true, add: true, delete: true, save: true); }
            };

            _equList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _equInfoArgs.EquInfoModelArgs.Select_Equip_Code = ((EquInfoEquipModel)e.SelectedModelArgsBase.SelectedModelBase).EQUIP_CD;

                _checkList.DataRefresh(_equInfoArgs);
            };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _equInfoArgs.EquInfoModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _equInfoArgs.EquInfoModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}

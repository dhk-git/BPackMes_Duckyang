using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmItemType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Model.App.MD.ItmItemType;

namespace BPack.Carrying.App.MD.ItmItemType
{
    public partial class ItmItemTypeMain : StrapMainForm
    {
        private ItmItemTypePocket _itmItemTypePocket;
        private ItmItemTypeArgs _itmItemTypeArgs;

        private ItemTypeList _itemTypeList;
        private ItemTypeItemList _itemTypeItemList;

        public ItmItemTypeMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {

            _itmItemTypeArgs = new ItmItemTypeArgs();
            _itmItemTypePocket = new ItmItemTypePocket();
            _itemTypeList = new ItemTypeList(_itmItemTypeArgs, _itmItemTypePocket);
            _itemTypeItemList = new ItemTypeItemList(_itmItemTypeArgs, _itmItemTypePocket);
            AddSubForm(this, _itemTypeList, layoutControlGroup2);
            AddSubForm(this, _itemTypeItemList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _itmItemTypeArgs,
                InitlistForm = _itemTypeList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });
            InitRibbonButtons(true, true, true, true);
            this.SelectedSubFormChanged += ItmItemTypeMain_SelectedSubFormChanged;

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);


            _itemTypeList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _itmItemTypeArgs.itmItemTypeModelArgs.Select_Main_Comp_Code = ((ItemTypeModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                _itmItemTypeArgs.itmItemTypeModelArgs.Select_ITEM_TYPE_CD = ((ItemTypeModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_TYPE_CD;

                _itemTypeItemList.DataRefresh(_itmItemTypeArgs);

                //_checkList.DataRefresh(_qciInspStdArgs);

            };

        }

        private void ItmItemTypeMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _itemTypeList)
            {
                SetRibbonButtonsEnable_ByAuth(save: false, edit: true);
            }
            if (this.SelectedSubForm == _itemTypeItemList)
            {
                SetRibbonButtonsEnable_ByAuth(save: true, edit: false);
            }

        }

        protected override void OnShown(EventArgs e)
        {
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
            base.OnShown(e);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _itmItemTypeArgs.itmItemTypeModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (_itmItemTypeArgs.itmItemTypeModelArgs.Select_Main_Comp_Code == null || _itmItemTypeArgs.itmItemTypeModelArgs.Select_ITEM_TYPE_CD == null)
            {
                MessageBox.Show("품목유형이 선택되지 않았습니다.");
                return;
            }
            _itmItemTypePocket.SaveItemTypeItemDefaultModel(new ItemTypeModel
            {
                COMP_CD_KEY = _itmItemTypeArgs.itmItemTypeModelArgs.Select_Main_Comp_Code,
                ITEM_TYPE_CD_KEY = _itmItemTypeArgs.itmItemTypeModelArgs.Select_ITEM_TYPE_CD,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
            });

            _itemTypeItemList.DataRefresh(_itmItemTypeArgs);
        }
    }
}

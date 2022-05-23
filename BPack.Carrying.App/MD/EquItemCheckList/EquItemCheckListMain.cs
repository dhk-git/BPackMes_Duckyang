using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.EquItemCheckList;
using BPack.Pocket.App.MD.EquItemCheckList;
using BPack.Strap.FormControls;
using System;

namespace BPack.Carrying.App.MD.EquItemCheckList
{
    public partial class EquItemCheckListMain : StrapMainForm
    {
        EquItemCheckListArgs _equItemCheckListArgs;
        EquItemCheckListPocket _equItemCheckListPocket;

        EquipList _equipList;
        ItemList _itemList;
        CheckList _checkList;

        public EquItemCheckListMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _equItemCheckListArgs = new EquItemCheckListArgs();
            _equItemCheckListPocket = new EquItemCheckListPocket();
            _equipList = new EquipList(_equItemCheckListArgs, _equItemCheckListPocket);
            _itemList = new ItemList(_equItemCheckListArgs, _equItemCheckListPocket);
            _checkList = new CheckList(_equItemCheckListArgs, _equItemCheckListPocket);

            AddSubForm(this, _equipList, layoutControlGroup2);
            AddSubForm(this, _itemList, layoutControlGroup3);
            AddSubForm(this, _checkList, layoutControlGroup4);

            _equipList.AddRefreshTargetSubForm(_itemList);
            _itemList.AddRefreshTargetSubForm(_checkList);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _equItemCheckListArgs,
                InitlistForm = _equipList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(refresh: true, add: false, delete: false, save: false);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _equipList) { SetRibbonButtonsEnable_ByAuth(refresh: true, add: false, delete: false, save: false); }
                if (this.SelectedSubForm == _itemList) { SetRibbonButtonsEnable_ByAuth(refresh: true, edit: false, add: true, delete: true, save: true); }
                if (this.SelectedSubForm == _checkList) { SetRibbonButtonsEnable_ByAuth(refresh: true, add: true, delete: true, save: true); }
            };

            _equipList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Equip_Code = ((EquItemCheckListEquipModel)e.SelectedModelArgsBase.SelectedModelBase).EQUIP_CD;

                _itemList.DataRefresh(_equItemCheckListArgs);
                _checkList.DataRefresh(_equItemCheckListArgs);
            };

            _itemList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Item_Code = ((EquItemCheckListItemModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;

                _checkList.DataRefresh(_equItemCheckListArgs);
            };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}

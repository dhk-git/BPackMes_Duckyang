using BPack.IStrap.Forms;
using BPack.Model.App.MD.ItmBomTree;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmBomTree;
using System;
using BPack.CommonMes.Helpers;
using System.Collections.Generic;

namespace BPack.Carrying.App.MD.ItmBomTree
{
    public partial class ItmBomTreeMain : StrapMainForm
    {
        private ItmBomTreeArgs _itmBomTreeArgs = new ItmBomTreeArgs();
        private ItmBomTreePocket _itmBomTreePocket = new ItmBomTreePocket();
        private ItemBomList _itemBomList;
        private BomTreeList _bomTreeList;

        public ItmBomTreeMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Comp_Code = Common.LoginInfo.UserInfo.CompCode;

            _itemBomList = new ItemBomList(_itmBomTreeArgs, _itmBomTreePocket);
            _bomTreeList = new BomTreeList(_itmBomTreeArgs, _itmBomTreePocket);

            AddSubForm(this, _itemBomList, layoutControlGroup6);
            AddSubForm(this, _bomTreeList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _itmBomTreeArgs,
                InitlistForm = _itemBomList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });
            InitRibbonButtons(true, true, true, true);

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _itemBomList) { SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: false); }
                if (this.SelectedSubForm == _bomTreeList) { SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: false); }
            };

            _itemBomList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _itmBomTreeArgs.itmBomTreeModelArgs.Select_ItemBom_Comp_Code = ((ItemBomModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                _itmBomTreeArgs.itmBomTreeModelArgs.Select_ItemBom_Plant_Code = ((ItemBomModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
                _itmBomTreeArgs.itmBomTreeModelArgs.Select_ItemBom_Item_Code = ((ItemBomModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
                _itmBomTreeArgs.itmBomTreeModelArgs.Select_ItemBom_Bom_No = ((ItemBomModel)e.SelectedModelArgsBase.SelectedModelBase).BOM_NO;
                // _itmBomTreeArgs.itmBomTreeModelArgs.Select_ItemBom_Apply_Date = ((ItemBomModel)e.SelectedModelArgsBase.SelectedModelBase).APPLY_DT?.Date.ToString("yyyy-MM-dd");

                _bomTreeList.DataRefresh(_itmBomTreeArgs);
            };

            _bomTreeList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _itmBomTreeArgs.itmBomTreeModelArgs.Select_BomTree_Comp_Code = ((BomTreeModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                _itmBomTreeArgs.itmBomTreeModelArgs.Select_BomTree_Plant_Code = ((BomTreeModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
                _itmBomTreeArgs.itmBomTreeModelArgs.Select_BomTree_Item_Code = ((BomTreeModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
                _itmBomTreeArgs.itmBomTreeModelArgs.Select_BomTree_Child_Item_Code = ((BomTreeModel)e.SelectedModelArgsBase.SelectedModelBase).CHILD_ITEM_CD;
               // _itmBomTreeArgs.itmBomTreeModelArgs.Select_BomTree_Apply_Date = ((BomTreeModel)e.SelectedModelArgsBase.SelectedModelBase).APPLY_DT?.Date.ToString("yyyy-MM-dd");

                //bomTreeModelBindingSource.DataSource = (BomTreeModel)e.SelectedModelArgsBase.SelectedModelBase;
            };

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        public override void ExecuteByRibbonButton(ButtonKind buttonKind)
        {
            _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Item_Code = strapTextEdit1.EditValue?.ToString();
            _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Item_Name = strapTextEdit2.EditValue?.ToString();
            _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Apply_Date = strapDateEdit1.DateTime;
            //_itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Item_Group_1 = strapTextEdit3.EditValue?.ToString();
            //_itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_ALC_Code = strapTextEdit4.EditValue?.ToString();

            _bomTreeList.bomTreeModelBindingSource.Clear();
            
            base.ExecuteByRibbonButton(buttonKind);
        }

        private void strapDateEdit1_EditValueChanged(object sender, EventArgs e)
        {
           // _itmBomTreeArgs.itmBomTreeModelArgs.Select_Main_Apply_Date = strapDateEdit1.DateTime.ToString("yyyy-MM-dd");
        }
    }
}

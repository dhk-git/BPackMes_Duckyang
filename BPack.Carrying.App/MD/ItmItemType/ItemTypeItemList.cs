using BPack.Common.Model;
using BPack.Model.App.MD.ItmItemType;
using BPack.Pocket.App.MD.ItmItemType;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.ItmItemType
{
    public partial class ItemTypeItemList : StrapSubForm_OnlyOneGrid_V2
    {
        ItmItemTypeArgs _itmItemTypeArgs;
        ItmItemTypePocket _itmItemTypePocket;

        public ItemTypeItemList(ItmItemTypeArgs itmItemTypeArgs, ItmItemTypePocket itmItemTypePocket)
        {
            InitializeComponent();

            _itmItemTypeArgs = itmItemTypeArgs;
            _itmItemTypePocket = itmItemTypePocket;

        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = itemTypeItemModelBindingSource,
                FormArgs = _itmItemTypeArgs,
                ModelArgs = _itmItemTypeArgs.itmItemTypeModelArgs,
                InitModelType = typeof(ItemTypeItemModel),
                GridView = gridView1,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<ItmItemTypeModelArgs, ItemTypeItemModel>(_itmItemTypePocket.SelectItemTypeItemModels, _itmItemTypePocket.SaveItemTypeItemModel, _itmItemTypePocket.SaveItemTypeItemModels);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ItemTypeItemModel)model).COMP_CD = _itmItemTypeArgs.itmItemTypeModelArgs.Select_Main_Comp_Code;
            ((ItemTypeItemModel)model).ITEM_TYPE_CD = _itmItemTypeArgs.itmItemTypeModelArgs.Select_ITEM_TYPE_CD;
            base.SetInsertDefaultValue(model);
        }

    }
}

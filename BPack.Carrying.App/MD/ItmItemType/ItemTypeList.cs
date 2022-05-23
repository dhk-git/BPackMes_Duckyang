using BPack.Common.Model;
using BPack.Model.App.MD.ItmItemType;
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
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.ItmItemType
{
    public partial class ItemTypeList : StrapSubForm_OnlyOneGrid_V2
    {
        ItmItemTypeArgs _itmItemTypeArgs;
        ItmItemTypePocket _itmItemTypePocket;

        public ItemTypeList(ItmItemTypeArgs itmItemTypeArgs, ItmItemTypePocket itmItemTypePocket)
        {
            InitializeComponent();

            _itmItemTypeArgs = itmItemTypeArgs;
            _itmItemTypePocket = itmItemTypePocket;

        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = itemTypeModelBindingSource,
                FormArgs = _itmItemTypeArgs,
                ModelArgs = _itmItemTypeArgs.itmItemTypeModelArgs,
                InitModelType = typeof(ItemTypeModel),
                GridView = gridView1
            });
            InitPocketDelegate<ItmItemTypeModelArgs, ItemTypeModel>(_itmItemTypePocket.SelectItemTypeModels, _itmItemTypePocket.SaveItemTypeModel);

            LookUpEditHelper.SetGridColumnSysCode(colITEM_TYPE_CLS, "ITEM_TYPE_CLS");
            LookUpEditHelper.SetGridColumnSysCode(colINV_GR, "INV_GR");
            
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((ItemTypeModel)model).COMP_CD = _itmItemTypeArgs.itmItemTypeModelArgs.Select_Main_Comp_Code;
        }
    }
}

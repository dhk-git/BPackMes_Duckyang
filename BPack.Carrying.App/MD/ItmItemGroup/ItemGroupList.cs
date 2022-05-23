using BPack.Common.Model;
using BPack.Model.App.MD.ItmItemGroup;
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
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.ItmItemGroup
{
    public partial class ItemGroupList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmItemGroupArgs _itmItemGroupArgs;
        private ItmItemGroupPocket _itmItemGroupPocket;

        public ItemGroupList(ItmItemGroupArgs itmItemGroupArgs, ItmItemGroupPocket itmItemGroupPocket)
        {
            InitializeComponent();

            _itmItemGroupArgs = itmItemGroupArgs;
            _itmItemGroupPocket = itmItemGroupPocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = itemGroupModelBindingSource,
                FormArgs = _itmItemGroupArgs,
                ModelArgs = _itmItemGroupArgs.itmItemGroupModelArgs,
                InitModelType = typeof(ItemGroupModel),
                GridView = gridView1
            });
            InitPocketDelegate<ItmItemGroupModelArgs, ItemGroupModel>(_itmItemGroupPocket.SelectItemGroupModels, _itmItemGroupPocket.SaveItemGroupModel);

            LookUpEditHelper.SetGridColumnSysCode(colITEM_GR_CLS, "ITEM_GR_CLS");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((ItemGroupModel)model).COMP_CD = _itmItemGroupArgs.itmItemGroupModelArgs.Select_Main_Comp_Code;
            ((ItemGroupModel)model).PLANT_CD = _itmItemGroupArgs.itmItemGroupModelArgs.Select_Main_Plant_Code;
        }
    }
}

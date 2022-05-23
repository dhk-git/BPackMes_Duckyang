using BPack.Common.Model;
using BPack.Model.App.MD.ItmItemInfo;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmItemInfo;
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

namespace BPack.Carrying.App.MD.ItmItemInfo
{
    public partial class ConvFactorList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmItemInfoArgs _itmItemInfoArgs;
        private ItmItemInfoPocket _itmItemInfoPocket;

        public ConvFactorList(ItmItemInfoArgs itmItemInfoArgs, ItmItemInfoPocket itmItemInfoPocket)
        {
            InitializeComponent();

            _itmItemInfoArgs = itmItemInfoArgs;
            _itmItemInfoPocket = itmItemInfoPocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = itemConvModelBindingSource,
                FormArgs = _itmItemInfoArgs,
                ModelArgs = _itmItemInfoArgs.itmItemInfoModelArgs,
                InitModelType = typeof(ItemConvModel),
                GridView = gridView1
            });
            InitPocketDelegate<ItmItemInfoModelArgs, ItemConvModel>(_itmItemInfoPocket.SelectItemConvModels, _itmItemInfoPocket.SaveItemConvModel);
            LookUpEditHelper.SetGridColumnCommonCode(colTARGET_UNIT, Common.LoginInfo.UserInfo.CompCode, "UNIT");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((ItemConvModel)model).COMP_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Comp_Code;
            ((ItemConvModel)model).PLANT_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Plant_Code;
            ((ItemConvModel)model).ITEM_CD = _itmItemInfoArgs.itmItemInfoModelArgs.Select_Item_Code;
        }
    }
}

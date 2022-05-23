using BPack.Common.Model;
using BPack.Model.App.MD.ItmBom;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.ItmBom;
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

namespace BPack.Carrying.App.MD.ItmBom
{
    public partial class ItemList : StrapSubForm_OnlyOneGrid_V2
    {
        private ItmBomArgs _ItmBomMainArgs;
        private ItmBomPocket _itmBomPocket;

        public ItemList(ItmBomArgs ItmBomMainArgs, ItmBomPocket itmBomPocket)
        {
            InitializeComponent();

            _ItmBomMainArgs = ItmBomMainArgs;
            _itmBomPocket = itmBomPocket;
        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = itemInfoModelBindingSource,
                FormArgs = _ItmBomMainArgs,
                ModelArgs = _ItmBomMainArgs.itmBomModelArgs,
                InitModelType = typeof(ItemInfoModel),
                GridView = gridView1
            });
            InitPocketDelegate<ItmBomModelArgs, ItemInfoModel>(_itmBomPocket.SelectitemInfoModels, null);

            LookUpEditHelper.SetGridColumnSysCode(colMAT_INPUT_TYPE, "MAT_INPUT_TYPE");
            LookUpEditHelper.SetGridColumnSysCode(colINDI_HU_FG, "INDI_HU_FG");

            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroupDetail", new { COMP_CD = "", PLANT_CD = "", ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_2, "ItemGroupDetail", new { COMP_CD = "", PLANT_CD = "", ITEM_GR_CLS = "ITEM_GR_2" }, "CODE", "NAME");

            colITEM_CD.MinWidth = 170;
            colITEM_NM.MinWidth = 220;

        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((ItemInfoModel)model).COMP_CD = _ItmBomMainArgs.itmBomModelArgs.Select_Main_Comp_Code;
            ((ItemInfoModel)model).PLANT_CD = _ItmBomMainArgs.itmBomModelArgs.Select_Main_Plant_Code;
            ((ItemInfoModel)model).ITEM_CD = _ItmBomMainArgs.itmBomModelArgs.Select_Main_Item_Code;
            ((ItemInfoModel)model).ITEM_NM = _ItmBomMainArgs.itmBomModelArgs.Select_Main_Item_Name;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE, "ItemType", new { COMP_CD = _ItmBomMainArgs.itmBomModelArgs.Select_Main_Comp_Code }, "CODE", "NAME");
            //LookUpEditHelper.SetGridColumnCommonCode(colITEM_TYPE, _ItmBomMainArgs.itmBomModelArgs.Select_Main_Comp_Code, "ITEM_TYPE");
            LookUpEditHelper.SetGridColumnCommonCode(colHU_UNIT, _ItmBomMainArgs.itmBomModelArgs.Select_Main_Comp_Code, "UNIT");
            LookUpEditHelper.SetGridColumnCommonCode(colBASE_UNIT, _ItmBomMainArgs.itmBomModelArgs.Select_Main_Comp_Code, "UNIT");
            LookUpEditHelper.SetGridColumnCommonCode(colWEIGHT_UNIT, _ItmBomMainArgs.itmBomModelArgs.Select_Main_Comp_Code, "UNIT");
        }
    }
}

using BPack.Model.App.MM.GirStock;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirStock;
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

namespace BPack.Carrying.App.MM.GirStock
{
    public partial class StockList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirStockArgs _girStockArgs;
        private GirStockPocket _girStockPocket;

        public StockList()
        {
            InitializeComponent();
        }

        public StockList(GirStockArgs girStockArgs, GirStockPocket girStockPocket) : this()
        {
            _girStockArgs = girStockArgs;
            _girStockPocket = girStockPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = stockModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girStockArgs,
                GridView = gridView1,
                InitModelType = typeof(StockModel),
                ModelArgs = _girStockArgs.GirStockModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirStockModelArgs, StockModel>(_girStockPocket.SelectStockModels, null);
            colIsCheck.Visible = false;

            LookUpEditHelper.SetGridColumnCommonCode(colBASE_UNIT, Common.LoginInfo.UserInfo.CompCode, "UNIT");
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroup_WithCode", new { COMP_CD = _girStockArgs.GirStockModelArgs.Select_Main_Comp_Cd, PLANT_CD = _girStockArgs.GirStockModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명");
            //LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_2, "ItemGroup_WithCode", new { COMP_CD = _girStockArgs.GirStockModelArgs.Select_Main_Comp_Cd, PLANT_CD = _girStockArgs.GirStockModelArgs.Select_Main_Plant_Cd, ITEM_GR_CLS = "ITEM_GR_2" }, "제품군", "제품군명");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE_CD, "ItemType", new { COMP_CD = _girStockArgs.GirStockModelArgs.Select_Main_Comp_Cd }, "품목유형코드", "품목유형명");

            base.DataRefresh(args);
        }
    }
}

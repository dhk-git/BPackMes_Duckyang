using BPack.Model.App.MM.GirStock;
using BPack.Strap.EditControls;
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
    public partial class GirList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirStockArgs _girStockArgs;
        private GirStockPocket _girStockPocket;
        //private LookUpEditPocket _lep;
        public GirList()
        {
            InitializeComponent();
        }

        public GirList(GirStockArgs girStockArgs, GirStockPocket girStockPocket) : this()
        {
            _girStockArgs = girStockArgs;
            _girStockPocket = girStockPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = girModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girStockArgs,
                GridView = gridView1,
                InitModelType = typeof(GirModel),
                ModelArgs = _girStockArgs.GirStockModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirStockModelArgs, GirModel>(_girStockPocket.SelectGirModels, null);
            colIsCheck.Visible = false;
            LookUpEditHelper.SetGridColumnByQuery(colGIR_TYPE_CD, "GirType", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, "수불유형코드", "수불유형명");
            
        }
        public override void DataRefresh(ArgsBase args)
        {
            //LookUpEditHelper.SetGridColumnByQuery(colLOC_CD, "Locations_WithCode", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _girStockArgs.GirStockModelArgs.Select_Main_Plant_Cd, WH_CD = _girStockArgs.GirStockModelArgs.Select_Main_Wh_Cd }, "위치코드", "위치명");
            LookUpEditHelper.SetGridColumnByQuery(colFROM_WH_CD, "WareHouses_WithCode", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _girStockArgs.GirStockModelArgs.Select_Main_Plant_Cd }, "창고코드", "창고명");
            LookUpEditHelper.SetGridColumnByQuery(colTO_WH_CD, "WareHouses_WithCode", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _girStockArgs.GirStockModelArgs.Select_Main_Plant_Cd }, "창고코드", "창고명");
            //LookUpEditHelper.SetGridColumnByQuery(colTARGET_LOC_CD, "Locations_WithCode", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = _girStockArgs.GirStockModelArgs.Select_Main_Plant_Cd, WH_CD = "" }, "위치코드", "위치명");
            base.DataRefresh(args);
        }

    }
}

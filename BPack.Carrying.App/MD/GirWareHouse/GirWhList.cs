using BPack.Common.Model;
using BPack.Model.App.MD.GirWareHouse;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.GirWareHouse;
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

namespace BPack.Carrying.App.MD.GirWareHouse
{
    public partial class GirWhList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirWareHouseArgs _girWareHouseArgs;
        private GirWareHousePocket _girWareHousePocket;

        public GirWhList(GirWareHouseArgs girWareHouseArgs, GirWareHousePocket girWareHousePocket)
        {
            InitializeComponent();

            _girWareHouseArgs = girWareHouseArgs;
            _girWareHousePocket = girWareHousePocket;

        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = wareHouseModelBindingSource,
                FormArgs = _girWareHouseArgs,
                ModelArgs = _girWareHouseArgs.girWareHouseModelArgs,
                InitModelType = typeof(WareHouseModel),
                GridView = gridView1
            });
            InitPocketDelegate<GirWareHouseModelArgs, WareHouseModel>(_girWareHousePocket.SelectWareHouseModels, _girWareHousePocket.SaveWareHouseModel);

            LookUpEditHelper.SetGridColumnSysCode(colWH_TYPE, "WH_TYPE");
            LookUpEditHelper.SetGridColumnSysCode(colWH_GR, "WH_GR");
            LookUpEditHelper.SetGridColumnSysCode(colWH_STOCK_TYPE, "WH_STOCK_TYPE");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((WareHouseModel)model).COMP_CD = _girWareHouseArgs.girWareHouseModelArgs.Select_Main_Comp_Code;
            ((WareHouseModel)model).PLANT_CD = _girWareHouseArgs.girWareHouseModelArgs.Select_Main_Plant_Code;
            ((WareHouseModel)model).WH_TYPE = "Real";
        }

    }
}

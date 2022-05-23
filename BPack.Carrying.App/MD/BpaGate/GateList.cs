using BPack.Common.Model;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.BpaGate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Model.App.MD.BpaGate;
using BPack.Strap.EditControls;

namespace BPack.Carrying.App.MD.BpaGate
{
    public partial class GateList : StrapSubForm_OnlyOneGrid_V2
    {
        private BpaGateArgs _bpaGateArgs;
        private BpaGatePocket _bpaGatePocket;


        public GateList(BpaGateArgs bpaGateArgs, BpaGatePocket bpaGatePocket)
        {
            InitializeComponent();
            _bpaGateArgs = bpaGateArgs;
            _bpaGatePocket = bpaGatePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new Strap.FormControls.FieldArgs_StrapSubForm_OnlyOneGrid
            {
                GridView = grvGate,
                BindingSource = gateModelBindingSource,
                FormArgs = _bpaGateArgs,
                ModelArgs = _bpaGateArgs.bpaGateModelArgs,
                InitModelType = typeof(Model.App.MD.BpaGate.GateModel),
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<Model.App.MD.BpaGate.BpaGateModelArgs, Model.App.MD.BpaGate.GateModel>(_bpaGatePocket.SelectGateModels, _bpaGatePocket.SaveGateModel, _bpaGatePocket.SaveGateModels);
            //grvGate.OptionsView.ColumnAutoWidth = true;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((Model.App.MD.BpaGate.GateModel)model).COMP_CD = _bpaGateArgs.bpaGateModelArgs.Select_Comp_Cd;
            ((Model.App.MD.BpaGate.GateModel)model).BP_CD = _bpaGateArgs.bpaGateModelArgs.Select_Bp_Cd;
            ((Model.App.MD.BpaGate.GateModel)model).VALID_FROM_DT = DateTime.Now.Date;
            ((Model.App.MD.BpaGate.GateModel)model).VALID_TO_DT = new DateTime(9999, 12, 31);

            base.SetInsertDefaultValue(model);
        }

        private void grvGate_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var row = grvGate.GetRow(e.RowHandle) as GateModel;

            switch (e.Column.FieldName)
            {
                case "IS_PURCHASE":
                case "IS_SALES":
                    row.IsCheck = true;
                    grdGate.RefreshDataSource();
                    break;
            }
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            //LookUpEditHelper.SetGridColumnByQuery(colWH_CD, "WareHouses", new { COMP_CD = _bpaGateArgs.bpaGateModelArgs.Select_Comp_Cd, PLANT_CD = "" }, "창고코드", "창고명");
            //LookUpEditHelper.SetGridColumnByQuery(colLOC_CD, "Locations", new { COMP_CD = _bpaGateArgs.bpaGateModelArgs.Select_Comp_Cd, PLANT_CD = "", WH_CD = "" }, "위치코드", "위치명");
        }
    }
}

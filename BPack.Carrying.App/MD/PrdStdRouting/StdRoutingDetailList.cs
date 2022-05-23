using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdStdRouting;
using BPack.Pocket.App.MD.PrdStdRouting;
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

namespace BPack.Carrying.App.MD.PrdStdRouting
{
    public partial class StdRoutingDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdStdRoutingArgs _prdStdRoutingArgs;
        private PrdStdRoutingPocket _prdStdRoutingPocket;

        public StdRoutingDetailList()
        {
            InitializeComponent();
        }

        public StdRoutingDetailList(PrdStdRoutingArgs prdStdRoutingArgs, PrdStdRoutingPocket prdStdRoutingPocket) : this()
        {
            this._prdStdRoutingArgs = prdStdRoutingArgs;
            this._prdStdRoutingPocket = prdStdRoutingPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = stdRoutingDetailModelBindingSource,
                FormArgs = _prdStdRoutingArgs,
                GridView = gridView1,
                InitModelType = typeof(StdRoutingDetailModel),
                ModelArgs = _prdStdRoutingArgs.PrdStdRoutingModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdStdRoutingModelArgs, StdRoutingDetailModel>(_prdStdRoutingPocket.SelectStdRoutingDetailModels, null, _prdStdRoutingPocket.SaveStdRoutingDetailModels);
            LookUpEditHelper.SetWorkCenter(colWC_CD, _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd, _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd);
            _gridView.CustomRowCellEditForEditing += _gridView_CustomRowCellEditForEditing;
        }
        private void _gridView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            SimplePocket simplePocket;
            DataTable source;

            switch (e.Column.FieldName)
            {
                case "DVC_ID":

                    simplePocket = SimplePocket.GetInstance();
                    source = simplePocket.SelectData("DeviceList_WithCode", new
                    {
                        COMP_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd,
                        PLANT_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd,
                        WC_CD = grv.GetRowCellValue(e.RowHandle, colWC_CD)
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "단말기ID", displayCaption: "단말기명");
                    break;
            }
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            if (stdRoutingDetailModelBindingSource.Count > 1)
            {
                MessageBox.Show("공정은 10번공정 1개만 등록되도록 제한되어있습니다.");
                stdRoutingDetailModelBindingSource.RemoveCurrent();
                return;
            }
            ((StdRoutingDetailModel)model).COMP_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd;
            ((StdRoutingDetailModel)model).PLANT_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd;
            ((StdRoutingDetailModel)model).STR_NO = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Str_No;
            ((StdRoutingDetailModel)model).MODE_ID = "M01";
            ((StdRoutingDetailModel)model).OPER = 10;
            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colMAT_WH_CD, "WareHouses_WithCode", new { COMP_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd, PLANT_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd }, "창고코드", "창고명");
            LookUpEditHelper.SetGridColumnByQuery(colGD_WH_CD, "WareHouses_WithCode", new { COMP_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd, PLANT_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd }, "창고코드", "창고명");
            LookUpEditHelper.SetGridColumnByQuery(colMAT_LOC_CD, "Locations_WithCode", new { COMP_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd, PLANT_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd, WH_CD = "" }, "위치코드", "위치명");
            LookUpEditHelper.SetGridColumnByQuery(colGD_LOC_CD, "Locations_WithCode", new { COMP_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd, PLANT_CD = _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd, WH_CD = "" }, "위치코드", "위치명");
            base.DataRefresh(args);
        }


    }
}

using BPack.Common.Model;
using BPack.Model.App.MD.PrdWorkCenter;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdWorkCenter;
using System.Data;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.Repository;

namespace BPack.Carrying.App.MD.PrdWorkCenter
{
    public partial class EquipList : StrapSubForm_OnlyOneGrid_V2
    {
        private PrdWorkCenterPocket _prdWorkCenterPocket;
        private PrdWorkCenterArgs _prdWorkCenterArgs;

        public EquipList(PrdWorkCenterArgs prdWorkCenterArgs, PrdWorkCenterPocket prdWorkCenterPocket)
        {
            InitializeComponent();

            _prdWorkCenterArgs = prdWorkCenterArgs;
            _prdWorkCenterPocket = prdWorkCenterPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            this.IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = eqiupModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _prdWorkCenterArgs,
                GridView = gridView1,
                InitModelType = typeof(EquipModel),
                ModelArgs = _prdWorkCenterArgs.PrdWorkCenterModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdWorkCenterModelArgs, EquipModel>(_prdWorkCenterPocket.SelectEquipModels, _prdWorkCenterPocket.SaveEquipModel, _prdWorkCenterPocket.SaveEquipModels);
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((EquipModel)model).COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD;
            ((EquipModel)model).PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD;
            ((EquipModel)model).WC_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_WorkCenter_WC_CD;
        }

        public override void DataRefresh(ArgsBase args)
        {
            LookUpEditHelper.SetGridColumnByQuery(colEQUIP_CD, "EquipList", new { COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD, PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD, EQUIP_CD = "" }, "설비코드", "설비명");
            (colEQUIP_CD.ColumnEdit as RepositoryItemLookUpEdit).DisplayMember = "CODE";

            LookUpEditHelper.SetGridColumnCommonCode(colEQUIP_CLS, _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD, "EQUIP_CLS");

            base.DataRefresh(args);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var grd = grv.GridControl;
            SimplePocket simplePocket;

            var curModel = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(e.RowHandle) as EquipModel;

            switch (e.Column.FieldName)
            {
                case "EQUIP_CD":

                    simplePocket = SimplePocket.GetInstance();
                    var row = simplePocket.SelectData("EquipInfo", new
                    {
                        COMP_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Comp_CD,
                        PLANT_CD = _prdWorkCenterArgs.PrdWorkCenterModelArgs.Select_Main_Plant_CD,
                        EQUIP_CD = grv.GetRowCellValue(e.RowHandle, "EQUIP_CD")
                    }).Select().FirstOrDefault();

                    if (row != null)
                    {
                        curModel.EQUIP_NM = row["EQUIP_NM"]?.ToString();
                        curModel.EQUIP_CLS = row["EQUIP_CLS"]?.ToString();
                        curModel.EQUIP_BARCODE = row["EQUIP_BARCODE"]?.ToString();
                    }

                    break;
            }
        }
    }
}

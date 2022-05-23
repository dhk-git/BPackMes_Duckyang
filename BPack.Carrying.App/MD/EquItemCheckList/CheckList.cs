using BPack.Common.Model;
using BPack.Model.App.MD.EquItemCheckList;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.EquItemCheckList;
using System.Linq;
using BPack.Strap.EditControls;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using DevExpress.XtraEditors.Repository;
using System.Collections.Generic;

namespace BPack.Carrying.App.MD.EquItemCheckList
{
    public partial class CheckList : StrapSubForm_OnlyOneGrid_V2
    {
        EquItemCheckListArgs _equItemCheckListArgs;
        EquItemCheckListPocket _equItemCheckListPocket;

        public CheckList(EquItemCheckListArgs equItemCheckListArgs, EquItemCheckListPocket equItemCheckListPocket)
        {
            InitializeComponent();

            _equItemCheckListArgs = equItemCheckListArgs;
            _equItemCheckListPocket = equItemCheckListPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = equItemCheckListCheckListModelBindingSource,
                FormArgs = _equItemCheckListArgs,
                GridView = gridView1,
                InitModelType = typeof(EquItemCheckListCheckListModel),
                ModelArgs = _equItemCheckListArgs.EquItemCheckListModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<EquItemCheckListModelArgs, EquItemCheckListCheckListModel>(_equItemCheckListPocket.SelectCheckListModels, null, _equItemCheckListPocket.SaveCheckListModels);

            LookUpEditHelper.SetGridColumnSysCode(colINSP_VAL_TYPE, "INSP_VAL_TYPE");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((EquItemCheckListCheckListModel)model).COMP_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code;
            ((EquItemCheckListCheckListModel)model).PLANT_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Plant_Code;
            ((EquItemCheckListCheckListModel)model).EQUIP_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Equip_Code;
            ((EquItemCheckListCheckListModel)model).ITEM_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Item_Code;

            base.SetInsertDefaultValue(model);
        }

        public override void DataRefresh(ArgsBase args)
        {
            SimplePocket simplePocket = SimplePocket.GetInstance();
            var source = simplePocket.SelectData("EquipCheckList", new
            {
                COMP_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code,
                PLANT_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Plant_Code,
                EQUIP_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Equip_Code,
                EQUIP_CHK_CD = ""
            });
            
            var rps = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "조건코드", displayCaption: "조건명");
            colEQUIP_CHK_CD.ColumnEdit = rps;
            RepositoryItemHelpers.PopupFilter(rps);

            LookUpEditHelper.SetGridColumnCommonCode(colINSP_DV, _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code, "INSP_DV");
            LookUpEditHelper.SetGridColumnCommonCode(colINSP_METHOD, _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code, "INSP_METHOD");


            base.DataRefresh(args);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var grd = grv.GridControl;
            SimplePocket simplePocket;

            var curModel = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetRow(e.RowHandle) as EquItemCheckListCheckListModel;
            switch (e.Column.FieldName)
            {
                case "EQUIP_CHK_CD":

                    simplePocket = SimplePocket.GetInstance();
                    var row = simplePocket.SelectData("EquipCheckListInfo", new
                    {
                        COMP_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Comp_Code, 
                        PLANT_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Main_Plant_Code, 
                        EQUIP_CD = _equItemCheckListArgs.EquItemCheckListModelArgs.Select_Equip_Code, 
                        EQUIP_CHK_CD = grv.GetRowCellValue(e.RowHandle, "EQUIP_CHK_CD")
                    }).Select().FirstOrDefault();

                    if (row != null)
                    {
                        curModel.EQUIP_CHK_NM = row["EQUIP_CHK_NM"]?.ToString();
                    }

                    break;
            }

        }

    }
}

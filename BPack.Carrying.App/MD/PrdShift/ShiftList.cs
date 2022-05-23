using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdShift;
using BPack.Pocket.App.MD.PrdShift;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.PrdShift
{
    public partial class ShiftList : StrapSubForm_OnlyOneGrid_V2
    {

        PrdShiftArgs _prdShiftArgs;
        PrdShiftPocket _prdShiftPocket;

        public ShiftList(PrdShiftArgs prdShiftArgs, PrdShiftPocket prdShiftPocket)
        {
            InitializeComponent();

            _prdShiftArgs = prdShiftArgs;
            _prdShiftPocket = prdShiftPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

         


            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = shiftModelBindingSource,
                FormArgs = _prdShiftArgs,
                GridView = gridView1,
                InitModelType = typeof(ShiftModel),
                ModelArgs = _prdShiftArgs.PrdShiftModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<PrdShiftModelArgs, ShiftModel>(_prdShiftPocket.SelectShiftModels, _prdShiftPocket.SaveShiftModel, _prdShiftPocket.SaveShiftModels);

            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colWORK_START_TIME);
            RepositoryItemHelpers.SetRepositoryItemTimeSpanEdit(colWORK_END_TIME);



        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ShiftModel)model).COMP_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code;
            ((ShiftModel)model).PLANT_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code;
            ((ShiftModel)model).SHIFT_GROUP_CD = _prdShiftArgs.PrdShiftModelArgs.SHIFT_GROUP_CD;

            base.SetInsertDefaultValue(model);
        }
        public override void DataRefresh(ArgsBase args)
        {

            //Grid LookUPEdit 바인딩

            //근무조 상세 
            LookUpEditHelper.SetGridColumnByQuery(colSHIFT_CD, "MD.SHIDGroup.Select",
                new
                {
                    COMP_CD= _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code
                    ,
                    PLANT_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code
                    ,
                    SHIFT_GROUP_CD = _prdShiftArgs.PrdShiftModelArgs.SHIFT_GROUP_CD
                }
                , "Code", "Name"
                );


            LookUpEditHelper.SetGridColumnSysCode(colWORK_STATUS, "WORK_STATUS");

            //NotWork Group
            LookUpEditHelper.SetGridColumnByQuery(
                colNOTWORK_GROUP_CD,
                "MD.NOTH.Select",
                new
                {
                    COMP_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code,
                    PLANT_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code,
                    WORK_STATUS="",
                }
                , "CODE", "NAME");

            //NotWork Detail
            LookUpEditHelper.SetGridColumnByQuery(
                colNOTWORK_CD,
                "MD.NOTD.Select",
                new
                {
                    COMP_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code,
                    PLANT_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code,
                    NOTWORK_GROUP_CD = "",
                }
                , "CODE", "NAME");

            base.DataRefresh(args);
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            var grv = sender as GridView;
            switch (e.Column.FieldName)
            {
                case "NOTWORK_GROUP_CD":
                    var work_status = grv.GetRowCellValue(e.RowHandle, "WORK_STATUS");
                    var sp = SimplePocket.GetInstance();
                    var source = sp.SelectData("MD.NOTH.Select", new
                    {
                        COMP_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code,
                        PLANT_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code,
                        WORK_STATUS = work_status
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source, valueCaption: "CODE", displayCaption: "NAME");
                    break;
                case "NOTWORK_CD":
                    var NotworkGroup = grv.GetRowCellValue(e.RowHandle, "NOTWORK_GROUP_CD");
                    var sp2 = SimplePocket.GetInstance();
                    var source2 = sp2.SelectData("MD.NOTD.Select", new
                    {
                        COMP_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code,
                        PLANT_CD = _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code,
                        NOTWORK_GROUP_CD= NotworkGroup
                    });
                    e.RepositoryItem = RepositoryItemHelpers.CreateRepItemLookUpEdit(dataSource: source2, valueCaption: "CODE", displayCaption: "NAME");

                    break;  
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //LookUpEdit 시 값 변경 시 "" 처리
            var curRow = gridView1.GetRow(gridView1.FocusedRowHandle) as ShiftModel;
            switch (e.Column.FieldName)
            {
                case "WORK_STATUS":
                    curRow.NOTWORK_GROUP_CD = "";
                    curRow.NOTWORK_CD = "";
                    break;
                case "":
                    curRow.NOTWORK_CD = "";
                    break;
            }
        }
    }
}

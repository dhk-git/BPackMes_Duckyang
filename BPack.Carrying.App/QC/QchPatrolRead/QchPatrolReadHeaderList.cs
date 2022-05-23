using BPack.CommonMes.Config;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchPatrolRead;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.QchPatrolRead;
using DevExpress.XtraGrid.Views.Grid;

namespace BPack.Carrying.App.QC.QchPatrolRead
{
    public partial class QchPatrolReadHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private QchPatrolReadArgs _qchPatrolReadArgs;
        private QchPatrolReadPocket _qchPatrolReadPocket;

        public QchPatrolReadHeaderList(QchPatrolReadArgs qchPatrolReadArgs, QchPatrolReadPocket qchPatrolReadPocket)
        {
            InitializeComponent();

            _qchPatrolReadArgs = qchPatrolReadArgs;
            _qchPatrolReadPocket = qchPatrolReadPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = qchPatrolReadHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qchPatrolReadArgs,
                GridView = gridView1,
                InitModelType = typeof(QchPatrolReadHeaderModel),
                ModelArgs = _qchPatrolReadArgs.QchPatrolReadModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<QchPatrolReadModelArgs, QchPatrolReadHeaderModel>(_qchPatrolReadPocket.SelectQchPatrolReadHeaderModels, _qchPatrolReadPocket.SaveQchPatrolReadHeaderModel, _qchPatrolReadPocket.SaveQchPatrolReadHeaderModels);

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE, "ItemType", new { COMP_CD = _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD }, "품목유형코드", "품목유형명");
            LookUpEditHelper.SetWareHouse(colWH_CD, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Plant_CD);
            LookUpEditHelper.SetLocation(colLOC_CD, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Plant_CD, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Warehouse_CD);
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "INSP_JUDGE_QC":
                    var cellValue = e.CellValue?.ToString();
                    if (cellValue == "OK") e.Appearance.BackColor = GlobalSettings.OkColor;
                    else if (cellValue == "NG") e.Appearance.BackColor = GlobalSettings.NgColor;
                    break;
            }
        }

        internal void RowRefresh()
        {
            gridView1.UpdateCurrentRow();
        }

        internal QchPatrolReadHeaderModel GetFocusedRow()
        {
            return gridView1.GetFocusedRow() as QchPatrolReadHeaderModel;
        }
    }
}

using BPack.CommonMes.Config;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchFmlRead;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.QchFmlRead;
using DevExpress.XtraGrid.Views.Grid;

namespace BPack.Carrying.App.QC.QchFmlRead
{
    public partial class QchFmlReadHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private QchFmlReadArgs _qchFmlReadArgs;
        private QchFmlReadPocket _qchFmlReadPocket;

        public QchFmlReadHeaderList(QchFmlReadArgs qchFmlReadArgs, QchFmlReadPocket qchFmlReadPocket)
        {
            InitializeComponent();

            _qchFmlReadArgs = qchFmlReadArgs;
            _qchFmlReadPocket = qchFmlReadPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = qchFmlReadHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qchFmlReadArgs,
                GridView = gridView1,
                InitModelType = typeof(QchFmlReadHeaderModel),
                ModelArgs = _qchFmlReadArgs.QchFmlReadModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<QchFmlReadModelArgs, QchFmlReadHeaderModel>(_qchFmlReadPocket.SelectQchFmlReadHeaderModels, _qchFmlReadPocket.SaveQchFmlReadHeaderModel, _qchFmlReadPocket.SaveQchFmlReadHeaderModels);

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnSysCode(colINSP_TYPE, "INSP_TYPE");
            LookUpEditHelper.SetGridColumnSysCode(colINSP_SUB_TYPE, "INSP_SUB_TYPE");
            LookUpEditHelper.SetShiftCode(colSHIFT_CD, _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Comp_CD, _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Plant_CD);
            LookUpEditHelper.SetWorkCenter(colWC_CD, _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Comp_CD, _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Plant_CD);

        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "INSP_JUDGE_PC":
                case "INSP_JUDGE_QC":
                    var cellValue = e.CellValue?.ToString();
                    if (cellValue == "OK") e.Appearance.BackColor = GlobalSettings.OkColor;
                    else if (cellValue == "NG") e.Appearance.BackColor = GlobalSettings.NgColor;
                    break;
            }
        }
    }
}

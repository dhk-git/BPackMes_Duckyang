using BPack.CommonMes.Config;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchFmlRead;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.QchFmlRead;

namespace BPack.Carrying.App.QC.QchFmlRead
{
    public partial class QchFmlReadDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private QchFmlReadArgs _qchFmlReadArgs;
        private QchFmlReadPocket _qchFmlReadPocket;
        

        public QchFmlReadDetailList(QchFmlReadArgs qchFmlReadArgs, QchFmlReadPocket qchFmlReadPocket)
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
                BindingSource = qchFmlReadDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qchFmlReadArgs,
                GridView = gridView1,
                InitModelType = typeof(QchFmlReadDetailModel),
                ModelArgs = _qchFmlReadArgs.QchFmlReadModelArgs
            });
            InitPocketDelegate<QchFmlReadModelArgs, QchFmlReadDetailModel>(_qchFmlReadPocket.SelectQchFmlReadDetailModels, null);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnCommonCode(colINSP_DV, _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Comp_CD, "INSP_DV");
            LookUpEditHelper.SetGridColumnCommonCode(colINSP_METHOD, _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Comp_CD, "INSP_METHOD");
            LookUpEditHelper.SetGridColumnSysCode(colINSP_VAL_TYPE, "INSP_VAL_TYPE");
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

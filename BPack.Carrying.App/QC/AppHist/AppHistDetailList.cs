using BPack.Model.App.QC.AppHist;
using BPack.Pocket.App.QC.AppHist;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;
using System.Drawing;

namespace BPack.Carrying.App.QC.AppHist
{
    public partial class AppHistDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private AppHistArgs _AppHistArgs;
        private AppHistPocket _AppHistPocket;

        public AppHistDetailList()
        {
            InitializeComponent();
        }

        public AppHistDetailList(AppHistArgs AppHistArgs, AppHistPocket AppHistPocket) : this()
        {
            _AppHistArgs = AppHistArgs;
            _AppHistPocket = AppHistPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = AppHistDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _AppHistArgs,
                GridView = gridView1,
                InitModelType = typeof(AppHistDetailModel),
                ModelArgs = _AppHistArgs.AppHistModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<AppHistModelArgs, AppHistDetailModel>(_AppHistPocket.SelectAppHistDetailModels, null, null);

            //gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.AllowCellMerge = true;

            colINSP_SEQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colHU_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colLOT_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colHU_BARCODE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

            // '비고'를 제외한 모든 항목을 수정못하게 처리 
            gridView1.OptionsBehavior.Editable = true;
            foreach (GridColumn col in gridView1.Columns)
            {
                if (col.FieldName != "REMARK")      // 비고 
                    col.OptionsColumn.AllowEdit = false;
            }
            gridView1.Columns["REMARK"].OptionsColumn.AllowEdit = true;

            RepositoryItemMemoEdit item = new RepositoryItemMemoEdit();
            colREMARK.ColumnEdit = item;

            colIsCheck.Visible = false;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            gridView1.BestFitColumns();
        }

        public AppHistDetailModel GetSelectedModel()
        {
            return (AppHistDetailModel)AppHistDetailModelBindingSource.Current;
        }

        public List<AppHistDetailModel> GetSelectedModels()
        {
            return (List<AppHistDetailModel>)AppHistDetailModelBindingSource.DataSource;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle == gridView1.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Blue;
                e.Appearance.ForeColor = Color.White;
            }
            else
            {
                e.Appearance.BackColor = Color.White;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (e.Column.FieldName == "ITEM_GR_1" || e.Column.FieldName == "ALC_CD" || e.Column.FieldName == "ITEM_CD" || e.Column.FieldName == "ITEM_NM" || 
                e.Column.FieldName == "BASE_UNIT" || e.Column.FieldName == "INSP_JUDGE_QC" || e.Column.FieldName == "INSP_DTTM_QC" || e.Column.FieldName == "INSP_QTY" ||
                e.Column.FieldName == "REMARK")
            {
                if ((gridView1.GetRowCellDisplayText(e.RowHandle1, "INSP_NO") == gridView1.GetRowCellDisplayText(e.RowHandle2, "INSP_NO")) &&
                   (e.CellValue1?.ToString() == e.CellValue2?.ToString()))
                {
                    e.Merge = true;
                }
                else
                {
                    e.Merge = false;
                }
            }
            e.Handled = true;
        }

    }
}

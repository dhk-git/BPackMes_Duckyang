using BPack.Model.App.QC.AppHist;
using BPack.Pocket.App.QC.AppHist;
using BPack.Strap.FormControls;
using System.Collections.Generic;
using System.Drawing;

namespace BPack.Carrying.App.QC.AppHist
{
    public partial class AppHistDetailInspList : StrapSubForm_OnlyOneGrid_V2
    {
        private AppHistArgs _AppHistArgs;
        private AppHistPocket _AppHistPocket;

        public AppHistDetailInspList()
        {
            InitializeComponent();
        }

        public AppHistDetailInspList(AppHistArgs AppHistArgs, AppHistPocket AppHistPocket) : this()
        {
            _AppHistArgs = AppHistArgs;
            _AppHistPocket = AppHistPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = AppHistDetailInspModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _AppHistArgs,
                GridView = gridView1,
                InitModelType = typeof(AppHistDetailInspModel),
                ModelArgs = _AppHistArgs.AppHistModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<AppHistModelArgs, AppHistDetailInspModel>(_AppHistPocket.SelectAppHistDetailInspModels, null, null);
            gridView1.OptionsView.ColumnAutoWidth = true;
            gridView1.OptionsView.AllowCellMerge = true;
            gridView1.OptionsBehavior.Editable = false;

            colINSP_SEQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colINSP_VAL_QC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            colINSP_JUDGE_QC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }

        public List<AppHistDetailInspModel> GetSelectedModels()
        {
            return (List<AppHistDetailInspModel>)AppHistDetailInspModelBindingSource.DataSource;
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
            if (e.Column.FieldName == "INSP_DV_NM" || e.Column.FieldName == "INSP_NM" || e.Column.FieldName == "INSP_VAL_TYPE_NM" || 
                e.Column.FieldName == "BASE_VALUE" || e.Column.FieldName == "UPPER_LIMIT" || e.Column.FieldName == "LOWER_LIMIT")
            {
                if ((gridView1.GetRowCellDisplayText(e.RowHandle1, "INSP_ID") == gridView1.GetRowCellDisplayText(e.RowHandle2, "INSP_ID")) &&
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

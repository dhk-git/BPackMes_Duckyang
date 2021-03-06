using BPack.CommonMes.Config;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvConfirm;
using BPack.Pocket.App.SD.DlvConfirm;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraRichEdit.Unicode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BPack.Carrying.App.SD.DlvConfirm
{
    public partial class DlvConfirmDetailJISList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvConfirmArgs _DlvConfirmArgs;
        private DlvConfirmPocket _DlvConfirmPocket;

        public DlvConfirmDetailJISList()
        {
            InitializeComponent();
        }

        public DlvConfirmDetailJISList(DlvConfirmArgs DlvConfirmArgs, DlvConfirmPocket DlvConfirmPocket) : this()
        {
            _DlvConfirmArgs = DlvConfirmArgs;
            _DlvConfirmPocket = DlvConfirmPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = DlvConfirmDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _DlvConfirmArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvConfirmDetailJISModel),
                ModelArgs = _DlvConfirmArgs.DlvConfirmModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvConfirmModelArgs, DlvConfirmDetailJISModel>(_DlvConfirmPocket.SelectDlvConfirmDetailJISModels, null, null);
            //gridView1.OptionsView.ColumnAutoWidth = true;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            gridView1.BestFitColumns();
        }

        public List<DlvConfirmDetailJISModel> GetSelectedModels()
        {
            return (List<DlvConfirmDetailJISModel>)DlvConfirmDetailModelBindingSource.DataSource;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle == gridView1.FocusedRowHandle) //  && e.Column.OptionsColumn.AllowMerge == DevExpress.Utils.DefaultBoolean.False)
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
    }
}

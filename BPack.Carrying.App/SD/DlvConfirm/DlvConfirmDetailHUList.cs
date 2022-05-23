using BPack.Model.App.SD.DlvConfirm;
using BPack.Pocket.App.SD.DlvConfirm;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using System.Collections.Generic;
using System.Drawing;

namespace BPack.Carrying.App.SD.DlvConfirm
{
    public partial class DlvConfirmDetailHUList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvConfirmArgs _DlvConfirmArgs;
        private DlvConfirmPocket _DlvConfirmPocket;

        public DlvConfirmDetailHUList()
        {
            InitializeComponent();
        }

        public DlvConfirmDetailHUList(DlvConfirmArgs DlvConfirmArgs, DlvConfirmPocket DlvConfirmPocket) : this()
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
                InitModelType = typeof(DlvConfirmDetailHUModel),
                ModelArgs = _DlvConfirmArgs.DlvConfirmModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<DlvConfirmModelArgs, DlvConfirmDetailHUModel>(_DlvConfirmPocket.SelectDlvConfirmDetailHUModels, null, null);
            gridView1.OptionsView.ColumnAutoWidth = true;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
        }

        public List<DlvConfirmDetailHUModel> GetSelectedModels()
        {
            return (List<DlvConfirmDetailHUModel>)DlvConfirmDetailModelBindingSource.DataSource;
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
    }
}

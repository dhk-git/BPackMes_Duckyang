using BPack.CommonMes.Config;
using BPack.Model.App.QC.QchDlvRead;
using BPack.Pocket.App.QC.QchDlvRead;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.QchDlvRead
{
    public partial class QchDlvReadHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private QchDlvReadArgs _qchDlvReadArgs;
        private QchDlvReadPocket _qchDlvReadPocket;


        public QchDlvReadHeaderList(QchDlvReadArgs qchDlvReadArgs, QchDlvReadPocket qchDlvReadPocket)
        {
            InitializeComponent();

            _qchDlvReadArgs = qchDlvReadArgs;
            _qchDlvReadPocket = qchDlvReadPocket;

            gridView1.CustomDrawCell += GridView1_CustomDrawCell;

        }

        public override void InitStrap()
        {
            base.InitStrap();
            IsBestFitStrapGrid = true;
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = qchDlvReadHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qchDlvReadArgs,
                GridView = gridView1,
                InitModelType = typeof(QchDlvReadHeaderModel),
                ModelArgs = _qchDlvReadArgs.QchDlvReadModelArgs,
                StrapEditMode = StrapEditMode.Default

            });
            InitPocketDelegate<QchDlvReadModelArgs, QchDlvReadHeaderModel>(_qchDlvReadPocket.SelectQchDlvReadHeaderModels,null); 
            gridView1.OptionsView.ColumnAutoWidth = true;
        }
        private void GridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
        internal QchDlvReadHeaderModel GetFocusedRow()
        {
            return gridView1.GetFocusedRow() as QchDlvReadHeaderModel;
        }


    }
}

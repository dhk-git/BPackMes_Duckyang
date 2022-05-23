using BPack.CommonMes.Config;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchFinalRead;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.QchFinalRead;
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
using System.Diagnostics;

namespace BPack.Carrying.App.QC.QchFinalRead
{
    public partial class QchFinalReadHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private QchFinalReadArgs _qchFinalReadArgs;
        private QchFinalReadPocket _qchFinalReadPocket;

        public QchFinalReadHeaderList(QchFinalReadArgs qchFinalReadArgs, QchFinalReadPocket qchFinalReadPocket)
        {
            InitializeComponent();

            _qchFinalReadArgs = qchFinalReadArgs;
            _qchFinalReadPocket = qchFinalReadPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = qchFinalReadHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qchFinalReadArgs,
                GridView = gridView1,
                InitModelType = typeof(QchFinalReadHeaderModel),
                ModelArgs = _qchFinalReadArgs.QchFinalReadModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<QchFinalReadModelArgs, QchFinalReadHeaderModel>(_qchFinalReadPocket.SelectQchFinalReadHeaderModels, _qchFinalReadPocket.SaveQchFinalReadHeaderModel, _qchFinalReadPocket.SaveQchFinalReadHeaderModels);

        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetShiftCode(colSHIFT_CD, _qchFinalReadArgs.QchFinalReadModelArgs.Select_Main_Comp_CD, _qchFinalReadArgs.QchFinalReadModelArgs.Select_Main_Plant_CD);
            LookUpEditHelper.SetWorkCenter(colWC_CD, _qchFinalReadArgs.QchFinalReadModelArgs.Select_Main_Comp_CD, _qchFinalReadArgs.QchFinalReadModelArgs.Select_Main_Plant_CD);
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

        internal QchFinalReadHeaderModel GetFocusedRow()
        {
            return gridView1.GetFocusedRow() as QchFinalReadHeaderModel;
        }
    }
}

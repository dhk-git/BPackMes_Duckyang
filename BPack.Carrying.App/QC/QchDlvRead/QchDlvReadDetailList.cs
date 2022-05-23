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
using DevExpress.XtraGrid.Views.Grid;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.QC.QchDlvRead
{
    public partial class QchDlvReadDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private QchDlvReadArgs _qchDlvReadArgs;
        private QchDlvReadPocket _qchDlvReadPocket;
        public event EventHandler<List<QchDlvReadDetailModel>> modelValueChanged;

        public QchDlvReadDetailList()
        {
            InitializeComponent();
        }
        public QchDlvReadDetailList(QchDlvReadArgs qchDlvReadArgs, QchDlvReadPocket qchDlvReadPocket)
        {
            InitializeComponent();
            _qchDlvReadArgs = qchDlvReadArgs;
            _qchDlvReadPocket = qchDlvReadPocket;

            gridView1.CustomDrawCell += GridView1_CustomDrawCell;
            gridView1.CustomRowCellEditForEditing += GridView1_CustomRowCellEditForEditing;
            gridView1.CellValueChanged += GridView1_CellValueChanged;
        }

       

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = true;
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource =qchDlvReadDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qchDlvReadArgs,
                GridView = gridView1,
                InitModelType = typeof(QchDlvReadDetailModel),
                ModelArgs = _qchDlvReadArgs.QchDlvReadModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });;
            InitPocketDelegate<QchDlvReadModelArgs, QchDlvReadDetailModel>
                (_qchDlvReadPocket.SelectQchDlvReadDetailModels
                , _qchDlvReadPocket.SaveQchDlvReadDetialModel
                , _qchDlvReadPocket.SaveQchDlvReadDetialModels);
            
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnCommonCode(colINSP_DV, _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Comp_CD, "INSP_DV");
            LookUpEditHelper.SetGridColumnCommonCode(colINSP_METHOD, _qchDlvReadArgs.QchDlvReadModelArgs.Select_Main_Comp_CD, "INSP_METHOD");
            LookUpEditHelper.SetGridColumnSysCode(colINSP_VAL_TYPE, "INSP_VAL_TYPE");
            gridView1.BestFitColumns();
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
        private void GridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            var grv = sender as GridView;
            var source = (grv.GridControl.DataSource as BindingSource).DataSource as List<QchDlvReadDetailModel>;
            var row = grv.GetRow(e.RowHandle) as QchDlvReadDetailModel;

            switch (e.Column.FieldName)
            {
                case "INSP_VAL_QC":
                    if (row.INSP_VAL_TYPE == "N")
                        e.RepositoryItem = rpsTextNumeric;
                    else if (row.INSP_VAL_TYPE == "OX")
                        e.RepositoryItem = rpsTextOX;
                    else
                        e.RepositoryItem = rpsTextString;
                    break;
            }
        }
        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var grv = sender as GridView;
            var source = (grv.GridControl.DataSource as BindingSource).DataSource as List<QchDlvReadDetailModel>;
            var row = grv.GetRow(e.RowHandle) as QchDlvReadDetailModel;

            switch (e.Column.FieldName)
            {
                case "INSP_VAL_QC":
                    if (row.INSP_VAL_TYPE == "OX")
                    {
                        if (e.Value?.ToString() == "O")
                        {
                            row.INSP_JUDGE_QC = "OK";
                        }
                        else
                        {
                            row.INSP_JUDGE_QC = "NG";
                        }
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(row.INSP_VAL_QC))
                        {
                            row.INSP_JUDGE_QC = "";
                            return;
                        }

                        Decimal lowerLimit = 0, upperLimit = 0;
                        if (!String.IsNullOrEmpty(row.LOWER_LIMIT)) lowerLimit = Convert.ToDecimal(row.LOWER_LIMIT);
                        if (!String.IsNullOrEmpty(row.UPPER_LIMIT)) upperLimit = Convert.ToDecimal(row.UPPER_LIMIT);

                        var inspValPC = row.INSP_VAL_QC == "" ? 0 : Convert.ToDecimal(row.INSP_VAL_QC);

                        if (String.IsNullOrEmpty(row.LOWER_LIMIT) && String.IsNullOrEmpty(row.UPPER_LIMIT))
                        {
                            row.INSP_JUDGE_QC = "OK";
                        }
                        else if (String.IsNullOrEmpty(row.LOWER_LIMIT))
                        {
                            if (upperLimit >= inspValPC)
                            {
                                row.INSP_JUDGE_QC = "OK";
                            }
                            else
                            {
                                row.INSP_JUDGE_QC = "NG";
                            }
                        }
                        else if (String.IsNullOrEmpty(row.UPPER_LIMIT))
                        {
                            if (lowerLimit <= inspValPC)
                            {
                                row.INSP_JUDGE_QC = "OK";
                            }
                            else
                            {
                                row.INSP_JUDGE_QC = "NG";
                            }
                        }
                        else
                        {
                            if (lowerLimit <= inspValPC && upperLimit >= inspValPC)
                            {
                                row.INSP_JUDGE_QC = "OK";
                            }
                            else
                            {
                                row.INSP_JUDGE_QC = "NG";
                            }
                        }

                    }
                    break;
            }

            modelValueChanged?.Invoke(this, source);
        }
    }
}

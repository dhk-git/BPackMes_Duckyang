﻿using BPack.CommonMes.Config;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchFinalRead;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.QchFinalRead;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.QchFinalRead
{
    public partial class QchFinalReadDetailList : StrapSubForm_OnlyOneGrid_V2
    {
        private QchFinalReadArgs _qchFinalReadArgs;
        private QchFinalReadPocket _qchFinalReadPocket;
        public event EventHandler<List<QchFinalReadDetailModel>> modelValueChanged;

        public QchFinalReadDetailList(QchFinalReadArgs qchFinalReadArgs, QchFinalReadPocket qchFinalReadPocket)
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
                BindingSource = qchFinalReadDetailModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _qchFinalReadArgs,
                GridView = gridView1,
                InitModelType = typeof(QchFinalReadDetailModel),
                ModelArgs = _qchFinalReadArgs.QchFinalReadModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<QchFinalReadModelArgs, QchFinalReadDetailModel>(_qchFinalReadPocket.SelectQchFinalReadDetailModels, _qchFinalReadPocket.SaveQchFinalReadDetailModel, _qchFinalReadPocket.SaveQchFinalReadDetailModels);
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);

            LookUpEditHelper.SetGridColumnCommonCode(colINSP_DV, _qchFinalReadArgs.QchFinalReadModelArgs.Select_Main_Comp_CD, "INSP_DV");
            LookUpEditHelper.SetGridColumnCommonCode(colINSP_METHOD, _qchFinalReadArgs.QchFinalReadModelArgs.Select_Main_Comp_CD, "INSP_METHOD");
            LookUpEditHelper.SetGridColumnSysCode(colINSP_VAL_TYPE, "INSP_VAL_TYPE");

            //gridView1.BestFitColumns();
            //var x = gridView1.Columns.Select(r => new { Value = r.FieldName, Width = r.Width }).ToList();
            //foreach (var z in x)
            //{
            //    Debug.Print(z.Value + " " + z.Width);
            //}

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

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            var grv = sender as GridView;
            var source = (grv.GridControl.DataSource as BindingSource).DataSource as List<QchFinalReadDetailModel>;
            var row = grv.GetRow(e.RowHandle) as QchFinalReadDetailModel;

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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var grv = sender as GridView;
            var source = (grv.GridControl.DataSource as BindingSource).DataSource as List<QchFinalReadDetailModel>;
            var row = grv.GetRow(e.RowHandle) as QchFinalReadDetailModel;

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

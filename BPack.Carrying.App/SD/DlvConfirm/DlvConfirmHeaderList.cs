using BPack.Model.App.SD.DlvConfirm;
using BPack.Pocket.App.SD.DlvConfirm;
using BPack.Strap.FormControls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;
using System.Drawing;

namespace BPack.Carrying.App.SD.DlvConfirm
{
    public partial class DlvConfirmHeaderList : StrapSubForm_OnlyOneGrid_V2
    {
        private DlvConfirmArgs _DlvConfirmArgs;
        private DlvConfirmPocket _DlvConfirmPocket;

        public DlvConfirmHeaderList()
        {
            InitializeComponent();
        }

        public DlvConfirmHeaderList(DlvConfirmArgs DlvConfirmArgs, DlvConfirmPocket DlvConfirmPocket) : this()
        {
            _DlvConfirmArgs = DlvConfirmArgs;
            _DlvConfirmPocket = DlvConfirmPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = DlvConfirmHeaderModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _DlvConfirmArgs,
                GridView = gridView1,
                InitModelType = typeof(DlvConfirmHeaderModel),
                ModelArgs = _DlvConfirmArgs.DlvConfirmModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<DlvConfirmModelArgs, DlvConfirmHeaderModel>(_DlvConfirmPocket.SelectDlvConfirmHeaderModels, null);

            //gridView1.OptionsView.ColumnAutoWidth = true;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsCustomization.AllowSort = false;
            gridView1.OptionsCustomization.AllowFilter = false;
            gridView1.OptionsFind.AllowFindPanel = false;

            colIsCheck.Visible = false;
            gridView1.OptionsView.AllowCellMerge = true;


            foreach(GridColumn col in gridView1.Columns )
            {
                col.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            }

            colDLV_PLC_NM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colCP_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colCP_SEQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colDRT_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colCAR_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colDRIV_NM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            colPHONE_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;

            RepositoryItemTimeSpanEdit tse = new RepositoryItemTimeSpanEdit();
            tse.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            tse.DisplayFormat.FormatString = "{0:hh}:{0:mm}";
            colDLV_TM.ColumnEdit = tse;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            gridView1.BestFitColumns();
        }

        public DlvConfirmHeaderModel GetSelectedModel()
        {
            return (DlvConfirmHeaderModel)DlvConfirmHeaderModelBindingSource.Current;
        }

        public List<DlvConfirmHeaderModel> GetSelectedModels()
        {
            return (List<DlvConfirmHeaderModel>)DlvConfirmHeaderModelBindingSource.DataSource;
        }

        public void ControlGrid(int Opt = 1)
        {
            if(Opt == 1)    // 출하확정 전 : 상차번호 기준으로 display 
            {
                colCP_NO.Visible = true;
                colCP_SEQ.Visible = true;
                colLOAD_SEQ.Visible = true;
                colDRT_NO.Visible = false;

                colDLV_PLC_NM.VisibleIndex = 0;
                colCP_NO.VisibleIndex = 1;
                colCP_SEQ.VisibleIndex = 2;
                colLOAD_SEQ.VisibleIndex = 3;
            }
            else   // 출하확정 후 : 출하실적번호 기준으로 display 
            {
                colCP_NO.Visible = false;
                colCP_SEQ.Visible = false;
                colLOAD_SEQ.Visible = false;
                colDRT_NO.Visible = true;

                colDLV_PLC_NM.VisibleIndex = 0;
                colDRT_NO.VisibleIndex = 1;
            }
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (e.Column.FieldName == "DLV_PLC_NM")
            {
                if ((gridView1.GetRowCellDisplayText(e.RowHandle1, "DLV_PLC_CD") == gridView1.GetRowCellDisplayText(e.RowHandle2, "DLV_PLC_CD")) &&
                   (e.CellValue1?.ToString() == e.CellValue2?.ToString()))
                {
                    e.Merge = true;
                }
                else
                {
                    e.Merge = false;
                }
            }
            else if (e.Column.FieldName == "DRT_NO" || e.Column.FieldName == "CP_NO" || e.Column.FieldName == "CP_SEQ" || e.Column.FieldName == "CAR_NO" || e.Column.FieldName == "DRIV_NM" || e.Column.FieldName == "PHONE_NO")
            {
                if ((gridView1.GetRowCellDisplayText(e.RowHandle1, "CP_NO") == gridView1.GetRowCellDisplayText(e.RowHandle2, "CP_NO")) &&
                   (e.CellValue1?.ToString() == e.CellValue2?.ToString()))
                {
                    e.Merge = true;
                }
                else
                {
                    e.Merge = false;
                }

                if (colDRT_NO.Visible == true)
                {
                    if ((gridView1.GetRowCellDisplayText(e.RowHandle1, "DRT_NO") == gridView1.GetRowCellDisplayText(e.RowHandle2, "DRT_NO")) &&
                       (e.CellValue1?.ToString() == e.CellValue2?.ToString()))
                    {
                        e.Merge = true;
                    }
                    else
                    {
                        e.Merge = false;
                    }
                }
                else
                {
                    if ((gridView1.GetRowCellDisplayText(e.RowHandle1, "CP_NO") == gridView1.GetRowCellDisplayText(e.RowHandle2, "CP_NO")) &&
                       (e.CellValue1?.ToString() == e.CellValue2?.ToString()))
                    {
                        e.Merge = true;
                    }
                    else
                    {
                        e.Merge = false;
                    }
                }
            }
            e.Handled = true;
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

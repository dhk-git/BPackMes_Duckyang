using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.JisDetailSum;
using BPack.Pocket.App.SD.JisDetailSum;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid;
using System.Collections.Generic;
using System.Drawing;

namespace BPack.Carrying.App.SD.JisDetailSum
{
    public partial class JisDetailSumList : StrapSubForm_OnlyOneGrid_V2
    {
        private JisDetailSumArgs _JisDetailSumArgs;
        private JisDetailSumPocket _JisDetailSumPocket;

        public JisDetailSumList()
        {
            InitializeComponent();
        }

        public JisDetailSumList(JisDetailSumArgs JisDetailSumArgs, JisDetailSumPocket JisDetailSumPocket) : this()
        {
            _JisDetailSumArgs = JisDetailSumArgs;
            _JisDetailSumPocket = JisDetailSumPocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();

            IsBestFitStrapGrid = false;

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid()
            {
                BindingSource = JisDetailSumModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _JisDetailSumArgs,
                GridView = gridView1,
                InitModelType = typeof(JisDetailSumModel),
                ModelArgs = _JisDetailSumArgs.JisDetailSumModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<JisDetailSumModelArgs, JisDetailSumModel>(_JisDetailSumPocket.SelectJisDetailSumModels, null);

            gridView1.OptionsBehavior.Editable = false;

            // Cell 병합 설정 
            gridView1.OptionsView.AllowCellMerge = true;
            gridView1.Columns["ALC_CD"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            gridView1.Columns["CNT"].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

            // 수신서열 sum 보여주기 
            gridView1.OptionsView.ShowFooter = true;
            colCNT.Summary.Add(DevExpress.Data.SummaryItemType.Sum, "CNT", "{0:#,##0}");

            // BOLD체 
            colIsCheck.Visible = false;
            colDT.AppearanceCell.Font = new Font(colDT.AppearanceCell.GetFont(), FontStyle.Bold);
            colITEM_GR_1.AppearanceCell.Font = new Font(colITEM_GR_1.AppearanceCell.GetFont(), FontStyle.Bold);

            // 가운데 정렬
            colDT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colITEM_GR_1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colALC_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }

        public override void DataRefresh(ArgsBase args)
        {
            base.DataRefresh(args);
            gridView1.BestFitColumns();
        }

        public void SetGridRepository()
        {
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "MasterDataControls.Item.ItemGr1", new
            {
                COMP_CD = _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Comp_Cd,
                PLANT_CD = _JisDetailSumArgs.JisDetailSumModelArgs.Select_Main_Plant_Cd
            }, "차종코드", "차종");
        }

        public JisDetailSumModel GetSelectedModel()
        {
            return (JisDetailSumModel)JisDetailSumModelBindingSource.Current;
        }

        public List<JisDetailSumModel> GetSelectedModels()
        {
            return (List<JisDetailSumModel>)JisDetailSumModelBindingSource.DataSource;
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle < 0)
                return;

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
            if (e.Column.FieldName == "DT")
            {
                if (e.CellValue1?.ToString() == e.CellValue2?.ToString())
                {
                    e.Merge = true;
                }
                else
                {
                    e.Merge = false;
                }
            }
            else if (e.Column.FieldName == "ITEM_GR_1")
            {
                if ((gridView1.GetRowCellDisplayText(e.RowHandle1, "DT") == gridView1.GetRowCellDisplayText(e.RowHandle2, "DT")) &&
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

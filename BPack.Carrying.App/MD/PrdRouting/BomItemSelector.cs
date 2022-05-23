using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdRouting;
using BPack.Pocket.App.MD.PrdRouting;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Import.Rtf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.PrdRouting
{
    public partial class BomItemSelector : DevExpress.XtraEditors.XtraForm
    {
        private PrdRoutingArgs _prdRoutingArgs;
        private PrdRoutingPocket _prdRoutingPocket = new PrdRoutingPocket();
        private PrdRoutingSelectedEventArgs _prdRoutingSelectedEventArgs = new PrdRoutingSelectedEventArgs();
        public event EventHandler<PrdRoutingSelectedEventArgs> SelectedComplate;

        public BomItemSelector(PrdRoutingArgs prdRoutingArgs)
        {
            InitializeComponent();

            _prdRoutingArgs = prdRoutingArgs;

            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            strapGridControl1.StrapEditMode = StrapEditMode.Default;
            strapGridControl2.StrapEditMode = StrapEditMode.Batch;

            strapGridControl1.InitDefaultSet();
            strapGridControl2.InitDefaultSet();
            
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsView.ColumnAutoWidth = false;
            gridView2.OptionsBehavior.Editable = true;

            strapButton1.Click += strapButton1_Click;
            strapButton2.Click += strapButton2_Click;
            strapButton3.Click += strapButton3_Click;
            strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            this.KeyPreview = true;
            this.KeyDown += BomItemSelector_KeyDown;
            gridView1.KeyDown += GridView_KeyDown;
            gridView2.KeyDown += GridView_KeyDown;
            //gridView1.DoubleClick += GridView_DoubleClick;
            gridView1.Click += GridView_DoubleClick;
            //gridView2.DoubleClick += GridView_DoubleClick;

            StrapEdit_FromModelAnnotation sefma = new StrapEdit_FromModelAnnotation();
            sefma.SetGridColumn(typeof(BomHeaderModel), gridView1);
            sefma.SetGridColumn(typeof(BomDetailModel), gridView2);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
        }

        protected override void OnShown(EventArgs e)
        {
            strapLookUpEdit1.EditValue = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Comp_Code;
            strapLookUpEdit2.EditValue = _prdRoutingArgs.PrdRoutingModelArgs.Select_Main_Plant_Code;
            strapButtonEdit_ItemMaster1.EditValue = _prdRoutingArgs.PrdRoutingModelArgs.Select_RoutingList_Item_Code;

            _prdRoutingArgs.PrdRoutingModelArgs.Select_Bom_BomHeaderList_Bom_No = null;

            DataRefresh();
            DataRefreshDetail();

            base.OnShown(e);
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var grd = grv.GridControl as BPack.Strap.Grid.StrapGridControl;

            MouseEventArgs mouseEventArgs = e as MouseEventArgs;
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo gridHitInfo = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).CalcHitInfo(mouseEventArgs.Location);
            if (gridHitInfo.InRow)
            {
                grd.OnGridSelectedRowFormatChange(sender, e); //하위폼 데이터 변경 체크후 롤백으로 인해 이쪽으로 옮김 20191031
            }

            if (grd == strapGridControl1)
            {
                modelSelect(strapGridControl1.SelectedModel);
                DataRefreshDetail();
            }
        }

        private void GridView_KeyDown(object sender, KeyEventArgs e)
        {
            var grv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var grd = grv.GridControl as BPack.Strap.Grid.StrapGridControl;

            if (e.KeyCode == Keys.Enter)
            {
                grd.OnGridSelectedRowFormatChange(sender, e); //하위폼 데이터 변경 체크후 롤백으로 인해 이쪽으로 옮김 20191031
            }

            if (grd == strapGridControl1)
            {
                modelSelect(strapGridControl1.SelectedModel);
                DataRefreshDetail();
            }

        }

        private void modelSelect(object selectedModel)
        {
            _prdRoutingArgs.PrdRoutingModelArgs.Select_Bom_BomHeaderList_Bom_No = ((BomHeaderModel)selectedModel)?.BOM_NO;
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() });
            strapLookUpEdit2.EditValue = strapLookUpEdit2.Properties.GetDataSourceValue("CODE", 0);
        }

        private void strapButton1_Click(object sender, EventArgs e)
        {
            DataRefresh();
            DataRefreshDetail();
        }

        private void strapButton2_Click(object sender, EventArgs e)
        {
            SelectComplate();
        }

        private void strapButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DataRefresh()
        {
            _prdRoutingArgs.PrdRoutingModelArgs.Select_Bom_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _prdRoutingArgs.PrdRoutingModelArgs.Select_Bom_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            _prdRoutingArgs.PrdRoutingModelArgs.Select_Bom_Main_Item_Code = strapButtonEdit_ItemMaster1.EditValue?.ToString() ?? "";

            bomHeaderModelBindingSource.DataSource = _prdRoutingPocket.SelectBomHeaderModels(_prdRoutingArgs.PrdRoutingModelArgs);

            gridView1.BestFitColumns();
            gridView1.Focus();
        }

        public void DataRefreshDetail()
        {
            bomDetailModelBindingSource.DataSource = _prdRoutingPocket.SelectBomDetailModels(_prdRoutingArgs.PrdRoutingModelArgs);

            gridView2.BestFitColumns();
            gridView2.Focus();
        }

        private void SelectComplate()
        {
            var models = ((List<BomDetailModel>)bomDetailModelBindingSource.DataSource).Where(r => r.IsCheck).ToList();
            _prdRoutingSelectedEventArgs.SeletedBomDetailModels = models;
            SelectedComplate?.Invoke(this, _prdRoutingSelectedEventArgs);
            this.Close();
        }


        private void BomItemSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DataRefresh();
            }
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
            {
                //SelectComplate();
            }
        }
    }
}

namespace BPack.Carrying.App.MM.GirStock
{
    partial class StockList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.strapGridControl1 = new BPack.Strap.Grid.StrapGridControl();
            this.stockModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_TYPE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASE_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASE_STOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUM_GR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUM_GI_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUM_STOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUR_STOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.stockModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.StrapMdiForm = null;
            this.strapGridControl1.StrapSubForm = null;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // stockModelBindingSource
            // 
            this.stockModelBindingSource.DataSource = typeof(BPack.Model.App.MM.GirStock.StockModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWH_CD,
            this.colITEM_GR_1,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_SPEC,
            this.colITEM_TYPE_CD,
            this.colBASE_UNIT,
            this.colBASE_STOCK_QTY,
            this.colSUM_GR_QTY,
            this.colSUM_GI_QTY,
            this.colSUM_STOCK_QTY,
            this.colCUR_STOCK_QTY,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 0;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 1;
            // 
            // colWH_CD
            // 
            this.colWH_CD.FieldName = "WH_CD";
            this.colWH_CD.Name = "colWH_CD";
            this.colWH_CD.Visible = true;
            this.colWH_CD.VisibleIndex = 2;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 3;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 4;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 5;
            // 
            // colITEM_SPEC
            // 
            this.colITEM_SPEC.FieldName = "ITEM_SPEC";
            this.colITEM_SPEC.Name = "colITEM_SPEC";
            this.colITEM_SPEC.Visible = true;
            this.colITEM_SPEC.VisibleIndex = 6;
            // 
            // colITEM_TYPE_CD
            // 
            this.colITEM_TYPE_CD.FieldName = "ITEM_TYPE_CD";
            this.colITEM_TYPE_CD.Name = "colITEM_TYPE_CD";
            this.colITEM_TYPE_CD.Visible = true;
            this.colITEM_TYPE_CD.VisibleIndex = 7;
            // 
            // colBASE_UNIT
            // 
            this.colBASE_UNIT.FieldName = "BASE_UNIT";
            this.colBASE_UNIT.Name = "colBASE_UNIT";
            this.colBASE_UNIT.Visible = true;
            this.colBASE_UNIT.VisibleIndex = 8;
            // 
            // colBASE_STOCK_QTY
            // 
            this.colBASE_STOCK_QTY.FieldName = "BASE_STOCK_QTY";
            this.colBASE_STOCK_QTY.Name = "colBASE_STOCK_QTY";
            this.colBASE_STOCK_QTY.Visible = true;
            this.colBASE_STOCK_QTY.VisibleIndex = 9;
            // 
            // colSUM_GR_QTY
            // 
            this.colSUM_GR_QTY.FieldName = "SUM_GR_QTY";
            this.colSUM_GR_QTY.Name = "colSUM_GR_QTY";
            this.colSUM_GR_QTY.Visible = true;
            this.colSUM_GR_QTY.VisibleIndex = 10;
            // 
            // colSUM_GI_QTY
            // 
            this.colSUM_GI_QTY.FieldName = "SUM_GI_QTY";
            this.colSUM_GI_QTY.Name = "colSUM_GI_QTY";
            this.colSUM_GI_QTY.Visible = true;
            this.colSUM_GI_QTY.VisibleIndex = 11;
            // 
            // colSUM_STOCK_QTY
            // 
            this.colSUM_STOCK_QTY.FieldName = "SUM_STOCK_QTY";
            this.colSUM_STOCK_QTY.Name = "colSUM_STOCK_QTY";
            this.colSUM_STOCK_QTY.Visible = true;
            this.colSUM_STOCK_QTY.VisibleIndex = 12;
            // 
            // colCUR_STOCK_QTY
            // 
            this.colCUR_STOCK_QTY.FieldName = "CUR_STOCK_QTY";
            this.colCUR_STOCK_QTY.Name = "colCUR_STOCK_QTY";
            this.colCUR_STOCK_QTY.Visible = true;
            this.colCUR_STOCK_QTY.VisibleIndex = 13;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 14;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 15;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 16;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 17;
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "StockList";
            this.Text = "StockList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource stockModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBASE_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colBASE_STOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colSUM_GR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colSUM_GI_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colSUM_STOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colCUR_STOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
namespace BPack.Carrying.App.PC.WorOrderVsMat
{
    partial class WorOrderVsMatMaterialList
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
            this.worOrderVsMatHeaderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_LOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_STOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGUBUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWOR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_A_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_B_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_C_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_D_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_E_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_A_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_B_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_C_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN_D_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_E_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worOrderVsMatHeaderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.worOrderVsMatHeaderModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // worOrderVsMatHeaderModelBindingSource
            // 
            this.worOrderVsMatHeaderModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WorOrderVsMat.WorOrderVsMatMaterialModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWO_DT,
            this.colMAT_WH_CD,
            this.colMAT_LOC_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colLOC_STOCK_QTY,
            this.colGUBUN,
            this.colWOR_QTY,
            this.colOPER_QTY,
            this.colD_A_TIME_QTY,
            this.colD_B_TIME_QTY,
            this.colD_C_TIME_QTY,
            this.colD_D_TIME_QTY,
            this.colN_E_TIME_QTY,
            this.colN_A_TIME_QTY,
            this.colN_B_TIME_QTY,
            this.colN_C_TIME_QTY,
            this.colN_D_TIME_QTY,
            this.colD_E_TIME_QTY,
            this.colTOTAL_QTY,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView1_CellMerge);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // colWO_DT
            // 
            this.colWO_DT.FieldName = "WO_DT";
            this.colWO_DT.Name = "colWO_DT";
            this.colWO_DT.Visible = true;
            this.colWO_DT.VisibleIndex = 0;
            // 
            // colMAT_WH_CD
            // 
            this.colMAT_WH_CD.FieldName = "MAT_WH_CD";
            this.colMAT_WH_CD.Name = "colMAT_WH_CD";
            this.colMAT_WH_CD.Visible = true;
            this.colMAT_WH_CD.VisibleIndex = 1;
            // 
            // colMAT_LOC_CD
            // 
            this.colMAT_LOC_CD.FieldName = "MAT_LOC_CD";
            this.colMAT_LOC_CD.Name = "colMAT_LOC_CD";
            this.colMAT_LOC_CD.Visible = true;
            this.colMAT_LOC_CD.VisibleIndex = 2;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 3;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 4;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 5;
            // 
            // colLOC_STOCK_QTY
            // 
            this.colLOC_STOCK_QTY.FieldName = "LOC_STOCK_QTY";
            this.colLOC_STOCK_QTY.Name = "colLOC_STOCK_QTY";
            this.colLOC_STOCK_QTY.Visible = true;
            this.colLOC_STOCK_QTY.VisibleIndex = 6;
            // 
            // colGUBUN
            // 
            this.colGUBUN.FieldName = "GUBUN";
            this.colGUBUN.Name = "colGUBUN";
            this.colGUBUN.Visible = true;
            this.colGUBUN.VisibleIndex = 7;
            // 
            // colWOR_QTY
            // 
            this.colWOR_QTY.FieldName = "WOR_QTY";
            this.colWOR_QTY.Name = "colWOR_QTY";
            this.colWOR_QTY.Visible = true;
            this.colWOR_QTY.VisibleIndex = 8;
            // 
            // colOPER_QTY
            // 
            this.colOPER_QTY.FieldName = "OPER_QTY";
            this.colOPER_QTY.Name = "colOPER_QTY";
            this.colOPER_QTY.Visible = true;
            this.colOPER_QTY.VisibleIndex = 9;
            // 
            // colD_A_TIME_QTY
            // 
            this.colD_A_TIME_QTY.FieldName = "D_A_TIME_QTY";
            this.colD_A_TIME_QTY.Name = "colD_A_TIME_QTY";
            this.colD_A_TIME_QTY.Visible = true;
            this.colD_A_TIME_QTY.VisibleIndex = 10;
            // 
            // colD_B_TIME_QTY
            // 
            this.colD_B_TIME_QTY.FieldName = "D_B_TIME_QTY";
            this.colD_B_TIME_QTY.Name = "colD_B_TIME_QTY";
            this.colD_B_TIME_QTY.Visible = true;
            this.colD_B_TIME_QTY.VisibleIndex = 11;
            // 
            // colD_C_TIME_QTY
            // 
            this.colD_C_TIME_QTY.FieldName = "D_C_TIME_QTY";
            this.colD_C_TIME_QTY.Name = "colD_C_TIME_QTY";
            this.colD_C_TIME_QTY.Visible = true;
            this.colD_C_TIME_QTY.VisibleIndex = 12;
            // 
            // colD_D_TIME_QTY
            // 
            this.colD_D_TIME_QTY.FieldName = "D_D_TIME_QTY";
            this.colD_D_TIME_QTY.Name = "colD_D_TIME_QTY";
            this.colD_D_TIME_QTY.Visible = true;
            this.colD_D_TIME_QTY.VisibleIndex = 13;
            // 
            // colN_E_TIME_QTY
            // 
            this.colN_E_TIME_QTY.FieldName = "N_E_TIME_QTY";
            this.colN_E_TIME_QTY.Name = "colN_E_TIME_QTY";
            this.colN_E_TIME_QTY.Visible = true;
            this.colN_E_TIME_QTY.VisibleIndex = 14;
            // 
            // colN_A_TIME_QTY
            // 
            this.colN_A_TIME_QTY.FieldName = "N_A_TIME_QTY";
            this.colN_A_TIME_QTY.Name = "colN_A_TIME_QTY";
            this.colN_A_TIME_QTY.Visible = true;
            this.colN_A_TIME_QTY.VisibleIndex = 15;
            // 
            // colN_B_TIME_QTY
            // 
            this.colN_B_TIME_QTY.FieldName = "N_B_TIME_QTY";
            this.colN_B_TIME_QTY.Name = "colN_B_TIME_QTY";
            this.colN_B_TIME_QTY.Visible = true;
            this.colN_B_TIME_QTY.VisibleIndex = 16;
            // 
            // colN_C_TIME_QTY
            // 
            this.colN_C_TIME_QTY.FieldName = "N_C_TIME_QTY";
            this.colN_C_TIME_QTY.Name = "colN_C_TIME_QTY";
            this.colN_C_TIME_QTY.Visible = true;
            this.colN_C_TIME_QTY.VisibleIndex = 17;
            // 
            // colN_D_TIME_QTY
            // 
            this.colN_D_TIME_QTY.FieldName = "N_D_TIME_QTY";
            this.colN_D_TIME_QTY.Name = "colN_D_TIME_QTY";
            this.colN_D_TIME_QTY.Visible = true;
            this.colN_D_TIME_QTY.VisibleIndex = 18;
            // 
            // colD_E_TIME_QTY
            // 
            this.colD_E_TIME_QTY.FieldName = "D_E_TIME_QTY";
            this.colD_E_TIME_QTY.Name = "colD_E_TIME_QTY";
            this.colD_E_TIME_QTY.Visible = true;
            this.colD_E_TIME_QTY.VisibleIndex = 19;
            // 
            // colTOTAL_QTY
            // 
            this.colTOTAL_QTY.FieldName = "TOTAL_QTY";
            this.colTOTAL_QTY.Name = "colTOTAL_QTY";
            this.colTOTAL_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTOTAL_QTY.Visible = true;
            this.colTOTAL_QTY.VisibleIndex = 20;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 21;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 22;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 23;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 24;
            // 
            // WorOrderVsMatMaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WorOrderVsMatMaterialList";
            this.Text = "WorkOrderHeaderList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worOrderVsMatHeaderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource worOrderVsMatHeaderModelBindingSource;
        public Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_LOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_STOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colGUBUN;
        private DevExpress.XtraGrid.Columns.GridColumn colWOR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colD_A_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colD_B_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colD_C_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colD_D_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colN_E_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colN_A_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colN_B_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colN_C_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colN_D_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colD_E_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
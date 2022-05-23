namespace BPack.Carrying.App.PC.WorOrderHuLabel
{
    partial class WorOrderHuLabelPalletHeaderList
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.worOrderHuLabelPalletHeaderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colWO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWOR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIN_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRINTED_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worOrderHuLabelPalletHeaderModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.worOrderHuLabelPalletHeaderModelBindingSource;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWO_DT,
            this.colSHIFT_CD,
            this.colWC_CD,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colALC_CD,
            this.colWO_NO,
            this.colWOR_QTY,
            this.colHU_SIZE,
            this.colIN_QTY,
            this.colPRINTED_QTY,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // worOrderHuLabelPalletHeaderModelBindingSource
            // 
            this.worOrderHuLabelPalletHeaderModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WorOrderHuLabel.WorOrderHuLabelPalletHeaderModel);
            // 
            // colWO_DT
            // 
            this.colWO_DT.FieldName = "WO_DT";
            this.colWO_DT.Name = "colWO_DT";
            this.colWO_DT.Visible = true;
            this.colWO_DT.VisibleIndex = 0;
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            this.colSHIFT_CD.Visible = true;
            this.colSHIFT_CD.VisibleIndex = 1;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 2;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 3;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 4;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 5;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 6;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 7;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 8;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 9;
            // 
            // colWOR_QTY
            // 
            this.colWOR_QTY.FieldName = "WOR_QTY";
            this.colWOR_QTY.Name = "colWOR_QTY";
            this.colWOR_QTY.Visible = true;
            this.colWOR_QTY.VisibleIndex = 10;
            // 
            // colHU_SIZE
            // 
            this.colHU_SIZE.FieldName = "HU_SIZE";
            this.colHU_SIZE.Name = "colHU_SIZE";
            this.colHU_SIZE.Visible = true;
            this.colHU_SIZE.VisibleIndex = 11;
            // 
            // colIN_QTY
            // 
            this.colIN_QTY.FieldName = "IN_QTY";
            this.colIN_QTY.Name = "colIN_QTY";
            this.colIN_QTY.Visible = true;
            this.colIN_QTY.VisibleIndex = 12;
            // 
            // colPRINTED_QTY
            // 
            this.colPRINTED_QTY.FieldName = "PRINTED_QTY";
            this.colPRINTED_QTY.Name = "colPRINTED_QTY";
            this.colPRINTED_QTY.Visible = true;
            this.colPRINTED_QTY.VisibleIndex = 13;
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
            // WorOrderHuLabelPalletHeaderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WorOrderHuLabelPalletHeaderList";
            this.Text = "WorkOrderHeaderList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worOrderHuLabelPalletHeaderModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public Strap.Grid.StrapGridControl strapGridControl1;
        private System.Windows.Forms.BindingSource worOrderHuLabelPalletHeaderModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWOR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_SIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colIN_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colPRINTED_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
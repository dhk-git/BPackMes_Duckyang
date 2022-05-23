
namespace BPack.Carrying.App.MM.GirTotalStock
{
    partial class GirTotalLocStockPivot
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
            this.strapPivotControl1 = new BPack.Strap.Pivot.StrapPivotControl();
            this.fieldITEMCD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMGR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldALCCD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWHCDNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLOCCDNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLOCSTOCKQTY = new DevExpress.XtraPivotGrid.PivotGridField();
            this.locStockModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locStockModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapPivotControl1
            // 
            this.strapPivotControl1.DataSource = this.locStockModelBindingSource;
            this.strapPivotControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapPivotControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldITEMCD,
            this.fieldITEMNM,
            this.fieldITEMGR1,
            this.fieldALCCD,
            this.fieldWHCDNM,
            this.fieldLOCCDNM,
            this.fieldLOCSTOCKQTY});
            this.strapPivotControl1.Location = new System.Drawing.Point(0, 0);
            this.strapPivotControl1.Name = "strapPivotControl1";
            this.strapPivotControl1.OptionsView.ShowColumnHeaders = false;
            this.strapPivotControl1.OptionsView.ShowDataHeaders = false;
            this.strapPivotControl1.OptionsView.ShowFilterHeaders = false;
            this.strapPivotControl1.Size = new System.Drawing.Size(994, 510);
            this.strapPivotControl1.TabIndex = 0;
            // 
            // fieldITEMCD
            // 
            this.fieldITEMCD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMCD.AreaIndex = 0;
            this.fieldITEMCD.FieldName = "ITEM_CD";
            this.fieldITEMCD.Name = "fieldITEMCD";
            this.fieldITEMCD.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldITEMNM
            // 
            this.fieldITEMNM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMNM.AreaIndex = 1;
            this.fieldITEMNM.FieldName = "ITEM_NM";
            this.fieldITEMNM.Name = "fieldITEMNM";
            this.fieldITEMNM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldITEMGR1
            // 
            this.fieldITEMGR1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMGR1.AreaIndex = 2;
            this.fieldITEMGR1.FieldName = "ITEM_GR_1";
            this.fieldITEMGR1.Name = "fieldITEMGR1";
            this.fieldITEMGR1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldALCCD
            // 
            this.fieldALCCD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldALCCD.AreaIndex = 3;
            this.fieldALCCD.FieldName = "ALC_CD";
            this.fieldALCCD.Name = "fieldALCCD";
            this.fieldALCCD.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldWHCDNM
            // 
            this.fieldWHCDNM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldWHCDNM.AreaIndex = 0;
            this.fieldWHCDNM.FieldName = "WH_CDNM";
            this.fieldWHCDNM.Name = "fieldWHCDNM";
            // 
            // fieldLOCCDNM
            // 
            this.fieldLOCCDNM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldLOCCDNM.AreaIndex = 1;
            this.fieldLOCCDNM.FieldName = "LOC_CDNM";
            this.fieldLOCCDNM.Name = "fieldLOCCDNM";
            // 
            // fieldLOCSTOCKQTY
            // 
            this.fieldLOCSTOCKQTY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldLOCSTOCKQTY.AreaIndex = 0;
            this.fieldLOCSTOCKQTY.CellFormat.FormatString = "n0";
            this.fieldLOCSTOCKQTY.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldLOCSTOCKQTY.FieldName = "LOC_STOCK_QTY";
            this.fieldLOCSTOCKQTY.Name = "fieldLOCSTOCKQTY";
            // 
            // locStockModelBindingSource
            // 
            this.locStockModelBindingSource.DataSource = typeof(BPack.Model.App.MM.GirTotalStock.LocStockModel);
            // 
            // GirTotalLocStockPivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 510);
            this.Controls.Add(this.strapPivotControl1);
            this.Name = "GirTotalLocStockPivot";
            this.Text = "GirTotalLocStockPivot";
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locStockModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Pivot.StrapPivotControl strapPivotControl1;
        private System.Windows.Forms.BindingSource locStockModelBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMCD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMNM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMGR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldALCCD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWHCDNM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLOCCDNM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLOCSTOCKQTY;
    }
}
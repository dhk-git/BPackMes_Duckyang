namespace BPack.Carrying.App.PC.WoeResultPivot
{
    partial class ResultPivotList
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
            this.fieldWORKDT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSHIFTNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWCNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWORKTM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMCD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMGR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldALCCD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHUINITQTY = new DevExpress.XtraPivotGrid.PivotGridField();
            this.resultPivotModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldITEMTYPENM = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPivotModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapPivotControl1
            // 
            this.strapPivotControl1.DataSource = this.resultPivotModelBindingSource;
            this.strapPivotControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapPivotControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldWORKDT,
            this.fieldSHIFTNM,
            this.fieldWCNM,
            this.fieldWORKTM,
            this.fieldITEMTYPENM,
            this.fieldITEMCD,
            this.fieldITEMNM,
            this.fieldITEMGR1,
            this.fieldALCCD,
            this.fieldHUINITQTY});
            this.strapPivotControl1.Location = new System.Drawing.Point(0, 0);
            this.strapPivotControl1.Name = "strapPivotControl1";
            this.strapPivotControl1.OptionsView.ShowColumnHeaders = false;
            this.strapPivotControl1.OptionsView.ShowDataHeaders = false;
            this.strapPivotControl1.OptionsView.ShowFilterHeaders = false;
            this.strapPivotControl1.Size = new System.Drawing.Size(818, 469);
            this.strapPivotControl1.TabIndex = 0;
            // 
            // fieldWORKDT
            // 
            this.fieldWORKDT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldWORKDT.AreaIndex = 0;
            this.fieldWORKDT.FieldName = "WORK_DT";
            this.fieldWORKDT.Name = "fieldWORKDT";
            // 
            // fieldSHIFTNM
            // 
            this.fieldSHIFTNM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSHIFTNM.AreaIndex = 0;
            this.fieldSHIFTNM.FieldName = "SHIFT_NM";
            this.fieldSHIFTNM.Name = "fieldSHIFTNM";
            this.fieldSHIFTNM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.fieldSHIFTNM.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // fieldWCNM
            // 
            this.fieldWCNM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldWCNM.AreaIndex = 1;
            this.fieldWCNM.FieldName = "WC_NM";
            this.fieldWCNM.Name = "fieldWCNM";
            this.fieldWCNM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldWORKTM
            // 
            this.fieldWORKTM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldWORKTM.AreaIndex = 1;
            this.fieldWORKTM.FieldName = "WORK_TM";
            this.fieldWORKTM.Name = "fieldWORKTM";
            this.fieldWORKTM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.fieldWORKTM.Width = 66;
            // 
            // fieldITEMCD
            // 
            this.fieldITEMCD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMCD.AreaIndex = 2;
            this.fieldITEMCD.FieldName = "ITEM_CD";
            this.fieldITEMCD.Name = "fieldITEMCD";
            this.fieldITEMCD.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldITEMNM
            // 
            this.fieldITEMNM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMNM.AreaIndex = 3;
            this.fieldITEMNM.FieldName = "ITEM_NM";
            this.fieldITEMNM.Name = "fieldITEMNM";
            this.fieldITEMNM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldITEMGR1
            // 
            this.fieldITEMGR1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMGR1.AreaIndex = 5;
            this.fieldITEMGR1.FieldName = "ITEM_GR_1";
            this.fieldITEMGR1.Name = "fieldITEMGR1";
            this.fieldITEMGR1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldALCCD
            // 
            this.fieldALCCD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldALCCD.AreaIndex = 6;
            this.fieldALCCD.FieldName = "ALC_CD";
            this.fieldALCCD.Name = "fieldALCCD";
            this.fieldALCCD.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldHUINITQTY
            // 
            this.fieldHUINITQTY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldHUINITQTY.AreaIndex = 0;
            this.fieldHUINITQTY.CellFormat.FormatString = "n0";
            this.fieldHUINITQTY.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldHUINITQTY.FieldName = "HU_INIT_QTY";
            this.fieldHUINITQTY.Name = "fieldHUINITQTY";
            // 
            // resultPivotModelBindingSource
            // 
            this.resultPivotModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WoeResultPivot.ResultPivotModel);
            // 
            // fieldITEMTYPENM
            // 
            this.fieldITEMTYPENM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMTYPENM.AreaIndex = 4;
            this.fieldITEMTYPENM.FieldName = "ITEM_TYPE_NM";
            this.fieldITEMTYPENM.Name = "fieldITEMTYPENM";
            this.fieldITEMTYPENM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // ResultPivotList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 469);
            this.Controls.Add(this.strapPivotControl1);
            this.Name = "ResultPivotList";
            this.Text = "ResultPivotList";
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPivotModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Pivot.StrapPivotControl strapPivotControl1;
        private System.Windows.Forms.BindingSource resultPivotModelBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWORKDT;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSHIFTNM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWCNM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWORKTM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMCD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMNM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMGR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldALCCD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHUINITQTY;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMTYPENM;
    }
}
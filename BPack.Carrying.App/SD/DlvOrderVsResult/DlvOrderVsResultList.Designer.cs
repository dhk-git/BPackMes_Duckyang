
namespace BPack.Carrying.App.SD.DlvOrderVsResult
{
    partial class DlvOrderVsResultList
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
            this.fieldDT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMCD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMNM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMGR11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCLSNAME = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQTY = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dlvOrderVsResultModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldBPNM = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrderVsResultModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapPivotControl1
            // 
            this.strapPivotControl1.DataSource = this.dlvOrderVsResultModelBindingSource;
            this.strapPivotControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapPivotControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldDT1,
            this.fieldITEMCD1,
            this.fieldITEMNM1,
            this.fieldITEMGR11,
            this.fieldCLSNAME,
            this.fieldQTY,
            this.fieldBPNM});
            this.strapPivotControl1.Location = new System.Drawing.Point(0, 0);
            this.strapPivotControl1.Name = "strapPivotControl1";
            this.strapPivotControl1.Size = new System.Drawing.Size(800, 450);
            this.strapPivotControl1.TabIndex = 0;
            // 
            // fieldDT1
            // 
            this.fieldDT1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldDT1.AreaIndex = 0;
            this.fieldDT1.Caption = "DT";
            this.fieldDT1.FieldName = "DT";
            this.fieldDT1.Name = "fieldDT1";
            // 
            // fieldITEMCD1
            // 
            this.fieldITEMCD1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMCD1.AreaIndex = 2;
            this.fieldITEMCD1.Caption = "품번";
            this.fieldITEMCD1.FieldName = "ITEM_CD";
            this.fieldITEMCD1.Name = "fieldITEMCD1";
            // 
            // fieldITEMNM1
            // 
            this.fieldITEMNM1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMNM1.AreaIndex = 3;
            this.fieldITEMNM1.Caption = "품명";
            this.fieldITEMNM1.FieldName = "ITEM_NM";
            this.fieldITEMNM1.Name = "fieldITEMNM1";
            // 
            // fieldITEMGR11
            // 
            this.fieldITEMGR11.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMGR11.AreaIndex = 1;
            this.fieldITEMGR11.Caption = "제품군";
            this.fieldITEMGR11.FieldName = "ITEM_GR_1";
            this.fieldITEMGR11.Name = "fieldITEMGR11";
            // 
            // fieldCLSNAME
            // 
            this.fieldCLSNAME.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCLSNAME.AreaIndex = 4;
            this.fieldCLSNAME.Caption = "구분";
            this.fieldCLSNAME.FieldName = "CLS_NAME";
            this.fieldCLSNAME.Name = "fieldCLSNAME";
            // 
            // fieldQTY
            // 
            this.fieldQTY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQTY.AreaIndex = 0;
            this.fieldQTY.CellFormat.FormatString = "#,##0";
            this.fieldQTY.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldQTY.FieldName = "QTY";
            this.fieldQTY.Name = "fieldQTY";
            // 
            // dlvOrderVsResultModelBindingSource
            // 
            this.dlvOrderVsResultModelBindingSource.DataSource = typeof(BPack.Model.App.SD.DlvOrderVsResult.DlvOrderVsResultModel);
            // 
            // fieldBPNM
            // 
            this.fieldBPNM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldBPNM.AreaIndex = 0;
            this.fieldBPNM.Caption = "고객사";
            this.fieldBPNM.FieldName = "BP_NM";
            this.fieldBPNM.Name = "fieldBPNM";
            // 
            // DlvOrderVsResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapPivotControl1);
            this.Name = "DlvOrderVsResultList";
            this.Text = "DlvOrderVsResultList";
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrderVsResultModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Pivot.StrapPivotControl strapPivotControl1;
        private System.Windows.Forms.BindingSource dlvOrderVsResultModelBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMCD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMNM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMGR11;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCLSNAME;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQTY;
        private DevExpress.XtraPivotGrid.PivotGridField fieldBPNM;
    }
}
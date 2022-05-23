
namespace BPack.Carrying.App.PC.WoeRsPivotDayPlan
{
    partial class WoeRsPivotDayPlanList
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
            this.rsPivotDayPlanModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldCOMPCD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPLANTCD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWORKDT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMTYPENM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMGRNM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMCD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMNM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCLSNAME1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTARGETRATIO = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQTY1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsPivotDayPlanModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapPivotControl1
            // 
            this.strapPivotControl1.Appearance.FieldValue.Options.UseTextOptions = true;
            this.strapPivotControl1.Appearance.FieldValue.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.strapPivotControl1.Appearance.FieldValue.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.strapPivotControl1.DataSource = this.rsPivotDayPlanModelBindingSource;
            this.strapPivotControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapPivotControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCOMPCD1,
            this.fieldPLANTCD1,
            this.fieldWORKDT1,
            this.fieldITEMTYPENM1,
            this.fieldITEMGRNM1,
            this.fieldITEMCD1,
            this.fieldITEMNM1,
            this.fieldCLSNAME1,
            this.fieldTARGETRATIO,
            this.fieldQTY1});
            this.strapPivotControl1.Location = new System.Drawing.Point(0, 0);
            this.strapPivotControl1.Name = "strapPivotControl1";
            this.strapPivotControl1.OptionsView.HeaderHeightOffset = 1;
            this.strapPivotControl1.OptionsView.ShowRowGrandTotalHeader = false;
            this.strapPivotControl1.OptionsView.ShowRowGrandTotals = false;
            this.strapPivotControl1.Size = new System.Drawing.Size(800, 450);
            this.strapPivotControl1.TabIndex = 0;
            // 
            // rsPivotDayPlanModelBindingSource
            // 
            this.rsPivotDayPlanModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WoeRsPivotDayPlan.RsPivotDayPlanModel);
            // 
            // fieldCOMPCD1
            // 
            this.fieldCOMPCD1.AreaIndex = 0;
            this.fieldCOMPCD1.Caption = "COMP_CD";
            this.fieldCOMPCD1.FieldName = "COMP_CD";
            this.fieldCOMPCD1.Name = "fieldCOMPCD1";
            // 
            // fieldPLANTCD1
            // 
            this.fieldPLANTCD1.AreaIndex = 1;
            this.fieldPLANTCD1.Caption = "PLANT_CD";
            this.fieldPLANTCD1.FieldName = "PLANT_CD";
            this.fieldPLANTCD1.Name = "fieldPLANTCD1";
            // 
            // fieldWORKDT1
            // 
            this.fieldWORKDT1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldWORKDT1.AreaIndex = 0;
            this.fieldWORKDT1.Caption = "일자";
            this.fieldWORKDT1.FieldName = "WORK_DT";
            this.fieldWORKDT1.Name = "fieldWORKDT1";
            // 
            // fieldITEMTYPENM1
            // 
            this.fieldITEMTYPENM1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMTYPENM1.AreaIndex = 0;
            this.fieldITEMTYPENM1.Caption = "제품유형";
            this.fieldITEMTYPENM1.FieldName = "ITEM_TYPE_NM";
            this.fieldITEMTYPENM1.Name = "fieldITEMTYPENM1";
            // 
            // fieldITEMGRNM1
            // 
            this.fieldITEMGRNM1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMGRNM1.AreaIndex = 1;
            this.fieldITEMGRNM1.Caption = "제품군";
            this.fieldITEMGRNM1.FieldName = "ITEM_GR_NM";
            this.fieldITEMGRNM1.Name = "fieldITEMGRNM1";
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
            // fieldCLSNAME1
            // 
            this.fieldCLSNAME1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCLSNAME1.AreaIndex = 4;
            this.fieldCLSNAME1.Caption = "구분";
            this.fieldCLSNAME1.FieldName = "CLS_NAME";
            this.fieldCLSNAME1.Name = "fieldCLSNAME1";
            // 
            // fieldTARGETRATIO
            // 
            this.fieldTARGETRATIO.AreaIndex = 2;
            this.fieldTARGETRATIO.FieldName = "TARGET_RATIO";
            this.fieldTARGETRATIO.MinWidth = 0;
            this.fieldTARGETRATIO.Name = "fieldTARGETRATIO";
            this.fieldTARGETRATIO.Options.AllowHide = DevExpress.Utils.DefaultBoolean.True;
            // 
            // fieldQTY1
            // 
            this.fieldQTY1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQTY1.AreaIndex = 0;
            this.fieldQTY1.Caption = "수량";
            this.fieldQTY1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQTY1.FieldName = "QTY";
            this.fieldQTY1.Name = "fieldQTY1";
            // 
            // WoeRsPivotDayPlanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapPivotControl1);
            this.Name = "WoeRsPivotDayPlanList";
            this.Text = "WoeRsPivotDayPlanList";
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsPivotDayPlanModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Pivot.StrapPivotControl strapPivotControl1;
        private System.Windows.Forms.BindingSource rsPivotDayPlanModelBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCOMPCD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPLANTCD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWORKDT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMTYPENM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMGRNM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMCD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMNM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCLSNAME1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQTY1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTARGETRATIO;
    }
}
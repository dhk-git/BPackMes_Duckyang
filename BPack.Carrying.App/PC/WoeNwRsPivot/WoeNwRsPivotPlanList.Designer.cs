
namespace BPack.Carrying.App.PC.WoeNwRsPivot
{
    partial class WoeNwRsPivotPlanList
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
            this.nwRsPivotModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldCOMPCD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPLANTCD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWCCD1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWCNM1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYEAR = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMONTHCD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWEEKCD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWORKDT1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCLSTYPE1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCLSNAME1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSORTNO1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQTY1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwRsPivotModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapPivotControl1
            // 
            this.strapPivotControl1.DataSource = this.nwRsPivotModelBindingSource;
            this.strapPivotControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapPivotControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCOMPCD1,
            this.fieldPLANTCD1,
            this.fieldWCCD1,
            this.fieldWCNM1,
            this.fieldYEAR,
            this.fieldMONTHCD,
            this.fieldWEEKCD,
            this.fieldWORKDT1,
            this.fieldCLSTYPE1,
            this.fieldCLSNAME1,
            this.fieldSORTNO1,
            this.fieldQTY1});
            this.strapPivotControl1.Location = new System.Drawing.Point(0, 0);
            this.strapPivotControl1.Name = "strapPivotControl1";
            this.strapPivotControl1.Size = new System.Drawing.Size(800, 450);
            this.strapPivotControl1.TabIndex = 0;
            this.strapPivotControl1.CellClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.strapPivotControl1_CellClick);
            // 
            // nwRsPivotModelBindingSource
            // 
            this.nwRsPivotModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WoeNwRsPivot.NwRsPivotModel);
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
            // fieldWCCD1
            // 
            this.fieldWCCD1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldWCCD1.AreaIndex = 0;
            this.fieldWCCD1.Caption = "작업장";
            this.fieldWCCD1.FieldName = "WC_CD";
            this.fieldWCCD1.Name = "fieldWCCD1";
            // 
            // fieldWCNM1
            // 
            this.fieldWCNM1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldWCNM1.AreaIndex = 1;
            this.fieldWCNM1.Caption = "작업장";
            this.fieldWCNM1.FieldName = "WC_NM";
            this.fieldWCNM1.Name = "fieldWCNM1";
            // 
            // fieldYEAR
            // 
            this.fieldYEAR.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYEAR.AreaIndex = 0;
            this.fieldYEAR.Caption = "년도";
            this.fieldYEAR.FieldName = "YEAR";
            this.fieldYEAR.Name = "fieldYEAR";
            // 
            // fieldMONTHCD
            // 
            this.fieldMONTHCD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMONTHCD.AreaIndex = 1;
            this.fieldMONTHCD.Caption = "월";
            this.fieldMONTHCD.FieldName = "MONTH_CD";
            this.fieldMONTHCD.Name = "fieldMONTHCD";
            // 
            // fieldWEEKCD
            // 
            this.fieldWEEKCD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldWEEKCD.AreaIndex = 2;
            this.fieldWEEKCD.Caption = "주차";
            this.fieldWEEKCD.FieldName = "WEEK_CD";
            this.fieldWEEKCD.Name = "fieldWEEKCD";
            // 
            // fieldWORKDT1
            // 
            this.fieldWORKDT1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldWORKDT1.AreaIndex = 3;
            this.fieldWORKDT1.Caption = "일자";
            this.fieldWORKDT1.FieldName = "WORK_DT";
            this.fieldWORKDT1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldWORKDT1.Name = "fieldWORKDT1";
            this.fieldWORKDT1.UnboundFieldName = "fieldWORKDT1";
            // 
            // fieldCLSTYPE1
            // 
            this.fieldCLSTYPE1.AreaIndex = 2;
            this.fieldCLSTYPE1.Caption = "CLS_TYPE";
            this.fieldCLSTYPE1.FieldName = "CLS_TYPE";
            this.fieldCLSTYPE1.Name = "fieldCLSTYPE1";
            // 
            // fieldCLSNAME1
            // 
            this.fieldCLSNAME1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCLSNAME1.AreaIndex = 2;
            this.fieldCLSNAME1.Caption = "구분";
            this.fieldCLSNAME1.FieldName = "CLS_NAME";
            this.fieldCLSNAME1.Name = "fieldCLSNAME1";
            // 
            // fieldSORTNO1
            // 
            this.fieldSORTNO1.AreaIndex = 3;
            this.fieldSORTNO1.Caption = "SORT_NO";
            this.fieldSORTNO1.FieldName = "SORT_NO";
            this.fieldSORTNO1.Name = "fieldSORTNO1";
            // 
            // fieldQTY1
            // 
            this.fieldQTY1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQTY1.AreaIndex = 0;
            this.fieldQTY1.Caption = "수량";
            this.fieldQTY1.FieldName = "QTY";
            this.fieldQTY1.Name = "fieldQTY1";
            // 
            // WoeNwRsPivotPlanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapPivotControl1);
            this.Name = "WoeNwRsPivotPlanList";
            this.Text = "WoeNwRsPivotPlanList";
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwRsPivotModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Pivot.StrapPivotControl strapPivotControl1;
        private System.Windows.Forms.BindingSource nwRsPivotModelBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCOMPCD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPLANTCD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWCCD1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWCNM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWORKDT1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCLSTYPE1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCLSNAME1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSORTNO1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQTY1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMONTHCD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWEEKCD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYEAR;
    }
}
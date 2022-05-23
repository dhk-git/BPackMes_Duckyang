
namespace BPack.Carrying.App.PC.WoeRsPivot
{
    partial class RsPivotList
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
            this.rsPivotModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldWORKDT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSHIFTNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldHOURCD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldWCNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMCD = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMGR1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldITEMTYPENM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRSTQTY = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsPivotModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapPivotControl1
            // 
            this.strapPivotControl1.DataSource = this.rsPivotModelBindingSource;
            this.strapPivotControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapPivotControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldWORKDT,
            this.fieldSHIFTNM,
            this.fieldHOURCD,
            this.fieldWCNM,
            this.fieldITEMCD,
            this.fieldITEMNM,
            this.fieldITEMGR1,
            this.fieldITEMTYPENM,
            this.fieldRSTQTY});
            this.strapPivotControl1.Location = new System.Drawing.Point(0, 0);
            this.strapPivotControl1.Name = "strapPivotControl1";
            this.strapPivotControl1.OptionsView.ShowColumnHeaders = false;
            this.strapPivotControl1.OptionsView.ShowDataHeaders = false;
            this.strapPivotControl1.OptionsView.ShowFilterHeaders = false;
            this.strapPivotControl1.Size = new System.Drawing.Size(800, 450);
            this.strapPivotControl1.TabIndex = 0;
            // 
            // rsPivotModelBindingSource
            // 
            this.rsPivotModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WoeRsPivot.RsPivotModel);
            // 
            // fieldWORKDT
            // 
            this.fieldWORKDT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldWORKDT.AreaIndex = 0;
            this.fieldWORKDT.Caption = "생산일자";
            this.fieldWORKDT.FieldName = "WORK_DT";
            this.fieldWORKDT.Name = "fieldWORKDT";
            // 
            // fieldSHIFTNM
            // 
            this.fieldSHIFTNM.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSHIFTNM.AreaIndex = 0;
            this.fieldSHIFTNM.Caption = "근무조";
            this.fieldSHIFTNM.FieldName = "SHIFT_NM";
            this.fieldSHIFTNM.Name = "fieldSHIFTNM";
            this.fieldSHIFTNM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.fieldSHIFTNM.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // fieldHOURCD
            // 
            this.fieldHOURCD.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldHOURCD.AreaIndex = 1;
            this.fieldHOURCD.Caption = "시간";
            this.fieldHOURCD.FieldName = "HOUR_CD";
            this.fieldHOURCD.Name = "fieldHOURCD";
            this.fieldHOURCD.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldWCNM
            // 
            this.fieldWCNM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldWCNM.AreaIndex = 1;
            this.fieldWCNM.Caption = "작업장";
            this.fieldWCNM.FieldName = "WC_NM";
            this.fieldWCNM.Name = "fieldWCNM";
            this.fieldWCNM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldITEMCD
            // 
            this.fieldITEMCD.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMCD.AreaIndex = 2;
            this.fieldITEMCD.Caption = "품번";
            this.fieldITEMCD.FieldName = "ITEM_CD";
            this.fieldITEMCD.Name = "fieldITEMCD";
            this.fieldITEMCD.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldITEMNM
            // 
            this.fieldITEMNM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMNM.AreaIndex = 3;
            this.fieldITEMNM.Caption = "품명";
            this.fieldITEMNM.FieldName = "ITEM_NM";
            this.fieldITEMNM.Name = "fieldITEMNM";
            this.fieldITEMNM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldITEMGR1
            // 
            this.fieldITEMGR1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMGR1.AreaIndex = 4;
            this.fieldITEMGR1.Caption = "제품군";
            this.fieldITEMGR1.FieldName = "ITEM_GR_1";
            this.fieldITEMGR1.Name = "fieldITEMGR1";
            this.fieldITEMGR1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldITEMTYPENM
            // 
            this.fieldITEMTYPENM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldITEMTYPENM.AreaIndex = 5;
            this.fieldITEMTYPENM.Caption = "품목유형";
            this.fieldITEMTYPENM.FieldName = "ITEM_TYPE_NM";
            this.fieldITEMTYPENM.Name = "fieldITEMTYPENM";
            this.fieldITEMTYPENM.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.True;
            // 
            // fieldRSTQTY
            // 
            this.fieldRSTQTY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRSTQTY.AreaIndex = 0;
            this.fieldRSTQTY.Caption = "수량";
            this.fieldRSTQTY.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRSTQTY.FieldName = "RST_QTY";
            this.fieldRSTQTY.Name = "fieldRSTQTY";
            // 
            // RsPivotList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapPivotControl1);
            this.Name = "RsPivotList";
            this.Text = "RsPivotList";
            ((System.ComponentModel.ISupportInitialize)(this.strapPivotControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsPivotModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Pivot.StrapPivotControl strapPivotControl1;
        private System.Windows.Forms.BindingSource rsPivotModelBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWORKDT;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSHIFTNM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWCNM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMCD;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMNM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMGR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldITEMTYPENM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRSTQTY;
        private DevExpress.XtraPivotGrid.PivotGridField fieldHOURCD;
    }
}
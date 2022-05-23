
namespace BPack.Carrying.App.SD.DlvOrder
{
    partial class ToReserveHuList
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESERVED_HU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRESERVED_DOH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.bindingSource1;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWH_CD,
            this.colLOC_CD,
            this.colHU_NO,
            this.colRESERVED_HU_NO,
            this.colRESERVED_DOH_NO,
            this.colBARCODE_TEXT,
            this.colWORK_DT,
            this.colSTOCK_QTY,
            this.colREMARK});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(BPack.Model.App.SD.DlvOrder.ToReserveHuModel);
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
            // colLOC_CD
            // 
            this.colLOC_CD.FieldName = "LOC_CD";
            this.colLOC_CD.Name = "colLOC_CD";
            this.colLOC_CD.Visible = true;
            this.colLOC_CD.VisibleIndex = 3;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 4;
            // 
            // colRESERVED_HU_NO
            // 
            this.colRESERVED_HU_NO.FieldName = "RESERVED_HU_NO";
            this.colRESERVED_HU_NO.Name = "colRESERVED_HU_NO";
            this.colRESERVED_HU_NO.Visible = true;
            this.colRESERVED_HU_NO.VisibleIndex = 5;
            // 
            // colRESERVED_DOH_NO
            // 
            this.colRESERVED_DOH_NO.FieldName = "RESERVED_DOH_NO";
            this.colRESERVED_DOH_NO.Name = "colRESERVED_DOH_NO";
            this.colRESERVED_DOH_NO.Visible = true;
            this.colRESERVED_DOH_NO.VisibleIndex = 6;
            // 
            // colBARCODE_TEXT
            // 
            this.colBARCODE_TEXT.FieldName = "BARCODE_TEXT";
            this.colBARCODE_TEXT.Name = "colBARCODE_TEXT";
            this.colBARCODE_TEXT.Visible = true;
            this.colBARCODE_TEXT.VisibleIndex = 7;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 8;
            // 
            // colSTOCK_QTY
            // 
            this.colSTOCK_QTY.FieldName = "STOCK_QTY";
            this.colSTOCK_QTY.Name = "colSTOCK_QTY";
            this.colSTOCK_QTY.Visible = true;
            this.colSTOCK_QTY.VisibleIndex = 9;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 10;
            // 
            // ToReserveHuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ToReserveHuList";
            this.Text = "ToReserveHuList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colRESERVED_HU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colRESERVED_DOH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_TEXT;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
    }
}
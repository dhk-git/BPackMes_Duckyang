namespace BPack.Carrying.App.SD.DlvConfirm
{
    partial class DlvConfirmDetailHUList
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
            this.DlvConfirmDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colROW_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_READY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIFO_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIFO_PASS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHK_RESULT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOMER_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlvConfirmDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.DlvConfirmDetailModelBindingSource;
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
            // DlvConfirmDetailModelBindingSource
            // 
            this.DlvConfirmDetailModelBindingSource.DataSource = typeof(BPack.Model.App.SD.DlvConfirm.DlvConfirmDetailHUModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colROW_SEQ,
            this.colDOD_NO,
            this.colHU_NO,
            this.colHU_BARCODE,
            this.colCUSTOMER_BARCODE,
            this.colDLV_READY_DTTM,
            this.colWORK_DT,
            this.colDR_QTY,
            this.colFIFO_FG,
            this.colFIFO_PASS,
            this.colCHK_RESULT,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 0;
            // 
            // colDOD_NO
            // 
            this.colDOD_NO.FieldName = "DOD_NO";
            this.colDOD_NO.Name = "colDOD_NO";
            this.colDOD_NO.OptionsColumn.ReadOnly = true;
            this.colDOD_NO.Visible = true;
            this.colDOD_NO.VisibleIndex = 1;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.OptionsColumn.ReadOnly = true;
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 2;
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.OptionsColumn.ReadOnly = true;
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 3;
            // 
            // colDLV_READY_DTTM
            // 
            this.colDLV_READY_DTTM.FieldName = "DLV_READY_DTTM";
            this.colDLV_READY_DTTM.Name = "colDLV_READY_DTTM";
            this.colDLV_READY_DTTM.OptionsColumn.ReadOnly = true;
            this.colDLV_READY_DTTM.Visible = true;
            this.colDLV_READY_DTTM.VisibleIndex = 5;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.OptionsColumn.ReadOnly = true;
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 6;
            // 
            // colDR_QTY
            // 
            this.colDR_QTY.FieldName = "DR_QTY";
            this.colDR_QTY.Name = "colDR_QTY";
            this.colDR_QTY.Visible = true;
            this.colDR_QTY.VisibleIndex = 7;
            // 
            // colFIFO_FG
            // 
            this.colFIFO_FG.FieldName = "FIFO_FG";
            this.colFIFO_FG.Name = "colFIFO_FG";
            this.colFIFO_FG.OptionsColumn.ReadOnly = true;
            this.colFIFO_FG.Visible = true;
            this.colFIFO_FG.VisibleIndex = 8;
            // 
            // colFIFO_PASS
            // 
            this.colFIFO_PASS.FieldName = "FIFO_PASS";
            this.colFIFO_PASS.Name = "colFIFO_PASS";
            this.colFIFO_PASS.OptionsColumn.ReadOnly = true;
            this.colFIFO_PASS.Visible = true;
            this.colFIFO_PASS.VisibleIndex = 9;
            // 
            // colCHK_RESULT
            // 
            this.colCHK_RESULT.FieldName = "CHK_RESULT";
            this.colCHK_RESULT.Name = "colCHK_RESULT";
            this.colCHK_RESULT.OptionsColumn.ReadOnly = true;
            this.colCHK_RESULT.Visible = true;
            this.colCHK_RESULT.VisibleIndex = 10;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 11;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 12;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 13;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 14;
            // 
            // colCUSTOMER_BARCODE
            // 
            this.colCUSTOMER_BARCODE.FieldName = "CUSTOMER_BARCODE";
            this.colCUSTOMER_BARCODE.Name = "colCUSTOMER_BARCODE";
            this.colCUSTOMER_BARCODE.Visible = true;
            this.colCUSTOMER_BARCODE.VisibleIndex = 4;
            // 
            // DlvConfirmDetailHUList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "DlvConfirmDetailHUList";
            this.Text = "DlvConfirmDetailHUList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlvConfirmDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public Strap.Grid.StrapGridControl strapGridControl1;
        private System.Windows.Forms.BindingSource DlvConfirmDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colDOD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_READY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colFIFO_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colFIFO_PASS;
        private DevExpress.XtraGrid.Columns.GridColumn colCHK_RESULT;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSTOMER_BARCODE;
    }
}
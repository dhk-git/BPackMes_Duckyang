namespace BPack.Carrying.App.SD.DlvConfirm
{
    partial class DlvConfirmDetailJISList
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
            this.colDOD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOH_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBS_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHK_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHK_RESULT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_READY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIFO_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJIS_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBODY_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHG_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOG_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlvConfirmDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
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
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // DlvConfirmDetailModelBindingSource
            // 
            this.DlvConfirmDetailModelBindingSource.DataSource = typeof(BPack.Model.App.SD.DlvConfirm.DlvConfirmDetailJISModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDOD_NO,
            this.colDOH_NO,
            this.colDOH_SEQ,
            this.colPBS_SEQ,
            this.colITEM_GR_1,
            this.colALC_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colCHK_DTTM,
            this.colCHK_RESULT,
            this.colDLV_READY_DTTM,
            this.colWORK_DT,
            this.colHU_NO,
            this.colHU_BARCODE,
            this.colFIFO_FG,
            this.colDO_QTY,
            this.colDR_QTY,
            this.colJIS_NO,
            this.colALC_NO,
            this.colPROD_DT,
            this.colBODY_NO,
            this.colCHG_FG,
            this.colOG_NO,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colDOD_NO
            // 
            this.colDOD_NO.FieldName = "DOD_NO";
            this.colDOD_NO.Name = "colDOD_NO";
            this.colDOD_NO.OptionsColumn.ReadOnly = true;
            this.colDOD_NO.Visible = true;
            this.colDOD_NO.VisibleIndex = 0;
            // 
            // colDOH_NO
            // 
            this.colDOH_NO.FieldName = "DOH_NO";
            this.colDOH_NO.Name = "colDOH_NO";
            this.colDOH_NO.OptionsColumn.ReadOnly = true;
            this.colDOH_NO.Visible = true;
            this.colDOH_NO.VisibleIndex = 1;
            // 
            // colDOH_SEQ
            // 
            this.colDOH_SEQ.FieldName = "DOH_SEQ";
            this.colDOH_SEQ.Name = "colDOH_SEQ";
            this.colDOH_SEQ.OptionsColumn.ReadOnly = true;
            this.colDOH_SEQ.Visible = true;
            this.colDOH_SEQ.VisibleIndex = 2;
            // 
            // colPBS_SEQ
            // 
            this.colPBS_SEQ.FieldName = "PBS_SEQ";
            this.colPBS_SEQ.Name = "colPBS_SEQ";
            this.colPBS_SEQ.OptionsColumn.ReadOnly = true;
            this.colPBS_SEQ.Visible = true;
            this.colPBS_SEQ.VisibleIndex = 3;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.OptionsColumn.ReadOnly = true;
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 4;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.OptionsColumn.ReadOnly = true;
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 5;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.OptionsColumn.ReadOnly = true;
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 6;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.OptionsColumn.ReadOnly = true;
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 7;
            // 
            // colCHK_DTTM
            // 
            this.colCHK_DTTM.FieldName = "CHK_DTTM";
            this.colCHK_DTTM.Name = "colCHK_DTTM";
            this.colCHK_DTTM.OptionsColumn.ReadOnly = true;
            this.colCHK_DTTM.Visible = true;
            this.colCHK_DTTM.VisibleIndex = 8;
            // 
            // colCHK_RESULT
            // 
            this.colCHK_RESULT.FieldName = "CHK_RESULT";
            this.colCHK_RESULT.Name = "colCHK_RESULT";
            this.colCHK_RESULT.OptionsColumn.ReadOnly = true;
            this.colCHK_RESULT.Visible = true;
            this.colCHK_RESULT.VisibleIndex = 9;
            // 
            // colDLV_READY_DTTM
            // 
            this.colDLV_READY_DTTM.FieldName = "DLV_READY_DTTM";
            this.colDLV_READY_DTTM.Name = "colDLV_READY_DTTM";
            this.colDLV_READY_DTTM.OptionsColumn.ReadOnly = true;
            this.colDLV_READY_DTTM.Visible = true;
            this.colDLV_READY_DTTM.VisibleIndex = 10;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.OptionsColumn.ReadOnly = true;
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 11;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.OptionsColumn.ReadOnly = true;
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 12;
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.OptionsColumn.ReadOnly = true;
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 13;
            // 
            // colFIFO_FG
            // 
            this.colFIFO_FG.FieldName = "FIFO_FG";
            this.colFIFO_FG.Name = "colFIFO_FG";
            this.colFIFO_FG.OptionsColumn.ReadOnly = true;
            this.colFIFO_FG.Visible = true;
            this.colFIFO_FG.VisibleIndex = 14;
            // 
            // colDO_QTY
            // 
            this.colDO_QTY.FieldName = "DO_QTY";
            this.colDO_QTY.Name = "colDO_QTY";
            this.colDO_QTY.OptionsColumn.ReadOnly = true;
            this.colDO_QTY.Visible = true;
            this.colDO_QTY.VisibleIndex = 15;
            // 
            // colDR_QTY
            // 
            this.colDR_QTY.FieldName = "DR_QTY";
            this.colDR_QTY.Name = "colDR_QTY";
            this.colDR_QTY.OptionsColumn.ReadOnly = true;
            this.colDR_QTY.Visible = true;
            this.colDR_QTY.VisibleIndex = 16;
            // 
            // colJIS_NO
            // 
            this.colJIS_NO.FieldName = "JIS_NO";
            this.colJIS_NO.Name = "colJIS_NO";
            this.colJIS_NO.OptionsColumn.ReadOnly = true;
            this.colJIS_NO.Visible = true;
            this.colJIS_NO.VisibleIndex = 17;
            // 
            // colALC_NO
            // 
            this.colALC_NO.FieldName = "ALC_NO";
            this.colALC_NO.Name = "colALC_NO";
            this.colALC_NO.OptionsColumn.ReadOnly = true;
            this.colALC_NO.Visible = true;
            this.colALC_NO.VisibleIndex = 18;
            // 
            // colPROD_DT
            // 
            this.colPROD_DT.FieldName = "PROD_DT";
            this.colPROD_DT.Name = "colPROD_DT";
            this.colPROD_DT.OptionsColumn.ReadOnly = true;
            this.colPROD_DT.Visible = true;
            this.colPROD_DT.VisibleIndex = 19;
            // 
            // colBODY_NO
            // 
            this.colBODY_NO.FieldName = "BODY_NO";
            this.colBODY_NO.Name = "colBODY_NO";
            this.colBODY_NO.OptionsColumn.ReadOnly = true;
            this.colBODY_NO.Visible = true;
            this.colBODY_NO.VisibleIndex = 20;
            // 
            // colCHG_FG
            // 
            this.colCHG_FG.FieldName = "CHG_FG";
            this.colCHG_FG.Name = "colCHG_FG";
            this.colCHG_FG.OptionsColumn.ReadOnly = true;
            this.colCHG_FG.Visible = true;
            this.colCHG_FG.VisibleIndex = 21;
            // 
            // colOG_NO
            // 
            this.colOG_NO.FieldName = "OG_NO";
            this.colOG_NO.Name = "colOG_NO";
            this.colOG_NO.OptionsColumn.ReadOnly = true;
            this.colOG_NO.Visible = true;
            this.colOG_NO.VisibleIndex = 22;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 23;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 24;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 25;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 26;
            // 
            // DlvConfirmDetailJISList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "DlvConfirmDetailJISList";
            this.Text = "DlvConfirmDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlvConfirmDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public Strap.Grid.StrapGridControl strapGridControl1;
        private System.Windows.Forms.BindingSource DlvConfirmDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDOD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDOH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDOH_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colPBS_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colCHK_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCHK_RESULT;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_READY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colFIFO_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colDR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colJIS_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colBODY_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCHG_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colOG_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
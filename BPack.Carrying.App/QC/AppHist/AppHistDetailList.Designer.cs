namespace BPack.Carrying.App.QC.AppHist
{
    partial class AppHistDetailList
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
            this.AppHistDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colINSP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASE_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_JUDGE_QC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_DTTM_QC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppHistDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.AppHistDetailModelBindingSource;
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
            // AppHistDetailModelBindingSource
            // 
            this.AppHistDetailModelBindingSource.DataSource = typeof(BPack.Model.App.QC.AppHist.AppHistDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colINSP_NO,
            this.colITEM_GR_1,
            this.colALC_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colBASE_UNIT,
            this.colDO_QTY,
            this.colINSP_JUDGE_QC,
            this.colINSP_DTTM_QC,
            this.colINSP_QTY,
            this.colINSP_SEQ,
            this.colHU_NO,
            this.colWORK_DT,
            this.colLOT_NO,
            this.colHU_BARCODE,
            this.colREMARK,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView1_CellMerge);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colINSP_NO
            // 
            this.colINSP_NO.FieldName = "INSP_NO";
            this.colINSP_NO.Name = "colINSP_NO";
            this.colINSP_NO.Visible = true;
            this.colINSP_NO.VisibleIndex = 0;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.OptionsColumn.ReadOnly = true;
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 1;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.OptionsColumn.ReadOnly = true;
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 2;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.OptionsColumn.ReadOnly = true;
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 3;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.OptionsColumn.ReadOnly = true;
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 4;
            // 
            // colBASE_UNIT
            // 
            this.colBASE_UNIT.FieldName = "BASE_UNIT";
            this.colBASE_UNIT.Name = "colBASE_UNIT";
            this.colBASE_UNIT.OptionsColumn.ReadOnly = true;
            this.colBASE_UNIT.Visible = true;
            this.colBASE_UNIT.VisibleIndex = 5;
            // 
            // colDO_QTY
            // 
            this.colDO_QTY.FieldName = "DO_QTY";
            this.colDO_QTY.Name = "colDO_QTY";
            this.colDO_QTY.OptionsColumn.ReadOnly = true;
            this.colDO_QTY.Visible = true;
            this.colDO_QTY.VisibleIndex = 6;
            // 
            // colINSP_JUDGE_QC
            // 
            this.colINSP_JUDGE_QC.FieldName = "INSP_JUDGE_QC";
            this.colINSP_JUDGE_QC.Name = "colINSP_JUDGE_QC";
            this.colINSP_JUDGE_QC.Visible = true;
            this.colINSP_JUDGE_QC.VisibleIndex = 7;
            // 
            // colINSP_DTTM_QC
            // 
            this.colINSP_DTTM_QC.FieldName = "INSP_DTTM_QC";
            this.colINSP_DTTM_QC.Name = "colINSP_DTTM_QC";
            this.colINSP_DTTM_QC.Visible = true;
            this.colINSP_DTTM_QC.VisibleIndex = 8;
            // 
            // colINSP_QTY
            // 
            this.colINSP_QTY.FieldName = "INSP_QTY";
            this.colINSP_QTY.Name = "colINSP_QTY";
            this.colINSP_QTY.Visible = true;
            this.colINSP_QTY.VisibleIndex = 9;
            // 
            // colINSP_SEQ
            // 
            this.colINSP_SEQ.FieldName = "INSP_SEQ";
            this.colINSP_SEQ.Name = "colINSP_SEQ";
            this.colINSP_SEQ.Visible = true;
            this.colINSP_SEQ.VisibleIndex = 10;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.OptionsColumn.ReadOnly = true;
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 11;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 12;
            // 
            // colLOT_NO
            // 
            this.colLOT_NO.FieldName = "LOT_NO";
            this.colLOT_NO.Name = "colLOT_NO";
            this.colLOT_NO.Visible = true;
            this.colLOT_NO.VisibleIndex = 13;
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.OptionsColumn.ReadOnly = true;
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 14;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 15;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 16;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 17;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 18;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 19;
            // 
            // AppHistDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "AppHistDetailList";
            this.Text = "AppHistDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppHistDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public Strap.Grid.StrapGridControl strapGridControl1;
        private System.Windows.Forms.BindingSource AppHistDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colBASE_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_JUDGE_QC;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_DTTM_QC;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colLOT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
namespace BPack.Carrying.App.SD.DlvConfirm
{
    partial class DlvConfirmHeaderList
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
            this.DlvConfirmHeaderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDLV_PLC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_PLC_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCP_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAD_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREQ_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREQ_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_STATUS_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_READY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_DT_MAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAR_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRIV_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlvConfirmHeaderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.DlvConfirmHeaderModelBindingSource;
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
            // DlvConfirmHeaderModelBindingSource
            // 
            this.DlvConfirmHeaderModelBindingSource.DataSource = typeof(BPack.Model.App.SD.DlvConfirm.DlvConfirmHeaderModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDLV_PLC_CD,
            this.colDLV_PLC_NM,
            this.colCP_NO,
            this.colCP_SEQ,
            this.colLOAD_SEQ,
            this.colDLV_TYPE,
            this.colREQ_DT,
            this.colREQ_SEQ,
            this.colDO_QTY,
            this.colDR_QTY,
            this.colDOH_NO,
            this.colDLV_STATUS,
            this.colDLV_STATUS_NM,
            this.colDLV_READY_DTTM,
            this.colDRT_NO,
            this.colDLV_DT,
            this.colDLV_DT_MAX,
            this.colDLV_TM,
            this.colCAR_NO,
            this.colDRIV_NM,
            this.colPHONE_NO,
            this.colOP_NO,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView1_CellMerge);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colDLV_PLC_CD
            // 
            this.colDLV_PLC_CD.FieldName = "DLV_PLC_CD";
            this.colDLV_PLC_CD.Name = "colDLV_PLC_CD";
            this.colDLV_PLC_CD.OptionsColumn.ReadOnly = true;
            this.colDLV_PLC_CD.Visible = true;
            this.colDLV_PLC_CD.VisibleIndex = 0;
            // 
            // colDLV_PLC_NM
            // 
            this.colDLV_PLC_NM.FieldName = "DLV_PLC_NM";
            this.colDLV_PLC_NM.Name = "colDLV_PLC_NM";
            this.colDLV_PLC_NM.OptionsColumn.ReadOnly = true;
            this.colDLV_PLC_NM.Visible = true;
            this.colDLV_PLC_NM.VisibleIndex = 1;
            // 
            // colCP_NO
            // 
            this.colCP_NO.FieldName = "CP_NO";
            this.colCP_NO.Name = "colCP_NO";
            this.colCP_NO.OptionsColumn.ReadOnly = true;
            this.colCP_NO.Visible = true;
            this.colCP_NO.VisibleIndex = 2;
            // 
            // colCP_SEQ
            // 
            this.colCP_SEQ.FieldName = "CP_SEQ";
            this.colCP_SEQ.Name = "colCP_SEQ";
            this.colCP_SEQ.OptionsColumn.ReadOnly = true;
            this.colCP_SEQ.Visible = true;
            this.colCP_SEQ.VisibleIndex = 3;
            // 
            // colLOAD_SEQ
            // 
            this.colLOAD_SEQ.FieldName = "LOAD_SEQ";
            this.colLOAD_SEQ.Name = "colLOAD_SEQ";
            this.colLOAD_SEQ.OptionsColumn.ReadOnly = true;
            this.colLOAD_SEQ.Visible = true;
            this.colLOAD_SEQ.VisibleIndex = 4;
            // 
            // colDLV_TYPE
            // 
            this.colDLV_TYPE.FieldName = "DLV_TYPE";
            this.colDLV_TYPE.Name = "colDLV_TYPE";
            this.colDLV_TYPE.OptionsColumn.ReadOnly = true;
            this.colDLV_TYPE.Visible = true;
            this.colDLV_TYPE.VisibleIndex = 5;
            // 
            // colREQ_DT
            // 
            this.colREQ_DT.FieldName = "REQ_DT";
            this.colREQ_DT.Name = "colREQ_DT";
            this.colREQ_DT.OptionsColumn.ReadOnly = true;
            this.colREQ_DT.Visible = true;
            this.colREQ_DT.VisibleIndex = 6;
            // 
            // colREQ_SEQ
            // 
            this.colREQ_SEQ.FieldName = "REQ_SEQ";
            this.colREQ_SEQ.Name = "colREQ_SEQ";
            this.colREQ_SEQ.OptionsColumn.ReadOnly = true;
            this.colREQ_SEQ.Visible = true;
            this.colREQ_SEQ.VisibleIndex = 7;
            // 
            // colDO_QTY
            // 
            this.colDO_QTY.FieldName = "DO_QTY";
            this.colDO_QTY.Name = "colDO_QTY";
            this.colDO_QTY.OptionsColumn.ReadOnly = true;
            this.colDO_QTY.Visible = true;
            this.colDO_QTY.VisibleIndex = 8;
            // 
            // colDR_QTY
            // 
            this.colDR_QTY.FieldName = "DR_QTY";
            this.colDR_QTY.Name = "colDR_QTY";
            this.colDR_QTY.OptionsColumn.ReadOnly = true;
            this.colDR_QTY.Visible = true;
            this.colDR_QTY.VisibleIndex = 9;
            // 
            // colDOH_NO
            // 
            this.colDOH_NO.FieldName = "DOH_NO";
            this.colDOH_NO.Name = "colDOH_NO";
            this.colDOH_NO.OptionsColumn.ReadOnly = true;
            this.colDOH_NO.Visible = true;
            this.colDOH_NO.VisibleIndex = 10;
            // 
            // colDLV_STATUS
            // 
            this.colDLV_STATUS.FieldName = "DLV_STATUS";
            this.colDLV_STATUS.Name = "colDLV_STATUS";
            this.colDLV_STATUS.OptionsColumn.ReadOnly = true;
            this.colDLV_STATUS.Visible = true;
            this.colDLV_STATUS.VisibleIndex = 11;
            // 
            // colDLV_STATUS_NM
            // 
            this.colDLV_STATUS_NM.FieldName = "DLV_STATUS_NM";
            this.colDLV_STATUS_NM.Name = "colDLV_STATUS_NM";
            this.colDLV_STATUS_NM.OptionsColumn.ReadOnly = true;
            this.colDLV_STATUS_NM.Visible = true;
            this.colDLV_STATUS_NM.VisibleIndex = 12;
            // 
            // colDLV_READY_DTTM
            // 
            this.colDLV_READY_DTTM.FieldName = "DLV_READY_DTTM";
            this.colDLV_READY_DTTM.Name = "colDLV_READY_DTTM";
            this.colDLV_READY_DTTM.OptionsColumn.ReadOnly = true;
            this.colDLV_READY_DTTM.Visible = true;
            this.colDLV_READY_DTTM.VisibleIndex = 13;
            // 
            // colDRT_NO
            // 
            this.colDRT_NO.FieldName = "DRT_NO";
            this.colDRT_NO.Name = "colDRT_NO";
            this.colDRT_NO.OptionsColumn.ReadOnly = true;
            this.colDRT_NO.Visible = true;
            this.colDRT_NO.VisibleIndex = 14;
            // 
            // colDLV_DT
            // 
            this.colDLV_DT.FieldName = "DLV_DT";
            this.colDLV_DT.Name = "colDLV_DT";
            this.colDLV_DT.OptionsColumn.ReadOnly = true;
            this.colDLV_DT.Visible = true;
            this.colDLV_DT.VisibleIndex = 15;
            // 
            // colDLV_DT_MAX
            // 
            this.colDLV_DT_MAX.FieldName = "DLV_DT_MAX";
            this.colDLV_DT_MAX.Name = "colDLV_DT_MAX";
            this.colDLV_DT_MAX.OptionsColumn.ReadOnly = true;
            this.colDLV_DT_MAX.Visible = true;
            this.colDLV_DT_MAX.VisibleIndex = 16;
            // 
            // colDLV_TM
            // 
            this.colDLV_TM.FieldName = "DLV_TM";
            this.colDLV_TM.Name = "colDLV_TM";
            this.colDLV_TM.OptionsColumn.ReadOnly = true;
            this.colDLV_TM.Visible = true;
            this.colDLV_TM.VisibleIndex = 17;
            // 
            // colCAR_NO
            // 
            this.colCAR_NO.FieldName = "CAR_NO";
            this.colCAR_NO.Name = "colCAR_NO";
            this.colCAR_NO.OptionsColumn.ReadOnly = true;
            this.colCAR_NO.Visible = true;
            this.colCAR_NO.VisibleIndex = 18;
            // 
            // colDRIV_NM
            // 
            this.colDRIV_NM.FieldName = "DRIV_NM";
            this.colDRIV_NM.Name = "colDRIV_NM";
            this.colDRIV_NM.OptionsColumn.ReadOnly = true;
            this.colDRIV_NM.Visible = true;
            this.colDRIV_NM.VisibleIndex = 19;
            // 
            // colPHONE_NO
            // 
            this.colPHONE_NO.FieldName = "PHONE_NO";
            this.colPHONE_NO.Name = "colPHONE_NO";
            this.colPHONE_NO.OptionsColumn.ReadOnly = true;
            this.colPHONE_NO.Visible = true;
            this.colPHONE_NO.VisibleIndex = 20;
            // 
            // colOP_NO
            // 
            this.colOP_NO.FieldName = "OP_NO";
            this.colOP_NO.Name = "colOP_NO";
            this.colOP_NO.OptionsColumn.ReadOnly = true;
            this.colOP_NO.Visible = true;
            this.colOP_NO.VisibleIndex = 21;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 22;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 23;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 24;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 25;
            // 
            // DlvConfirmHeaderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "DlvConfirmHeaderList";
            this.Text = "DlvConfirmHeaderList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DlvConfirmHeaderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource DlvConfirmHeaderModelBindingSource;
        public Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_PLC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_PLC_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colCP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCP_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAD_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colREQ_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colREQ_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colDR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colDOH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_STATUS_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_READY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colDRT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_DT_MAX;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colCAR_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDRIV_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colOP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
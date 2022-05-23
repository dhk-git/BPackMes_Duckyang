namespace BPack.Carrying.App.SD.DlvHist
{
    partial class DlvHistDetailList
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
            this.dlvHistDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPROD_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREQ_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGATE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBODY_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBS_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_INIT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSCAN_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvHistDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.dlvHistDetailModelBindingSource;
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
            // dlvHistDetailModelBindingSource
            // 
            this.dlvHistDetailModelBindingSource.DataSource = typeof(BPack.Model.App.SD.DlvHist.DlvHistDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPROD_DT,
            this.colREQ_DT,
            this.colDLV_DT,
            this.colDOD_NO,
            this.colGATE_CD,
            this.colDLV_TYPE,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colALC_CD,
            this.colITEM_GR_1,
            this.colBODY_NO,
            this.colPBS_SEQ,
            this.colDO_QTY,
            this.colDR_QTY,
            this.colHU_INIT_QTY,
            this.colCREATE_DTTM,
            this.colHU_NO,
            this.colHU_BARCODE,
            this.colSCAN_DTTM,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPROD_DT
            // 
            this.colPROD_DT.FieldName = "PROD_DT";
            this.colPROD_DT.Name = "colPROD_DT";
            this.colPROD_DT.Visible = true;
            this.colPROD_DT.VisibleIndex = 0;
            // 
            // colREQ_DT
            // 
            this.colREQ_DT.FieldName = "REQ_DT";
            this.colREQ_DT.Name = "colREQ_DT";
            this.colREQ_DT.Visible = true;
            this.colREQ_DT.VisibleIndex = 1;
            // 
            // colDLV_DT
            // 
            this.colDLV_DT.FieldName = "DLV_DT";
            this.colDLV_DT.Name = "colDLV_DT";
            this.colDLV_DT.Visible = true;
            this.colDLV_DT.VisibleIndex = 2;
            // 
            // colDOD_NO
            // 
            this.colDOD_NO.FieldName = "DOD_NO";
            this.colDOD_NO.Name = "colDOD_NO";
            this.colDOD_NO.Visible = true;
            this.colDOD_NO.VisibleIndex = 3;
            // 
            // colGATE_CD
            // 
            this.colGATE_CD.FieldName = "GATE_CD";
            this.colGATE_CD.Name = "colGATE_CD";
            this.colGATE_CD.Visible = true;
            this.colGATE_CD.VisibleIndex = 4;
            // 
            // colDLV_TYPE
            // 
            this.colDLV_TYPE.FieldName = "DLV_TYPE";
            this.colDLV_TYPE.Name = "colDLV_TYPE";
            this.colDLV_TYPE.Visible = true;
            this.colDLV_TYPE.VisibleIndex = 5;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 6;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 7;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 8;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 9;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 10;
            // 
            // colBODY_NO
            // 
            this.colBODY_NO.FieldName = "BODY_NO";
            this.colBODY_NO.Name = "colBODY_NO";
            this.colBODY_NO.Visible = true;
            this.colBODY_NO.VisibleIndex = 11;
            // 
            // colPBS_SEQ
            // 
            this.colPBS_SEQ.FieldName = "PBS_SEQ";
            this.colPBS_SEQ.Name = "colPBS_SEQ";
            this.colPBS_SEQ.Visible = true;
            this.colPBS_SEQ.VisibleIndex = 12;
            // 
            // colDO_QTY
            // 
            this.colDO_QTY.FieldName = "DO_QTY";
            this.colDO_QTY.Name = "colDO_QTY";
            this.colDO_QTY.Visible = true;
            this.colDO_QTY.VisibleIndex = 13;
            // 
            // colDR_QTY
            // 
            this.colDR_QTY.FieldName = "DR_QTY";
            this.colDR_QTY.Name = "colDR_QTY";
            this.colDR_QTY.Visible = true;
            this.colDR_QTY.VisibleIndex = 14;
            // 
            // colHU_INIT_QTY
            // 
            this.colHU_INIT_QTY.FieldName = "HU_INIT_QTY";
            this.colHU_INIT_QTY.Name = "colHU_INIT_QTY";
            this.colHU_INIT_QTY.Visible = true;
            this.colHU_INIT_QTY.VisibleIndex = 15;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 16;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 17;
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 18;
            // 
            // colSCAN_DTTM
            // 
            this.colSCAN_DTTM.FieldName = "SCAN_DTTM";
            this.colSCAN_DTTM.Name = "colSCAN_DTTM";
            this.colSCAN_DTTM.Visible = true;
            this.colSCAN_DTTM.VisibleIndex = 19;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 20;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 21;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 22;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 23;
            // 
            // DlvHistDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "DlvHistDetailList";
            this.Text = "DlvHistDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvHistDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dlvHistDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPROD_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colREQ_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDOD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colGATE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colBODY_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPBS_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colDR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_INIT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colSCAN_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
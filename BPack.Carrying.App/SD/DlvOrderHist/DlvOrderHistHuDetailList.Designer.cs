
namespace BPack.Carrying.App.SD.DlvOrderHist
{
    partial class DlvOrderHistHuDetailList
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
            this.dlvOrderHistHuDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDOH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOH_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDER_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOM_PO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_DOH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVEHICLE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPICKING_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrderHistHuDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.dlvOrderHistHuDetailModelBindingSource;
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
            // dlvOrderHistHuDetailModelBindingSource
            // 
            this.dlvOrderHistHuDetailModelBindingSource.DataSource = typeof(BPack.Model.App.SD.DlvOrderHist.DlvOrderHistHuDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDOH_NO,
            this.colDOD_NO,
            this.colDRH_NO,
            this.colDRD_NO,
            this.colDOH_DT,
            this.colORDER_SEQ,
            this.colCUSTOM_PO_NO,
            this.colCUST_DOH_NO,
            this.colVEHICLE_NO,
            this.colPICKING_DT,
            this.colDLV_DT,
            this.colDLV_TM,
            this.colBP_CD,
            this.colITEM_GR_1,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colWH_CD,
            this.colLOC_CD,
            this.colHU_NO,
            this.colBARCODE_TEXT,
            this.colHU_QTY,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colDOH_NO
            // 
            this.colDOH_NO.FieldName = "DOH_NO";
            this.colDOH_NO.Name = "colDOH_NO";
            this.colDOH_NO.Visible = true;
            this.colDOH_NO.VisibleIndex = 0;
            // 
            // colDOD_NO
            // 
            this.colDOD_NO.FieldName = "DOD_NO";
            this.colDOD_NO.Name = "colDOD_NO";
            this.colDOD_NO.Visible = true;
            this.colDOD_NO.VisibleIndex = 1;
            // 
            // colDRH_NO
            // 
            this.colDRH_NO.FieldName = "DRH_NO";
            this.colDRH_NO.Name = "colDRH_NO";
            this.colDRH_NO.Visible = true;
            this.colDRH_NO.VisibleIndex = 2;
            // 
            // colDRD_NO
            // 
            this.colDRD_NO.FieldName = "DRD_NO";
            this.colDRD_NO.Name = "colDRD_NO";
            this.colDRD_NO.Visible = true;
            this.colDRD_NO.VisibleIndex = 3;
            // 
            // colDOH_DT
            // 
            this.colDOH_DT.FieldName = "DOH_DT";
            this.colDOH_DT.Name = "colDOH_DT";
            this.colDOH_DT.Visible = true;
            this.colDOH_DT.VisibleIndex = 4;
            // 
            // colORDER_SEQ
            // 
            this.colORDER_SEQ.FieldName = "ORDER_SEQ";
            this.colORDER_SEQ.Name = "colORDER_SEQ";
            this.colORDER_SEQ.Visible = true;
            this.colORDER_SEQ.VisibleIndex = 5;
            // 
            // colCUSTOM_PO_NO
            // 
            this.colCUSTOM_PO_NO.FieldName = "CUSTOM_PO_NO";
            this.colCUSTOM_PO_NO.Name = "colCUSTOM_PO_NO";
            this.colCUSTOM_PO_NO.Visible = true;
            this.colCUSTOM_PO_NO.VisibleIndex = 6;
            // 
            // colCUST_DOH_NO
            // 
            this.colCUST_DOH_NO.FieldName = "CUST_DOH_NO";
            this.colCUST_DOH_NO.Name = "colCUST_DOH_NO";
            this.colCUST_DOH_NO.Visible = true;
            this.colCUST_DOH_NO.VisibleIndex = 7;
            // 
            // colVEHICLE_NO
            // 
            this.colVEHICLE_NO.FieldName = "VEHICLE_NO";
            this.colVEHICLE_NO.Name = "colVEHICLE_NO";
            this.colVEHICLE_NO.Visible = true;
            this.colVEHICLE_NO.VisibleIndex = 8;
            // 
            // colPICKING_DT
            // 
            this.colPICKING_DT.FieldName = "PICKING_DT";
            this.colPICKING_DT.Name = "colPICKING_DT";
            this.colPICKING_DT.Visible = true;
            this.colPICKING_DT.VisibleIndex = 9;
            // 
            // colDLV_DT
            // 
            this.colDLV_DT.FieldName = "DLV_DT";
            this.colDLV_DT.Name = "colDLV_DT";
            this.colDLV_DT.Visible = true;
            this.colDLV_DT.VisibleIndex = 10;
            // 
            // colDLV_TM
            // 
            this.colDLV_TM.FieldName = "DLV_TM";
            this.colDLV_TM.Name = "colDLV_TM";
            this.colDLV_TM.Visible = true;
            this.colDLV_TM.VisibleIndex = 11;
            // 
            // colBP_CD
            // 
            this.colBP_CD.FieldName = "BP_CD";
            this.colBP_CD.Name = "colBP_CD";
            this.colBP_CD.Visible = true;
            this.colBP_CD.VisibleIndex = 12;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 13;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 14;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 15;
            // 
            // colWH_CD
            // 
            this.colWH_CD.FieldName = "WH_CD";
            this.colWH_CD.Name = "colWH_CD";
            this.colWH_CD.Visible = true;
            this.colWH_CD.VisibleIndex = 16;
            // 
            // colLOC_CD
            // 
            this.colLOC_CD.FieldName = "LOC_CD";
            this.colLOC_CD.Name = "colLOC_CD";
            this.colLOC_CD.Visible = true;
            this.colLOC_CD.VisibleIndex = 17;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 18;
            // 
            // colBARCODE_TEXT
            // 
            this.colBARCODE_TEXT.FieldName = "BARCODE_TEXT";
            this.colBARCODE_TEXT.Name = "colBARCODE_TEXT";
            this.colBARCODE_TEXT.Visible = true;
            this.colBARCODE_TEXT.VisibleIndex = 19;
            // 
            // colHU_QTY
            // 
            this.colHU_QTY.FieldName = "HU_QTY";
            this.colHU_QTY.Name = "colHU_QTY";
            this.colHU_QTY.Visible = true;
            this.colHU_QTY.VisibleIndex = 20;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 21;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 22;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 23;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 24;
            // 
            // DlvOrderHistHuDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "DlvOrderHistHuDetailList";
            this.Text = "DlvOrderHistHuDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrderHistHuDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dlvOrderHistHuDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDOH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDOD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDRH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDRD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDOH_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colORDER_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSTOM_PO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_DOH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colVEHICLE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPICKING_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_TEXT;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
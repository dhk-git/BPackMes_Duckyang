namespace BPack.Carrying.App.MM.HumEmptyLabel
{
    partial class PrintedBarcodeList
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
            this.barcodeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBARCODE_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_KIND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_FULL_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_INIT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_STOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_HU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDED_HU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDED_BARCODE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_BLOCKED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLOCK_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLOCK_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_LENGTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRINT_COUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANG_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.barcodeModelBindingSource;
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
            // barcodeModelBindingSource
            // 
            this.barcodeModelBindingSource.DataSource = typeof(BPack.Model.App.MM.HumEmptyLabel.BarcodeModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBARCODE_NO_KEY,
            this.colBARCODE_KIND,
            this.colBARCODE_FULL_NO,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colHU_INIT_QTY,
            this.colHU_STOCK_QTY,
            this.colHU_NO,
            this.colPARENT_HU_NO,
            this.colADDED_HU_NO,
            this.colADDED_BARCODE_NO,
            this.colIS_BLOCKED,
            this.colBLOCK_DTTM,
            this.colBLOCK_DESC,
            this.colBARCODE_LENGTH,
            this.colREF_NO,
            this.colPRINT_COUNT,
            this.colBARCODE_NO,
            this.colVALID,
            this.colREMARK,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colCREATE_DTTM,
            this.colCREATE_USER_ID,
            this.colMODIFY_DTTM,
            this.colMODIFY_USER_ID,
            this.colLANG_CODE,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colBARCODE_NO_KEY
            // 
            this.colBARCODE_NO_KEY.FieldName = "BARCODE_NO_KEY";
            this.colBARCODE_NO_KEY.Name = "colBARCODE_NO_KEY";
            this.colBARCODE_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colBARCODE_NO_KEY.Visible = true;
            this.colBARCODE_NO_KEY.VisibleIndex = 1;
            // 
            // colBARCODE_KIND
            // 
            this.colBARCODE_KIND.FieldName = "BARCODE_KIND";
            this.colBARCODE_KIND.Name = "colBARCODE_KIND";
            this.colBARCODE_KIND.Visible = true;
            this.colBARCODE_KIND.VisibleIndex = 2;
            // 
            // colBARCODE_FULL_NO
            // 
            this.colBARCODE_FULL_NO.FieldName = "BARCODE_FULL_NO";
            this.colBARCODE_FULL_NO.Name = "colBARCODE_FULL_NO";
            this.colBARCODE_FULL_NO.Visible = true;
            this.colBARCODE_FULL_NO.VisibleIndex = 3;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 4;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 5;
            // 
            // colHU_INIT_QTY
            // 
            this.colHU_INIT_QTY.FieldName = "HU_INIT_QTY";
            this.colHU_INIT_QTY.Name = "colHU_INIT_QTY";
            this.colHU_INIT_QTY.Visible = true;
            this.colHU_INIT_QTY.VisibleIndex = 6;
            // 
            // colHU_STOCK_QTY
            // 
            this.colHU_STOCK_QTY.FieldName = "HU_STOCK_QTY";
            this.colHU_STOCK_QTY.Name = "colHU_STOCK_QTY";
            this.colHU_STOCK_QTY.Visible = true;
            this.colHU_STOCK_QTY.VisibleIndex = 7;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 8;
            // 
            // colPARENT_HU_NO
            // 
            this.colPARENT_HU_NO.FieldName = "PARENT_HU_NO";
            this.colPARENT_HU_NO.Name = "colPARENT_HU_NO";
            this.colPARENT_HU_NO.Visible = true;
            this.colPARENT_HU_NO.VisibleIndex = 9;
            // 
            // colADDED_HU_NO
            // 
            this.colADDED_HU_NO.FieldName = "ADDED_HU_NO";
            this.colADDED_HU_NO.Name = "colADDED_HU_NO";
            this.colADDED_HU_NO.Visible = true;
            this.colADDED_HU_NO.VisibleIndex = 10;
            // 
            // colADDED_BARCODE_NO
            // 
            this.colADDED_BARCODE_NO.FieldName = "ADDED_BARCODE_NO";
            this.colADDED_BARCODE_NO.Name = "colADDED_BARCODE_NO";
            this.colADDED_BARCODE_NO.Visible = true;
            this.colADDED_BARCODE_NO.VisibleIndex = 11;
            // 
            // colIS_BLOCKED
            // 
            this.colIS_BLOCKED.FieldName = "IS_BLOCKED";
            this.colIS_BLOCKED.Name = "colIS_BLOCKED";
            this.colIS_BLOCKED.Visible = true;
            this.colIS_BLOCKED.VisibleIndex = 12;
            // 
            // colBLOCK_DTTM
            // 
            this.colBLOCK_DTTM.FieldName = "BLOCK_DTTM";
            this.colBLOCK_DTTM.Name = "colBLOCK_DTTM";
            this.colBLOCK_DTTM.Visible = true;
            this.colBLOCK_DTTM.VisibleIndex = 13;
            // 
            // colBLOCK_DESC
            // 
            this.colBLOCK_DESC.FieldName = "BLOCK_DESC";
            this.colBLOCK_DESC.Name = "colBLOCK_DESC";
            this.colBLOCK_DESC.Visible = true;
            this.colBLOCK_DESC.VisibleIndex = 14;
            // 
            // colBARCODE_LENGTH
            // 
            this.colBARCODE_LENGTH.FieldName = "BARCODE_LENGTH";
            this.colBARCODE_LENGTH.Name = "colBARCODE_LENGTH";
            this.colBARCODE_LENGTH.Visible = true;
            this.colBARCODE_LENGTH.VisibleIndex = 15;
            // 
            // colREF_NO
            // 
            this.colREF_NO.FieldName = "REF_NO";
            this.colREF_NO.Name = "colREF_NO";
            this.colREF_NO.Visible = true;
            this.colREF_NO.VisibleIndex = 16;
            // 
            // colPRINT_COUNT
            // 
            this.colPRINT_COUNT.FieldName = "PRINT_COUNT";
            this.colPRINT_COUNT.Name = "colPRINT_COUNT";
            this.colPRINT_COUNT.Visible = true;
            this.colPRINT_COUNT.VisibleIndex = 17;
            // 
            // colBARCODE_NO
            // 
            this.colBARCODE_NO.FieldName = "BARCODE_NO";
            this.colBARCODE_NO.Name = "colBARCODE_NO";
            this.colBARCODE_NO.Visible = true;
            this.colBARCODE_NO.VisibleIndex = 18;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 19;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 20;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 21;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 22;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 23;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 24;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 25;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 26;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 27;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 28;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 29;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 30;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 31;
            // 
            // PrintedBarcodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "PrintedBarcodeList";
            this.Text = "PrintedBarcodeList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource barcodeModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_KIND;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_FULL_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_INIT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_STOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_HU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colADDED_HU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colADDED_BARCODE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_BLOCKED;
        private DevExpress.XtraGrid.Columns.GridColumn colBLOCK_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colBLOCK_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_LENGTH;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPRINT_COUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colSORT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLANG_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
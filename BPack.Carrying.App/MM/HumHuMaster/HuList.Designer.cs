namespace BPack.Carrying.App.MM.HumHuMaster
{
    partial class HuList
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
            this.huModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHU_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_HU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDED_HU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINIT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOM_BARCODE_TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_DOC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_DOC_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_USE_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_STOCK_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_ADJUST_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLOCK_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLOCK_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLOCK_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLOCK_CANCEL_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.huModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.huModelBindingSource;
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
            // huModelBindingSource
            // 
            this.huModelBindingSource.DataSource = typeof(BPack.Model.App.MM.HumHuMaster.HuModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHU_NO_KEY,
            this.colHU_NO,
            this.colPARENT_HU_NO,
            this.colADDED_HU_NO,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colHU_TYPE,
            this.colINIT_QTY,
            this.colSTOCK_QTY,
            this.colWORK_DT,
            this.colLOT_NO,
            this.colBARCODE_TYPE,
            this.colBARCODE_TEXT,
            this.colCUSTOM_BARCODE_TEXT,
            this.colREF_DOC_TYPE,
            this.colREF_DOC_NO,
            this.colHU_USE_STATUS,
            this.colHU_STOCK_STATUS,
            this.colHU_ADJUST_STATUS,
            this.colBLOCK_YN,
            this.colBLOCK_DTTM,
            this.colBLOCK_DESC,
            this.colBLOCK_CANCEL_DTTM,
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
            // 
            // colHU_NO_KEY
            // 
            this.colHU_NO_KEY.FieldName = "HU_NO_KEY";
            this.colHU_NO_KEY.Name = "colHU_NO_KEY";
            this.colHU_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colHU_NO_KEY.Visible = true;
            this.colHU_NO_KEY.VisibleIndex = 0;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 1;
            // 
            // colPARENT_HU_NO
            // 
            this.colPARENT_HU_NO.FieldName = "PARENT_HU_NO";
            this.colPARENT_HU_NO.Name = "colPARENT_HU_NO";
            this.colPARENT_HU_NO.Visible = true;
            this.colPARENT_HU_NO.VisibleIndex = 2;
            // 
            // colADDED_HU_NO
            // 
            this.colADDED_HU_NO.FieldName = "ADDED_HU_NO";
            this.colADDED_HU_NO.Name = "colADDED_HU_NO";
            this.colADDED_HU_NO.Visible = true;
            this.colADDED_HU_NO.VisibleIndex = 3;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 4;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 5;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 6;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 7;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 8;
            // 
            // colHU_TYPE
            // 
            this.colHU_TYPE.FieldName = "HU_TYPE";
            this.colHU_TYPE.Name = "colHU_TYPE";
            this.colHU_TYPE.Visible = true;
            this.colHU_TYPE.VisibleIndex = 9;
            // 
            // colINIT_QTY
            // 
            this.colINIT_QTY.FieldName = "INIT_QTY";
            this.colINIT_QTY.Name = "colINIT_QTY";
            this.colINIT_QTY.Visible = true;
            this.colINIT_QTY.VisibleIndex = 10;
            // 
            // colSTOCK_QTY
            // 
            this.colSTOCK_QTY.FieldName = "STOCK_QTY";
            this.colSTOCK_QTY.Name = "colSTOCK_QTY";
            this.colSTOCK_QTY.Visible = true;
            this.colSTOCK_QTY.VisibleIndex = 11;
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
            // colBARCODE_TYPE
            // 
            this.colBARCODE_TYPE.FieldName = "BARCODE_TYPE";
            this.colBARCODE_TYPE.Name = "colBARCODE_TYPE";
            this.colBARCODE_TYPE.Visible = true;
            this.colBARCODE_TYPE.VisibleIndex = 14;
            // 
            // colBARCODE_TEXT
            // 
            this.colBARCODE_TEXT.FieldName = "BARCODE_TEXT";
            this.colBARCODE_TEXT.Name = "colBARCODE_TEXT";
            this.colBARCODE_TEXT.Visible = true;
            this.colBARCODE_TEXT.VisibleIndex = 15;
            // 
            // colCUSTOM_BARCODE_TEXT
            // 
            this.colCUSTOM_BARCODE_TEXT.FieldName = "CUSTOM_BARCODE_TEXT";
            this.colCUSTOM_BARCODE_TEXT.Name = "colCUSTOM_BARCODE_TEXT";
            this.colCUSTOM_BARCODE_TEXT.Visible = true;
            this.colCUSTOM_BARCODE_TEXT.VisibleIndex = 16;
            // 
            // colREF_DOC_TYPE
            // 
            this.colREF_DOC_TYPE.FieldName = "REF_DOC_TYPE";
            this.colREF_DOC_TYPE.Name = "colREF_DOC_TYPE";
            this.colREF_DOC_TYPE.Visible = true;
            this.colREF_DOC_TYPE.VisibleIndex = 17;
            // 
            // colREF_DOC_NO
            // 
            this.colREF_DOC_NO.FieldName = "REF_DOC_NO";
            this.colREF_DOC_NO.Name = "colREF_DOC_NO";
            this.colREF_DOC_NO.Visible = true;
            this.colREF_DOC_NO.VisibleIndex = 18;
            // 
            // colHU_USE_STATUS
            // 
            this.colHU_USE_STATUS.FieldName = "HU_USE_STATUS";
            this.colHU_USE_STATUS.Name = "colHU_USE_STATUS";
            this.colHU_USE_STATUS.Visible = true;
            this.colHU_USE_STATUS.VisibleIndex = 19;
            // 
            // colHU_STOCK_STATUS
            // 
            this.colHU_STOCK_STATUS.FieldName = "HU_STOCK_STATUS";
            this.colHU_STOCK_STATUS.Name = "colHU_STOCK_STATUS";
            this.colHU_STOCK_STATUS.Visible = true;
            this.colHU_STOCK_STATUS.VisibleIndex = 20;
            // 
            // colHU_ADJUST_STATUS
            // 
            this.colHU_ADJUST_STATUS.FieldName = "HU_ADJUST_STATUS";
            this.colHU_ADJUST_STATUS.Name = "colHU_ADJUST_STATUS";
            this.colHU_ADJUST_STATUS.Visible = true;
            this.colHU_ADJUST_STATUS.VisibleIndex = 21;
            // 
            // colBLOCK_YN
            // 
            this.colBLOCK_YN.FieldName = "BLOCK_YN";
            this.colBLOCK_YN.Name = "colBLOCK_YN";
            this.colBLOCK_YN.Visible = true;
            this.colBLOCK_YN.VisibleIndex = 22;
            // 
            // colBLOCK_DTTM
            // 
            this.colBLOCK_DTTM.FieldName = "BLOCK_DTTM";
            this.colBLOCK_DTTM.Name = "colBLOCK_DTTM";
            this.colBLOCK_DTTM.Visible = true;
            this.colBLOCK_DTTM.VisibleIndex = 23;
            // 
            // colBLOCK_DESC
            // 
            this.colBLOCK_DESC.FieldName = "BLOCK_DESC";
            this.colBLOCK_DESC.Name = "colBLOCK_DESC";
            this.colBLOCK_DESC.Visible = true;
            this.colBLOCK_DESC.VisibleIndex = 24;
            // 
            // colBLOCK_CANCEL_DTTM
            // 
            this.colBLOCK_CANCEL_DTTM.FieldName = "BLOCK_CANCEL_DTTM";
            this.colBLOCK_CANCEL_DTTM.Name = "colBLOCK_CANCEL_DTTM";
            this.colBLOCK_CANCEL_DTTM.Visible = true;
            this.colBLOCK_CANCEL_DTTM.VisibleIndex = 25;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 26;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 27;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 28;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 29;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 30;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 31;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 32;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 33;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 34;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 35;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 36;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 37;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 38;
            // 
            // HuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "HuList";
            this.Text = "HuList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource huModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_HU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colADDED_HU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colINIT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colLOT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_TEXT;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSTOM_BARCODE_TEXT;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_DOC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_DOC_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_USE_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_STOCK_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_ADJUST_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colBLOCK_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colBLOCK_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colBLOCK_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colBLOCK_CANCEL_DTTM;
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
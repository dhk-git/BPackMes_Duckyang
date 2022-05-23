namespace BPack.Carrying.App.MM.MovDoc
{
    partial class MovDocList
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
            this.strapGridControl1 = new BPack.Strap.Grid.StrapGridControl();
            this.movDocbindingSource = new System.Windows.Forms.BindingSource();
            this.gridview1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMOV_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOV_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFROM_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFROM_LOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTO_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTO_LOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOV_TYPE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOV_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUBLISH_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLOSE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFROM_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTO_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.movDocbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.movDocbindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridview1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridview1});
            // 
            // movDocbindingSource
            // 
            this.movDocbindingSource.DataSource = typeof(BPack.Model.App.MM.MovDoc.MovDocModel);
            // 
            // gridview1
            // 
            this.gridview1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMOV_NO_KEY,
            this.colMOV_NO,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colFROM_WH_CD,
            this.colFROM_LOC_CD,
            this.colTO_WH_CD,
            this.colTO_LOC_CD,
            this.colMOV_TYPE_CD,
            this.colMOV_STATUS,
            this.colPUBLISH_DTTM,
            this.colCLOSE_DTTM,
            this.colFROM_USER_ID,
            this.colTO_USER_ID,
            this.colDEL_FG,
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
            this.gridview1.GridControl = this.strapGridControl1;
            this.gridview1.Name = "gridview1";
            // 
            // colMOV_NO_KEY
            // 
            this.colMOV_NO_KEY.FieldName = "MOV_NO_KEY";
            this.colMOV_NO_KEY.Name = "colMOV_NO_KEY";
            this.colMOV_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colMOV_NO_KEY.Visible = true;
            this.colMOV_NO_KEY.VisibleIndex = 0;
            // 
            // colMOV_NO
            // 
            this.colMOV_NO.FieldName = "MOV_NO";
            this.colMOV_NO.Name = "colMOV_NO";
            this.colMOV_NO.Visible = true;
            this.colMOV_NO.VisibleIndex = 1;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 2;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 3;
            // 
            // colFROM_WH_CD
            // 
            this.colFROM_WH_CD.FieldName = "FROM_WH_CD";
            this.colFROM_WH_CD.Name = "colFROM_WH_CD";
            this.colFROM_WH_CD.Visible = true;
            this.colFROM_WH_CD.VisibleIndex = 4;
            // 
            // colFROM_LOC_CD
            // 
            this.colFROM_LOC_CD.FieldName = "FROM_LOC_CD";
            this.colFROM_LOC_CD.Name = "colFROM_LOC_CD";
            this.colFROM_LOC_CD.Visible = true;
            this.colFROM_LOC_CD.VisibleIndex = 5;
            // 
            // colTO_WH_CD
            // 
            this.colTO_WH_CD.FieldName = "TO_WH_CD";
            this.colTO_WH_CD.Name = "colTO_WH_CD";
            this.colTO_WH_CD.Visible = true;
            this.colTO_WH_CD.VisibleIndex = 6;
            // 
            // colTO_LOC_CD
            // 
            this.colTO_LOC_CD.FieldName = "TO_LOC_CD";
            this.colTO_LOC_CD.Name = "colTO_LOC_CD";
            this.colTO_LOC_CD.Visible = true;
            this.colTO_LOC_CD.VisibleIndex = 7;
            // 
            // colMOV_TYPE_CD
            // 
            this.colMOV_TYPE_CD.FieldName = "MOV_TYPE_CD";
            this.colMOV_TYPE_CD.Name = "colMOV_TYPE_CD";
            this.colMOV_TYPE_CD.Visible = true;
            this.colMOV_TYPE_CD.VisibleIndex = 8;
            // 
            // colMOV_STATUS
            // 
            this.colMOV_STATUS.FieldName = "MOV_STATUS";
            this.colMOV_STATUS.Name = "colMOV_STATUS";
            this.colMOV_STATUS.Visible = true;
            this.colMOV_STATUS.VisibleIndex = 9;
            // 
            // colPUBLISH_DTTM
            // 
            this.colPUBLISH_DTTM.FieldName = "PUBLISH_DTTM";
            this.colPUBLISH_DTTM.Name = "colPUBLISH_DTTM";
            this.colPUBLISH_DTTM.Visible = true;
            this.colPUBLISH_DTTM.VisibleIndex = 10;
            // 
            // colCLOSE_DTTM
            // 
            this.colCLOSE_DTTM.FieldName = "CLOSE_DTTM";
            this.colCLOSE_DTTM.Name = "colCLOSE_DTTM";
            this.colCLOSE_DTTM.Visible = true;
            this.colCLOSE_DTTM.VisibleIndex = 11;
            // 
            // colFROM_USER_ID
            // 
            this.colFROM_USER_ID.FieldName = "FROM_USER_ID";
            this.colFROM_USER_ID.Name = "colFROM_USER_ID";
            this.colFROM_USER_ID.Visible = true;
            this.colFROM_USER_ID.VisibleIndex = 12;
            // 
            // colTO_USER_ID
            // 
            this.colTO_USER_ID.FieldName = "TO_USER_ID";
            this.colTO_USER_ID.Name = "colTO_USER_ID";
            this.colTO_USER_ID.Visible = true;
            this.colTO_USER_ID.VisibleIndex = 13;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 14;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 15;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 16;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 17;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 18;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 19;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 20;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 21;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 22;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 23;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 24;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 25;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 26;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 27;
            // 
            // MovDocList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "MovDocList";
            this.Text = "MovDocList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movDocbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridview1;
        private System.Windows.Forms.BindingSource movDocbindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMOV_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colMOV_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colFROM_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colFROM_LOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colTO_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colTO_LOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMOV_TYPE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMOV_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colPUBLISH_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCLOSE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colFROM_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTO_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_FG;
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
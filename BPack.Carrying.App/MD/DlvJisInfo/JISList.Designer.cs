namespace BPack.Carrying.App.MD.DlvJisInfo
{
    partial class CarTypeList
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
            this.dlvJisInfoJISModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_PLC_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_PLC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_DV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_TYPE_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAD_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRINT_COL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRINT_WAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEVICE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANG_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvJisInfoJISModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.dlvJisInfoJISModelBindingSource;
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
            // dlvJisInfoJISModelBindingSource
            // 
            this.dlvJisInfoJISModelBindingSource.DataSource = typeof(BPack.Model.App.MD.DlvJisInfo.DlvJisInfoJISModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colPLANT_CD_KEY,
            this.colDLV_PLC_CD_KEY,
            this.colALC_NO_KEY,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colDLV_PLC_CD,
            this.colALC_NO,
            this.colALC_DV,
            this.colALC_TYPE,
            this.colALC_TYPE_NM,
            this.colLOAD_QTY,
            this.colPRINT_COL,
            this.colPRINT_WAY,
            this.colDEVICE_ID,
            this.colREMARK,
            this.colMODIFY_DTTM,
            this.colMODIFY_USER_ID,
            this.colVALID,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colCREATE_DTTM,
            this.colCREATE_USER_ID,
            this.colLANG_CODE,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD_KEY.Visible = true;
            this.colCOMP_CD_KEY.VisibleIndex = 0;
            // 
            // colPLANT_CD_KEY
            // 
            this.colPLANT_CD_KEY.FieldName = "PLANT_CD_KEY";
            this.colPLANT_CD_KEY.Name = "colPLANT_CD_KEY";
            this.colPLANT_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colPLANT_CD_KEY.Visible = true;
            this.colPLANT_CD_KEY.VisibleIndex = 1;
            // 
            // colDLV_PLC_CD_KEY
            // 
            this.colDLV_PLC_CD_KEY.FieldName = "DLV_PLC_CD_KEY";
            this.colDLV_PLC_CD_KEY.Name = "colDLV_PLC_CD_KEY";
            this.colDLV_PLC_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colDLV_PLC_CD_KEY.Visible = true;
            this.colDLV_PLC_CD_KEY.VisibleIndex = 2;
            // 
            // colALC_NO_KEY
            // 
            this.colALC_NO_KEY.FieldName = "ALC_NO_KEY";
            this.colALC_NO_KEY.Name = "colALC_NO_KEY";
            this.colALC_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colALC_NO_KEY.Visible = true;
            this.colALC_NO_KEY.VisibleIndex = 3;
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
            // colDLV_PLC_CD
            // 
            this.colDLV_PLC_CD.FieldName = "DLV_PLC_CD";
            this.colDLV_PLC_CD.Name = "colDLV_PLC_CD";
            this.colDLV_PLC_CD.Visible = true;
            this.colDLV_PLC_CD.VisibleIndex = 6;
            // 
            // colALC_NO
            // 
            this.colALC_NO.FieldName = "ALC_NO";
            this.colALC_NO.Name = "colALC_NO";
            this.colALC_NO.Visible = true;
            this.colALC_NO.VisibleIndex = 7;
            // 
            // colALC_DV
            // 
            this.colALC_DV.FieldName = "ALC_DV";
            this.colALC_DV.Name = "colALC_DV";
            this.colALC_DV.Visible = true;
            this.colALC_DV.VisibleIndex = 8;
            // 
            // colALC_TYPE
            // 
            this.colALC_TYPE.FieldName = "ALC_TYPE";
            this.colALC_TYPE.Name = "colALC_TYPE";
            this.colALC_TYPE.Visible = true;
            this.colALC_TYPE.VisibleIndex = 9;
            // 
            // colALC_TYPE_NM
            // 
            this.colALC_TYPE_NM.FieldName = "ALC_TYPE_NM";
            this.colALC_TYPE_NM.Name = "colALC_TYPE_NM";
            this.colALC_TYPE_NM.Visible = true;
            this.colALC_TYPE_NM.VisibleIndex = 10;
            // 
            // colLOAD_QTY
            // 
            this.colLOAD_QTY.FieldName = "LOAD_QTY";
            this.colLOAD_QTY.Name = "colLOAD_QTY";
            this.colLOAD_QTY.Visible = true;
            this.colLOAD_QTY.VisibleIndex = 11;
            // 
            // colPRINT_COL
            // 
            this.colPRINT_COL.FieldName = "PRINT_COL";
            this.colPRINT_COL.Name = "colPRINT_COL";
            this.colPRINT_COL.Visible = true;
            this.colPRINT_COL.VisibleIndex = 12;
            // 
            // colPRINT_WAY
            // 
            this.colPRINT_WAY.FieldName = "PRINT_WAY";
            this.colPRINT_WAY.Name = "colPRINT_WAY";
            this.colPRINT_WAY.Visible = true;
            this.colPRINT_WAY.VisibleIndex = 13;
            // 
            // colDEVICE_ID
            // 
            this.colDEVICE_ID.FieldName = "DEVICE_ID";
            this.colDEVICE_ID.Name = "colDEVICE_ID";
            this.colDEVICE_ID.Visible = true;
            this.colDEVICE_ID.VisibleIndex = 14;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 15;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 16;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 17;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 18;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 19;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 20;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 21;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 22;
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
            // CarTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "CarTypeList";
            this.Text = "JISList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvJisInfoJISModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dlvJisInfoJISModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_PLC_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_PLC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_DV;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_TYPE_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAD_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colPRINT_COL;
        private DevExpress.XtraGrid.Columns.GridColumn colPRINT_WAY;
        private DevExpress.XtraGrid.Columns.GridColumn colDEVICE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID;
        private DevExpress.XtraGrid.Columns.GridColumn colSORT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLANG_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
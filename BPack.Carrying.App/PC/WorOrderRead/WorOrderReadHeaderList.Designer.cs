namespace BPack.Carrying.App.PC.WorOrderRead
{
    partial class WorOrderReadHeaderList
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
            this.worOrderReadHeaderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWO_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROUTE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOM_WO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLOSE_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_WC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWOR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colE_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPH_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.worOrderReadHeaderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.worOrderReadHeaderModelBindingSource;
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
            // worOrderReadHeaderModelBindingSource
            // 
            this.worOrderReadHeaderModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WorOrderRead.WorOrderReadHeaderModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWO_NO_KEY,
            this.colROUTE_NO,
            this.colCUSTOM_WO_NO,
            this.colWO_NO,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWO_DT,
            this.colCLOSE_DT,
            this.colSHIFT_CD,
            this.colPARENT_WC_CD,
            this.colWC_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colALC_CD,
            this.colWOR_QTY,
            this.colA_TIME_QTY,
            this.colB_TIME_QTY,
            this.colC_TIME_QTY,
            this.colD_TIME_QTY,
            this.colE_TIME_QTY,
            this.colWO_STATUS,
            this.colUPH_QTY,
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
            // colWO_NO_KEY
            // 
            this.colWO_NO_KEY.FieldName = "WO_NO_KEY";
            this.colWO_NO_KEY.Name = "colWO_NO_KEY";
            this.colWO_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colWO_NO_KEY.Visible = true;
            this.colWO_NO_KEY.VisibleIndex = 0;
            // 
            // colROUTE_NO
            // 
            this.colROUTE_NO.FieldName = "ROUTE_NO";
            this.colROUTE_NO.Name = "colROUTE_NO";
            this.colROUTE_NO.Visible = true;
            this.colROUTE_NO.VisibleIndex = 1;
            // 
            // colCUSTOM_WO_NO
            // 
            this.colCUSTOM_WO_NO.FieldName = "CUSTOM_WO_NO";
            this.colCUSTOM_WO_NO.Name = "colCUSTOM_WO_NO";
            this.colCUSTOM_WO_NO.Visible = true;
            this.colCUSTOM_WO_NO.VisibleIndex = 2;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 3;
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
            // colWO_DT
            // 
            this.colWO_DT.FieldName = "WO_DT";
            this.colWO_DT.Name = "colWO_DT";
            this.colWO_DT.Visible = true;
            this.colWO_DT.VisibleIndex = 6;
            // 
            // colCLOSE_DT
            // 
            this.colCLOSE_DT.FieldName = "CLOSE_DT";
            this.colCLOSE_DT.Name = "colCLOSE_DT";
            this.colCLOSE_DT.Visible = true;
            this.colCLOSE_DT.VisibleIndex = 7;
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            this.colSHIFT_CD.Visible = true;
            this.colSHIFT_CD.VisibleIndex = 8;
            // 
            // colPARENT_WC_CD
            // 
            this.colPARENT_WC_CD.FieldName = "PARENT_WC_CD";
            this.colPARENT_WC_CD.Name = "colPARENT_WC_CD";
            this.colPARENT_WC_CD.Visible = true;
            this.colPARENT_WC_CD.VisibleIndex = 9;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 10;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 11;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 12;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 13;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 14;
            // 
            // colWOR_QTY
            // 
            this.colWOR_QTY.FieldName = "WOR_QTY";
            this.colWOR_QTY.Name = "colWOR_QTY";
            this.colWOR_QTY.Visible = true;
            this.colWOR_QTY.VisibleIndex = 15;
            // 
            // colA_TIME_QTY
            // 
            this.colA_TIME_QTY.FieldName = "A_TIME_QTY";
            this.colA_TIME_QTY.Name = "colA_TIME_QTY";
            this.colA_TIME_QTY.Visible = true;
            this.colA_TIME_QTY.VisibleIndex = 16;
            // 
            // colB_TIME_QTY
            // 
            this.colB_TIME_QTY.FieldName = "B_TIME_QTY";
            this.colB_TIME_QTY.Name = "colB_TIME_QTY";
            this.colB_TIME_QTY.Visible = true;
            this.colB_TIME_QTY.VisibleIndex = 17;
            // 
            // colC_TIME_QTY
            // 
            this.colC_TIME_QTY.FieldName = "C_TIME_QTY";
            this.colC_TIME_QTY.Name = "colC_TIME_QTY";
            this.colC_TIME_QTY.Visible = true;
            this.colC_TIME_QTY.VisibleIndex = 18;
            // 
            // colD_TIME_QTY
            // 
            this.colD_TIME_QTY.FieldName = "D_TIME_QTY";
            this.colD_TIME_QTY.Name = "colD_TIME_QTY";
            this.colD_TIME_QTY.Visible = true;
            this.colD_TIME_QTY.VisibleIndex = 19;
            // 
            // colE_TIME_QTY
            // 
            this.colE_TIME_QTY.FieldName = "E_TIME_QTY";
            this.colE_TIME_QTY.Name = "colE_TIME_QTY";
            this.colE_TIME_QTY.Visible = true;
            this.colE_TIME_QTY.VisibleIndex = 20;
            // 
            // colWO_STATUS
            // 
            this.colWO_STATUS.FieldName = "WO_STATUS";
            this.colWO_STATUS.Name = "colWO_STATUS";
            this.colWO_STATUS.Visible = true;
            this.colWO_STATUS.VisibleIndex = 21;
            // 
            // colUPH_QTY
            // 
            this.colUPH_QTY.FieldName = "UPH_QTY";
            this.colUPH_QTY.Name = "colUPH_QTY";
            this.colUPH_QTY.Visible = true;
            this.colUPH_QTY.VisibleIndex = 22;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 23;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 24;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 25;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 26;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 27;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 28;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 29;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 30;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 31;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 32;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 33;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 34;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 35;
            // 
            // WorOrderReadHeaderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WorOrderReadHeaderList";
            this.Text = "WorkOrderHeaderList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worOrderReadHeaderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource worOrderReadHeaderModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSTOM_WO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCLOSE_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_WC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWOR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colA_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colB_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colD_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colE_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colUPH_QTY;
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
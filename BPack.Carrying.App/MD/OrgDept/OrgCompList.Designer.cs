namespace BPack.Carrying.App.MD.OrgDept
{
    partial class OrgCompList
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
            this.compModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREG_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_FROM_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_TO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.compModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // compModelBindingSource
            // 
            this.compModelBindingSource.DataSource = typeof(BPack.Model.App.MD.OrgDept.CompModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colCOMP_CD,
            this.colCOMP_NM,
            this.colREG_NO,
            this.colDUNS,
            this.colADDR,
            this.colVALID_FROM_DT,
            this.colVALID_TO_DT,
            this.colDEL_FG,
            this.colREMARK,
            this.colMODIFY_DTTM,
            this.colMODIFY_USER_ID,
            this.colVALID,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colCREATE_DTTM,
            this.colCREATE_USER_ID,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck});
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
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 1;
            // 
            // colCOMP_NM
            // 
            this.colCOMP_NM.FieldName = "COMP_NM";
            this.colCOMP_NM.Name = "colCOMP_NM";
            this.colCOMP_NM.Visible = true;
            this.colCOMP_NM.VisibleIndex = 2;
            // 
            // colREG_NO
            // 
            this.colREG_NO.FieldName = "REG_NO";
            this.colREG_NO.Name = "colREG_NO";
            this.colREG_NO.Visible = true;
            this.colREG_NO.VisibleIndex = 3;
            // 
            // colDUNS
            // 
            this.colDUNS.FieldName = "DUNS";
            this.colDUNS.Name = "colDUNS";
            this.colDUNS.Visible = true;
            this.colDUNS.VisibleIndex = 4;
            // 
            // colADDR
            // 
            this.colADDR.FieldName = "ADDR";
            this.colADDR.Name = "colADDR";
            this.colADDR.Visible = true;
            this.colADDR.VisibleIndex = 5;
            // 
            // colVALID_FROM_DT
            // 
            this.colVALID_FROM_DT.FieldName = "VALID_FROM_DT";
            this.colVALID_FROM_DT.Name = "colVALID_FROM_DT";
            this.colVALID_FROM_DT.Visible = true;
            this.colVALID_FROM_DT.VisibleIndex = 6;
            // 
            // colVALID_TO_DT
            // 
            this.colVALID_TO_DT.FieldName = "VALID_TO_DT";
            this.colVALID_TO_DT.Name = "colVALID_TO_DT";
            this.colVALID_TO_DT.Visible = true;
            this.colVALID_TO_DT.VisibleIndex = 7;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 8;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 9;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 10;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 11;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 12;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 13;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 14;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 15;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 16;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 17;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 18;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 19;
            // 
            // OrgCompList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "OrgCompList";
            this.Text = "OrgCompList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource compModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colREG_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDUNS;
        private DevExpress.XtraGrid.Columns.GridColumn colADDR;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_FROM_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_TO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID;
        private DevExpress.XtraGrid.Columns.GridColumn colSORT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
    }
}
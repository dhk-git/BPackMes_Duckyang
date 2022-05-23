namespace BPack.Carrying.App.CT.ProjectManager
{
    partial class ProjectActivity
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
            this.projectActivityModelBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPJA_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJA_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMEMB_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACT_HOUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_ACT_CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectActivityModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.projectActivityModelBindingSource;
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
            // projectActivityModelBindingSource
            // 
            this.projectActivityModelBindingSource.DataSource = typeof(BPack.Model.App.CT.ProjectManager.ProjectActivityModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPJA_NO_KEY,
            this.colPJA_NO,
            this.colPJD_NO,
            this.colMEMB_NM,
            this.colSTART_DTTM,
            this.colEND_DTTM,
            this.colACT_HOUR,
            this.colPJT_ACT_CLS,
            this.colACT_DESC,
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
            this.colSelectedCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPJA_NO_KEY
            // 
            this.colPJA_NO_KEY.FieldName = "PJA_NO_KEY";
            this.colPJA_NO_KEY.Name = "colPJA_NO_KEY";
            this.colPJA_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colPJA_NO_KEY.Visible = true;
            this.colPJA_NO_KEY.VisibleIndex = 0;
            // 
            // colPJA_NO
            // 
            this.colPJA_NO.FieldName = "PJA_NO";
            this.colPJA_NO.Name = "colPJA_NO";
            this.colPJA_NO.Visible = true;
            this.colPJA_NO.VisibleIndex = 1;
            // 
            // colPJD_NO
            // 
            this.colPJD_NO.FieldName = "PJD_NO";
            this.colPJD_NO.Name = "colPJD_NO";
            this.colPJD_NO.Visible = true;
            this.colPJD_NO.VisibleIndex = 2;
            // 
            // colMEMB_NM
            // 
            this.colMEMB_NM.FieldName = "MEMB_NM";
            this.colMEMB_NM.Name = "colMEMB_NM";
            this.colMEMB_NM.Visible = true;
            this.colMEMB_NM.VisibleIndex = 3;
            // 
            // colSTART_DTTM
            // 
            this.colSTART_DTTM.FieldName = "START_DTTM";
            this.colSTART_DTTM.Name = "colSTART_DTTM";
            this.colSTART_DTTM.Visible = true;
            this.colSTART_DTTM.VisibleIndex = 4;
            // 
            // colEND_DTTM
            // 
            this.colEND_DTTM.FieldName = "END_DTTM";
            this.colEND_DTTM.Name = "colEND_DTTM";
            this.colEND_DTTM.Visible = true;
            this.colEND_DTTM.VisibleIndex = 5;
            // 
            // colACT_HOUR
            // 
            this.colACT_HOUR.FieldName = "ACT_HOUR";
            this.colACT_HOUR.Name = "colACT_HOUR";
            this.colACT_HOUR.Visible = true;
            this.colACT_HOUR.VisibleIndex = 6;
            // 
            // colPJT_ACT_CLS
            // 
            this.colPJT_ACT_CLS.FieldName = "PJT_ACT_CLS";
            this.colPJT_ACT_CLS.Name = "colPJT_ACT_CLS";
            this.colPJT_ACT_CLS.Visible = true;
            this.colPJT_ACT_CLS.VisibleIndex = 7;
            // 
            // colACT_DESC
            // 
            this.colACT_DESC.FieldName = "ACT_DESC";
            this.colACT_DESC.Name = "colACT_DESC";
            this.colACT_DESC.Visible = true;
            this.colACT_DESC.VisibleIndex = 8;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 9;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 10;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 11;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 12;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 13;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 14;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 15;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 16;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 17;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 18;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 19;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 20;
            // 
            // ProjectActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ProjectActivity";
            this.Text = "ProjectActivity";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectActivityModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource projectActivityModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPJA_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPJA_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPJD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMEMB_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colACT_HOUR;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_ACT_CLS;
        private DevExpress.XtraGrid.Columns.GridColumn colACT_DESC;
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
    }
}
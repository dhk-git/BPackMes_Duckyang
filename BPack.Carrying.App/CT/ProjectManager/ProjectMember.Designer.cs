namespace BPack.Carrying.App.CT.ProjectManager
{
    partial class ProjectMember
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.projectMemberModelBindingSource = new System.Windows.Forms.BindingSource();
            this.colPJT_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMEMB_SEQ_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMEMB_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_MEMB_ROLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMEMB_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAN_START_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAN_END_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACT_START_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACT_END_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_MEMB_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMemberModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.projectMemberModelBindingSource;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPJT_NO_KEY,
            this.colMEMB_SEQ_KEY,
            this.colPJT_NO,
            this.colMEMB_SEQ,
            this.colPJT_MEMB_ROLE,
            this.colMEMB_NM,
            this.colPLAN_START_DT,
            this.colPLAN_END_DT,
            this.colACT_START_DT,
            this.colACT_END_DT,
            this.colPJT_MEMB_STATUS,
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
            // projectMemberModelBindingSource
            // 
            this.projectMemberModelBindingSource.DataSource = typeof(BPack.Model.App.CT.ProjectManager.ProjectMemberModel);
            // 
            // colPJT_NO_KEY
            // 
            this.colPJT_NO_KEY.FieldName = "PJT_NO_KEY";
            this.colPJT_NO_KEY.Name = "colPJT_NO_KEY";
            this.colPJT_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colPJT_NO_KEY.Visible = true;
            this.colPJT_NO_KEY.VisibleIndex = 0;
            // 
            // colMEMB_SEQ_KEY
            // 
            this.colMEMB_SEQ_KEY.FieldName = "MEMB_SEQ_KEY";
            this.colMEMB_SEQ_KEY.Name = "colMEMB_SEQ_KEY";
            this.colMEMB_SEQ_KEY.OptionsColumn.ReadOnly = true;
            this.colMEMB_SEQ_KEY.Visible = true;
            this.colMEMB_SEQ_KEY.VisibleIndex = 1;
            // 
            // colPJT_NO
            // 
            this.colPJT_NO.FieldName = "PJT_NO";
            this.colPJT_NO.Name = "colPJT_NO";
            this.colPJT_NO.Visible = true;
            this.colPJT_NO.VisibleIndex = 2;
            // 
            // colMEMB_SEQ
            // 
            this.colMEMB_SEQ.FieldName = "MEMB_SEQ";
            this.colMEMB_SEQ.Name = "colMEMB_SEQ";
            this.colMEMB_SEQ.Visible = true;
            this.colMEMB_SEQ.VisibleIndex = 3;
            // 
            // colPJT_MEMB_ROLE
            // 
            this.colPJT_MEMB_ROLE.FieldName = "PJT_MEMB_ROLE";
            this.colPJT_MEMB_ROLE.Name = "colPJT_MEMB_ROLE";
            this.colPJT_MEMB_ROLE.Visible = true;
            this.colPJT_MEMB_ROLE.VisibleIndex = 4;
            // 
            // colMEMB_NM
            // 
            this.colMEMB_NM.FieldName = "MEMB_NM";
            this.colMEMB_NM.Name = "colMEMB_NM";
            this.colMEMB_NM.Visible = true;
            this.colMEMB_NM.VisibleIndex = 5;
            // 
            // colPLAN_START_DT
            // 
            this.colPLAN_START_DT.FieldName = "PLAN_START_DT";
            this.colPLAN_START_DT.Name = "colPLAN_START_DT";
            this.colPLAN_START_DT.Visible = true;
            this.colPLAN_START_DT.VisibleIndex = 6;
            // 
            // colPLAN_END_DT
            // 
            this.colPLAN_END_DT.FieldName = "PLAN_END_DT";
            this.colPLAN_END_DT.Name = "colPLAN_END_DT";
            this.colPLAN_END_DT.Visible = true;
            this.colPLAN_END_DT.VisibleIndex = 7;
            // 
            // colACT_START_DT
            // 
            this.colACT_START_DT.FieldName = "ACT_START_DT";
            this.colACT_START_DT.Name = "colACT_START_DT";
            this.colACT_START_DT.Visible = true;
            this.colACT_START_DT.VisibleIndex = 8;
            // 
            // colACT_END_DT
            // 
            this.colACT_END_DT.FieldName = "ACT_END_DT";
            this.colACT_END_DT.Name = "colACT_END_DT";
            this.colACT_END_DT.Visible = true;
            this.colACT_END_DT.VisibleIndex = 9;
            // 
            // colPJT_MEMB_STATUS
            // 
            this.colPJT_MEMB_STATUS.FieldName = "PJT_MEMB_STATUS";
            this.colPJT_MEMB_STATUS.Name = "colPJT_MEMB_STATUS";
            this.colPJT_MEMB_STATUS.Visible = true;
            this.colPJT_MEMB_STATUS.VisibleIndex = 10;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 11;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 12;
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
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 17;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 18;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 19;
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
            // ProjectMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ProjectMember";
            this.Text = "ProjectMember";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMemberModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource projectMemberModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colMEMB_SEQ_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMEMB_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_MEMB_ROLE;
        private DevExpress.XtraGrid.Columns.GridColumn colMEMB_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAN_START_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAN_END_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colACT_START_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colACT_END_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_MEMB_STATUS;
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
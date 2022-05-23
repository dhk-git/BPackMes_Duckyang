namespace BPack.Carrying.App.CT.ProjectManager
{
    partial class ProjectDetail
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
            this.projectDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strapTreeList1 = new BPack.Strap.TreeList.StrapTreeList();
            this.colPJD_NO_KEY = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPJT_NO = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPJT_TASK = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPJT_TASK_CD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMEMB_NM_1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMEMB_NM_2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPLAN_START_DT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPLAN_END_DT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colACT_START_DT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colACT_END_DT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPLAN_MD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colACT_MD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPJT_DETAIL_STATUS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVALID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colREMARK = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSORT_NO = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colROW_SEQ = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCREATE_DTTM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLANG_CODE = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRowState = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCrudCls = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSelectedCheck = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPJT_TASK_CLS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPJT_TASK_CLS_2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPJT_TASK_CLS_3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectDetailModelBindingSource
            // 
            this.projectDetailModelBindingSource.DataSource = typeof(BPack.Model.App.CT.ProjectManager.ProjectDetailModel);
            // 
            // strapTreeList1
            // 
            this.strapTreeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colPJD_NO_KEY,
            this.colPJT_NO,
            this.colPJT_TASK,
            this.colPJT_TASK_CD,
            this.colMEMB_NM_1,
            this.colMEMB_NM_2,
            this.colPLAN_START_DT,
            this.colPLAN_END_DT,
            this.colACT_START_DT,
            this.colACT_END_DT,
            this.colPLAN_MD,
            this.colACT_MD,
            this.colPJT_DETAIL_STATUS,
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
            this.colPJT_TASK_CLS,
            this.colPJT_TASK_CLS_2,
            this.colPJT_TASK_CLS_3});
            this.strapTreeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.strapTreeList1.DataSource = this.projectDetailModelBindingSource;
            this.strapTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapTreeList1.IsStrapGridViewDefaultSetting = true;
            this.strapTreeList1.KeyFieldName = "PJD_NO";
            this.strapTreeList1.Location = new System.Drawing.Point(0, 0);
            this.strapTreeList1.Name = "strapTreeList1";
            this.strapTreeList1.OptionsView.AutoWidth = false;
            this.strapTreeList1.ParentFieldName = "PARENT_PJD_NO";
            this.strapTreeList1.SelectedModel = null;
            this.strapTreeList1.SelectedModelIndex = null;
            this.strapTreeList1.SelectedNode = null;
            this.strapTreeList1.Size = new System.Drawing.Size(1306, 468);
            this.strapTreeList1.TabIndex = 0;
            // 
            // colPJD_NO_KEY
            // 
            this.colPJD_NO_KEY.FieldName = "PJD_NO_KEY";
            this.colPJD_NO_KEY.Name = "colPJD_NO_KEY";
            this.colPJD_NO_KEY.OptionsColumn.ReadOnly = true;
            // 
            // colPJT_NO
            // 
            this.colPJT_NO.FieldName = "PJT_NO";
            this.colPJT_NO.Name = "colPJT_NO";
            // 
            // colPJT_TASK
            // 
            this.colPJT_TASK.FieldName = "PJT_TASK";
            this.colPJT_TASK.Name = "colPJT_TASK";
            this.colPJT_TASK.Visible = true;
            this.colPJT_TASK.VisibleIndex = 0;
            // 
            // colPJT_TASK_CD
            // 
            this.colPJT_TASK_CD.FieldName = "PJT_TASK_CD";
            this.colPJT_TASK_CD.Name = "colPJT_TASK_CD";
            this.colPJT_TASK_CD.Visible = true;
            this.colPJT_TASK_CD.VisibleIndex = 1;
            // 
            // colMEMB_NM_1
            // 
            this.colMEMB_NM_1.FieldName = "MEMB_NM_1";
            this.colMEMB_NM_1.Name = "colMEMB_NM_1";
            this.colMEMB_NM_1.Visible = true;
            this.colMEMB_NM_1.VisibleIndex = 5;
            // 
            // colMEMB_NM_2
            // 
            this.colMEMB_NM_2.FieldName = "MEMB_NM_2";
            this.colMEMB_NM_2.Name = "colMEMB_NM_2";
            this.colMEMB_NM_2.Visible = true;
            this.colMEMB_NM_2.VisibleIndex = 6;
            // 
            // colPLAN_START_DT
            // 
            this.colPLAN_START_DT.FieldName = "PLAN_START_DT";
            this.colPLAN_START_DT.Name = "colPLAN_START_DT";
            this.colPLAN_START_DT.Visible = true;
            this.colPLAN_START_DT.VisibleIndex = 7;
            // 
            // colPLAN_END_DT
            // 
            this.colPLAN_END_DT.FieldName = "PLAN_END_DT";
            this.colPLAN_END_DT.Name = "colPLAN_END_DT";
            this.colPLAN_END_DT.Visible = true;
            this.colPLAN_END_DT.VisibleIndex = 8;
            // 
            // colACT_START_DT
            // 
            this.colACT_START_DT.FieldName = "ACT_START_DT";
            this.colACT_START_DT.Name = "colACT_START_DT";
            this.colACT_START_DT.Visible = true;
            this.colACT_START_DT.VisibleIndex = 9;
            // 
            // colACT_END_DT
            // 
            this.colACT_END_DT.FieldName = "ACT_END_DT";
            this.colACT_END_DT.Name = "colACT_END_DT";
            this.colACT_END_DT.Visible = true;
            this.colACT_END_DT.VisibleIndex = 10;
            // 
            // colPLAN_MD
            // 
            this.colPLAN_MD.FieldName = "PLAN_MD";
            this.colPLAN_MD.Name = "colPLAN_MD";
            this.colPLAN_MD.Visible = true;
            this.colPLAN_MD.VisibleIndex = 11;
            // 
            // colACT_MD
            // 
            this.colACT_MD.FieldName = "ACT_MD";
            this.colACT_MD.Name = "colACT_MD";
            this.colACT_MD.Visible = true;
            this.colACT_MD.VisibleIndex = 12;
            // 
            // colPJT_DETAIL_STATUS
            // 
            this.colPJT_DETAIL_STATUS.FieldName = "PJT_DETAIL_STATUS";
            this.colPJT_DETAIL_STATUS.Name = "colPJT_DETAIL_STATUS";
            this.colPJT_DETAIL_STATUS.Visible = true;
            this.colPJT_DETAIL_STATUS.VisibleIndex = 13;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 14;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
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
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            // 
            // colPJT_TASK_CLS
            // 
            this.colPJT_TASK_CLS.FieldName = "PJT_TASK_CLS";
            this.colPJT_TASK_CLS.Name = "colPJT_TASK_CLS";
            this.colPJT_TASK_CLS.Visible = true;
            this.colPJT_TASK_CLS.VisibleIndex = 2;
            // 
            // colPJT_TASK_CLS_2
            // 
            this.colPJT_TASK_CLS_2.FieldName = "PJT_TASK_CLS_2";
            this.colPJT_TASK_CLS_2.Name = "colPJT_TASK_CLS_2";
            this.colPJT_TASK_CLS_2.Visible = true;
            this.colPJT_TASK_CLS_2.VisibleIndex = 3;
            // 
            // colPJT_TASK_CLS_3
            // 
            this.colPJT_TASK_CLS_3.FieldName = "PJT_TASK_CLS_3";
            this.colPJT_TASK_CLS_3.Name = "colPJT_TASK_CLS_3";
            this.colPJT_TASK_CLS_3.Visible = true;
            this.colPJT_TASK_CLS_3.VisibleIndex = 4;
            // 
            // ProjectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 468);
            this.Controls.Add(this.strapTreeList1);
            this.Name = "ProjectDetail";
            this.Text = "ProjectDetail";
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource projectDetailModelBindingSource;
        private Strap.TreeList.StrapTreeList strapTreeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPJD_NO_KEY;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPJT_NO;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPJT_TASK;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMEMB_NM_1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMEMB_NM_2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPLAN_START_DT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPLAN_END_DT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colACT_START_DT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colACT_END_DT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPJT_DETAIL_STATUS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVALID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colREMARK;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSORT_NO;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colROW_SEQ;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCREATE_DTTM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCREATE_USER_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMODIFY_DTTM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMODIFY_USER_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLANG_CODE;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRowState;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCrudCls;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSelectedCheck;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPJT_TASK_CLS;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPJT_TASK_CD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPLAN_MD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colACT_MD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPJT_TASK_CLS_2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPJT_TASK_CLS_3;
    }
}
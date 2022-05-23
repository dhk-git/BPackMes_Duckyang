namespace BPack.Carrying.App.MD.OrgUser
{
    partial class OrgDeptList
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
            this.strapTreeList1 = new BPack.Strap.TreeList.StrapTreeList();
            this.deptModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCOMP_CD_KEY = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDEPT_CD_KEY = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCOMP_CD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCOMP_NM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDEPT_NM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPATH = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVALID_FROM_DT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVALID_TO_DT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDEL_FG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colREMARK = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVALID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSORT_NO = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colROW_SEQ = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCREATE_DTTM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRowState = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCrudCls = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSelectedCheck = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapTreeList1
            // 
            this.strapTreeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCOMP_CD_KEY,
            this.colDEPT_CD_KEY,
            this.colCOMP_CD,
            this.colCOMP_NM,
            this.colDEPT_NM,
            this.colPATH,
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
            this.strapTreeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.strapTreeList1.DataSource = this.deptModelBindingSource;
            this.strapTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapTreeList1.IsStrapGridViewDefaultSetting = true;
            this.strapTreeList1.KeyFieldName = "DEPT_CD";
            this.strapTreeList1.Location = new System.Drawing.Point(0, 0);
            this.strapTreeList1.Name = "strapTreeList1";
            this.strapTreeList1.ParentFieldName = "PARENT_DEPT_CD";
            this.strapTreeList1.RootValue = "";
            this.strapTreeList1.SelectedModel = null;
            this.strapTreeList1.SelectedModelIndex = null;
            this.strapTreeList1.SelectedNode = null;
            this.strapTreeList1.Size = new System.Drawing.Size(800, 450);
            this.strapTreeList1.TabIndex = 0;
            // 
            // deptModelBindingSource
            // 
            this.deptModelBindingSource.DataSource = typeof(BPack.Model.App.MD.OrgUser.DeptModel);
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD_KEY.Visible = true;
            this.colCOMP_CD_KEY.VisibleIndex = 0;
            // 
            // colDEPT_CD_KEY
            // 
            this.colDEPT_CD_KEY.FieldName = "DEPT_CD_KEY";
            this.colDEPT_CD_KEY.Name = "colDEPT_CD_KEY";
            this.colDEPT_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colDEPT_CD_KEY.Visible = true;
            this.colDEPT_CD_KEY.VisibleIndex = 1;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 2;
            // 
            // colCOMP_NM
            // 
            this.colCOMP_NM.FieldName = "COMP_NM";
            this.colCOMP_NM.Name = "colCOMP_NM";
            this.colCOMP_NM.Visible = true;
            this.colCOMP_NM.VisibleIndex = 3;
            // 
            // colDEPT_NM
            // 
            this.colDEPT_NM.FieldName = "DEPT_NM";
            this.colDEPT_NM.Name = "colDEPT_NM";
            this.colDEPT_NM.Visible = true;
            this.colDEPT_NM.VisibleIndex = 4;
            // 
            // colPATH
            // 
            this.colPATH.FieldName = "PATH";
            this.colPATH.Name = "colPATH";
            this.colPATH.Visible = true;
            this.colPATH.VisibleIndex = 5;
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
            // OrgDeptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapTreeList1);
            this.Name = "OrgDeptList";
            this.Text = "OrgDeptList";
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Strap.TreeList.StrapTreeList strapTreeList1;
        private System.Windows.Forms.BindingSource deptModelBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCOMP_CD_KEY;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDEPT_CD_KEY;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCOMP_CD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCOMP_NM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDEPT_NM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPATH;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVALID_FROM_DT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVALID_TO_DT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDEL_FG;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colREMARK;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMODIFY_DTTM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMODIFY_USER_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVALID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSORT_NO;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colROW_SEQ;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCREATE_DTTM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCREATE_USER_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRowState;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCrudCls;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSelectedCheck;
    }
}
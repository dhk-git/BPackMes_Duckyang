﻿
namespace BPack.Carrying.App.CT.ProjectManager
{
    partial class ProjectDetailList
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.projectDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPJD_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_TASK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_TASK_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_TASK_CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_TASK_CLS_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_TASK_CLS_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMEMB_NM_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMEMB_NM_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_PJD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAN_START_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAN_END_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACT_START_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACT_END_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAN_MD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACT_MD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_DETAIL_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.projectDetailModelBindingSource;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPJD_NO_KEY,
            this.colPJD_NO,
            this.colPJT_NO,
            this.colPJT_TASK,
            this.colPJT_TASK_CD,
            this.colPJT_TASK_CLS,
            this.colPJT_TASK_CLS_2,
            this.colPJT_TASK_CLS_3,
            this.colMEMB_NM_1,
            this.colMEMB_NM_2,
            this.colPARENT_PJD_NO,
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
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // projectDetailModelBindingSource
            // 
            this.projectDetailModelBindingSource.DataSource = typeof(BPack.Model.App.CT.ProjectManager.ProjectDetailModel);
            // 
            // colPJD_NO_KEY
            // 
            this.colPJD_NO_KEY.FieldName = "PJD_NO_KEY";
            this.colPJD_NO_KEY.Name = "colPJD_NO_KEY";
            this.colPJD_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colPJD_NO_KEY.Visible = true;
            this.colPJD_NO_KEY.VisibleIndex = 0;
            // 
            // colPJD_NO
            // 
            this.colPJD_NO.FieldName = "PJD_NO";
            this.colPJD_NO.Name = "colPJD_NO";
            this.colPJD_NO.OptionsColumn.ReadOnly = true;
            this.colPJD_NO.Visible = true;
            this.colPJD_NO.VisibleIndex = 1;
            // 
            // colPJT_NO
            // 
            this.colPJT_NO.FieldName = "PJT_NO";
            this.colPJT_NO.Name = "colPJT_NO";
            this.colPJT_NO.OptionsColumn.ReadOnly = true;
            this.colPJT_NO.Visible = true;
            this.colPJT_NO.VisibleIndex = 2;
            // 
            // colPJT_TASK
            // 
            this.colPJT_TASK.FieldName = "PJT_TASK";
            this.colPJT_TASK.Name = "colPJT_TASK";
            this.colPJT_TASK.Visible = true;
            this.colPJT_TASK.VisibleIndex = 3;
            // 
            // colPJT_TASK_CD
            // 
            this.colPJT_TASK_CD.FieldName = "PJT_TASK_CD";
            this.colPJT_TASK_CD.Name = "colPJT_TASK_CD";
            this.colPJT_TASK_CD.Visible = true;
            this.colPJT_TASK_CD.VisibleIndex = 4;
            // 
            // colPJT_TASK_CLS
            // 
            this.colPJT_TASK_CLS.FieldName = "PJT_TASK_CLS";
            this.colPJT_TASK_CLS.Name = "colPJT_TASK_CLS";
            this.colPJT_TASK_CLS.Visible = true;
            this.colPJT_TASK_CLS.VisibleIndex = 5;
            // 
            // colPJT_TASK_CLS_2
            // 
            this.colPJT_TASK_CLS_2.FieldName = "PJT_TASK_CLS_2";
            this.colPJT_TASK_CLS_2.Name = "colPJT_TASK_CLS_2";
            this.colPJT_TASK_CLS_2.Visible = true;
            this.colPJT_TASK_CLS_2.VisibleIndex = 6;
            // 
            // colPJT_TASK_CLS_3
            // 
            this.colPJT_TASK_CLS_3.FieldName = "PJT_TASK_CLS_3";
            this.colPJT_TASK_CLS_3.Name = "colPJT_TASK_CLS_3";
            this.colPJT_TASK_CLS_3.Visible = true;
            this.colPJT_TASK_CLS_3.VisibleIndex = 7;
            // 
            // colMEMB_NM_1
            // 
            this.colMEMB_NM_1.FieldName = "MEMB_NM_1";
            this.colMEMB_NM_1.Name = "colMEMB_NM_1";
            this.colMEMB_NM_1.Visible = true;
            this.colMEMB_NM_1.VisibleIndex = 8;
            // 
            // colMEMB_NM_2
            // 
            this.colMEMB_NM_2.FieldName = "MEMB_NM_2";
            this.colMEMB_NM_2.Name = "colMEMB_NM_2";
            this.colMEMB_NM_2.Visible = true;
            this.colMEMB_NM_2.VisibleIndex = 9;
            // 
            // colPARENT_PJD_NO
            // 
            this.colPARENT_PJD_NO.FieldName = "PARENT_PJD_NO";
            this.colPARENT_PJD_NO.Name = "colPARENT_PJD_NO";
            this.colPARENT_PJD_NO.Visible = true;
            this.colPARENT_PJD_NO.VisibleIndex = 10;
            // 
            // colPLAN_START_DT
            // 
            this.colPLAN_START_DT.FieldName = "PLAN_START_DT";
            this.colPLAN_START_DT.Name = "colPLAN_START_DT";
            this.colPLAN_START_DT.Visible = true;
            this.colPLAN_START_DT.VisibleIndex = 11;
            // 
            // colPLAN_END_DT
            // 
            this.colPLAN_END_DT.FieldName = "PLAN_END_DT";
            this.colPLAN_END_DT.Name = "colPLAN_END_DT";
            this.colPLAN_END_DT.Visible = true;
            this.colPLAN_END_DT.VisibleIndex = 12;
            // 
            // colACT_START_DT
            // 
            this.colACT_START_DT.FieldName = "ACT_START_DT";
            this.colACT_START_DT.Name = "colACT_START_DT";
            this.colACT_START_DT.Visible = true;
            this.colACT_START_DT.VisibleIndex = 13;
            // 
            // colACT_END_DT
            // 
            this.colACT_END_DT.FieldName = "ACT_END_DT";
            this.colACT_END_DT.Name = "colACT_END_DT";
            this.colACT_END_DT.Visible = true;
            this.colACT_END_DT.VisibleIndex = 14;
            // 
            // colPLAN_MD
            // 
            this.colPLAN_MD.FieldName = "PLAN_MD";
            this.colPLAN_MD.Name = "colPLAN_MD";
            this.colPLAN_MD.Visible = true;
            this.colPLAN_MD.VisibleIndex = 15;
            // 
            // colACT_MD
            // 
            this.colACT_MD.FieldName = "ACT_MD";
            this.colACT_MD.Name = "colACT_MD";
            this.colACT_MD.Visible = true;
            this.colACT_MD.VisibleIndex = 16;
            // 
            // colPJT_DETAIL_STATUS
            // 
            this.colPJT_DETAIL_STATUS.FieldName = "PJT_DETAIL_STATUS";
            this.colPJT_DETAIL_STATUS.Name = "colPJT_DETAIL_STATUS";
            this.colPJT_DETAIL_STATUS.Visible = true;
            this.colPJT_DETAIL_STATUS.VisibleIndex = 17;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 18;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 19;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 20;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 21;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 22;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 23;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 24;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 25;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 26;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 27;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 28;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 29;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 30;
            // 
            // ProjectDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ProjectDetailList";
            this.Text = "ProjectDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource projectDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPJD_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPJD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_TASK;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_TASK_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_TASK_CLS;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_TASK_CLS_2;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_TASK_CLS_3;
        private DevExpress.XtraGrid.Columns.GridColumn colMEMB_NM_1;
        private DevExpress.XtraGrid.Columns.GridColumn colMEMB_NM_2;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_PJD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAN_START_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAN_END_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colACT_START_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colACT_END_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAN_MD;
        private DevExpress.XtraGrid.Columns.GridColumn colACT_MD;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_DETAIL_STATUS;
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
namespace BPack.Carrying.App.MD.WcWorkTime
{
    partial class WcWorkTimeWorkTimeList
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
            this.wcWorkTimeWorkTimeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTimeSpanEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_DT_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_TM_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWTM_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWTM_MIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_DT = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.wcWorkTimeWorkTimeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.wcWorkTimeWorkTimeModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTimeSpanEdit1});
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 1;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // wcWorkTimeWorkTimeModelBindingSource
            // 
            this.wcWorkTimeWorkTimeModelBindingSource.DataSource = typeof(BPack.Model.App.MD.WcWorkTime.WcWorkTimeWorkTimeModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colPLANT_CD_KEY,
            this.colWC_CD_KEY,
            this.colSHIFT_CD_KEY,
            this.colVALID_DT_KEY,
            this.colSTART_TM_KEY,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWC_CD,
            this.colSHIFT_CD,
            this.colWTM_TYPE,
            this.colTM_NM,
            this.colSTART_TM,
            this.colEND_TM,
            this.colWTM_MIN,
            this.colVALID_DT,
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
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "###0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTimeSpanEdit1
            // 
            this.repositoryItemTimeSpanEdit1.AutoHeight = false;
            this.repositoryItemTimeSpanEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeSpanEdit1.Name = "repositoryItemTimeSpanEdit1";
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
            // colWC_CD_KEY
            // 
            this.colWC_CD_KEY.FieldName = "WC_CD_KEY";
            this.colWC_CD_KEY.Name = "colWC_CD_KEY";
            this.colWC_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colWC_CD_KEY.Visible = true;
            this.colWC_CD_KEY.VisibleIndex = 2;
            // 
            // colSHIFT_CD_KEY
            // 
            this.colSHIFT_CD_KEY.FieldName = "SHIFT_CD_KEY";
            this.colSHIFT_CD_KEY.Name = "colSHIFT_CD_KEY";
            this.colSHIFT_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colSHIFT_CD_KEY.Visible = true;
            this.colSHIFT_CD_KEY.VisibleIndex = 3;
            // 
            // colVALID_DT_KEY
            // 
            this.colVALID_DT_KEY.FieldName = "VALID_DT_KEY";
            this.colVALID_DT_KEY.Name = "colVALID_DT_KEY";
            this.colVALID_DT_KEY.OptionsColumn.ReadOnly = true;
            this.colVALID_DT_KEY.Visible = true;
            this.colVALID_DT_KEY.VisibleIndex = 4;
            // 
            // colSTART_TM_KEY
            // 
            this.colSTART_TM_KEY.FieldName = "START_TM_KEY";
            this.colSTART_TM_KEY.Name = "colSTART_TM_KEY";
            this.colSTART_TM_KEY.OptionsColumn.ReadOnly = true;
            this.colSTART_TM_KEY.Visible = true;
            this.colSTART_TM_KEY.VisibleIndex = 5;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 6;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 7;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 8;
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            this.colSHIFT_CD.Visible = true;
            this.colSHIFT_CD.VisibleIndex = 9;
            // 
            // colWTM_TYPE
            // 
            this.colWTM_TYPE.FieldName = "WTM_TYPE";
            this.colWTM_TYPE.Name = "colWTM_TYPE";
            this.colWTM_TYPE.Visible = true;
            this.colWTM_TYPE.VisibleIndex = 10;
            // 
            // colTM_NM
            // 
            this.colTM_NM.FieldName = "TM_NM";
            this.colTM_NM.Name = "colTM_NM";
            this.colTM_NM.Visible = true;
            this.colTM_NM.VisibleIndex = 11;
            // 
            // colSTART_TM
            // 
            this.colSTART_TM.FieldName = "START_TM";
            this.colSTART_TM.Name = "colSTART_TM";
            this.colSTART_TM.Visible = true;
            this.colSTART_TM.VisibleIndex = 12;
            // 
            // colEND_TM
            // 
            this.colEND_TM.FieldName = "END_TM";
            this.colEND_TM.Name = "colEND_TM";
            this.colEND_TM.Visible = true;
            this.colEND_TM.VisibleIndex = 13;
            // 
            // colWTM_MIN
            // 
            this.colWTM_MIN.FieldName = "WTM_MIN";
            this.colWTM_MIN.Name = "colWTM_MIN";
            this.colWTM_MIN.Visible = true;
            this.colWTM_MIN.VisibleIndex = 14;
            // 
            // colVALID_DT
            // 
            this.colVALID_DT.FieldName = "VALID_DT";
            this.colVALID_DT.Name = "colVALID_DT";
            this.colVALID_DT.Visible = true;
            this.colVALID_DT.VisibleIndex = 15;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 16;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 17;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 18;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 19;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 20;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 21;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 22;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 23;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 24;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 25;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 26;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 27;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 28;
            // 
            // WcWorkTimeWorkTimeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WcWorkTimeWorkTimeList";
            this.Text = "WcWorkTimeWorkTimeList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wcWorkTimeWorkTimeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource wcWorkTimeWorkTimeModelBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_DT_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_TM_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWTM_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colTM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colWTM_MIN;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_DT;
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
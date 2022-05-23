namespace BPack.Carrying.App.MI.CommonCodeManager
{
    partial class ParentCode
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
            this.parentCodeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colP_CODE_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colP_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colP_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE_CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_1_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_2_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_3_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_4_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_5_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CODE_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.parentCodeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.parentCodeModelBindingSource;
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
            // parentCodeModelBindingSource
            // 
            this.parentCodeModelBindingSource.DataSource = typeof(BPack.Model.App.MI.CommonCodeManager.ParentCodeModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colP_CODE_KEY,
            this.colP_CODE,
            this.colP_NAME,
            this.colCODE_CLS,
            this.colVALUE_1_DESC,
            this.colVALUE_2_DESC,
            this.colVALUE_3_DESC,
            this.colVALUE_4_DESC,
            this.colVALUE_5_DESC,
            this.colCOMP_CODE_KEY,
            this.colCOMP_CODE,
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
            // colP_CODE_KEY
            // 
            this.colP_CODE_KEY.FieldName = "P_CODE_KEY";
            this.colP_CODE_KEY.Name = "colP_CODE_KEY";
            this.colP_CODE_KEY.OptionsColumn.ReadOnly = true;
            this.colP_CODE_KEY.Visible = true;
            this.colP_CODE_KEY.VisibleIndex = 1;
            // 
            // colP_CODE
            // 
            this.colP_CODE.FieldName = "P_CODE";
            this.colP_CODE.Name = "colP_CODE";
            this.colP_CODE.Visible = true;
            this.colP_CODE.VisibleIndex = 2;
            // 
            // colP_NAME
            // 
            this.colP_NAME.FieldName = "P_NAME";
            this.colP_NAME.Name = "colP_NAME";
            this.colP_NAME.Visible = true;
            this.colP_NAME.VisibleIndex = 3;
            // 
            // colCODE_CLS
            // 
            this.colCODE_CLS.FieldName = "CODE_CLS";
            this.colCODE_CLS.Name = "colCODE_CLS";
            this.colCODE_CLS.Visible = true;
            this.colCODE_CLS.VisibleIndex = 4;
            // 
            // colVALUE_1_DESC
            // 
            this.colVALUE_1_DESC.FieldName = "VALUE_1_DESC";
            this.colVALUE_1_DESC.Name = "colVALUE_1_DESC";
            this.colVALUE_1_DESC.Visible = true;
            this.colVALUE_1_DESC.VisibleIndex = 5;
            // 
            // colVALUE_2_DESC
            // 
            this.colVALUE_2_DESC.FieldName = "VALUE_2_DESC";
            this.colVALUE_2_DESC.Name = "colVALUE_2_DESC";
            this.colVALUE_2_DESC.Visible = true;
            this.colVALUE_2_DESC.VisibleIndex = 6;
            // 
            // colVALUE_3_DESC
            // 
            this.colVALUE_3_DESC.FieldName = "VALUE_3_DESC";
            this.colVALUE_3_DESC.Name = "colVALUE_3_DESC";
            this.colVALUE_3_DESC.Visible = true;
            this.colVALUE_3_DESC.VisibleIndex = 7;
            // 
            // colVALUE_4_DESC
            // 
            this.colVALUE_4_DESC.FieldName = "VALUE_4_DESC";
            this.colVALUE_4_DESC.Name = "colVALUE_4_DESC";
            this.colVALUE_4_DESC.Visible = true;
            this.colVALUE_4_DESC.VisibleIndex = 8;
            // 
            // colVALUE_5_DESC
            // 
            this.colVALUE_5_DESC.FieldName = "VALUE_5_DESC";
            this.colVALUE_5_DESC.Name = "colVALUE_5_DESC";
            this.colVALUE_5_DESC.Visible = true;
            this.colVALUE_5_DESC.VisibleIndex = 9;
            // 
            // colCOMP_CODE_KEY
            // 
            this.colCOMP_CODE_KEY.FieldName = "COMP_CODE_KEY";
            this.colCOMP_CODE_KEY.Name = "colCOMP_CODE_KEY";
            this.colCOMP_CODE_KEY.Visible = true;
            this.colCOMP_CODE_KEY.VisibleIndex = 10;
            // 
            // colCOMP_CODE
            // 
            this.colCOMP_CODE.FieldName = "COMP_CODE";
            this.colCOMP_CODE.Name = "colCOMP_CODE";
            this.colCOMP_CODE.OptionsColumn.ReadOnly = true;
            this.colCOMP_CODE.Visible = true;
            this.colCOMP_CODE.VisibleIndex = 11;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 12;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 13;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 14;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 15;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 16;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 17;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 18;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 19;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 20;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 21;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 22;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 23;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 0;
            // 
            // ParentCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ParentCode";
            this.Text = "ParentCode";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentCodeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource parentCodeModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colP_CODE_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colP_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colP_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE_CLS;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_1_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_2_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_3_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_4_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_5_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CODE_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CODE;
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
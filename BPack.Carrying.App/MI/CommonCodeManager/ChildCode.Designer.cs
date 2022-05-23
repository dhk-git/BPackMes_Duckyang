namespace BPack.Carrying.App.MI.CommonCodeManager
{
    partial class ChildCode
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
            this.childCodeModelBindingSource = new System.Windows.Forms.BindingSource();
            this.colP_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childCodeModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.childCodeModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colP_CODE,
            this.colC_CODE,
            this.colC_NAME,
            this.colVALUE_1,
            this.colVALUE_2,
            this.colVALUE_3,
            this.colVALUE_4,
            this.colVALUE_5,
            this.colVALID,
            this.colREMARK,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colCREATE_DTTM,
            this.colCREATE_USER_ID,
            this.colMODIFY_DTTM,
            this.colMODIFY_USER_ID,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // childCodeModelBindingSource
            // 
            this.childCodeModelBindingSource.DataSource = typeof(BPack.Model.App.MI.CommonCodeManager.ChildCodeModel);
            // 
            // colP_CODE
            // 
            this.colP_CODE.FieldName = "P_CODE";
            this.colP_CODE.Name = "colP_CODE";
            this.colP_CODE.OptionsColumn.ReadOnly = true;
            this.colP_CODE.Visible = true;
            this.colP_CODE.VisibleIndex = 0;
            // 
            // colC_CODE
            // 
            this.colC_CODE.FieldName = "C_CODE";
            this.colC_CODE.Name = "colC_CODE";
            this.colC_CODE.Visible = true;
            this.colC_CODE.VisibleIndex = 1;
            // 
            // colC_NAME
            // 
            this.colC_NAME.FieldName = "C_NAME";
            this.colC_NAME.Name = "colC_NAME";
            this.colC_NAME.Visible = true;
            this.colC_NAME.VisibleIndex = 2;
            // 
            // colVALUE_1
            // 
            this.colVALUE_1.FieldName = "VALUE_1";
            this.colVALUE_1.Name = "colVALUE_1";
            this.colVALUE_1.Visible = true;
            this.colVALUE_1.VisibleIndex = 3;
            // 
            // colVALUE_2
            // 
            this.colVALUE_2.FieldName = "VALUE_2";
            this.colVALUE_2.Name = "colVALUE_2";
            this.colVALUE_2.Visible = true;
            this.colVALUE_2.VisibleIndex = 4;
            // 
            // colVALUE_3
            // 
            this.colVALUE_3.FieldName = "VALUE_3";
            this.colVALUE_3.Name = "colVALUE_3";
            this.colVALUE_3.Visible = true;
            this.colVALUE_3.VisibleIndex = 5;
            // 
            // colVALUE_4
            // 
            this.colVALUE_4.FieldName = "VALUE_4";
            this.colVALUE_4.Name = "colVALUE_4";
            this.colVALUE_4.Visible = true;
            this.colVALUE_4.VisibleIndex = 6;
            // 
            // colVALUE_5
            // 
            this.colVALUE_5.FieldName = "VALUE_5";
            this.colVALUE_5.Name = "colVALUE_5";
            this.colVALUE_5.Visible = true;
            this.colVALUE_5.VisibleIndex = 7;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 8;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 9;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 10;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 11;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 12;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 13;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 14;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 15;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 16;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 17;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 18;
            // 
            // ChildCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ChildCode";
            this.Text = "ChildCode";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childCodeModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource childCodeModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colP_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colC_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_1;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_2;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_3;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_4;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_5;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colSORT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
    }
}
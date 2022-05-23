
namespace BPack.Carrying.App.QC.IqcInsp
{
    partial class IqcInspFailList
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
            this.IqcInspFailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIQD_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFECT_SEQ_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIQD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFECT_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFECT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIQC_RESPON_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFECT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IqcInspFailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.IqcInspFailModelBindingSource;
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
            // IqcInspFailModelBindingSource
            // 
            this.IqcInspFailModelBindingSource.DataSource = typeof(BPack.Model.App.QC.IqcInsp.IqcInspFailModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIQD_NO_KEY,
            this.colDEFECT_SEQ_KEY,
            this.colIQD_NO,
            this.colDEFECT_SEQ,
            this.colDEFECT_CD,
            this.colIQC_RESPON_CD,
            this.colDEFECT_QTY,
            this.colREMARK,
            this.colCREATE_DTTM,
            this.colMODIFY_DTTM,
            this.colCREATE_USER_ID,
            this.colMODIFY_USER_ID,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIQD_NO_KEY
            // 
            this.colIQD_NO_KEY.FieldName = "IQD_NO_KEY";
            this.colIQD_NO_KEY.Name = "colIQD_NO_KEY";
            this.colIQD_NO_KEY.OptionsColumn.ReadOnly = true;
            // 
            // colDEFECT_SEQ_KEY
            // 
            this.colDEFECT_SEQ_KEY.FieldName = "DEFECT_SEQ_KEY";
            this.colDEFECT_SEQ_KEY.Name = "colDEFECT_SEQ_KEY";
            this.colDEFECT_SEQ_KEY.OptionsColumn.ReadOnly = true;
            // 
            // colIQD_NO
            // 
            this.colIQD_NO.FieldName = "IQD_NO";
            this.colIQD_NO.Name = "colIQD_NO";
            // 
            // colDEFECT_SEQ
            // 
            this.colDEFECT_SEQ.FieldName = "DEFECT_SEQ";
            this.colDEFECT_SEQ.Name = "colDEFECT_SEQ";
            // 
            // colDEFECT_CD
            // 
            this.colDEFECT_CD.FieldName = "DEFECT_CD";
            this.colDEFECT_CD.Name = "colDEFECT_CD";
            this.colDEFECT_CD.Visible = true;
            this.colDEFECT_CD.VisibleIndex = 1;
            // 
            // colIQC_RESPON_CD
            // 
            this.colIQC_RESPON_CD.FieldName = "IQC_RESPON_CD";
            this.colIQC_RESPON_CD.Name = "colIQC_RESPON_CD";
            this.colIQC_RESPON_CD.Visible = true;
            this.colIQC_RESPON_CD.VisibleIndex = 2;
            // 
            // colDEFECT_QTY
            // 
            this.colDEFECT_QTY.FieldName = "DEFECT_QTY";
            this.colDEFECT_QTY.Name = "colDEFECT_QTY";
            this.colDEFECT_QTY.Visible = true;
            this.colDEFECT_QTY.VisibleIndex = 3;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 4;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 5;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 6;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 7;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 8;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 9;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 0;
            // 
            // IqcInspFailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "IqcInspFailList";
            this.Text = "IqcInspFailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IqcInspFailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource IqcInspFailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIQD_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFECT_SEQ_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colIQD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFECT_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFECT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colIQC_RESPON_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFECT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}

namespace BPack.Carrying.App.QC.IqcInsp
{
    partial class IqcInspList
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
            this.IqcInspModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIQC_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIQC_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLOSE_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPIH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIQC_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIQC_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IqcInspModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.IqcInspModelBindingSource;
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
            // IqcInspModelBindingSource
            // 
            this.IqcInspModelBindingSource.DataSource = typeof(BPack.Model.App.QC.IqcInsp.IqcInspModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIQC_NO_KEY,
            this.colIQC_NO,
            this.colCLOSE_DT,
            this.colPIH_NO,
            this.colIQC_STATUS,
            this.colIQC_DT,
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
            // colIQC_NO_KEY
            // 
            this.colIQC_NO_KEY.FieldName = "IQC_NO_KEY";
            this.colIQC_NO_KEY.Name = "colIQC_NO_KEY";
            this.colIQC_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colIQC_NO_KEY.Visible = true;
            this.colIQC_NO_KEY.VisibleIndex = 0;
            // 
            // colIQC_NO
            // 
            this.colIQC_NO.FieldName = "IQC_NO";
            this.colIQC_NO.Name = "colIQC_NO";
            this.colIQC_NO.Visible = true;
            this.colIQC_NO.VisibleIndex = 1;
            // 
            // colCLOSE_DT
            // 
            this.colCLOSE_DT.FieldName = "CLOSE_DT";
            this.colCLOSE_DT.Name = "colCLOSE_DT";
            this.colCLOSE_DT.Visible = true;
            this.colCLOSE_DT.VisibleIndex = 2;
            // 
            // colPIH_NO
            // 
            this.colPIH_NO.FieldName = "PIH_NO";
            this.colPIH_NO.Name = "colPIH_NO";
            this.colPIH_NO.Visible = true;
            this.colPIH_NO.VisibleIndex = 3;
            // 
            // colIQC_STATUS
            // 
            this.colIQC_STATUS.FieldName = "IQC_STATUS";
            this.colIQC_STATUS.Name = "colIQC_STATUS";
            this.colIQC_STATUS.Visible = true;
            this.colIQC_STATUS.VisibleIndex = 4;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 6;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 7;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 8;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 9;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 10;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 11;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 12;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 13;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 14;
            // 
            // colIQC_DT
            // 
            this.colIQC_DT.FieldName = "IQC_DT";
            this.colIQC_DT.Name = "colIQC_DT";
            this.colIQC_DT.Visible = true;
            this.colIQC_DT.VisibleIndex = 5;
            // 
            // IqcInspList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "IqcInspList";
            this.Text = "IqcInspList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IqcInspModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource IqcInspModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIQC_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colIQC_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPIH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colIQC_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colCLOSE_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colIQC_DT;
    }
}
namespace BPack.Carrying.App.CT.PjtAct
{
    partial class PjtActList
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
            this.pjtActModelBindingSource = new System.Windows.Forms.BindingSource();
            this.colSTART_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_TASK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACT_HOUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPJT_ACT_CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pjtActModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.pjtActModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTART_DTTM,
            this.colEND_DTTM,
            this.colPJT_NM,
            this.colPJT_TASK,
            this.colACT_HOUR,
            this.colPJT_ACT_CLS,
            this.colACT_DESC,
            this.colREMARK,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // pjtActModelBindingSource
            // 
            this.pjtActModelBindingSource.DataSource = typeof(BPack.Model.App.CT.PjtAct.PjtActModel);
            // 
            // colSTART_DTTM
            // 
            this.colSTART_DTTM.FieldName = "START_DTTM";
            this.colSTART_DTTM.Name = "colSTART_DTTM";
            this.colSTART_DTTM.Visible = true;
            this.colSTART_DTTM.VisibleIndex = 0;
            // 
            // colEND_DTTM
            // 
            this.colEND_DTTM.FieldName = "END_DTTM";
            this.colEND_DTTM.Name = "colEND_DTTM";
            this.colEND_DTTM.Visible = true;
            this.colEND_DTTM.VisibleIndex = 1;
            // 
            // colPJT_NM
            // 
            this.colPJT_NM.FieldName = "PJT_NM";
            this.colPJT_NM.Name = "colPJT_NM";
            this.colPJT_NM.Visible = true;
            this.colPJT_NM.VisibleIndex = 2;
            // 
            // colPJT_TASK
            // 
            this.colPJT_TASK.FieldName = "PJT_TASK";
            this.colPJT_TASK.Name = "colPJT_TASK";
            this.colPJT_TASK.Visible = true;
            this.colPJT_TASK.VisibleIndex = 3;
            // 
            // colACT_HOUR
            // 
            this.colACT_HOUR.FieldName = "ACT_HOUR";
            this.colACT_HOUR.Name = "colACT_HOUR";
            this.colACT_HOUR.Visible = true;
            this.colACT_HOUR.VisibleIndex = 4;
            // 
            // colPJT_ACT_CLS
            // 
            this.colPJT_ACT_CLS.FieldName = "PJT_ACT_CLS";
            this.colPJT_ACT_CLS.Name = "colPJT_ACT_CLS";
            this.colPJT_ACT_CLS.Visible = true;
            this.colPJT_ACT_CLS.VisibleIndex = 5;
            // 
            // colACT_DESC
            // 
            this.colACT_DESC.FieldName = "ACT_DESC";
            this.colACT_DESC.Name = "colACT_DESC";
            this.colACT_DESC.Visible = true;
            this.colACT_DESC.VisibleIndex = 6;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 7;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 8;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 9;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 10;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 11;
            // 
            // PjtActList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "PjtActList";
            this.Text = "PjtActList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pjtActModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource pjtActModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_TASK;
        private DevExpress.XtraGrid.Columns.GridColumn colACT_HOUR;
        private DevExpress.XtraGrid.Columns.GridColumn colPJT_ACT_CLS;
        private DevExpress.XtraGrid.Columns.GridColumn colACT_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
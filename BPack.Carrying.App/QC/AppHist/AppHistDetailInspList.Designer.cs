namespace BPack.Carrying.App.QC.AppHist
{
    partial class AppHistDetailInspList
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
            this.AppHistDetailInspModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colINSP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_DV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_DV_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_VAL_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_VAL_TYPE_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASE_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPPER_LIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOWER_LIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_VAL_QC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_JUDGE_QC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppHistDetailInspModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.AppHistDetailInspModelBindingSource;
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
            // AppHistDetailInspModelBindingSource
            // 
            this.AppHistDetailInspModelBindingSource.DataSource = typeof(BPack.Model.App.QC.AppHist.AppHistDetailInspModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colINSP_NO,
            this.colINSP_DV,
            this.colINSP_DV_NM,
            this.colINSP_ID,
            this.colINSP_NM,
            this.colINSP_VAL_TYPE,
            this.colINSP_VAL_TYPE_NM,
            this.colINSP_SPEC,
            this.colBASE_VALUE,
            this.colUPPER_LIMIT,
            this.colLOWER_LIMIT,
            this.colINSP_SEQ,
            this.colHU_NO,
            this.colINSP_VAL_QC,
            this.colINSP_JUDGE_QC,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView1_CellMerge);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colINSP_NO
            // 
            this.colINSP_NO.FieldName = "INSP_NO";
            this.colINSP_NO.Name = "colINSP_NO";
            this.colINSP_NO.Visible = true;
            this.colINSP_NO.VisibleIndex = 0;
            // 
            // colINSP_DV
            // 
            this.colINSP_DV.FieldName = "INSP_DV";
            this.colINSP_DV.Name = "colINSP_DV";
            this.colINSP_DV.Visible = true;
            this.colINSP_DV.VisibleIndex = 1;
            // 
            // colINSP_DV_NM
            // 
            this.colINSP_DV_NM.FieldName = "INSP_DV_NM";
            this.colINSP_DV_NM.Name = "colINSP_DV_NM";
            this.colINSP_DV_NM.Visible = true;
            this.colINSP_DV_NM.VisibleIndex = 2;
            // 
            // colINSP_ID
            // 
            this.colINSP_ID.FieldName = "INSP_ID";
            this.colINSP_ID.Name = "colINSP_ID";
            this.colINSP_ID.Visible = true;
            this.colINSP_ID.VisibleIndex = 3;
            // 
            // colINSP_NM
            // 
            this.colINSP_NM.FieldName = "INSP_NM";
            this.colINSP_NM.Name = "colINSP_NM";
            this.colINSP_NM.Visible = true;
            this.colINSP_NM.VisibleIndex = 4;
            // 
            // colINSP_VAL_TYPE
            // 
            this.colINSP_VAL_TYPE.FieldName = "INSP_VAL_TYPE";
            this.colINSP_VAL_TYPE.Name = "colINSP_VAL_TYPE";
            this.colINSP_VAL_TYPE.Visible = true;
            this.colINSP_VAL_TYPE.VisibleIndex = 5;
            // 
            // colINSP_VAL_TYPE_NM
            // 
            this.colINSP_VAL_TYPE_NM.FieldName = "INSP_VAL_TYPE_NM";
            this.colINSP_VAL_TYPE_NM.Name = "colINSP_VAL_TYPE_NM";
            this.colINSP_VAL_TYPE_NM.Visible = true;
            this.colINSP_VAL_TYPE_NM.VisibleIndex = 6;
            // 
            // colINSP_SPEC
            // 
            this.colINSP_SPEC.FieldName = "INSP_SPEC";
            this.colINSP_SPEC.Name = "colINSP_SPEC";
            this.colINSP_SPEC.Visible = true;
            this.colINSP_SPEC.VisibleIndex = 7;
            // 
            // colBASE_VALUE
            // 
            this.colBASE_VALUE.FieldName = "BASE_VALUE";
            this.colBASE_VALUE.Name = "colBASE_VALUE";
            this.colBASE_VALUE.Visible = true;
            this.colBASE_VALUE.VisibleIndex = 8;
            // 
            // colUPPER_LIMIT
            // 
            this.colUPPER_LIMIT.FieldName = "UPPER_LIMIT";
            this.colUPPER_LIMIT.Name = "colUPPER_LIMIT";
            this.colUPPER_LIMIT.Visible = true;
            this.colUPPER_LIMIT.VisibleIndex = 9;
            // 
            // colLOWER_LIMIT
            // 
            this.colLOWER_LIMIT.FieldName = "LOWER_LIMIT";
            this.colLOWER_LIMIT.Name = "colLOWER_LIMIT";
            this.colLOWER_LIMIT.Visible = true;
            this.colLOWER_LIMIT.VisibleIndex = 10;
            // 
            // colINSP_SEQ
            // 
            this.colINSP_SEQ.FieldName = "INSP_SEQ";
            this.colINSP_SEQ.Name = "colINSP_SEQ";
            this.colINSP_SEQ.Visible = true;
            this.colINSP_SEQ.VisibleIndex = 11;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.OptionsColumn.ReadOnly = true;
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 12;
            // 
            // colINSP_VAL_QC
            // 
            this.colINSP_VAL_QC.FieldName = "INSP_VAL_QC";
            this.colINSP_VAL_QC.Name = "colINSP_VAL_QC";
            this.colINSP_VAL_QC.Visible = true;
            this.colINSP_VAL_QC.VisibleIndex = 13;
            // 
            // colINSP_JUDGE_QC
            // 
            this.colINSP_JUDGE_QC.FieldName = "INSP_JUDGE_QC";
            this.colINSP_JUDGE_QC.Name = "colINSP_JUDGE_QC";
            this.colINSP_JUDGE_QC.Visible = true;
            this.colINSP_JUDGE_QC.VisibleIndex = 14;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 15;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 16;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 17;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 18;
            // 
            // AppHistDetailInspList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "AppHistDetailInspList";
            this.Text = "AppHistInspDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppHistDetailInspModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public Strap.Grid.StrapGridControl strapGridControl1;
        private System.Windows.Forms.BindingSource AppHistDetailInspModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_DV;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_DV_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_VAL_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_VAL_TYPE_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colBASE_VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colUPPER_LIMIT;
        private DevExpress.XtraGrid.Columns.GridColumn colLOWER_LIMIT;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_VAL_QC;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_JUDGE_QC;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
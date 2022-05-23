namespace BPack.Carrying.App.MM.GirLocStock
{
    partial class LocGirList
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
            this.locGirModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIR_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIR_TYPE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARGET_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARGET_LOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGI_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locGirModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.locGirModelBindingSource;
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
            // locGirModelBindingSource
            // 
            this.locGirModelBindingSource.DataSource = typeof(BPack.Model.App.MM.GirLocStock.LocGirModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWH_CD,
            this.colCREATE_DTTM,
            this.colGIR_DT,
            this.colLOC_CD,
            this.colGIR_TYPE_CD,
            this.colTARGET_WH_CD,
            this.colTARGET_LOC_CD,
            this.colREF_NO,
            this.colHU_NO,
            this.colREF_REMARK,
            this.colITEM_CD,
            this.colGR_QTY,
            this.colGI_QTY,
            this.colHU_BARCODE,
            this.colCREATE_USER_ID,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 0;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 1;
            // 
            // colWH_CD
            // 
            this.colWH_CD.FieldName = "WH_CD";
            this.colWH_CD.Name = "colWH_CD";
            this.colWH_CD.Visible = true;
            this.colWH_CD.VisibleIndex = 2;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 3;
            // 
            // colGIR_DT
            // 
            this.colGIR_DT.FieldName = "GIR_DT";
            this.colGIR_DT.Name = "colGIR_DT";
            this.colGIR_DT.Visible = true;
            this.colGIR_DT.VisibleIndex = 4;
            // 
            // colLOC_CD
            // 
            this.colLOC_CD.FieldName = "LOC_CD";
            this.colLOC_CD.Name = "colLOC_CD";
            this.colLOC_CD.Visible = true;
            this.colLOC_CD.VisibleIndex = 5;
            // 
            // colGIR_TYPE_CD
            // 
            this.colGIR_TYPE_CD.FieldName = "GIR_TYPE_CD";
            this.colGIR_TYPE_CD.Name = "colGIR_TYPE_CD";
            this.colGIR_TYPE_CD.Visible = true;
            this.colGIR_TYPE_CD.VisibleIndex = 6;
            // 
            // colTARGET_WH_CD
            // 
            this.colTARGET_WH_CD.FieldName = "TARGET_WH_CD";
            this.colTARGET_WH_CD.Name = "colTARGET_WH_CD";
            this.colTARGET_WH_CD.Visible = true;
            this.colTARGET_WH_CD.VisibleIndex = 7;
            // 
            // colTARGET_LOC_CD
            // 
            this.colTARGET_LOC_CD.FieldName = "TARGET_LOC_CD";
            this.colTARGET_LOC_CD.Name = "colTARGET_LOC_CD";
            this.colTARGET_LOC_CD.Visible = true;
            this.colTARGET_LOC_CD.VisibleIndex = 8;
            // 
            // colREF_NO
            // 
            this.colREF_NO.FieldName = "REF_NO";
            this.colREF_NO.Name = "colREF_NO";
            this.colREF_NO.Visible = true;
            this.colREF_NO.VisibleIndex = 9;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 10;
            // 
            // colREF_REMARK
            // 
            this.colREF_REMARK.FieldName = "REF_REMARK";
            this.colREF_REMARK.Name = "colREF_REMARK";
            this.colREF_REMARK.Visible = true;
            this.colREF_REMARK.VisibleIndex = 11;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 12;
            // 
            // colGR_QTY
            // 
            this.colGR_QTY.FieldName = "GR_QTY";
            this.colGR_QTY.Name = "colGR_QTY";
            this.colGR_QTY.Visible = true;
            this.colGR_QTY.VisibleIndex = 13;
            // 
            // colGI_QTY
            // 
            this.colGI_QTY.FieldName = "GI_QTY";
            this.colGI_QTY.Name = "colGI_QTY";
            this.colGI_QTY.Visible = true;
            this.colGI_QTY.VisibleIndex = 14;
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 15;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
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
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 20;
            // 
            // LocGirList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "LocGirList";
            this.Text = "LocGirList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locGirModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource locGirModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colGIR_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGIR_TYPE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colTARGET_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colTARGET_LOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colGI_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
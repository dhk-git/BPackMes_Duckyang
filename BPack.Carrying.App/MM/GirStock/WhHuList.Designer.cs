namespace BPack.Carrying.App.MM.GirStock
{
    partial class WhHuList
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
            this.whHuModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_INIT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_STOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_CREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_CREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWHHU_CREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWHHU_CREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whHuModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.whHuModelBindingSource;
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
            // whHuModelBindingSource
            // 
            this.whHuModelBindingSource.DataSource = typeof(BPack.Model.App.MM.GirStock.WhHuModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWH_CD,
            this.colLOC_CD,
            this.colHU_BARCODE,
            this.colHU_NO,
            this.colHU_TYPE,
            this.colHU_INIT_QTY,
            this.colHU_STOCK_QTY,
            this.colREMARK,
            this.colHU_CREATE_DTTM,
            this.colHU_CREATE_USER_ID,
            this.colWHHU_CREATE_DTTM,
            this.colWHHU_CREATE_USER_ID,
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
            // colLOC_CD
            // 
            this.colLOC_CD.FieldName = "LOC_CD";
            this.colLOC_CD.Name = "colLOC_CD";
            this.colLOC_CD.Visible = true;
            this.colLOC_CD.VisibleIndex = 3;
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 4;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 5;
            // 
            // colHU_TYPE
            // 
            this.colHU_TYPE.FieldName = "HU_TYPE";
            this.colHU_TYPE.Name = "colHU_TYPE";
            this.colHU_TYPE.Visible = true;
            this.colHU_TYPE.VisibleIndex = 6;
            // 
            // colHU_INIT_QTY
            // 
            this.colHU_INIT_QTY.FieldName = "HU_INIT_QTY";
            this.colHU_INIT_QTY.Name = "colHU_INIT_QTY";
            this.colHU_INIT_QTY.Visible = true;
            this.colHU_INIT_QTY.VisibleIndex = 7;
            // 
            // colHU_STOCK_QTY
            // 
            this.colHU_STOCK_QTY.FieldName = "HU_STOCK_QTY";
            this.colHU_STOCK_QTY.Name = "colHU_STOCK_QTY";
            this.colHU_STOCK_QTY.Visible = true;
            this.colHU_STOCK_QTY.VisibleIndex = 8;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 9;
            // 
            // colHU_CREATE_DTTM
            // 
            this.colHU_CREATE_DTTM.FieldName = "HU_CREATE_DTTM";
            this.colHU_CREATE_DTTM.Name = "colHU_CREATE_DTTM";
            this.colHU_CREATE_DTTM.Visible = true;
            this.colHU_CREATE_DTTM.VisibleIndex = 10;
            // 
            // colHU_CREATE_USER_ID
            // 
            this.colHU_CREATE_USER_ID.FieldName = "HU_CREATE_USER_ID";
            this.colHU_CREATE_USER_ID.Name = "colHU_CREATE_USER_ID";
            this.colHU_CREATE_USER_ID.Visible = true;
            this.colHU_CREATE_USER_ID.VisibleIndex = 11;
            // 
            // colWHHU_CREATE_DTTM
            // 
            this.colWHHU_CREATE_DTTM.FieldName = "WHHU_CREATE_DTTM";
            this.colWHHU_CREATE_DTTM.Name = "colWHHU_CREATE_DTTM";
            this.colWHHU_CREATE_DTTM.Visible = true;
            this.colWHHU_CREATE_DTTM.VisibleIndex = 12;
            // 
            // colWHHU_CREATE_USER_ID
            // 
            this.colWHHU_CREATE_USER_ID.FieldName = "WHHU_CREATE_USER_ID";
            this.colWHHU_CREATE_USER_ID.Name = "colWHHU_CREATE_USER_ID";
            this.colWHHU_CREATE_USER_ID.Visible = true;
            this.colWHHU_CREATE_USER_ID.VisibleIndex = 13;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 14;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 15;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 16;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 17;
            // 
            // WhHuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WhHuList";
            this.Text = "WhHuList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhHuList_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whHuModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private System.Windows.Forms.BindingSource whHuModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_INIT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_STOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_CREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_CREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colWHHU_CREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colWHHU_CREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
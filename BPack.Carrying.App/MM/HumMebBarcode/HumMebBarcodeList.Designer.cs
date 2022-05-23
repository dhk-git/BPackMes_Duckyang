
namespace BPack.Carrying.App.MM.HumMebBarcode
{
    partial class HumMebBarcodeList
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
            this.humMebBarcodeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBARCODE_TEXT_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_MEB_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINIT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCASE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDER_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPACK_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIP_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humMebBarcodeModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.humMebBarcodeModelBindingSource;
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
            this.colBARCODE_TEXT_KEY,
            this.colBARCODE_TEXT,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colHU_MEB_TYPE,
            this.colINIT_QTY,
            this.colCASE_NO,
            this.colORDER_NO,
            this.colLOT,
            this.colPACK_DATE,
            this.colSHIP_DATE,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // humMebBarcodeModelBindingSource
            // 
            this.humMebBarcodeModelBindingSource.DataSource = typeof(BPack.Model.App.MM.HumMebBarcode.HumMebBarcodeModel);
            // 
            // colBARCODE_TEXT_KEY
            // 
            this.colBARCODE_TEXT_KEY.FieldName = "BARCODE_TEXT_KEY";
            this.colBARCODE_TEXT_KEY.Name = "colBARCODE_TEXT_KEY";
            this.colBARCODE_TEXT_KEY.OptionsColumn.ReadOnly = true;
            this.colBARCODE_TEXT_KEY.Visible = true;
            this.colBARCODE_TEXT_KEY.VisibleIndex = 0;
            // 
            // colBARCODE_TEXT
            // 
            this.colBARCODE_TEXT.FieldName = "BARCODE_TEXT";
            this.colBARCODE_TEXT.Name = "colBARCODE_TEXT";
            this.colBARCODE_TEXT.Visible = true;
            this.colBARCODE_TEXT.VisibleIndex = 1;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 2;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 3;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 4;
            // 
            // colHU_MEB_TYPE
            // 
            this.colHU_MEB_TYPE.FieldName = "HU_MEB_TYPE";
            this.colHU_MEB_TYPE.Name = "colHU_MEB_TYPE";
            this.colHU_MEB_TYPE.Visible = true;
            this.colHU_MEB_TYPE.VisibleIndex = 5;
            // 
            // colINIT_QTY
            // 
            this.colINIT_QTY.FieldName = "INIT_QTY";
            this.colINIT_QTY.Name = "colINIT_QTY";
            this.colINIT_QTY.Visible = true;
            this.colINIT_QTY.VisibleIndex = 6;
            // 
            // colCASE_NO
            // 
            this.colCASE_NO.FieldName = "CASE_NO";
            this.colCASE_NO.Name = "colCASE_NO";
            this.colCASE_NO.Visible = true;
            this.colCASE_NO.VisibleIndex = 7;
            // 
            // colORDER_NO
            // 
            this.colORDER_NO.FieldName = "ORDER_NO";
            this.colORDER_NO.Name = "colORDER_NO";
            this.colORDER_NO.Visible = true;
            this.colORDER_NO.VisibleIndex = 8;
            // 
            // colLOT
            // 
            this.colLOT.FieldName = "LOT";
            this.colLOT.Name = "colLOT";
            this.colLOT.Visible = true;
            this.colLOT.VisibleIndex = 9;
            // 
            // colPACK_DATE
            // 
            this.colPACK_DATE.FieldName = "PACK_DATE";
            this.colPACK_DATE.Name = "colPACK_DATE";
            this.colPACK_DATE.Visible = true;
            this.colPACK_DATE.VisibleIndex = 10;
            // 
            // colSHIP_DATE
            // 
            this.colSHIP_DATE.FieldName = "SHIP_DATE";
            this.colSHIP_DATE.Name = "colSHIP_DATE";
            this.colSHIP_DATE.Visible = true;
            this.colSHIP_DATE.VisibleIndex = 11;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 12;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 13;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 14;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 15;
            // 
            // HumMebBarcodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "HumMebBarcodeList";
            this.Text = "HumMebBarcodeList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humMebBarcodeModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource humMebBarcodeModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_TEXT_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_TEXT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_MEB_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colINIT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colCASE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colORDER_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colLOT;
        private DevExpress.XtraGrid.Columns.GridColumn colPACK_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIP_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
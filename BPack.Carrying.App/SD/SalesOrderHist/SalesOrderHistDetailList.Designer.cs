
namespace BPack.Carrying.App.SD.SalesOrderHist
{
    partial class SalesOrderHistDetailList
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
            this.dlvOrderDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOR_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOR_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOM_PO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOD_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOD_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURRENCY_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUE_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrderDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.dlvOrderDetailModelBindingSource;
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
            // dlvOrderDetailModelBindingSource
            // 
            this.dlvOrderDetailModelBindingSource.DataSource = typeof(BPack.Model.App.SD.SalesOrderHist.SalesOrderHistDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOR_DT,
            this.colSOR_NO,
            this.colBP_CD,
            this.colBP_NM,
            this.colCUSTOM_PO_NO,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_SPEC,
            this.colITEM_GR_1,
            this.colSOD_QTY,
            this.colSOD_PRICE,
            this.colCOST,
            this.colCURRENCY_TYPE,
            this.colDUE_DT,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSOR_DT
            // 
            this.colSOR_DT.FieldName = "SOR_DT";
            this.colSOR_DT.Name = "colSOR_DT";
            this.colSOR_DT.Visible = true;
            this.colSOR_DT.VisibleIndex = 0;
            // 
            // colSOR_NO
            // 
            this.colSOR_NO.FieldName = "SOR_NO";
            this.colSOR_NO.Name = "colSOR_NO";
            this.colSOR_NO.Visible = true;
            this.colSOR_NO.VisibleIndex = 1;
            // 
            // colBP_CD
            // 
            this.colBP_CD.FieldName = "BP_CD";
            this.colBP_CD.Name = "colBP_CD";
            this.colBP_CD.Visible = true;
            this.colBP_CD.VisibleIndex = 2;
            // 
            // colBP_NM
            // 
            this.colBP_NM.FieldName = "BP_NM";
            this.colBP_NM.Name = "colBP_NM";
            this.colBP_NM.Visible = true;
            this.colBP_NM.VisibleIndex = 3;
            // 
            // colCUSTOM_PO_NO
            // 
            this.colCUSTOM_PO_NO.FieldName = "CUSTOM_PO_NO";
            this.colCUSTOM_PO_NO.Name = "colCUSTOM_PO_NO";
            this.colCUSTOM_PO_NO.Visible = true;
            this.colCUSTOM_PO_NO.VisibleIndex = 4;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 5;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 6;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 7;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 8;
            // 
            // colITEM_SPEC
            // 
            this.colITEM_SPEC.FieldName = "ITEM_SPEC";
            this.colITEM_SPEC.Name = "colITEM_SPEC";
            this.colITEM_SPEC.Visible = true;
            this.colITEM_SPEC.VisibleIndex = 9;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 10;
            // 
            // colSOD_QTY
            // 
            this.colSOD_QTY.FieldName = "SOD_QTY";
            this.colSOD_QTY.Name = "colSOD_QTY";
            this.colSOD_QTY.Visible = true;
            this.colSOD_QTY.VisibleIndex = 11;
            // 
            // colSOD_PRICE
            // 
            this.colSOD_PRICE.FieldName = "SOD_PRICE";
            this.colSOD_PRICE.Name = "colSOD_PRICE";
            this.colSOD_PRICE.Visible = true;
            this.colSOD_PRICE.VisibleIndex = 12;
            // 
            // colCOST
            // 
            this.colCOST.FieldName = "COST";
            this.colCOST.Name = "colCOST";
            this.colCOST.Visible = true;
            this.colCOST.VisibleIndex = 13;
            // 
            // colCURRENCY_TYPE
            // 
            this.colCURRENCY_TYPE.FieldName = "CURRENCY_TYPE";
            this.colCURRENCY_TYPE.Name = "colCURRENCY_TYPE";
            this.colCURRENCY_TYPE.Visible = true;
            this.colCURRENCY_TYPE.VisibleIndex = 14;
            // 
            // colDUE_DT
            // 
            this.colDUE_DT.FieldName = "DUE_DT";
            this.colDUE_DT.Name = "colDUE_DT";
            this.colDUE_DT.Visible = true;
            this.colDUE_DT.VisibleIndex = 15;
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
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 19;
            // 
            // SalesOrderHistDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "SalesOrderHistDetailList";
            this.Text = "SalesOrderHistDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrderDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dlvOrderDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSOR_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOR_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSTOM_PO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOST;
        private DevExpress.XtraGrid.Columns.GridColumn colCURRENCY_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colDUE_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
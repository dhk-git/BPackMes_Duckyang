namespace BPack.Carrying.App.MD.ItmPurchase
{
    partial class ItmPurchaseList
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
            this.itmPurchaseModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_PURCHASE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_SALES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itmPurchaseModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.itmPurchaseModelBindingSource;
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
            // itmPurchaseModelBindingSource
            // 
            this.itmPurchaseModelBindingSource.DataSource = typeof(BPack.Model.App.MD.ItmPurchase.ItmPurchaseModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colCOMP_CD,
            this.colBP_CD_KEY,
            this.colBP_CD,
            this.colBP_NM,
            this.colIS_PURCHASE,
            this.colIS_SALES,
            this.colADDR,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD_KEY.Visible = true;
            this.colCOMP_CD_KEY.VisibleIndex = 0;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 1;
            // 
            // colBP_CD_KEY
            // 
            this.colBP_CD_KEY.FieldName = "BP_CD_KEY";
            this.colBP_CD_KEY.Name = "colBP_CD_KEY";
            this.colBP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colBP_CD_KEY.Visible = true;
            this.colBP_CD_KEY.VisibleIndex = 2;
            // 
            // colBP_CD
            // 
            this.colBP_CD.FieldName = "BP_CD";
            this.colBP_CD.Name = "colBP_CD";
            this.colBP_CD.Visible = true;
            this.colBP_CD.VisibleIndex = 3;
            // 
            // colBP_NM
            // 
            this.colBP_NM.FieldName = "BP_NM";
            this.colBP_NM.Name = "colBP_NM";
            this.colBP_NM.Visible = true;
            this.colBP_NM.VisibleIndex = 4;
            // 
            // colIS_PURCHASE
            // 
            this.colIS_PURCHASE.FieldName = "IS_PURCHASE";
            this.colIS_PURCHASE.Name = "colIS_PURCHASE";
            this.colIS_PURCHASE.Visible = true;
            this.colIS_PURCHASE.VisibleIndex = 5;
            // 
            // colIS_SALES
            // 
            this.colIS_SALES.FieldName = "IS_SALES";
            this.colIS_SALES.Name = "colIS_SALES";
            this.colIS_SALES.Visible = true;
            this.colIS_SALES.VisibleIndex = 6;
            // 
            // colADDR
            // 
            this.colADDR.FieldName = "ADDR";
            this.colADDR.Name = "colADDR";
            this.colADDR.Visible = true;
            this.colADDR.VisibleIndex = 7;
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
            // ItmPurchaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ItmPurchaseList";
            this.Text = "PlantList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itmPurchaseModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource itmPurchaseModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_PURCHASE;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_SALES;
        private DevExpress.XtraGrid.Columns.GridColumn colADDR;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
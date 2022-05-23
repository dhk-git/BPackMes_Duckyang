
namespace BPack.Carrying.App.PO.PurOrderInp
{
    partial class PurOrderInpList
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPOH_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOD_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIN_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIFF_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASE_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.bindingSource1;
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
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(BPack.Model.App.PO.PurOrderInp.PurOrderInpModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPOH_DT,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colPOD_QTY,
            this.colIN_QTY,
            this.colDIFF_QTY,
            this.colBASE_UNIT,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPOH_DT
            // 
            this.colPOH_DT.FieldName = "POH_DT";
            this.colPOH_DT.Name = "colPOH_DT";
            this.colPOH_DT.Visible = true;
            this.colPOH_DT.VisibleIndex = 0;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 1;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 2;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 3;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 4;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 5;
            // 
            // colPOD_QTY
            // 
            this.colPOD_QTY.FieldName = "POD_QTY";
            this.colPOD_QTY.Name = "colPOD_QTY";
            this.colPOD_QTY.Visible = true;
            this.colPOD_QTY.VisibleIndex = 6;
            // 
            // colIN_QTY
            // 
            this.colIN_QTY.FieldName = "IN_QTY";
            this.colIN_QTY.Name = "colIN_QTY";
            this.colIN_QTY.Visible = true;
            this.colIN_QTY.VisibleIndex = 7;
            // 
            // colDIFF_QTY
            // 
            this.colDIFF_QTY.FieldName = "DIFF_QTY";
            this.colDIFF_QTY.Name = "colDIFF_QTY";
            this.colDIFF_QTY.Visible = true;
            this.colDIFF_QTY.VisibleIndex = 8;
            // 
            // colBASE_UNIT
            // 
            this.colBASE_UNIT.FieldName = "BASE_UNIT";
            this.colBASE_UNIT.Name = "colBASE_UNIT";
            this.colBASE_UNIT.Visible = true;
            this.colBASE_UNIT.VisibleIndex = 9;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 10;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 11;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 12;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 13;
            // 
            // PurOrderInpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "PurOrderInpList";
            this.Text = "PurOrderInpList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colPOH_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colPOD_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colIN_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colDIFF_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colBASE_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
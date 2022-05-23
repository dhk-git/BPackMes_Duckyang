namespace BPack.Carrying.App.MM.HumLotTracking
{
    partial class HumDetailReverseList
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
            this.strapTreeList1 = new BPack.Strap.TreeList.StrapTreeList();
            this.colLV = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colP_HU_NO = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_HU_NO = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSORT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colHU_BARCODE = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colITEM_CD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colITEM_NM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colITEM_GR_1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colALC_CD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUSED_QTY = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colWORK_DT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLOT_NO = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRowState = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCrudCls = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSelectedCheck = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsCheck = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.humDetailReverseModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humDetailReverseModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapTreeList1
            // 
            this.strapTreeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colLV,
            this.colP_HU_NO,
            this.colC_HU_NO,
            this.colSORT,
            this.colHU_BARCODE,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colALC_CD,
            this.colUSED_QTY,
            this.colWORK_DT,
            this.colLOT_NO,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.strapTreeList1.DataSource = this.humDetailReverseModelBindingSource;
            this.strapTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapTreeList1.IsStrapGridViewDefaultSetting = true;
            this.strapTreeList1.KeyFieldName = "TREE_ID";
            this.strapTreeList1.Location = new System.Drawing.Point(0, 0);
            this.strapTreeList1.Name = "strapTreeList1";
            this.strapTreeList1.OptionsView.AutoWidth = false;
            this.strapTreeList1.ParentFieldName = "PARENT_ID";
            this.strapTreeList1.RootValue = "ROOT";
            this.strapTreeList1.SelectedModel = null;
            this.strapTreeList1.SelectedModelIndex = null;
            this.strapTreeList1.SelectedNode = null;
            this.strapTreeList1.Size = new System.Drawing.Size(800, 450);
            this.strapTreeList1.TabIndex = 0;
            // 
            // colLV
            // 
            this.colLV.FieldName = "LV";
            this.colLV.Name = "colLV";
            this.colLV.Visible = true;
            this.colLV.VisibleIndex = 0;
            // 
            // colP_HU_NO
            // 
            this.colP_HU_NO.FieldName = "P_HU_NO";
            this.colP_HU_NO.Name = "colP_HU_NO";
            // 
            // colC_HU_NO
            // 
            this.colC_HU_NO.FieldName = "C_HU_NO";
            this.colC_HU_NO.Name = "colC_HU_NO";
            this.colC_HU_NO.Visible = true;
            this.colC_HU_NO.VisibleIndex = 6;
            // 
            // colSORT
            // 
            this.colSORT.FieldName = "SORT";
            this.colSORT.Name = "colSORT";
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 5;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 1;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 2;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            // 
            // colUSED_QTY
            // 
            this.colUSED_QTY.FieldName = "USED_QTY";
            this.colUSED_QTY.Name = "colUSED_QTY";
            this.colUSED_QTY.Visible = true;
            this.colUSED_QTY.VisibleIndex = 3;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            // 
            // colLOT_NO
            // 
            this.colLOT_NO.FieldName = "LOT_NO";
            this.colLOT_NO.Name = "colLOT_NO";
            this.colLOT_NO.Visible = true;
            this.colLOT_NO.VisibleIndex = 4;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            // 
            // humDetailReverseModelBindingSource
            // 
            this.humDetailReverseModelBindingSource.DataSource = typeof(BPack.Model.App.MM.HumLotTracking.HumDetailReverseModel);
            // 
            // HumDetailReverseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapTreeList1);
            this.Name = "HumDetailReverseList";
            this.Text = "HumDetailReverseList";
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humDetailReverseModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.TreeList.StrapTreeList strapTreeList1;
        private System.Windows.Forms.BindingSource humDetailReverseModelBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLV;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colP_HU_NO;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_HU_NO;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSORT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colHU_BARCODE;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colITEM_CD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colITEM_NM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colITEM_GR_1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colALC_CD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUSED_QTY;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colWORK_DT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRowState;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCrudCls;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSelectedCheck;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsCheck;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLOT_NO;
    }
}
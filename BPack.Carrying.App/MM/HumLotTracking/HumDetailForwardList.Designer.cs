namespace BPack.Carrying.App.MM.HumLotTracking
{
    partial class HumDetailForwardList
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
            this.colBODY_NO = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPBS_SEQ = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRowState = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCrudCls = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSelectedCheck = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsCheck = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.humDetailForwardModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humDetailForwardModelBindingSource)).BeginInit();
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
            this.colBODY_NO,
            this.colPBS_SEQ,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.strapTreeList1.DataSource = this.humDetailForwardModelBindingSource;
            this.strapTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapTreeList1.IsStrapGridViewDefaultSetting = true;
            this.strapTreeList1.KeyFieldName = "TREE_ID";
            this.strapTreeList1.Location = new System.Drawing.Point(0, 0);
            this.strapTreeList1.Name = "strapTreeList1";
            this.strapTreeList1.OptionsView.ShowSummaryFooter = true;
            this.strapTreeList1.ParentFieldName = "PARENT_ID";
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
            this.colC_HU_NO.VisibleIndex = 10;
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
            this.colHU_BARCODE.VisibleIndex = 1;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 2;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 3;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 4;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 5;
            // 
            // colUSED_QTY
            // 
            this.colUSED_QTY.FieldName = "USED_QTY";
            this.colUSED_QTY.Name = "colUSED_QTY";
            this.colUSED_QTY.Visible = true;
            this.colUSED_QTY.VisibleIndex = 6;
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
            this.colLOT_NO.VisibleIndex = 7;
            // 
            // colBODY_NO
            // 
            this.colBODY_NO.FieldName = "BODY_NO";
            this.colBODY_NO.Name = "colBODY_NO";
            this.colBODY_NO.Visible = true;
            this.colBODY_NO.VisibleIndex = 8;
            // 
            // colPBS_SEQ
            // 
            this.colPBS_SEQ.FieldName = "PBS_SEQ";
            this.colPBS_SEQ.Name = "colPBS_SEQ";
            this.colPBS_SEQ.Visible = true;
            this.colPBS_SEQ.VisibleIndex = 9;
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
            // humDetailForwardModelBindingSource
            // 
            this.humDetailForwardModelBindingSource.DataSource = typeof(BPack.Model.App.MM.HumLotTracking.HumDetailForwardModel);
            // 
            // HumDetailForwardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapTreeList1);
            this.Name = "HumDetailForwardList";
            this.Text = "HumDetailFowardList";
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humDetailForwardModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.TreeList.StrapTreeList strapTreeList1;
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
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLOT_NO;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRowState;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCrudCls;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSelectedCheck;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsCheck;
        private System.Windows.Forms.BindingSource humDetailForwardModelBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBODY_NO;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPBS_SEQ;
    }
}
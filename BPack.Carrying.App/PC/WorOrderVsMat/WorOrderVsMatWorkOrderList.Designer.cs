namespace BPack.Carrying.App.PC.WorOrderVsMat
{
    partial class WorOrderVsMatWorkOrderList
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
            this.worOrderVsMatWorkOrderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWOR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colE_TIME_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worOrderVsMatWorkOrderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.worOrderVsMatWorkOrderModelBindingSource;
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
            // worOrderVsMatWorkOrderModelBindingSource
            // 
            this.worOrderVsMatWorkOrderModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WorOrderVsMat.WorOrderVsMatWorkOrderModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWC_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_SPEC,
            this.colITEM_TYPE,
            this.colITEM_GR_1,
            this.colITEM_GR_2,
            this.colITEM_GR_3,
            this.colALC_CD,
            this.colWOR_QTY,
            this.colA_TIME_QTY,
            this.colB_TIME_QTY,
            this.colC_TIME_QTY,
            this.colD_TIME_QTY,
            this.colE_TIME_QTY,
            this.colWO_DT,
            this.colWO_NO,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
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
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 3;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 4;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 5;
            // 
            // colITEM_SPEC
            // 
            this.colITEM_SPEC.FieldName = "ITEM_SPEC";
            this.colITEM_SPEC.Name = "colITEM_SPEC";
            this.colITEM_SPEC.Visible = true;
            this.colITEM_SPEC.VisibleIndex = 6;
            // 
            // colITEM_TYPE
            // 
            this.colITEM_TYPE.FieldName = "ITEM_TYPE";
            this.colITEM_TYPE.Name = "colITEM_TYPE";
            this.colITEM_TYPE.Visible = true;
            this.colITEM_TYPE.VisibleIndex = 7;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 8;
            // 
            // colITEM_GR_2
            // 
            this.colITEM_GR_2.FieldName = "ITEM_GR_2";
            this.colITEM_GR_2.Name = "colITEM_GR_2";
            this.colITEM_GR_2.Visible = true;
            this.colITEM_GR_2.VisibleIndex = 9;
            // 
            // colITEM_GR_3
            // 
            this.colITEM_GR_3.FieldName = "ITEM_GR_3";
            this.colITEM_GR_3.Name = "colITEM_GR_3";
            this.colITEM_GR_3.Visible = true;
            this.colITEM_GR_3.VisibleIndex = 10;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 11;
            // 
            // colWOR_QTY
            // 
            this.colWOR_QTY.FieldName = "WOR_QTY";
            this.colWOR_QTY.Name = "colWOR_QTY";
            this.colWOR_QTY.Visible = true;
            this.colWOR_QTY.VisibleIndex = 12;
            // 
            // colA_TIME_QTY
            // 
            this.colA_TIME_QTY.FieldName = "A_TIME_QTY";
            this.colA_TIME_QTY.Name = "colA_TIME_QTY";
            this.colA_TIME_QTY.Visible = true;
            this.colA_TIME_QTY.VisibleIndex = 13;
            // 
            // colB_TIME_QTY
            // 
            this.colB_TIME_QTY.FieldName = "B_TIME_QTY";
            this.colB_TIME_QTY.Name = "colB_TIME_QTY";
            this.colB_TIME_QTY.Visible = true;
            this.colB_TIME_QTY.VisibleIndex = 14;
            // 
            // colC_TIME_QTY
            // 
            this.colC_TIME_QTY.FieldName = "C_TIME_QTY";
            this.colC_TIME_QTY.Name = "colC_TIME_QTY";
            this.colC_TIME_QTY.Visible = true;
            this.colC_TIME_QTY.VisibleIndex = 15;
            // 
            // colD_TIME_QTY
            // 
            this.colD_TIME_QTY.FieldName = "D_TIME_QTY";
            this.colD_TIME_QTY.Name = "colD_TIME_QTY";
            this.colD_TIME_QTY.Visible = true;
            this.colD_TIME_QTY.VisibleIndex = 16;
            // 
            // colE_TIME_QTY
            // 
            this.colE_TIME_QTY.FieldName = "E_TIME_QTY";
            this.colE_TIME_QTY.Name = "colE_TIME_QTY";
            this.colE_TIME_QTY.Visible = true;
            this.colE_TIME_QTY.VisibleIndex = 17;
            // 
            // colWO_DT
            // 
            this.colWO_DT.FieldName = "WO_DT";
            this.colWO_DT.Name = "colWO_DT";
            this.colWO_DT.Visible = true;
            this.colWO_DT.VisibleIndex = 18;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 19;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 20;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 21;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 22;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 23;
            // 
            // WorOrderVsMatWorkOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WorOrderVsMatWorkOrderList";
            this.Text = "WorOrderVsMatWorkOrderList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worOrderVsMatWorkOrderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public Strap.Grid.StrapGridControl strapGridControl1;
        private System.Windows.Forms.BindingSource worOrderVsMatWorkOrderModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_2;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_3;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWOR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colA_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colB_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colC_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colD_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colE_TIME_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
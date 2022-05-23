namespace BPack.Carrying.App.SD.DlvHist
{
    partial class DlvHistList
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
            this.dlvHistModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colREQ_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGATE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_PLC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIFF_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvHistModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.dlvHistModelBindingSource;
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
            // dlvHistModelBindingSource
            // 
            this.dlvHistModelBindingSource.DataSource = typeof(BPack.Model.App.SD.DlvHist.DlvHistModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colREQ_DT,
            this.colDLV_DT,
            this.colGATE_CD,
            this.colDLV_PLC_CD,
            this.colDLV_TYPE,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colITEM_GR_2,
            this.colALC_CD,
            this.colDO_QTY,
            this.colDR_QTY,
            this.colDIFF_QTY,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colREQ_DT
            // 
            this.colREQ_DT.FieldName = "REQ_DT";
            this.colREQ_DT.Name = "colREQ_DT";
            this.colREQ_DT.Visible = true;
            this.colREQ_DT.VisibleIndex = 0;
            // 
            // colDLV_DT
            // 
            this.colDLV_DT.FieldName = "DLV_DT";
            this.colDLV_DT.Name = "colDLV_DT";
            this.colDLV_DT.Visible = true;
            this.colDLV_DT.VisibleIndex = 1;
            // 
            // colGATE_CD
            // 
            this.colGATE_CD.FieldName = "GATE_CD";
            this.colGATE_CD.Name = "colGATE_CD";
            this.colGATE_CD.Visible = true;
            this.colGATE_CD.VisibleIndex = 2;
            // 
            // colDLV_PLC_CD
            // 
            this.colDLV_PLC_CD.FieldName = "DLV_PLC_CD";
            this.colDLV_PLC_CD.Name = "colDLV_PLC_CD";
            this.colDLV_PLC_CD.Visible = true;
            this.colDLV_PLC_CD.VisibleIndex = 3;
            // 
            // colDLV_TYPE
            // 
            this.colDLV_TYPE.FieldName = "DLV_TYPE";
            this.colDLV_TYPE.Name = "colDLV_TYPE";
            this.colDLV_TYPE.Visible = true;
            this.colDLV_TYPE.VisibleIndex = 4;
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
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 9;
            // 
            // colITEM_GR_2
            // 
            this.colITEM_GR_2.FieldName = "ITEM_GR_2";
            this.colITEM_GR_2.Name = "colITEM_GR_2";
            this.colITEM_GR_2.Visible = true;
            this.colITEM_GR_2.VisibleIndex = 10;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 11;
            // 
            // colDO_QTY
            // 
            this.colDO_QTY.FieldName = "DO_QTY";
            this.colDO_QTY.Name = "colDO_QTY";
            this.colDO_QTY.Visible = true;
            this.colDO_QTY.VisibleIndex = 12;
            // 
            // colDR_QTY
            // 
            this.colDR_QTY.FieldName = "DR_QTY";
            this.colDR_QTY.Name = "colDR_QTY";
            this.colDR_QTY.Visible = true;
            this.colDR_QTY.VisibleIndex = 13;
            // 
            // colDIFF_QTY
            // 
            this.colDIFF_QTY.FieldName = "DIFF_QTY";
            this.colDIFF_QTY.Name = "colDIFF_QTY";
            this.colDIFF_QTY.Visible = true;
            this.colDIFF_QTY.VisibleIndex = 14;
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
            // DlvHistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "DlvHistList";
            this.Text = "DlvHistList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvHistModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dlvHistModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colREQ_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colGATE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_PLC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_2;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colDR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colDIFF_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
namespace BPack.Carrying.App.MM.GirHist
{
    partial class GirHistList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.strapGridControl1 = new BPack.Strap.Grid.StrapGridControl();
            this.girHistModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIR_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIR_TYPE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFROM_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFROM_WH_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTO_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTO_WH_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_TYPE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGI_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_DOC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_DOC_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girHistModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.girHistModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(816, 492);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.StrapMdiForm = null;
            this.strapGridControl1.StrapSubForm = null;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // girHistModelBindingSource
            // 
            this.girHistModelBindingSource.DataSource = typeof(BPack.Model.App.MM.GirHist.GirHistModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colGIR_DT,
            this.colCREATE_DTTM,
            this.colWH_CD,
            this.colWH_NM,
            this.colGIR_TYPE_CD,
            this.colFROM_WH_CD,
            this.colFROM_WH_NM,
            this.colTO_WH_CD,
            this.colTO_WH_NM,
            this.colITEM_TYPE_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colGR_QTY,
            this.colGI_QTY,
            this.colREF_DOC_TYPE,
            this.colREF_DOC_NO,
            this.colHU_NO,
            this.colHU_BARCODE,
            this.colREMARK,
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
            // colGIR_DT
            // 
            this.colGIR_DT.FieldName = "GIR_DT";
            this.colGIR_DT.Name = "colGIR_DT";
            this.colGIR_DT.Visible = true;
            this.colGIR_DT.VisibleIndex = 2;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 3;
            // 
            // colWH_CD
            // 
            this.colWH_CD.FieldName = "WH_CD";
            this.colWH_CD.Name = "colWH_CD";
            this.colWH_CD.Visible = true;
            this.colWH_CD.VisibleIndex = 4;
            // 
            // colWH_NM
            // 
            this.colWH_NM.FieldName = "WH_NM";
            this.colWH_NM.Name = "colWH_NM";
            this.colWH_NM.Visible = true;
            this.colWH_NM.VisibleIndex = 5;
            // 
            // colGIR_TYPE_CD
            // 
            this.colGIR_TYPE_CD.FieldName = "GIR_TYPE_CD";
            this.colGIR_TYPE_CD.Name = "colGIR_TYPE_CD";
            this.colGIR_TYPE_CD.Visible = true;
            this.colGIR_TYPE_CD.VisibleIndex = 6;
            // 
            // colFROM_WH_CD
            // 
            this.colFROM_WH_CD.FieldName = "FROM_WH_CD";
            this.colFROM_WH_CD.Name = "colFROM_WH_CD";
            this.colFROM_WH_CD.Visible = true;
            this.colFROM_WH_CD.VisibleIndex = 7;
            // 
            // colFROM_WH_NM
            // 
            this.colFROM_WH_NM.FieldName = "FROM_WH_NM";
            this.colFROM_WH_NM.Name = "colFROM_WH_NM";
            this.colFROM_WH_NM.Visible = true;
            this.colFROM_WH_NM.VisibleIndex = 8;
            // 
            // colTO_WH_CD
            // 
            this.colTO_WH_CD.FieldName = "TO_WH_CD";
            this.colTO_WH_CD.Name = "colTO_WH_CD";
            this.colTO_WH_CD.Visible = true;
            this.colTO_WH_CD.VisibleIndex = 9;
            // 
            // colTO_WH_NM
            // 
            this.colTO_WH_NM.FieldName = "TO_WH_NM";
            this.colTO_WH_NM.Name = "colTO_WH_NM";
            this.colTO_WH_NM.Visible = true;
            this.colTO_WH_NM.VisibleIndex = 10;
            // 
            // colITEM_TYPE_CD
            // 
            this.colITEM_TYPE_CD.FieldName = "ITEM_TYPE_CD";
            this.colITEM_TYPE_CD.Name = "colITEM_TYPE_CD";
            this.colITEM_TYPE_CD.Visible = true;
            this.colITEM_TYPE_CD.VisibleIndex = 11;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 12;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 13;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 14;
            // 
            // colGR_QTY
            // 
            this.colGR_QTY.FieldName = "GR_QTY";
            this.colGR_QTY.Name = "colGR_QTY";
            this.colGR_QTY.Visible = true;
            this.colGR_QTY.VisibleIndex = 15;
            // 
            // colGI_QTY
            // 
            this.colGI_QTY.FieldName = "GI_QTY";
            this.colGI_QTY.Name = "colGI_QTY";
            this.colGI_QTY.Visible = true;
            this.colGI_QTY.VisibleIndex = 16;
            // 
            // colREF_DOC_TYPE
            // 
            this.colREF_DOC_TYPE.FieldName = "REF_DOC_TYPE";
            this.colREF_DOC_TYPE.Name = "colREF_DOC_TYPE";
            this.colREF_DOC_TYPE.Visible = true;
            this.colREF_DOC_TYPE.VisibleIndex = 17;
            // 
            // colREF_DOC_NO
            // 
            this.colREF_DOC_NO.FieldName = "REF_DOC_NO";
            this.colREF_DOC_NO.Name = "colREF_DOC_NO";
            this.colREF_DOC_NO.Visible = true;
            this.colREF_DOC_NO.VisibleIndex = 18;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 19;
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 20;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 21;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 22;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 23;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 24;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 25;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 26;
            // 
            // GirHistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 492);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "GirHistList";
            this.Text = "GirHistList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girHistModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource girHistModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGIR_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colGIR_TYPE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colFROM_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colFROM_WH_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colTO_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colTO_WH_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colGR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colGI_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_DOC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_DOC_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
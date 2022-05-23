
namespace BPack.Carrying.App.PC.WoeResultPivot
{
    partial class ResultEachList
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
            this.resultEachModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_TYPE_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_INIT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOK_NG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultEachModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.resultEachModelBindingSource;
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
            // resultEachModelBindingSource
            // 
            this.resultEachModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WoeResultPivot.ResultEachModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWORK_DT,
            this.colCREATE_DTTM,
            this.colSHIFT_CD,
            this.colSHIFT_NM,
            this.colWORK_TM,
            this.colWC_CD,
            this.colWC_NM,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colALC_CD,
            this.colITEM_TYPE_NM,
            this.colHU_INIT_QTY,
            this.colOK_NG,
            this.colHU_BARCODE,
            this.colHU_NO,
            this.colRST_NO,
            this.colWO_NO,
            this.colWO_DT,
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
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 2;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 3;
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            this.colSHIFT_CD.Visible = true;
            this.colSHIFT_CD.VisibleIndex = 4;
            // 
            // colSHIFT_NM
            // 
            this.colSHIFT_NM.FieldName = "SHIFT_NM";
            this.colSHIFT_NM.Name = "colSHIFT_NM";
            this.colSHIFT_NM.Visible = true;
            this.colSHIFT_NM.VisibleIndex = 5;
            // 
            // colWORK_TM
            // 
            this.colWORK_TM.FieldName = "WORK_TM";
            this.colWORK_TM.Name = "colWORK_TM";
            this.colWORK_TM.Visible = true;
            this.colWORK_TM.VisibleIndex = 6;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 7;
            // 
            // colWC_NM
            // 
            this.colWC_NM.FieldName = "WC_NM";
            this.colWC_NM.Name = "colWC_NM";
            this.colWC_NM.Visible = true;
            this.colWC_NM.VisibleIndex = 8;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 9;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 10;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 11;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 12;
            // 
            // colITEM_TYPE_NM
            // 
            this.colITEM_TYPE_NM.FieldName = "ITEM_TYPE_NM";
            this.colITEM_TYPE_NM.Name = "colITEM_TYPE_NM";
            this.colITEM_TYPE_NM.Visible = true;
            this.colITEM_TYPE_NM.VisibleIndex = 13;
            // 
            // colHU_INIT_QTY
            // 
            this.colHU_INIT_QTY.FieldName = "HU_INIT_QTY";
            this.colHU_INIT_QTY.Name = "colHU_INIT_QTY";
            this.colHU_INIT_QTY.Visible = true;
            this.colHU_INIT_QTY.VisibleIndex = 14;
            // 
            // colOK_NG
            // 
            this.colOK_NG.FieldName = "OK_NG";
            this.colOK_NG.Name = "colOK_NG";
            this.colOK_NG.Visible = true;
            this.colOK_NG.VisibleIndex = 15;
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 16;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 17;
            // 
            // colRST_NO
            // 
            this.colRST_NO.FieldName = "RST_NO";
            this.colRST_NO.Name = "colRST_NO";
            this.colRST_NO.Visible = true;
            this.colRST_NO.VisibleIndex = 18;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 19;
            // 
            // colWO_DT
            // 
            this.colWO_DT.FieldName = "WO_DT";
            this.colWO_DT.Name = "colWO_DT";
            this.colWO_DT.Visible = true;
            this.colWO_DT.VisibleIndex = 20;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 21;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 22;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 23;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 24;
            // 
            // ResultEachList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ResultEachList";
            this.Text = "ResultEachList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultEachModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource resultEachModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_INIT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colOK_NG;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
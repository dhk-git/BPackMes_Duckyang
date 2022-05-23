namespace BPack.Carrying.App.PC.WoeRsltInfo
{
    partial class WorkResultList
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
            this.workResultModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_TYPE_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWOR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNG_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIFF_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOM_WO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workResultModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.workResultModelBindingSource;
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
            // workResultModelBindingSource
            // 
            this.workResultModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WoeRsltInfo.WorkResultModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWO_DT,
            this.colWORK_DT,
            this.colSHIFT_NM,
            this.colWC_CD,
            this.colWC_NM,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colITEM_GR_2,
            this.colALC_CD,
            this.colITEM_TYPE_NM,
            this.colWOR_QTY,
            this.colRST_QTY,
            this.colOK_QTY,
            this.colNG_QTY,
            this.colDIFF_QTY,
            this.colCUSTOM_WO_NO,
            this.colWO_NO,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colWO_DT
            // 
            this.colWO_DT.FieldName = "WO_DT";
            this.colWO_DT.Name = "colWO_DT";
            this.colWO_DT.Visible = true;
            this.colWO_DT.VisibleIndex = 0;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 1;
            // 
            // colSHIFT_NM
            // 
            this.colSHIFT_NM.FieldName = "SHIFT_NM";
            this.colSHIFT_NM.Name = "colSHIFT_NM";
            this.colSHIFT_NM.Visible = true;
            this.colSHIFT_NM.VisibleIndex = 2;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 3;
            // 
            // colWC_NM
            // 
            this.colWC_NM.FieldName = "WC_NM";
            this.colWC_NM.Name = "colWC_NM";
            this.colWC_NM.Visible = true;
            this.colWC_NM.VisibleIndex = 4;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 5;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 6;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 7;
            // 
            // colITEM_GR_2
            // 
            this.colITEM_GR_2.FieldName = "ITEM_GR_2";
            this.colITEM_GR_2.Name = "colITEM_GR_2";
            this.colITEM_GR_2.Visible = true;
            this.colITEM_GR_2.VisibleIndex = 8;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 9;
            // 
            // colITEM_TYPE_NM
            // 
            this.colITEM_TYPE_NM.FieldName = "ITEM_TYPE_NM";
            this.colITEM_TYPE_NM.Name = "colITEM_TYPE_NM";
            this.colITEM_TYPE_NM.Visible = true;
            this.colITEM_TYPE_NM.VisibleIndex = 10;
            // 
            // colWOR_QTY
            // 
            this.colWOR_QTY.FieldName = "WOR_QTY";
            this.colWOR_QTY.Name = "colWOR_QTY";
            this.colWOR_QTY.Visible = true;
            this.colWOR_QTY.VisibleIndex = 11;
            // 
            // colRST_QTY
            // 
            this.colRST_QTY.FieldName = "RST_QTY";
            this.colRST_QTY.Name = "colRST_QTY";
            this.colRST_QTY.Visible = true;
            this.colRST_QTY.VisibleIndex = 12;
            // 
            // colOK_QTY
            // 
            this.colOK_QTY.FieldName = "OK_QTY";
            this.colOK_QTY.Name = "colOK_QTY";
            this.colOK_QTY.Visible = true;
            this.colOK_QTY.VisibleIndex = 13;
            // 
            // colNG_QTY
            // 
            this.colNG_QTY.FieldName = "NG_QTY";
            this.colNG_QTY.Name = "colNG_QTY";
            this.colNG_QTY.Visible = true;
            this.colNG_QTY.VisibleIndex = 14;
            // 
            // colDIFF_QTY
            // 
            this.colDIFF_QTY.FieldName = "DIFF_QTY";
            this.colDIFF_QTY.Name = "colDIFF_QTY";
            this.colDIFF_QTY.Visible = true;
            this.colDIFF_QTY.VisibleIndex = 15;
            // 
            // colCUSTOM_WO_NO
            // 
            this.colCUSTOM_WO_NO.FieldName = "CUSTOM_WO_NO";
            this.colCUSTOM_WO_NO.Name = "colCUSTOM_WO_NO";
            this.colCUSTOM_WO_NO.Visible = true;
            this.colCUSTOM_WO_NO.VisibleIndex = 16;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 17;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 18;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 19;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 20;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 21;
            // 
            // WorkResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WorkResultList";
            this.Text = "WorkResultList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workResultModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource workResultModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_2;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWOR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colOK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colNG_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colDIFF_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSTOM_WO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
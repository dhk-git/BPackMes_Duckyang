
namespace BPack.Carrying.App.PC.NwtStatusInfo
{
    partial class NwtStatusInfoDayDetailList
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
            this.nwtStatusInfoListModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOWK_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOWK_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_HOURS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWK_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWK_SEQ_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwtStatusInfoListModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.nwtStatusInfoListModelBindingSource;
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
            // nwtStatusInfoListModelBindingSource
            // 
            this.nwtStatusInfoListModelBindingSource.DataSource = typeof(BPack.Model.App.PC.NwtStatusInfo.NwtStatusInfoListModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colCOMP_CD_KEY,
            this.colPLANT_CD_KEY,
            this.colWK_SEQ,
            this.colWK_SEQ_KEY,
            this.colWC_CD,
            this.colWC_NM,
            this.colWORK_DT,
            this.colSHIFT_CD,
            this.colSHIFT_NM,
            this.colWORK_STATUS,
            this.colNOWK_CD,
            this.colNOWK_NM,
            this.colWO_NO,
            this.colALC_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colSTART_DTTM,
            this.colEND_DTTM,
            this.colWORK_HOURS});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            // 
            // colWC_NM
            // 
            this.colWC_NM.FieldName = "WC_NM";
            this.colWC_NM.Name = "colWC_NM";
            this.colWC_NM.Visible = true;
            this.colWC_NM.VisibleIndex = 0;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 1;
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            // 
            // colSHIFT_NM
            // 
            this.colSHIFT_NM.FieldName = "SHIFT_NM";
            this.colSHIFT_NM.Name = "colSHIFT_NM";
            this.colSHIFT_NM.Visible = true;
            this.colSHIFT_NM.VisibleIndex = 2;
            // 
            // colWORK_STATUS
            // 
            this.colWORK_STATUS.FieldName = "WORK_STATUS";
            this.colWORK_STATUS.Name = "colWORK_STATUS";
            this.colWORK_STATUS.Visible = true;
            this.colWORK_STATUS.VisibleIndex = 3;
            // 
            // colNOWK_CD
            // 
            this.colNOWK_CD.FieldName = "NOWK_CD";
            this.colNOWK_CD.Name = "colNOWK_CD";
            // 
            // colNOWK_NM
            // 
            this.colNOWK_NM.FieldName = "NOWK_NM";
            this.colNOWK_NM.Name = "colNOWK_NM";
            this.colNOWK_NM.Visible = true;
            this.colNOWK_NM.VisibleIndex = 4;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 5;
            // 
            // colALC_CD
            // 
            this.colALC_CD.FieldName = "ALC_CD";
            this.colALC_CD.Name = "colALC_CD";
            this.colALC_CD.Visible = true;
            this.colALC_CD.VisibleIndex = 6;
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
            // colSTART_DTTM
            // 
            this.colSTART_DTTM.FieldName = "START_DTTM";
            this.colSTART_DTTM.Name = "colSTART_DTTM";
            this.colSTART_DTTM.Visible = true;
            this.colSTART_DTTM.VisibleIndex = 9;
            // 
            // colEND_DTTM
            // 
            this.colEND_DTTM.FieldName = "END_DTTM";
            this.colEND_DTTM.Name = "colEND_DTTM";
            this.colEND_DTTM.Visible = true;
            this.colEND_DTTM.VisibleIndex = 10;
            // 
            // colWORK_HOURS
            // 
            this.colWORK_HOURS.FieldName = "WORK_HOURS";
            this.colWORK_HOURS.Name = "colWORK_HOURS";
            this.colWORK_HOURS.Visible = true;
            this.colWORK_HOURS.VisibleIndex = 11;
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            // 
            // colPLANT_CD_KEY
            // 
            this.colPLANT_CD_KEY.FieldName = "PLANT_CD_KEY";
            this.colPLANT_CD_KEY.Name = "colPLANT_CD_KEY";
            // 
            // colWK_SEQ
            // 
            this.colWK_SEQ.FieldName = "WK_SEQ";
            this.colWK_SEQ.Name = "colWK_SEQ";
            // 
            // colWK_SEQ_KEY
            // 
            this.colWK_SEQ_KEY.FieldName = "WK_SEQ_KEY";
            this.colWK_SEQ_KEY.Name = "colWK_SEQ_KEY";
            // 
            // NwtStatusInfoDayDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "NwtStatusInfoDayDetailList";
            this.Text = "NwtStatusInfoDayDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwtStatusInfoListModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nwtStatusInfoListModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colNOWK_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colNOWK_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_HOURS;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colWK_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colWK_SEQ_KEY;
    }
}
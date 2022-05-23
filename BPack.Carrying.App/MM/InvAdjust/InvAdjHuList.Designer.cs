namespace BPack.Carrying.App.MM.InvAdjust
{
    partial class InvAdjHuList
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
            this.invAdjHuModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colINVD_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOGI_PARENT_HU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHYSI_PARENT_HU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOGI_STOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHYSI_STOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIFF_STOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINV_RSLT_HU_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANG_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invAdjHuModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.invAdjHuModelBindingSource;
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
            // invAdjHuModelBindingSource
            // 
            this.invAdjHuModelBindingSource.DataSource = typeof(BPack.Model.App.MM.InvAdjust.InvAdjHuModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colINVD_NO_KEY,
            this.colHU_NO_KEY,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colINVD_NO,
            this.colITEM_CD,
            this.colHU_NO,
            this.colLOGI_PARENT_HU_NO,
            this.colPHYSI_PARENT_HU_NO,
            this.colLOGI_STOCK,
            this.colPHYSI_STOCK,
            this.colDIFF_STOCK,
            this.colINV_RSLT_HU_STATUS,
            this.colHU_BARCODE,
            this.colDEL_FG,
            this.colREMARK,
            this.colMODIFY_DTTM,
            this.colMODIFY_USER_ID,
            this.colVALID,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colCREATE_DTTM,
            this.colCREATE_USER_ID,
            this.colLANG_CODE,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colINVD_NO_KEY
            // 
            this.colINVD_NO_KEY.FieldName = "INVD_NO_KEY";
            this.colINVD_NO_KEY.Name = "colINVD_NO_KEY";
            this.colINVD_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colINVD_NO_KEY.Visible = true;
            this.colINVD_NO_KEY.VisibleIndex = 0;
            // 
            // colHU_NO_KEY
            // 
            this.colHU_NO_KEY.FieldName = "HU_NO_KEY";
            this.colHU_NO_KEY.Name = "colHU_NO_KEY";
            this.colHU_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colHU_NO_KEY.Visible = true;
            this.colHU_NO_KEY.VisibleIndex = 1;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 2;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 3;
            // 
            // colINVD_NO
            // 
            this.colINVD_NO.FieldName = "INVD_NO";
            this.colINVD_NO.Name = "colINVD_NO";
            this.colINVD_NO.Visible = true;
            this.colINVD_NO.VisibleIndex = 4;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 5;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 6;
            // 
            // colLOGI_PARENT_HU_NO
            // 
            this.colLOGI_PARENT_HU_NO.FieldName = "LOGI_PARENT_HU_NO";
            this.colLOGI_PARENT_HU_NO.Name = "colLOGI_PARENT_HU_NO";
            this.colLOGI_PARENT_HU_NO.Visible = true;
            this.colLOGI_PARENT_HU_NO.VisibleIndex = 7;
            // 
            // colPHYSI_PARENT_HU_NO
            // 
            this.colPHYSI_PARENT_HU_NO.FieldName = "PHYSI_PARENT_HU_NO";
            this.colPHYSI_PARENT_HU_NO.Name = "colPHYSI_PARENT_HU_NO";
            this.colPHYSI_PARENT_HU_NO.Visible = true;
            this.colPHYSI_PARENT_HU_NO.VisibleIndex = 8;
            // 
            // colLOGI_STOCK
            // 
            this.colLOGI_STOCK.FieldName = "LOGI_STOCK";
            this.colLOGI_STOCK.Name = "colLOGI_STOCK";
            this.colLOGI_STOCK.Visible = true;
            this.colLOGI_STOCK.VisibleIndex = 9;
            // 
            // colPHYSI_STOCK
            // 
            this.colPHYSI_STOCK.FieldName = "PHYSI_STOCK";
            this.colPHYSI_STOCK.Name = "colPHYSI_STOCK";
            this.colPHYSI_STOCK.Visible = true;
            this.colPHYSI_STOCK.VisibleIndex = 10;
            // 
            // colDIFF_STOCK
            // 
            this.colDIFF_STOCK.FieldName = "DIFF_STOCK";
            this.colDIFF_STOCK.Name = "colDIFF_STOCK";
            this.colDIFF_STOCK.Visible = true;
            this.colDIFF_STOCK.VisibleIndex = 11;
            // 
            // colINV_RSLT_HU_STATUS
            // 
            this.colINV_RSLT_HU_STATUS.FieldName = "INV_RSLT_HU_STATUS";
            this.colINV_RSLT_HU_STATUS.Name = "colINV_RSLT_HU_STATUS";
            this.colINV_RSLT_HU_STATUS.Visible = true;
            this.colINV_RSLT_HU_STATUS.VisibleIndex = 12;
            // 
            // colHU_BARCODE
            // 
            this.colHU_BARCODE.FieldName = "HU_BARCODE";
            this.colHU_BARCODE.Name = "colHU_BARCODE";
            this.colHU_BARCODE.Visible = true;
            this.colHU_BARCODE.VisibleIndex = 13;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 14;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 15;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 16;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 17;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 18;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 19;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 20;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 21;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 22;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 23;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 24;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 25;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 26;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 27;
            // 
            // InvAdjHuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "InvAdjHuList";
            this.Text = "InvAdjHuList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invAdjHuModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource invAdjHuModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colINVD_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colINVD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGI_PARENT_HU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPHYSI_PARENT_HU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colLOGI_STOCK;
        private DevExpress.XtraGrid.Columns.GridColumn colPHYSI_STOCK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIFF_STOCK;
        private DevExpress.XtraGrid.Columns.GridColumn colINV_RSLT_HU_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID;
        private DevExpress.XtraGrid.Columns.GridColumn colSORT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLANG_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
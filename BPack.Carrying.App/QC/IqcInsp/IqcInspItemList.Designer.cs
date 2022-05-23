
namespace BPack.Carrying.App.QC.IqcInsp
{
    partial class IqcInspItemList
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
            this.IqcInspItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIQD_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIQD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIQC_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIN_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIQC_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFECT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIQC_INSD_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSPECTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_TYPE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IqcInspItemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.IqcInspItemModelBindingSource;
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
            // IqcInspItemModelBindingSource
            // 
            this.IqcInspItemModelBindingSource.DataSource = typeof(BPack.Model.App.QC.IqcInsp.IqcInspItemModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIQD_NO_KEY,
            this.colIQD_NO,
            this.colIQC_NO,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colITEM_TYPE_CD,
            this.colITEM_GR_1,
            this.colITEM_NM,
            this.colHU_NO,
            this.colIN_QTY,
            this.colIQC_QTY,
            this.colDEFECT_QTY,
            this.colIQC_INSD_STATUS,
            this.colINSPECTOR,
            this.colREMARK,
            this.colCREATE_DTTM,
            this.colMODIFY_DTTM,
            this.colCREATE_USER_ID,
            this.colMODIFY_USER_ID,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIQD_NO_KEY
            // 
            this.colIQD_NO_KEY.FieldName = "IQD_NO_KEY";
            this.colIQD_NO_KEY.Name = "colIQD_NO_KEY";
            this.colIQD_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colIQD_NO_KEY.Visible = true;
            this.colIQD_NO_KEY.VisibleIndex = 0;
            // 
            // colIQD_NO
            // 
            this.colIQD_NO.FieldName = "IQD_NO";
            this.colIQD_NO.Name = "colIQD_NO";
            this.colIQD_NO.Visible = true;
            this.colIQD_NO.VisibleIndex = 1;
            // 
            // colIQC_NO
            // 
            this.colIQC_NO.FieldName = "IQC_NO";
            this.colIQC_NO.Name = "colIQC_NO";
            this.colIQC_NO.Visible = true;
            this.colIQC_NO.VisibleIndex = 2;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 3;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 4;
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
            this.colITEM_NM.VisibleIndex = 8;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 9;
            // 
            // colIN_QTY
            // 
            this.colIN_QTY.FieldName = "IN_QTY";
            this.colIN_QTY.Name = "colIN_QTY";
            this.colIN_QTY.Visible = true;
            this.colIN_QTY.VisibleIndex = 10;
            // 
            // colIQC_QTY
            // 
            this.colIQC_QTY.FieldName = "IQC_QTY";
            this.colIQC_QTY.Name = "colIQC_QTY";
            this.colIQC_QTY.Visible = true;
            this.colIQC_QTY.VisibleIndex = 11;
            // 
            // colDEFECT_QTY
            // 
            this.colDEFECT_QTY.FieldName = "DEFECT_QTY";
            this.colDEFECT_QTY.Name = "colDEFECT_QTY";
            this.colDEFECT_QTY.Visible = true;
            this.colDEFECT_QTY.VisibleIndex = 12;
            // 
            // colIQC_INSD_STATUS
            // 
            this.colIQC_INSD_STATUS.FieldName = "IQC_INSD_STATUS";
            this.colIQC_INSD_STATUS.Name = "colIQC_INSD_STATUS";
            this.colIQC_INSD_STATUS.Visible = true;
            this.colIQC_INSD_STATUS.VisibleIndex = 13;
            // 
            // colINSPECTOR
            // 
            this.colINSPECTOR.FieldName = "INSPECTOR";
            this.colINSPECTOR.Name = "colINSPECTOR";
            this.colINSPECTOR.Visible = true;
            this.colINSPECTOR.VisibleIndex = 14;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 15;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 16;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 17;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 18;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 19;
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
            // colITEM_TYPE_CD
            // 
            this.colITEM_TYPE_CD.FieldName = "ITEM_TYPE_CD";
            this.colITEM_TYPE_CD.Name = "colITEM_TYPE_CD";
            this.colITEM_TYPE_CD.Visible = true;
            this.colITEM_TYPE_CD.VisibleIndex = 6;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 7;
            // 
            // IqcInspItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "IqcInspItemList";
            this.Text = "IqcInspItemList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IqcInspItemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource IqcInspItemModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIQD_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colIQD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colIQC_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colIN_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colIQC_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFECT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colIQC_INSD_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colINSPECTOR;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
    }
}
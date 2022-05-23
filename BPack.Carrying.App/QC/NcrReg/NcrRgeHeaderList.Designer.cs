
namespace BPack.Carrying.App.QC.NcrReg
{
    partial class NcrRgeHeaderList
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
            this.ncrRegHeaderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNCH_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCH_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCH_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFROM_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCR_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCH_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_DOC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_DOC_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANG_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncrRegHeaderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.ncrRegHeaderModelBindingSource;
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
            // ncrRegHeaderModelBindingSource
            // 
            this.ncrRegHeaderModelBindingSource.DataSource = typeof(BPack.Model.App.QC.NcrReg.NcrRegHeaderModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNCH_NO_KEY,
            this.colIsCheck,
            this.colNCH_DT,
            this.colNCH_NO,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colNCH_TYPE,
            this.colFROM_WH_CD,
            this.colNCR_WH_CD,
            this.colNCH_STATUS,
            this.colREF_DOC_TYPE,
            this.colREF_DOC_NO,
            this.colVALID,
            this.colREMARK,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colCREATE_DTTM,
            this.colCREATE_USER_ID,
            this.colMODIFY_DTTM,
            this.colMODIFY_USER_ID,
            this.colLANG_CODE,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colNCH_NO_KEY
            // 
            this.colNCH_NO_KEY.FieldName = "NCH_NO_KEY";
            this.colNCH_NO_KEY.Name = "colNCH_NO_KEY";
            this.colNCH_NO_KEY.OptionsColumn.ReadOnly = true;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 0;
            // 
            // colNCH_DT
            // 
            this.colNCH_DT.FieldName = "NCH_DT";
            this.colNCH_DT.Name = "colNCH_DT";
            this.colNCH_DT.Visible = true;
            this.colNCH_DT.VisibleIndex = 1;
            // 
            // colNCH_NO
            // 
            this.colNCH_NO.FieldName = "NCH_NO";
            this.colNCH_NO.Name = "colNCH_NO";
            this.colNCH_NO.Visible = true;
            this.colNCH_NO.VisibleIndex = 2;
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
            // colNCH_TYPE
            // 
            this.colNCH_TYPE.FieldName = "NCH_TYPE";
            this.colNCH_TYPE.Name = "colNCH_TYPE";
            this.colNCH_TYPE.Visible = true;
            this.colNCH_TYPE.VisibleIndex = 3;
            // 
            // colFROM_WH_CD
            // 
            this.colFROM_WH_CD.FieldName = "FROM_WH_CD";
            this.colFROM_WH_CD.Name = "colFROM_WH_CD";
            this.colFROM_WH_CD.Visible = true;
            this.colFROM_WH_CD.VisibleIndex = 4;
            // 
            // colNCR_WH_CD
            // 
            this.colNCR_WH_CD.FieldName = "NCR_WH_CD";
            this.colNCR_WH_CD.Name = "colNCR_WH_CD";
            this.colNCR_WH_CD.Visible = true;
            this.colNCR_WH_CD.VisibleIndex = 5;
            // 
            // colNCH_STATUS
            // 
            this.colNCH_STATUS.FieldName = "NCH_STATUS";
            this.colNCH_STATUS.Name = "colNCH_STATUS";
            this.colNCH_STATUS.Visible = true;
            this.colNCH_STATUS.VisibleIndex = 6;
            // 
            // colREF_DOC_TYPE
            // 
            this.colREF_DOC_TYPE.FieldName = "REF_DOC_TYPE";
            this.colREF_DOC_TYPE.Name = "colREF_DOC_TYPE";
            this.colREF_DOC_TYPE.Visible = true;
            this.colREF_DOC_TYPE.VisibleIndex = 7;
            // 
            // colREF_DOC_NO
            // 
            this.colREF_DOC_NO.FieldName = "REF_DOC_NO";
            this.colREF_DOC_NO.Name = "colREF_DOC_NO";
            this.colREF_DOC_NO.Visible = true;
            this.colREF_DOC_NO.VisibleIndex = 8;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 9;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 10;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 11;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 12;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
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
            // NcrRgeHeaderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "NcrRgeHeaderList";
            this.Text = "NcrRgeHeaderList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncrRegHeaderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource ncrRegHeaderModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNCH_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colNCH_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colNCH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colNCH_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colFROM_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colNCR_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colNCH_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_DOC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_DOC_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colSORT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLANG_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
    }
}
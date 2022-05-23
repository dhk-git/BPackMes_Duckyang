namespace BPack.Carrying.App.MD.GirType
{
    partial class GirTypeList
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
            this.typeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIR_TYPE_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIR_TYPE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIR_TYPE_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINOUT_CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINOUT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colERP_CODE_MAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANG_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.typeModelBindingSource;
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
            // typeModelBindingSource
            // 
            this.typeModelBindingSource.DataSource = typeof(BPack.Model.App.MD.GirType.TypeModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colGIR_TYPE_CD_KEY,
            this.colCOMP_CD,
            this.colGIR_TYPE_CD,
            this.colGIR_TYPE_NM,
            this.colINOUT_CLS,
            this.colINOUT_TYPE,
            this.colERP_CODE_MAP,
            this.colREMARK,
            this.colDEL_FG,
            this.colCREATE_DTTM,
            this.colMODIFY_DTTM,
            this.colCREATE_USER_ID,
            this.colMODIFY_USER_ID,
            this.colVALID,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colLANG_CODE,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.Visible = true;
            this.colCOMP_CD_KEY.VisibleIndex = 0;
            // 
            // colGIR_TYPE_CD_KEY
            // 
            this.colGIR_TYPE_CD_KEY.FieldName = "GIR_TYPE_CD_KEY";
            this.colGIR_TYPE_CD_KEY.Name = "colGIR_TYPE_CD_KEY";
            this.colGIR_TYPE_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colGIR_TYPE_CD_KEY.Visible = true;
            this.colGIR_TYPE_CD_KEY.VisibleIndex = 1;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 2;
            // 
            // colGIR_TYPE_CD
            // 
            this.colGIR_TYPE_CD.FieldName = "GIR_TYPE_CD";
            this.colGIR_TYPE_CD.Name = "colGIR_TYPE_CD";
            this.colGIR_TYPE_CD.Visible = true;
            this.colGIR_TYPE_CD.VisibleIndex = 3;
            // 
            // colGIR_TYPE_NM
            // 
            this.colGIR_TYPE_NM.FieldName = "GIR_TYPE_NM";
            this.colGIR_TYPE_NM.Name = "colGIR_TYPE_NM";
            this.colGIR_TYPE_NM.Visible = true;
            this.colGIR_TYPE_NM.VisibleIndex = 4;
            // 
            // colINOUT_CLS
            // 
            this.colINOUT_CLS.FieldName = "INOUT_CLS";
            this.colINOUT_CLS.Name = "colINOUT_CLS";
            this.colINOUT_CLS.Visible = true;
            this.colINOUT_CLS.VisibleIndex = 5;
            // 
            // colINOUT_TYPE
            // 
            this.colINOUT_TYPE.FieldName = "INOUT_TYPE";
            this.colINOUT_TYPE.Name = "colINOUT_TYPE";
            this.colINOUT_TYPE.Visible = true;
            this.colINOUT_TYPE.VisibleIndex = 6;
            // 
            // colERP_CODE_MAP
            // 
            this.colERP_CODE_MAP.FieldName = "ERP_CODE_MAP";
            this.colERP_CODE_MAP.Name = "colERP_CODE_MAP";
            this.colERP_CODE_MAP.Visible = true;
            this.colERP_CODE_MAP.VisibleIndex = 7;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 8;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 9;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 10;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 11;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 12;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 13;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 14;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 15;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 16;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 17;
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
            // GirTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "GirTypeList";
            this.Text = "GirTypeList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource typeModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colGIR_TYPE_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGIR_TYPE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGIR_TYPE_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colINOUT_CLS;
        private DevExpress.XtraGrid.Columns.GridColumn colINOUT_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colERP_CODE_MAP;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID;
        private DevExpress.XtraGrid.Columns.GridColumn colSORT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colLANG_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
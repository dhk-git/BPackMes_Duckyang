
namespace BPack.Carrying.App.MM.GirEtc
{
    partial class GirEtcList
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
            this.girEtcModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colETG_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIR_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINOUT_CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIR_TYPE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETC_GIR_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETC_GIR_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETC_GIR_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETG_NO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girEtcModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.girEtcModelBindingSource;
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
            // girEtcModelBindingSource
            // 
            this.girEtcModelBindingSource.DataSource = typeof(BPack.Model.App.MM.GirEtc.GirEtcModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colETG_NO_KEY,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colGIR_DT,
            this.colINOUT_CLS,
            this.colWH_CD,
            this.colGIR_TYPE_CD,
            this.colETC_GIR_TYPE,
            this.colETC_GIR_STATUS,
            this.colETC_GIR_DESC,
            this.colETG_NO,
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
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colETG_NO_KEY
            // 
            this.colETG_NO_KEY.FieldName = "ETG_NO_KEY";
            this.colETG_NO_KEY.Name = "colETG_NO_KEY";
            this.colETG_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colETG_NO_KEY.Visible = true;
            this.colETG_NO_KEY.VisibleIndex = 0;
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
            // colGIR_DT
            // 
            this.colGIR_DT.FieldName = "GIR_DT";
            this.colGIR_DT.Name = "colGIR_DT";
            this.colGIR_DT.Visible = true;
            this.colGIR_DT.VisibleIndex = 3;
            // 
            // colINOUT_CLS
            // 
            this.colINOUT_CLS.FieldName = "INOUT_CLS";
            this.colINOUT_CLS.Name = "colINOUT_CLS";
            this.colINOUT_CLS.Visible = true;
            this.colINOUT_CLS.VisibleIndex = 4;
            // 
            // colWH_CD
            // 
            this.colWH_CD.FieldName = "WH_CD";
            this.colWH_CD.Name = "colWH_CD";
            this.colWH_CD.Visible = true;
            this.colWH_CD.VisibleIndex = 5;
            // 
            // colGIR_TYPE_CD
            // 
            this.colGIR_TYPE_CD.FieldName = "GIR_TYPE_CD";
            this.colGIR_TYPE_CD.Name = "colGIR_TYPE_CD";
            this.colGIR_TYPE_CD.Visible = true;
            this.colGIR_TYPE_CD.VisibleIndex = 6;
            // 
            // colETC_GIR_TYPE
            // 
            this.colETC_GIR_TYPE.FieldName = "ETC_GIR_TYPE";
            this.colETC_GIR_TYPE.Name = "colETC_GIR_TYPE";
            this.colETC_GIR_TYPE.Visible = true;
            this.colETC_GIR_TYPE.VisibleIndex = 7;
            // 
            // colETC_GIR_STATUS
            // 
            this.colETC_GIR_STATUS.FieldName = "ETC_GIR_STATUS";
            this.colETC_GIR_STATUS.Name = "colETC_GIR_STATUS";
            this.colETC_GIR_STATUS.OptionsColumn.ReadOnly = true;
            this.colETC_GIR_STATUS.Visible = true;
            this.colETC_GIR_STATUS.VisibleIndex = 8;
            // 
            // colETC_GIR_DESC
            // 
            this.colETC_GIR_DESC.FieldName = "ETC_GIR_DESC";
            this.colETC_GIR_DESC.Name = "colETC_GIR_DESC";
            this.colETC_GIR_DESC.Visible = true;
            this.colETC_GIR_DESC.VisibleIndex = 9;
            // 
            // colETG_NO
            // 
            this.colETG_NO.FieldName = "ETG_NO";
            this.colETG_NO.Name = "colETG_NO";
            this.colETG_NO.OptionsColumn.ReadOnly = true;
            this.colETG_NO.Visible = true;
            this.colETG_NO.VisibleIndex = 10;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 11;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 12;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 13;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 14;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 15;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 16;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 17;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 18;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 19;
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
            // GirEtcList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "GirEtcList";
            this.Text = "GirEtcList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girEtcModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource girEtcModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colETG_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGIR_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colINOUT_CLS;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGIR_TYPE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colETC_GIR_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colETC_GIR_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colETC_GIR_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colETG_NO;
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
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
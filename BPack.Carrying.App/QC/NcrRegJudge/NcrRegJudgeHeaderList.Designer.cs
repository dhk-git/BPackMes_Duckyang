
namespace BPack.Carrying.App.QC.NcrRegJudge
{
    partial class NcrRegJudgeHeaderList
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
            this.nccrRegJudgHeaderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNCD_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCH_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCH_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_DOC_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREF_DOC_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCR_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_TYPE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFECT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJUDGE_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMAIN_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEFECT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJUDGE_RESULT = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.nccrRegJudgHeaderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.nccrRegJudgHeaderModelBindingSource;
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
            // nccrRegJudgHeaderModelBindingSource
            // 
            this.nccrRegJudgHeaderModelBindingSource.DataSource = typeof(BPack.Model.App.QC.NcrRegJudge.NcrRegJudgHeaderModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNCD_NO_KEY,
            this.colNCH_DT,
            this.colNCD_NO,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colJUDGE_RESULT,
            this.colNCH_TYPE,
            this.colREF_DOC_TYPE,
            this.colREF_DOC_NO,
            this.colNCR_WH_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colITEM_TYPE_CD,
            this.colDEFECT_QTY,
            this.colJUDGE_QTY,
            this.colREMAIN_QTY,
            this.colDEFECT_CD,
            this.colHU_NO,
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
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colNCD_NO_KEY
            // 
            this.colNCD_NO_KEY.FieldName = "NCD_NO_KEY";
            this.colNCD_NO_KEY.Name = "colNCD_NO_KEY";
            this.colNCD_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colNCD_NO_KEY.Visible = true;
            this.colNCD_NO_KEY.VisibleIndex = 0;
            // 
            // colNCH_DT
            // 
            this.colNCH_DT.FieldName = "NCH_DT";
            this.colNCH_DT.Name = "colNCH_DT";
            this.colNCH_DT.Visible = true;
            this.colNCH_DT.VisibleIndex = 1;
            // 
            // colNCD_NO
            // 
            this.colNCD_NO.FieldName = "NCD_NO";
            this.colNCD_NO.Name = "colNCD_NO";
            this.colNCD_NO.OptionsColumn.ReadOnly = true;
            this.colNCD_NO.Visible = true;
            this.colNCD_NO.VisibleIndex = 2;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 3;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.OptionsColumn.ReadOnly = true;
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 4;
            // 
            // colNCH_TYPE
            // 
            this.colNCH_TYPE.FieldName = "NCH_TYPE";
            this.colNCH_TYPE.Name = "colNCH_TYPE";
            this.colNCH_TYPE.OptionsColumn.ReadOnly = true;
            this.colNCH_TYPE.Visible = true;
            this.colNCH_TYPE.VisibleIndex = 6;
            // 
            // colREF_DOC_TYPE
            // 
            this.colREF_DOC_TYPE.FieldName = "REF_DOC_TYPE";
            this.colREF_DOC_TYPE.Name = "colREF_DOC_TYPE";
            this.colREF_DOC_TYPE.OptionsColumn.ReadOnly = true;
            this.colREF_DOC_TYPE.Visible = true;
            this.colREF_DOC_TYPE.VisibleIndex = 7;
            // 
            // colREF_DOC_NO
            // 
            this.colREF_DOC_NO.FieldName = "REF_DOC_NO";
            this.colREF_DOC_NO.Name = "colREF_DOC_NO";
            this.colREF_DOC_NO.OptionsColumn.ReadOnly = true;
            this.colREF_DOC_NO.Visible = true;
            this.colREF_DOC_NO.VisibleIndex = 8;
            // 
            // colNCR_WH_CD
            // 
            this.colNCR_WH_CD.FieldName = "NCR_WH_CD";
            this.colNCR_WH_CD.Name = "colNCR_WH_CD";
            this.colNCR_WH_CD.OptionsColumn.ReadOnly = true;
            this.colNCR_WH_CD.Visible = true;
            this.colNCR_WH_CD.VisibleIndex = 9;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.OptionsColumn.ReadOnly = true;
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 10;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.OptionsColumn.ReadOnly = true;
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 11;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.OptionsColumn.ReadOnly = true;
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 12;
            // 
            // colITEM_TYPE_CD
            // 
            this.colITEM_TYPE_CD.FieldName = "ITEM_TYPE_CD";
            this.colITEM_TYPE_CD.Name = "colITEM_TYPE_CD";
            this.colITEM_TYPE_CD.OptionsColumn.ReadOnly = true;
            this.colITEM_TYPE_CD.Visible = true;
            this.colITEM_TYPE_CD.VisibleIndex = 13;
            // 
            // colDEFECT_QTY
            // 
            this.colDEFECT_QTY.FieldName = "DEFECT_QTY";
            this.colDEFECT_QTY.Name = "colDEFECT_QTY";
            this.colDEFECT_QTY.OptionsColumn.ReadOnly = true;
            this.colDEFECT_QTY.Visible = true;
            this.colDEFECT_QTY.VisibleIndex = 14;
            // 
            // colJUDGE_QTY
            // 
            this.colJUDGE_QTY.FieldName = "JUDGE_QTY";
            this.colJUDGE_QTY.Name = "colJUDGE_QTY";
            this.colJUDGE_QTY.OptionsColumn.ReadOnly = true;
            this.colJUDGE_QTY.Visible = true;
            this.colJUDGE_QTY.VisibleIndex = 15;
            // 
            // colREMAIN_QTY
            // 
            this.colREMAIN_QTY.FieldName = "REMAIN_QTY";
            this.colREMAIN_QTY.Name = "colREMAIN_QTY";
            this.colREMAIN_QTY.OptionsColumn.ReadOnly = true;
            this.colREMAIN_QTY.Visible = true;
            this.colREMAIN_QTY.VisibleIndex = 17;
            // 
            // colDEFECT_CD
            // 
            this.colDEFECT_CD.FieldName = "DEFECT_CD";
            this.colDEFECT_CD.Name = "colDEFECT_CD";
            this.colDEFECT_CD.Visible = true;
            this.colDEFECT_CD.VisibleIndex = 16;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.OptionsColumn.ReadOnly = true;
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 18;
            // 
            // colJUDGE_RESULT
            // 
            this.colJUDGE_RESULT.FieldName = "JUDGE_RESULT";
            this.colJUDGE_RESULT.Name = "colJUDGE_RESULT";
            this.colJUDGE_RESULT.Visible = true;
            this.colJUDGE_RESULT.VisibleIndex = 5;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 19;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 20;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 21;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 22;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 23;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 24;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 25;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 26;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 27;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 28;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 29;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 30;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 31;
            // 
            // NcrRegJudgeHeaderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "NcrRegJudgeHeaderList";
            this.Text = "NcrRegJudgHeaderList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nccrRegJudgHeaderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nccrRegJudgHeaderModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNCD_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colNCD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colNCH_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_DOC_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colREF_DOC_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colNCR_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFECT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colJUDGE_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colREMAIN_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colJUDGE_RESULT;
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
        private DevExpress.XtraGrid.Columns.GridColumn colNCH_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDEFECT_CD;
    }
}
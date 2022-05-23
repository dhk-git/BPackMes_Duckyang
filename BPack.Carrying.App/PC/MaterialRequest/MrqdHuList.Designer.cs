
namespace BPack.Carrying.App.PC.MaterialRequest
{
    partial class MrqdHuList
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
            this.mrqdHuListModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMRD_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMRD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARCODE_TEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMRD_HU_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_INSP_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_REG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_OTHER_REG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls2 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.mrqdHuListModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.mrqdHuListModelBindingSource;
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
            // mrqdHuListModelBindingSource
            // 
            this.mrqdHuListModelBindingSource.DataSource = typeof(BPack.Model.App.PC.MaterialRequest.MrqdHuListModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMRD_NO_KEY,
            this.colHU_NO_KEY,
            this.colIS_REG,
            this.colIS_OTHER_REG,
            this.colMRD_NO,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWORK_DT,
            this.colITEM_CD,
            this.colWH_CD,
            this.colLOC_CD,
            this.colHU_NO,
            this.colBARCODE_TEXT,
            this.colSTOCK_QTY,
            this.colMRD_HU_STATUS,
            this.colHU_INSP_STATUS,
            this.colCrudCls2,
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
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colMRD_NO_KEY
            // 
            this.colMRD_NO_KEY.FieldName = "MRD_NO_KEY";
            this.colMRD_NO_KEY.Name = "colMRD_NO_KEY";
            this.colMRD_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colMRD_NO_KEY.Visible = true;
            this.colMRD_NO_KEY.VisibleIndex = 3;
            // 
            // colHU_NO_KEY
            // 
            this.colHU_NO_KEY.FieldName = "HU_NO_KEY";
            this.colHU_NO_KEY.Name = "colHU_NO_KEY";
            this.colHU_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colHU_NO_KEY.Visible = true;
            this.colHU_NO_KEY.VisibleIndex = 4;
            // 
            // colMRD_NO
            // 
            this.colMRD_NO.FieldName = "MRD_NO";
            this.colMRD_NO.Name = "colMRD_NO";
            this.colMRD_NO.Visible = true;
            this.colMRD_NO.VisibleIndex = 5;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 6;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 7;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 8;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 9;
            // 
            // colWH_CD
            // 
            this.colWH_CD.FieldName = "WH_CD";
            this.colWH_CD.Name = "colWH_CD";
            this.colWH_CD.Visible = true;
            this.colWH_CD.VisibleIndex = 10;
            // 
            // colLOC_CD
            // 
            this.colLOC_CD.FieldName = "LOC_CD";
            this.colLOC_CD.Name = "colLOC_CD";
            this.colLOC_CD.Visible = true;
            this.colLOC_CD.VisibleIndex = 11;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 12;
            // 
            // colBARCODE_TEXT
            // 
            this.colBARCODE_TEXT.FieldName = "BARCODE_TEXT";
            this.colBARCODE_TEXT.Name = "colBARCODE_TEXT";
            this.colBARCODE_TEXT.Visible = true;
            this.colBARCODE_TEXT.VisibleIndex = 13;
            // 
            // colSTOCK_QTY
            // 
            this.colSTOCK_QTY.FieldName = "STOCK_QTY";
            this.colSTOCK_QTY.Name = "colSTOCK_QTY";
            this.colSTOCK_QTY.Visible = true;
            this.colSTOCK_QTY.VisibleIndex = 14;
            // 
            // colMRD_HU_STATUS
            // 
            this.colMRD_HU_STATUS.FieldName = "MRD_HU_STATUS";
            this.colMRD_HU_STATUS.Name = "colMRD_HU_STATUS";
            this.colMRD_HU_STATUS.Visible = true;
            this.colMRD_HU_STATUS.VisibleIndex = 15;
            // 
            // colHU_INSP_STATUS
            // 
            this.colHU_INSP_STATUS.FieldName = "HU_INSP_STATUS";
            this.colHU_INSP_STATUS.Name = "colHU_INSP_STATUS";
            this.colHU_INSP_STATUS.Visible = true;
            this.colHU_INSP_STATUS.VisibleIndex = 16;
            // 
            // colIS_REG
            // 
            this.colIS_REG.FieldName = "IS_REG";
            this.colIS_REG.Name = "colIS_REG";
            this.colIS_REG.OptionsColumn.ReadOnly = true;
            this.colIS_REG.Visible = true;
            this.colIS_REG.VisibleIndex = 1;
            // 
            // colIS_OTHER_REG
            // 
            this.colIS_OTHER_REG.FieldName = "IS_OTHER_REG";
            this.colIS_OTHER_REG.Name = "colIS_OTHER_REG";
            this.colIS_OTHER_REG.OptionsColumn.ReadOnly = true;
            this.colIS_OTHER_REG.Visible = true;
            this.colIS_OTHER_REG.VisibleIndex = 2;
            // 
            // colCrudCls2
            // 
            this.colCrudCls2.FieldName = "CrudCls2";
            this.colCrudCls2.Name = "colCrudCls2";
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
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 17;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 18;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 19;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 20;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 21;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 22;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 23;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 24;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 25;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 26;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 27;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 28;
            // 
            // MrqdHuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "MrqdHuList";
            this.Text = "MrqdHuList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrqdHuListModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource mrqdHuListModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMRD_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colMRD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBARCODE_TEXT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colMRD_HU_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_INSP_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_REG;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_OTHER_REG;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls2;
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
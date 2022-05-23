namespace BPack.Carrying.App.MD.DlvJisTrtRule
{
    partial class DlvJisTrtRuleHeader
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
            this.dlvJisTrtRuleHeaderlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_PLC_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRT_RULE_ID_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_PLC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRT_RULE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRT_RULE_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBODY_PREFIX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBODY_PREFIX2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBODY_PREFIX3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_TRT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_TRT_METHOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_NO_SOURCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC_NO_TARGET = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dlvJisTrtRuleHeaderlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.dlvJisTrtRuleHeaderlBindingSource;
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
            // dlvJisTrtRuleHeaderlBindingSource
            // 
            this.dlvJisTrtRuleHeaderlBindingSource.DataSource = typeof(BPack.Model.App.MD.DlvJisTrtRule.DlvJisTrtRuleHeaderModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colPLANT_CD_KEY,
            this.colDLV_PLC_CD_KEY,
            this.colTRT_RULE_ID_KEY,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colDLV_PLC_CD,
            this.colTRT_RULE_ID,
            this.colTRT_RULE_NM,
            this.colITEM_GR_1,
            this.colBODY_PREFIX1,
            this.colBODY_PREFIX2,
            this.colBODY_PREFIX3,
            this.colALC_TRT_TYPE,
            this.colALC_TRT_METHOD,
            this.colALC_NO_SOURCE,
            this.colALC_NO_TARGET,
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
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD_KEY.Visible = true;
            this.colCOMP_CD_KEY.VisibleIndex = 0;
            // 
            // colPLANT_CD_KEY
            // 
            this.colPLANT_CD_KEY.FieldName = "PLANT_CD_KEY";
            this.colPLANT_CD_KEY.Name = "colPLANT_CD_KEY";
            this.colPLANT_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colPLANT_CD_KEY.Visible = true;
            this.colPLANT_CD_KEY.VisibleIndex = 1;
            // 
            // colDLV_PLC_CD_KEY
            // 
            this.colDLV_PLC_CD_KEY.FieldName = "DLV_PLC_CD_KEY";
            this.colDLV_PLC_CD_KEY.Name = "colDLV_PLC_CD_KEY";
            this.colDLV_PLC_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colDLV_PLC_CD_KEY.Visible = true;
            this.colDLV_PLC_CD_KEY.VisibleIndex = 2;
            // 
            // colTRT_RULE_ID_KEY
            // 
            this.colTRT_RULE_ID_KEY.FieldName = "TRT_RULE_ID_KEY";
            this.colTRT_RULE_ID_KEY.Name = "colTRT_RULE_ID_KEY";
            this.colTRT_RULE_ID_KEY.OptionsColumn.ReadOnly = true;
            this.colTRT_RULE_ID_KEY.Visible = true;
            this.colTRT_RULE_ID_KEY.VisibleIndex = 3;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 4;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.OptionsColumn.ReadOnly = true;
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 5;
            // 
            // colDLV_PLC_CD
            // 
            this.colDLV_PLC_CD.FieldName = "DLV_PLC_CD";
            this.colDLV_PLC_CD.Name = "colDLV_PLC_CD";
            this.colDLV_PLC_CD.OptionsColumn.ReadOnly = true;
            this.colDLV_PLC_CD.Visible = true;
            this.colDLV_PLC_CD.VisibleIndex = 6;
            // 
            // colTRT_RULE_ID
            // 
            this.colTRT_RULE_ID.FieldName = "TRT_RULE_ID";
            this.colTRT_RULE_ID.Name = "colTRT_RULE_ID";
            this.colTRT_RULE_ID.Visible = true;
            this.colTRT_RULE_ID.VisibleIndex = 7;
            // 
            // colTRT_RULE_NM
            // 
            this.colTRT_RULE_NM.FieldName = "TRT_RULE_NM";
            this.colTRT_RULE_NM.Name = "colTRT_RULE_NM";
            this.colTRT_RULE_NM.Visible = true;
            this.colTRT_RULE_NM.VisibleIndex = 8;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 9;
            // 
            // colBODY_PREFIX1
            // 
            this.colBODY_PREFIX1.FieldName = "BODY_PREFIX1";
            this.colBODY_PREFIX1.Name = "colBODY_PREFIX1";
            this.colBODY_PREFIX1.Visible = true;
            this.colBODY_PREFIX1.VisibleIndex = 10;
            // 
            // colBODY_PREFIX2
            // 
            this.colBODY_PREFIX2.FieldName = "BODY_PREFIX2";
            this.colBODY_PREFIX2.Name = "colBODY_PREFIX2";
            this.colBODY_PREFIX2.Visible = true;
            this.colBODY_PREFIX2.VisibleIndex = 11;
            // 
            // colBODY_PREFIX3
            // 
            this.colBODY_PREFIX3.FieldName = "BODY_PREFIX3";
            this.colBODY_PREFIX3.Name = "colBODY_PREFIX3";
            this.colBODY_PREFIX3.Visible = true;
            this.colBODY_PREFIX3.VisibleIndex = 12;
            // 
            // colALC_TRT_TYPE
            // 
            this.colALC_TRT_TYPE.FieldName = "ALC_TRT_TYPE";
            this.colALC_TRT_TYPE.Name = "colALC_TRT_TYPE";
            this.colALC_TRT_TYPE.Visible = true;
            this.colALC_TRT_TYPE.VisibleIndex = 13;
            // 
            // colALC_TRT_METHOD
            // 
            this.colALC_TRT_METHOD.FieldName = "ALC_TRT_METHOD";
            this.colALC_TRT_METHOD.Name = "colALC_TRT_METHOD";
            this.colALC_TRT_METHOD.Visible = true;
            this.colALC_TRT_METHOD.VisibleIndex = 14;
            // 
            // colALC_NO_SOURCE
            // 
            this.colALC_NO_SOURCE.FieldName = "ALC_NO_SOURCE";
            this.colALC_NO_SOURCE.Name = "colALC_NO_SOURCE";
            this.colALC_NO_SOURCE.Visible = true;
            this.colALC_NO_SOURCE.VisibleIndex = 15;
            // 
            // colALC_NO_TARGET
            // 
            this.colALC_NO_TARGET.FieldName = "ALC_NO_TARGET";
            this.colALC_NO_TARGET.Name = "colALC_NO_TARGET";
            this.colALC_NO_TARGET.Visible = true;
            this.colALC_NO_TARGET.VisibleIndex = 16;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 17;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 18;
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
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 23;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 24;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 25;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 26;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 27;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 28;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 29;
            // 
            // DlvJisTrtRuleHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "DlvJisTrtRuleHeader";
            this.Text = "GirWhList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvJisTrtRuleHeaderlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dlvJisTrtRuleHeaderlBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_PLC_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colTRT_RULE_ID_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_PLC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colTRT_RULE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTRT_RULE_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colBODY_PREFIX1;
        private DevExpress.XtraGrid.Columns.GridColumn colBODY_PREFIX2;
        private DevExpress.XtraGrid.Columns.GridColumn colBODY_PREFIX3;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_TRT_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_TRT_METHOD;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_NO_SOURCE;
        private DevExpress.XtraGrid.Columns.GridColumn colALC_NO_TARGET;
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
namespace BPack.Carrying.App.MD.QciInspStd
{
    partial class CheckList
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.strapGridControl1 = new BPack.Strap.Grid.StrapGridControl();
            this.inspectionCheckListModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colINSP_DV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOWER_LIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASE_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPPER_LIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_METHOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_VAL_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQC_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_STD_ID_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREVISION_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_ID_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_STD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREVISION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORT_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPC_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.rpsFile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colFILE_GROUP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionCheckListModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsFile)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.inspectionCheckListModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpsFile});
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // inspectionCheckListModelBindingSource
            // 
            this.inspectionCheckListModelBindingSource.DataSource = typeof(BPack.Model.App.MD.QciInspStd.InspectionCheckListModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colINSP_DV,
            this.colINSP_ID,
            this.colINSP_SPEC,
            this.colLOWER_LIMIT,
            this.colBASE_VALUE,
            this.colUPPER_LIMIT,
            this.colINSP_METHOD,
            this.colINSP_VAL_TYPE,
            this.colUNIT,
            this.colQC_FG,
            this.colINSP_STD_ID_KEY,
            this.colREVISION_KEY,
            this.colINSP_ID_KEY,
            this.colINSP_STD_ID,
            this.colREVISION,
            this.colSORT_SEQ,
            this.colPC_FG,
            this.colFILE_GROUP_ID,
            this.colDEL_FG,
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
            this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colINSP_DV
            // 
            this.colINSP_DV.FieldName = "INSP_DV";
            this.colINSP_DV.Name = "colINSP_DV";
            this.colINSP_DV.Visible = true;
            this.colINSP_DV.VisibleIndex = 1;
            // 
            // colINSP_ID
            // 
            this.colINSP_ID.FieldName = "INSP_ID";
            this.colINSP_ID.Name = "colINSP_ID";
            this.colINSP_ID.Visible = true;
            this.colINSP_ID.VisibleIndex = 2;
            // 
            // colINSP_SPEC
            // 
            this.colINSP_SPEC.FieldName = "INSP_SPEC";
            this.colINSP_SPEC.Name = "colINSP_SPEC";
            this.colINSP_SPEC.Visible = true;
            this.colINSP_SPEC.VisibleIndex = 3;
            // 
            // colLOWER_LIMIT
            // 
            this.colLOWER_LIMIT.FieldName = "LOWER_LIMIT";
            this.colLOWER_LIMIT.Name = "colLOWER_LIMIT";
            this.colLOWER_LIMIT.Visible = true;
            this.colLOWER_LIMIT.VisibleIndex = 4;
            // 
            // colBASE_VALUE
            // 
            this.colBASE_VALUE.FieldName = "BASE_VALUE";
            this.colBASE_VALUE.Name = "colBASE_VALUE";
            this.colBASE_VALUE.Visible = true;
            this.colBASE_VALUE.VisibleIndex = 5;
            // 
            // colUPPER_LIMIT
            // 
            this.colUPPER_LIMIT.FieldName = "UPPER_LIMIT";
            this.colUPPER_LIMIT.Name = "colUPPER_LIMIT";
            this.colUPPER_LIMIT.Visible = true;
            this.colUPPER_LIMIT.VisibleIndex = 6;
            // 
            // colINSP_METHOD
            // 
            this.colINSP_METHOD.FieldName = "INSP_METHOD";
            this.colINSP_METHOD.Name = "colINSP_METHOD";
            this.colINSP_METHOD.Visible = true;
            this.colINSP_METHOD.VisibleIndex = 7;
            // 
            // colINSP_VAL_TYPE
            // 
            this.colINSP_VAL_TYPE.FieldName = "INSP_VAL_TYPE";
            this.colINSP_VAL_TYPE.Name = "colINSP_VAL_TYPE";
            this.colINSP_VAL_TYPE.Visible = true;
            this.colINSP_VAL_TYPE.VisibleIndex = 8;
            // 
            // colUNIT
            // 
            this.colUNIT.FieldName = "UNIT";
            this.colUNIT.Name = "colUNIT";
            this.colUNIT.Visible = true;
            this.colUNIT.VisibleIndex = 9;
            // 
            // colQC_FG
            // 
            this.colQC_FG.FieldName = "QC_FG";
            this.colQC_FG.Name = "colQC_FG";
            this.colQC_FG.Visible = true;
            this.colQC_FG.VisibleIndex = 10;
            // 
            // colINSP_STD_ID_KEY
            // 
            this.colINSP_STD_ID_KEY.FieldName = "INSP_STD_ID_KEY";
            this.colINSP_STD_ID_KEY.Name = "colINSP_STD_ID_KEY";
            this.colINSP_STD_ID_KEY.OptionsColumn.ReadOnly = true;
            this.colINSP_STD_ID_KEY.Visible = true;
            this.colINSP_STD_ID_KEY.VisibleIndex = 11;
            // 
            // colREVISION_KEY
            // 
            this.colREVISION_KEY.FieldName = "REVISION_KEY";
            this.colREVISION_KEY.Name = "colREVISION_KEY";
            this.colREVISION_KEY.OptionsColumn.ReadOnly = true;
            this.colREVISION_KEY.Visible = true;
            this.colREVISION_KEY.VisibleIndex = 12;
            // 
            // colINSP_ID_KEY
            // 
            this.colINSP_ID_KEY.FieldName = "INSP_ID_KEY";
            this.colINSP_ID_KEY.Name = "colINSP_ID_KEY";
            this.colINSP_ID_KEY.OptionsColumn.ReadOnly = true;
            this.colINSP_ID_KEY.Visible = true;
            this.colINSP_ID_KEY.VisibleIndex = 13;
            // 
            // colINSP_STD_ID
            // 
            this.colINSP_STD_ID.FieldName = "INSP_STD_ID";
            this.colINSP_STD_ID.Name = "colINSP_STD_ID";
            this.colINSP_STD_ID.Visible = true;
            this.colINSP_STD_ID.VisibleIndex = 14;
            // 
            // colREVISION
            // 
            this.colREVISION.FieldName = "REVISION";
            this.colREVISION.Name = "colREVISION";
            this.colREVISION.Visible = true;
            this.colREVISION.VisibleIndex = 15;
            // 
            // colSORT_SEQ
            // 
            this.colSORT_SEQ.FieldName = "SORT_SEQ";
            this.colSORT_SEQ.Name = "colSORT_SEQ";
            this.colSORT_SEQ.Visible = true;
            this.colSORT_SEQ.VisibleIndex = 16;
            // 
            // colPC_FG
            // 
            this.colPC_FG.FieldName = "PC_FG";
            this.colPC_FG.Name = "colPC_FG";
            this.colPC_FG.Visible = true;
            this.colPC_FG.VisibleIndex = 18;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 19;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 20;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 21;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 22;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 23;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 24;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 25;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 26;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 27;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 28;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 29;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 30;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 31;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 0;
            // 
            // rpsFile
            // 
            this.rpsFile.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.rpsFile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.rpsFile.Name = "rpsFile";
            // 
            // colFILE_GROUP_ID
            // 
            this.colFILE_GROUP_ID.FieldName = "FILE_GROUP_ID";
            this.colFILE_GROUP_ID.Name = "colFILE_GROUP_ID";
            this.colFILE_GROUP_ID.Visible = true;
            this.colFILE_GROUP_ID.VisibleIndex = 17;
            // 
            // CheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "CheckList";
            this.Text = "CheckList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionCheckListModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private System.Windows.Forms.BindingSource inspectionCheckListModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rpsFile;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_DV;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colLOWER_LIMIT;
        private DevExpress.XtraGrid.Columns.GridColumn colBASE_VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colUPPER_LIMIT;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_METHOD;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_VAL_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colQC_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_STD_ID_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colREVISION_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_ID_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_STD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colREVISION;
        private DevExpress.XtraGrid.Columns.GridColumn colSORT_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colPC_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_FG;
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
        private DevExpress.XtraGrid.Columns.GridColumn colFILE_GROUP_ID;
    }
}
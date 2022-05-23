namespace BPack.Carrying.App.MD.EquItemCheckList
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
            this.strapGridControl1 = new BPack.Strap.Grid.StrapGridControl();
            this.equItemCheckListCheckListModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CHK_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CHK_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CHK_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOWER_LIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASE_VAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPPER_LIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_DV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_METHOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_VAL_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_FROM_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_TO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.equItemCheckListCheckListModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.equItemCheckListCheckListModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // equItemCheckListCheckListModelBindingSource
            // 
            this.equItemCheckListCheckListModelBindingSource.DataSource = typeof(BPack.Model.App.MD.EquItemCheckList.EquItemCheckListCheckListModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colPLANT_CD_KEY,
            this.colEQUIP_CD_KEY,
            this.colITEM_CD_KEY,
            this.colEQUIP_CHK_CD_KEY,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colEQUIP_CD,
            this.colITEM_CD,
            this.colEQUIP_CHK_CD,
            this.colEQUIP_CHK_NM,
            this.colLOWER_LIMIT,
            this.colBASE_VAL,
            this.colUPPER_LIMIT,
            this.colINSP_DV,
            this.colINSP_METHOD,
            this.colINSP_VAL_TYPE,
            this.colVALID_FROM_DT,
            this.colVALID_TO_DT,
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
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
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
            // colEQUIP_CD_KEY
            // 
            this.colEQUIP_CD_KEY.FieldName = "EQUIP_CD_KEY";
            this.colEQUIP_CD_KEY.Name = "colEQUIP_CD_KEY";
            this.colEQUIP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colEQUIP_CD_KEY.Visible = true;
            this.colEQUIP_CD_KEY.VisibleIndex = 2;
            // 
            // colITEM_CD_KEY
            // 
            this.colITEM_CD_KEY.FieldName = "ITEM_CD_KEY";
            this.colITEM_CD_KEY.Name = "colITEM_CD_KEY";
            this.colITEM_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colITEM_CD_KEY.Visible = true;
            this.colITEM_CD_KEY.VisibleIndex = 3;
            // 
            // colEQUIP_CHK_CD_KEY
            // 
            this.colEQUIP_CHK_CD_KEY.FieldName = "EQUIP_CHK_CD_KEY";
            this.colEQUIP_CHK_CD_KEY.Name = "colEQUIP_CHK_CD_KEY";
            this.colEQUIP_CHK_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colEQUIP_CHK_CD_KEY.Visible = true;
            this.colEQUIP_CHK_CD_KEY.VisibleIndex = 4;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 5;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 6;
            // 
            // colEQUIP_CD
            // 
            this.colEQUIP_CD.FieldName = "EQUIP_CD";
            this.colEQUIP_CD.Name = "colEQUIP_CD";
            this.colEQUIP_CD.Visible = true;
            this.colEQUIP_CD.VisibleIndex = 7;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 8;
            // 
            // colEQUIP_CHK_CD
            // 
            this.colEQUIP_CHK_CD.FieldName = "EQUIP_CHK_CD";
            this.colEQUIP_CHK_CD.Name = "colEQUIP_CHK_CD";
            this.colEQUIP_CHK_CD.Visible = true;
            this.colEQUIP_CHK_CD.VisibleIndex = 9;
            // 
            // colEQUIP_CHK_NM
            // 
            this.colEQUIP_CHK_NM.FieldName = "EQUIP_CHK_NM";
            this.colEQUIP_CHK_NM.Name = "colEQUIP_CHK_NM";
            this.colEQUIP_CHK_NM.OptionsColumn.ReadOnly = true;
            this.colEQUIP_CHK_NM.Visible = true;
            this.colEQUIP_CHK_NM.VisibleIndex = 10;
            // 
            // colLOWER_LIMIT
            // 
            this.colLOWER_LIMIT.FieldName = "LOWER_LIMIT";
            this.colLOWER_LIMIT.Name = "colLOWER_LIMIT";
            this.colLOWER_LIMIT.Visible = true;
            this.colLOWER_LIMIT.VisibleIndex = 11;
            // 
            // colBASE_VAL
            // 
            this.colBASE_VAL.FieldName = "BASE_VAL";
            this.colBASE_VAL.Name = "colBASE_VAL";
            this.colBASE_VAL.Visible = true;
            this.colBASE_VAL.VisibleIndex = 12;
            // 
            // colUPPER_LIMIT
            // 
            this.colUPPER_LIMIT.FieldName = "UPPER_LIMIT";
            this.colUPPER_LIMIT.Name = "colUPPER_LIMIT";
            this.colUPPER_LIMIT.Visible = true;
            this.colUPPER_LIMIT.VisibleIndex = 13;
            // 
            // colINSP_DV
            // 
            this.colINSP_DV.FieldName = "INSP_DV";
            this.colINSP_DV.Name = "colINSP_DV";
            this.colINSP_DV.Visible = true;
            this.colINSP_DV.VisibleIndex = 14;
            // 
            // colINSP_METHOD
            // 
            this.colINSP_METHOD.FieldName = "INSP_METHOD";
            this.colINSP_METHOD.Name = "colINSP_METHOD";
            this.colINSP_METHOD.Visible = true;
            this.colINSP_METHOD.VisibleIndex = 15;
            // 
            // colINSP_VAL_TYPE
            // 
            this.colINSP_VAL_TYPE.FieldName = "INSP_VAL_TYPE";
            this.colINSP_VAL_TYPE.Name = "colINSP_VAL_TYPE";
            this.colINSP_VAL_TYPE.Visible = true;
            this.colINSP_VAL_TYPE.VisibleIndex = 16;
            // 
            // colVALID_FROM_DT
            // 
            this.colVALID_FROM_DT.FieldName = "VALID_FROM_DT";
            this.colVALID_FROM_DT.Name = "colVALID_FROM_DT";
            this.colVALID_FROM_DT.Visible = true;
            this.colVALID_FROM_DT.VisibleIndex = 17;
            // 
            // colVALID_TO_DT
            // 
            this.colVALID_TO_DT.FieldName = "VALID_TO_DT";
            this.colVALID_TO_DT.Name = "colVALID_TO_DT";
            this.colVALID_TO_DT.Visible = true;
            this.colVALID_TO_DT.VisibleIndex = 18;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 19;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 20;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 21;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 22;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 23;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 24;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 25;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 26;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 27;
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
            this.colIsCheck.VisibleIndex = 32;
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
            ((System.ComponentModel.ISupportInitialize)(this.equItemCheckListCheckListModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource equItemCheckListCheckListModelBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CHK_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CHK_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CHK_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colLOWER_LIMIT;
        private DevExpress.XtraGrid.Columns.GridColumn colBASE_VAL;
        private DevExpress.XtraGrid.Columns.GridColumn colUPPER_LIMIT;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_DV;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_METHOD;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_VAL_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_FROM_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_TO_DT;
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
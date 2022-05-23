namespace BPack.Carrying.App.MD.QciInspStd
{
    partial class RevisionList
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colREVISION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAMPLE_CNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_FROM_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_TO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_STD_ID_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREVISION_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_STD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSP_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROUTE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFILE_GROUP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSE_FG = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.inspectionRevisionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionRevisionModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.inspectionRevisionModelBindingSource;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colREVISION,
            this.colALL_FG,
            this.colSAMPLE_CNT,
            this.colVALID_FROM_DT,
            this.colVALID_TO_DT,
            this.colINSP_STD_ID_KEY,
            this.colREVISION_KEY,
            this.colINSP_STD_ID,
            this.colINSP_TYPE,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colROUTE_NO,
            this.colOPER,
            this.colFILE_GROUP_ID,
            this.colUSE_FG,
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
            // 
            // colREVISION
            // 
            this.colREVISION.FieldName = "REVISION";
            this.colREVISION.Name = "colREVISION";
            this.colREVISION.Visible = true;
            this.colREVISION.VisibleIndex = 0;
            // 
            // colALL_FG
            // 
            this.colALL_FG.FieldName = "ALL_FG";
            this.colALL_FG.Name = "colALL_FG";
            this.colALL_FG.Visible = true;
            this.colALL_FG.VisibleIndex = 1;
            // 
            // colSAMPLE_CNT
            // 
            this.colSAMPLE_CNT.FieldName = "SAMPLE_CNT";
            this.colSAMPLE_CNT.Name = "colSAMPLE_CNT";
            this.colSAMPLE_CNT.Visible = true;
            this.colSAMPLE_CNT.VisibleIndex = 2;
            // 
            // colVALID_FROM_DT
            // 
            this.colVALID_FROM_DT.FieldName = "VALID_FROM_DT";
            this.colVALID_FROM_DT.Name = "colVALID_FROM_DT";
            this.colVALID_FROM_DT.Visible = true;
            this.colVALID_FROM_DT.VisibleIndex = 3;
            // 
            // colVALID_TO_DT
            // 
            this.colVALID_TO_DT.FieldName = "VALID_TO_DT";
            this.colVALID_TO_DT.Name = "colVALID_TO_DT";
            this.colVALID_TO_DT.Visible = true;
            this.colVALID_TO_DT.VisibleIndex = 4;
            // 
            // colINSP_STD_ID_KEY
            // 
            this.colINSP_STD_ID_KEY.FieldName = "INSP_STD_ID_KEY";
            this.colINSP_STD_ID_KEY.Name = "colINSP_STD_ID_KEY";
            this.colINSP_STD_ID_KEY.OptionsColumn.ReadOnly = true;
            this.colINSP_STD_ID_KEY.Visible = true;
            this.colINSP_STD_ID_KEY.VisibleIndex = 5;
            // 
            // colREVISION_KEY
            // 
            this.colREVISION_KEY.FieldName = "REVISION_KEY";
            this.colREVISION_KEY.Name = "colREVISION_KEY";
            this.colREVISION_KEY.OptionsColumn.ReadOnly = true;
            this.colREVISION_KEY.Visible = true;
            this.colREVISION_KEY.VisibleIndex = 6;
            // 
            // colINSP_STD_ID
            // 
            this.colINSP_STD_ID.FieldName = "INSP_STD_ID";
            this.colINSP_STD_ID.Name = "colINSP_STD_ID";
            this.colINSP_STD_ID.Visible = true;
            this.colINSP_STD_ID.VisibleIndex = 7;
            // 
            // colINSP_TYPE
            // 
            this.colINSP_TYPE.FieldName = "INSP_TYPE";
            this.colINSP_TYPE.Name = "colINSP_TYPE";
            this.colINSP_TYPE.Visible = true;
            this.colINSP_TYPE.VisibleIndex = 8;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 9;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 10;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 11;
            // 
            // colROUTE_NO
            // 
            this.colROUTE_NO.FieldName = "ROUTE_NO";
            this.colROUTE_NO.Name = "colROUTE_NO";
            this.colROUTE_NO.Visible = true;
            this.colROUTE_NO.VisibleIndex = 12;
            // 
            // colOPER
            // 
            this.colOPER.FieldName = "OPER";
            this.colOPER.Name = "colOPER";
            this.colOPER.Visible = true;
            this.colOPER.VisibleIndex = 13;
            // 
            // colFILE_GROUP_ID
            // 
            this.colFILE_GROUP_ID.FieldName = "FILE_GROUP_ID";
            this.colFILE_GROUP_ID.Name = "colFILE_GROUP_ID";
            this.colFILE_GROUP_ID.Visible = true;
            this.colFILE_GROUP_ID.VisibleIndex = 14;
            // 
            // colUSE_FG
            // 
            this.colUSE_FG.FieldName = "USE_FG";
            this.colUSE_FG.Name = "colUSE_FG";
            this.colUSE_FG.Visible = true;
            this.colUSE_FG.VisibleIndex = 15;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 16;
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
            // inspectionRevisionModelBindingSource
            // 
            this.inspectionRevisionModelBindingSource.DataSource = typeof(BPack.Model.App.MD.QciInspStd.InspectionRevisionModel);
            // 
            // RevisionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "RevisionList";
            this.Text = "RevisionList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionRevisionModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colREVISION;
        private DevExpress.XtraGrid.Columns.GridColumn colALL_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colSAMPLE_CNT;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_FROM_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_TO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_STD_ID_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colREVISION_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_STD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colINSP_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER;
        private DevExpress.XtraGrid.Columns.GridColumn colUSE_FG;
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
        private System.Windows.Forms.BindingSource inspectionRevisionModelBindingSource;
    }
}
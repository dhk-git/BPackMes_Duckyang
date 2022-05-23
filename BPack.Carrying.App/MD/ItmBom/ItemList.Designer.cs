namespace BPack.Carrying.App.MD.ItmBom
{
    partial class ItemList
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
            this.itemInfoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM_PL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAIN_MODEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASE_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWEIGHT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWEIGHT_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_INPUT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINDI_HU_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_FROM_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_TO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.itemInfoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.itemInfoModelBindingSource;
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
            // itemInfoModelBindingSource
            // 
            this.itemInfoModelBindingSource.DataSource = typeof(BPack.Model.App.MD.ItmBom.ItemInfoModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colPLANT_CD_KEY,
            this.colITEM_CD_KEY,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_GR_1,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_NM_PL,
            this.colITEM_SPEC,
            this.colITEM_TYPE,
            this.colITEM_GR_2,
            this.colITEM_GR_3,
            this.colHU_SIZE,
            this.colHU_UNIT,
            this.colMAIN_MODEL,
            this.colBASE_UNIT,
            this.colWEIGHT,
            this.colWEIGHT_UNIT,
            this.colMAT_INPUT_TYPE,
            this.colINDI_HU_FG,
            this.colREMARK,
            this.colVALID_FROM_DT,
            this.colVALID_TO_DT,
            this.colDEL_FG,
            this.colVALID,
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
            this.colCOMP_CD_KEY.Width = 20;
            // 
            // colPLANT_CD_KEY
            // 
            this.colPLANT_CD_KEY.FieldName = "PLANT_CD_KEY";
            this.colPLANT_CD_KEY.Name = "colPLANT_CD_KEY";
            this.colPLANT_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colPLANT_CD_KEY.Visible = true;
            this.colPLANT_CD_KEY.VisibleIndex = 1;
            this.colPLANT_CD_KEY.Width = 20;
            // 
            // colITEM_CD_KEY
            // 
            this.colITEM_CD_KEY.FieldName = "ITEM_CD_KEY";
            this.colITEM_CD_KEY.Name = "colITEM_CD_KEY";
            this.colITEM_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colITEM_CD_KEY.Visible = true;
            this.colITEM_CD_KEY.VisibleIndex = 2;
            this.colITEM_CD_KEY.Width = 20;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 3;
            this.colCOMP_CD.Width = 20;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.OptionsColumn.ReadOnly = true;
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 4;
            this.colPLANT_CD.Width = 20;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 5;
            this.colITEM_GR_1.Width = 20;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 6;
            this.colITEM_CD.Width = 20;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 7;
            this.colITEM_NM.Width = 21;
            // 
            // colITEM_NM_PL
            // 
            this.colITEM_NM_PL.FieldName = "ITEM_NM_PL";
            this.colITEM_NM_PL.Name = "colITEM_NM_PL";
            this.colITEM_NM_PL.Visible = true;
            this.colITEM_NM_PL.VisibleIndex = 8;
            this.colITEM_NM_PL.Width = 21;
            // 
            // colITEM_SPEC
            // 
            this.colITEM_SPEC.FieldName = "ITEM_SPEC";
            this.colITEM_SPEC.Name = "colITEM_SPEC";
            this.colITEM_SPEC.Visible = true;
            this.colITEM_SPEC.VisibleIndex = 9;
            this.colITEM_SPEC.Width = 21;
            // 
            // colITEM_TYPE
            // 
            this.colITEM_TYPE.FieldName = "ITEM_TYPE";
            this.colITEM_TYPE.Name = "colITEM_TYPE";
            this.colITEM_TYPE.Visible = true;
            this.colITEM_TYPE.VisibleIndex = 10;
            this.colITEM_TYPE.Width = 21;
            // 
            // colITEM_GR_2
            // 
            this.colITEM_GR_2.FieldName = "ITEM_GR_2";
            this.colITEM_GR_2.Name = "colITEM_GR_2";
            this.colITEM_GR_2.Visible = true;
            this.colITEM_GR_2.VisibleIndex = 11;
            this.colITEM_GR_2.Width = 21;
            // 
            // colITEM_GR_3
            // 
            this.colITEM_GR_3.FieldName = "ITEM_GR_3";
            this.colITEM_GR_3.Name = "colITEM_GR_3";
            this.colITEM_GR_3.Visible = true;
            this.colITEM_GR_3.VisibleIndex = 12;
            this.colITEM_GR_3.Width = 21;
            // 
            // colHU_SIZE
            // 
            this.colHU_SIZE.FieldName = "HU_SIZE";
            this.colHU_SIZE.Name = "colHU_SIZE";
            this.colHU_SIZE.Visible = true;
            this.colHU_SIZE.VisibleIndex = 13;
            this.colHU_SIZE.Width = 21;
            // 
            // colHU_UNIT
            // 
            this.colHU_UNIT.FieldName = "HU_UNIT";
            this.colHU_UNIT.Name = "colHU_UNIT";
            this.colHU_UNIT.Visible = true;
            this.colHU_UNIT.VisibleIndex = 14;
            this.colHU_UNIT.Width = 21;
            // 
            // colMAIN_MODEL
            // 
            this.colMAIN_MODEL.FieldName = "MAIN_MODEL";
            this.colMAIN_MODEL.Name = "colMAIN_MODEL";
            this.colMAIN_MODEL.Visible = true;
            this.colMAIN_MODEL.VisibleIndex = 15;
            this.colMAIN_MODEL.Width = 21;
            // 
            // colBASE_UNIT
            // 
            this.colBASE_UNIT.FieldName = "BASE_UNIT";
            this.colBASE_UNIT.Name = "colBASE_UNIT";
            this.colBASE_UNIT.Visible = true;
            this.colBASE_UNIT.VisibleIndex = 16;
            this.colBASE_UNIT.Width = 21;
            // 
            // colWEIGHT
            // 
            this.colWEIGHT.FieldName = "WEIGHT";
            this.colWEIGHT.Name = "colWEIGHT";
            this.colWEIGHT.Visible = true;
            this.colWEIGHT.VisibleIndex = 17;
            this.colWEIGHT.Width = 21;
            // 
            // colWEIGHT_UNIT
            // 
            this.colWEIGHT_UNIT.FieldName = "WEIGHT_UNIT";
            this.colWEIGHT_UNIT.Name = "colWEIGHT_UNIT";
            this.colWEIGHT_UNIT.Visible = true;
            this.colWEIGHT_UNIT.VisibleIndex = 18;
            this.colWEIGHT_UNIT.Width = 21;
            // 
            // colMAT_INPUT_TYPE
            // 
            this.colMAT_INPUT_TYPE.FieldName = "MAT_INPUT_TYPE";
            this.colMAT_INPUT_TYPE.Name = "colMAT_INPUT_TYPE";
            this.colMAT_INPUT_TYPE.Visible = true;
            this.colMAT_INPUT_TYPE.VisibleIndex = 19;
            this.colMAT_INPUT_TYPE.Width = 21;
            // 
            // colINDI_HU_FG
            // 
            this.colINDI_HU_FG.FieldName = "INDI_HU_FG";
            this.colINDI_HU_FG.Name = "colINDI_HU_FG";
            this.colINDI_HU_FG.Visible = true;
            this.colINDI_HU_FG.VisibleIndex = 20;
            this.colINDI_HU_FG.Width = 21;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 21;
            this.colREMARK.Width = 21;
            // 
            // colVALID_FROM_DT
            // 
            this.colVALID_FROM_DT.FieldName = "VALID_FROM_DT";
            this.colVALID_FROM_DT.Name = "colVALID_FROM_DT";
            this.colVALID_FROM_DT.Visible = true;
            this.colVALID_FROM_DT.VisibleIndex = 22;
            this.colVALID_FROM_DT.Width = 21;
            // 
            // colVALID_TO_DT
            // 
            this.colVALID_TO_DT.FieldName = "VALID_TO_DT";
            this.colVALID_TO_DT.Name = "colVALID_TO_DT";
            this.colVALID_TO_DT.Visible = true;
            this.colVALID_TO_DT.VisibleIndex = 23;
            this.colVALID_TO_DT.Width = 21;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 24;
            this.colDEL_FG.Width = 21;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 25;
            this.colVALID.Width = 21;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 26;
            this.colSORT_NO.Width = 21;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 27;
            this.colROW_SEQ.Width = 21;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 28;
            this.colCREATE_DTTM.Width = 21;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 29;
            this.colCREATE_USER_ID.Width = 21;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 30;
            this.colMODIFY_DTTM.Width = 21;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 31;
            this.colMODIFY_USER_ID.Width = 21;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 32;
            this.colLANG_CODE.Width = 21;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 33;
            this.colRowState.Width = 21;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 34;
            this.colCrudCls.Width = 21;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 35;
            this.colSelectedCheck.Width = 21;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 36;
            this.colIsCheck.Width = 26;
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ItemList";
            this.Text = "ItemList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemInfoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource itemInfoModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM_PL;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_2;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_3;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_SIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAIN_MODEL;
        private DevExpress.XtraGrid.Columns.GridColumn colBASE_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colWEIGHT;
        private DevExpress.XtraGrid.Columns.GridColumn colWEIGHT_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_INPUT_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colINDI_HU_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_FROM_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_TO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID;
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
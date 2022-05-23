
namespace BPack.Carrying.App.MD.OrgPlant
{
    partial class OrgPlantWktmList
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
            this.plantWkModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSHIFT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_DT_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_TM_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWTM_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWTM_MIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.plantWkModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.plantWkModelBindingSource;
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
            // plantWkModelBindingSource
            // 
            this.plantWkModelBindingSource.DataSource = typeof(BPack.Model.App.MD.OrgPlant.PlantWkModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSHIFT_CD_KEY,
            this.colVALID_DT_KEY,
            this.colSTART_TM_KEY,
            this.colWTM_TYPE,
            this.colTM_CD,
            this.colVALID_DT,
            this.colSTART_TM,
            this.colEND_TM,
            this.colWTM_MIN,
            this.colCOMP_CD_KEY,
            this.colCOMP_CD,
            this.colPLANT_CD_KEY,
            this.colPLANT_CD,
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
            // colSHIFT_CD_KEY
            // 
            this.colSHIFT_CD_KEY.FieldName = "SHIFT_CD_KEY";
            this.colSHIFT_CD_KEY.Name = "colSHIFT_CD_KEY";
            this.colSHIFT_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colSHIFT_CD_KEY.Visible = true;
            this.colSHIFT_CD_KEY.VisibleIndex = 0;
            // 
            // colVALID_DT_KEY
            // 
            this.colVALID_DT_KEY.FieldName = "VALID_DT_KEY";
            this.colVALID_DT_KEY.Name = "colVALID_DT_KEY";
            this.colVALID_DT_KEY.OptionsColumn.ReadOnly = true;
            this.colVALID_DT_KEY.Visible = true;
            this.colVALID_DT_KEY.VisibleIndex = 1;
            // 
            // colSTART_TM_KEY
            // 
            this.colSTART_TM_KEY.FieldName = "START_TM_KEY";
            this.colSTART_TM_KEY.Name = "colSTART_TM_KEY";
            this.colSTART_TM_KEY.OptionsColumn.ReadOnly = true;
            this.colSTART_TM_KEY.Visible = true;
            this.colSTART_TM_KEY.VisibleIndex = 2;
            // 
            // colWTM_TYPE
            // 
            this.colWTM_TYPE.FieldName = "WTM_TYPE";
            this.colWTM_TYPE.Name = "colWTM_TYPE";
            this.colWTM_TYPE.Visible = true;
            this.colWTM_TYPE.VisibleIndex = 3;
            // 
            // colTM_CD
            // 
            this.colTM_CD.FieldName = "TM_CD";
            this.colTM_CD.Name = "colTM_CD";
            this.colTM_CD.Visible = true;
            this.colTM_CD.VisibleIndex = 4;
            // 
            // colVALID_DT
            // 
            this.colVALID_DT.FieldName = "VALID_DT";
            this.colVALID_DT.Name = "colVALID_DT";
            this.colVALID_DT.Visible = true;
            this.colVALID_DT.VisibleIndex = 5;
            // 
            // colSTART_TM
            // 
            this.colSTART_TM.FieldName = "START_TM";
            this.colSTART_TM.Name = "colSTART_TM";
            this.colSTART_TM.Visible = true;
            this.colSTART_TM.VisibleIndex = 6;
            // 
            // colEND_TM
            // 
            this.colEND_TM.FieldName = "END_TM";
            this.colEND_TM.Name = "colEND_TM";
            this.colEND_TM.Visible = true;
            this.colEND_TM.VisibleIndex = 7;
            // 
            // colWTM_MIN
            // 
            this.colWTM_MIN.FieldName = "WTM_MIN";
            this.colWTM_MIN.Name = "colWTM_MIN";
            this.colWTM_MIN.Visible = true;
            this.colWTM_MIN.VisibleIndex = 8;
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.Visible = true;
            this.colCOMP_CD_KEY.VisibleIndex = 9;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 10;
            // 
            // colPLANT_CD_KEY
            // 
            this.colPLANT_CD_KEY.FieldName = "PLANT_CD_KEY";
            this.colPLANT_CD_KEY.Name = "colPLANT_CD_KEY";
            this.colPLANT_CD_KEY.Visible = true;
            this.colPLANT_CD_KEY.VisibleIndex = 11;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.OptionsColumn.ReadOnly = true;
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 12;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 13;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 14;
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
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 17;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 18;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 19;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 20;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 21;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 22;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 23;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 24;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 25;
            // 
            // OrgPlantWktmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "OrgPlantWktmList";
            this.Text = "OrgPlantWktmList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantWkModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource plantWkModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_DT_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_TM_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colWTM_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colTM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colWTM_MIN;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
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
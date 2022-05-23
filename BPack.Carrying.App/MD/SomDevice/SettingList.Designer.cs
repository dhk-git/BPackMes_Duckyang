namespace BPack.Carrying.App.MD.SomDevice
{
    partial class SettingList
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
            this.settingModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDVC_ID_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODE_ID_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVCS_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVCS_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVCS_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVCS_VALUE_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVCS_VALUE_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVCS_VALUE_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVCS_VALUE_4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVCS_VALUE_5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_1_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_2_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_3_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_4_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUE_5_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.settingModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.settingModelBindingSource;
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
            // settingModelBindingSource
            // 
            this.settingModelBindingSource.DataSource = typeof(BPack.Model.App.MD.SomDevice.SettingModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDVC_ID_KEY,
            this.colMODE_ID_KEY,
            this.colDVCS_CD_KEY,
            this.colDVC_ID,
            this.colMODE_ID,
            this.colDVCS_CD,
            this.colDVCS_NM,
            this.colDVCS_VALUE_1,
            this.colDVCS_VALUE_2,
            this.colDVCS_VALUE_3,
            this.colDVCS_VALUE_4,
            this.colDVCS_VALUE_5,
            this.colREMARK,
            this.colVALUE_1_DESC,
            this.colVALUE_2_DESC,
            this.colVALUE_3_DESC,
            this.colVALUE_4_DESC,
            this.colVALUE_5_DESC,
            this.colREMARK_DESC,
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
            // colDVC_ID_KEY
            // 
            this.colDVC_ID_KEY.FieldName = "DVC_ID_KEY";
            this.colDVC_ID_KEY.Name = "colDVC_ID_KEY";
            this.colDVC_ID_KEY.OptionsColumn.ReadOnly = true;
            this.colDVC_ID_KEY.Visible = true;
            this.colDVC_ID_KEY.VisibleIndex = 0;
            // 
            // colMODE_ID_KEY
            // 
            this.colMODE_ID_KEY.FieldName = "MODE_ID_KEY";
            this.colMODE_ID_KEY.Name = "colMODE_ID_KEY";
            this.colMODE_ID_KEY.OptionsColumn.ReadOnly = true;
            this.colMODE_ID_KEY.Visible = true;
            this.colMODE_ID_KEY.VisibleIndex = 1;
            // 
            // colDVCS_CD_KEY
            // 
            this.colDVCS_CD_KEY.FieldName = "DVCS_CD_KEY";
            this.colDVCS_CD_KEY.Name = "colDVCS_CD_KEY";
            this.colDVCS_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colDVCS_CD_KEY.Visible = true;
            this.colDVCS_CD_KEY.VisibleIndex = 2;
            // 
            // colDVC_ID
            // 
            this.colDVC_ID.FieldName = "DVC_ID";
            this.colDVC_ID.Name = "colDVC_ID";
            this.colDVC_ID.Visible = true;
            this.colDVC_ID.VisibleIndex = 3;
            // 
            // colMODE_ID
            // 
            this.colMODE_ID.FieldName = "MODE_ID";
            this.colMODE_ID.Name = "colMODE_ID";
            this.colMODE_ID.Visible = true;
            this.colMODE_ID.VisibleIndex = 4;
            // 
            // colDVCS_CD
            // 
            this.colDVCS_CD.FieldName = "DVCS_CD";
            this.colDVCS_CD.Name = "colDVCS_CD";
            this.colDVCS_CD.Visible = true;
            this.colDVCS_CD.VisibleIndex = 5;
            // 
            // colDVCS_NM
            // 
            this.colDVCS_NM.FieldName = "DVCS_NM";
            this.colDVCS_NM.Name = "colDVCS_NM";
            this.colDVCS_NM.Visible = true;
            this.colDVCS_NM.VisibleIndex = 6;
            // 
            // colDVCS_VALUE_1
            // 
            this.colDVCS_VALUE_1.FieldName = "DVCS_VALUE_1";
            this.colDVCS_VALUE_1.Name = "colDVCS_VALUE_1";
            this.colDVCS_VALUE_1.Visible = true;
            this.colDVCS_VALUE_1.VisibleIndex = 7;
            // 
            // colDVCS_VALUE_2
            // 
            this.colDVCS_VALUE_2.FieldName = "DVCS_VALUE_2";
            this.colDVCS_VALUE_2.Name = "colDVCS_VALUE_2";
            this.colDVCS_VALUE_2.Visible = true;
            this.colDVCS_VALUE_2.VisibleIndex = 8;
            // 
            // colDVCS_VALUE_3
            // 
            this.colDVCS_VALUE_3.FieldName = "DVCS_VALUE_3";
            this.colDVCS_VALUE_3.Name = "colDVCS_VALUE_3";
            this.colDVCS_VALUE_3.Visible = true;
            this.colDVCS_VALUE_3.VisibleIndex = 9;
            // 
            // colDVCS_VALUE_4
            // 
            this.colDVCS_VALUE_4.FieldName = "DVCS_VALUE_4";
            this.colDVCS_VALUE_4.Name = "colDVCS_VALUE_4";
            this.colDVCS_VALUE_4.Visible = true;
            this.colDVCS_VALUE_4.VisibleIndex = 10;
            // 
            // colDVCS_VALUE_5
            // 
            this.colDVCS_VALUE_5.FieldName = "DVCS_VALUE_5";
            this.colDVCS_VALUE_5.Name = "colDVCS_VALUE_5";
            this.colDVCS_VALUE_5.Visible = true;
            this.colDVCS_VALUE_5.VisibleIndex = 11;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 12;
            // 
            // colVALUE_1_DESC
            // 
            this.colVALUE_1_DESC.FieldName = "VALUE_1_DESC";
            this.colVALUE_1_DESC.Name = "colVALUE_1_DESC";
            this.colVALUE_1_DESC.OptionsColumn.ReadOnly = true;
            this.colVALUE_1_DESC.Visible = true;
            this.colVALUE_1_DESC.VisibleIndex = 13;
            // 
            // colVALUE_2_DESC
            // 
            this.colVALUE_2_DESC.FieldName = "VALUE_2_DESC";
            this.colVALUE_2_DESC.Name = "colVALUE_2_DESC";
            this.colVALUE_2_DESC.OptionsColumn.ReadOnly = true;
            this.colVALUE_2_DESC.Visible = true;
            this.colVALUE_2_DESC.VisibleIndex = 14;
            // 
            // colVALUE_3_DESC
            // 
            this.colVALUE_3_DESC.FieldName = "VALUE_3_DESC";
            this.colVALUE_3_DESC.Name = "colVALUE_3_DESC";
            this.colVALUE_3_DESC.OptionsColumn.ReadOnly = true;
            this.colVALUE_3_DESC.Visible = true;
            this.colVALUE_3_DESC.VisibleIndex = 15;
            // 
            // colVALUE_4_DESC
            // 
            this.colVALUE_4_DESC.FieldName = "VALUE_4_DESC";
            this.colVALUE_4_DESC.Name = "colVALUE_4_DESC";
            this.colVALUE_4_DESC.OptionsColumn.ReadOnly = true;
            this.colVALUE_4_DESC.Visible = true;
            this.colVALUE_4_DESC.VisibleIndex = 16;
            // 
            // colVALUE_5_DESC
            // 
            this.colVALUE_5_DESC.FieldName = "VALUE_5_DESC";
            this.colVALUE_5_DESC.Name = "colVALUE_5_DESC";
            this.colVALUE_5_DESC.OptionsColumn.ReadOnly = true;
            this.colVALUE_5_DESC.Visible = true;
            this.colVALUE_5_DESC.VisibleIndex = 17;
            // 
            // colREMARK_DESC
            // 
            this.colREMARK_DESC.FieldName = "REMARK_DESC";
            this.colREMARK_DESC.Name = "colREMARK_DESC";
            this.colREMARK_DESC.OptionsColumn.ReadOnly = true;
            this.colREMARK_DESC.Visible = true;
            this.colREMARK_DESC.VisibleIndex = 18;
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
            // SettingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "SettingList";
            this.Text = "SettingList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource settingModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDVC_ID_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colMODE_ID_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colDVCS_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colDVC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDVCS_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDVCS_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colDVCS_VALUE_1;
        private DevExpress.XtraGrid.Columns.GridColumn colDVCS_VALUE_2;
        private DevExpress.XtraGrid.Columns.GridColumn colDVCS_VALUE_3;
        private DevExpress.XtraGrid.Columns.GridColumn colDVCS_VALUE_4;
        private DevExpress.XtraGrid.Columns.GridColumn colDVCS_VALUE_5;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_1_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_2_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_3_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_4_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUE_5_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK_DESC;
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
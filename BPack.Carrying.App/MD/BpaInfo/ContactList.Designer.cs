namespace BPack.Carrying.App.MD.BpaInfo
{
    partial class ContactList
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
            this.contGrd = new BPack.Strap.Grid.StrapGridControl();
            this.contModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contGrv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDI_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDI_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTACT_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE_NO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHONE_NO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_FROM_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_TO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.contGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contGrv)).BeginInit();
            this.SuspendLayout();
            // 
            // contGrd
            // 
            this.contGrd.DataSource = this.contModelBindingSource;
            this.contGrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contGrd.IsStrapGridViewDefaultSetting = true;
            this.contGrd.Location = new System.Drawing.Point(0, 0);
            this.contGrd.MainView = this.contGrv;
            this.contGrd.Name = "contGrd";
            this.contGrd.SelectedModel = null;
            this.contGrd.SelectedModelIndex = null;
            this.contGrd.Size = new System.Drawing.Size(800, 450);
            this.contGrd.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.contGrd.TabIndex = 0;
            this.contGrd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.contGrv});
            // 
            // contModelBindingSource
            // 
            this.contModelBindingSource.DataSource = typeof(BPack.Model.App.MD.BpaInfo.ContModel);
            // 
            // contGrv
            // 
            this.contGrv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colBP_CD_KEY,
            this.colADDI_NO_KEY,
            this.colCOMP_CD,
            this.colBP_CD,
            this.colADDI_NO,
            this.colCONTACT_NM,
            this.colPHONE_NO1,
            this.colPHONE_NO2,
            this.colFAX,
            this.colEMAIL,
            this.colVALID_FROM_DT,
            this.colVALID_TO_DT,
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
            this.contGrv.GridControl = this.contGrd;
            this.contGrv.Name = "contGrv";
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD_KEY.Visible = true;
            this.colCOMP_CD_KEY.VisibleIndex = 0;
            // 
            // colBP_CD_KEY
            // 
            this.colBP_CD_KEY.FieldName = "BP_CD_KEY";
            this.colBP_CD_KEY.Name = "colBP_CD_KEY";
            this.colBP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colBP_CD_KEY.Visible = true;
            this.colBP_CD_KEY.VisibleIndex = 1;
            // 
            // colADDI_NO_KEY
            // 
            this.colADDI_NO_KEY.FieldName = "ADDI_NO_KEY";
            this.colADDI_NO_KEY.Name = "colADDI_NO_KEY";
            this.colADDI_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colADDI_NO_KEY.Visible = true;
            this.colADDI_NO_KEY.VisibleIndex = 2;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 3;
            // 
            // colBP_CD
            // 
            this.colBP_CD.FieldName = "BP_CD";
            this.colBP_CD.Name = "colBP_CD";
            this.colBP_CD.Visible = true;
            this.colBP_CD.VisibleIndex = 4;
            // 
            // colADDI_NO
            // 
            this.colADDI_NO.FieldName = "ADDI_NO";
            this.colADDI_NO.Name = "colADDI_NO";
            this.colADDI_NO.Visible = true;
            this.colADDI_NO.VisibleIndex = 5;
            // 
            // colCONTACT_NM
            // 
            this.colCONTACT_NM.FieldName = "CONTACT_NM";
            this.colCONTACT_NM.Name = "colCONTACT_NM";
            this.colCONTACT_NM.Visible = true;
            this.colCONTACT_NM.VisibleIndex = 6;
            // 
            // colPHONE_NO1
            // 
            this.colPHONE_NO1.FieldName = "PHONE_NO1";
            this.colPHONE_NO1.Name = "colPHONE_NO1";
            this.colPHONE_NO1.Visible = true;
            this.colPHONE_NO1.VisibleIndex = 7;
            // 
            // colPHONE_NO2
            // 
            this.colPHONE_NO2.FieldName = "PHONE_NO2";
            this.colPHONE_NO2.Name = "colPHONE_NO2";
            this.colPHONE_NO2.Visible = true;
            this.colPHONE_NO2.VisibleIndex = 8;
            // 
            // colFAX
            // 
            this.colFAX.FieldName = "FAX";
            this.colFAX.Name = "colFAX";
            this.colFAX.Visible = true;
            this.colFAX.VisibleIndex = 9;
            // 
            // colEMAIL
            // 
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 10;
            // 
            // colVALID_FROM_DT
            // 
            this.colVALID_FROM_DT.FieldName = "VALID_FROM_DT";
            this.colVALID_FROM_DT.Name = "colVALID_FROM_DT";
            this.colVALID_FROM_DT.Visible = true;
            this.colVALID_FROM_DT.VisibleIndex = 11;
            // 
            // colVALID_TO_DT
            // 
            this.colVALID_TO_DT.FieldName = "VALID_TO_DT";
            this.colVALID_TO_DT.Name = "colVALID_TO_DT";
            this.colVALID_TO_DT.Visible = true;
            this.colVALID_TO_DT.VisibleIndex = 12;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 13;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 14;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 15;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 16;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 17;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 18;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 19;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 20;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 21;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 22;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 23;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 24;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 25;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 26;
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contGrd);
            this.Name = "ContactList";
            this.Text = "ContactList";
            ((System.ComponentModel.ISupportInitialize)(this.contGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contGrv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl contGrd;
        private DevExpress.XtraGrid.Views.Grid.GridView contGrv;
        private System.Windows.Forms.BindingSource contModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colADDI_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colADDI_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTACT_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE_NO1;
        private DevExpress.XtraGrid.Columns.GridColumn colPHONE_NO2;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_FROM_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_TO_DT;
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
    }
}
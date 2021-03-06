namespace BPack.Carrying.App.MD.PrdWorkCenter
{
    partial class EquipList
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
            this.eqiupModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWC_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_BARCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.eqiupModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.eqiupModelBindingSource;
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
            // eqiupModelBindingSource
            // 
            this.eqiupModelBindingSource.DataSource = typeof(BPack.Model.App.MD.PrdWorkCenter.EquipModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWC_CD_KEY,
            this.colCOMP_CD_KEY,
            this.colPLANT_CD_KEY,
            this.colEQUIP_CD_KEY,
            this.colWC_CD,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colEQUIP_CD,
            this.colEQUIP_NM,
            this.colEQUIP_CLS,
            this.colEQUIP_BARCODE,
            this.colREMARK,
            this.colDEL_FG,
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
            // colWC_CD_KEY
            // 
            this.colWC_CD_KEY.FieldName = "WC_CD_KEY";
            this.colWC_CD_KEY.Name = "colWC_CD_KEY";
            this.colWC_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colWC_CD_KEY.Visible = true;
            this.colWC_CD_KEY.VisibleIndex = 0;
            this.colWC_CD_KEY.Width = 31;
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD_KEY.Visible = true;
            this.colCOMP_CD_KEY.VisibleIndex = 1;
            this.colCOMP_CD_KEY.Width = 31;
            // 
            // colPLANT_CD_KEY
            // 
            this.colPLANT_CD_KEY.FieldName = "PLANT_CD_KEY";
            this.colPLANT_CD_KEY.Name = "colPLANT_CD_KEY";
            this.colPLANT_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colPLANT_CD_KEY.Visible = true;
            this.colPLANT_CD_KEY.VisibleIndex = 2;
            this.colPLANT_CD_KEY.Width = 31;
            // 
            // colEQUIP_CD_KEY
            // 
            this.colEQUIP_CD_KEY.FieldName = "EQUIP_CD_KEY";
            this.colEQUIP_CD_KEY.Name = "colEQUIP_CD_KEY";
            this.colEQUIP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colEQUIP_CD_KEY.Visible = true;
            this.colEQUIP_CD_KEY.VisibleIndex = 3;
            this.colEQUIP_CD_KEY.Width = 31;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 4;
            this.colWC_CD.Width = 31;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 5;
            this.colCOMP_CD.Width = 31;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 6;
            this.colPLANT_CD.Width = 31;
            // 
            // colEQUIP_CD
            // 
            this.colEQUIP_CD.FieldName = "EQUIP_CD";
            this.colEQUIP_CD.Name = "colEQUIP_CD";
            this.colEQUIP_CD.Visible = true;
            this.colEQUIP_CD.VisibleIndex = 7;
            this.colEQUIP_CD.Width = 31;
            // 
            // colEQUIP_NM
            // 
            this.colEQUIP_NM.FieldName = "EQUIP_NM";
            this.colEQUIP_NM.Name = "colEQUIP_NM";
            this.colEQUIP_NM.OptionsColumn.ReadOnly = true;
            this.colEQUIP_NM.Visible = true;
            this.colEQUIP_NM.VisibleIndex = 8;
            this.colEQUIP_NM.Width = 31;
            // 
            // colEQUIP_CLS
            // 
            this.colEQUIP_CLS.FieldName = "EQUIP_CLS";
            this.colEQUIP_CLS.Name = "colEQUIP_CLS";
            this.colEQUIP_CLS.OptionsColumn.ReadOnly = true;
            this.colEQUIP_CLS.Visible = true;
            this.colEQUIP_CLS.VisibleIndex = 9;
            this.colEQUIP_CLS.Width = 31;
            // 
            // colEQUIP_BARCODE
            // 
            this.colEQUIP_BARCODE.FieldName = "EQUIP_BARCODE";
            this.colEQUIP_BARCODE.Name = "colEQUIP_BARCODE";
            this.colEQUIP_BARCODE.OptionsColumn.ReadOnly = true;
            this.colEQUIP_BARCODE.Visible = true;
            this.colEQUIP_BARCODE.VisibleIndex = 10;
            this.colEQUIP_BARCODE.Width = 31;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 11;
            this.colREMARK.Width = 31;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 12;
            this.colDEL_FG.Width = 31;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 13;
            this.colMODIFY_DTTM.Width = 31;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 14;
            this.colMODIFY_USER_ID.Width = 31;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 15;
            this.colVALID.Width = 31;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 16;
            this.colSORT_NO.Width = 31;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 17;
            this.colROW_SEQ.Width = 31;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 18;
            this.colCREATE_DTTM.Width = 31;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 19;
            this.colCREATE_USER_ID.Width = 31;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 20;
            this.colLANG_CODE.Width = 31;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 21;
            this.colRowState.Width = 31;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 22;
            this.colCrudCls.Width = 31;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 23;
            this.colSelectedCheck.Width = 31;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 24;
            this.colIsCheck.Width = 45;
            // 
            // EquipList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "EquipList";
            this.Text = "EqiupList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqiupModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource eqiupModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CLS;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_BARCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_FG;
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

namespace BPack.Carrying.App.MD.PrdShift
{
    partial class ShiftList
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
            this.shiftModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_GROUP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_GROUP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_START_NEXT_DAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_START_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_END_NEXT_DAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_END_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTWORK_GROUP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTWORK_CD = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colOVERTIME_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.shiftModelBindingSource;
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
            // shiftModelBindingSource
            // 
            this.shiftModelBindingSource.DataSource = typeof(BPack.Model.App.MD.PrdShift.ShiftModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colPLANT_CD_KEY,
            this.colSHIFT_GROUP_CD_KEY,
            this.colSHIFT_CD_KEY,
            this.colIsCheck,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colSHIFT_GROUP_CD,
            this.colSHIFT_CD,
            this.colSEQ,
            this.colIS_START_NEXT_DAY,
            this.colWORK_START_TIME,
            this.colIS_END_NEXT_DAY,
            this.colWORK_END_TIME,
            this.colOVERTIME_STATUS,
            this.colWORK_STATUS,
            this.colNOTWORK_GROUP_CD,
            this.colNOTWORK_CD,
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
            this.colSelectedCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.OptionsColumn.ReadOnly = true;
            // 
            // colPLANT_CD_KEY
            // 
            this.colPLANT_CD_KEY.FieldName = "PLANT_CD_KEY";
            this.colPLANT_CD_KEY.Name = "colPLANT_CD_KEY";
            this.colPLANT_CD_KEY.OptionsColumn.ReadOnly = true;
            // 
            // colSHIFT_GROUP_CD_KEY
            // 
            this.colSHIFT_GROUP_CD_KEY.FieldName = "SHIFT_GROUP_CD_KEY";
            this.colSHIFT_GROUP_CD_KEY.Name = "colSHIFT_GROUP_CD_KEY";
            this.colSHIFT_GROUP_CD_KEY.OptionsColumn.ReadOnly = true;
            // 
            // colSHIFT_CD_KEY
            // 
            this.colSHIFT_CD_KEY.FieldName = "SHIFT_CD_KEY";
            this.colSHIFT_CD_KEY.Name = "colSHIFT_CD_KEY";
            this.colSHIFT_CD_KEY.OptionsColumn.ReadOnly = true;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 0;
            this.colIsCheck.Width = 48;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.OptionsColumn.ReadOnly = true;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.OptionsColumn.ReadOnly = true;
            // 
            // colSHIFT_GROUP_CD
            // 
            this.colSHIFT_GROUP_CD.FieldName = "SHIFT_GROUP_CD";
            this.colSHIFT_GROUP_CD.Name = "colSHIFT_GROUP_CD";
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            this.colSHIFT_CD.Visible = true;
            this.colSHIFT_CD.VisibleIndex = 1;
            this.colSHIFT_CD.Width = 48;
            // 
            // colSEQ
            // 
            this.colSEQ.FieldName = "SEQ";
            this.colSEQ.Name = "colSEQ";
            this.colSEQ.Visible = true;
            this.colSEQ.VisibleIndex = 2;
            this.colSEQ.Width = 48;
            // 
            // colIS_START_NEXT_DAY
            // 
            this.colIS_START_NEXT_DAY.FieldName = "IS_START_NEXT_DAY";
            this.colIS_START_NEXT_DAY.Name = "colIS_START_NEXT_DAY";
            this.colIS_START_NEXT_DAY.Visible = true;
            this.colIS_START_NEXT_DAY.VisibleIndex = 3;
            this.colIS_START_NEXT_DAY.Width = 48;
            // 
            // colWORK_START_TIME
            // 
            this.colWORK_START_TIME.FieldName = "WORK_START_TIME";
            this.colWORK_START_TIME.Name = "colWORK_START_TIME";
            this.colWORK_START_TIME.Visible = true;
            this.colWORK_START_TIME.VisibleIndex = 4;
            this.colWORK_START_TIME.Width = 48;
            // 
            // colIS_END_NEXT_DAY
            // 
            this.colIS_END_NEXT_DAY.FieldName = "IS_END_NEXT_DAY";
            this.colIS_END_NEXT_DAY.Name = "colIS_END_NEXT_DAY";
            this.colIS_END_NEXT_DAY.Visible = true;
            this.colIS_END_NEXT_DAY.VisibleIndex = 5;
            this.colIS_END_NEXT_DAY.Width = 48;
            // 
            // colWORK_END_TIME
            // 
            this.colWORK_END_TIME.FieldName = "WORK_END_TIME";
            this.colWORK_END_TIME.Name = "colWORK_END_TIME";
            this.colWORK_END_TIME.Visible = true;
            this.colWORK_END_TIME.VisibleIndex = 6;
            this.colWORK_END_TIME.Width = 48;
            // 
            // colWORK_STATUS
            // 
            this.colWORK_STATUS.FieldName = "WORK_STATUS";
            this.colWORK_STATUS.Name = "colWORK_STATUS";
            this.colWORK_STATUS.Visible = true;
            this.colWORK_STATUS.VisibleIndex = 8;
            this.colWORK_STATUS.Width = 45;
            // 
            // colNOTWORK_GROUP_CD
            // 
            this.colNOTWORK_GROUP_CD.FieldName = "NOTWORK_GROUP_CD";
            this.colNOTWORK_GROUP_CD.Name = "colNOTWORK_GROUP_CD";
            this.colNOTWORK_GROUP_CD.Visible = true;
            this.colNOTWORK_GROUP_CD.VisibleIndex = 9;
            this.colNOTWORK_GROUP_CD.Width = 45;
            // 
            // colNOTWORK_CD
            // 
            this.colNOTWORK_CD.FieldName = "NOTWORK_CD";
            this.colNOTWORK_CD.Name = "colNOTWORK_CD";
            this.colNOTWORK_CD.Visible = true;
            this.colNOTWORK_CD.VisibleIndex = 10;
            this.colNOTWORK_CD.Width = 45;
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
            this.colREMARK.VisibleIndex = 11;
            this.colREMARK.Width = 45;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 12;
            this.colCREATE_DTTM.Width = 45;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 13;
            this.colCREATE_USER_ID.Width = 45;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 14;
            this.colMODIFY_DTTM.Width = 45;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 15;
            this.colMODIFY_USER_ID.Width = 52;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            // 
            // colOVERTIME_STATUS
            // 
            this.colOVERTIME_STATUS.FieldName = "OVERTIME_STATUS";
            this.colOVERTIME_STATUS.Name = "colOVERTIME_STATUS";
            this.colOVERTIME_STATUS.Visible = true;
            this.colOVERTIME_STATUS.VisibleIndex = 7;
            this.colOVERTIME_STATUS.Width = 72;
            // 
            // ShiftList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "ShiftList";
            this.Text = "ShiftList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource shiftModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_GROUP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_GROUP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_START_NEXT_DAY;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_START_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_END_NEXT_DAY;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_END_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTWORK_GROUP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTWORK_CD;
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
        private DevExpress.XtraGrid.Columns.GridColumn colOVERTIME_STATUS;
    }
}
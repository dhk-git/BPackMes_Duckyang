
namespace BPack.Carrying.App.PC.WoeNwRsPivot
{
    partial class WoeNwRsPivotNotWorkList
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
            this.nwRsPivotNotworkModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSEQ_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYEAR_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWEEK_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONTH_WEEK_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_GROUP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTWORK_GROUP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTWORK_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.nwRsPivotNotworkModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.nwRsPivotNotworkModelBindingSource;
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
            // nwRsPivotNotworkModelBindingSource
            // 
            this.nwRsPivotNotworkModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WoeNwRsPivot.NwRsPivotNotworkModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSEQ_KEY,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colYEAR_CD,
            this.colMONTH_CD,
            this.colWEEK_CD,
            this.colMONTH_WEEK_CD,
            this.colWORK_DT,
            this.colSHIFT_GROUP_CD,
            this.colSHIFT_CD,
            this.colWC_CD,
            this.colNOTWORK_GROUP_CD,
            this.colNOTWORK_CD,
            this.colSTART_DTTM,
            this.colEND_DTTM,
            this.colTOTAL_TIME,
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
            // 
            // colSEQ_KEY
            // 
            this.colSEQ_KEY.FieldName = "SEQ_KEY";
            this.colSEQ_KEY.Name = "colSEQ_KEY";
            this.colSEQ_KEY.OptionsColumn.ReadOnly = true;
            this.colSEQ_KEY.Visible = true;
            this.colSEQ_KEY.VisibleIndex = 0;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 1;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 2;
            // 
            // colYEAR_CD
            // 
            this.colYEAR_CD.FieldName = "YEAR_CD";
            this.colYEAR_CD.Name = "colYEAR_CD";
            this.colYEAR_CD.Visible = true;
            this.colYEAR_CD.VisibleIndex = 3;
            // 
            // colMONTH_CD
            // 
            this.colMONTH_CD.FieldName = "MONTH_CD";
            this.colMONTH_CD.Name = "colMONTH_CD";
            this.colMONTH_CD.Visible = true;
            this.colMONTH_CD.VisibleIndex = 4;
            // 
            // colWEEK_CD
            // 
            this.colWEEK_CD.FieldName = "WEEK_CD";
            this.colWEEK_CD.Name = "colWEEK_CD";
            this.colWEEK_CD.Visible = true;
            this.colWEEK_CD.VisibleIndex = 5;
            // 
            // colMONTH_WEEK_CD
            // 
            this.colMONTH_WEEK_CD.FieldName = "MONTH_WEEK_CD";
            this.colMONTH_WEEK_CD.Name = "colMONTH_WEEK_CD";
            this.colMONTH_WEEK_CD.Visible = true;
            this.colMONTH_WEEK_CD.VisibleIndex = 6;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 7;
            // 
            // colSHIFT_GROUP_CD
            // 
            this.colSHIFT_GROUP_CD.FieldName = "SHIFT_GROUP_CD";
            this.colSHIFT_GROUP_CD.Name = "colSHIFT_GROUP_CD";
            this.colSHIFT_GROUP_CD.Visible = true;
            this.colSHIFT_GROUP_CD.VisibleIndex = 8;
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            this.colSHIFT_CD.Visible = true;
            this.colSHIFT_CD.VisibleIndex = 9;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.OptionsColumn.ReadOnly = true;
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 10;
            // 
            // colNOTWORK_GROUP_CD
            // 
            this.colNOTWORK_GROUP_CD.FieldName = "NOTWORK_GROUP_CD";
            this.colNOTWORK_GROUP_CD.Name = "colNOTWORK_GROUP_CD";
            this.colNOTWORK_GROUP_CD.Visible = true;
            this.colNOTWORK_GROUP_CD.VisibleIndex = 11;
            // 
            // colNOTWORK_CD
            // 
            this.colNOTWORK_CD.FieldName = "NOTWORK_CD";
            this.colNOTWORK_CD.Name = "colNOTWORK_CD";
            this.colNOTWORK_CD.Visible = true;
            this.colNOTWORK_CD.VisibleIndex = 12;
            // 
            // colSTART_DTTM
            // 
            this.colSTART_DTTM.FieldName = "START_DTTM";
            this.colSTART_DTTM.Name = "colSTART_DTTM";
            this.colSTART_DTTM.Visible = true;
            this.colSTART_DTTM.VisibleIndex = 13;
            // 
            // colEND_DTTM
            // 
            this.colEND_DTTM.FieldName = "END_DTTM";
            this.colEND_DTTM.Name = "colEND_DTTM";
            this.colEND_DTTM.Visible = true;
            this.colEND_DTTM.VisibleIndex = 14;
            // 
            // colTOTAL_TIME
            // 
            this.colTOTAL_TIME.FieldName = "TOTAL_TIME";
            this.colTOTAL_TIME.Name = "colTOTAL_TIME";
            this.colTOTAL_TIME.OptionsColumn.ReadOnly = true;
            this.colTOTAL_TIME.Visible = true;
            this.colTOTAL_TIME.VisibleIndex = 15;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 16;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 17;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 18;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 19;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 20;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 21;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 22;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 23;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 24;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 25;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 26;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 27;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 28;
            // 
            // WoeNwRsPivotNotWorkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WoeNwRsPivotNotWorkList";
            this.Text = "WoeNwRsPivotNotWorkList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwRsPivotNotworkModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nwRsPivotNotworkModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSEQ_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colYEAR_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWEEK_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMONTH_WEEK_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_GROUP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTWORK_GROUP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTWORK_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL_TIME;
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
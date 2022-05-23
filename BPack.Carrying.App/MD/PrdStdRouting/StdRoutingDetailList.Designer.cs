namespace BPack.Carrying.App.MD.PrdStdRouting
{
    partial class StdRoutingDetailList
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
            this.stdRoutingDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTR_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTR_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_LOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGD_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGD_LOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.stdRoutingDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.stdRoutingDetailModelBindingSource;
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
            // stdRoutingDetailModelBindingSource
            // 
            this.stdRoutingDetailModelBindingSource.DataSource = typeof(BPack.Model.App.MD.PrdStdRouting.StdRoutingDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTR_NO_KEY,
            this.colOPER_KEY,
            this.colSTR_NO,
            this.colOPER,
            this.colOPER_DESC,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWC_CD,
            this.colMAT_WH_CD,
            this.colMAT_LOC_CD,
            this.colGD_WH_CD,
            this.colGD_LOC_CD,
            this.colDVC_ID,
            this.colMODE_ID,
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
            // colSTR_NO_KEY
            // 
            this.colSTR_NO_KEY.FieldName = "STR_NO_KEY";
            this.colSTR_NO_KEY.Name = "colSTR_NO_KEY";
            this.colSTR_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colSTR_NO_KEY.Visible = true;
            this.colSTR_NO_KEY.VisibleIndex = 0;
            // 
            // colOPER_KEY
            // 
            this.colOPER_KEY.FieldName = "OPER_KEY";
            this.colOPER_KEY.Name = "colOPER_KEY";
            this.colOPER_KEY.OptionsColumn.ReadOnly = true;
            this.colOPER_KEY.Visible = true;
            this.colOPER_KEY.VisibleIndex = 1;
            // 
            // colSTR_NO
            // 
            this.colSTR_NO.FieldName = "STR_NO";
            this.colSTR_NO.Name = "colSTR_NO";
            this.colSTR_NO.Visible = true;
            this.colSTR_NO.VisibleIndex = 2;
            // 
            // colOPER
            // 
            this.colOPER.FieldName = "OPER";
            this.colOPER.Name = "colOPER";
            this.colOPER.Visible = true;
            this.colOPER.VisibleIndex = 3;
            // 
            // colOPER_DESC
            // 
            this.colOPER_DESC.FieldName = "OPER_DESC";
            this.colOPER_DESC.Name = "colOPER_DESC";
            this.colOPER_DESC.Visible = true;
            this.colOPER_DESC.VisibleIndex = 4;
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
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 7;
            // 
            // colMAT_WH_CD
            // 
            this.colMAT_WH_CD.FieldName = "MAT_WH_CD";
            this.colMAT_WH_CD.Name = "colMAT_WH_CD";
            this.colMAT_WH_CD.Visible = true;
            this.colMAT_WH_CD.VisibleIndex = 8;
            // 
            // colMAT_LOC_CD
            // 
            this.colMAT_LOC_CD.FieldName = "MAT_LOC_CD";
            this.colMAT_LOC_CD.Name = "colMAT_LOC_CD";
            this.colMAT_LOC_CD.Visible = true;
            this.colMAT_LOC_CD.VisibleIndex = 9;
            // 
            // colGD_WH_CD
            // 
            this.colGD_WH_CD.FieldName = "GD_WH_CD";
            this.colGD_WH_CD.Name = "colGD_WH_CD";
            this.colGD_WH_CD.Visible = true;
            this.colGD_WH_CD.VisibleIndex = 10;
            // 
            // colGD_LOC_CD
            // 
            this.colGD_LOC_CD.FieldName = "GD_LOC_CD";
            this.colGD_LOC_CD.Name = "colGD_LOC_CD";
            this.colGD_LOC_CD.Visible = true;
            this.colGD_LOC_CD.VisibleIndex = 11;
            // 
            // colDVC_ID
            // 
            this.colDVC_ID.FieldName = "DVC_ID";
            this.colDVC_ID.Name = "colDVC_ID";
            this.colDVC_ID.Visible = true;
            this.colDVC_ID.VisibleIndex = 12;
            // 
            // colMODE_ID
            // 
            this.colMODE_ID.FieldName = "MODE_ID";
            this.colMODE_ID.Name = "colMODE_ID";
            this.colMODE_ID.Visible = true;
            this.colMODE_ID.VisibleIndex = 13;
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
            // StdRoutingDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "StdRoutingDetailList";
            this.Text = "StdRoutingDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdRoutingDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource stdRoutingDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSTR_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colSTR_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_LOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGD_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGD_LOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDVC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODE_ID;
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
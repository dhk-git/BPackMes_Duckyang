namespace BPack.Carrying.App.PC.WorWorkOrder
{
    partial class WorkOrderDetailList
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
            this.workOrderDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWO_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROUTE_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROUTE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOLD_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_HU_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_LOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGD_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGD_LOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWOD_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.workOrderDetailModelBindingSource;
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
            // workOrderDetailModelBindingSource
            // 
            this.workOrderDetailModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WorWorkOrder.WorkOrderDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWO_NO_KEY,
            this.colROUTE_NO_KEY,
            this.colOPER_KEY,
            this.colWO_NO,
            this.colROUTE_NO,
            this.colOPER,
            this.colOPER_DESC,
            this.colWC_CD,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colMOLD_CD,
            this.colRST_HU_TYPE,
            this.colMAT_WH_CD,
            this.colMAT_LOC_CD,
            this.colGD_WH_CD,
            this.colGD_LOC_CD,
            this.colDVC_ID,
            this.colMODE_ID,
            this.colWOD_STATUS,
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
            // colWO_NO_KEY
            // 
            this.colWO_NO_KEY.FieldName = "WO_NO_KEY";
            this.colWO_NO_KEY.Name = "colWO_NO_KEY";
            this.colWO_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colWO_NO_KEY.Visible = true;
            this.colWO_NO_KEY.VisibleIndex = 0;
            // 
            // colROUTE_NO_KEY
            // 
            this.colROUTE_NO_KEY.FieldName = "ROUTE_NO_KEY";
            this.colROUTE_NO_KEY.Name = "colROUTE_NO_KEY";
            this.colROUTE_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colROUTE_NO_KEY.Visible = true;
            this.colROUTE_NO_KEY.VisibleIndex = 1;
            // 
            // colOPER_KEY
            // 
            this.colOPER_KEY.FieldName = "OPER_KEY";
            this.colOPER_KEY.Name = "colOPER_KEY";
            this.colOPER_KEY.OptionsColumn.ReadOnly = true;
            this.colOPER_KEY.Visible = true;
            this.colOPER_KEY.VisibleIndex = 2;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 3;
            // 
            // colROUTE_NO
            // 
            this.colROUTE_NO.FieldName = "ROUTE_NO";
            this.colROUTE_NO.Name = "colROUTE_NO";
            this.colROUTE_NO.Visible = true;
            this.colROUTE_NO.VisibleIndex = 4;
            // 
            // colOPER
            // 
            this.colOPER.FieldName = "OPER";
            this.colOPER.Name = "colOPER";
            this.colOPER.Visible = true;
            this.colOPER.VisibleIndex = 5;
            // 
            // colOPER_DESC
            // 
            this.colOPER_DESC.FieldName = "OPER_DESC";
            this.colOPER_DESC.Name = "colOPER_DESC";
            this.colOPER_DESC.Visible = true;
            this.colOPER_DESC.VisibleIndex = 6;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 7;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 8;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 9;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 10;
            // 
            // colMOLD_CD
            // 
            this.colMOLD_CD.FieldName = "MOLD_CD";
            this.colMOLD_CD.Name = "colMOLD_CD";
            this.colMOLD_CD.Visible = true;
            this.colMOLD_CD.VisibleIndex = 11;
            // 
            // colRST_HU_TYPE
            // 
            this.colRST_HU_TYPE.FieldName = "RST_HU_TYPE";
            this.colRST_HU_TYPE.Name = "colRST_HU_TYPE";
            this.colRST_HU_TYPE.Visible = true;
            this.colRST_HU_TYPE.VisibleIndex = 12;
            // 
            // colMAT_WH_CD
            // 
            this.colMAT_WH_CD.FieldName = "MAT_WH_CD";
            this.colMAT_WH_CD.Name = "colMAT_WH_CD";
            this.colMAT_WH_CD.Visible = true;
            this.colMAT_WH_CD.VisibleIndex = 13;
            // 
            // colMAT_LOC_CD
            // 
            this.colMAT_LOC_CD.FieldName = "MAT_LOC_CD";
            this.colMAT_LOC_CD.Name = "colMAT_LOC_CD";
            this.colMAT_LOC_CD.Visible = true;
            this.colMAT_LOC_CD.VisibleIndex = 14;
            // 
            // colGD_WH_CD
            // 
            this.colGD_WH_CD.FieldName = "GD_WH_CD";
            this.colGD_WH_CD.Name = "colGD_WH_CD";
            this.colGD_WH_CD.Visible = true;
            this.colGD_WH_CD.VisibleIndex = 15;
            // 
            // colGD_LOC_CD
            // 
            this.colGD_LOC_CD.FieldName = "GD_LOC_CD";
            this.colGD_LOC_CD.Name = "colGD_LOC_CD";
            this.colGD_LOC_CD.Visible = true;
            this.colGD_LOC_CD.VisibleIndex = 16;
            // 
            // colDVC_ID
            // 
            this.colDVC_ID.FieldName = "DVC_ID";
            this.colDVC_ID.Name = "colDVC_ID";
            this.colDVC_ID.Visible = true;
            this.colDVC_ID.VisibleIndex = 17;
            // 
            // colMODE_ID
            // 
            this.colMODE_ID.FieldName = "MODE_ID";
            this.colMODE_ID.Name = "colMODE_ID";
            this.colMODE_ID.Visible = true;
            this.colMODE_ID.VisibleIndex = 18;
            // 
            // colWOD_STATUS
            // 
            this.colWOD_STATUS.FieldName = "WOD_STATUS";
            this.colWOD_STATUS.Name = "colWOD_STATUS";
            this.colWOD_STATUS.Visible = true;
            this.colWOD_STATUS.VisibleIndex = 19;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 20;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 21;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 22;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 23;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 24;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 25;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 26;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 27;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 28;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 29;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 30;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 31;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 32;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 33;
            // 
            // WorkOrderDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WorkOrderDetailList";
            this.Text = "WorkOrderDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource workOrderDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTE_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMOLD_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_HU_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_LOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGD_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGD_LOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDVC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colWOD_STATUS;
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
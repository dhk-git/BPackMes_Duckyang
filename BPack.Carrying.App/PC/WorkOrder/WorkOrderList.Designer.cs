namespace BPack.Carrying.App.PC.WorkOrder
{
    partial class WorkOrderList
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
            this.sgcList = new BPack.Strap.Grid.StrapGridControl();
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWO_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDER_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDER_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_GROUP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOT_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWOR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUPH_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGD_WH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBOM_NO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.sgcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sgcList
            // 
            this.sgcList.ArgsBase = null;
            this.sgcList.DataSource = this.bsList;
            this.sgcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgcList.IsStrapGridViewDefaultSetting = true;
            this.sgcList.Location = new System.Drawing.Point(0, 0);
            this.sgcList.MainView = this.gridView1;
            this.sgcList.Name = "sgcList";
            this.sgcList.SelectedModel = null;
            this.sgcList.SelectedModelIndex = null;
            this.sgcList.Size = new System.Drawing.Size(800, 450);
            this.sgcList.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.sgcList.StrapMdiForm = null;
            this.sgcList.StrapSubForm = null;
            this.sgcList.TabIndex = 0;
            this.sgcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsList
            // 
            this.bsList.DataSource = typeof(BPack.Model.App.PC.WorkOrder.WorkOrderModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWO_NO_KEY,
            this.colIsCheck,
            this.colORDER_TYPE,
            this.colORDER_STATUS,
            this.colWO_NO,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colWC_CD,
            this.colWO_DT,
            this.colSHIFT_GROUP_CD,
            this.colSHIFT_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colLOT_SIZE,
            this.colWOR_QTY,
            this.colUPH_QTY,
            this.colMAT_WH_CD,
            this.colGD_WH_CD,
            this.colBOM_NO,
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
            this.gridView1.GridControl = this.sgcList;
            this.gridView1.Name = "gridView1";
            // 
            // colWO_NO_KEY
            // 
            this.colWO_NO_KEY.FieldName = "WO_NO_KEY";
            this.colWO_NO_KEY.Name = "colWO_NO_KEY";
            this.colWO_NO_KEY.OptionsColumn.ReadOnly = true;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.MaxWidth = 10;
            this.colIsCheck.MinWidth = 10;
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 0;
            this.colIsCheck.Width = 10;
            // 
            // colORDER_TYPE
            // 
            this.colORDER_TYPE.FieldName = "ORDER_TYPE";
            this.colORDER_TYPE.Name = "colORDER_TYPE";
            this.colORDER_TYPE.Visible = true;
            this.colORDER_TYPE.VisibleIndex = 1;
            this.colORDER_TYPE.Width = 36;
            // 
            // colORDER_STATUS
            // 
            this.colORDER_STATUS.FieldName = "ORDER_STATUS";
            this.colORDER_STATUS.Name = "colORDER_STATUS";
            this.colORDER_STATUS.Visible = true;
            this.colORDER_STATUS.VisibleIndex = 2;
            this.colORDER_STATUS.Width = 30;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 3;
            this.colWO_NO.Width = 42;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 4;
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            this.colPLANT_CD.Visible = true;
            this.colPLANT_CD.VisibleIndex = 5;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 6;
            this.colWC_CD.Width = 35;
            // 
            // colWO_DT
            // 
            this.colWO_DT.FieldName = "WO_DT";
            this.colWO_DT.Name = "colWO_DT";
            this.colWO_DT.Visible = true;
            this.colWO_DT.VisibleIndex = 7;
            this.colWO_DT.Width = 35;
            // 
            // colSHIFT_GROUP_CD
            // 
            this.colSHIFT_GROUP_CD.FieldName = "SHIFT_GROUP_CD";
            this.colSHIFT_GROUP_CD.Name = "colSHIFT_GROUP_CD";
            this.colSHIFT_GROUP_CD.Visible = true;
            this.colSHIFT_GROUP_CD.VisibleIndex = 8;
            this.colSHIFT_GROUP_CD.Width = 35;
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            this.colSHIFT_CD.Visible = true;
            this.colSHIFT_CD.VisibleIndex = 9;
            this.colSHIFT_CD.Width = 35;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 10;
            this.colITEM_CD.Width = 35;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 11;
            this.colITEM_NM.Width = 35;
            // 
            // colLOT_SIZE
            // 
            this.colLOT_SIZE.FieldName = "LOT_SIZE";
            this.colLOT_SIZE.Name = "colLOT_SIZE";
            this.colLOT_SIZE.Visible = true;
            this.colLOT_SIZE.VisibleIndex = 12;
            this.colLOT_SIZE.Width = 35;
            // 
            // colWOR_QTY
            // 
            this.colWOR_QTY.FieldName = "WOR_QTY";
            this.colWOR_QTY.Name = "colWOR_QTY";
            this.colWOR_QTY.Visible = true;
            this.colWOR_QTY.VisibleIndex = 13;
            this.colWOR_QTY.Width = 35;
            // 
            // colUPH_QTY
            // 
            this.colUPH_QTY.FieldName = "UPH_QTY";
            this.colUPH_QTY.Name = "colUPH_QTY";
            this.colUPH_QTY.Visible = true;
            this.colUPH_QTY.VisibleIndex = 14;
            this.colUPH_QTY.Width = 35;
            // 
            // colMAT_WH_CD
            // 
            this.colMAT_WH_CD.FieldName = "MAT_WH_CD";
            this.colMAT_WH_CD.Name = "colMAT_WH_CD";
            this.colMAT_WH_CD.Visible = true;
            this.colMAT_WH_CD.VisibleIndex = 15;
            this.colMAT_WH_CD.Width = 35;
            // 
            // colGD_WH_CD
            // 
            this.colGD_WH_CD.FieldName = "GD_WH_CD";
            this.colGD_WH_CD.Name = "colGD_WH_CD";
            this.colGD_WH_CD.Visible = true;
            this.colGD_WH_CD.VisibleIndex = 16;
            this.colGD_WH_CD.Width = 35;
            // 
            // colBOM_NO
            // 
            this.colBOM_NO.FieldName = "BOM_NO";
            this.colBOM_NO.Name = "colBOM_NO";
            this.colBOM_NO.Visible = true;
            this.colBOM_NO.VisibleIndex = 17;
            this.colBOM_NO.Width = 35;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 18;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 19;
            this.colREMARK.Width = 35;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 20;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 21;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 22;
            this.colCREATE_DTTM.Width = 35;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 23;
            this.colCREATE_USER_ID.Width = 35;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Width = 35;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Width = 71;
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
            // WorkOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sgcList);
            this.Name = "WorkOrderList";
            this.Text = "WorkOrderList";
            ((System.ComponentModel.ISupportInitialize)(this.sgcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl sgcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsList;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBOM_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colLOT_SIZE;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_GROUP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colWOR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colUPH_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_WH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGD_WH_CD;
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
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colORDER_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colORDER_STATUS;
    }
}
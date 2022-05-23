
namespace BPack.Carrying.App.SD.SalesOrder
{
    partial class SalesOrderDetailList
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
            this.salesOrderDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOD_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOD_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOR_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOD_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOR_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOD_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOD_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOD_AMOUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURRENCY_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUE_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUSTOM_PO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOD_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOD_DLV_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.salesOrderDetailModelBindingSource;
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
            // salesOrderDetailModelBindingSource
            // 
            this.salesOrderDetailModelBindingSource.DataSource = typeof(BPack.Model.App.SD.SalesOrder.SalesOrderDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOD_NO_KEY,
            this.colSOD_NO,
            this.colSOR_NO,
            this.colSOD_SEQ,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_SPEC,
            this.colITEM_GR_1,
            this.colSOR_DT,
            this.colSOD_QTY,
            this.colSOD_PRICE,
            this.colSOD_AMOUNT,
            this.colCURRENCY_TYPE,
            this.colDUE_DT,
            this.colCUSTOM_PO_NO,
            this.colSOD_STATUS,
            this.colSOD_DLV_STATUS,
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
            // colSOD_NO_KEY
            // 
            this.colSOD_NO_KEY.FieldName = "SOD_NO_KEY";
            this.colSOD_NO_KEY.Name = "colSOD_NO_KEY";
            this.colSOD_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colSOD_NO_KEY.Visible = true;
            this.colSOD_NO_KEY.VisibleIndex = 0;
            // 
            // colSOD_NO
            // 
            this.colSOD_NO.FieldName = "SOD_NO";
            this.colSOD_NO.Name = "colSOD_NO";
            this.colSOD_NO.Visible = true;
            this.colSOD_NO.VisibleIndex = 1;
            // 
            // colSOR_NO
            // 
            this.colSOR_NO.FieldName = "SOR_NO";
            this.colSOR_NO.Name = "colSOR_NO";
            this.colSOR_NO.Visible = true;
            this.colSOR_NO.VisibleIndex = 2;
            // 
            // colSOD_SEQ
            // 
            this.colSOD_SEQ.FieldName = "SOD_SEQ";
            this.colSOD_SEQ.Name = "colSOD_SEQ";
            this.colSOD_SEQ.Visible = true;
            this.colSOD_SEQ.VisibleIndex = 3;
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
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 6;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 7;
            // 
            // colITEM_SPEC
            // 
            this.colITEM_SPEC.FieldName = "ITEM_SPEC";
            this.colITEM_SPEC.Name = "colITEM_SPEC";
            this.colITEM_SPEC.Visible = true;
            this.colITEM_SPEC.VisibleIndex = 8;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 9;
            // 
            // colSOR_DT
            // 
            this.colSOR_DT.FieldName = "SOR_DT";
            this.colSOR_DT.Name = "colSOR_DT";
            this.colSOR_DT.Visible = true;
            this.colSOR_DT.VisibleIndex = 10;
            // 
            // colSOD_QTY
            // 
            this.colSOD_QTY.FieldName = "SOD_QTY";
            this.colSOD_QTY.Name = "colSOD_QTY";
            this.colSOD_QTY.Visible = true;
            this.colSOD_QTY.VisibleIndex = 11;
            // 
            // colSOD_PRICE
            // 
            this.colSOD_PRICE.FieldName = "SOD_PRICE";
            this.colSOD_PRICE.Name = "colSOD_PRICE";
            this.colSOD_PRICE.Visible = true;
            this.colSOD_PRICE.VisibleIndex = 12;
            // 
            // colSOD_AMOUNT
            // 
            this.colSOD_AMOUNT.FieldName = "SOD_AMOUNT";
            this.colSOD_AMOUNT.Name = "colSOD_AMOUNT";
            this.colSOD_AMOUNT.Visible = true;
            this.colSOD_AMOUNT.VisibleIndex = 13;
            // 
            // colCURRENCY_TYPE
            // 
            this.colCURRENCY_TYPE.FieldName = "CURRENCY_TYPE";
            this.colCURRENCY_TYPE.Name = "colCURRENCY_TYPE";
            this.colCURRENCY_TYPE.Visible = true;
            this.colCURRENCY_TYPE.VisibleIndex = 14;
            // 
            // colDUE_DT
            // 
            this.colDUE_DT.FieldName = "DUE_DT";
            this.colDUE_DT.Name = "colDUE_DT";
            this.colDUE_DT.Visible = true;
            this.colDUE_DT.VisibleIndex = 15;
            // 
            // colCUSTOM_PO_NO
            // 
            this.colCUSTOM_PO_NO.FieldName = "CUSTOM_PO_NO";
            this.colCUSTOM_PO_NO.Name = "colCUSTOM_PO_NO";
            this.colCUSTOM_PO_NO.Visible = true;
            this.colCUSTOM_PO_NO.VisibleIndex = 16;
            // 
            // colSOD_STATUS
            // 
            this.colSOD_STATUS.FieldName = "SOD_STATUS";
            this.colSOD_STATUS.Name = "colSOD_STATUS";
            this.colSOD_STATUS.Visible = true;
            this.colSOD_STATUS.VisibleIndex = 17;
            // 
            // colSOD_DLV_STATUS
            // 
            this.colSOD_DLV_STATUS.FieldName = "SOD_DLV_STATUS";
            this.colSOD_DLV_STATUS.Name = "colSOD_DLV_STATUS";
            this.colSOD_DLV_STATUS.Visible = true;
            this.colSOD_DLV_STATUS.VisibleIndex = 18;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 19;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 20;
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
            // SalesOrderDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "SalesOrderDetailList";
            this.Text = "OrderDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource salesOrderDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colSOR_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLANT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOR_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_PRICE;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_AMOUNT;
        private DevExpress.XtraGrid.Columns.GridColumn colCURRENCY_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colDUE_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCUSTOM_PO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD_DLV_STATUS;
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
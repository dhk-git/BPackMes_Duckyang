
namespace BPack.Carrying.App.PO.PurPack
{
    partial class InvoiceList
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
            this.invoiceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colINVOICE_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVOICE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVOICE_NO_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTAINER_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVOICE_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINVOICE_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETA_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colARRIVAL_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colARRIVAL_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLOSE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.invoiceModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.invoiceModelBindingSource;
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
            // invoiceModelBindingSource
            // 
            this.invoiceModelBindingSource.DataSource = typeof(BPack.Model.App.PO.PurPack.InvoiceModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colINVOICE_NO_KEY,
            this.colINVOICE_NO,
            this.colINVOICE_NO_2,
            this.colCONTAINER_NO,
            this.colINVOICE_STATUS,
            this.colINVOICE_DT,
            this.colCOMP_CD,
            this.colETA_DT,
            this.colARRIVAL_DT,
            this.colARRIVAL_DTTM,
            this.colBP_CD,
            this.colCLOSE_DTTM,
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
            // colINVOICE_NO_KEY
            // 
            this.colINVOICE_NO_KEY.FieldName = "INVOICE_NO_KEY";
            this.colINVOICE_NO_KEY.Name = "colINVOICE_NO_KEY";
            this.colINVOICE_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colINVOICE_NO_KEY.Visible = true;
            this.colINVOICE_NO_KEY.VisibleIndex = 0;
            // 
            // colINVOICE_NO
            // 
            this.colINVOICE_NO.FieldName = "INVOICE_NO";
            this.colINVOICE_NO.Name = "colINVOICE_NO";
            this.colINVOICE_NO.Visible = true;
            this.colINVOICE_NO.VisibleIndex = 1;
            // 
            // colINVOICE_NO_2
            // 
            this.colINVOICE_NO_2.FieldName = "INVOICE_NO_2";
            this.colINVOICE_NO_2.Name = "colINVOICE_NO_2";
            this.colINVOICE_NO_2.Visible = true;
            this.colINVOICE_NO_2.VisibleIndex = 2;
            // 
            // colCONTAINER_NO
            // 
            this.colCONTAINER_NO.FieldName = "CONTAINER_NO";
            this.colCONTAINER_NO.Name = "colCONTAINER_NO";
            this.colCONTAINER_NO.Visible = true;
            this.colCONTAINER_NO.VisibleIndex = 3;
            // 
            // colINVOICE_STATUS
            // 
            this.colINVOICE_STATUS.FieldName = "INVOICE_STATUS";
            this.colINVOICE_STATUS.Name = "colINVOICE_STATUS";
            this.colINVOICE_STATUS.Visible = true;
            this.colINVOICE_STATUS.VisibleIndex = 4;
            // 
            // colINVOICE_DT
            // 
            this.colINVOICE_DT.FieldName = "INVOICE_DT";
            this.colINVOICE_DT.Name = "colINVOICE_DT";
            this.colINVOICE_DT.Visible = true;
            this.colINVOICE_DT.VisibleIndex = 5;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 6;
            // 
            // colETA_DT
            // 
            this.colETA_DT.FieldName = "ETA_DT";
            this.colETA_DT.Name = "colETA_DT";
            this.colETA_DT.Visible = true;
            this.colETA_DT.VisibleIndex = 7;
            // 
            // colARRIVAL_DT
            // 
            this.colARRIVAL_DT.FieldName = "ARRIVAL_DT";
            this.colARRIVAL_DT.Name = "colARRIVAL_DT";
            this.colARRIVAL_DT.Visible = true;
            this.colARRIVAL_DT.VisibleIndex = 8;
            // 
            // colARRIVAL_DTTM
            // 
            this.colARRIVAL_DTTM.FieldName = "ARRIVAL_DTTM";
            this.colARRIVAL_DTTM.Name = "colARRIVAL_DTTM";
            this.colARRIVAL_DTTM.Visible = true;
            this.colARRIVAL_DTTM.VisibleIndex = 9;
            // 
            // colBP_CD
            // 
            this.colBP_CD.FieldName = "BP_CD";
            this.colBP_CD.Name = "colBP_CD";
            this.colBP_CD.Visible = true;
            this.colBP_CD.VisibleIndex = 10;
            // 
            // colCLOSE_DTTM
            // 
            this.colCLOSE_DTTM.FieldName = "CLOSE_DTTM";
            this.colCLOSE_DTTM.Name = "colCLOSE_DTTM";
            this.colCLOSE_DTTM.Visible = true;
            this.colCLOSE_DTTM.VisibleIndex = 11;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 12;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 13;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 14;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 15;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 16;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 17;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 18;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 19;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 20;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 21;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 22;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 23;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 24;
            // 
            // InvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "InvoiceList";
            this.Text = "InvoiceList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource invoiceModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colINVOICE_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colINVOICE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colINVOICE_NO_2;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTAINER_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colINVOICE_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colINVOICE_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colETA_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colARRIVAL_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colARRIVAL_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colCLOSE_DTTM;
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

namespace BPack.Carrying.App.SD.DlvOrderHist
{
    partial class DlvOrderHistDetailList
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
            this.dlvOrderDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDRH_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPICKING_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_TM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRETURN_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLOSE_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBASE_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRH_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_DOH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVEHICLE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRIVER_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrderDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.dlvOrderDetailModelBindingSource;
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
            // dlvOrderDetailModelBindingSource
            // 
            this.dlvOrderDetailModelBindingSource.DataSource = typeof(BPack.Model.App.SD.DlvOrderHist.DlvOrderHistDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDRH_NO_KEY,
            this.colDLV_DT,
            this.colBP_CD,
            this.colBP_NM,
            this.colDRH_NO,
            this.colDOH_NO,
            this.colCOMP_CD,
            this.colPICKING_DT,
            this.colDLV_TM,
            this.colDLV_QTY,
            this.colRETURN_QTY,
            this.colCLOSE_QTY,
            this.colBASE_UNIT,
            this.colDRH_STATUS,
            this.colCUST_DOH_NO,
            this.colVEHICLE_NO,
            this.colDRIVER_NM,
            this.colREMARK,
            this.colCREATE_DTTM,
            this.colMODIFY_DTTM,
            this.colCREATE_USER_ID,
            this.colMODIFY_USER_ID,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colDRH_NO_KEY
            // 
            this.colDRH_NO_KEY.FieldName = "DRH_NO_KEY";
            this.colDRH_NO_KEY.Name = "colDRH_NO_KEY";
            this.colDRH_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colDRH_NO_KEY.Visible = true;
            this.colDRH_NO_KEY.VisibleIndex = 0;
            // 
            // colDLV_DT
            // 
            this.colDLV_DT.FieldName = "DLV_DT";
            this.colDLV_DT.Name = "colDLV_DT";
            this.colDLV_DT.Visible = true;
            this.colDLV_DT.VisibleIndex = 1;
            // 
            // colBP_CD
            // 
            this.colBP_CD.FieldName = "BP_CD";
            this.colBP_CD.Name = "colBP_CD";
            this.colBP_CD.Visible = true;
            this.colBP_CD.VisibleIndex = 2;
            // 
            // colBP_NM
            // 
            this.colBP_NM.FieldName = "BP_NM";
            this.colBP_NM.Name = "colBP_NM";
            this.colBP_NM.Visible = true;
            this.colBP_NM.VisibleIndex = 3;
            // 
            // colDRH_NO
            // 
            this.colDRH_NO.FieldName = "DRH_NO";
            this.colDRH_NO.Name = "colDRH_NO";
            this.colDRH_NO.Visible = true;
            this.colDRH_NO.VisibleIndex = 4;
            // 
            // colDOH_NO
            // 
            this.colDOH_NO.FieldName = "DOH_NO";
            this.colDOH_NO.Name = "colDOH_NO";
            this.colDOH_NO.Visible = true;
            this.colDOH_NO.VisibleIndex = 5;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 6;
            // 
            // colPICKING_DT
            // 
            this.colPICKING_DT.FieldName = "PICKING_DT";
            this.colPICKING_DT.Name = "colPICKING_DT";
            this.colPICKING_DT.Visible = true;
            this.colPICKING_DT.VisibleIndex = 7;
            // 
            // colDLV_TM
            // 
            this.colDLV_TM.FieldName = "DLV_TM";
            this.colDLV_TM.Name = "colDLV_TM";
            this.colDLV_TM.Visible = true;
            this.colDLV_TM.VisibleIndex = 8;
            // 
            // colDLV_QTY
            // 
            this.colDLV_QTY.FieldName = "DLV_QTY";
            this.colDLV_QTY.Name = "colDLV_QTY";
            this.colDLV_QTY.Visible = true;
            this.colDLV_QTY.VisibleIndex = 9;
            // 
            // colRETURN_QTY
            // 
            this.colRETURN_QTY.FieldName = "RETURN_QTY";
            this.colRETURN_QTY.Name = "colRETURN_QTY";
            this.colRETURN_QTY.Visible = true;
            this.colRETURN_QTY.VisibleIndex = 10;
            // 
            // colCLOSE_QTY
            // 
            this.colCLOSE_QTY.FieldName = "CLOSE_QTY";
            this.colCLOSE_QTY.Name = "colCLOSE_QTY";
            this.colCLOSE_QTY.Visible = true;
            this.colCLOSE_QTY.VisibleIndex = 11;
            // 
            // colBASE_UNIT
            // 
            this.colBASE_UNIT.FieldName = "BASE_UNIT";
            this.colBASE_UNIT.Name = "colBASE_UNIT";
            this.colBASE_UNIT.Visible = true;
            this.colBASE_UNIT.VisibleIndex = 12;
            // 
            // colDRH_STATUS
            // 
            this.colDRH_STATUS.FieldName = "DRH_STATUS";
            this.colDRH_STATUS.Name = "colDRH_STATUS";
            this.colDRH_STATUS.Visible = true;
            this.colDRH_STATUS.VisibleIndex = 13;
            // 
            // colCUST_DOH_NO
            // 
            this.colCUST_DOH_NO.FieldName = "CUST_DOH_NO";
            this.colCUST_DOH_NO.Name = "colCUST_DOH_NO";
            this.colCUST_DOH_NO.Visible = true;
            this.colCUST_DOH_NO.VisibleIndex = 14;
            // 
            // colVEHICLE_NO
            // 
            this.colVEHICLE_NO.FieldName = "VEHICLE_NO";
            this.colVEHICLE_NO.Name = "colVEHICLE_NO";
            this.colVEHICLE_NO.Visible = true;
            this.colVEHICLE_NO.VisibleIndex = 15;
            // 
            // colDRIVER_NM
            // 
            this.colDRIVER_NM.FieldName = "DRIVER_NM";
            this.colDRIVER_NM.Name = "colDRIVER_NM";
            this.colDRIVER_NM.Visible = true;
            this.colDRIVER_NM.VisibleIndex = 16;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 17;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 18;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 19;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 20;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 21;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 22;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 23;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 24;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 25;
            // 
            // DlvOrderHistDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "DlvOrderHistDetailList";
            this.Text = "DlvOrderHistDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvOrderDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dlvOrderDetailModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDRH_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colDRH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDOH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPICKING_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_TM;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colRETURN_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colCLOSE_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colBASE_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colDRH_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_DOH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colVEHICLE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colDRIVER_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}

namespace BPack.Carrying.App.PO.PurOrder
{
    partial class PurOrderList
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
            this.purOrderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPOH_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOH_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOH_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVL_PLACE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOH_CREATE_CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOH_INTER_CLS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOH_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLOSE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.purOrderModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.purOrderModelBindingSource;
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
            // purOrderModelBindingSource
            // 
            this.purOrderModelBindingSource.DataSource = typeof(BPack.Model.App.PO.PurOrder.PurOrderModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPOH_NO_KEY,
            this.colPOH_NO,
            this.colCOMP_CD,
            this.colBP_CD,
            this.colPOH_STATUS,
            this.colDVL_PLACE,
            this.colPOH_CREATE_CLS,
            this.colPOH_INTER_CLS,
            this.colPOH_DT,
            this.colCLOSE_DTTM,
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
            // colPOH_NO_KEY
            // 
            this.colPOH_NO_KEY.FieldName = "POH_NO_KEY";
            this.colPOH_NO_KEY.Name = "colPOH_NO_KEY";
            this.colPOH_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colPOH_NO_KEY.Visible = true;
            this.colPOH_NO_KEY.VisibleIndex = 0;
            // 
            // colPOH_NO
            // 
            this.colPOH_NO.FieldName = "POH_NO";
            this.colPOH_NO.Name = "colPOH_NO";
            this.colPOH_NO.Visible = true;
            this.colPOH_NO.VisibleIndex = 1;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 2;
            // 
            // colBP_CD
            // 
            this.colBP_CD.FieldName = "BP_CD";
            this.colBP_CD.Name = "colBP_CD";
            this.colBP_CD.Visible = true;
            this.colBP_CD.VisibleIndex = 3;
            // 
            // colPOH_STATUS
            // 
            this.colPOH_STATUS.FieldName = "POH_STATUS";
            this.colPOH_STATUS.Name = "colPOH_STATUS";
            this.colPOH_STATUS.Visible = true;
            this.colPOH_STATUS.VisibleIndex = 4;
            // 
            // colDVL_PLACE
            // 
            this.colDVL_PLACE.FieldName = "DVL_PLACE";
            this.colDVL_PLACE.Name = "colDVL_PLACE";
            this.colDVL_PLACE.Visible = true;
            this.colDVL_PLACE.VisibleIndex = 5;
            // 
            // colPOH_CREATE_CLS
            // 
            this.colPOH_CREATE_CLS.FieldName = "POH_CREATE_CLS";
            this.colPOH_CREATE_CLS.Name = "colPOH_CREATE_CLS";
            this.colPOH_CREATE_CLS.Visible = true;
            this.colPOH_CREATE_CLS.VisibleIndex = 6;
            // 
            // colPOH_INTER_CLS
            // 
            this.colPOH_INTER_CLS.FieldName = "POH_INTER_CLS";
            this.colPOH_INTER_CLS.Name = "colPOH_INTER_CLS";
            this.colPOH_INTER_CLS.Visible = true;
            this.colPOH_INTER_CLS.VisibleIndex = 7;
            // 
            // colPOH_DT
            // 
            this.colPOH_DT.FieldName = "POH_DT";
            this.colPOH_DT.Name = "colPOH_DT";
            this.colPOH_DT.Visible = true;
            this.colPOH_DT.VisibleIndex = 8;
            // 
            // colCLOSE_DTTM
            // 
            this.colCLOSE_DTTM.FieldName = "CLOSE_DTTM";
            this.colCLOSE_DTTM.Name = "colCLOSE_DTTM";
            this.colCLOSE_DTTM.Visible = true;
            this.colCLOSE_DTTM.VisibleIndex = 9;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 10;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 11;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 12;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 13;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 14;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 15;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 16;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 17;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 18;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 19;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 20;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 21;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 22;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 23;
            // 
            // PurOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "PurOrderList";
            this.Text = "PurOrderList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purOrderModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource purOrderModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPOH_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPOH_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colPOH_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colDVL_PLACE;
        private DevExpress.XtraGrid.Columns.GridColumn colPOH_CREATE_CLS;
        private DevExpress.XtraGrid.Columns.GridColumn colPOH_INTER_CLS;
        private DevExpress.XtraGrid.Columns.GridColumn colPOH_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colCLOSE_DTTM;
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
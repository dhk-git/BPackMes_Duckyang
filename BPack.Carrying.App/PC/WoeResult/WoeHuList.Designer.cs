namespace BPack.Carrying.App.PC.WoeResult
{
    partial class WoeHuList
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
            this.strapGridControl1 = new BPack.Strap.Grid.StrapGridControl();
            this.woeHuModelBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRST_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_INIT_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_STOCK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOK_NG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_HU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.woeHuModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.woeHuModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 525);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // woeHuModelBindingSource
            // 
            this.woeHuModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WoeResult.WoeHuModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRST_NO_KEY,
            this.colHU_NO_KEY,
            this.colRST_NO,
            this.colHU_TYPE,
            this.colHU_NO,
            this.colHU_INIT_QTY,
            this.colHU_STOCK_QTY,
            this.colOK_NG,
            this.colPARENT_HU_NO,
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
            this.gridView1.DetailHeight = 408;
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colRST_NO_KEY
            // 
            this.colRST_NO_KEY.FieldName = "RST_NO_KEY";
            this.colRST_NO_KEY.Name = "colRST_NO_KEY";
            this.colRST_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colRST_NO_KEY.Visible = true;
            this.colRST_NO_KEY.VisibleIndex = 0;
            // 
            // colHU_NO_KEY
            // 
            this.colHU_NO_KEY.FieldName = "HU_NO_KEY";
            this.colHU_NO_KEY.Name = "colHU_NO_KEY";
            this.colHU_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colHU_NO_KEY.Visible = true;
            this.colHU_NO_KEY.VisibleIndex = 1;
            // 
            // colRST_NO
            // 
            this.colRST_NO.FieldName = "RST_NO";
            this.colRST_NO.Name = "colRST_NO";
            this.colRST_NO.Visible = true;
            this.colRST_NO.VisibleIndex = 2;
            // 
            // colHU_TYPE
            // 
            this.colHU_TYPE.FieldName = "HU_TYPE";
            this.colHU_TYPE.Name = "colHU_TYPE";
            this.colHU_TYPE.Visible = true;
            this.colHU_TYPE.VisibleIndex = 3;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 4;
            // 
            // colHU_INIT_QTY
            // 
            this.colHU_INIT_QTY.FieldName = "HU_INIT_QTY";
            this.colHU_INIT_QTY.Name = "colHU_INIT_QTY";
            this.colHU_INIT_QTY.Visible = true;
            this.colHU_INIT_QTY.VisibleIndex = 5;
            // 
            // colHU_STOCK_QTY
            // 
            this.colHU_STOCK_QTY.FieldName = "HU_STOCK_QTY";
            this.colHU_STOCK_QTY.Name = "colHU_STOCK_QTY";
            this.colHU_STOCK_QTY.Visible = true;
            this.colHU_STOCK_QTY.VisibleIndex = 6;
            // 
            // colOK_NG
            // 
            this.colOK_NG.FieldName = "OK_NG";
            this.colOK_NG.Name = "colOK_NG";
            this.colOK_NG.Visible = true;
            this.colOK_NG.VisibleIndex = 7;
            // 
            // colPARENT_HU_NO
            // 
            this.colPARENT_HU_NO.FieldName = "PARENT_HU_NO";
            this.colPARENT_HU_NO.Name = "colPARENT_HU_NO";
            this.colPARENT_HU_NO.Visible = true;
            this.colPARENT_HU_NO.VisibleIndex = 8;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 9;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 10;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 11;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 12;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 13;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 14;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 15;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 16;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 17;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 18;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 19;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 20;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 21;
            // 
            // WoeHuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WoeHuList";
            this.Text = "WoeHuList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woeHuModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource woeHuModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_INIT_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_STOCK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colOK_NG;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_HU_NO;
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
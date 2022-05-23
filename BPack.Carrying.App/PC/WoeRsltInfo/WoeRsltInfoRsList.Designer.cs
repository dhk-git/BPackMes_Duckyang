namespace BPack.Carrying.App.PC.WoeRsltInfo
{
    partial class WoeRsltInfoRsList
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
            this.gcList = new BPack.Strap.Grid.StrapGridControl();
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRST_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROUTE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNG_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.DataSource = this.bsList;
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.IsStrapGridViewDefaultSetting = true;
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gridView1;
            this.gcList.Name = "gcList";
            this.gcList.SelectedModel = null;
            this.gcList.SelectedModelIndex = null;
            this.gcList.Size = new System.Drawing.Size(800, 450);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsList
            // 
            this.bsList.DataSource = typeof(BPack.Model.App.PC.WoeRsltInfo.WoeRsltInfoRsModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRST_NO,
            this.colWO_NO,
            this.colROUTE_NO,
            this.colOPER,
            this.colRST_QTY,
            this.colOK_QTY,
            this.colNG_QTY,
            this.colLOT_NO,
            this.colRST_STATUS,
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
            this.gridView1.GridControl = this.gcList;
            this.gridView1.Name = "gridView1";
            // 
            // colRST_NO
            // 
            this.colRST_NO.FieldName = "RST_NO";
            this.colRST_NO.Name = "colRST_NO";
            this.colRST_NO.Visible = true;
            this.colRST_NO.VisibleIndex = 0;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 1;
            // 
            // colROUTE_NO
            // 
            this.colROUTE_NO.FieldName = "ROUTE_NO";
            this.colROUTE_NO.Name = "colROUTE_NO";
            this.colROUTE_NO.Visible = true;
            this.colROUTE_NO.VisibleIndex = 2;
            // 
            // colOPER
            // 
            this.colOPER.FieldName = "OPER";
            this.colOPER.Name = "colOPER";
            this.colOPER.Visible = true;
            this.colOPER.VisibleIndex = 3;
            // 
            // colRST_QTY
            // 
            this.colRST_QTY.FieldName = "RST_QTY";
            this.colRST_QTY.Name = "colRST_QTY";
            this.colRST_QTY.Visible = true;
            this.colRST_QTY.VisibleIndex = 4;
            // 
            // colOK_QTY
            // 
            this.colOK_QTY.FieldName = "OK_QTY";
            this.colOK_QTY.Name = "colOK_QTY";
            this.colOK_QTY.Visible = true;
            this.colOK_QTY.VisibleIndex = 5;
            // 
            // colNG_QTY
            // 
            this.colNG_QTY.FieldName = "NG_QTY";
            this.colNG_QTY.Name = "colNG_QTY";
            this.colNG_QTY.Visible = true;
            this.colNG_QTY.VisibleIndex = 6;
            // 
            // colLOT_NO
            // 
            this.colLOT_NO.FieldName = "LOT_NO";
            this.colLOT_NO.Name = "colLOT_NO";
            this.colLOT_NO.Visible = true;
            this.colLOT_NO.VisibleIndex = 7;
            // 
            // colRST_STATUS
            // 
            this.colRST_STATUS.FieldName = "RST_STATUS";
            this.colRST_STATUS.Name = "colRST_STATUS";
            this.colRST_STATUS.Visible = true;
            this.colRST_STATUS.VisibleIndex = 8;
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
            this.colCREATE_DTTM.VisibleIndex = 9;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 10;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
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
            // WoeRsltInfoRsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gcList);
            this.Name = "WoeRsltInfoRsList";
            this.Text = "ResultList";
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsList;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colOK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colNG_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colLOT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_STATUS;
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
    }
}
namespace BPack.Carrying.App.PC.WoeRsltInfo
{
    partial class WoeRsltInfoList
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
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROUTE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_GR_1_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLOSE_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWOR_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOLD_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOLD_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWOD_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_IF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNG_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.sgcList.DataSource = this.bsList;
            this.sgcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgcList.IsStrapGridViewDefaultSetting = true;
            this.sgcList.Location = new System.Drawing.Point(0, 0);
            this.sgcList.MainView = this.gridView1;
            this.sgcList.Name = "sgcList";
            this.sgcList.SelectedModel = null;
            this.sgcList.SelectedModelIndex = null;
            this.sgcList.Size = new System.Drawing.Size(800, 450);
            this.sgcList.TabIndex = 0;
            this.sgcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsList
            // 
            this.bsList.DataSource = typeof(BPack.Model.App.PC.WoeRsltInfo.WoeRsltInfoModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWO_NO,
            this.colROUTE_NO,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_GR_1,
            this.colITEM_GR_1_NM,
            this.colCLOSE_DT,
            this.colWO_DT,
            this.colSHIFT_CD,
            this.colWOR_QTY,
            this.colWO_STATUS,
            this.colOPER,
            this.colOPER_DESC,
            this.colWC_CD,
            this.colMOLD_CD,
            this.colMOLD_NM,
            this.colWOD_STATUS,
            this.colIS_IF,
            this.colRST_QTY,
            this.colOK_QTY,
            this.colNG_QTY,
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
            // colWO_NO
            // 
            this.colWO_NO.AppearanceCell.Options.UseTextOptions = true;
            this.colWO_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 5;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 6;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 7;
            // 
            // colITEM_GR_1_NM
            // 
            this.colITEM_GR_1_NM.FieldName = "ITEM_GR_1_NM";
            this.colITEM_GR_1_NM.Name = "colITEM_GR_1_NM";
            this.colITEM_GR_1_NM.Visible = true;
            this.colITEM_GR_1_NM.VisibleIndex = 8;
            // 
            // colCLOSE_DT
            // 
            this.colCLOSE_DT.FieldName = "CLOSE_DT";
            this.colCLOSE_DT.Name = "colCLOSE_DT";
            // 
            // colWO_DT
            // 
            this.colWO_DT.AppearanceCell.Options.UseTextOptions = true;
            this.colWO_DT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWO_DT.FieldName = "WO_DT";
            this.colWO_DT.Name = "colWO_DT";
            this.colWO_DT.Visible = true;
            this.colWO_DT.VisibleIndex = 1;
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.AppearanceCell.Options.UseTextOptions = true;
            this.colSHIFT_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSHIFT_CD.Caption = "근무조";
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            this.colSHIFT_CD.Visible = true;
            this.colSHIFT_CD.VisibleIndex = 2;
            // 
            // colWOR_QTY
            // 
            this.colWOR_QTY.FieldName = "WOR_QTY";
            this.colWOR_QTY.Name = "colWOR_QTY";
            this.colWOR_QTY.Visible = true;
            this.colWOR_QTY.VisibleIndex = 9;
            // 
            // colWO_STATUS
            // 
            this.colWO_STATUS.FieldName = "WO_STATUS";
            this.colWO_STATUS.Name = "colWO_STATUS";
            this.colWO_STATUS.Visible = true;
            this.colWO_STATUS.VisibleIndex = 10;
            // 
            // colOPER
            // 
            this.colOPER.FieldName = "OPER";
            this.colOPER.Name = "colOPER";
            this.colOPER.Visible = true;
            this.colOPER.VisibleIndex = 11;
            // 
            // colOPER_DESC
            // 
            this.colOPER_DESC.FieldName = "OPER_DESC";
            this.colOPER_DESC.Name = "colOPER_DESC";
            // 
            // colWC_CD
            // 
            this.colWC_CD.AppearanceCell.Options.UseTextOptions = true;
            this.colWC_CD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 0;
            // 
            // colMOLD_CD
            // 
            this.colMOLD_CD.FieldName = "MOLD_CD";
            this.colMOLD_CD.Name = "colMOLD_CD";
            this.colMOLD_CD.Visible = true;
            this.colMOLD_CD.VisibleIndex = 12;
            // 
            // colMOLD_NM
            // 
            this.colMOLD_NM.FieldName = "MOLD_NM";
            this.colMOLD_NM.Name = "colMOLD_NM";
            this.colMOLD_NM.Visible = true;
            this.colMOLD_NM.VisibleIndex = 13;
            // 
            // colWOD_STATUS
            // 
            this.colWOD_STATUS.FieldName = "WOD_STATUS";
            this.colWOD_STATUS.Name = "colWOD_STATUS";
            this.colWOD_STATUS.Visible = true;
            this.colWOD_STATUS.VisibleIndex = 14;
            // 
            // colIS_IF
            // 
            this.colIS_IF.FieldName = "IS_IF";
            this.colIS_IF.Name = "colIS_IF";
            // 
            // colRST_QTY
            // 
            this.colRST_QTY.FieldName = "RST_QTY";
            this.colRST_QTY.Name = "colRST_QTY";
            this.colRST_QTY.Visible = true;
            this.colRST_QTY.VisibleIndex = 15;
            // 
            // colOK_QTY
            // 
            this.colOK_QTY.FieldName = "OK_QTY";
            this.colOK_QTY.Name = "colOK_QTY";
            this.colOK_QTY.Visible = true;
            this.colOK_QTY.VisibleIndex = 16;
            // 
            // colNG_QTY
            // 
            this.colNG_QTY.FieldName = "NG_QTY";
            this.colNG_QTY.Name = "colNG_QTY";
            this.colNG_QTY.Visible = true;
            this.colNG_QTY.VisibleIndex = 17;
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
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
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
            // WoeRsltInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sgcList);
            this.Name = "WoeRsltInfoList";
            this.Text = "WoList";
            ((System.ComponentModel.ISupportInitialize)(this.sgcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl sgcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsList;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_GR_1_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colCLOSE_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWOR_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMOLD_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colMOLD_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colWOD_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_IF;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colOK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colNG_QTY;
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
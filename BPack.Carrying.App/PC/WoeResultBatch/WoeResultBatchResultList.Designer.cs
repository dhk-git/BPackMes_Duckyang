
namespace BPack.Carrying.App.PC.WoeResultBatch
{
    partial class WoeResultBatchResultList
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
            this.woeResultBatchResultModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRST_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWO_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROUTE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOK_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNG_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRST_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHU_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHIFT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_TM = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.woeResultBatchResultModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.woeResultBatchResultModelBindingSource;
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
            // woeResultBatchResultModelBindingSource
            // 
            this.woeResultBatchResultModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WoeResultBatch.WoeResultBatchResultModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRST_NO_KEY,
            this.colRST_NO,
            this.colWO_NO,
            this.colROUTE_NO,
            this.colOPER,
            this.colRST_QTY,
            this.colOK_QTY,
            this.colNG_QTY,
            this.colRST_STATUS,
            this.colWC_CD,
            this.colHU_NO,
            this.colHU_TYPE,
            this.colITEM_CD,
            this.colWORK_DT,
            this.colSHIFT_CD,
            this.colDVC_ID,
            this.colWORK_TM,
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
            // colRST_NO_KEY
            // 
            this.colRST_NO_KEY.FieldName = "RST_NO_KEY";
            this.colRST_NO_KEY.Name = "colRST_NO_KEY";
            this.colRST_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colRST_NO_KEY.Visible = true;
            this.colRST_NO_KEY.VisibleIndex = 0;
            // 
            // colRST_NO
            // 
            this.colRST_NO.FieldName = "RST_NO";
            this.colRST_NO.Name = "colRST_NO";
            this.colRST_NO.Visible = true;
            this.colRST_NO.VisibleIndex = 1;
            // 
            // colWO_NO
            // 
            this.colWO_NO.FieldName = "WO_NO";
            this.colWO_NO.Name = "colWO_NO";
            this.colWO_NO.Visible = true;
            this.colWO_NO.VisibleIndex = 2;
            // 
            // colROUTE_NO
            // 
            this.colROUTE_NO.FieldName = "ROUTE_NO";
            this.colROUTE_NO.Name = "colROUTE_NO";
            this.colROUTE_NO.Visible = true;
            this.colROUTE_NO.VisibleIndex = 3;
            // 
            // colOPER
            // 
            this.colOPER.FieldName = "OPER";
            this.colOPER.Name = "colOPER";
            this.colOPER.Visible = true;
            this.colOPER.VisibleIndex = 4;
            // 
            // colRST_QTY
            // 
            this.colRST_QTY.FieldName = "RST_QTY";
            this.colRST_QTY.Name = "colRST_QTY";
            this.colRST_QTY.Visible = true;
            this.colRST_QTY.VisibleIndex = 5;
            // 
            // colOK_QTY
            // 
            this.colOK_QTY.FieldName = "OK_QTY";
            this.colOK_QTY.Name = "colOK_QTY";
            this.colOK_QTY.Visible = true;
            this.colOK_QTY.VisibleIndex = 6;
            // 
            // colNG_QTY
            // 
            this.colNG_QTY.FieldName = "NG_QTY";
            this.colNG_QTY.Name = "colNG_QTY";
            this.colNG_QTY.Visible = true;
            this.colNG_QTY.VisibleIndex = 7;
            // 
            // colRST_STATUS
            // 
            this.colRST_STATUS.FieldName = "RST_STATUS";
            this.colRST_STATUS.Name = "colRST_STATUS";
            this.colRST_STATUS.Visible = true;
            this.colRST_STATUS.VisibleIndex = 8;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.Visible = true;
            this.colWC_CD.VisibleIndex = 9;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.Visible = true;
            this.colHU_NO.VisibleIndex = 10;
            // 
            // colHU_TYPE
            // 
            this.colHU_TYPE.FieldName = "HU_TYPE";
            this.colHU_TYPE.Name = "colHU_TYPE";
            this.colHU_TYPE.Visible = true;
            this.colHU_TYPE.VisibleIndex = 11;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 12;
            // 
            // colWORK_DT
            // 
            this.colWORK_DT.FieldName = "WORK_DT";
            this.colWORK_DT.Name = "colWORK_DT";
            this.colWORK_DT.Visible = true;
            this.colWORK_DT.VisibleIndex = 13;
            // 
            // colSHIFT_CD
            // 
            this.colSHIFT_CD.FieldName = "SHIFT_CD";
            this.colSHIFT_CD.Name = "colSHIFT_CD";
            this.colSHIFT_CD.Visible = true;
            this.colSHIFT_CD.VisibleIndex = 14;
            // 
            // colDVC_ID
            // 
            this.colDVC_ID.FieldName = "DVC_ID";
            this.colDVC_ID.Name = "colDVC_ID";
            this.colDVC_ID.Visible = true;
            this.colDVC_ID.VisibleIndex = 15;
            // 
            // colWORK_TM
            // 
            this.colWORK_TM.FieldName = "WORK_TM";
            this.colWORK_TM.Name = "colWORK_TM";
            this.colWORK_TM.Visible = true;
            this.colWORK_TM.VisibleIndex = 16;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 17;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 18;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 19;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 20;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 21;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 22;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 23;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 24;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 25;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 26;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 27;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 28;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 29;
            // 
            // WoeResultBatchResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "WoeResultBatchResultList";
            this.Text = "WoeResultBatchResultList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woeResultBatchResultModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource woeResultBatchResultModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colWO_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colOK_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colNG_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colRST_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colHU_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colSHIFT_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colDVC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_TM;
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
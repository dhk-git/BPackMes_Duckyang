namespace BPack.Carrying.App.MD.BpaGate
{
    partial class GateList
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
            this.grdGate = new BPack.Strap.Grid.StrapGridControl();
            this.gateModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvGate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGATE_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGATE_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGATE_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_PURCHASE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_SALES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWH_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_FROM_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID_TO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV_SPOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_PLANT_CD = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdGate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gateModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGate)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGate
            // 
            this.grdGate.DataSource = this.gateModelBindingSource;
            this.grdGate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGate.IsStrapGridViewDefaultSetting = true;
            this.grdGate.Location = new System.Drawing.Point(0, 0);
            this.grdGate.MainView = this.grvGate;
            this.grdGate.Name = "grdGate";
            this.grdGate.SelectedModel = null;
            this.grdGate.SelectedModelIndex = null;
            this.grdGate.Size = new System.Drawing.Size(800, 450);
            this.grdGate.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.grdGate.TabIndex = 0;
            this.grdGate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvGate});
            // 
            // gateModelBindingSource
            // 
            this.gateModelBindingSource.DataSource = typeof(BPack.Model.App.MD.BpaGate.GateModel);
            // 
            // grvGate
            // 
            this.grvGate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOMP_CD_KEY,
            this.colBP_CD_KEY,
            this.colGATE_CD_KEY,
            this.colCOMP_CD,
            this.colBP_CD,
            this.colGATE_CD,
            this.colGATE_NM,
            this.colIS_PURCHASE,
            this.colIS_SALES,
            this.colWH_CD,
            this.colLOC_CD,
            this.colVALID_FROM_DT,
            this.colVALID_TO_DT,
            this.colDLV_SPOT,
            this.colCUST_PLANT_CD,
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
            this.grvGate.GridControl = this.grdGate;
            this.grvGate.Name = "grvGate";
            this.grvGate.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.grvGate_RowCellClick);
            // 
            // colCOMP_CD_KEY
            // 
            this.colCOMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.colCOMP_CD_KEY.Name = "colCOMP_CD_KEY";
            this.colCOMP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colCOMP_CD_KEY.Visible = true;
            this.colCOMP_CD_KEY.VisibleIndex = 0;
            // 
            // colBP_CD_KEY
            // 
            this.colBP_CD_KEY.FieldName = "BP_CD_KEY";
            this.colBP_CD_KEY.Name = "colBP_CD_KEY";
            this.colBP_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colBP_CD_KEY.Visible = true;
            this.colBP_CD_KEY.VisibleIndex = 1;
            // 
            // colGATE_CD_KEY
            // 
            this.colGATE_CD_KEY.FieldName = "GATE_CD_KEY";
            this.colGATE_CD_KEY.Name = "colGATE_CD_KEY";
            this.colGATE_CD_KEY.OptionsColumn.ReadOnly = true;
            this.colGATE_CD_KEY.Visible = true;
            this.colGATE_CD_KEY.VisibleIndex = 2;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            this.colCOMP_CD.Visible = true;
            this.colCOMP_CD.VisibleIndex = 3;
            // 
            // colBP_CD
            // 
            this.colBP_CD.FieldName = "BP_CD";
            this.colBP_CD.Name = "colBP_CD";
            this.colBP_CD.Visible = true;
            this.colBP_CD.VisibleIndex = 4;
            // 
            // colGATE_CD
            // 
            this.colGATE_CD.FieldName = "GATE_CD";
            this.colGATE_CD.Name = "colGATE_CD";
            this.colGATE_CD.Visible = true;
            this.colGATE_CD.VisibleIndex = 5;
            // 
            // colGATE_NM
            // 
            this.colGATE_NM.FieldName = "GATE_NM";
            this.colGATE_NM.Name = "colGATE_NM";
            this.colGATE_NM.Visible = true;
            this.colGATE_NM.VisibleIndex = 6;
            // 
            // colIS_PURCHASE
            // 
            this.colIS_PURCHASE.FieldName = "IS_PURCHASE";
            this.colIS_PURCHASE.Name = "colIS_PURCHASE";
            this.colIS_PURCHASE.Visible = true;
            this.colIS_PURCHASE.VisibleIndex = 7;
            // 
            // colIS_SALES
            // 
            this.colIS_SALES.FieldName = "IS_SALES";
            this.colIS_SALES.Name = "colIS_SALES";
            this.colIS_SALES.Visible = true;
            this.colIS_SALES.VisibleIndex = 8;
            // 
            // colWH_CD
            // 
            this.colWH_CD.FieldName = "WH_CD";
            this.colWH_CD.Name = "colWH_CD";
            this.colWH_CD.Visible = true;
            this.colWH_CD.VisibleIndex = 9;
            // 
            // colLOC_CD
            // 
            this.colLOC_CD.FieldName = "LOC_CD";
            this.colLOC_CD.Name = "colLOC_CD";
            this.colLOC_CD.Visible = true;
            this.colLOC_CD.VisibleIndex = 10;
            // 
            // colVALID_FROM_DT
            // 
            this.colVALID_FROM_DT.FieldName = "VALID_FROM_DT";
            this.colVALID_FROM_DT.Name = "colVALID_FROM_DT";
            this.colVALID_FROM_DT.Visible = true;
            this.colVALID_FROM_DT.VisibleIndex = 11;
            // 
            // colVALID_TO_DT
            // 
            this.colVALID_TO_DT.FieldName = "VALID_TO_DT";
            this.colVALID_TO_DT.Name = "colVALID_TO_DT";
            this.colVALID_TO_DT.Visible = true;
            this.colVALID_TO_DT.VisibleIndex = 12;
            // 
            // colDLV_SPOT
            // 
            this.colDLV_SPOT.FieldName = "DLV_SPOT";
            this.colDLV_SPOT.Name = "colDLV_SPOT";
            this.colDLV_SPOT.Visible = true;
            this.colDLV_SPOT.VisibleIndex = 13;
            // 
            // colCUST_PLANT_CD
            // 
            this.colCUST_PLANT_CD.FieldName = "CUST_PLANT_CD";
            this.colCUST_PLANT_CD.Name = "colCUST_PLANT_CD";
            this.colCUST_PLANT_CD.Visible = true;
            this.colCUST_PLANT_CD.VisibleIndex = 14;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 15;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 16;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 17;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 18;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 19;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 20;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 21;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 22;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 23;
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
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 28;
            // 
            // GateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdGate);
            this.Name = "GateList";
            this.Text = "GateList";
            ((System.ComponentModel.ISupportInitialize)(this.grdGate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gateModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl grdGate;
        private DevExpress.XtraGrid.Views.Grid.GridView grvGate;
        private System.Windows.Forms.BindingSource gateModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colGATE_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colBP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGATE_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colGATE_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_PURCHASE;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_SALES;
        private DevExpress.XtraGrid.Columns.GridColumn colWH_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_FROM_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID_TO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV_SPOT;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_PLANT_CD;
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
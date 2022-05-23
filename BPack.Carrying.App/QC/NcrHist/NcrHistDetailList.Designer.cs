namespace BPack.Carrying.App.QC.NcrHist
{
    partial class NcrHistDetailList
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
            this.ncrHistDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIsCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSelectedCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNCR_NO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colNCR_JUDGE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colHU_NO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTRT_FG = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colWH_CD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colWH_NM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colWC_CD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colLOC_CD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLOC_NM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colBP_NM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBP_CD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNCR_QTY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colROUTE_NO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colOPER = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVALID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLANG_CODE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRowState = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncrHistDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.ncrHistDetailModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(1202, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ncrHistDetailModelBindingSource
            // 
            this.ncrHistDetailModelBindingSource.DataSource = typeof(BPack.Model.App.QC.NcrHist.NcrHistDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.BandPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand4,
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand5,
            this.gridBand6});
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colNCR_NO,
            this.colNCR_JUDGE,
            this.colHU_NO,
            this.colNCR_QTY,
            this.colTRT_FG,
            this.colWH_CD,
            this.colWH_NM,
            this.colLOC_CD,
            this.colLOC_NM,
            this.colBP_CD,
            this.colBP_NM,
            this.colCREATE_USER_ID,
            this.colCREATE_DTTM,
            this.colROUTE_NO,
            this.colOPER,
            this.colWC_CD,
            this.colREMARK,
            this.colMODIFY_DTTM,
            this.colMODIFY_USER_ID,
            this.colVALID,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colLANG_CODE,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "선택";
            this.gridBand4.Columns.Add(this.colIsCheck);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 0;
            this.gridBand4.Width = 45;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIsCheck.Visible = true;
            this.colIsCheck.Width = 45;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "부적합번호";
            this.gridBand1.Columns.Add(this.colSelectedCheck);
            this.gridBand1.Columns.Add(this.colNCR_NO);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 1;
            this.gridBand1.Width = 160;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colNCR_NO
            // 
            this.colNCR_NO.FieldName = "NCR_NO";
            this.colNCR_NO.Name = "colNCR_NO";
            this.colNCR_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colNCR_NO.OptionsColumn.ReadOnly = true;
            this.colNCR_NO.Visible = true;
            this.colNCR_NO.Width = 160;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "판정";
            this.gridBand2.Columns.Add(this.colNCR_JUDGE);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 150;
            // 
            // colNCR_JUDGE
            // 
            this.colNCR_JUDGE.FieldName = "NCR_JUDGE";
            this.colNCR_JUDGE.Name = "colNCR_JUDGE";
            this.colNCR_JUDGE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNCR_JUDGE.Visible = true;
            this.colNCR_JUDGE.Width = 150;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "개별식별번호";
            this.gridBand3.Columns.Add(this.colHU_NO);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 3;
            this.gridBand3.Width = 140;
            // 
            // colHU_NO
            // 
            this.colHU_NO.FieldName = "HU_NO";
            this.colHU_NO.Name = "colHU_NO";
            this.colHU_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colHU_NO.OptionsColumn.ReadOnly = true;
            this.colHU_NO.Visible = true;
            this.colHU_NO.Width = 140;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "처리완료여부";
            this.gridBand5.Columns.Add(this.colTRT_FG);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 100;
            // 
            // colTRT_FG
            // 
            this.colTRT_FG.FieldName = "TRT_FG";
            this.colTRT_FG.Name = "colTRT_FG";
            this.colTRT_FG.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTRT_FG.OptionsColumn.ReadOnly = true;
            this.colTRT_FG.Visible = true;
            this.colTRT_FG.Width = 100;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "판정 후 처리현황";
            this.gridBand6.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand7,
            this.gridBand8,
            this.gridBand9});
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 5;
            this.gridBand6.Width = 325;
            // 
            // gridBand7
            // 
            this.gridBand7.Caption = "재입고창고";
            this.gridBand7.Columns.Add(this.colWH_CD);
            this.gridBand7.Columns.Add(this.colWH_NM);
            this.gridBand7.Columns.Add(this.colWC_CD);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 0;
            this.gridBand7.Width = 100;
            // 
            // colWH_CD
            // 
            this.colWH_CD.FieldName = "WH_CD";
            this.colWH_CD.Name = "colWH_CD";
            this.colWH_CD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colWH_CD.OptionsColumn.ReadOnly = true;
            this.colWH_CD.Width = 90;
            // 
            // colWH_NM
            // 
            this.colWH_NM.Caption = "재입고창고";
            this.colWH_NM.FieldName = "WH_NM";
            this.colWH_NM.Name = "colWH_NM";
            this.colWH_NM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colWH_NM.OptionsColumn.ReadOnly = true;
            this.colWH_NM.Visible = true;
            this.colWH_NM.Width = 100;
            // 
            // colWC_CD
            // 
            this.colWC_CD.FieldName = "WC_CD";
            this.colWC_CD.Name = "colWC_CD";
            this.colWC_CD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colWC_CD.OptionsColumn.ReadOnly = true;
            // 
            // gridBand8
            // 
            this.gridBand8.Caption = "재입고위치";
            this.gridBand8.Columns.Add(this.colLOC_CD);
            this.gridBand8.Columns.Add(this.colLOC_NM);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 1;
            this.gridBand8.Width = 150;
            // 
            // colLOC_CD
            // 
            this.colLOC_CD.FieldName = "LOC_CD";
            this.colLOC_CD.Name = "colLOC_CD";
            this.colLOC_CD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLOC_CD.OptionsColumn.ReadOnly = true;
            this.colLOC_CD.Width = 90;
            // 
            // colLOC_NM
            // 
            this.colLOC_NM.FieldName = "LOC_NM";
            this.colLOC_NM.Name = "colLOC_NM";
            this.colLOC_NM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLOC_NM.OptionsColumn.ReadOnly = true;
            this.colLOC_NM.Visible = true;
            this.colLOC_NM.Width = 150;
            // 
            // gridBand9
            // 
            this.gridBand9.Caption = "반송업체";
            this.gridBand9.Columns.Add(this.colBP_NM);
            this.gridBand9.Columns.Add(this.colBP_CD);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.VisibleIndex = 2;
            this.gridBand9.Width = 75;
            // 
            // colBP_NM
            // 
            this.colBP_NM.Caption = "반품거래처";
            this.colBP_NM.FieldName = "BP_NM";
            this.colBP_NM.Name = "colBP_NM";
            this.colBP_NM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colBP_NM.OptionsColumn.ReadOnly = true;
            this.colBP_NM.Visible = true;
            // 
            // colBP_CD
            // 
            this.colBP_CD.FieldName = "BP_CD";
            this.colBP_CD.Name = "colBP_CD";
            this.colBP_CD.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colBP_CD.OptionsColumn.ReadOnly = true;
            this.colBP_CD.Width = 120;
            // 
            // colNCR_QTY
            // 
            this.colNCR_QTY.FieldName = "NCR_QTY";
            this.colNCR_QTY.Name = "colNCR_QTY";
            this.colNCR_QTY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNCR_QTY.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colROUTE_NO
            // 
            this.colROUTE_NO.FieldName = "ROUTE_NO";
            this.colROUTE_NO.Name = "colROUTE_NO";
            this.colROUTE_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colROUTE_NO.OptionsColumn.ReadOnly = true;
            // 
            // colOPER
            // 
            this.colOPER.FieldName = "OPER";
            this.colOPER.Name = "colOPER";
            this.colOPER.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colOPER.OptionsColumn.ReadOnly = true;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colREMARK.OptionsColumn.ReadOnly = true;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            // 
            // NcrHistDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "NcrHistDetailList";
            this.Text = "NcrHistDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncrHistDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView1;
        private System.Windows.Forms.BindingSource ncrHistDetailModelBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNCR_NO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNCR_JUDGE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHU_NO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNCR_QTY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTRT_FG;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colWH_CD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLOC_CD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBP_CD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colROUTE_NO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colOPER;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colWC_CD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colREMARK;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVALID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSORT_NO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLANG_CODE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRowState;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCrudCls;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIsCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colWH_NM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLOC_NM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBP_NM;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
    }
}
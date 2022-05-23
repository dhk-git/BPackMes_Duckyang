namespace BPack.Carrying.App.QC.QchFinalRead
{
    partial class QchFinalReadDetailList
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
            this.qchFinalReadDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.colINSP_NO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINSP_DV = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVALID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLANG_CODE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRowState = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINSP_ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINSP_NM = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINSP_SPEC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLOWER_LIMIT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBASE_VALUE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUPPER_LIMIT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINSP_METHOD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINSP_VAL_TYPE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINSP_VAL_QC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colINSP_JUDGE_QC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpsTextNumeric = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rpsTextOX = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rpsTextString = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridBand9 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand15 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand7 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand8 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand12 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand13 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand14 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qchFinalReadDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsTextNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsTextOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsTextString)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.qchFinalReadDetailModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpsTextNumeric,
            this.rpsTextOX,
            this.rpsTextString});
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(1202, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // qchFinalReadDetailModelBindingSource
            // 
            this.qchFinalReadDetailModelBindingSource.DataSource = typeof(BPack.Model.App.QC.QchFinalRead.QchFinalReadDetailModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.BandPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand9,
            this.gridBand1,
            this.gridBand2,
            this.gridBand15,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6,
            this.gridBand7,
            this.gridBand8,
            this.gridBand12});
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colINSP_NO,
            this.colINSP_DV,
            this.colINSP_ID,
            this.colINSP_NM,
            this.colINSP_SPEC,
            this.colLOWER_LIMIT,
            this.colBASE_VALUE,
            this.colUPPER_LIMIT,
            this.colINSP_METHOD,
            this.colINSP_VAL_TYPE,
            this.colINSP_VAL_QC,
            this.colINSP_JUDGE_QC,
            this.colREMARK,
            this.colMODIFY_DTTM,
            this.colMODIFY_USER_ID,
            this.colVALID,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colCREATE_DTTM,
            this.colCREATE_USER_ID,
            this.colLANG_CODE,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colINSP_NO
            // 
            this.colINSP_NO.FieldName = "INSP_NO";
            this.colINSP_NO.Name = "colINSP_NO";
            // 
            // colINSP_DV
            // 
            this.colINSP_DV.FieldName = "INSP_DV";
            this.colINSP_DV.Name = "colINSP_DV";
            this.colINSP_DV.Visible = true;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
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
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
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
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.Width = 45;
            // 
            // colINSP_ID
            // 
            this.colINSP_ID.FieldName = "INSP_ID";
            this.colINSP_ID.Name = "colINSP_ID";
            this.colINSP_ID.Visible = true;
            // 
            // colINSP_NM
            // 
            this.colINSP_NM.FieldName = "INSP_NM";
            this.colINSP_NM.Name = "colINSP_NM";
            this.colINSP_NM.Visible = true;
            this.colINSP_NM.Width = 140;
            // 
            // colINSP_SPEC
            // 
            this.colINSP_SPEC.FieldName = "INSP_SPEC";
            this.colINSP_SPEC.Name = "colINSP_SPEC";
            this.colINSP_SPEC.Visible = true;
            this.colINSP_SPEC.Width = 200;
            // 
            // colLOWER_LIMIT
            // 
            this.colLOWER_LIMIT.AppearanceCell.Options.UseTextOptions = true;
            this.colLOWER_LIMIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colLOWER_LIMIT.FieldName = "LOWER_LIMIT";
            this.colLOWER_LIMIT.Name = "colLOWER_LIMIT";
            this.colLOWER_LIMIT.Visible = true;
            this.colLOWER_LIMIT.Width = 90;
            // 
            // colBASE_VALUE
            // 
            this.colBASE_VALUE.AppearanceCell.Options.UseTextOptions = true;
            this.colBASE_VALUE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBASE_VALUE.FieldName = "BASE_VALUE";
            this.colBASE_VALUE.Name = "colBASE_VALUE";
            this.colBASE_VALUE.Visible = true;
            this.colBASE_VALUE.Width = 90;
            // 
            // colUPPER_LIMIT
            // 
            this.colUPPER_LIMIT.AppearanceCell.Options.UseTextOptions = true;
            this.colUPPER_LIMIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUPPER_LIMIT.FieldName = "UPPER_LIMIT";
            this.colUPPER_LIMIT.Name = "colUPPER_LIMIT";
            this.colUPPER_LIMIT.Visible = true;
            this.colUPPER_LIMIT.Width = 90;
            // 
            // colINSP_METHOD
            // 
            this.colINSP_METHOD.FieldName = "INSP_METHOD";
            this.colINSP_METHOD.Name = "colINSP_METHOD";
            this.colINSP_METHOD.Visible = true;
            this.colINSP_METHOD.Width = 80;
            // 
            // colINSP_VAL_TYPE
            // 
            this.colINSP_VAL_TYPE.FieldName = "INSP_VAL_TYPE";
            this.colINSP_VAL_TYPE.Name = "colINSP_VAL_TYPE";
            this.colINSP_VAL_TYPE.Visible = true;
            this.colINSP_VAL_TYPE.Width = 90;
            // 
            // colINSP_VAL_QC
            // 
            this.colINSP_VAL_QC.AppearanceCell.Options.UseTextOptions = true;
            this.colINSP_VAL_QC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colINSP_VAL_QC.FieldName = "INSP_VAL_QC";
            this.colINSP_VAL_QC.Name = "colINSP_VAL_QC";
            this.colINSP_VAL_QC.Visible = true;
            this.colINSP_VAL_QC.Width = 90;
            // 
            // colINSP_JUDGE_QC
            // 
            this.colINSP_JUDGE_QC.FieldName = "INSP_JUDGE_QC";
            this.colINSP_JUDGE_QC.Name = "colINSP_JUDGE_QC";
            this.colINSP_JUDGE_QC.Visible = true;
            this.colINSP_JUDGE_QC.Width = 60;
            // 
            // rpsTextNumeric
            // 
            this.rpsTextNumeric.AutoHeight = false;
            this.rpsTextNumeric.DisplayFormat.FormatString = "#,##0.#";
            this.rpsTextNumeric.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rpsTextNumeric.Mask.EditMask = "n4";
            this.rpsTextNumeric.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.rpsTextNumeric.Name = "rpsTextNumeric";
            // 
            // rpsTextOX
            // 
            this.rpsTextOX.AutoHeight = false;
            this.rpsTextOX.Mask.EditMask = "O|X";
            this.rpsTextOX.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.rpsTextOX.Name = "rpsTextOX";
            // 
            // rpsTextString
            // 
            this.rpsTextString.AutoHeight = false;
            this.rpsTextString.Name = "rpsTextString";
            // 
            // gridBand9
            // 
            this.gridBand9.Caption = "선택";
            this.gridBand9.Columns.Add(this.colIsCheck);
            this.gridBand9.Name = "gridBand9";
            this.gridBand9.VisibleIndex = 0;
            this.gridBand9.Width = 45;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "검사분류";
            this.gridBand1.Columns.Add(this.colINSP_NO);
            this.gridBand1.Columns.Add(this.colINSP_DV);
            this.gridBand1.Columns.Add(this.colREMARK);
            this.gridBand1.Columns.Add(this.colMODIFY_DTTM);
            this.gridBand1.Columns.Add(this.colMODIFY_USER_ID);
            this.gridBand1.Columns.Add(this.colVALID);
            this.gridBand1.Columns.Add(this.colSORT_NO);
            this.gridBand1.Columns.Add(this.colROW_SEQ);
            this.gridBand1.Columns.Add(this.colCREATE_DTTM);
            this.gridBand1.Columns.Add(this.colCREATE_USER_ID);
            this.gridBand1.Columns.Add(this.colLANG_CODE);
            this.gridBand1.Columns.Add(this.colRowState);
            this.gridBand1.Columns.Add(this.colCrudCls);
            this.gridBand1.Columns.Add(this.colSelectedCheck);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 1;
            this.gridBand1.Width = 75;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "검사항목";
            this.gridBand2.Columns.Add(this.colINSP_ID);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 75;
            // 
            // gridBand15
            // 
            this.gridBand15.Caption = "검사항목명";
            this.gridBand15.Columns.Add(this.colINSP_NM);
            this.gridBand15.Name = "gridBand15";
            this.gridBand15.VisibleIndex = 3;
            this.gridBand15.Width = 140;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "검사규격";
            this.gridBand3.Columns.Add(this.colINSP_SPEC);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 4;
            this.gridBand3.Width = 200;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "하한값";
            this.gridBand4.Columns.Add(this.colLOWER_LIMIT);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 5;
            this.gridBand4.Width = 90;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "기준값";
            this.gridBand5.Columns.Add(this.colBASE_VALUE);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 6;
            this.gridBand5.Width = 90;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "상한값";
            this.gridBand6.Columns.Add(this.colUPPER_LIMIT);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 7;
            this.gridBand6.Width = 90;
            // 
            // gridBand7
            // 
            this.gridBand7.Caption = "검사방법";
            this.gridBand7.Columns.Add(this.colINSP_METHOD);
            this.gridBand7.Name = "gridBand7";
            this.gridBand7.VisibleIndex = 8;
            this.gridBand7.Width = 80;
            // 
            // gridBand8
            // 
            this.gridBand8.Caption = "측정값유형";
            this.gridBand8.Columns.Add(this.colINSP_VAL_TYPE);
            this.gridBand8.Name = "gridBand8";
            this.gridBand8.VisibleIndex = 9;
            this.gridBand8.Width = 90;
            // 
            // gridBand12
            // 
            this.gridBand12.Caption = "품질";
            this.gridBand12.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand13,
            this.gridBand14});
            this.gridBand12.Name = "gridBand12";
            this.gridBand12.VisibleIndex = 10;
            this.gridBand12.Width = 150;
            // 
            // gridBand13
            // 
            this.gridBand13.Caption = "측정값";
            this.gridBand13.Columns.Add(this.colINSP_VAL_QC);
            this.gridBand13.Name = "gridBand13";
            this.gridBand13.VisibleIndex = 0;
            this.gridBand13.Width = 90;
            // 
            // gridBand14
            // 
            this.gridBand14.Caption = "판정";
            this.gridBand14.Columns.Add(this.colINSP_JUDGE_QC);
            this.gridBand14.Name = "gridBand14";
            this.gridBand14.VisibleIndex = 1;
            this.gridBand14.Width = 60;
            // 
            // QchFinalReadDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "QchFinalReadDetailList";
            this.Text = "QchFinalReadDetailList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qchFinalReadDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsTextNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsTextOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsTextString)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private System.Windows.Forms.BindingSource qchFinalReadDetailModelBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colINSP_NO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colINSP_DV;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colREMARK;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVALID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSORT_NO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLANG_CODE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRowState;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCrudCls;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIsCheck;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colINSP_ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colINSP_NM;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colINSP_SPEC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLOWER_LIMIT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBASE_VALUE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUPPER_LIMIT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colINSP_METHOD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colINSP_VAL_TYPE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colINSP_VAL_QC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colINSP_JUDGE_QC;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rpsTextNumeric;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rpsTextOX;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rpsTextString;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand9;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand15;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand7;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand8;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand12;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand13;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand14;
    }
}
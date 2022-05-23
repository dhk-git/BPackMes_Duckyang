namespace BPack.Carrying.App.MD.BpaInfo
{
    partial class BpList
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
            this.bpGrd = new BPack.Strap.Grid.StrapGridControl();
            this.bpModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bpGrv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bpGrv_Col_COMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_BP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_COMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_BP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCEO_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_BP_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_IS_PURCHASE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_IS_SALES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_ADDR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_VALID_FROM_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_VALID_TO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bpGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpGrv)).BeginInit();
            this.SuspendLayout();
            // 
            // bpGrd
            // 
            this.bpGrd.ArgsBase = null;
            this.bpGrd.DataSource = this.bpModelBindingSource;
            this.bpGrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bpGrd.IsStrapGridViewDefaultSetting = true;
            this.bpGrd.Location = new System.Drawing.Point(0, 0);
            this.bpGrd.MainView = this.bpGrv;
            this.bpGrd.Name = "bpGrd";
            this.bpGrd.SelectedModel = null;
            this.bpGrd.SelectedModelIndex = null;
            this.bpGrd.Size = new System.Drawing.Size(800, 450);
            this.bpGrd.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.bpGrd.StrapMdiForm = null;
            this.bpGrd.StrapSubForm = null;
            this.bpGrd.TabIndex = 0;
            this.bpGrd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bpGrv});
            // 
            // bpModelBindingSource
            // 
            this.bpModelBindingSource.DataSource = typeof(BPack.Model.App.MD.BpaInfo.BparModel);
            // 
            // bpGrv
            // 
            this.bpGrv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bpGrv_Col_COMP_CD_KEY,
            this.bpGrv_Col_BP_CD_KEY,
            this.bpGrv_Col_COMP_CD,
            this.bpGrv_Col_BP_CD,
            this.colCEO_NM,
            this.colTEL,
            this.bpGrv_Col_BP_NM,
            this.bpGrv_Col_IS_PURCHASE,
            this.bpGrv_Col_IS_SALES,
            this.bpGrv_Col_ADDR,
            this.bpGrv_Col_REMARK,
            this.bpGrv_Col_VALID_FROM_DT,
            this.bpGrv_Col_VALID_TO_DT});
            this.bpGrv.GridControl = this.bpGrd;
            this.bpGrv.Name = "bpGrv";
            // 
            // bpGrv_Col_COMP_CD_KEY
            // 
            this.bpGrv_Col_COMP_CD_KEY.Caption = "COMP_CD_KEY";
            this.bpGrv_Col_COMP_CD_KEY.FieldName = "COMP_CD_KEY";
            this.bpGrv_Col_COMP_CD_KEY.Name = "bpGrv_Col_COMP_CD_KEY";
            this.bpGrv_Col_COMP_CD_KEY.Visible = true;
            this.bpGrv_Col_COMP_CD_KEY.VisibleIndex = 0;
            // 
            // bpGrv_Col_BP_CD_KEY
            // 
            this.bpGrv_Col_BP_CD_KEY.Caption = "BP_CD_KEY";
            this.bpGrv_Col_BP_CD_KEY.FieldName = "BP_CD_KEY";
            this.bpGrv_Col_BP_CD_KEY.Name = "bpGrv_Col_BP_CD_KEY";
            this.bpGrv_Col_BP_CD_KEY.Visible = true;
            this.bpGrv_Col_BP_CD_KEY.VisibleIndex = 1;
            // 
            // bpGrv_Col_COMP_CD
            // 
            this.bpGrv_Col_COMP_CD.Caption = "회사코드";
            this.bpGrv_Col_COMP_CD.FieldName = "COMP_CD";
            this.bpGrv_Col_COMP_CD.Name = "bpGrv_Col_COMP_CD";
            // 
            // bpGrv_Col_BP_CD
            // 
            this.bpGrv_Col_BP_CD.Caption = "거래처코드";
            this.bpGrv_Col_BP_CD.FieldName = "BP_CD";
            this.bpGrv_Col_BP_CD.Name = "bpGrv_Col_BP_CD";
            this.bpGrv_Col_BP_CD.Visible = true;
            this.bpGrv_Col_BP_CD.VisibleIndex = 2;
            // 
            // colCEO_NM
            // 
            this.colCEO_NM.FieldName = "CEO_NM";
            this.colCEO_NM.Name = "colCEO_NM";
            this.colCEO_NM.Visible = true;
            this.colCEO_NM.VisibleIndex = 4;
            // 
            // bpGrv_Col_BP_NM
            // 
            this.bpGrv_Col_BP_NM.Caption = "거래처명";
            this.bpGrv_Col_BP_NM.FieldName = "BP_NM";
            this.bpGrv_Col_BP_NM.Name = "bpGrv_Col_BP_NM";
            this.bpGrv_Col_BP_NM.Visible = true;
            this.bpGrv_Col_BP_NM.VisibleIndex = 3;
            // 
            // bpGrv_Col_IS_PURCHASE
            // 
            this.bpGrv_Col_IS_PURCHASE.Caption = "매입여부";
            this.bpGrv_Col_IS_PURCHASE.FieldName = "IS_PURCHASE";
            this.bpGrv_Col_IS_PURCHASE.Name = "bpGrv_Col_IS_PURCHASE";
            this.bpGrv_Col_IS_PURCHASE.Visible = true;
            this.bpGrv_Col_IS_PURCHASE.VisibleIndex = 6;
            // 
            // bpGrv_Col_IS_SALES
            // 
            this.bpGrv_Col_IS_SALES.Caption = "매출여부";
            this.bpGrv_Col_IS_SALES.FieldName = "IS_SALES";
            this.bpGrv_Col_IS_SALES.Name = "bpGrv_Col_IS_SALES";
            this.bpGrv_Col_IS_SALES.Visible = true;
            this.bpGrv_Col_IS_SALES.VisibleIndex = 7;
            // 
            // bpGrv_Col_ADDR
            // 
            this.bpGrv_Col_ADDR.Caption = "주소";
            this.bpGrv_Col_ADDR.FieldName = "ADDR";
            this.bpGrv_Col_ADDR.Name = "bpGrv_Col_ADDR";
            this.bpGrv_Col_ADDR.Visible = true;
            this.bpGrv_Col_ADDR.VisibleIndex = 8;
            // 
            // bpGrv_Col_REMARK
            // 
            this.bpGrv_Col_REMARK.Caption = "비고";
            this.bpGrv_Col_REMARK.FieldName = "REMARK";
            this.bpGrv_Col_REMARK.Name = "bpGrv_Col_REMARK";
            this.bpGrv_Col_REMARK.Visible = true;
            this.bpGrv_Col_REMARK.VisibleIndex = 9;
            // 
            // bpGrv_Col_VALID_FROM_DT
            // 
            this.bpGrv_Col_VALID_FROM_DT.Caption = "유효시작일";
            this.bpGrv_Col_VALID_FROM_DT.FieldName = "VALID_FROM_DT";
            this.bpGrv_Col_VALID_FROM_DT.Name = "bpGrv_Col_VALID_FROM_DT";
            this.bpGrv_Col_VALID_FROM_DT.Visible = true;
            this.bpGrv_Col_VALID_FROM_DT.VisibleIndex = 10;
            // 
            // bpGrv_Col_VALID_TO_DT
            // 
            this.bpGrv_Col_VALID_TO_DT.Caption = "유효종료일";
            this.bpGrv_Col_VALID_TO_DT.FieldName = "VALID_TO_DT";
            this.bpGrv_Col_VALID_TO_DT.Name = "bpGrv_Col_VALID_TO_DT";
            this.bpGrv_Col_VALID_TO_DT.Visible = true;
            this.bpGrv_Col_VALID_TO_DT.VisibleIndex = 11;
            // 
            // colTEL
            // 
            this.colTEL.FieldName = "TEL";
            this.colTEL.Name = "colTEL";
            this.colTEL.Visible = true;
            this.colTEL.VisibleIndex = 5;
            // 
            // BpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bpGrd);
            this.Name = "BpList";
            this.Text = "BpList";
            ((System.ComponentModel.ISupportInitialize)(this.bpGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpGrv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl bpGrd;
        private DevExpress.XtraGrid.Views.Grid.GridView bpGrv;
        private System.Windows.Forms.BindingSource bpModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_COMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_BP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_COMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_BP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_BP_NM;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_IS_PURCHASE;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_IS_SALES;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_ADDR;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_VALID_FROM_DT;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_VALID_TO_DT;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colCEO_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colTEL;
    }
}
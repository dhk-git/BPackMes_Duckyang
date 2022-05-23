namespace BPack.Carrying.App.MD.BpaGate
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
            this.bparGrd = new BPack.Strap.Grid.StrapGridControl();
            this.bparGrv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bparModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bpGrv_Col_COMP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_BP_CD_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_COMP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_BP_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_BP_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_IS_PURCHASE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_IS_SALES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_ADDR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_REMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_VALID_FROM_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bpGrv_Col_VALID_TO_DT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bparGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bparGrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bparModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bparGrd
            // 
            this.bparGrd.DataSource = this.bparModelBindingSource;
            this.bparGrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bparGrd.IsStrapGridViewDefaultSetting = true;
            this.bparGrd.Location = new System.Drawing.Point(0, 0);
            this.bparGrd.MainView = this.bparGrv;
            this.bparGrd.Name = "bparGrd";
            this.bparGrd.SelectedModel = null;
            this.bparGrd.SelectedModelIndex = null;
            this.bparGrd.Size = new System.Drawing.Size(800, 450);
            this.bparGrd.TabIndex = 0;
            this.bparGrd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bparGrv});
            // 
            // bparGrv
            // 
            this.bparGrv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bpGrv_Col_COMP_CD_KEY,
            this.bpGrv_Col_BP_CD_KEY,
            this.bpGrv_Col_COMP_CD,
            this.bpGrv_Col_BP_CD,
            this.bpGrv_Col_BP_NM,
            this.bpGrv_Col_IS_PURCHASE,
            this.bpGrv_Col_IS_SALES,
            this.bpGrv_Col_ADDR,
            this.bpGrv_Col_REMARK,
            this.bpGrv_Col_VALID_FROM_DT,
            this.bpGrv_Col_VALID_TO_DT});
            this.bparGrv.GridControl = this.bparGrd;
            this.bparGrv.Name = "bparGrv";
            // 
            // bparModelBindingSource
            // 
            this.bparModelBindingSource.DataSource = typeof(BPack.Model.App.MD.BpaGate.BparModel);
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
            this.bpGrv_Col_IS_PURCHASE.VisibleIndex = 4;
            // 
            // bpGrv_Col_IS_SALES
            // 
            this.bpGrv_Col_IS_SALES.Caption = "매출여부";
            this.bpGrv_Col_IS_SALES.FieldName = "IS_SALES";
            this.bpGrv_Col_IS_SALES.Name = "bpGrv_Col_IS_SALES";
            this.bpGrv_Col_IS_SALES.Visible = true;
            this.bpGrv_Col_IS_SALES.VisibleIndex = 5;
            // 
            // bpGrv_Col_ADDR
            // 
            this.bpGrv_Col_ADDR.Caption = "주소";
            this.bpGrv_Col_ADDR.FieldName = "ADDR";
            this.bpGrv_Col_ADDR.Name = "bpGrv_Col_ADDR";
            this.bpGrv_Col_ADDR.Visible = true;
            this.bpGrv_Col_ADDR.VisibleIndex = 6;
            // 
            // bpGrv_Col_REMARK
            // 
            this.bpGrv_Col_REMARK.Caption = "비고";
            this.bpGrv_Col_REMARK.FieldName = "REMARK";
            this.bpGrv_Col_REMARK.Name = "bpGrv_Col_REMARK";
            this.bpGrv_Col_REMARK.Visible = true;
            this.bpGrv_Col_REMARK.VisibleIndex = 7;
            // 
            // bpGrv_Col_VALID_FROM_DT
            // 
            this.bpGrv_Col_VALID_FROM_DT.Caption = "유효시작일";
            this.bpGrv_Col_VALID_FROM_DT.FieldName = "VALID_FROM_DT";
            this.bpGrv_Col_VALID_FROM_DT.Name = "bpGrv_Col_VALID_FROM_DT";
            this.bpGrv_Col_VALID_FROM_DT.Visible = true;
            this.bpGrv_Col_VALID_FROM_DT.VisibleIndex = 8;
            // 
            // bpGrv_Col_VALID_TO_DT
            // 
            this.bpGrv_Col_VALID_TO_DT.Caption = "유효종료일";
            this.bpGrv_Col_VALID_TO_DT.FieldName = "VALID_TO_DT";
            this.bpGrv_Col_VALID_TO_DT.Name = "bpGrv_Col_VALID_TO_DT";
            this.bpGrv_Col_VALID_TO_DT.Visible = true;
            this.bpGrv_Col_VALID_TO_DT.VisibleIndex = 9;
            // 
            // BpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bparGrd);
            this.Name = "BpList";
            this.Text = "BpList";
            ((System.ComponentModel.ISupportInitialize)(this.bparGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bparGrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bparModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl bparGrd;
        private DevExpress.XtraGrid.Views.Grid.GridView bparGrv;
        private System.Windows.Forms.BindingSource bparModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_COMP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_BP_CD_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_COMP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_BP_CD;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_BP_NM;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_IS_PURCHASE;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_IS_SALES;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_ADDR;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_REMARK;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_VALID_FROM_DT;
        private DevExpress.XtraGrid.Columns.GridColumn bpGrv_Col_VALID_TO_DT;
    }
}
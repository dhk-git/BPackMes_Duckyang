
namespace BPack.Carrying.App.SD.DlvConfirm2
{
    partial class DlvResultEditForm
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
            this.strapDataLayout1 = new BPack.Strap.Layout.StrapDataLayout();
            this.CUST_DOH_NOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dlvResultModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VEHICLE_NOLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.REMARKMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.DRIVER_NMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCUST_DOH_NO = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDRIVER_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForREMARK = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVEHICLE_NO = new DevExpress.XtraLayout.LayoutControlItem();
            this.DRH_NOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForDRH_NO = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).BeginInit();
            this.strapDataLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUST_DOH_NOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvResultModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VEHICLE_NOLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REMARKMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRIVER_NMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCUST_DOH_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDRIVER_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREMARK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVEHICLE_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRH_NOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDRH_NO)).BeginInit();
            this.SuspendLayout();
            // 
            // strapDataLayout1
            // 
            this.SetBoundPropertyName(this.strapDataLayout1, "");
            this.strapDataLayout1.Controls.Add(this.CUST_DOH_NOTextEdit);
            this.strapDataLayout1.Controls.Add(this.VEHICLE_NOLookUpEdit);
            this.strapDataLayout1.Controls.Add(this.REMARKMemoEdit);
            this.strapDataLayout1.Controls.Add(this.DRIVER_NMTextEdit);
            this.strapDataLayout1.Controls.Add(this.DRH_NOTextEdit);
            this.strapDataLayout1.DataSource = this.dlvResultModelBindingSource;
            this.strapDataLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapDataLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapDataLayout1.Name = "strapDataLayout1";
            this.strapDataLayout1.Root = this.Root;
            this.strapDataLayout1.Size = new System.Drawing.Size(561, 189);
            this.strapDataLayout1.TabIndex = 0;
            this.strapDataLayout1.Text = "strapDataLayout1";
            // 
            // CUST_DOH_NOTextEdit
            // 
            this.SetBoundPropertyName(this.CUST_DOH_NOTextEdit, "");
            this.CUST_DOH_NOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvResultModelBindingSource, "CUST_DOH_NO", true));
            this.CUST_DOH_NOTextEdit.Location = new System.Drawing.Point(355, 12);
            this.CUST_DOH_NOTextEdit.Name = "CUST_DOH_NOTextEdit";
            this.CUST_DOH_NOTextEdit.Size = new System.Drawing.Size(194, 20);
            this.CUST_DOH_NOTextEdit.StyleController = this.strapDataLayout1;
            this.CUST_DOH_NOTextEdit.TabIndex = 4;
            // 
            // dlvResultModelBindingSource
            // 
            this.dlvResultModelBindingSource.DataSource = typeof(BPack.Model.App.SD.DlvConfirm2.DlvResultModel);
            // 
            // VEHICLE_NOLookUpEdit
            // 
            this.SetBoundPropertyName(this.VEHICLE_NOLookUpEdit, "");
            this.VEHICLE_NOLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvResultModelBindingSource, "VEHICLE_NO", true));
            this.VEHICLE_NOLookUpEdit.Location = new System.Drawing.Point(85, 36);
            this.VEHICLE_NOLookUpEdit.Name = "VEHICLE_NOLookUpEdit";
            this.VEHICLE_NOLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VEHICLE_NOLookUpEdit.Properties.NullText = "";
            this.VEHICLE_NOLookUpEdit.Size = new System.Drawing.Size(193, 20);
            this.VEHICLE_NOLookUpEdit.StyleController = this.strapDataLayout1;
            this.VEHICLE_NOLookUpEdit.TabIndex = 5;
            // 
            // REMARKMemoEdit
            // 
            this.SetBoundPropertyName(this.REMARKMemoEdit, "");
            this.REMARKMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvResultModelBindingSource, "REMARK", true));
            this.REMARKMemoEdit.Location = new System.Drawing.Point(85, 60);
            this.REMARKMemoEdit.Name = "REMARKMemoEdit";
            this.REMARKMemoEdit.Size = new System.Drawing.Size(464, 117);
            this.REMARKMemoEdit.StyleController = this.strapDataLayout1;
            this.REMARKMemoEdit.TabIndex = 7;
            // 
            // DRIVER_NMTextEdit
            // 
            this.SetBoundPropertyName(this.DRIVER_NMTextEdit, "");
            this.DRIVER_NMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvResultModelBindingSource, "DRIVER_NM", true));
            this.DRIVER_NMTextEdit.Location = new System.Drawing.Point(355, 36);
            this.DRIVER_NMTextEdit.Name = "DRIVER_NMTextEdit";
            this.DRIVER_NMTextEdit.Size = new System.Drawing.Size(194, 20);
            this.DRIVER_NMTextEdit.StyleController = this.strapDataLayout1;
            this.DRIVER_NMTextEdit.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(561, 189);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDRIVER_NM,
            this.ItemForREMARK,
            this.ItemForDRH_NO,
            this.ItemForCUST_DOH_NO,
            this.ItemForVEHICLE_NO});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(541, 169);
            // 
            // ItemForCUST_DOH_NO
            // 
            this.ItemForCUST_DOH_NO.Control = this.CUST_DOH_NOTextEdit;
            this.ItemForCUST_DOH_NO.Location = new System.Drawing.Point(270, 0);
            this.ItemForCUST_DOH_NO.Name = "ItemForCUST_DOH_NO";
            this.ItemForCUST_DOH_NO.Size = new System.Drawing.Size(271, 24);
            this.ItemForCUST_DOH_NO.TextSize = new System.Drawing.Size(70, 14);
            // 
            // ItemForDRIVER_NM
            // 
            this.ItemForDRIVER_NM.Control = this.DRIVER_NMTextEdit;
            this.ItemForDRIVER_NM.Location = new System.Drawing.Point(270, 24);
            this.ItemForDRIVER_NM.Name = "ItemForDRIVER_NM";
            this.ItemForDRIVER_NM.Size = new System.Drawing.Size(271, 24);
            this.ItemForDRIVER_NM.TextSize = new System.Drawing.Size(70, 14);
            // 
            // ItemForREMARK
            // 
            this.ItemForREMARK.Control = this.REMARKMemoEdit;
            this.ItemForREMARK.Location = new System.Drawing.Point(0, 48);
            this.ItemForREMARK.Name = "ItemForREMARK";
            this.ItemForREMARK.Size = new System.Drawing.Size(541, 121);
            this.ItemForREMARK.StartNewLine = true;
            this.ItemForREMARK.TextSize = new System.Drawing.Size(70, 14);
            // 
            // ItemForVEHICLE_NO
            // 
            this.ItemForVEHICLE_NO.Control = this.VEHICLE_NOLookUpEdit;
            this.ItemForVEHICLE_NO.Location = new System.Drawing.Point(0, 24);
            this.ItemForVEHICLE_NO.Name = "ItemForVEHICLE_NO";
            this.ItemForVEHICLE_NO.Size = new System.Drawing.Size(270, 24);
            this.ItemForVEHICLE_NO.TextSize = new System.Drawing.Size(70, 14);
            // 
            // DRH_NOTextEdit
            // 
            this.SetBoundPropertyName(this.DRH_NOTextEdit, "");
            this.DRH_NOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvResultModelBindingSource, "DRH_NO", true));
            this.DRH_NOTextEdit.Location = new System.Drawing.Point(85, 12);
            this.DRH_NOTextEdit.Name = "DRH_NOTextEdit";
            this.DRH_NOTextEdit.Size = new System.Drawing.Size(193, 20);
            this.DRH_NOTextEdit.StyleController = this.strapDataLayout1;
            this.DRH_NOTextEdit.TabIndex = 8;
            // 
            // ItemForDRH_NO
            // 
            this.ItemForDRH_NO.Control = this.DRH_NOTextEdit;
            this.ItemForDRH_NO.Location = new System.Drawing.Point(0, 0);
            this.ItemForDRH_NO.Name = "ItemForDRH_NO";
            this.ItemForDRH_NO.Size = new System.Drawing.Size(270, 24);
            this.ItemForDRH_NO.TextSize = new System.Drawing.Size(70, 14);
            // 
            // DlvResultEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.strapDataLayout1);
            this.Name = "DlvResultEditForm";
            this.Size = new System.Drawing.Size(561, 189);
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).EndInit();
            this.strapDataLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CUST_DOH_NOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvResultModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VEHICLE_NOLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REMARKMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRIVER_NMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCUST_DOH_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDRIVER_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREMARK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVEHICLE_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRH_NOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDRH_NO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapDataLayout strapDataLayout1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource dlvResultModelBindingSource;
        private DevExpress.XtraEditors.TextEdit CUST_DOH_NOTextEdit;
        private DevExpress.XtraEditors.LookUpEdit VEHICLE_NOLookUpEdit;
        private DevExpress.XtraEditors.MemoEdit REMARKMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCUST_DOH_NO;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDRIVER_NM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForREMARK;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVEHICLE_NO;
        private DevExpress.XtraEditors.TextEdit DRIVER_NMTextEdit;
        private DevExpress.XtraEditors.TextEdit DRH_NOTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDRH_NO;
    }
}
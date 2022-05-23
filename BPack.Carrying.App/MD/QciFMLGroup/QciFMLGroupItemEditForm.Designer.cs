namespace BPack.Carrying.App.MD.QciFMLGroup
{
    partial class QciFMLGroupItemEditForm
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
            this.ALC_CDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ITEM_NMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ITEM_CDButtonEdit = new BPack.CommonMes.Controls.ItemMaster.ItemMasterButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForITEM_CD = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForALC_CD = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForITEM_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this.qciFMLGroupItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).BeginInit();
            this.strapDataLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALC_CDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_NMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_CDButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_CD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_CD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qciFMLGroupItemModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapDataLayout1
            // 
            this.SetBoundPropertyName(this.strapDataLayout1, "");
            this.strapDataLayout1.Controls.Add(this.ALC_CDTextEdit);
            this.strapDataLayout1.Controls.Add(this.ITEM_NMTextEdit);
            this.strapDataLayout1.Controls.Add(this.ITEM_CDButtonEdit);
            this.strapDataLayout1.DataSource = this.qciFMLGroupItemModelBindingSource;
            this.strapDataLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapDataLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapDataLayout1.Name = "strapDataLayout1";
            this.strapDataLayout1.Root = this.Root;
            this.strapDataLayout1.Size = new System.Drawing.Size(587, 53);
            this.strapDataLayout1.TabIndex = 0;
            this.strapDataLayout1.Text = "strapDataLayout1";
            // 
            // ALC_CDTextEdit
            // 
            this.SetBoundPropertyName(this.ALC_CDTextEdit, "");
            this.ALC_CDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qciFMLGroupItemModelBindingSource, "ALC_CD", true));
            this.ALC_CDTextEdit.Location = new System.Drawing.Point(244, 12);
            this.ALC_CDTextEdit.Name = "ALC_CDTextEdit";
            this.ALC_CDTextEdit.Properties.ReadOnly = true;
            this.ALC_CDTextEdit.Size = new System.Drawing.Size(142, 20);
            this.ALC_CDTextEdit.StyleController = this.strapDataLayout1;
            this.ALC_CDTextEdit.TabIndex = 5;
            // 
            // ITEM_NMTextEdit
            // 
            this.SetBoundPropertyName(this.ITEM_NMTextEdit, "");
            this.ITEM_NMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qciFMLGroupItemModelBindingSource, "ITEM_NM", true));
            this.ITEM_NMTextEdit.Location = new System.Drawing.Point(433, 12);
            this.ITEM_NMTextEdit.Name = "ITEM_NMTextEdit";
            this.ITEM_NMTextEdit.Properties.ReadOnly = true;
            this.ITEM_NMTextEdit.Size = new System.Drawing.Size(142, 20);
            this.ITEM_NMTextEdit.StyleController = this.strapDataLayout1;
            this.ITEM_NMTextEdit.TabIndex = 6;
            // 
            // ITEM_CDButtonEdit
            // 
            this.SetBoundPropertyName(this.ITEM_CDButtonEdit, "");
            this.ITEM_CDButtonEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qciFMLGroupItemModelBindingSource, "ITEM_CD", true));
            this.ITEM_CDButtonEdit.ItemMasterModel = null;
            this.ITEM_CDButtonEdit.Location = new System.Drawing.Point(55, 12);
            this.ITEM_CDButtonEdit.Name = "ITEM_CDButtonEdit";
            this.ITEM_CDButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ITEM_CDButtonEdit.Size = new System.Drawing.Size(142, 20);
            this.ITEM_CDButtonEdit.StyleController = this.strapDataLayout1;
            this.ITEM_CDButtonEdit.TabIndex = 7;
            this.ITEM_CDButtonEdit.EditValueChanged += new System.EventHandler(this.ITEM_CDButtonEdit_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(587, 53);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForITEM_CD,
            this.ItemForALC_CD,
            this.ItemForITEM_NM});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(567, 33);
            // 
            // ItemForITEM_CD
            // 
            this.ItemForITEM_CD.Control = this.ITEM_CDButtonEdit;
            this.ItemForITEM_CD.Location = new System.Drawing.Point(0, 0);
            this.ItemForITEM_CD.Name = "ItemForITEM_CD";
            this.ItemForITEM_CD.Size = new System.Drawing.Size(189, 33);
            this.ItemForITEM_CD.TextSize = new System.Drawing.Size(40, 14);
            // 
            // ItemForALC_CD
            // 
            this.ItemForALC_CD.Control = this.ALC_CDTextEdit;
            this.ItemForALC_CD.Location = new System.Drawing.Point(189, 0);
            this.ItemForALC_CD.Name = "ItemForALC_CD";
            this.ItemForALC_CD.Size = new System.Drawing.Size(189, 33);
            this.ItemForALC_CD.TextSize = new System.Drawing.Size(40, 14);
            // 
            // ItemForITEM_NM
            // 
            this.ItemForITEM_NM.Control = this.ITEM_NMTextEdit;
            this.ItemForITEM_NM.Location = new System.Drawing.Point(378, 0);
            this.ItemForITEM_NM.Name = "ItemForITEM_NM";
            this.ItemForITEM_NM.Size = new System.Drawing.Size(189, 33);
            this.ItemForITEM_NM.TextSize = new System.Drawing.Size(40, 14);
            // 
            // qciFMLGroupItemModelBindingSource
            // 
            this.qciFMLGroupItemModelBindingSource.DataSource = typeof(BPack.Model.App.MD.QciFMLGroup.QciFMLGroupItemModel);
            // 
            // QciFMLGroupItemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.strapDataLayout1);
            this.Name = "QciFMLGroupItemEditForm";
            this.Size = new System.Drawing.Size(587, 53);
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).EndInit();
            this.strapDataLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ALC_CDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_NMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_CDButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_CD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_CD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qciFMLGroupItemModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapDataLayout strapDataLayout1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit ALC_CDTextEdit;
        private System.Windows.Forms.BindingSource qciFMLGroupItemModelBindingSource;
        private DevExpress.XtraEditors.TextEdit ITEM_NMTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForITEM_CD;
        private DevExpress.XtraLayout.LayoutControlItem ItemForALC_CD;
        private DevExpress.XtraLayout.LayoutControlItem ItemForITEM_NM;
        private BPack.CommonMes.Controls.ItemMaster.ItemMasterButtonEdit ITEM_CDButtonEdit;
    }
}
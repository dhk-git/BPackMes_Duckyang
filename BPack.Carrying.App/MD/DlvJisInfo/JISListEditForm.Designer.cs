namespace BPack.Carrying.App.MD.DlvJisInfo
{
    partial class JISListEditForm
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
            this.ALC_NOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ALC_TYPE_NMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LOAD_QTYTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PRINT_COLTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PRINT_WAYLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ALC_TYPELookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForALC_NO = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForALC_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForALC_TYPE_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLOAD_QTY = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPRINT_COL = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPRINT_WAY = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dlvJisInfoJISModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).BeginInit();
            this.strapDataLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALC_NOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALC_TYPE_NMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOAD_QTYTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRINT_COLTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRINT_WAYLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALC_TYPELookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_TYPE_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLOAD_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPRINT_COL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPRINT_WAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvJisInfoJISModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapDataLayout1
            // 
            this.SetBoundPropertyName(this.strapDataLayout1, "");
            this.strapDataLayout1.Controls.Add(this.ALC_NOTextEdit);
            this.strapDataLayout1.Controls.Add(this.ALC_TYPE_NMTextEdit);
            this.strapDataLayout1.Controls.Add(this.LOAD_QTYTextEdit);
            this.strapDataLayout1.Controls.Add(this.PRINT_COLTextEdit);
            this.strapDataLayout1.Controls.Add(this.PRINT_WAYLookUpEdit);
            this.strapDataLayout1.Controls.Add(this.ALC_TYPELookUpEdit);
            this.strapDataLayout1.DataSource = this.dlvJisInfoJISModelBindingSource;
            this.strapDataLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapDataLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapDataLayout1.Name = "strapDataLayout1";
            this.strapDataLayout1.Root = this.Root;
            this.strapDataLayout1.Size = new System.Drawing.Size(694, 78);
            this.strapDataLayout1.TabIndex = 0;
            this.strapDataLayout1.Text = "strapDataLayout1";
            // 
            // ALC_NOTextEdit
            // 
            this.SetBoundPropertyName(this.ALC_NOTextEdit, "");
            this.ALC_NOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvJisInfoJISModelBindingSource, "ALC_NO", true));
            this.ALC_NOTextEdit.Location = new System.Drawing.Point(65, 12);
            this.ALC_NOTextEdit.Name = "ALC_NOTextEdit";
            this.ALC_NOTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ALC_NOTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ALC_NOTextEdit.Properties.Mask.EditMask = "N0";
            this.ALC_NOTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ALC_NOTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ALC_NOTextEdit.Size = new System.Drawing.Size(83, 20);
            this.ALC_NOTextEdit.StyleController = this.strapDataLayout1;
            this.ALC_NOTextEdit.TabIndex = 4;
            // 
            // ALC_TYPE_NMTextEdit
            // 
            this.SetBoundPropertyName(this.ALC_TYPE_NMTextEdit, "");
            this.ALC_TYPE_NMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvJisInfoJISModelBindingSource, "ALC_TYPE_NM", true));
            this.ALC_TYPE_NMTextEdit.Location = new System.Drawing.Point(361, 12);
            this.ALC_TYPE_NMTextEdit.Name = "ALC_TYPE_NMTextEdit";
            this.ALC_TYPE_NMTextEdit.Properties.ReadOnly = true;
            this.ALC_TYPE_NMTextEdit.Size = new System.Drawing.Size(321, 20);
            this.ALC_TYPE_NMTextEdit.StyleController = this.strapDataLayout1;
            this.ALC_TYPE_NMTextEdit.TabIndex = 6;
            // 
            // LOAD_QTYTextEdit
            // 
            this.SetBoundPropertyName(this.LOAD_QTYTextEdit, "");
            this.LOAD_QTYTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvJisInfoJISModelBindingSource, "LOAD_QTY", true));
            this.LOAD_QTYTextEdit.Location = new System.Drawing.Point(65, 36);
            this.LOAD_QTYTextEdit.Name = "LOAD_QTYTextEdit";
            this.LOAD_QTYTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.LOAD_QTYTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LOAD_QTYTextEdit.Properties.Mask.EditMask = "\\d+";
            this.LOAD_QTYTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.LOAD_QTYTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.LOAD_QTYTextEdit.Size = new System.Drawing.Size(83, 20);
            this.LOAD_QTYTextEdit.StyleController = this.strapDataLayout1;
            this.LOAD_QTYTextEdit.TabIndex = 7;
            // 
            // PRINT_COLTextEdit
            // 
            this.SetBoundPropertyName(this.PRINT_COLTextEdit, "");
            this.PRINT_COLTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvJisInfoJISModelBindingSource, "PRINT_COL", true));
            this.PRINT_COLTextEdit.Location = new System.Drawing.Point(205, 36);
            this.PRINT_COLTextEdit.Name = "PRINT_COLTextEdit";
            this.PRINT_COLTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PRINT_COLTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PRINT_COLTextEdit.Properties.Mask.EditMask = "\\d+";
            this.PRINT_COLTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.PRINT_COLTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PRINT_COLTextEdit.Size = new System.Drawing.Size(99, 20);
            this.PRINT_COLTextEdit.StyleController = this.strapDataLayout1;
            this.PRINT_COLTextEdit.TabIndex = 8;
            // 
            // PRINT_WAYLookUpEdit
            // 
            this.SetBoundPropertyName(this.PRINT_WAYLookUpEdit, "");
            this.PRINT_WAYLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvJisInfoJISModelBindingSource, "PRINT_WAY", true));
            this.PRINT_WAYLookUpEdit.Location = new System.Drawing.Point(361, 36);
            this.PRINT_WAYLookUpEdit.Name = "PRINT_WAYLookUpEdit";
            this.PRINT_WAYLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PRINT_WAYLookUpEdit.Properties.NullText = "";
            this.PRINT_WAYLookUpEdit.Size = new System.Drawing.Size(158, 20);
            this.PRINT_WAYLookUpEdit.StyleController = this.strapDataLayout1;
            this.PRINT_WAYLookUpEdit.TabIndex = 10;
            // 
            // ALC_TYPELookUpEdit
            // 
            this.SetBoundPropertyName(this.ALC_TYPELookUpEdit, "");
            this.ALC_TYPELookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dlvJisInfoJISModelBindingSource, "ALC_TYPE", true));
            this.ALC_TYPELookUpEdit.Location = new System.Drawing.Point(205, 12);
            this.ALC_TYPELookUpEdit.Name = "ALC_TYPELookUpEdit";
            this.ALC_TYPELookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ALC_TYPELookUpEdit.Properties.NullText = "";
            this.ALC_TYPELookUpEdit.Size = new System.Drawing.Size(99, 20);
            this.ALC_TYPELookUpEdit.StyleController = this.strapDataLayout1;
            this.ALC_TYPELookUpEdit.TabIndex = 11;
            this.ALC_TYPELookUpEdit.EditValueChanged += new System.EventHandler(this.ALC_TYPELookUpEdit_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(694, 78);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForALC_NO,
            this.ItemForALC_TYPE,
            this.ItemForALC_TYPE_NM,
            this.ItemForLOAD_QTY,
            this.ItemForPRINT_COL,
            this.ItemForPRINT_WAY,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(674, 58);
            // 
            // ItemForALC_NO
            // 
            this.ItemForALC_NO.Control = this.ALC_NOTextEdit;
            this.ItemForALC_NO.Location = new System.Drawing.Point(0, 0);
            this.ItemForALC_NO.Name = "ItemForALC_NO";
            this.ItemForALC_NO.Size = new System.Drawing.Size(140, 24);
            this.ItemForALC_NO.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForALC_TYPE
            // 
            this.ItemForALC_TYPE.Control = this.ALC_TYPELookUpEdit;
            this.ItemForALC_TYPE.Location = new System.Drawing.Point(140, 0);
            this.ItemForALC_TYPE.Name = "ItemForALC_TYPE";
            this.ItemForALC_TYPE.Size = new System.Drawing.Size(156, 24);
            this.ItemForALC_TYPE.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForALC_TYPE_NM
            // 
            this.ItemForALC_TYPE_NM.Control = this.ALC_TYPE_NMTextEdit;
            this.ItemForALC_TYPE_NM.Location = new System.Drawing.Point(296, 0);
            this.ItemForALC_TYPE_NM.Name = "ItemForALC_TYPE_NM";
            this.ItemForALC_TYPE_NM.Size = new System.Drawing.Size(378, 24);
            this.ItemForALC_TYPE_NM.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForLOAD_QTY
            // 
            this.ItemForLOAD_QTY.Control = this.LOAD_QTYTextEdit;
            this.ItemForLOAD_QTY.Location = new System.Drawing.Point(0, 24);
            this.ItemForLOAD_QTY.Name = "ItemForLOAD_QTY";
            this.ItemForLOAD_QTY.Size = new System.Drawing.Size(140, 34);
            this.ItemForLOAD_QTY.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForPRINT_COL
            // 
            this.ItemForPRINT_COL.Control = this.PRINT_COLTextEdit;
            this.ItemForPRINT_COL.Location = new System.Drawing.Point(140, 24);
            this.ItemForPRINT_COL.Name = "ItemForPRINT_COL";
            this.ItemForPRINT_COL.Size = new System.Drawing.Size(156, 34);
            this.ItemForPRINT_COL.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForPRINT_WAY
            // 
            this.ItemForPRINT_WAY.Control = this.PRINT_WAYLookUpEdit;
            this.ItemForPRINT_WAY.Location = new System.Drawing.Point(296, 24);
            this.ItemForPRINT_WAY.Name = "ItemForPRINT_WAY";
            this.ItemForPRINT_WAY.Size = new System.Drawing.Size(215, 34);
            this.ItemForPRINT_WAY.TextSize = new System.Drawing.Size(50, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(511, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(163, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dlvJisInfoJISModelBindingSource
            // 
            this.dlvJisInfoJISModelBindingSource.DataSource = typeof(BPack.Model.App.MD.DlvJisInfo.DlvJisInfoJISModel);
            // 
            // JISListEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.strapDataLayout1);
            this.Name = "JISListEditForm";
            this.Size = new System.Drawing.Size(694, 78);
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).EndInit();
            this.strapDataLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ALC_NOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALC_TYPE_NMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOAD_QTYTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRINT_COLTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRINT_WAYLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALC_TYPELookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_TYPE_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLOAD_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPRINT_COL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPRINT_WAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvJisInfoJISModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapDataLayout strapDataLayout1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit ALC_NOTextEdit;
        private System.Windows.Forms.BindingSource dlvJisInfoJISModelBindingSource;
        private DevExpress.XtraEditors.TextEdit ALC_TYPE_NMTextEdit;
        private DevExpress.XtraEditors.TextEdit LOAD_QTYTextEdit;
        private DevExpress.XtraEditors.TextEdit PRINT_COLTextEdit;
        private DevExpress.XtraEditors.LookUpEdit PRINT_WAYLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForALC_NO;
        private DevExpress.XtraLayout.LayoutControlItem ItemForALC_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem ItemForALC_TYPE_NM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLOAD_QTY;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPRINT_COL;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPRINT_WAY;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit ALC_TYPELookUpEdit;
    }
}
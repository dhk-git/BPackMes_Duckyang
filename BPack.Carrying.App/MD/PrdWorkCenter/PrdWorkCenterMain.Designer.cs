namespace BPack.Carrying.App.MD.PrdWorkCenter
{
    partial class PrdWorkCenterMain
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
            this.strapLayout1 = new BPack.Strap.Layout.StrapLayout();
            this.strapLookUpEdit2 = new BPack.Strap.EditControls.StrapLookUpEdit();
            this.strapLookUpEdit1 = new BPack.Strap.EditControls.StrapLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.strapLayout1)).BeginInit();
            this.strapLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strapLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            this.SuspendLayout();
            // 
            // strapLayout1
            // 
            this.strapLayout1.AllowCustomization = false;
            this.strapLayout1.Controls.Add(this.strapLookUpEdit2);
            this.strapLayout1.Controls.Add(this.strapLookUpEdit1);
            this.strapLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapLayout1.Name = "strapLayout1";
            this.strapLayout1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(596, 100, 803, 850);
            this.strapLayout1.Root = this.Root;
            this.strapLayout1.Size = new System.Drawing.Size(800, 450);
            this.strapLayout1.TabIndex = 0;
            this.strapLayout1.Text = "strapLayout1";
            // 
            // strapLookUpEdit2
            // 
            this.strapLookUpEdit2.Location = new System.Drawing.Point(49, 69);
            this.strapLookUpEdit2.MaximumSize = new System.Drawing.Size(150, 0);
            this.strapLookUpEdit2.Name = "strapLookUpEdit2";
            this.strapLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.strapLookUpEdit2.Size = new System.Drawing.Size(150, 20);
            this.strapLookUpEdit2.StyleController = this.strapLayout1;
            this.strapLookUpEdit2.TabIndex = 5;
            // 
            // strapLookUpEdit1
            // 
            this.strapLookUpEdit1.Location = new System.Drawing.Point(49, 45);
            this.strapLookUpEdit1.MaximumSize = new System.Drawing.Size(120, 0);
            this.strapLookUpEdit1.Name = "strapLookUpEdit1";
            this.strapLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.strapLookUpEdit1.Size = new System.Drawing.Size(120, 20);
            this.strapLookUpEdit1.StyleController = this.strapLayout1;
            this.strapLookUpEdit1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup3,
            this.splitterItem2,
            this.tabbedControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 93);
            this.layoutControlGroup1.Text = "조회조건";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.strapLookUpEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(756, 24);
            this.layoutControlItem1.Text = "회사";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(20, 14);
            this.layoutControlItem1.TextToControlDistance = 5;
            this.layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.strapLookUpEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(756, 24);
            this.layoutControlItem2.Text = "공장";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(20, 14);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 93);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(780, 145);
            this.layoutControlGroup3.Text = "작업장";
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(0, 238);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(780, 10);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 248);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup4;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(780, 182);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlGroup2});
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(756, 134);
            this.layoutControlGroup4.Text = "품목정보";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(756, 134);
            this.layoutControlGroup2.Text = "작업자";
            this.layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // PrdWorkCenterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapLayout1);
            this.Name = "PrdWorkCenterMain";
            this.Text = "PrdWorkCenterMain";
            ((System.ComponentModel.ISupportInitialize)(this.strapLayout1)).EndInit();
            this.strapLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.strapLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapLayout strapLayout1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private Strap.EditControls.StrapLookUpEdit strapLookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private Strap.EditControls.StrapLookUpEdit strapLookUpEdit2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
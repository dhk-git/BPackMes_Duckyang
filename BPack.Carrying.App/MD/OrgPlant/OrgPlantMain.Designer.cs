namespace BPack.Carrying.App.MD.OrgPlant
{
    partial class OrgPlantMain
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
            this.strapTextEdit2 = new BPack.Strap.EditControls.StrapTextEdit();
            this.strapTextEdit1 = new BPack.Strap.EditControls.StrapTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.strapLayout1)).BeginInit();
            this.strapLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strapTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            this.SuspendLayout();
            // 
            // strapLayout1
            // 
            this.strapLayout1.AllowCustomization = false;
            this.strapLayout1.Controls.Add(this.strapTextEdit2);
            this.strapLayout1.Controls.Add(this.strapTextEdit1);
            this.strapLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapLayout1.Name = "strapLayout1";
            this.strapLayout1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(852, 198, 650, 400);
            this.strapLayout1.Root = this.Root;
            this.strapLayout1.Size = new System.Drawing.Size(800, 450);
            this.strapLayout1.TabIndex = 0;
            this.strapLayout1.Text = "strapLayout1";
            // 
            // strapTextEdit2
            // 
            this.strapTextEdit2.Location = new System.Drawing.Point(214, 45);
            this.strapTextEdit2.MaximumSize = new System.Drawing.Size(130, 0);
            this.strapTextEdit2.MinimumSize = new System.Drawing.Size(100, 0);
            this.strapTextEdit2.Name = "strapTextEdit2";
            this.strapTextEdit2.Size = new System.Drawing.Size(130, 20);
            this.strapTextEdit2.StyleController = this.strapLayout1;
            this.strapTextEdit2.TabIndex = 5;
            // 
            // strapTextEdit1
            // 
            this.strapTextEdit1.Location = new System.Drawing.Point(67, 45);
            this.strapTextEdit1.MaximumSize = new System.Drawing.Size(130, 0);
            this.strapTextEdit1.MinimumSize = new System.Drawing.Size(100, 0);
            this.strapTextEdit1.Name = "strapTextEdit1";
            this.strapTextEdit1.Size = new System.Drawing.Size(100, 20);
            this.strapTextEdit1.StyleController = this.strapLayout1;
            this.strapTextEdit1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.splitterItem1,
            this.layoutControlGroup5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 69);
            this.layoutControlGroup1.Text = "조회조건";
            this.layoutControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(324, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(432, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.strapTextEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(147, 24);
            this.layoutControlItem1.Text = "공장코드";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.strapTextEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(147, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(177, 24);
            this.layoutControlItem2.Text = "공장명";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 69);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(205, 361);
            this.layoutControlGroup2.Text = "회사List";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Location = new System.Drawing.Point(215, 69);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(565, 199);
            this.layoutControlGroup3.Text = "공장List";
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(205, 69);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(10, 361);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "조업시간";
            this.layoutControlGroup5.Location = new System.Drawing.Point(215, 268);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(565, 162);
            this.layoutControlGroup5.Text = "조업시간";
            this.layoutControlGroup5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // OrgPlantMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapLayout1);
            this.Name = "OrgPlantMain";
            this.Text = "OrgPlantMain";
            ((System.ComponentModel.ISupportInitialize)(this.strapLayout1)).EndInit();
            this.strapLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.strapTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapLayout strapLayout1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private Strap.EditControls.StrapTextEdit strapTextEdit2;
        private Strap.EditControls.StrapTextEdit strapTextEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
    }
}
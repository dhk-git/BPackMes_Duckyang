namespace BPack.Carrying.App.MD.PrdShiftOper
{
    partial class PrdShiftOperMain
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.strapLookUpEdit1 = new BPack.Strap.EditControls.StrapLookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.strapLookUpEdit2 = new BPack.Strap.EditControls.StrapLookUpEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.strapLayout1)).BeginInit();
            this.strapLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
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
            this.strapLayout1.Root = this.Root;
            this.strapLayout1.Size = new System.Drawing.Size(800, 450);
            this.strapLayout1.TabIndex = 0;
            this.strapLayout1.Text = "strapLayout1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.splitterItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(311, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(445, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 67);
            this.layoutControlGroup1.Text = "조회조건";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 67);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(357, 363);
            this.layoutControlGroup2.Text = "근무조/근무시간";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Location = new System.Drawing.Point(362, 67);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(418, 363);
            this.layoutControlGroup3.Text = "근무조별 작업자";
            // 
            // strapLookUpEdit1
            // 
            this.strapLookUpEdit1.Location = new System.Drawing.Point(68, 43);
            this.strapLookUpEdit1.MaximumSize = new System.Drawing.Size(150, 0);
            this.strapLookUpEdit1.MinimumSize = new System.Drawing.Size(100, 0);
            this.strapLookUpEdit1.Name = "strapLookUpEdit1";
            this.strapLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.strapLookUpEdit1.Size = new System.Drawing.Size(115, 20);
            this.strapLookUpEdit1.StyleController = this.strapLayout1;
            this.strapLookUpEdit1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.strapLookUpEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(163, 24);
            this.layoutControlItem1.Text = "회사코드";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 14);
            this.layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // strapLookUpEdit2
            // 
            this.strapLookUpEdit2.Location = new System.Drawing.Point(231, 43);
            this.strapLookUpEdit2.MaximumSize = new System.Drawing.Size(150, 0);
            this.strapLookUpEdit2.MinimumSize = new System.Drawing.Size(100, 0);
            this.strapLookUpEdit2.Name = "strapLookUpEdit2";
            this.strapLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.strapLookUpEdit2.Size = new System.Drawing.Size(100, 20);
            this.strapLookUpEdit2.StyleController = this.strapLayout1;
            this.strapLookUpEdit2.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.strapLookUpEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(163, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(148, 24);
            this.layoutControlItem2.Text = "공장코드";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(40, 14);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(357, 67);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 363);
            // 
            // PrdShiftOperMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapLayout1);
            this.Name = "PrdShiftOperMain";
            this.Text = "PrdShiftOperMain";
            ((System.ComponentModel.ISupportInitialize)(this.strapLayout1)).EndInit();
            this.strapLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strapLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapLayout strapLayout1;
        private Strap.EditControls.StrapLookUpEdit strapLookUpEdit2;
        private Strap.EditControls.StrapLookUpEdit strapLookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}
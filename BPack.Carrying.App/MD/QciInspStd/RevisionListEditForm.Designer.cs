namespace BPack.Carrying.App.MD.QciInspStd
{
    partial class RevisionListEditForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.strapDataLayout1 = new BPack.Strap.Layout.StrapDataLayout();
            this.REVISIONTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ALL_FGLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SAMPLE_CNTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.VALID_FROM_DTDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForREVISION = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVALID_FROM_DT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForALL_FG = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSAMPLE_CNT = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.inspectionRevisionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileManagerButtonEdit1 = new BPack.CommonMes.Controls.FileManager.FileManagerButtonEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).BeginInit();
            this.strapDataLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.REVISIONTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALL_FGLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAMPLE_CNTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_FROM_DTDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_FROM_DTDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREVISION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVALID_FROM_DT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALL_FG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSAMPLE_CNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionRevisionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileManagerButtonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapDataLayout1
            // 
            this.SetBoundPropertyName(this.strapDataLayout1, "");
            this.strapDataLayout1.Controls.Add(this.fileManagerButtonEdit1);
            this.strapDataLayout1.Controls.Add(this.REVISIONTextEdit);
            this.strapDataLayout1.Controls.Add(this.ALL_FGLookUpEdit);
            this.strapDataLayout1.Controls.Add(this.SAMPLE_CNTTextEdit);
            this.strapDataLayout1.Controls.Add(this.VALID_FROM_DTDateEdit);
            this.strapDataLayout1.DataSource = this.inspectionRevisionModelBindingSource;
            this.strapDataLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapDataLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapDataLayout1.Name = "strapDataLayout1";
            this.strapDataLayout1.Root = this.Root;
            this.strapDataLayout1.Size = new System.Drawing.Size(777, 76);
            this.strapDataLayout1.TabIndex = 0;
            this.strapDataLayout1.Text = "strapDataLayout1";
            // 
            // REVISIONTextEdit
            // 
            this.SetBoundPropertyName(this.REVISIONTextEdit, "");
            this.REVISIONTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionRevisionModelBindingSource, "REVISION", true));
            this.REVISIONTextEdit.Location = new System.Drawing.Point(79, 12);
            this.REVISIONTextEdit.Name = "REVISIONTextEdit";
            this.REVISIONTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.REVISIONTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.REVISIONTextEdit.Properties.Mask.EditMask = "N0";
            this.REVISIONTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.REVISIONTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.REVISIONTextEdit.Properties.ReadOnly = true;
            this.REVISIONTextEdit.Size = new System.Drawing.Size(181, 20);
            this.REVISIONTextEdit.StyleController = this.strapDataLayout1;
            this.REVISIONTextEdit.TabIndex = 4;
            // 
            // ALL_FGLookUpEdit
            // 
            this.SetBoundPropertyName(this.ALL_FGLookUpEdit, "");
            this.ALL_FGLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionRevisionModelBindingSource, "ALL_FG", true));
            this.ALL_FGLookUpEdit.Location = new System.Drawing.Point(331, 12);
            this.ALL_FGLookUpEdit.Name = "ALL_FGLookUpEdit";
            this.ALL_FGLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ALL_FGLookUpEdit.Properties.NullText = "";
            this.ALL_FGLookUpEdit.Size = new System.Drawing.Size(181, 20);
            this.ALL_FGLookUpEdit.StyleController = this.strapDataLayout1;
            this.ALL_FGLookUpEdit.TabIndex = 5;
            this.ALL_FGLookUpEdit.EditValueChanged += new System.EventHandler(this.ALL_FGLookUpEdit_EditValueChanged);
            // 
            // SAMPLE_CNTTextEdit
            // 
            this.SetBoundPropertyName(this.SAMPLE_CNTTextEdit, "");
            this.SAMPLE_CNTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionRevisionModelBindingSource, "SAMPLE_CNT", true));
            this.SAMPLE_CNTTextEdit.Location = new System.Drawing.Point(583, 12);
            this.SAMPLE_CNTTextEdit.Name = "SAMPLE_CNTTextEdit";
            this.SAMPLE_CNTTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SAMPLE_CNTTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SAMPLE_CNTTextEdit.Properties.Mask.EditMask = "N0";
            this.SAMPLE_CNTTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SAMPLE_CNTTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SAMPLE_CNTTextEdit.Size = new System.Drawing.Size(182, 20);
            this.SAMPLE_CNTTextEdit.StyleController = this.strapDataLayout1;
            this.SAMPLE_CNTTextEdit.TabIndex = 6;
            // 
            // VALID_FROM_DTDateEdit
            // 
            this.SetBoundPropertyName(this.VALID_FROM_DTDateEdit, "");
            this.VALID_FROM_DTDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionRevisionModelBindingSource, "VALID_FROM_DT", true));
            this.VALID_FROM_DTDateEdit.EditValue = null;
            this.VALID_FROM_DTDateEdit.Location = new System.Drawing.Point(79, 36);
            this.VALID_FROM_DTDateEdit.Name = "VALID_FROM_DTDateEdit";
            this.VALID_FROM_DTDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VALID_FROM_DTDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VALID_FROM_DTDateEdit.Size = new System.Drawing.Size(181, 20);
            this.VALID_FROM_DTDateEdit.StyleController = this.strapDataLayout1;
            this.VALID_FROM_DTDateEdit.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(777, 76);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForREVISION,
            this.ItemForVALID_FROM_DT,
            this.ItemForALL_FG,
            this.ItemForSAMPLE_CNT,
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(757, 56);
            // 
            // ItemForREVISION
            // 
            this.ItemForREVISION.Control = this.REVISIONTextEdit;
            this.ItemForREVISION.Location = new System.Drawing.Point(0, 0);
            this.ItemForREVISION.Name = "ItemForREVISION";
            this.ItemForREVISION.Size = new System.Drawing.Size(252, 24);
            this.ItemForREVISION.TextSize = new System.Drawing.Size(64, 14);
            // 
            // ItemForVALID_FROM_DT
            // 
            this.ItemForVALID_FROM_DT.Control = this.VALID_FROM_DTDateEdit;
            this.ItemForVALID_FROM_DT.Location = new System.Drawing.Point(0, 24);
            this.ItemForVALID_FROM_DT.Name = "ItemForVALID_FROM_DT";
            this.ItemForVALID_FROM_DT.Size = new System.Drawing.Size(252, 32);
            this.ItemForVALID_FROM_DT.TextSize = new System.Drawing.Size(64, 14);
            // 
            // ItemForALL_FG
            // 
            this.ItemForALL_FG.Control = this.ALL_FGLookUpEdit;
            this.ItemForALL_FG.Location = new System.Drawing.Point(252, 0);
            this.ItemForALL_FG.Name = "ItemForALL_FG";
            this.ItemForALL_FG.Size = new System.Drawing.Size(252, 24);
            this.ItemForALL_FG.TextSize = new System.Drawing.Size(64, 14);
            // 
            // ItemForSAMPLE_CNT
            // 
            this.ItemForSAMPLE_CNT.Control = this.SAMPLE_CNTTextEdit;
            this.ItemForSAMPLE_CNT.Location = new System.Drawing.Point(504, 0);
            this.ItemForSAMPLE_CNT.Name = "ItemForSAMPLE_CNT";
            this.ItemForSAMPLE_CNT.Size = new System.Drawing.Size(253, 24);
            this.ItemForSAMPLE_CNT.TextSize = new System.Drawing.Size(64, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(504, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(253, 32);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // inspectionRevisionModelBindingSource
            // 
            this.inspectionRevisionModelBindingSource.DataSource = typeof(BPack.Model.App.MD.QciInspStd.InspectionRevisionModel);
            // 
            // fileManagerButtonEdit1
            // 
            this.SetBoundPropertyName(this.fileManagerButtonEdit1, "");
            this.fileManagerButtonEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionRevisionModelBindingSource, "FILE_GROUP_ID", true));
            this.fileManagerButtonEdit1.Location = new System.Drawing.Point(331, 36);
            this.fileManagerButtonEdit1.Name = "fileManagerButtonEdit1";
            this.fileManagerButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fileManagerButtonEdit1.Size = new System.Drawing.Size(181, 20);
            this.fileManagerButtonEdit1.StyleController = this.strapDataLayout1;
            this.fileManagerButtonEdit1.TabIndex = 9;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.fileManagerButtonEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(252, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(252, 32);
            this.layoutControlItem1.Text = "참조파일";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 14);
            // 
            // RevisionListEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.strapDataLayout1);
            this.Name = "RevisionListEditForm";
            this.Size = new System.Drawing.Size(777, 76);
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).EndInit();
            this.strapDataLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.REVISIONTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALL_FGLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAMPLE_CNTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_FROM_DTDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_FROM_DTDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREVISION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVALID_FROM_DT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALL_FG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSAMPLE_CNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionRevisionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileManagerButtonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapDataLayout strapDataLayout1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource inspectionRevisionModelBindingSource;
        private DevExpress.XtraEditors.TextEdit REVISIONTextEdit;
        private DevExpress.XtraEditors.LookUpEdit ALL_FGLookUpEdit;
        private DevExpress.XtraEditors.TextEdit SAMPLE_CNTTextEdit;
        private DevExpress.XtraEditors.DateEdit VALID_FROM_DTDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForREVISION;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVALID_FROM_DT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForALL_FG;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSAMPLE_CNT;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private CommonMes.Controls.FileManager.FileManagerButtonEdit fileManagerButtonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}

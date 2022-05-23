namespace BPack.Carrying.App.MD.OrgUser
{
    partial class OrgUserEditForm
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.USER_IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USER_PWTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.USER_NMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MODIFY_DTTMDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.MODIFY_USER_IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.REMARKMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.DEL_FGImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUSER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMODIFY_DTTM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMODIFY_USER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForREMARK = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUSER_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUSER_PW = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDEL_FG = new DevExpress.XtraLayout.LayoutControlItem();
            this.DEPT_CDLookUpEdit = new BPack.Strap.EditControls.StrapLookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USER_IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USER_PWTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USER_NMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_USER_IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REMARKMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEL_FGImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_DTTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_USER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREMARK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSER_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSER_PW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDEL_FG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEPT_CDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.SetBoundPropertyName(this.dataLayoutControl1, "");
            this.dataLayoutControl1.Controls.Add(this.DEPT_CDLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.USER_IDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.USER_PWTextEdit);
            this.dataLayoutControl1.Controls.Add(this.USER_NMTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MODIFY_DTTMDateEdit);
            this.dataLayoutControl1.Controls.Add(this.MODIFY_USER_IDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.REMARKMemoEdit);
            this.dataLayoutControl1.Controls.Add(this.DEL_FGImageComboBoxEdit);
            this.dataLayoutControl1.DataSource = this.userModelBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(620, 188);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // USER_IDTextEdit
            // 
            this.SetBoundPropertyName(this.USER_IDTextEdit, "");
            this.USER_IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "USER_ID", true));
            this.USER_IDTextEdit.Location = new System.Drawing.Point(57, 12);
            this.USER_IDTextEdit.Name = "USER_IDTextEdit";
            this.USER_IDTextEdit.Size = new System.Drawing.Size(251, 20);
            this.USER_IDTextEdit.StyleController = this.dataLayoutControl1;
            this.USER_IDTextEdit.TabIndex = 4;
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(BPack.Model.App.MD.OrgUser.UserModel);
            // 
            // USER_PWTextEdit
            // 
            this.SetBoundPropertyName(this.USER_PWTextEdit, "");
            this.USER_PWTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "USER_PW", true));
            this.USER_PWTextEdit.Location = new System.Drawing.Point(57, 36);
            this.USER_PWTextEdit.Name = "USER_PWTextEdit";
            this.USER_PWTextEdit.Size = new System.Drawing.Size(251, 20);
            this.USER_PWTextEdit.StyleController = this.dataLayoutControl1;
            this.USER_PWTextEdit.TabIndex = 5;
            // 
            // USER_NMTextEdit
            // 
            this.SetBoundPropertyName(this.USER_NMTextEdit, "");
            this.USER_NMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "USER_NM", true));
            this.USER_NMTextEdit.Location = new System.Drawing.Point(357, 12);
            this.USER_NMTextEdit.Name = "USER_NMTextEdit";
            this.USER_NMTextEdit.Size = new System.Drawing.Size(251, 20);
            this.USER_NMTextEdit.StyleController = this.dataLayoutControl1;
            this.USER_NMTextEdit.TabIndex = 6;
            // 
            // MODIFY_DTTMDateEdit
            // 
            this.SetBoundPropertyName(this.MODIFY_DTTMDateEdit, "");
            this.MODIFY_DTTMDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "MODIFY_DTTM", true));
            this.MODIFY_DTTMDateEdit.EditValue = null;
            this.MODIFY_DTTMDateEdit.Location = new System.Drawing.Point(57, 84);
            this.MODIFY_DTTMDateEdit.Name = "MODIFY_DTTMDateEdit";
            this.MODIFY_DTTMDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.MODIFY_DTTMDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MODIFY_DTTMDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MODIFY_DTTMDateEdit.Properties.DisplayFormat.FormatString = "{0:yyyy-MM-dd HH:mm}";
            this.MODIFY_DTTMDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.MODIFY_DTTMDateEdit.Properties.ReadOnly = true;
            this.MODIFY_DTTMDateEdit.Size = new System.Drawing.Size(251, 20);
            this.MODIFY_DTTMDateEdit.StyleController = this.dataLayoutControl1;
            this.MODIFY_DTTMDateEdit.TabIndex = 8;
            // 
            // MODIFY_USER_IDTextEdit
            // 
            this.SetBoundPropertyName(this.MODIFY_USER_IDTextEdit, "");
            this.MODIFY_USER_IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "MODIFY_USER_ID", true));
            this.MODIFY_USER_IDTextEdit.Location = new System.Drawing.Point(357, 84);
            this.MODIFY_USER_IDTextEdit.Name = "MODIFY_USER_IDTextEdit";
            this.MODIFY_USER_IDTextEdit.Properties.ReadOnly = true;
            this.MODIFY_USER_IDTextEdit.Size = new System.Drawing.Size(251, 20);
            this.MODIFY_USER_IDTextEdit.StyleController = this.dataLayoutControl1;
            this.MODIFY_USER_IDTextEdit.TabIndex = 9;
            // 
            // REMARKMemoEdit
            // 
            this.SetBoundPropertyName(this.REMARKMemoEdit, "");
            this.REMARKMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "REMARK", true));
            this.REMARKMemoEdit.Location = new System.Drawing.Point(57, 108);
            this.REMARKMemoEdit.Name = "REMARKMemoEdit";
            this.REMARKMemoEdit.Size = new System.Drawing.Size(551, 68);
            this.REMARKMemoEdit.StyleController = this.dataLayoutControl1;
            this.REMARKMemoEdit.TabIndex = 10;
            // 
            // DEL_FGImageComboBoxEdit
            // 
            this.SetBoundPropertyName(this.DEL_FGImageComboBoxEdit, "");
            this.DEL_FGImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "DEL_FG", true));
            this.DEL_FGImageComboBoxEdit.Location = new System.Drawing.Point(357, 36);
            this.DEL_FGImageComboBoxEdit.Name = "DEL_FGImageComboBoxEdit";
            this.DEL_FGImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEL_FGImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Y", "Y", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("N", "N", -1)});
            this.DEL_FGImageComboBoxEdit.Size = new System.Drawing.Size(251, 20);
            this.DEL_FGImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.DEL_FGImageComboBoxEdit.TabIndex = 17;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(620, 188);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUSER_ID,
            this.ItemForMODIFY_DTTM,
            this.ItemForMODIFY_USER_ID,
            this.ItemForREMARK,
            this.ItemForUSER_NM,
            this.ItemForUSER_PW,
            this.ItemForDEL_FG,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(600, 168);
            // 
            // ItemForUSER_ID
            // 
            this.ItemForUSER_ID.Control = this.USER_IDTextEdit;
            this.ItemForUSER_ID.Location = new System.Drawing.Point(0, 0);
            this.ItemForUSER_ID.Name = "ItemForUSER_ID";
            this.ItemForUSER_ID.Size = new System.Drawing.Size(300, 24);
            this.ItemForUSER_ID.TextSize = new System.Drawing.Size(42, 14);
            // 
            // ItemForMODIFY_DTTM
            // 
            this.ItemForMODIFY_DTTM.Control = this.MODIFY_DTTMDateEdit;
            this.ItemForMODIFY_DTTM.Location = new System.Drawing.Point(0, 72);
            this.ItemForMODIFY_DTTM.Name = "ItemForMODIFY_DTTM";
            this.ItemForMODIFY_DTTM.Size = new System.Drawing.Size(300, 24);
            this.ItemForMODIFY_DTTM.TextSize = new System.Drawing.Size(42, 14);
            // 
            // ItemForMODIFY_USER_ID
            // 
            this.ItemForMODIFY_USER_ID.Control = this.MODIFY_USER_IDTextEdit;
            this.ItemForMODIFY_USER_ID.Location = new System.Drawing.Point(300, 72);
            this.ItemForMODIFY_USER_ID.Name = "ItemForMODIFY_USER_ID";
            this.ItemForMODIFY_USER_ID.Size = new System.Drawing.Size(300, 24);
            this.ItemForMODIFY_USER_ID.TextSize = new System.Drawing.Size(42, 14);
            // 
            // ItemForREMARK
            // 
            this.ItemForREMARK.Control = this.REMARKMemoEdit;
            this.ItemForREMARK.Location = new System.Drawing.Point(0, 96);
            this.ItemForREMARK.Name = "ItemForREMARK";
            this.ItemForREMARK.Size = new System.Drawing.Size(600, 72);
            this.ItemForREMARK.TextSize = new System.Drawing.Size(42, 14);
            // 
            // ItemForUSER_NM
            // 
            this.ItemForUSER_NM.Control = this.USER_NMTextEdit;
            this.ItemForUSER_NM.Location = new System.Drawing.Point(300, 0);
            this.ItemForUSER_NM.Name = "ItemForUSER_NM";
            this.ItemForUSER_NM.Size = new System.Drawing.Size(300, 24);
            this.ItemForUSER_NM.TextSize = new System.Drawing.Size(42, 14);
            // 
            // ItemForUSER_PW
            // 
            this.ItemForUSER_PW.Control = this.USER_PWTextEdit;
            this.ItemForUSER_PW.Location = new System.Drawing.Point(0, 24);
            this.ItemForUSER_PW.Name = "ItemForUSER_PW";
            this.ItemForUSER_PW.Size = new System.Drawing.Size(300, 24);
            this.ItemForUSER_PW.TextSize = new System.Drawing.Size(42, 14);
            // 
            // ItemForDEL_FG
            // 
            this.ItemForDEL_FG.Control = this.DEL_FGImageComboBoxEdit;
            this.ItemForDEL_FG.Location = new System.Drawing.Point(300, 24);
            this.ItemForDEL_FG.Name = "ItemForDEL_FG";
            this.ItemForDEL_FG.Size = new System.Drawing.Size(300, 24);
            this.ItemForDEL_FG.TextSize = new System.Drawing.Size(42, 14);
            // 
            // DEPT_CDLookUpEdit
            // 
            this.SetBoundPropertyName(this.DEPT_CDLookUpEdit, "");
            this.DEPT_CDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userModelBindingSource, "DEPT_CD", true));
            this.DEPT_CDLookUpEdit.Location = new System.Drawing.Point(57, 60);
            this.DEPT_CDLookUpEdit.Name = "DEPT_CDLookUpEdit";
            this.DEPT_CDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEPT_CDLookUpEdit.Size = new System.Drawing.Size(551, 20);
            this.DEPT_CDLookUpEdit.StyleController = this.dataLayoutControl1;
            this.DEPT_CDLookUpEdit.TabIndex = 18;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.DEPT_CDLookUpEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(600, 24);
            this.layoutControlItem1.Text = "부서";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(42, 14);
            // 
            // OrgUserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "OrgUserEditForm";
            this.Size = new System.Drawing.Size(620, 188);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.USER_IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USER_PWTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USER_NMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_USER_IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REMARKMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEL_FGImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_DTTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_USER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREMARK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSER_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUSER_PW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDEL_FG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEPT_CDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit USER_IDTextEdit;
        private System.Windows.Forms.BindingSource userModelBindingSource;
        private DevExpress.XtraEditors.TextEdit USER_PWTextEdit;
        private DevExpress.XtraEditors.TextEdit USER_NMTextEdit;
        private DevExpress.XtraEditors.DateEdit MODIFY_DTTMDateEdit;
        private DevExpress.XtraEditors.TextEdit MODIFY_USER_IDTextEdit;
        private DevExpress.XtraEditors.MemoEdit REMARKMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUSER_ID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMODIFY_DTTM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMODIFY_USER_ID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForREMARK;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUSER_NM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUSER_PW;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDEL_FG;
        private DevExpress.XtraEditors.ImageComboBoxEdit DEL_FGImageComboBoxEdit;
        private Strap.EditControls.StrapLookUpEdit DEPT_CDLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}

namespace BPack.Carrying.App.MD.QciInspStd
{
    partial class CheckListEditForm
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
            this.INSP_DVLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.inspectionCheckListModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOWER_LIMITTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BASE_VALUETextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UPPER_LIMITTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.INSP_METHODLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.INSP_VAL_TYPELookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.UNITLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.INSP_IDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForINSP_DV = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForINSP_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBASE_VALUE = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUPPER_LIMIT = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForLOWER_LIMIT = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForINSP_METHOD = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForINSP_VAL_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUNIT = new DevExpress.XtraLayout.LayoutControlItem();
            this.fileManagerButtonEdit1 = new BPack.CommonMes.Controls.FileManager.FileManagerButtonEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).BeginInit();
            this.strapDataLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_DVLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionCheckListModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOWER_LIMITTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BASE_VALUETextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPPER_LIMITTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_METHODLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_VAL_TYPELookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNITLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_IDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_DV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBASE_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUPPER_LIMIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLOWER_LIMIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_METHOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_VAL_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUNIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileManagerButtonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapDataLayout1
            // 
            this.SetBoundPropertyName(this.strapDataLayout1, "");
            this.strapDataLayout1.Controls.Add(this.fileManagerButtonEdit1);
            this.strapDataLayout1.Controls.Add(this.INSP_DVLookUpEdit);
            this.strapDataLayout1.Controls.Add(this.LOWER_LIMITTextEdit);
            this.strapDataLayout1.Controls.Add(this.BASE_VALUETextEdit);
            this.strapDataLayout1.Controls.Add(this.UPPER_LIMITTextEdit);
            this.strapDataLayout1.Controls.Add(this.INSP_METHODLookUpEdit);
            this.strapDataLayout1.Controls.Add(this.INSP_VAL_TYPELookUpEdit);
            this.strapDataLayout1.Controls.Add(this.UNITLookUpEdit);
            this.strapDataLayout1.Controls.Add(this.INSP_IDLookUpEdit);
            this.strapDataLayout1.DataSource = this.inspectionCheckListModelBindingSource;
            this.strapDataLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapDataLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapDataLayout1.Name = "strapDataLayout1";
            this.strapDataLayout1.Root = this.Root;
            this.strapDataLayout1.Size = new System.Drawing.Size(641, 119);
            this.strapDataLayout1.TabIndex = 0;
            this.strapDataLayout1.Text = "strapDataLayout1";
            // 
            // INSP_DVLookUpEdit
            // 
            this.SetBoundPropertyName(this.INSP_DVLookUpEdit, "");
            this.INSP_DVLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionCheckListModelBindingSource, "INSP_DV", true));
            this.INSP_DVLookUpEdit.Location = new System.Drawing.Point(65, 12);
            this.INSP_DVLookUpEdit.Name = "INSP_DVLookUpEdit";
            this.INSP_DVLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.INSP_DVLookUpEdit.Properties.NullText = "";
            this.INSP_DVLookUpEdit.Size = new System.Drawing.Size(149, 20);
            this.INSP_DVLookUpEdit.StyleController = this.strapDataLayout1;
            this.INSP_DVLookUpEdit.TabIndex = 4;
            this.INSP_DVLookUpEdit.EditValueChanged += new System.EventHandler(this.INSP_DVLookUpEdit_EditValueChanged);
            // 
            // inspectionCheckListModelBindingSource
            // 
            this.inspectionCheckListModelBindingSource.DataSource = typeof(BPack.Model.App.MD.QciInspStd.InspectionCheckListModel);
            // 
            // LOWER_LIMITTextEdit
            // 
            this.SetBoundPropertyName(this.LOWER_LIMITTextEdit, "");
            this.LOWER_LIMITTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionCheckListModelBindingSource, "LOWER_LIMIT", true));
            this.LOWER_LIMITTextEdit.Location = new System.Drawing.Point(65, 60);
            this.LOWER_LIMITTextEdit.Name = "LOWER_LIMITTextEdit";
            this.LOWER_LIMITTextEdit.Size = new System.Drawing.Size(149, 20);
            this.LOWER_LIMITTextEdit.StyleController = this.strapDataLayout1;
            this.LOWER_LIMITTextEdit.TabIndex = 6;
            // 
            // BASE_VALUETextEdit
            // 
            this.SetBoundPropertyName(this.BASE_VALUETextEdit, "");
            this.BASE_VALUETextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionCheckListModelBindingSource, "BASE_VALUE", true));
            this.BASE_VALUETextEdit.Location = new System.Drawing.Point(271, 60);
            this.BASE_VALUETextEdit.Name = "BASE_VALUETextEdit";
            this.BASE_VALUETextEdit.Size = new System.Drawing.Size(151, 20);
            this.BASE_VALUETextEdit.StyleController = this.strapDataLayout1;
            this.BASE_VALUETextEdit.TabIndex = 7;
            // 
            // UPPER_LIMITTextEdit
            // 
            this.SetBoundPropertyName(this.UPPER_LIMITTextEdit, "");
            this.UPPER_LIMITTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionCheckListModelBindingSource, "UPPER_LIMIT", true));
            this.UPPER_LIMITTextEdit.Location = new System.Drawing.Point(479, 60);
            this.UPPER_LIMITTextEdit.Name = "UPPER_LIMITTextEdit";
            this.UPPER_LIMITTextEdit.Size = new System.Drawing.Size(150, 20);
            this.UPPER_LIMITTextEdit.StyleController = this.strapDataLayout1;
            this.UPPER_LIMITTextEdit.TabIndex = 8;
            // 
            // INSP_METHODLookUpEdit
            // 
            this.SetBoundPropertyName(this.INSP_METHODLookUpEdit, "");
            this.INSP_METHODLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionCheckListModelBindingSource, "INSP_METHOD", true));
            this.INSP_METHODLookUpEdit.Location = new System.Drawing.Point(65, 36);
            this.INSP_METHODLookUpEdit.Name = "INSP_METHODLookUpEdit";
            this.INSP_METHODLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.INSP_METHODLookUpEdit.Properties.NullText = "";
            this.INSP_METHODLookUpEdit.Properties.ReadOnly = true;
            this.INSP_METHODLookUpEdit.Size = new System.Drawing.Size(149, 20);
            this.INSP_METHODLookUpEdit.StyleController = this.strapDataLayout1;
            this.INSP_METHODLookUpEdit.TabIndex = 9;
            // 
            // INSP_VAL_TYPELookUpEdit
            // 
            this.SetBoundPropertyName(this.INSP_VAL_TYPELookUpEdit, "");
            this.INSP_VAL_TYPELookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionCheckListModelBindingSource, "INSP_VAL_TYPE", true));
            this.INSP_VAL_TYPELookUpEdit.Location = new System.Drawing.Point(271, 36);
            this.INSP_VAL_TYPELookUpEdit.Name = "INSP_VAL_TYPELookUpEdit";
            this.INSP_VAL_TYPELookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.INSP_VAL_TYPELookUpEdit.Properties.NullText = "";
            this.INSP_VAL_TYPELookUpEdit.Properties.ReadOnly = true;
            this.INSP_VAL_TYPELookUpEdit.Size = new System.Drawing.Size(151, 20);
            this.INSP_VAL_TYPELookUpEdit.StyleController = this.strapDataLayout1;
            this.INSP_VAL_TYPELookUpEdit.TabIndex = 10;
            // 
            // UNITLookUpEdit
            // 
            this.SetBoundPropertyName(this.UNITLookUpEdit, "");
            this.UNITLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionCheckListModelBindingSource, "UNIT", true));
            this.UNITLookUpEdit.Location = new System.Drawing.Point(479, 36);
            this.UNITLookUpEdit.Name = "UNITLookUpEdit";
            this.UNITLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UNITLookUpEdit.Properties.NullText = "";
            this.UNITLookUpEdit.Properties.ReadOnly = true;
            this.UNITLookUpEdit.Size = new System.Drawing.Size(150, 20);
            this.UNITLookUpEdit.StyleController = this.strapDataLayout1;
            this.UNITLookUpEdit.TabIndex = 11;
            // 
            // INSP_IDLookUpEdit
            // 
            this.SetBoundPropertyName(this.INSP_IDLookUpEdit, "");
            this.INSP_IDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionCheckListModelBindingSource, "INSP_ID", true));
            this.INSP_IDLookUpEdit.Location = new System.Drawing.Point(271, 12);
            this.INSP_IDLookUpEdit.Name = "INSP_IDLookUpEdit";
            this.INSP_IDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.INSP_IDLookUpEdit.Properties.NullText = "";
            this.INSP_IDLookUpEdit.Size = new System.Drawing.Size(151, 20);
            this.INSP_IDLookUpEdit.StyleController = this.strapDataLayout1;
            this.INSP_IDLookUpEdit.TabIndex = 13;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(641, 119);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForINSP_DV,
            this.ItemForINSP_ID,
            this.ItemForBASE_VALUE,
            this.ItemForUPPER_LIMIT,
            this.emptySpaceItem1,
            this.ItemForLOWER_LIMIT,
            this.emptySpaceItem3,
            this.ItemForINSP_METHOD,
            this.ItemForINSP_VAL_TYPE,
            this.ItemForUNIT,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(621, 99);
            // 
            // ItemForINSP_DV
            // 
            this.ItemForINSP_DV.Control = this.INSP_DVLookUpEdit;
            this.ItemForINSP_DV.Location = new System.Drawing.Point(0, 0);
            this.ItemForINSP_DV.Name = "ItemForINSP_DV";
            this.ItemForINSP_DV.Size = new System.Drawing.Size(206, 24);
            this.ItemForINSP_DV.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForINSP_ID
            // 
            this.ItemForINSP_ID.Control = this.INSP_IDLookUpEdit;
            this.ItemForINSP_ID.Location = new System.Drawing.Point(206, 0);
            this.ItemForINSP_ID.Name = "ItemForINSP_ID";
            this.ItemForINSP_ID.Size = new System.Drawing.Size(208, 24);
            this.ItemForINSP_ID.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForBASE_VALUE
            // 
            this.ItemForBASE_VALUE.Control = this.BASE_VALUETextEdit;
            this.ItemForBASE_VALUE.Location = new System.Drawing.Point(206, 48);
            this.ItemForBASE_VALUE.Name = "ItemForBASE_VALUE";
            this.ItemForBASE_VALUE.Size = new System.Drawing.Size(208, 24);
            this.ItemForBASE_VALUE.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForUPPER_LIMIT
            // 
            this.ItemForUPPER_LIMIT.Control = this.UPPER_LIMITTextEdit;
            this.ItemForUPPER_LIMIT.Location = new System.Drawing.Point(414, 48);
            this.ItemForUPPER_LIMIT.Name = "ItemForUPPER_LIMIT";
            this.ItemForUPPER_LIMIT.Size = new System.Drawing.Size(207, 24);
            this.ItemForUPPER_LIMIT.TextSize = new System.Drawing.Size(50, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(414, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(207, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForLOWER_LIMIT
            // 
            this.ItemForLOWER_LIMIT.Control = this.LOWER_LIMITTextEdit;
            this.ItemForLOWER_LIMIT.Location = new System.Drawing.Point(0, 48);
            this.ItemForLOWER_LIMIT.Name = "ItemForLOWER_LIMIT";
            this.ItemForLOWER_LIMIT.Size = new System.Drawing.Size(206, 24);
            this.ItemForLOWER_LIMIT.TextSize = new System.Drawing.Size(50, 14);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(207, 72);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(414, 27);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForINSP_METHOD
            // 
            this.ItemForINSP_METHOD.Control = this.INSP_METHODLookUpEdit;
            this.ItemForINSP_METHOD.Location = new System.Drawing.Point(0, 24);
            this.ItemForINSP_METHOD.Name = "ItemForINSP_METHOD";
            this.ItemForINSP_METHOD.Size = new System.Drawing.Size(206, 24);
            this.ItemForINSP_METHOD.Text = "검사방법";
            this.ItemForINSP_METHOD.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForINSP_VAL_TYPE
            // 
            this.ItemForINSP_VAL_TYPE.Control = this.INSP_VAL_TYPELookUpEdit;
            this.ItemForINSP_VAL_TYPE.Location = new System.Drawing.Point(206, 24);
            this.ItemForINSP_VAL_TYPE.Name = "ItemForINSP_VAL_TYPE";
            this.ItemForINSP_VAL_TYPE.Size = new System.Drawing.Size(208, 24);
            this.ItemForINSP_VAL_TYPE.Text = "측정값유형";
            this.ItemForINSP_VAL_TYPE.TextSize = new System.Drawing.Size(50, 14);
            // 
            // ItemForUNIT
            // 
            this.ItemForUNIT.Control = this.UNITLookUpEdit;
            this.ItemForUNIT.Location = new System.Drawing.Point(414, 24);
            this.ItemForUNIT.Name = "ItemForUNIT";
            this.ItemForUNIT.Size = new System.Drawing.Size(207, 24);
            this.ItemForUNIT.Text = "단위";
            this.ItemForUNIT.TextSize = new System.Drawing.Size(50, 14);
            // 
            // fileManagerButtonEdit1
            // 
            this.SetBoundPropertyName(this.fileManagerButtonEdit1, "");
            this.fileManagerButtonEdit1.Location = new System.Drawing.Point(65, 84);
            this.fileManagerButtonEdit1.Name = "fileManagerButtonEdit1";
            this.fileManagerButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fileManagerButtonEdit1.Size = new System.Drawing.Size(150, 20);
            this.fileManagerButtonEdit1.StyleController = this.strapDataLayout1;
            this.fileManagerButtonEdit1.TabIndex = 14;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.fileManagerButtonEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(207, 27);
            this.layoutControlItem1.Text = "참조파일";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 14);
            // 
            // CheckListEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.strapDataLayout1);
            this.Name = "CheckListEditForm";
            this.Size = new System.Drawing.Size(641, 119);
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).EndInit();
            this.strapDataLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.INSP_DVLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionCheckListModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOWER_LIMITTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BASE_VALUETextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPPER_LIMITTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_METHODLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_VAL_TYPELookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNITLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_IDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_DV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBASE_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUPPER_LIMIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLOWER_LIMIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_METHOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_VAL_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUNIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileManagerButtonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapDataLayout strapDataLayout1;
        private DevExpress.XtraEditors.LookUpEdit INSP_DVLookUpEdit;
        private System.Windows.Forms.BindingSource inspectionCheckListModelBindingSource;
        private DevExpress.XtraEditors.TextEdit LOWER_LIMITTextEdit;
        private DevExpress.XtraEditors.TextEdit BASE_VALUETextEdit;
        private DevExpress.XtraEditors.TextEdit UPPER_LIMITTextEdit;
        private DevExpress.XtraEditors.LookUpEdit INSP_METHODLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit INSP_VAL_TYPELookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit UNITLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForINSP_DV;
        private DevExpress.XtraLayout.LayoutControlItem ItemForINSP_ID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLOWER_LIMIT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBASE_VALUE;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUPPER_LIMIT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForINSP_METHOD;
        private DevExpress.XtraLayout.LayoutControlItem ItemForINSP_VAL_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUNIT;
        private DevExpress.XtraEditors.LookUpEdit INSP_IDLookUpEdit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private CommonMes.Controls.FileManager.FileManagerButtonEdit fileManagerButtonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}

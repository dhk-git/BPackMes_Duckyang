using BPack.Strap.EditControls;

namespace BPack.Carrying.App.MD.QciInspStd
{
    partial class StandardListEditForm
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
            this.ALC_CDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.INSP_STD_IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MAX_REVISIONTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.INSP_TYPELookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ItemForALC_CD = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForINSP_STD_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMAX_REVISION = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForINSP_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.inspectionStandardModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ITEM_CDButtonEdit = new BPack.CommonMes.Controls.ItemMaster.ItemMasterButtonEdit();
            this.ItemForITEM_CD = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALC_CDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_STD_IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_REVISIONTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_TYPELookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_CD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_STD_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMAX_REVISION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionStandardModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_CDButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_CD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.SetBoundPropertyName(this.dataLayoutControl1, "");
            this.dataLayoutControl1.Controls.Add(this.ALC_CDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.INSP_STD_IDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.MAX_REVISIONTextEdit);
            this.dataLayoutControl1.Controls.Add(this.INSP_TYPELookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.ITEM_CDButtonEdit);
            this.dataLayoutControl1.DataSource = this.inspectionStandardModelBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForALC_CD,
            this.ItemForINSP_STD_ID,
            this.ItemForMAX_REVISION});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(536, 44);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ALC_CDTextEdit
            // 
            this.SetBoundPropertyName(this.ALC_CDTextEdit, "");
            this.ALC_CDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionStandardModelBindingSource, "ALC_CD", true));
            this.ALC_CDTextEdit.Location = new System.Drawing.Point(67, 36);
            this.ALC_CDTextEdit.Name = "ALC_CDTextEdit";
            this.ALC_CDTextEdit.Properties.ReadOnly = true;
            this.ALC_CDTextEdit.Size = new System.Drawing.Size(199, 20);
            this.ALC_CDTextEdit.StyleController = this.dataLayoutControl1;
            this.ALC_CDTextEdit.TabIndex = 6;
            // 
            // INSP_STD_IDTextEdit
            // 
            this.SetBoundPropertyName(this.INSP_STD_IDTextEdit, "");
            this.INSP_STD_IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionStandardModelBindingSource, "INSP_STD_ID", true));
            this.INSP_STD_IDTextEdit.Location = new System.Drawing.Point(325, 36);
            this.INSP_STD_IDTextEdit.Name = "INSP_STD_IDTextEdit";
            this.INSP_STD_IDTextEdit.Properties.ReadOnly = true;
            this.INSP_STD_IDTextEdit.Size = new System.Drawing.Size(199, 20);
            this.INSP_STD_IDTextEdit.StyleController = this.dataLayoutControl1;
            this.INSP_STD_IDTextEdit.TabIndex = 7;
            // 
            // MAX_REVISIONTextEdit
            // 
            this.SetBoundPropertyName(this.MAX_REVISIONTextEdit, "");
            this.MAX_REVISIONTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionStandardModelBindingSource, "MAX_REVISION", true));
            this.MAX_REVISIONTextEdit.Location = new System.Drawing.Point(67, 60);
            this.MAX_REVISIONTextEdit.Name = "MAX_REVISIONTextEdit";
            this.MAX_REVISIONTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MAX_REVISIONTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MAX_REVISIONTextEdit.Properties.Mask.EditMask = "N0";
            this.MAX_REVISIONTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.MAX_REVISIONTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.MAX_REVISIONTextEdit.Properties.ReadOnly = true;
            this.MAX_REVISIONTextEdit.Size = new System.Drawing.Size(199, 20);
            this.MAX_REVISIONTextEdit.StyleController = this.dataLayoutControl1;
            this.MAX_REVISIONTextEdit.TabIndex = 8;
            // 
            // INSP_TYPELookUpEdit
            // 
            this.SetBoundPropertyName(this.INSP_TYPELookUpEdit, "");
            this.INSP_TYPELookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.inspectionStandardModelBindingSource, "INSP_TYPE", true));
            this.INSP_TYPELookUpEdit.Location = new System.Drawing.Point(55, 12);
            this.INSP_TYPELookUpEdit.Name = "INSP_TYPELookUpEdit";
            this.INSP_TYPELookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.INSP_TYPELookUpEdit.Properties.NullText = "";
            this.INSP_TYPELookUpEdit.Size = new System.Drawing.Size(125, 20);
            this.INSP_TYPELookUpEdit.StyleController = this.dataLayoutControl1;
            this.INSP_TYPELookUpEdit.TabIndex = 9;
            // 
            // ItemForALC_CD
            // 
            this.ItemForALC_CD.Control = this.ALC_CDTextEdit;
            this.ItemForALC_CD.Location = new System.Drawing.Point(0, 24);
            this.ItemForALC_CD.Name = "ItemForALC_CD";
            this.ItemForALC_CD.Size = new System.Drawing.Size(258, 24);
            this.ItemForALC_CD.TextSize = new System.Drawing.Size(52, 14);
            // 
            // ItemForINSP_STD_ID
            // 
            this.ItemForINSP_STD_ID.Control = this.INSP_STD_IDTextEdit;
            this.ItemForINSP_STD_ID.Location = new System.Drawing.Point(0, 24);
            this.ItemForINSP_STD_ID.Name = "ItemForINSP_STD_ID";
            this.ItemForINSP_STD_ID.Size = new System.Drawing.Size(516, 24);
            this.ItemForINSP_STD_ID.TextSize = new System.Drawing.Size(52, 14);
            // 
            // ItemForMAX_REVISION
            // 
            this.ItemForMAX_REVISION.Control = this.MAX_REVISIONTextEdit;
            this.ItemForMAX_REVISION.Location = new System.Drawing.Point(0, 24);
            this.ItemForMAX_REVISION.Name = "ItemForMAX_REVISION";
            this.ItemForMAX_REVISION.Size = new System.Drawing.Size(258, 50);
            this.ItemForMAX_REVISION.TextSize = new System.Drawing.Size(52, 14);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(536, 44);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForINSP_TYPE,
            this.ItemForITEM_CD,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(516, 24);
            // 
            // ItemForINSP_TYPE
            // 
            this.ItemForINSP_TYPE.Control = this.INSP_TYPELookUpEdit;
            this.ItemForINSP_TYPE.Location = new System.Drawing.Point(0, 0);
            this.ItemForINSP_TYPE.Name = "ItemForINSP_TYPE";
            this.ItemForINSP_TYPE.Size = new System.Drawing.Size(172, 24);
            this.ItemForINSP_TYPE.TextSize = new System.Drawing.Size(40, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(344, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(172, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // inspectionStandardModelBindingSource
            // 
            this.inspectionStandardModelBindingSource.DataSource = typeof(BPack.Model.App.MD.QciInspStd.InspectionStandardModel);
            // 
            // ITEM_CDButtonEdit
            // 
            this.SetBoundPropertyName(this.ITEM_CDButtonEdit, "");
            this.ITEM_CDButtonEdit.ItemMasterModel = null;
            this.ITEM_CDButtonEdit.Location = new System.Drawing.Point(227, 12);
            this.ITEM_CDButtonEdit.Name = "ITEM_CDButtonEdit";
            this.ITEM_CDButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ITEM_CDButtonEdit.Size = new System.Drawing.Size(125, 20);
            this.ITEM_CDButtonEdit.StyleController = this.dataLayoutControl1;
            this.ITEM_CDButtonEdit.TabIndex = 10;
            this.ITEM_CDButtonEdit.EditValueChanged += new System.EventHandler(this.ITEM_CDButtonEdit_EditValueChanged);
            this.ITEM_CDButtonEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.ITEM_CDButtonEdit_EditValueChanging);
            // 
            // ItemForITEM_CD
            // 
            this.ItemForITEM_CD.Control = this.ITEM_CDButtonEdit;
            this.ItemForITEM_CD.Location = new System.Drawing.Point(172, 0);
            this.ItemForITEM_CD.Name = "ItemForITEM_CD";
            this.ItemForITEM_CD.Size = new System.Drawing.Size(172, 24);
            this.ItemForITEM_CD.Text = "품번";
            this.ItemForITEM_CD.TextSize = new System.Drawing.Size(40, 14);
            // 
            // StandardListEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "StandardListEditForm";
            this.Size = new System.Drawing.Size(536, 44);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ALC_CDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_STD_IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAX_REVISIONTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INSP_TYPELookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForALC_CD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_STD_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMAX_REVISION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForINSP_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionStandardModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_CDButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_CD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit ALC_CDTextEdit;
        private System.Windows.Forms.BindingSource inspectionStandardModelBindingSource;
        private DevExpress.XtraEditors.TextEdit INSP_STD_IDTextEdit;
        private DevExpress.XtraEditors.TextEdit MAX_REVISIONTextEdit;
        private DevExpress.XtraEditors.LookUpEdit INSP_TYPELookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForINSP_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem ItemForITEM_CD;
        private DevExpress.XtraLayout.LayoutControlItem ItemForALC_CD;
        private DevExpress.XtraLayout.LayoutControlItem ItemForINSP_STD_ID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMAX_REVISION;
        private BPack.CommonMes.Controls.ItemMaster.ItemMasterButtonEdit ITEM_CDButtonEdit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}

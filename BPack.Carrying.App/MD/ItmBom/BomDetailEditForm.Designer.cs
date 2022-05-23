namespace BPack.Carrying.App.MD.ItmBom
{
    partial class BomDetailEditForm
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
            this.bomDetailModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ITEM_NMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BOM_QTYTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MODIFY_DTTMDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.MODIFY_USER_IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.REMARKMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.BOM_UNITLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForREMARK = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMODIFY_DTTM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForITEM_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBOM_QTY = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMODIFY_USER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBOM_UNIT = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.itemMasterButtonEdit1 = new CommonMes.Controls.ItemMaster.ItemMasterButtonEdit();
            this.ItemForITEM_CD = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).BeginInit();
            this.strapDataLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bomDetailModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_NMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_QTYTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_USER_IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REMARKMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_UNITLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREMARK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_DTTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBOM_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_USER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBOM_UNIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterButtonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_CD)).BeginInit();
            this.SuspendLayout();
            // 
            // strapDataLayout1
            // 
            this.SetBoundPropertyName(this.strapDataLayout1, "");
            this.strapDataLayout1.Controls.Add(this.itemMasterButtonEdit1);
            this.strapDataLayout1.Controls.Add(this.ITEM_NMTextEdit);
            this.strapDataLayout1.Controls.Add(this.BOM_QTYTextEdit);
            this.strapDataLayout1.Controls.Add(this.MODIFY_DTTMDateEdit);
            this.strapDataLayout1.Controls.Add(this.MODIFY_USER_IDTextEdit);
            this.strapDataLayout1.Controls.Add(this.REMARKMemoEdit);
            this.strapDataLayout1.Controls.Add(this.BOM_UNITLookUpEdit);
            this.strapDataLayout1.DataMember = null;
            this.strapDataLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapDataLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapDataLayout1.Name = "strapDataLayout1";
            this.strapDataLayout1.Root = this.Root;
            this.strapDataLayout1.Size = new System.Drawing.Size(897, 286);
            this.strapDataLayout1.TabIndex = 0;
            this.strapDataLayout1.Text = "strapDataLayout1";
            // 
            // ITEM_NMTextEdit
            // 
            this.SetBoundPropertyName(this.ITEM_NMTextEdit, "");
            this.ITEM_NMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bomDetailModelBindingSource, "ITEM_NM", true));
            this.ITEM_NMTextEdit.Location = new System.Drawing.Point(486, 12);
            this.ITEM_NMTextEdit.MinimumSize = new System.Drawing.Size(150, 0);
            this.ITEM_NMTextEdit.Name = "ITEM_NMTextEdit";
            this.ITEM_NMTextEdit.Properties.ReadOnly = true;
            this.ITEM_NMTextEdit.Size = new System.Drawing.Size(180, 20);
            this.ITEM_NMTextEdit.StyleController = this.strapDataLayout1;
            this.ITEM_NMTextEdit.TabIndex = 5;
            // 
            // BOM_QTYTextEdit
            // 
            this.SetBoundPropertyName(this.BOM_QTYTextEdit, "");
            this.BOM_QTYTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bomDetailModelBindingSource, "BOM_QTY", true));
            this.BOM_QTYTextEdit.Location = new System.Drawing.Point(157, 36);
            this.BOM_QTYTextEdit.MinimumSize = new System.Drawing.Size(150, 0);
            this.BOM_QTYTextEdit.Name = "BOM_QTYTextEdit";
            this.BOM_QTYTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BOM_QTYTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BOM_QTYTextEdit.Properties.Mask.EditMask = "F";
            this.BOM_QTYTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BOM_QTYTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BOM_QTYTextEdit.Size = new System.Drawing.Size(180, 20);
            this.BOM_QTYTextEdit.StyleController = this.strapDataLayout1;
            this.BOM_QTYTextEdit.TabIndex = 7;
            // 
            // MODIFY_DTTMDateEdit
            // 
            this.SetBoundPropertyName(this.MODIFY_DTTMDateEdit, "");
            this.MODIFY_DTTMDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bomDetailModelBindingSource, "MODIFY_DTTM", true));
            this.MODIFY_DTTMDateEdit.EditValue = null;
            this.MODIFY_DTTMDateEdit.Location = new System.Drawing.Point(376, 254);
            this.MODIFY_DTTMDateEdit.MinimumSize = new System.Drawing.Size(150, 0);
            this.MODIFY_DTTMDateEdit.Name = "MODIFY_DTTMDateEdit";
            this.MODIFY_DTTMDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MODIFY_DTTMDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MODIFY_DTTMDateEdit.Properties.DisplayFormat.FormatString = "{0:yyyy-MM-dd HH:mm}";
            this.MODIFY_DTTMDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.MODIFY_DTTMDateEdit.Properties.ReadOnly = true;
            this.MODIFY_DTTMDateEdit.Size = new System.Drawing.Size(180, 20);
            this.MODIFY_DTTMDateEdit.StyleController = this.strapDataLayout1;
            this.MODIFY_DTTMDateEdit.TabIndex = 9;
            // 
            // MODIFY_USER_IDTextEdit
            // 
            this.SetBoundPropertyName(this.MODIFY_USER_IDTextEdit, "");
            this.MODIFY_USER_IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bomDetailModelBindingSource, "MODIFY_USER_ID", true));
            this.MODIFY_USER_IDTextEdit.Location = new System.Drawing.Point(705, 254);
            this.MODIFY_USER_IDTextEdit.MinimumSize = new System.Drawing.Size(150, 0);
            this.MODIFY_USER_IDTextEdit.Name = "MODIFY_USER_IDTextEdit";
            this.MODIFY_USER_IDTextEdit.Properties.ReadOnly = true;
            this.MODIFY_USER_IDTextEdit.Size = new System.Drawing.Size(180, 20);
            this.MODIFY_USER_IDTextEdit.StyleController = this.strapDataLayout1;
            this.MODIFY_USER_IDTextEdit.TabIndex = 10;
            // 
            // REMARKMemoEdit
            // 
            this.SetBoundPropertyName(this.REMARKMemoEdit, "");
            this.REMARKMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bomDetailModelBindingSource, "REMARK", true));
            this.REMARKMemoEdit.Location = new System.Drawing.Point(157, 60);
            this.REMARKMemoEdit.Name = "REMARKMemoEdit";
            this.REMARKMemoEdit.Size = new System.Drawing.Size(728, 190);
            this.REMARKMemoEdit.StyleController = this.strapDataLayout1;
            this.REMARKMemoEdit.TabIndex = 14;
            // 
            // BOM_UNITLookUpEdit
            // 
            this.SetBoundPropertyName(this.BOM_UNITLookUpEdit, "");
            this.BOM_UNITLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bomDetailModelBindingSource, "BOM_UNIT", true));
            this.BOM_UNITLookUpEdit.Location = new System.Drawing.Point(486, 36);
            this.BOM_UNITLookUpEdit.Name = "BOM_UNITLookUpEdit";
            this.BOM_UNITLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BOM_UNITLookUpEdit.Properties.NullText = "";
            this.BOM_UNITLookUpEdit.Size = new System.Drawing.Size(180, 20);
            this.BOM_UNITLookUpEdit.StyleController = this.strapDataLayout1;
            this.BOM_UNITLookUpEdit.TabIndex = 15;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForREMARK,
            this.ItemForMODIFY_DTTM,
            this.ItemForITEM_NM,
            this.ItemForBOM_QTY,
            this.ItemForMODIFY_USER_ID,
            this.ItemForBOM_UNIT,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.ItemForITEM_CD});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(897, 286);
            this.Root.TextVisible = false;
            // 
            // ItemForREMARK
            // 
            this.ItemForREMARK.Control = this.REMARKMemoEdit;
            this.ItemForREMARK.Location = new System.Drawing.Point(0, 48);
            this.ItemForREMARK.Name = "ItemForREMARK";
            this.ItemForREMARK.Size = new System.Drawing.Size(877, 194);
            this.ItemForREMARK.TextSize = new System.Drawing.Size(142, 14);
            // 
            // ItemForMODIFY_DTTM
            // 
            this.ItemForMODIFY_DTTM.Control = this.MODIFY_DTTMDateEdit;
            this.ItemForMODIFY_DTTM.Location = new System.Drawing.Point(219, 242);
            this.ItemForMODIFY_DTTM.Name = "ItemForMODIFY_DTTM";
            this.ItemForMODIFY_DTTM.Size = new System.Drawing.Size(329, 24);
            this.ItemForMODIFY_DTTM.TextSize = new System.Drawing.Size(142, 14);
            // 
            // ItemForITEM_NM
            // 
            this.ItemForITEM_NM.Control = this.ITEM_NMTextEdit;
            this.ItemForITEM_NM.Location = new System.Drawing.Point(329, 0);
            this.ItemForITEM_NM.Name = "ItemForITEM_NM";
            this.ItemForITEM_NM.Size = new System.Drawing.Size(329, 24);
            this.ItemForITEM_NM.TextSize = new System.Drawing.Size(142, 14);
            // 
            // ItemForBOM_QTY
            // 
            this.ItemForBOM_QTY.Control = this.BOM_QTYTextEdit;
            this.ItemForBOM_QTY.Location = new System.Drawing.Point(0, 24);
            this.ItemForBOM_QTY.Name = "ItemForBOM_QTY";
            this.ItemForBOM_QTY.Size = new System.Drawing.Size(329, 24);
            this.ItemForBOM_QTY.TextSize = new System.Drawing.Size(142, 14);
            // 
            // ItemForMODIFY_USER_ID
            // 
            this.ItemForMODIFY_USER_ID.Control = this.MODIFY_USER_IDTextEdit;
            this.ItemForMODIFY_USER_ID.Location = new System.Drawing.Point(548, 242);
            this.ItemForMODIFY_USER_ID.Name = "ItemForMODIFY_USER_ID";
            this.ItemForMODIFY_USER_ID.Size = new System.Drawing.Size(329, 24);
            this.ItemForMODIFY_USER_ID.TextSize = new System.Drawing.Size(142, 14);
            // 
            // ItemForBOM_UNIT
            // 
            this.ItemForBOM_UNIT.Control = this.BOM_UNITLookUpEdit;
            this.ItemForBOM_UNIT.Location = new System.Drawing.Point(329, 24);
            this.ItemForBOM_UNIT.Name = "ItemForBOM_UNIT";
            this.ItemForBOM_UNIT.Size = new System.Drawing.Size(329, 24);
            this.ItemForBOM_UNIT.TextSize = new System.Drawing.Size(142, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(658, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(219, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 242);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(219, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(658, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(219, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // itemMasterButtonEdit1
            // 
            this.SetBoundPropertyName(this.itemMasterButtonEdit1, "");
            this.itemMasterButtonEdit1.ItemMasterModel = null;
            this.itemMasterButtonEdit1.Location = new System.Drawing.Point(157, 12);
            this.itemMasterButtonEdit1.Name = "itemMasterButtonEdit1";
            this.itemMasterButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.itemMasterButtonEdit1.Size = new System.Drawing.Size(180, 20);
            this.itemMasterButtonEdit1.StyleController = this.strapDataLayout1;
            this.itemMasterButtonEdit1.TabIndex = 16;
            // 
            // ItemForITEM_CD
            // 
            this.ItemForITEM_CD.Control = this.itemMasterButtonEdit1;
            this.ItemForITEM_CD.Location = new System.Drawing.Point(0, 0);
            this.ItemForITEM_CD.Name = "ItemForITEM_CD";
            this.ItemForITEM_CD.Size = new System.Drawing.Size(329, 24);
            this.ItemForITEM_CD.TextSize = new System.Drawing.Size(142, 14);
            // 
            // BomDetailEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.strapDataLayout1);
            this.Name = "BomDetailEditForm";
            this.Size = new System.Drawing.Size(897, 286);
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).EndInit();
            this.strapDataLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bomDetailModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_NMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_QTYTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_USER_IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REMARKMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_UNITLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREMARK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_DTTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBOM_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_USER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBOM_UNIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterButtonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_CD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapDataLayout strapDataLayout1;
        private System.Windows.Forms.BindingSource bomDetailModelBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit ITEM_NMTextEdit;
        private DevExpress.XtraEditors.TextEdit BOM_QTYTextEdit;
        private DevExpress.XtraEditors.DateEdit MODIFY_DTTMDateEdit;
        private DevExpress.XtraEditors.TextEdit MODIFY_USER_IDTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForITEM_NM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBOM_QTY;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBOM_UNIT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMODIFY_DTTM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMODIFY_USER_ID;
        private DevExpress.XtraEditors.MemoEdit REMARKMemoEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForREMARK;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.LookUpEdit BOM_UNITLookUpEdit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private CommonMes.Controls.ItemMaster.ItemMasterButtonEdit itemMasterButtonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForITEM_CD;
    }
}

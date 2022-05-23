namespace BPack.Carrying.App.PC.WorkOrder
{
    partial class WorkOrderListEditForm
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
            this.sgcRouteMtrl = new BPack.Strap.Grid.StrapGridControl();
            this.bsRouteMtrl = new System.Windows.Forms.BindingSource(this.components);
            this.gvRouteMtrl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colROUTE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colITEM_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPER_UNIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_BACKFLUSH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAT_INPUT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSORT_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROW_SEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLANG_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ITEM_NMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.MODIFY_DTTMDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bsWorkOrder = new System.Windows.Forms.BindingSource(this.components);
            this.REMARKMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.WO_DTDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.WOR_QTYTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BOM_BASE_QTYTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.VALID_TO_DTDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.VALID_FROM_DTDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.BOM_BASE_UNITTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.WO_NOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SHIFT_CDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ROUTE_NOLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ITEM_CDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ItemForMODIFY_DTTM = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForITEM_CD = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForITEM_NM = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWO_NO = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWO_DT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSHIFT_CD = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForROUTE_NO = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForVALID_FROM_DT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForVALID_TO_DT = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBOM_BASE_QTY = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBOM_BASE_UNIT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForREMARK = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWOR_QTY = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).BeginInit();
            this.strapDataLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgcRouteMtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRouteMtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRouteMtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_NMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REMARKMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WO_DTDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WO_DTDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WOR_QTYTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_BASE_QTYTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_TO_DTDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_TO_DTDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_FROM_DTDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_FROM_DTDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_BASE_UNITTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WO_NOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIFT_CDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROUTE_NOLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_CDLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_DTTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_CD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_NM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWO_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWO_DT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSHIFT_CD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForROUTE_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVALID_FROM_DT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVALID_TO_DT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBOM_BASE_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBOM_BASE_UNIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREMARK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWOR_QTY)).BeginInit();
            this.SuspendLayout();
            // 
            // strapDataLayout1
            // 
            this.SetBoundPropertyName(this.strapDataLayout1, "");
            this.strapDataLayout1.Controls.Add(this.sgcRouteMtrl);
            this.strapDataLayout1.Controls.Add(this.ITEM_NMTextEdit);
            this.strapDataLayout1.Controls.Add(this.MODIFY_DTTMDateEdit);
            this.strapDataLayout1.Controls.Add(this.REMARKMemoEdit);
            this.strapDataLayout1.Controls.Add(this.WO_DTDateEdit);
            this.strapDataLayout1.Controls.Add(this.WOR_QTYTextEdit);
            this.strapDataLayout1.Controls.Add(this.BOM_BASE_QTYTextEdit);
            this.strapDataLayout1.Controls.Add(this.VALID_TO_DTDateEdit);
            this.strapDataLayout1.Controls.Add(this.VALID_FROM_DTDateEdit);
            this.strapDataLayout1.Controls.Add(this.BOM_BASE_UNITTextEdit);
            this.strapDataLayout1.Controls.Add(this.WO_NOTextEdit);
            this.strapDataLayout1.Controls.Add(this.SHIFT_CDLookUpEdit);
            this.strapDataLayout1.Controls.Add(this.ROUTE_NOLookUpEdit);
            this.strapDataLayout1.Controls.Add(this.ITEM_CDLookUpEdit);
            this.strapDataLayout1.DataSource = this.bsWorkOrder;
            this.strapDataLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapDataLayout1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMODIFY_DTTM});
            this.strapDataLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapDataLayout1.Name = "strapDataLayout1";
            this.strapDataLayout1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(818, 40, 650, 400);
            this.strapDataLayout1.Root = this.Root;
            this.strapDataLayout1.Size = new System.Drawing.Size(771, 500);
            this.strapDataLayout1.TabIndex = 0;
            this.strapDataLayout1.Text = "strapDataLayout1";
            // 
            // sgcRouteMtrl
            // 
            this.SetBoundPropertyName(this.sgcRouteMtrl, "");
            this.sgcRouteMtrl.DataSource = this.bsRouteMtrl;
            this.sgcRouteMtrl.IsStrapGridViewDefaultSetting = true;
            this.sgcRouteMtrl.Location = new System.Drawing.Point(24, 352);
            this.sgcRouteMtrl.MainView = this.gvRouteMtrl;
            this.sgcRouteMtrl.Name = "sgcRouteMtrl";
            this.sgcRouteMtrl.SelectedModel = null;
            this.sgcRouteMtrl.SelectedModelIndex = null;
            this.sgcRouteMtrl.Size = new System.Drawing.Size(723, 124);
            this.sgcRouteMtrl.TabIndex = 48;
            this.sgcRouteMtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRouteMtrl});
            // 
            // bsRouteMtrl
            // 
            this.bsRouteMtrl.DataSource = typeof(BPack.Model.App.PC.WorkOrder.RouteMtrlModel);
            // 
            // gvRouteMtrl
            // 
            this.gvRouteMtrl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colROUTE_NO,
            this.colOPER,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colOPER_QTY,
            this.colOPER_UNIT,
            this.colIS_BACKFLUSH,
            this.colMAT_INPUT_TYPE,
            this.colVALID,
            this.colREMARK,
            this.colSORT_NO,
            this.colROW_SEQ,
            this.colCREATE_DTTM,
            this.colCREATE_USER_ID,
            this.colMODIFY_DTTM,
            this.colMODIFY_USER_ID,
            this.colLANG_CODE,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck});
            this.gvRouteMtrl.GridControl = this.sgcRouteMtrl;
            this.gvRouteMtrl.Name = "gvRouteMtrl";
            this.gvRouteMtrl.OptionsBehavior.Editable = false;
            this.gvRouteMtrl.OptionsView.ShowGroupPanel = false;
            // 
            // colROUTE_NO
            // 
            this.colROUTE_NO.FieldName = "ROUTE_NO";
            this.colROUTE_NO.Name = "colROUTE_NO";
            // 
            // colOPER
            // 
            this.colOPER.FieldName = "OPER";
            this.colOPER.Name = "colOPER";
            this.colOPER.Visible = true;
            this.colOPER.VisibleIndex = 0;
            // 
            // colITEM_CD
            // 
            this.colITEM_CD.FieldName = "ITEM_CD";
            this.colITEM_CD.Name = "colITEM_CD";
            this.colITEM_CD.Visible = true;
            this.colITEM_CD.VisibleIndex = 1;
            // 
            // colITEM_NM
            // 
            this.colITEM_NM.FieldName = "ITEM_NM";
            this.colITEM_NM.Name = "colITEM_NM";
            this.colITEM_NM.Visible = true;
            this.colITEM_NM.VisibleIndex = 2;
            // 
            // colOPER_QTY
            // 
            this.colOPER_QTY.FieldName = "OPER_QTY";
            this.colOPER_QTY.Name = "colOPER_QTY";
            this.colOPER_QTY.Visible = true;
            this.colOPER_QTY.VisibleIndex = 3;
            // 
            // colOPER_UNIT
            // 
            this.colOPER_UNIT.FieldName = "OPER_UNIT";
            this.colOPER_UNIT.Name = "colOPER_UNIT";
            this.colOPER_UNIT.Visible = true;
            this.colOPER_UNIT.VisibleIndex = 4;
            // 
            // colIS_BACKFLUSH
            // 
            this.colIS_BACKFLUSH.FieldName = "IS_BACKFLUSH";
            this.colIS_BACKFLUSH.Name = "colIS_BACKFLUSH";
            this.colIS_BACKFLUSH.Visible = true;
            this.colIS_BACKFLUSH.VisibleIndex = 5;
            // 
            // colMAT_INPUT_TYPE
            // 
            this.colMAT_INPUT_TYPE.FieldName = "MAT_INPUT_TYPE";
            this.colMAT_INPUT_TYPE.Name = "colMAT_INPUT_TYPE";
            this.colMAT_INPUT_TYPE.Visible = true;
            this.colMAT_INPUT_TYPE.VisibleIndex = 6;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            // 
            // ITEM_NMTextEdit
            // 
            this.SetBoundPropertyName(this.ITEM_NMTextEdit, "");
            this.ITEM_NMTextEdit.Location = new System.Drawing.Point(501, 60);
            this.ITEM_NMTextEdit.MinimumSize = new System.Drawing.Size(150, 0);
            this.ITEM_NMTextEdit.Name = "ITEM_NMTextEdit";
            this.ITEM_NMTextEdit.Size = new System.Drawing.Size(258, 20);
            this.ITEM_NMTextEdit.StyleController = this.strapDataLayout1;
            this.ITEM_NMTextEdit.TabIndex = 5;
            // 
            // MODIFY_DTTMDateEdit
            // 
            this.SetBoundPropertyName(this.MODIFY_DTTMDateEdit, "");
            this.MODIFY_DTTMDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsWorkOrder, "MODIFY_DTTM", true));
            this.MODIFY_DTTMDateEdit.EditValue = null;
            this.MODIFY_DTTMDateEdit.Location = new System.Drawing.Point(448, 180);
            this.MODIFY_DTTMDateEdit.MinimumSize = new System.Drawing.Size(150, 0);
            this.MODIFY_DTTMDateEdit.Name = "MODIFY_DTTMDateEdit";
            this.MODIFY_DTTMDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MODIFY_DTTMDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MODIFY_DTTMDateEdit.Properties.DisplayFormat.FormatString = "{0:yyyy-MM-dd HH:mm}";
            this.MODIFY_DTTMDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.MODIFY_DTTMDateEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.MODIFY_DTTMDateEdit.Properties.ReadOnly = true;
            this.MODIFY_DTTMDateEdit.Size = new System.Drawing.Size(311, 20);
            this.MODIFY_DTTMDateEdit.StyleController = this.strapDataLayout1;
            this.MODIFY_DTTMDateEdit.TabIndex = 26;
            // 
            // bsWorkOrder
            // 
            this.bsWorkOrder.DataSource = typeof(BPack.Model.App.PC.WorkOrder.WorkOrderModel);
            // 
            // REMARKMemoEdit
            // 
            this.SetBoundPropertyName(this.REMARKMemoEdit, "");
            this.REMARKMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsWorkOrder, "REMARK", true));
            this.REMARKMemoEdit.Location = new System.Drawing.Point(126, 84);
            this.REMARKMemoEdit.Name = "REMARKMemoEdit";
            this.REMARKMemoEdit.Size = new System.Drawing.Size(633, 161);
            this.REMARKMemoEdit.StyleController = this.strapDataLayout1;
            this.REMARKMemoEdit.TabIndex = 28;
            // 
            // WO_DTDateEdit
            // 
            this.SetBoundPropertyName(this.WO_DTDateEdit, "");
            this.WO_DTDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsWorkOrder, "WO_DT", true));
            this.WO_DTDateEdit.EditValue = null;
            this.WO_DTDateEdit.Location = new System.Drawing.Point(126, 36);
            this.WO_DTDateEdit.Name = "WO_DTDateEdit";
            this.WO_DTDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WO_DTDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WO_DTDateEdit.Size = new System.Drawing.Size(257, 20);
            this.WO_DTDateEdit.StyleController = this.strapDataLayout1;
            this.WO_DTDateEdit.TabIndex = 30;
            // 
            // WOR_QTYTextEdit
            // 
            this.SetBoundPropertyName(this.WOR_QTYTextEdit, "");
            this.WOR_QTYTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsWorkOrder, "WOR_QTY", true));
            this.WOR_QTYTextEdit.Location = new System.Drawing.Point(501, 12);
            this.WOR_QTYTextEdit.Name = "WOR_QTYTextEdit";
            this.WOR_QTYTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.WOR_QTYTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.WOR_QTYTextEdit.Properties.Mask.EditMask = "F";
            this.WOR_QTYTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.WOR_QTYTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.WOR_QTYTextEdit.Size = new System.Drawing.Size(258, 20);
            this.WOR_QTYTextEdit.StyleController = this.strapDataLayout1;
            this.WOR_QTYTextEdit.TabIndex = 31;
            // 
            // BOM_BASE_QTYTextEdit
            // 
            this.SetBoundPropertyName(this.BOM_BASE_QTYTextEdit, "");
            this.BOM_BASE_QTYTextEdit.Location = new System.Drawing.Point(138, 328);
            this.BOM_BASE_QTYTextEdit.Name = "BOM_BASE_QTYTextEdit";
            this.BOM_BASE_QTYTextEdit.Size = new System.Drawing.Size(245, 20);
            this.BOM_BASE_QTYTextEdit.StyleController = this.strapDataLayout1;
            this.BOM_BASE_QTYTextEdit.TabIndex = 36;
            // 
            // VALID_TO_DTDateEdit
            // 
            this.SetBoundPropertyName(this.VALID_TO_DTDateEdit, "");
            this.VALID_TO_DTDateEdit.EditValue = null;
            this.VALID_TO_DTDateEdit.Location = new System.Drawing.Point(501, 304);
            this.VALID_TO_DTDateEdit.Name = "VALID_TO_DTDateEdit";
            this.VALID_TO_DTDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VALID_TO_DTDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VALID_TO_DTDateEdit.Size = new System.Drawing.Size(246, 20);
            this.VALID_TO_DTDateEdit.StyleController = this.strapDataLayout1;
            this.VALID_TO_DTDateEdit.TabIndex = 37;
            // 
            // VALID_FROM_DTDateEdit
            // 
            this.SetBoundPropertyName(this.VALID_FROM_DTDateEdit, "");
            this.VALID_FROM_DTDateEdit.EditValue = null;
            this.VALID_FROM_DTDateEdit.Enabled = false;
            this.VALID_FROM_DTDateEdit.Location = new System.Drawing.Point(138, 304);
            this.VALID_FROM_DTDateEdit.Name = "VALID_FROM_DTDateEdit";
            this.VALID_FROM_DTDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VALID_FROM_DTDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.VALID_FROM_DTDateEdit.Size = new System.Drawing.Size(245, 20);
            this.VALID_FROM_DTDateEdit.StyleController = this.strapDataLayout1;
            this.VALID_FROM_DTDateEdit.TabIndex = 38;
            // 
            // BOM_BASE_UNITTextEdit
            // 
            this.SetBoundPropertyName(this.BOM_BASE_UNITTextEdit, "");
            this.BOM_BASE_UNITTextEdit.Location = new System.Drawing.Point(501, 328);
            this.BOM_BASE_UNITTextEdit.Name = "BOM_BASE_UNITTextEdit";
            this.BOM_BASE_UNITTextEdit.Size = new System.Drawing.Size(246, 20);
            this.BOM_BASE_UNITTextEdit.StyleController = this.strapDataLayout1;
            this.BOM_BASE_UNITTextEdit.TabIndex = 39;
            // 
            // WO_NOTextEdit
            // 
            this.SetBoundPropertyName(this.WO_NOTextEdit, "");
            this.WO_NOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsWorkOrder, "WO_NO", true));
            this.WO_NOTextEdit.Location = new System.Drawing.Point(126, 12);
            this.WO_NOTextEdit.Name = "WO_NOTextEdit";
            this.WO_NOTextEdit.Properties.ReadOnly = true;
            this.WO_NOTextEdit.Size = new System.Drawing.Size(257, 20);
            this.WO_NOTextEdit.StyleController = this.strapDataLayout1;
            this.WO_NOTextEdit.TabIndex = 40;
            // 
            // SHIFT_CDLookUpEdit
            // 
            this.SetBoundPropertyName(this.SHIFT_CDLookUpEdit, "");
            this.SHIFT_CDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsWorkOrder, "SHIFT_CD", true));
            this.SHIFT_CDLookUpEdit.Location = new System.Drawing.Point(501, 36);
            this.SHIFT_CDLookUpEdit.Name = "SHIFT_CDLookUpEdit";
            this.SHIFT_CDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SHIFT_CDLookUpEdit.Properties.NullText = "";
            this.SHIFT_CDLookUpEdit.Size = new System.Drawing.Size(258, 20);
            this.SHIFT_CDLookUpEdit.StyleController = this.strapDataLayout1;
            this.SHIFT_CDLookUpEdit.TabIndex = 42;
            // 
            // ROUTE_NOLookUpEdit
            // 
            this.SetBoundPropertyName(this.ROUTE_NOLookUpEdit, "");
            this.ROUTE_NOLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsWorkOrder, "ROUTE_NO", true));
            this.ROUTE_NOLookUpEdit.Location = new System.Drawing.Point(138, 280);
            this.ROUTE_NOLookUpEdit.Name = "ROUTE_NOLookUpEdit";
            this.ROUTE_NOLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ROUTE_NOLookUpEdit.Properties.NullText = "";
            this.ROUTE_NOLookUpEdit.Size = new System.Drawing.Size(245, 20);
            this.ROUTE_NOLookUpEdit.StyleController = this.strapDataLayout1;
            this.ROUTE_NOLookUpEdit.TabIndex = 43;
            this.ROUTE_NOLookUpEdit.EditValueChanged += new System.EventHandler(this.ROUTE_NOLookUpEdit_EditValueChanged);
            // 
            // ITEM_CDLookUpEdit
            // 
            this.SetBoundPropertyName(this.ITEM_CDLookUpEdit, "");
            this.ITEM_CDLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsWorkOrder, "ITEM_CD", true));
            this.ITEM_CDLookUpEdit.Location = new System.Drawing.Point(126, 60);
            this.ITEM_CDLookUpEdit.Name = "ITEM_CDLookUpEdit";
            this.ITEM_CDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ITEM_CDLookUpEdit.Properties.NullText = "";
            this.ITEM_CDLookUpEdit.Size = new System.Drawing.Size(257, 20);
            this.ITEM_CDLookUpEdit.StyleController = this.strapDataLayout1;
            this.ITEM_CDLookUpEdit.TabIndex = 47;
            this.ITEM_CDLookUpEdit.EditValueChanged += new System.EventHandler(this.ITEM_CDLookUpEdit_EditValueChanged);
            // 
            // ItemForMODIFY_DTTM
            // 
            this.ItemForMODIFY_DTTM.Control = this.MODIFY_DTTMDateEdit;
            this.ItemForMODIFY_DTTM.Location = new System.Drawing.Point(295, 168);
            this.ItemForMODIFY_DTTM.Name = "ItemForMODIFY_DTTM";
            this.ItemForMODIFY_DTTM.Size = new System.Drawing.Size(456, 24);
            this.ItemForMODIFY_DTTM.TextSize = new System.Drawing.Size(138, 14);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(771, 500);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForITEM_CD,
            this.ItemForITEM_NM,
            this.ItemForWO_NO,
            this.ItemForWO_DT,
            this.ItemForSHIFT_CD,
            this.layoutControlGroup2,
            this.ItemForREMARK,
            this.ItemForWOR_QTY});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(751, 480);
            // 
            // ItemForITEM_CD
            // 
            this.ItemForITEM_CD.Control = this.ITEM_CDLookUpEdit;
            this.ItemForITEM_CD.Location = new System.Drawing.Point(0, 48);
            this.ItemForITEM_CD.Name = "ItemForITEM_CD";
            this.ItemForITEM_CD.Size = new System.Drawing.Size(375, 24);
            this.ItemForITEM_CD.TextSize = new System.Drawing.Size(111, 14);
            // 
            // ItemForITEM_NM
            // 
            this.ItemForITEM_NM.Control = this.ITEM_NMTextEdit;
            this.ItemForITEM_NM.Enabled = false;
            this.ItemForITEM_NM.Location = new System.Drawing.Point(375, 48);
            this.ItemForITEM_NM.Name = "ItemForITEM_NM";
            this.ItemForITEM_NM.Size = new System.Drawing.Size(376, 24);
            this.ItemForITEM_NM.Text = "품명";
            this.ItemForITEM_NM.TextSize = new System.Drawing.Size(111, 14);
            // 
            // ItemForWO_NO
            // 
            this.ItemForWO_NO.Control = this.WO_NOTextEdit;
            this.ItemForWO_NO.Location = new System.Drawing.Point(0, 0);
            this.ItemForWO_NO.Name = "ItemForWO_NO";
            this.ItemForWO_NO.Size = new System.Drawing.Size(375, 24);
            this.ItemForWO_NO.TextSize = new System.Drawing.Size(111, 14);
            // 
            // ItemForWO_DT
            // 
            this.ItemForWO_DT.Control = this.WO_DTDateEdit;
            this.ItemForWO_DT.Location = new System.Drawing.Point(0, 24);
            this.ItemForWO_DT.Name = "ItemForWO_DT";
            this.ItemForWO_DT.Size = new System.Drawing.Size(375, 24);
            this.ItemForWO_DT.TextSize = new System.Drawing.Size(111, 14);
            // 
            // ItemForSHIFT_CD
            // 
            this.ItemForSHIFT_CD.Control = this.SHIFT_CDLookUpEdit;
            this.ItemForSHIFT_CD.Location = new System.Drawing.Point(375, 24);
            this.ItemForSHIFT_CD.Name = "ItemForSHIFT_CD";
            this.ItemForSHIFT_CD.Size = new System.Drawing.Size(376, 24);
            this.ItemForSHIFT_CD.TextSize = new System.Drawing.Size(111, 14);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForROUTE_NO,
            this.emptySpaceItem3,
            this.ItemForVALID_FROM_DT,
            this.ItemForVALID_TO_DT,
            this.ItemForBOM_BASE_QTY,
            this.ItemForBOM_BASE_UNIT,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 237);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(751, 243);
            this.layoutControlGroup2.Text = "라우팅정보";
            // 
            // ItemForROUTE_NO
            // 
            this.ItemForROUTE_NO.Control = this.ROUTE_NOLookUpEdit;
            this.ItemForROUTE_NO.Location = new System.Drawing.Point(0, 0);
            this.ItemForROUTE_NO.Name = "ItemForROUTE_NO";
            this.ItemForROUTE_NO.Size = new System.Drawing.Size(363, 24);
            this.ItemForROUTE_NO.TextSize = new System.Drawing.Size(111, 14);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(363, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(364, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForVALID_FROM_DT
            // 
            this.ItemForVALID_FROM_DT.Control = this.VALID_FROM_DTDateEdit;
            this.ItemForVALID_FROM_DT.Location = new System.Drawing.Point(0, 24);
            this.ItemForVALID_FROM_DT.Name = "ItemForVALID_FROM_DT";
            this.ItemForVALID_FROM_DT.Size = new System.Drawing.Size(363, 24);
            this.ItemForVALID_FROM_DT.Text = "라우팅 유효기간(To)";
            this.ItemForVALID_FROM_DT.TextSize = new System.Drawing.Size(111, 14);
            // 
            // ItemForVALID_TO_DT
            // 
            this.ItemForVALID_TO_DT.Control = this.VALID_TO_DTDateEdit;
            this.ItemForVALID_TO_DT.Enabled = false;
            this.ItemForVALID_TO_DT.Location = new System.Drawing.Point(363, 24);
            this.ItemForVALID_TO_DT.Name = "ItemForVALID_TO_DT";
            this.ItemForVALID_TO_DT.Size = new System.Drawing.Size(364, 24);
            this.ItemForVALID_TO_DT.Text = "라우팅 유효기간(From)";
            this.ItemForVALID_TO_DT.TextSize = new System.Drawing.Size(111, 14);
            // 
            // ItemForBOM_BASE_QTY
            // 
            this.ItemForBOM_BASE_QTY.Control = this.BOM_BASE_QTYTextEdit;
            this.ItemForBOM_BASE_QTY.Enabled = false;
            this.ItemForBOM_BASE_QTY.Location = new System.Drawing.Point(0, 48);
            this.ItemForBOM_BASE_QTY.Name = "ItemForBOM_BASE_QTY";
            this.ItemForBOM_BASE_QTY.Size = new System.Drawing.Size(363, 24);
            this.ItemForBOM_BASE_QTY.Text = "기준수량";
            this.ItemForBOM_BASE_QTY.TextSize = new System.Drawing.Size(111, 14);
            // 
            // ItemForBOM_BASE_UNIT
            // 
            this.ItemForBOM_BASE_UNIT.Control = this.BOM_BASE_UNITTextEdit;
            this.ItemForBOM_BASE_UNIT.Enabled = false;
            this.ItemForBOM_BASE_UNIT.Location = new System.Drawing.Point(363, 48);
            this.ItemForBOM_BASE_UNIT.Name = "ItemForBOM_BASE_UNIT";
            this.ItemForBOM_BASE_UNIT.Size = new System.Drawing.Size(364, 24);
            this.ItemForBOM_BASE_UNIT.Text = "단위";
            this.ItemForBOM_BASE_UNIT.TextSize = new System.Drawing.Size(111, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sgcRouteMtrl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(727, 128);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForREMARK
            // 
            this.ItemForREMARK.Control = this.REMARKMemoEdit;
            this.ItemForREMARK.Location = new System.Drawing.Point(0, 72);
            this.ItemForREMARK.Name = "ItemForREMARK";
            this.ItemForREMARK.Size = new System.Drawing.Size(751, 165);
            this.ItemForREMARK.TextSize = new System.Drawing.Size(111, 14);
            // 
            // ItemForWOR_QTY
            // 
            this.ItemForWOR_QTY.Control = this.WOR_QTYTextEdit;
            this.ItemForWOR_QTY.Location = new System.Drawing.Point(375, 0);
            this.ItemForWOR_QTY.Name = "ItemForWOR_QTY";
            this.ItemForWOR_QTY.Size = new System.Drawing.Size(376, 24);
            this.ItemForWOR_QTY.TextSize = new System.Drawing.Size(111, 14);
            // 
            // WorkOrderListEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.strapDataLayout1);
            this.Name = "WorkOrderListEditForm";
            this.Size = new System.Drawing.Size(771, 500);
            ((System.ComponentModel.ISupportInitialize)(this.strapDataLayout1)).EndInit();
            this.strapDataLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sgcRouteMtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRouteMtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRouteMtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_NMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MODIFY_DTTMDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REMARKMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WO_DTDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WO_DTDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WOR_QTYTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_BASE_QTYTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_TO_DTDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_TO_DTDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_FROM_DTDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VALID_FROM_DTDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BOM_BASE_UNITTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WO_NOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHIFT_CDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ROUTE_NOLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM_CDLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMODIFY_DTTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_CD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForITEM_NM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWO_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWO_DT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSHIFT_CD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForROUTE_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVALID_FROM_DT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVALID_TO_DT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBOM_BASE_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBOM_BASE_UNIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForREMARK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWOR_QTY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Layout.StrapDataLayout strapDataLayout1;
        private System.Windows.Forms.BindingSource bsWorkOrder;
        private DevExpress.XtraEditors.TextEdit ITEM_NMTextEdit;
        private DevExpress.XtraEditors.DateEdit MODIFY_DTTMDateEdit;
        private DevExpress.XtraEditors.MemoEdit REMARKMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForITEM_CD;
        private DevExpress.XtraLayout.LayoutControlItem ItemForITEM_NM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMODIFY_DTTM;
        private DevExpress.XtraLayout.LayoutControlItem ItemForREMARK;
        private DevExpress.XtraEditors.DateEdit WO_DTDateEdit;
        private DevExpress.XtraEditors.TextEdit WOR_QTYTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForROUTE_NO;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWO_DT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWOR_QTY;
        private DevExpress.XtraEditors.TextEdit BOM_BASE_QTYTextEdit;
        private DevExpress.XtraEditors.DateEdit VALID_TO_DTDateEdit;
        private DevExpress.XtraEditors.DateEdit VALID_FROM_DTDateEdit;
        private DevExpress.XtraEditors.TextEdit BOM_BASE_UNITTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBOM_BASE_QTY;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVALID_FROM_DT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVALID_TO_DT;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBOM_BASE_UNIT;
        private DevExpress.XtraEditors.TextEdit WO_NOTextEdit;
        private DevExpress.XtraEditors.LookUpEdit SHIFT_CDLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWO_NO;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSHIFT_CD;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.LookUpEdit ROUTE_NOLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit ITEM_CDLookUpEdit;
        private Strap.Grid.StrapGridControl sgcRouteMtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRouteMtrl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource bsRouteMtrl;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_CD;
        private DevExpress.XtraGrid.Columns.GridColumn colITEM_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colOPER_UNIT;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_BACKFLUSH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAT_INPUT_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colVALID;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DevExpress.XtraGrid.Columns.GridColumn colSORT_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colROW_SEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLANG_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
    }
}

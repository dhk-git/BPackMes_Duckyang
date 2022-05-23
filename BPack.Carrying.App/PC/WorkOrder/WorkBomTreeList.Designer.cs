
namespace BPack.Carrying.App.PC.WorkOrder
{
    partial class WorkBomTreeList
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
            this.strapTreeList1 = new BPack.Strap.TreeList.StrapTreeList();
            this.colLV = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCOMP_CD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPLANT_CD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVALIDT_DT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colP_ITEM_CD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colITEM_CD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colITEM_NM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colITEM_SPEC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colITEM_TYPE = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colITEM_GR_1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBOM_QTY = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBASE_UNIT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colVALID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colREMARK = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSORT_NO = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colROW_SEQ = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCREATE_DTTM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLANG_CODE = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRowState = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCrudCls = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSelectedCheck = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsCheck = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.workOrderBomModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIS_PHANTOM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBomModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strapTreeList1
            // 
            this.strapTreeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colLV,
            this.colCOMP_CD,
            this.colPLANT_CD,
            this.colVALIDT_DT,
            this.colP_ITEM_CD,
            this.colITEM_CD,
            this.colITEM_NM,
            this.colITEM_SPEC,
            this.colITEM_TYPE,
            this.colITEM_GR_1,
            this.colBOM_QTY,
            this.colBASE_UNIT,
            this.colIS_PHANTOM,
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
            this.colSelectedCheck,
            this.colIsCheck});
            this.strapTreeList1.DataSource = this.workOrderBomModelBindingSource;
            this.strapTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapTreeList1.IsStrapGridViewDefaultSetting = true;
            this.strapTreeList1.Location = new System.Drawing.Point(0, 0);
            this.strapTreeList1.Name = "strapTreeList1";
            this.strapTreeList1.ParentFieldName = "P_ID";
            this.strapTreeList1.RootValue = "ROOT";
            this.strapTreeList1.SelectedModel = null;
            this.strapTreeList1.SelectedModelIndex = null;
            this.strapTreeList1.SelectedNode = null;
            this.strapTreeList1.Size = new System.Drawing.Size(838, 501);
            this.strapTreeList1.TabIndex = 0;
            // 
            // colLV
            // 
            this.colLV.FieldName = "LV";
            this.colLV.Name = "colLV";
            this.colLV.Visible = true;
            this.colLV.VisibleIndex = 0;
            // 
            // colCOMP_CD
            // 
            this.colCOMP_CD.FieldName = "COMP_CD";
            this.colCOMP_CD.Name = "colCOMP_CD";
            // 
            // colPLANT_CD
            // 
            this.colPLANT_CD.FieldName = "PLANT_CD";
            this.colPLANT_CD.Name = "colPLANT_CD";
            // 
            // colVALIDT_DT
            // 
            this.colVALIDT_DT.FieldName = "VALIDT_DT";
            this.colVALIDT_DT.Name = "colVALIDT_DT";
            // 
            // colP_ITEM_CD
            // 
            this.colP_ITEM_CD.FieldName = "P_ITEM_CD";
            this.colP_ITEM_CD.Name = "colP_ITEM_CD";
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
            // colITEM_SPEC
            // 
            this.colITEM_SPEC.FieldName = "ITEM_SPEC";
            this.colITEM_SPEC.Name = "colITEM_SPEC";
            this.colITEM_SPEC.Visible = true;
            this.colITEM_SPEC.VisibleIndex = 3;
            // 
            // colITEM_TYPE
            // 
            this.colITEM_TYPE.FieldName = "ITEM_TYPE";
            this.colITEM_TYPE.Name = "colITEM_TYPE";
            this.colITEM_TYPE.Visible = true;
            this.colITEM_TYPE.VisibleIndex = 4;
            // 
            // colITEM_GR_1
            // 
            this.colITEM_GR_1.FieldName = "ITEM_GR_1";
            this.colITEM_GR_1.Name = "colITEM_GR_1";
            this.colITEM_GR_1.Visible = true;
            this.colITEM_GR_1.VisibleIndex = 5;
            // 
            // colBOM_QTY
            // 
            this.colBOM_QTY.FieldName = "BOM_QTY";
            this.colBOM_QTY.Name = "colBOM_QTY";
            this.colBOM_QTY.Visible = true;
            this.colBOM_QTY.VisibleIndex = 6;
            // 
            // colBASE_UNIT
            // 
            this.colBASE_UNIT.FieldName = "BASE_UNIT";
            this.colBASE_UNIT.Name = "colBASE_UNIT";
            this.colBASE_UNIT.Visible = true;
            this.colBASE_UNIT.VisibleIndex = 7;
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
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            // 
            // workOrderBomModelBindingSource
            // 
            this.workOrderBomModelBindingSource.DataSource = typeof(BPack.Model.App.PC.WorkOrder.WorkOrderBomModel);
            // 
            // colIS_PHANTOM
            // 
            this.colIS_PHANTOM.FieldName = "IS_PHANTOM";
            this.colIS_PHANTOM.Name = "colIS_PHANTOM";
            this.colIS_PHANTOM.Visible = true;
            this.colIS_PHANTOM.VisibleIndex = 8;
            // 
            // WorkBomTreeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 501);
            this.Controls.Add(this.strapTreeList1);
            this.Name = "WorkBomTreeList";
            ((System.ComponentModel.ISupportInitialize)(this.strapTreeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBomModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.TreeList.StrapTreeList strapTreeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLV;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCOMP_CD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPLANT_CD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVALIDT_DT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colP_ITEM_CD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colITEM_CD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colITEM_NM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colITEM_SPEC;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colITEM_TYPE;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colITEM_GR_1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBOM_QTY;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBASE_UNIT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colVALID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colREMARK;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSORT_NO;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colROW_SEQ;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCREATE_DTTM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCREATE_USER_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMODIFY_DTTM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMODIFY_USER_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLANG_CODE;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRowState;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCrudCls;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSelectedCheck;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsCheck;
        private System.Windows.Forms.BindingSource workOrderBomModelBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIS_PHANTOM;
    }
}

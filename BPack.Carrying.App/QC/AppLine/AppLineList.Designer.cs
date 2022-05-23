namespace BPack.Carrying.App.QC.AppLine
{
    partial class AppLineList
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
            this.components = new System.ComponentModel.Container();
            this.strapLayout1 = new BPack.Strap.Layout.StrapLayout();
            this.btnCancle = new BPack.Strap.EditControls.StrapButton();
            this.btnAdd = new BPack.Strap.EditControls.StrapButton();
            this.strapGridControl1 = new BPack.Strap.Grid.StrapGridControl();
            this.AppLineModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAPP_LINE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPP_USER_ID_REQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPP_USER_ID_REV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAPP_USER_ID_APP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODIFY_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSearch = new BPack.Strap.EditControls.StrapButton();
            this.btnDelete = new BPack.Strap.EditControls.StrapButton();
            this.btnSave = new BPack.Strap.EditControls.StrapButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.strapLayout1)).BeginInit();
            this.strapLayout1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppLineModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapLayout1
            // 
            this.strapLayout1.AllowCustomization = false;
            this.strapLayout1.Controls.Add(this.btnCancle);
            this.strapLayout1.Controls.Add(this.btnAdd);
            this.strapLayout1.Controls.Add(this.strapGridControl1);
            this.strapLayout1.Controls.Add(this.btnSearch);
            this.strapLayout1.Controls.Add(this.btnDelete);
            this.strapLayout1.Controls.Add(this.btnSave);
            this.strapLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapLayout1.Location = new System.Drawing.Point(0, 0);
            this.strapLayout1.Name = "strapLayout1";
            this.strapLayout1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1250, 268, 650, 400);
            this.strapLayout1.Root = this.Root;
            this.strapLayout1.Size = new System.Drawing.Size(698, 468);
            this.strapLayout1.TabIndex = 0;
            this.strapLayout1.Text = "strapLayout1";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(586, 12);
            this.btnCancle.MaximumSize = new System.Drawing.Size(100, 0);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(100, 22);
            this.btnCancle.StyleController = this.strapLayout1;
            this.btnCancle.TabIndex = 13;
            this.btnCancle.Text = "닫기";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 12);
            this.btnAdd.MaximumSize = new System.Drawing.Size(100, 0);
            this.btnAdd.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 22);
            this.btnAdd.StyleController = this.strapLayout1;
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "추가(F3)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.AppLineModelBindingSource;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(15, 62);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(668, 391);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 11;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // AppLineModelBindingSource
            // 
            this.AppLineModelBindingSource.DataSource = typeof(BPack.Model.App.QC.AppLine.AppLineModel);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAPP_LINE_NO,
            this.colAPP_USER_ID_REQ,
            this.colAPP_USER_ID_REV,
            this.colAPP_USER_ID_APP,
            this.colDEL_FG,
            this.colCREATE_DTTM,
            this.colMODIFY_DTTM,
            this.colCREATE_USER_ID,
            this.colMODIFY_USER_ID,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colAPP_LINE_NO
            // 
            this.colAPP_LINE_NO.FieldName = "APP_LINE_NO";
            this.colAPP_LINE_NO.Name = "colAPP_LINE_NO";
            this.colAPP_LINE_NO.OptionsColumn.ReadOnly = true;
            // 
            // colAPP_USER_ID_REQ
            // 
            this.colAPP_USER_ID_REQ.AppearanceCell.Options.UseTextOptions = true;
            this.colAPP_USER_ID_REQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAPP_USER_ID_REQ.Caption = "요청자";
            this.colAPP_USER_ID_REQ.FieldName = "APP_USER_ID_REQ";
            this.colAPP_USER_ID_REQ.Name = "colAPP_USER_ID_REQ";
            this.colAPP_USER_ID_REQ.OptionsColumn.AllowEdit = false;
            this.colAPP_USER_ID_REQ.OptionsColumn.ReadOnly = true;
            this.colAPP_USER_ID_REQ.Visible = true;
            this.colAPP_USER_ID_REQ.VisibleIndex = 1;
            // 
            // colAPP_USER_ID_REV
            // 
            this.colAPP_USER_ID_REV.AppearanceCell.Options.UseTextOptions = true;
            this.colAPP_USER_ID_REV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAPP_USER_ID_REV.Caption = "검토자";
            this.colAPP_USER_ID_REV.FieldName = "APP_USER_ID_REV";
            this.colAPP_USER_ID_REV.Name = "colAPP_USER_ID_REV";
            this.colAPP_USER_ID_REV.Visible = true;
            this.colAPP_USER_ID_REV.VisibleIndex = 2;
            // 
            // colAPP_USER_ID_APP
            // 
            this.colAPP_USER_ID_APP.AppearanceCell.Options.UseTextOptions = true;
            this.colAPP_USER_ID_APP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAPP_USER_ID_APP.Caption = "승인자";
            this.colAPP_USER_ID_APP.FieldName = "APP_USER_ID_APP";
            this.colAPP_USER_ID_APP.Name = "colAPP_USER_ID_APP";
            this.colAPP_USER_ID_APP.Visible = true;
            this.colAPP_USER_ID_APP.VisibleIndex = 3;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
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
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(170, 12);
            this.btnSearch.MaximumSize = new System.Drawing.Size(100, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 22);
            this.btnSearch.StyleController = this.strapLayout1;
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "조회(F5)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(482, 12);
            this.btnDelete.MaximumSize = new System.Drawing.Size(100, 0);
            this.btnDelete.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 22);
            this.btnDelete.StyleController = this.strapLayout1;
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "삭제(F4)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 12);
            this.btnSave.MaximumSize = new System.Drawing.Size(100, 0);
            this.btnSave.MinimumSize = new System.Drawing.Size(100, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 22);
            this.btnSave.StyleController = this.strapLayout1;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "저장(F8)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem7,
            this.layoutControlItem10,
            this.emptySpaceItem3,
            this.layoutControlItem9,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(698, 468);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(678, 422);
            this.layoutControlGroup2.Text = "결재선";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.strapGridControl1;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(672, 395);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnSearch;
            this.layoutControlItem7.Location = new System.Drawing.Point(158, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnCancle;
            this.layoutControlItem10.Location = new System.Drawing.Point(574, 0);
            this.layoutControlItem10.MaxSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(158, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnAdd;
            this.layoutControlItem9.Location = new System.Drawing.Point(262, 0);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDelete;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem3.Location = new System.Drawing.Point(470, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem9";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSave;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem1.Location = new System.Drawing.Point(366, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem9";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // AppLineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 468);
            this.Controls.Add(this.strapLayout1);
            this.MinimizeBox = false;
            this.Name = "AppLineList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "결재선 관리";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AppLineList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.strapLayout1)).EndInit();
            this.strapLayout1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppLineModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BPack.Strap.Layout.StrapLayout strapLayout1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private BPack.Strap.EditControls.StrapButton btnSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private BPack.Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BPack.Strap.EditControls.StrapButton btnCancle;
        private BPack.Strap.EditControls.StrapButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private System.Windows.Forms.BindingSource AppLineModelBindingSource;
        private Strap.EditControls.StrapButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private Strap.EditControls.StrapButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colAPP_LINE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colAPP_USER_ID_REQ;
        private DevExpress.XtraGrid.Columns.GridColumn colAPP_USER_ID_REV;
        private DevExpress.XtraGrid.Columns.GridColumn colAPP_USER_ID_APP;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODIFY_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
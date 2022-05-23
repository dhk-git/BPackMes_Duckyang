
namespace BPack.Carrying.App.MM.MebLot
{
    partial class LPackAndMPackList
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
            this.strapGridControl1 = new BPack.Strap.Grid.StrapGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colPACK_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM_PACK_NO_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPACK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM_PACK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCASE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDER_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPART_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWORK_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSE_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEND_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAVE_DTTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCREATE_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAVE_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrudCls = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelectedCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.ArgsBase = null;
            this.strapGridControl1.DataSource = this.bindingSource1;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 450);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.StrapMdiForm = null;
            this.strapGridControl1.StrapSubForm = null;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPACK_NO_KEY,
            this.colM_PACK_NO_KEY,
            this.colPACK_NO,
            this.colM_PACK_NO,
            this.colCASE_NO,
            this.colORDER_NO,
            this.colPART_NO,
            this.colQTY,
            this.colLOT,
            this.colWORK_DATE,
            this.colUSE_YN,
            this.colSEND_YN,
            this.colCREATE_DTTM,
            this.colSAVE_DTTM,
            this.colCREATE_BY,
            this.colSAVE_BY,
            this.colRowState,
            this.colCrudCls,
            this.colSelectedCheck,
            this.colIsCheck});
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(BPack.Model.App.MM.MebLot.LPackAndMPackModel);
            // 
            // colPACK_NO_KEY
            // 
            this.colPACK_NO_KEY.FieldName = "PACK_NO_KEY";
            this.colPACK_NO_KEY.Name = "colPACK_NO_KEY";
            this.colPACK_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colPACK_NO_KEY.Visible = true;
            this.colPACK_NO_KEY.VisibleIndex = 0;
            // 
            // colM_PACK_NO_KEY
            // 
            this.colM_PACK_NO_KEY.FieldName = "M_PACK_NO_KEY";
            this.colM_PACK_NO_KEY.Name = "colM_PACK_NO_KEY";
            this.colM_PACK_NO_KEY.OptionsColumn.ReadOnly = true;
            this.colM_PACK_NO_KEY.Visible = true;
            this.colM_PACK_NO_KEY.VisibleIndex = 1;
            // 
            // colPACK_NO
            // 
            this.colPACK_NO.FieldName = "PACK_NO";
            this.colPACK_NO.Name = "colPACK_NO";
            this.colPACK_NO.Visible = true;
            this.colPACK_NO.VisibleIndex = 2;
            // 
            // colM_PACK_NO
            // 
            this.colM_PACK_NO.FieldName = "M_PACK_NO";
            this.colM_PACK_NO.Name = "colM_PACK_NO";
            this.colM_PACK_NO.Visible = true;
            this.colM_PACK_NO.VisibleIndex = 3;
            // 
            // colCASE_NO
            // 
            this.colCASE_NO.FieldName = "CASE_NO";
            this.colCASE_NO.Name = "colCASE_NO";
            this.colCASE_NO.Visible = true;
            this.colCASE_NO.VisibleIndex = 4;
            // 
            // colORDER_NO
            // 
            this.colORDER_NO.FieldName = "ORDER_NO";
            this.colORDER_NO.Name = "colORDER_NO";
            this.colORDER_NO.Visible = true;
            this.colORDER_NO.VisibleIndex = 5;
            // 
            // colPART_NO
            // 
            this.colPART_NO.FieldName = "PART_NO";
            this.colPART_NO.Name = "colPART_NO";
            this.colPART_NO.Visible = true;
            this.colPART_NO.VisibleIndex = 6;
            // 
            // colQTY
            // 
            this.colQTY.FieldName = "QTY";
            this.colQTY.Name = "colQTY";
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 7;
            // 
            // colLOT
            // 
            this.colLOT.FieldName = "LOT";
            this.colLOT.Name = "colLOT";
            this.colLOT.Visible = true;
            this.colLOT.VisibleIndex = 8;
            // 
            // colWORK_DATE
            // 
            this.colWORK_DATE.FieldName = "WORK_DATE";
            this.colWORK_DATE.Name = "colWORK_DATE";
            this.colWORK_DATE.Visible = true;
            this.colWORK_DATE.VisibleIndex = 9;
            // 
            // colUSE_YN
            // 
            this.colUSE_YN.FieldName = "USE_YN";
            this.colUSE_YN.Name = "colUSE_YN";
            this.colUSE_YN.Visible = true;
            this.colUSE_YN.VisibleIndex = 10;
            // 
            // colSEND_YN
            // 
            this.colSEND_YN.FieldName = "SEND_YN";
            this.colSEND_YN.Name = "colSEND_YN";
            this.colSEND_YN.Visible = true;
            this.colSEND_YN.VisibleIndex = 11;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 12;
            // 
            // colSAVE_DTTM
            // 
            this.colSAVE_DTTM.FieldName = "SAVE_DTTM";
            this.colSAVE_DTTM.Name = "colSAVE_DTTM";
            this.colSAVE_DTTM.Visible = true;
            this.colSAVE_DTTM.VisibleIndex = 13;
            // 
            // colCREATE_BY
            // 
            this.colCREATE_BY.FieldName = "CREATE_BY";
            this.colCREATE_BY.Name = "colCREATE_BY";
            this.colCREATE_BY.Visible = true;
            this.colCREATE_BY.VisibleIndex = 14;
            // 
            // colSAVE_BY
            // 
            this.colSAVE_BY.FieldName = "SAVE_BY";
            this.colSAVE_BY.Name = "colSAVE_BY";
            this.colSAVE_BY.Visible = true;
            this.colSAVE_BY.VisibleIndex = 15;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 16;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 17;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 18;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 19;
            // 
            // LPackAndMPackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "LPackAndMPackList";
            this.Text = "LPackAndMPackList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colPACK_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colM_PACK_NO_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colPACK_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colM_PACK_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCASE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colORDER_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colPART_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraGrid.Columns.GridColumn colLOT;
        private DevExpress.XtraGrid.Columns.GridColumn colWORK_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colUSE_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colSEND_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colSAVE_DTTM;
        private DevExpress.XtraGrid.Columns.GridColumn colCREATE_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colSAVE_BY;
        private DevExpress.XtraGrid.Columns.GridColumn colRowState;
        private DevExpress.XtraGrid.Columns.GridColumn colCrudCls;
        private DevExpress.XtraGrid.Columns.GridColumn colSelectedCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
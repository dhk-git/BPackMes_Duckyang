
namespace BPack.Carrying.App.MD.SomDevice
{
    partial class PlcInfoList
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
            this.plcInfoModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDVC_ID_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_GR_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_ID_KEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVC_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_GR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAG_NM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATA_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATA_LENGTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREAD_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWRITE_YN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUMMY_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUMMY_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDUMMY_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEL_FG = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colIsCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plcInfoModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // strapGridControl1
            // 
            this.strapGridControl1.DataSource = this.plcInfoModelBindingSource;
            this.strapGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strapGridControl1.IsStrapGridViewDefaultSetting = true;
            this.strapGridControl1.Location = new System.Drawing.Point(0, 0);
            this.strapGridControl1.MainView = this.gridView1;
            this.strapGridControl1.Name = "strapGridControl1";
            this.strapGridControl1.SelectedModel = null;
            this.strapGridControl1.SelectedModelIndex = null;
            this.strapGridControl1.Size = new System.Drawing.Size(800, 525);
            this.strapGridControl1.StrapEditMode = BPack.Strap.FormControls.StrapEditMode.Default;
            this.strapGridControl1.TabIndex = 0;
            this.strapGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // plcInfoModelBindingSource
            // 
            this.plcInfoModelBindingSource.DataSource = typeof(BPack.Model.App.MD.SomDevice.PlcInfoModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDVC_ID_KEY,
            this.colTAG_GR_KEY,
            this.colTAG_ID_KEY,
            this.colDVC_ID,
            this.colTAG_ID,
            this.colTAG_GR,
            this.colTAG_NM,
            this.colADDR,
            this.colDATA_TYPE,
            this.colDATA_LENGTH,
            this.colREAD_YN,
            this.colWRITE_YN,
            this.colDUMMY_1,
            this.colDUMMY_2,
            this.colDUMMY_3,
            this.colDEL_FG,
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
            this.gridView1.DetailHeight = 408;
            this.gridView1.GridControl = this.strapGridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colDVC_ID_KEY
            // 
            this.colDVC_ID_KEY.FieldName = "DVC_ID_KEY";
            this.colDVC_ID_KEY.Name = "colDVC_ID_KEY";
            this.colDVC_ID_KEY.OptionsColumn.ReadOnly = true;
            this.colDVC_ID_KEY.Visible = true;
            this.colDVC_ID_KEY.VisibleIndex = 0;
            // 
            // colTAG_GR_KEY
            // 
            this.colTAG_GR_KEY.FieldName = "TAG_GR_KEY";
            this.colTAG_GR_KEY.Name = "colTAG_GR_KEY";
            this.colTAG_GR_KEY.OptionsColumn.ReadOnly = true;
            this.colTAG_GR_KEY.Visible = true;
            this.colTAG_GR_KEY.VisibleIndex = 1;
            // 
            // colTAG_ID_KEY
            // 
            this.colTAG_ID_KEY.FieldName = "TAG_ID_KEY";
            this.colTAG_ID_KEY.Name = "colTAG_ID_KEY";
            this.colTAG_ID_KEY.OptionsColumn.ReadOnly = true;
            this.colTAG_ID_KEY.Visible = true;
            this.colTAG_ID_KEY.VisibleIndex = 2;
            // 
            // colDVC_ID
            // 
            this.colDVC_ID.FieldName = "DVC_ID";
            this.colDVC_ID.Name = "colDVC_ID";
            this.colDVC_ID.Visible = true;
            this.colDVC_ID.VisibleIndex = 3;
            // 
            // colTAG_ID
            // 
            this.colTAG_ID.FieldName = "TAG_ID";
            this.colTAG_ID.Name = "colTAG_ID";
            this.colTAG_ID.Visible = true;
            this.colTAG_ID.VisibleIndex = 4;
            // 
            // colTAG_GR
            // 
            this.colTAG_GR.FieldName = "TAG_GR";
            this.colTAG_GR.Name = "colTAG_GR";
            this.colTAG_GR.Visible = true;
            this.colTAG_GR.VisibleIndex = 5;
            // 
            // colTAG_NM
            // 
            this.colTAG_NM.FieldName = "TAG_NM";
            this.colTAG_NM.Name = "colTAG_NM";
            this.colTAG_NM.Visible = true;
            this.colTAG_NM.VisibleIndex = 6;
            // 
            // colADDR
            // 
            this.colADDR.FieldName = "ADDR";
            this.colADDR.Name = "colADDR";
            this.colADDR.Visible = true;
            this.colADDR.VisibleIndex = 7;
            // 
            // colDATA_TYPE
            // 
            this.colDATA_TYPE.FieldName = "DATA_TYPE";
            this.colDATA_TYPE.Name = "colDATA_TYPE";
            this.colDATA_TYPE.Visible = true;
            this.colDATA_TYPE.VisibleIndex = 8;
            // 
            // colDATA_LENGTH
            // 
            this.colDATA_LENGTH.FieldName = "DATA_LENGTH";
            this.colDATA_LENGTH.Name = "colDATA_LENGTH";
            this.colDATA_LENGTH.Visible = true;
            this.colDATA_LENGTH.VisibleIndex = 9;
            // 
            // colREAD_YN
            // 
            this.colREAD_YN.FieldName = "READ_YN";
            this.colREAD_YN.Name = "colREAD_YN";
            this.colREAD_YN.Visible = true;
            this.colREAD_YN.VisibleIndex = 10;
            // 
            // colWRITE_YN
            // 
            this.colWRITE_YN.FieldName = "WRITE_YN";
            this.colWRITE_YN.Name = "colWRITE_YN";
            this.colWRITE_YN.Visible = true;
            this.colWRITE_YN.VisibleIndex = 11;
            // 
            // colDUMMY_1
            // 
            this.colDUMMY_1.FieldName = "DUMMY_1";
            this.colDUMMY_1.Name = "colDUMMY_1";
            this.colDUMMY_1.Visible = true;
            this.colDUMMY_1.VisibleIndex = 12;
            // 
            // colDUMMY_2
            // 
            this.colDUMMY_2.FieldName = "DUMMY_2";
            this.colDUMMY_2.Name = "colDUMMY_2";
            this.colDUMMY_2.Visible = true;
            this.colDUMMY_2.VisibleIndex = 13;
            // 
            // colDUMMY_3
            // 
            this.colDUMMY_3.FieldName = "DUMMY_3";
            this.colDUMMY_3.Name = "colDUMMY_3";
            this.colDUMMY_3.Visible = true;
            this.colDUMMY_3.VisibleIndex = 14;
            // 
            // colDEL_FG
            // 
            this.colDEL_FG.FieldName = "DEL_FG";
            this.colDEL_FG.Name = "colDEL_FG";
            this.colDEL_FG.Visible = true;
            this.colDEL_FG.VisibleIndex = 15;
            // 
            // colVALID
            // 
            this.colVALID.FieldName = "VALID";
            this.colVALID.Name = "colVALID";
            this.colVALID.Visible = true;
            this.colVALID.VisibleIndex = 16;
            // 
            // colREMARK
            // 
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 17;
            // 
            // colSORT_NO
            // 
            this.colSORT_NO.FieldName = "SORT_NO";
            this.colSORT_NO.Name = "colSORT_NO";
            this.colSORT_NO.Visible = true;
            this.colSORT_NO.VisibleIndex = 18;
            // 
            // colROW_SEQ
            // 
            this.colROW_SEQ.FieldName = "ROW_SEQ";
            this.colROW_SEQ.Name = "colROW_SEQ";
            this.colROW_SEQ.OptionsColumn.ReadOnly = true;
            this.colROW_SEQ.Visible = true;
            this.colROW_SEQ.VisibleIndex = 19;
            // 
            // colCREATE_DTTM
            // 
            this.colCREATE_DTTM.FieldName = "CREATE_DTTM";
            this.colCREATE_DTTM.Name = "colCREATE_DTTM";
            this.colCREATE_DTTM.OptionsColumn.ReadOnly = true;
            this.colCREATE_DTTM.Visible = true;
            this.colCREATE_DTTM.VisibleIndex = 20;
            // 
            // colCREATE_USER_ID
            // 
            this.colCREATE_USER_ID.FieldName = "CREATE_USER_ID";
            this.colCREATE_USER_ID.Name = "colCREATE_USER_ID";
            this.colCREATE_USER_ID.OptionsColumn.ReadOnly = true;
            this.colCREATE_USER_ID.Visible = true;
            this.colCREATE_USER_ID.VisibleIndex = 21;
            // 
            // colMODIFY_DTTM
            // 
            this.colMODIFY_DTTM.FieldName = "MODIFY_DTTM";
            this.colMODIFY_DTTM.Name = "colMODIFY_DTTM";
            this.colMODIFY_DTTM.OptionsColumn.ReadOnly = true;
            this.colMODIFY_DTTM.Visible = true;
            this.colMODIFY_DTTM.VisibleIndex = 22;
            // 
            // colMODIFY_USER_ID
            // 
            this.colMODIFY_USER_ID.FieldName = "MODIFY_USER_ID";
            this.colMODIFY_USER_ID.Name = "colMODIFY_USER_ID";
            this.colMODIFY_USER_ID.OptionsColumn.ReadOnly = true;
            this.colMODIFY_USER_ID.Visible = true;
            this.colMODIFY_USER_ID.VisibleIndex = 23;
            // 
            // colLANG_CODE
            // 
            this.colLANG_CODE.FieldName = "LANG_CODE";
            this.colLANG_CODE.Name = "colLANG_CODE";
            this.colLANG_CODE.OptionsColumn.ReadOnly = true;
            this.colLANG_CODE.Visible = true;
            this.colLANG_CODE.VisibleIndex = 24;
            // 
            // colRowState
            // 
            this.colRowState.FieldName = "RowState";
            this.colRowState.Name = "colRowState";
            this.colRowState.Visible = true;
            this.colRowState.VisibleIndex = 25;
            // 
            // colCrudCls
            // 
            this.colCrudCls.FieldName = "CrudCls";
            this.colCrudCls.Name = "colCrudCls";
            this.colCrudCls.OptionsColumn.ReadOnly = true;
            this.colCrudCls.Visible = true;
            this.colCrudCls.VisibleIndex = 26;
            // 
            // colSelectedCheck
            // 
            this.colSelectedCheck.FieldName = "SelectedCheck";
            this.colSelectedCheck.Name = "colSelectedCheck";
            this.colSelectedCheck.Visible = true;
            this.colSelectedCheck.VisibleIndex = 27;
            // 
            // colIsCheck
            // 
            this.colIsCheck.FieldName = "IsCheck";
            this.colIsCheck.Name = "colIsCheck";
            this.colIsCheck.Visible = true;
            this.colIsCheck.VisibleIndex = 28;
            // 
            // PlcInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.strapGridControl1);
            this.Name = "PlcInfoList";
            this.Text = "PlcInfoList";
            ((System.ComponentModel.ISupportInitialize)(this.strapGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plcInfoModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Strap.Grid.StrapGridControl strapGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource plcInfoModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDVC_ID_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_GR_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_ID_KEY;
        private DevExpress.XtraGrid.Columns.GridColumn colDVC_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_GR;
        private DevExpress.XtraGrid.Columns.GridColumn colTAG_NM;
        private DevExpress.XtraGrid.Columns.GridColumn colADDR;
        private DevExpress.XtraGrid.Columns.GridColumn colDATA_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATA_LENGTH;
        private DevExpress.XtraGrid.Columns.GridColumn colREAD_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colWRITE_YN;
        private DevExpress.XtraGrid.Columns.GridColumn colDUMMY_1;
        private DevExpress.XtraGrid.Columns.GridColumn colDUMMY_2;
        private DevExpress.XtraGrid.Columns.GridColumn colDUMMY_3;
        private DevExpress.XtraGrid.Columns.GridColumn colDEL_FG;
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
        private DevExpress.XtraGrid.Columns.GridColumn colIsCheck;
    }
}
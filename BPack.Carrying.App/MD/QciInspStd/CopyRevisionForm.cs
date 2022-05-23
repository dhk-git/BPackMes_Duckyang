using System;
using System.Linq;
using BPack.Strap.FormControls;
using BPack.Common.Pocket;
using BPack.Common.LoginInfo;
using BPack.Model.App.MD.QciInspStd;
using BPack.CommonMes.Helpers;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.QciInspStd
{
    public partial class CopyRevisionForm : StrapMdiForm
    {
        private QciInspStdArgs _qciInspStdArgs;
        private InspectionRevisionModel _inspectionRevisionModel;

        public CopyRevisionForm(QciInspStdArgs qciInspStdArgs)
        {
            InitializeComponent();

            _qciInspStdArgs = qciInspStdArgs;

            LookUpEditHelper.SetSysCode(strapLookUpEdit1, "INSP_TYPE", false);
            LookUpEditHelper.SetSysCode(strapLookUpEdit2, "INSP_TYPE", false);

            this.KeyPreview = true;
        }

        public void DataRefresh(InspectionRevisionModel inspectionRevisionModel)
        {
            _inspectionRevisionModel = inspectionRevisionModel;

            strapLookUpEdit1.EditValue = _inspectionRevisionModel.INSP_TYPE;
            strapTextEdit1.Text = _inspectionRevisionModel.ITEM_CD;
            strapTextEdit2.Text = _inspectionRevisionModel.ITEM_NM;
            strapTextEdit3.Text = _inspectionRevisionModel.ALC_CD;
            strapTextEdit4.Text = _inspectionRevisionModel.INSP_STD_ID;
            strapTextEdit5.Text = _inspectionRevisionModel.REVISION.ToString();

            strapButtonEdit_ItemMaster1.InitStrap();
            strapButtonEdit_ItemMaster1.InitCompCode(_inspectionRevisionModel.COMP_CD);
            strapButtonEdit_ItemMaster1.InitPlantCode(_inspectionRevisionModel.PLANT_CD);

            strapLookUpEdit2.EditValue = _inspectionRevisionModel.INSP_TYPE;
            strapButtonEdit_ItemMaster1.EditValue = _inspectionRevisionModel.ITEM_CD;
            strapDateEdit1.DateTime = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var msgResult = StrapMessageBox.Show("A001", 34, messageBoxButtons: MessageBoxButtons.YesNo);
            if (msgResult != DialogResult.Yes) return;

            if (!String.IsNullOrEmpty(_qciInspStdArgs.QciInspStdModelArgs.Select_Revision_Revision.ToString()))
            {
                var sp = SimplePocket.GetInstance();
                sp.SimplePocketExecute("MD.QciInspStd.Revision.Copy", new
                {
                    @INSP_TYPE = strapLookUpEdit2.EditValue,
                    @ITEM_CD = strapButtonEdit_ItemMaster1.EditValue,

                    @INSP_STD_ID_KEY = _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Insp_Std_ID,
                    @REVISION = _qciInspStdArgs.QciInspStdModelArgs.Select_Revision_Revision,

                    @USER_ID = UserInfo.UserID,
                    @LANG_CODE = UserInfo.Sys_Language,
                    @VALID_FROM_DT = strapDateEdit1.DateTime.ToShortDateString()
                });
                StrapMessageBox.Show("A001", 36);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void strapLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            SearchRevisionInfo();
        }

        private void strapButtonEdit_ItemMaster1_EditValueChanged(object sender, EventArgs e)
        {
            SearchRevisionInfo();
        }

        private void SearchRevisionInfo()
        {
            var sp = SimplePocket.GetInstance();
            var row = sp.SelectData("CheckListInfo_Revision", new

            {
                COMP_CD = _inspectionRevisionModel.COMP_CD,
                PLANT_CD = _inspectionRevisionModel.PLANT_CD,
                ITEM_CD = strapButtonEdit_ItemMaster1.EditValue,
                INSP_STD_ID_KEY = _inspectionRevisionModel.INSP_STD_ID_KEY,
                INSP_TYPE = strapLookUpEdit2.EditValue
            }).Select().FirstOrDefault();

            if (row != null)
            {
                strapTextEdit6.EditValue = row["ITEM_NM"]?.ToString();
                strapTextEdit7.EditValue = row["ALC_CD"]?.ToString();
                strapTextEdit8.EditValue = row["INSP_STD_ID"]?.ToString();
                strapTextEdit9.EditValue = row["MAX_REVISION"]?.ToString();
            }
        }

        private void CopyRevisionForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (e.Modifiers == Keys.Control)
                    {
                        this.Close();
                        btnSave_Click(btnSave, null);
                    }
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
}

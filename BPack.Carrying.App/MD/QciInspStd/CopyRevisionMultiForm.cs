using System;
using System.Windows.Forms;
using BPack.Strap.FormControls;
using BPack.Common.Pocket;
using BPack.Model.App.MD.QciInspStd;
using BPack.CommonMes.Helpers;
using System.Linq;
using BPack.Common.LoginInfo;

namespace BPack.Carrying.App.MD.QciInspStd
{
    public partial class CopyRevisionMultiForm : StrapMdiForm
    {
        private QciInspStdArgs _qciInspStdArgs;
        private InspectionRevisionModel _inspectionRevisionModel;

        public CopyRevisionMultiForm(QciInspStdArgs qciInspStdArgs)
        {
            InitializeComponent();

            _qciInspStdArgs = qciInspStdArgs;

            LookUpEditHelper.SetSysCode(lueSourceInspType, "INSP_TYPE");
            LookUpEditHelper.SetSysCode(lueTargeInspType, "INSP_TYPE");
            LookUpEditHelper.SetByQuery(lueItemType, "ItemType", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD }, "품목유형코드", "품목유형명", isTotalRow: true);
            LookUpEditHelper.SetByQuery(lueItemGr1, "ItemGroupDetail", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명", isTotalRow: true);
            LookUpEditHelper.SetByQuery(lueItemGr2, "ItemGroupDetail", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD, ITEM_GR_CLS = "ITEM_GR_2" }, "제품군", "제품군명", isTotalRow: true); ;
            LookUpEditHelper.SetByQuery(lueItemGr3, "ItemGroupDetail", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD, ITEM_GR_CLS = "ITEM_GR_3" }, "서열유형", "서열유형명", isTotalRow: true);

            LookUpEditHelper.SetGridColumnByQuery(colITEM_TYPE, "ItemType", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD }, "품목유형코드", "품목유형명");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_1, "ItemGroupDetail", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD, ITEM_GR_CLS = "ITEM_GR_1" }, "차종", "차종명");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_2, "ItemGroupDetail", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD, ITEM_GR_CLS = "ITEM_GR_2" }, "제품군", "제품군명");
            LookUpEditHelper.SetGridColumnByQuery(colITEM_GR_3, "ItemGroupDetail", new { COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD, PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD, ITEM_GR_CLS = "ITEM_GR_3" }, "서열유형", "서열유형명");

            this.KeyPreview = true;
        }

        public void DataRefresh(InspectionRevisionModel inspectionRevisionModel)
        {
            _inspectionRevisionModel = inspectionRevisionModel;

            lueSourceInspType.EditValue = _inspectionRevisionModel.INSP_TYPE;
            txtSourceItemCd.Text = _inspectionRevisionModel.ITEM_CD;
            txtSourceItemNm.Text = _inspectionRevisionModel.ITEM_NM;
            txtSourceAlc.Text = _inspectionRevisionModel.ALC_CD;
            txtSourceInspStdId.Text = _inspectionRevisionModel.INSP_STD_ID;
            txtSourceRevision.Text = _inspectionRevisionModel.REVISION.ToString();

            lueTargeInspType.EditValue = _inspectionRevisionModel.INSP_TYPE;
            dteTargetValidFormDt.DateTime = DateTime.Now;

            SearchItem();
        }

        public void SearchItem()
        {
            var sp = SimplePocket.GetInstance();
            var source = sp.SelectData<ItemModel>("MD.QciInspStd.Revision.Item.Select", new
            {
                COMP_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Comp_CD,
                PLANT_CD = _qciInspStdArgs.QciInspStdModelArgs.Select_Main_Plant_CD,
                ITEM_GR_1 = lueItemGr1.EditValue?.ToString(),
                ITEM_GR_2 = lueItemGr2.EditValue?.ToString(),
                ITEM_GR_3 = lueItemGr3.EditValue?.ToString(),
                ITEM_TYPE = lueItemType.EditValue?.ToString(),
                ITEM_CD = txtItemCd.EditValue?.ToString(),
                ITEM_NM = txtItemNm.EditValue?.ToString(),
                ALC_CD = txtTargetAlc.EditValue?.ToString()
            });

            grdItem.DataSource = source.Where(r => r.ITEM_CD != _inspectionRevisionModel.ITEM_CD);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = grvItem.GetSelectedRows();
                if (rows == null || rows.Count() == 0)
                {
                    StrapMessageBox.Show("A001", 9);
                    return;
                }

                var msgResult = StrapMessageBox.Show("A001", 34, messageBoxButtons: MessageBoxButtons.YesNo);
                if (msgResult != DialogResult.Yes) return;

                string itemCodeList = "";
                foreach (var idx in rows)
                {
                    var row = grvItem.GetRow(idx) as ItemModel;
                    if (row != null)
                    {
                        if (itemCodeList.Length > 0) itemCodeList += "^#^";
                        itemCodeList += row.ITEM_CD;
                    }
                }

                if (!String.IsNullOrEmpty(_qciInspStdArgs.QciInspStdModelArgs.Select_Revision_Revision.ToString()))
                {
                    var sp = SimplePocket.GetInstance();
                    sp.SimplePocketExecute("MD.QciInspStd.Revision.Copy.Multi", new
                    {
                        @USER_ID = UserInfo.UserID,
                        @LANG_CODE = UserInfo.Sys_Language,

                        @INSP_TYPE = lueTargeInspType.EditValue,
                        @INSP_STD_ID = _qciInspStdArgs.QciInspStdModelArgs.Select_Standard_Insp_Std_ID,
                        @REVISION = _qciInspStdArgs.QciInspStdModelArgs.Select_Revision_Revision,

                        @ITEM_CD_LIST = itemCodeList,
                        @VALID_FROM_DT = (dteTargetValidFormDt.Text == "" ? null  : dteTargetValidFormDt.DateTime.ToShortDateString())
                    });
                    StrapMessageBox.Show("A001", 36);
                }
            }
            catch(Exception ex)
            {
                StrapMessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void CopyRevisionMultiForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F5:
                    SearchItem();
                    break;
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

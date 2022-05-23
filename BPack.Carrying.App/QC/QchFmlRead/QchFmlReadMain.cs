using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchFmlRead;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.QchFmlRead;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BPack.Report.App.Factory;

namespace BPack.Carrying.App.QC.QchFmlRead
{
    public partial class QchFmlReadMain : StrapMainForm
    {
        private QchFmlReadArgs _qchFmlReadArgs;
        private QchFmlReadPocket _qchFmlReadPocket;
        private QchFmlReadHeaderList _qchFmlReadHeaderList;
        private QchFmlReadDetailList _qchFmlReadDetailList;
        private HandlingUnitReportFactory rf = HandlingUnitReportFactory.GetInstance();

        public QchFmlReadMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _qchFmlReadArgs = new QchFmlReadArgs();
            _qchFmlReadPocket = new QchFmlReadPocket();
            _qchFmlReadHeaderList = new QchFmlReadHeaderList(_qchFmlReadArgs, _qchFmlReadPocket);
            _qchFmlReadDetailList = new QchFmlReadDetailList(_qchFmlReadArgs, _qchFmlReadPocket);

            AddSubForm(this, _qchFmlReadHeaderList, layoutControlGroup2);
            AddSubForm(this, _qchFmlReadDetailList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _qchFmlReadArgs,
                InitlistForm = _qchFmlReadHeaderList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetSysCode(strapLookUpEdit6, "INSP_JUDGE", isFirstSelect: true);
            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
            strapButtonEdit_ItemMaster1.InitStrap();

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);

                strapButtonEdit_ItemMaster1.InitCompCode(strapLookUpEdit1.EditValue?.ToString());
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetByQuery(strapLookUpEdit3, "ShiftList", new { COMP_CD = strapLookUpEdit1.EditValue?.ToString(), PLANT_CD = strapLookUpEdit2.EditValue?.ToString() }, "근무조코드", "근무조명", isTotalRow: true, isFirstSelect: true);
                LookUpEditHelper.SetByQuery(strapLookUpEdit4, "CoreSettingsWorkCenterList", new { COMP_CD = strapLookUpEdit1.EditValue?.ToString(), PLANT_CD = strapLookUpEdit2.EditValue?.ToString() }, "작업장코드", "작업장명", isTotalRow: true, isFirstSelect: true);
                LookUpEditHelper.SetByQuery(strapLookUpEdit5, "ItemGroup_WithCode", new { COMP_CD = strapLookUpEdit1.EditValue?.ToString(), PLANT_CD = strapLookUpEdit2.EditValue?.ToString(), ITEM_GR_CLS = "ITEM_GR_1" }, "코드", "차종명", isTotalRow: true, isFirstSelect: true);

                strapButtonEdit_ItemMaster1.InitPlantCode(strapLookUpEdit2.EditValue?.ToString());
            };

            _qchFmlReadHeaderList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _qchFmlReadArgs.QchFmlReadModelArgs.Select_Insp_No = ((QchFmlReadHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).INSP_NO;

                _qchFmlReadDetailList.DataRefresh(_qchFmlReadArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _qchFmlReadHeaderList) { SetRibbonButtonsEnable_ByAuth(add: false, save: true, edit: false, delete: false); }
                if (this.SelectedSubForm == _qchFmlReadDetailList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_WorkOrderDate_From = strapDateEdit1.DateTime.ToShortDateString();
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_WorkOrderDate_To = strapDateEdit2.DateTime.ToShortDateString();
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Shift_CD = strapLookUpEdit3.EditValue?.ToString();
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_WorkCenter_CD = strapLookUpEdit4.EditValue?.ToString();
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_ItemGroup_CD = strapLookUpEdit5.EditValue?.ToString();
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Item_CD = strapButtonEdit_ItemMaster1.EditValue?.ToString();

            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Insp_Judge = strapLookUpEdit6.EditValue?.ToString();

            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Insp_Sub_Type_F = checkEdit1.Checked == true ? "F" : "";
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Insp_Sub_Type_M = checkEdit2.Checked == true ? "M" : "";
            _qchFmlReadArgs.QchFmlReadModelArgs.Select_Main_Insp_Sub_Type_L = checkEdit3.Checked == true ? "L" : "";

            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void strapButton1_Click(object sender, EventArgs e)
        {
            var btn = sender as DevExpress.XtraEditors.SimpleButton;

            var checkedHeader = ((List<QchFmlReadHeaderModel>)_qchFmlReadHeaderList.SelectedModels).Where(r => r.IsCheck).ToList();
            if (checkedHeader == null || checkedHeader.Count == 0)
            {
                StrapMessageBox.Show("A001", 9);
                return;
            }
            var inspNoList = checkedHeader.Select(r => r.INSP_NO).ToList();
            rf.HandlingUnit_FmlTag(inspNoList, Report.App.Common.PaperKind.A5).ShowPreviewDialog();

        }
    }
}

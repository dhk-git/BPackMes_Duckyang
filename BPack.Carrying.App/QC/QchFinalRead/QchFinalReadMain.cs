using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchFinalRead;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.QchFinalRead;
using System;
using System.Linq;

namespace BPack.Carrying.App.QC.QchFinalRead
{
    public partial class QchFinalReadMain : StrapMainForm
    {
        private QchFinalReadArgs _qchFmlReadArgs;
        private QchFinalReadPocket _qchFmlReadPocket;
        private QchFinalReadHeaderList _qchFmlReadHeaderList;
        private QchFinalReadDetailList _qchFmlReadDetailList;

        public QchFinalReadMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _qchFmlReadArgs = new QchFinalReadArgs();
            _qchFmlReadPocket = new QchFinalReadPocket();
            _qchFmlReadHeaderList = new QchFinalReadHeaderList(_qchFmlReadArgs, _qchFmlReadPocket);
            _qchFmlReadDetailList = new QchFinalReadDetailList(_qchFmlReadArgs, _qchFmlReadPocket);

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
                _qchFmlReadArgs.QchFinalReadModelArgs.Select_Insp_No = ((QchFinalReadHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).INSP_NO;

                _qchFmlReadDetailList.DataRefresh(_qchFmlReadArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _qchFmlReadHeaderList) { SetRibbonButtonsEnable_ByAuth(add: false, save: true, edit: false, delete: false); }
                if (this.SelectedSubForm == _qchFmlReadDetailList) { SetRibbonButtonsEnable_ByAuth(add: false, save: true, edit: true, delete: false); }
            };

            _qchFmlReadDetailList.modelValueChanged += (object sender, System.Collections.Generic.List<QchFinalReadDetailModel> e) =>
            {
                var ngModel = e.Where(r => r.INSP_JUDGE_QC == "NG").Count();

                var curModel = _qchFmlReadHeaderList.GetFocusedRow();
                if (ngModel > 0)
                {
                    curModel.INSP_JUDGE_QC = "NG";
                }
                else
                {
                    curModel.INSP_JUDGE_QC = "OK";
                }
                _qchFmlReadHeaderList.RowRefresh();
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _qchFmlReadArgs.QchFinalReadModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _qchFmlReadArgs.QchFinalReadModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            _qchFmlReadArgs.QchFinalReadModelArgs.Select_Main_WorkOrderDate_From = strapDateEdit1.DateTime.ToShortDateString();
            _qchFmlReadArgs.QchFinalReadModelArgs.Select_Main_WorkOrderDate_To = strapDateEdit2.DateTime.ToShortDateString();
            _qchFmlReadArgs.QchFinalReadModelArgs.Select_Main_Shift_CD = strapLookUpEdit3.EditValue?.ToString();
            _qchFmlReadArgs.QchFinalReadModelArgs.Select_Main_WorkCenter_CD = strapLookUpEdit4.EditValue?.ToString();
            _qchFmlReadArgs.QchFinalReadModelArgs.Select_Main_ItemGroup_CD = strapLookUpEdit5.EditValue?.ToString();
            _qchFmlReadArgs.QchFinalReadModelArgs.Select_Main_Item_CD = strapButtonEdit_ItemMaster1.EditValue?.ToString();

            _qchFmlReadArgs.QchFinalReadModelArgs.Select_Main_Insp_Judge = strapLookUpEdit6.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}

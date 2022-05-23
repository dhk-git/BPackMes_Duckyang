using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.QchPatrolRead;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.QchPatrolRead;
using System;
using System.Linq;

namespace BPack.Carrying.App.QC.QchPatrolRead
{
    public partial class QchPatrolReadMain : StrapMainForm
    {
        private QchPatrolReadArgs _qchPatrolReadArgs;
        private QchPatrolReadPocket _qchPatrolReadPocket;
        private QchPatrolReadHeaderList _qchPatrolReadHeaderList;
        private QchPatrolReadDetailList _qchPatrolReadDetailList;

        public QchPatrolReadMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _qchPatrolReadArgs = new QchPatrolReadArgs();
            _qchPatrolReadPocket = new QchPatrolReadPocket();
            _qchPatrolReadHeaderList = new QchPatrolReadHeaderList(_qchPatrolReadArgs, _qchPatrolReadPocket);
            _qchPatrolReadDetailList = new QchPatrolReadDetailList(_qchPatrolReadArgs, _qchPatrolReadPocket);

            AddSubForm(this, _qchPatrolReadHeaderList, layoutControlGroup2);
            AddSubForm(this, _qchPatrolReadDetailList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _qchPatrolReadArgs,
                InitlistForm = _qchPatrolReadHeaderList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetSysCode(strapLookUpEdit6, "INSP_JUDGE", isFirstSelect: true);
            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
            strapButtonEdit_ItemMaster1.InitStrap();

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD }, isFirstSelect: true);

                strapButtonEdit_ItemMaster1.InitCompCode(_qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD);
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
                LookUpEditHelper.SetWareHouse(strapLookUpEdit3, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Plant_CD, isTotalRow: true, isFirstSelect: true);

                strapButtonEdit_ItemMaster1.InitPlantCode(strapLookUpEdit2.EditValue?.ToString());
            };

            strapLookUpEdit3.EditValueChanged += (object sender, EventArgs e) =>
            {
                _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Warehouse_CD = strapLookUpEdit3.EditValue?.ToString();

                LookUpEditHelper.SetLocation(strapLookUpEdit4, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Plant_CD, _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Warehouse_CD, isTotalRow: true, isFirstSelect: true);
                LookUpEditHelper.SetByQuery(strapLookUpEdit5, "ItemGroup_WithCode", new { COMP_CD = _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD, PLANT_CD = _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Plant_CD, ITEM_GR_CLS = "ITEM_GR_1" }, "코드", "차종명", isTotalRow: true, isFirstSelect: true);

                strapButtonEdit_ItemMaster1.InitPlantCode(strapLookUpEdit2.EditValue?.ToString());
            };

            strapLookUpEdit4.EditValueChanged += (object sender, EventArgs e) =>
            {
                _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Location_CD = strapLookUpEdit4.EditValue?.ToString();
            };

            _qchPatrolReadHeaderList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Header_Insp_No = ((QchPatrolReadHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).INSP_NO;

                _qchPatrolReadDetailList.DataRefresh(_qchPatrolReadArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _qchPatrolReadHeaderList) { SetRibbonButtonsEnable_ByAuth(add: false, save: true, edit: false, delete: false); }
                if (this.SelectedSubForm == _qchPatrolReadDetailList) { SetRibbonButtonsEnable_ByAuth(add: false, save: true, edit: true, delete: false); }
            };

            _qchPatrolReadDetailList.modelValueChanged += (object sender, System.Collections.Generic.List<QchPatrolReadDetailModel> e) =>
            {
                var ngModel = e.Where(r => r.INSP_JUDGE_QC == "NG").Count();

                var curModel = _qchPatrolReadHeaderList.GetFocusedRow();
                if (ngModel > 0)
                {
                    curModel.INSP_JUDGE_QC = "NG";
                }
                else
                {
                    curModel.INSP_JUDGE_QC = "OK";
                }
                _qchPatrolReadHeaderList.RowRefresh();
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_InspDate_From = strapDateEdit1.DateTime.ToShortDateString();
            _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_InspDate_To = strapDateEdit2.DateTime.ToShortDateString();
            _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Warehouse_CD = strapLookUpEdit3.EditValue?.ToString();
            _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Location_CD = strapLookUpEdit4.EditValue?.ToString();
            _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_ItemGroup_CD = strapLookUpEdit5.EditValue?.ToString();
            _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Item_CD = strapButtonEdit_ItemMaster1.EditValue?.ToString();
            _qchPatrolReadArgs.QchPatrolReadModelArgs.Select_Main_Insp_Judge = strapLookUpEdit6.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

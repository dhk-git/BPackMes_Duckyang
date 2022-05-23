using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrHist;
using BPack.Strap.FormControls;
using BPack.Pocket.App.QC.NcrHist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using BPack.Report.App.Factory;

namespace BPack.Carrying.App.QC.NcrHist
{
    public partial class NcrHistMain : StrapMainForm
    {
        private NcrHistArgs _ncrHistArgs;
        private NcrHistPocket _ncrHistPocket;
        private NcrHistHeaderList _ncrHistHeaderList;
        private NcrHistDetailList _ncrHistDetailList;

        private HandlingUnitReportFactory rf = HandlingUnitReportFactory.GetInstance();

        public NcrHistMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _ncrHistArgs = new NcrHistArgs();
            _ncrHistPocket = new NcrHistPocket();
            _ncrHistHeaderList = new NcrHistHeaderList(_ncrHistArgs, _ncrHistPocket);
            _ncrHistDetailList = new NcrHistDetailList(_ncrHistArgs, _ncrHistPocket);

            AddSubForm(this, _ncrHistHeaderList, layoutControlGroup2);
            AddSubForm(this, _ncrHistDetailList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _ncrHistArgs,
                InitlistForm = _ncrHistHeaderList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetSysCode(strapLookUpEdit6, "NCR_JUDGE", isFirstSelect: true);
            LookUpEditHelper.SetSysCode(strapLookUpEdit7, "ITEM_TYPE_CLS", isFirstSelect: true);
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
                LookUpEditHelper.SetByQuery(strapLookUpEdit5, "ItemGroup_WithCode", new { COMP_CD = strapLookUpEdit1.EditValue?.ToString(), PLANT_CD = strapLookUpEdit2.EditValue?.ToString(), ITEM_GR_CLS = "ITEM_GR_1" }, "작업장코드", "작업장명", isTotalRow: true, isFirstSelect: true);

                strapButtonEdit_ItemMaster1.InitPlantCode(strapLookUpEdit2.EditValue?.ToString());
            };


            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _ncrHistHeaderList) { SetRibbonButtonsEnable_ByAuth(add: false, save: true, edit: false, delete: false); }
            };

            _ncrHistHeaderList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _ncrHistArgs.NcrHistModelArgs.Select_Header_NcrNo = ((NcrHistHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).NCR_NO;
                _ncrHistArgs.NcrHistModelArgs.Select_Header_NcrStatus = ((NcrHistHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).NCR_STATUS;

                _ncrHistDetailList.DataRefresh(_ncrHistArgs);
            };

            _ncrHistDetailList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _ncrHistArgs.NcrHistModelArgs.Select_Detail_TrtFlag = ((NcrHistDetailModel)e.SelectedModelArgsBase.SelectedModelBase).TRT_FG;

                if (_ncrHistArgs.NcrHistModelArgs.Select_Header_NcrStatus == "END" && _ncrHistArgs.NcrHistModelArgs.Select_Detail_TrtFlag == "N")
                {
                    SetRibbonButtonsEnable_ByAuth(add: false, save: true, edit: true, delete: false);
                }
                else
                {
                    SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false);
                }
            };
            _ncrHistDetailList.ModelSavedEvent += (object sender, ArgsBase e) =>
            {
                _ncrHistHeaderList.DataRefresh(_ncrHistArgs);
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _ncrHistArgs.NcrHistModelArgs.Select_Main_CompCode = strapLookUpEdit1.EditValue?.ToString();
            _ncrHistArgs.NcrHistModelArgs.Select_Main_PlantCode = strapLookUpEdit2.EditValue?.ToString();
            _ncrHistArgs.NcrHistModelArgs.Select_Main_InspDateFrom = strapDateEdit1.DateTime.ToShortDateString();
            _ncrHistArgs.NcrHistModelArgs.Select_Main_InspDateTo = strapDateEdit2.DateTime.ToShortDateString();
            _ncrHistArgs.NcrHistModelArgs.Select_Main_ShiftCode = strapLookUpEdit3.EditValue?.ToString();
            _ncrHistArgs.NcrHistModelArgs.Select_Main_WorkCenterCode = strapLookUpEdit4.EditValue?.ToString();
            _ncrHistArgs.NcrHistModelArgs.Select_Main_ItemGroup1 = strapLookUpEdit5.EditValue?.ToString();
            _ncrHistArgs.NcrHistModelArgs.Select_Main_ItemCode = strapButtonEdit_ItemMaster1.EditValue?.ToString();

            _ncrHistArgs.NcrHistModelArgs.Select_Main_NcrStatus = strapLookUpEdit6.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void simpleButton_Click(object sender, EventArgs e)
        {
            var btn = sender as DevExpress.XtraEditors.SimpleButton;
            var reportType = btn.Tag?.ToString();

            var checkedHeader = ((List<NcrHistHeaderModel>)_ncrHistHeaderList.SelectedModels).Where(r => r.IsCheck).ToList();
            if (checkedHeader == null || checkedHeader.Count == 0)
            {
                StrapMessageBox.Show("A001", 9);
                return;
            }
            var ncrNoList = checkedHeader.Select(r => r.NCR_NO).ToList();

            switch (reportType)
            {
                case "A":
                case "B":
                case "C":   
                    rf.HandlingUnit_NcrTag(ncrNoList, reportType, Report.App.Common.PaperKind.A5).ShowPreviewDialog();
                    break;
                case "R":

                    var rejectEmpty = checkedHeader.Where(r => r.REJECT_QTY == 0).Count();
                    if (rejectEmpty > 0)
                    {
                        StrapMessageBox.Show("A001", 37);
                        return;
                    }

                    rf.HandlingUnit_NcrReturnTag(ncrNoList).ShowPreviewDialog();
                    break;
            }
        }
    }
}

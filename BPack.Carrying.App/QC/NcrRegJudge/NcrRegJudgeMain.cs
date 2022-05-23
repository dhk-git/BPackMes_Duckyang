using BPack.Carrying.App.QC.NcrRegJudge;
using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrRegJudge;
using BPack.Pocket.App.QC.NcrRegJudge;
using BPack.Report.App.Factory.Dy_HandlingUnit;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.NcrRegJudge
{
    public partial class NcrRegJudgeMain : StrapMainForm
    {
        private NcrRegJudgePocket _regPocket;
        private NcrRegJudgeArgs _JudgArgs;

        private NcrRegJudgeHeaderList _headerList;
        private NcrRegJudgeDetailList _detailList;
        public NcrRegJudgeMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _regPocket = new NcrRegJudgePocket();
            _JudgArgs = new NcrRegJudgeArgs();
            _headerList = new NcrRegJudgeHeaderList(_regPocket, _JudgArgs);
            _detailList = new NcrRegJudgeDetailList(_regPocket, _JudgArgs);
            AddSubForm(this, _headerList, layoutControlGroup2);
            AddSubForm(this, _detailList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _JudgArgs,
                InitlistForm = _headerList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, false, false, false, false);
            this.SelectedSubFormChanged += NcrRegJudgMain_SelectedSubFormChanged;

            LookUpEditHelper.SetCompCode(sleCompCd);
            LookUpEditHelper.SetSysCode(ctl_Judge_Result, "JUDGE_RESULT",total:true);

            sleCompCd.EditValueChanged += SleCompCd_EditValueChanged;
            slePlantCd.EditValueChanged += SlePlantCd_EditValueChanged;

            sleCompCd.EditValue = UserInfo.CompCode;
            slePlantCd.EditValue = UserInfo.PlantCode;
            De_Start_dt.EditValue = DateTime.Now;
            De_End_dt.EditValue = DateTime.Now;
            _headerList.ModelSelectedEvent += _headerList_ModelSelectedEvent; ;
            _detailList.ModelAddedEvent += _detailList_ModelAddedEvent;
            _detailList.ModelDeletedEvent += _detailList_ModelDeletedEvent;
            _detailList.ModelUpdatedEvent += _detailList_ModelUpdatedEvent;


        }

        private void _detailList_ModelUpdatedEvent(object sender, ArgsBase e)
        {
            _headerList.GridSelectByKey();
            

        }

        private void _detailList_ModelDeletedEvent(object sender, ArgsBase e)
        {
            _headerList.GridSelectByKey();
        }

        private void _detailList_ModelAddedEvent(object sender, ArgsBase e)
        {
            _headerList.GridSelectByKey();
        }

        private void _headerList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            //
            _JudgArgs.NcrRegJudgModelArgs.NCD_NO_KEY
               = ((NcrRegJudgHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).NCD_NO_KEY;
            _JudgArgs.NcrRegJudgModelArgs.JUDGE_RESULT
                = ((NcrRegJudgHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).JUDGE_RESULT;

            _JudgArgs.NcrRegJudgModelArgs.DEFECT_QTY
                = ((NcrRegJudgHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).DEFECT_QTY;
            _JudgArgs.NcrRegJudgModelArgs.REMAIN_QTY
                            = ((NcrRegJudgHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).REMAIN_QTY;

            //2022.02.10
            _JudgArgs.NcrRegJudgModelArgs.JUDGE_NEW_PRINT_YN
                = ((NcrRegJudgHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).JUDGE_NEW_PRINT_YN;
            //
            _JudgArgs.NcrRegJudgModelArgs.JUDGE_HU_STATUS
                = ((NcrRegJudgHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).JUDGE_HU_STATUS;
            _JudgArgs.NcrRegJudgModelArgs.PRE_HU_NO
                = ((NcrRegJudgHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).HU_NO;

            _detailList.DataRefresh(_JudgArgs);

        }

        private void SleCompCd_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
            _JudgArgs.NcrRegJudgModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
        }

        private void SlePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _JudgArgs.NcrRegJudgModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
        }


        private void NcrRegJudgMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _detailList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true,save:true);
            }
            else if (this.SelectedSubForm == _headerList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false);
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _JudgArgs.NcrRegJudgModelArgs.Select_Main_Comp_Cd
              = sleCompCd.EditValue?.ToString();
            _JudgArgs.NcrRegJudgModelArgs.Select_Main_Plant_Cd
                = slePlantCd.EditValue?.ToString();
            _JudgArgs.NcrRegJudgModelArgs.Select_Main_Start_dt
                = De_Start_dt.DateTime;
            _JudgArgs.NcrRegJudgModelArgs.Select_Main_End_dt
                = De_End_dt.DateTime;
            _JudgArgs.NcrRegJudgModelArgs.Select_Main_Judge_Result
                = ctl_Judge_Result.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
            _headerList.SelectModelAndRaiseEvent(0);
        }

        private void strapButton1_Click(object sender, EventArgs e)
        {
            List<NcrRegJudgeDetailModel> models= _detailList.GetCheckedData();
            int CheckConfirmCnt = models.Where(v => v.JUDGE_STATUS.ToUpper() == "CLOSE").Count();
            if (CheckConfirmCnt >0)
            {
                //이미 확정된 건 입니다.
                StrapMessageBox.Show("A002", 3);
                return;
            }

            _detailList.Confirm(models);
        }

        private void strapButton2_Click(object sender, EventArgs e)
        {
            List<NcrRegJudgeDetailModel> models = _detailList.GetCheckedData();

            if (models.Count == 0) return;

            int CheckConfirmCnt = models.Where(v => v.JUDGE_STATUS.ToUpper() != "CLOSE").Count();
            int CheckConfirmCnt2 = models.Where(v => string.IsNullOrEmpty( v.HU_NO)).Count();

            if (CheckConfirmCnt > 0)
            {
                //확정된 데이터의 신규식별표만 출력 가능합니다.
                StrapMessageBox.Show("A002", 31);
                return;
            }
            if (CheckConfirmCnt2 > 0)
            {
                //신규식별표가 존재하는 경우에만 출력 가능합니다.
                StrapMessageBox.Show("A002", 32);
                return;
            }

            List<string> huNoList = new List<string>();
            foreach (NcrRegJudgeDetailModel model in models)
            {
                huNoList.Add(model.HU_NO);
            }
            Dy_HandlingUnitReportFactory rf = Dy_HandlingUnitReportFactory.GetInstance();
            //대포장 바코드
            rf.HandlingUnit_LPackingBarcode(huNoList).ShowPreviewDialog();

        }
    }
}

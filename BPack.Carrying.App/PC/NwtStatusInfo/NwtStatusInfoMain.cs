using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.NwtStatusInfo;
using BPack.Pocket.App.PC.NwtStatusInfo;
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

namespace BPack.Carrying.App.PC.NwtStatusInfo
{
    public partial class NwtStatusInfoMain : StrapMainForm
    {
        private NwtStatusInfoArgs _nwtStatusInfoArgs;
        private NwtStatusInfoPocket _nwtStatusInfoPocket;
        private NwtStatusInfoDayList _nwtStatusInfoDayList;
        private NwtStatusInfoDayDetailList _nwtStatusInfoDayDetailList;

        public NwtStatusInfoMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();

            _nwtStatusInfoArgs = new NwtStatusInfoArgs();
            _nwtStatusInfoPocket = new NwtStatusInfoPocket();
            _nwtStatusInfoDayList = new NwtStatusInfoDayList(_nwtStatusInfoArgs, _nwtStatusInfoPocket);
            _nwtStatusInfoDayDetailList = new NwtStatusInfoDayDetailList(_nwtStatusInfoArgs, _nwtStatusInfoPocket);

            AddSubForm(this, _nwtStatusInfoDayList, layoutControlGroup2);
            AddSubForm(this, _nwtStatusInfoDayDetailList, layoutControlGroup3);

            //
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _nwtStatusInfoArgs,
                InitlistForm = _nwtStatusInfoDayList,
                StrapLayout = strapLayout1
            });


            //회사
            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            //공장
            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };

            //작업장
            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetByQuery(strapLookUpEdit3, "CoreSettingsWorkCenterList", new { COMP_CD = strapLookUpEdit1.EditValue?.ToString(), PLANT_CD = strapLookUpEdit2.EditValue?.ToString() }, "작업장코드", "작업장명", isTotalRow: true, isFirstSelect: true);
            };

            //폼 바뀔때마다 버튼 활성화(권한) 이벤트
            this.SelectedSubFormChanged += NwtStatusInfoMain_SelectedSubFormChanged;

            //그리드 선택 이벤트
            _nwtStatusInfoDayList.ModelSelectedEvent += _nwtStatusInfoDayList_ModelSelectedEvent;
            //_nwtStatusInfoDayDetailList.ModelSelectedEvent += _nwtStatusInfoDayDetailList_ModelSelectedEvent;

            //회사 초기화
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;

            //최초 권한
            InitRibbonButtons(true, false, false, false);

        }

      

        //메인 그리드 선택 이벤트
        private void _nwtStatusInfoDayList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Comp_CD
                = ((NwtStatusInfoModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Plant_CD
            = ((NwtStatusInfoModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Wc_CD
            = ((NwtStatusInfoModel)e.SelectedModelArgsBase.SelectedModelBase).WC_CD;
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Work_Dt
                            = ((NwtStatusInfoModel)e.SelectedModelArgsBase.SelectedModelBase).WORK_DT;
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Shift_Cd
            = ((NwtStatusInfoModel)e.SelectedModelArgsBase.SelectedModelBase).SHIFT_CD;

            _nwtStatusInfoDayDetailList.DataRefresh(_nwtStatusInfoArgs);
            
            //예를 들어 3개 그리드 일 경우 
            // 1 선택 후 2의 첫번째 0번재 선택 이벤트 발생
            //_nwtStatusInfoDayDetailList.SelectModelAndRaiseEvent(0);
        }

        private void NwtStatusInfoMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _nwtStatusInfoDayList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false);
            }
            if (this.SelectedSubForm == _nwtStatusInfoDayDetailList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: true, delete: false);
            }
        }

        /// <summary>
        /// 조회조건 을 args 에 넣는다
        /// </summary>
        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Wc_CD = strapLookUpEdit3.EditValue?.ToString();
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime.ToShortDateString();
            _nwtStatusInfoArgs.NwtStatusInfoModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime.ToShortDateString();

            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

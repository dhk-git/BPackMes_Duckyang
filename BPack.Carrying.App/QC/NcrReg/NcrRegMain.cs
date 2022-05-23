using BPack.Common.Config;
using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.NcrReg;
using BPack.Pocket.App.QC.NcrReg;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BPack.Carrying.App.QC.NcrReg
{
    public partial class NcrRegMain : StrapMainForm
    {

        private NcrRegPocket _regPocket;
        private NcrRegArgs _ncrRegArgs;

        private NcrRgeHeaderList _headerList;
        private NcrRegDetailList _detailList;
        public NcrRegMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();
            _regPocket = new NcrRegPocket();
            _ncrRegArgs = new NcrRegArgs();

            _headerList = new NcrRgeHeaderList(_ncrRegArgs, _regPocket);
            _detailList = new NcrRegDetailList(_ncrRegArgs, _regPocket);
            AddSubForm(this, _headerList, layoutControlGroup2);
            AddSubForm(this, _detailList, layoutControlGroup3);


            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _ncrRegArgs,
                InitlistForm = _headerList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true, true);
            this.SelectedSubFormChanged += NcrRegMain_SelectedSubFormChanged;

            LookUpEditHelper.SetCompCode(sleCompCd);
            LookUpEditHelper.SetSysCode(ctl_Ncr_status, "NCH_STATUS");
                //LookUpEditHelper.SetGridColumnSysCode(colNCH_STATUS, "NCH_STATUS");


            sleCompCd.EditValueChanged += SleCompCd_EditValueChanged;

            slePlantCd.EditValueChanged += SlePlantCd_EditValueChanged;

            sleCompCd.EditValue = UserInfo.CompCode;
            slePlantCd.EditValue = UserInfo.PlantCode;
            _headerList.ModelSelectedEvent += _headerList_ModelSelectedEvent;
            De_Start_dt.EditValue = DateTime.Now;
            De_End_dt.EditValue = DateTime.Now;

        }

        private void NcrRegMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _detailList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true);
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd
                = sleCompCd.EditValue?.ToString();
            _ncrRegArgs.NcrRegModelArgs.Plant_cd
                = slePlantCd.EditValue?.ToString();
            _ncrRegArgs.NcrRegModelArgs.Select_Main_Start_dt
                = De_Start_dt.DateTime;
            _ncrRegArgs.NcrRegModelArgs.Select_Main_End_dt
                = De_End_dt.DateTime;
            _ncrRegArgs.NcrRegModelArgs.Select_Main_Nch_Status
                = ctl_Ncr_status.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
            _headerList.SelectModelAndRaiseEvent(0);
        }


        private void SlePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _ncrRegArgs.NcrRegModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
        }

        private void SleCompCd_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
            _ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
        }

        private void _headerList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _ncrRegArgs.NcrRegModelArgs.NCH_NO_KEY
                = ((NcrRegHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).NCH_NO_KEY;
            _ncrRegArgs.NcrRegModelArgs.Comp_cd
                = ((NcrRegHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _ncrRegArgs.NcrRegModelArgs.Plant_cd
                = ((NcrRegHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
            _ncrRegArgs.NcrRegModelArgs.NCH_STATUS
                = ((NcrRegHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).NCH_STATUS;


            _detailList.DataRefresh(_ncrRegArgs);
        }

        private void strapButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(_ncrRegArgs.NcrRegModelArgs.NCH_NO_KEY))
            {
                //선택된 행이 없습니다.
                StrapMessageBox.Show("A001", 61);
                return;
            }
            else
            {
                if (_ncrRegArgs.NcrRegModelArgs.NCH_STATUS == "CLOSE")
                {
                    //선택된 행이 없습니다.
                    //"이미 등록완료된 부적합정보입니다.
                    //추가할수 없습니다."
                    StrapMessageBox.Show("A001", 85);
                    return;
                }
                else
                {
                    NcrRegDetailPopup popup = new NcrRegDetailPopup(_ncrRegArgs, _regPocket);
                    if (DialogResult.OK == popup.ShowDialog())
                    {
                        //갱신
                        _detailList.DataRefresh(_ncrRegArgs);
                    }
                }
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            List<NcrRegHeaderModel> data = _headerList.GetCheckedData();
            if (data.Count < 1)
            {
                //선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                StrapMessageBox.Show("A001", 9);
                return;
            }
            if (data.Exists(v => v.NCH_STATUS == "CLOSE"))
            {
                // 이미 등록된 정보입니다.
                StrapMessageBox.Show("A001", 79);
                return;
            }
            if (StrapMessageBox.Show("A001", 33, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<NcrRegHeaderConfirmModel> models = new List<NcrRegHeaderConfirmModel>();

                foreach (NcrRegHeaderModel model in data)
                {
                    models.Add(new NcrRegHeaderConfirmModel()
                    {
                        CREATE_DTTM = SystemConfig.ServerDateTime
                     ,
                        CREATE_USER_ID = UserInfo.UserID
                     ,
                        MODIFY_DTTM = SystemConfig.ServerDateTime
                     ,
                        MODIFY_USER_ID = UserInfo.UserID
                     ,
                        LANG_CODE = UserInfo.Sys_Language
                    ,
                        COMP_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Comp_Cd
                    ,
                        PLANT_CD = _ncrRegArgs.NcrRegModelArgs.Select_Main_Plant_Cd
                        ,
                        NCH_NO_KEY = model.NCH_NO_KEY
                        ,
                        NCH_STATUS = "CLOSE"
                    });
                }
                _headerList.UpdateStatus_Confirm(models);

                _headerList.DataRefresh(_ncrRegArgs);
            }
        }
    }
}

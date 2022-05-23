using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.MaterialRequest;
using BPack.Pocket.App.PC.MaterialRequest;
using BPack.Report.App.Factory;
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

namespace BPack.Carrying.App.PC.MaterialRequest
{
    public partial class MrqhMain : StrapMainForm
    {
        private MaterialRequestArgs _materialRequestArgs;
        private MaterialRequestPocket _materialRequestPocket;

        private MrqhList _mrqhList;
        private MrqdList _mrqdList;
        private MrqdHuList _mrqdHuList;


        public MrqhMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _materialRequestArgs = new MaterialRequestArgs();
            _materialRequestPocket = new MaterialRequestPocket();
            _mrqhList = new MrqhList(_materialRequestArgs, _materialRequestPocket);
            _mrqdList = new MrqdList(_materialRequestArgs, _materialRequestPocket);
            _mrqdHuList = new MrqdHuList(_materialRequestArgs, _materialRequestPocket);
            AddSubForm(this, _mrqhList, layoutControlGroup2);
            AddSubForm(this, _mrqdList, layoutControlGroup3);
            AddSubForm(this, _mrqdHuList, layoutControlGroup4);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _materialRequestArgs,
                InitlistForm = _mrqhList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(sleCompCd);

            sleCompCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
                _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD = sleCompCd.EditValue?.ToString();
            };

            slePlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD = slePlantCd.EditValue?.ToString();
            };
            LookUpEditHelper.SetSysCode(sleStatus, "MRH_STATUS");

            sleCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;
            slePlantCd.EditValue = Common.LoginInfo.UserInfo.PlantCode;
            sleStatus.EditValue = "";
            ctl_Start_dt.EditValue = DateTime.Now.AddDays(-1);
            ctl_End_dt.EditValue = DateTime.Now.AddDays(+7);


            this.SelectedSubFormChanged += MrqhMain_SelectedSubFormChanged;

            _mrqhList.ModelSelectedEvent += _mrqhList_ModelSelectedEvent;

           
            _mrqdList.ModelSelectedEvent += _mrqdList_ModelSelectedEvent;

            
        }

        private void MrqhMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _mrqhList) 
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save:true);
            }
            if (this.SelectedSubForm == _mrqdList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: true);
            }
            if (this.SelectedSubForm == _mrqdHuList)
            {
                SetRibbonButtonsEnable_ByAuth(add: false, edit: true, delete: false,save:false);
            }
        }

        private void _mrqhList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD = ((MrqhListModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD = ((MrqhListModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
            _materialRequestArgs.MaterialRequestModelArgs.MRH_NO_KEY = ((MrqhListModel)e.SelectedModelArgsBase.SelectedModelBase).MRH_NO_KEY;
            
            _mrqdList.DataClear(_materialRequestArgs);
            _mrqdHuList.DataClear(_materialRequestArgs);


            _mrqdList.DataRefresh(_materialRequestArgs);
            _mrqdList.SelectModelAndRaiseEvent(0);
            
        }

        private void _mrqdList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD = ((MrqdListModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
            _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD = ((MrqdListModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
            _materialRequestArgs.MaterialRequestModelArgs.MRD_NO_KEY= ((MrqdListModel)e.SelectedModelArgsBase.SelectedModelBase).MRD_NO_KEY;
            _mrqdHuList.DataRefresh(_materialRequestArgs);
        }


        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            

            _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD = sleCompCd.EditValue?.ToString();
            _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD = slePlantCd.EditValue?.ToString();
            _materialRequestArgs.MaterialRequestModelArgs.START_DT = ctl_Start_dt.DateTime;
            _materialRequestArgs.MaterialRequestModelArgs.END_DT = ctl_End_dt.DateTime;
            _materialRequestArgs.MaterialRequestModelArgs.MRH_STATUS = sleStatus.EditValue?.ToString();
            
            base.Refresh_From_ExecuteByRibbonButton();
            _mrqhList.SelectModelAndRaiseEvent(0);



        }

        /// <summary>
        /// 식별표 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void strapButton1_Click(object sender, EventArgs e)
        {
            var model = _mrqdList.SelectedModel;

            var data = _mrqdHuList.GetCheckedData();
            if (data.Count < 1)
            {
                //선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                StrapMessageBox.Show("A001", 9);
                return;
            }
            if (data.Exists(v => v.IS_REG == true))
            {
                // 이미 등록된 정보입니다.
                StrapMessageBox.Show("A001", 79);
                return;
            }
            if (data.Exists(v => v.IS_OTHER_REG == true))
            {
                // 이미 등록된 정보입니다.
                StrapMessageBox.Show("A001", 80);
                return;
            }
            if (data.Exists(v => v.HU_INSP_STATUS == "WAIT"))
            {
                // 입고검사 대기 식별표는 불출할수 없습니다.
                StrapMessageBox.Show("A001", 110);
                return;
            }


            if (data.Count(v => v.CrudCls2 == "") == data.Count())
            {

            }
            else
            {
                //todo 수정한 데이터와 동시에 처리할수 없습니다.
                StrapMessageBox.Show("A001", 80);
                return;
            }
            if (StrapMessageBox.Show("A001", 33, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                foreach (MrqdHuListModel obj in data)
                {
                    obj.CrudCls2 = "Added";
                    obj.CREATE_DTTM = DateTime.Now;
                    obj.MODIFY_DTTM = DateTime.Now;
                    obj.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                    obj.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
                }

                _mrqdHuList.SaveMrqdHuListModel(data);
                _mrqdList.DataRefresh(_materialRequestArgs);

                _mrqdHuList.DataRefresh(_materialRequestArgs);
            }
        }

        /// <summary>
        /// 식별표 삭제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void strapButton2_Click(object sender, EventArgs e)
        {
            var model = _mrqdList.SelectedModel;
            var data = _mrqdHuList.GetCheckedData();
            if (data.Count < 1)
            {
                //선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                StrapMessageBox.Show("A001", 9);
                return;
            }
            if (data.Exists(v => v.IS_REG == false))
            {
                //미 등록된 정보입니다.
                StrapMessageBox.Show("A001", 81);
                return;
            }
            if (StrapMessageBox.Show("A001", 10, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                foreach (MrqdHuListModel obj in data)
                {
                    obj.CrudCls2 = "Deleted";
                    obj.CREATE_DTTM = DateTime.Now;
                    obj.MODIFY_DTTM = DateTime.Now;
                    obj.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                    obj.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
                }

                _mrqdHuList.SaveMrqdHuListModel(data);
                _mrqdList.DataRefresh(_materialRequestArgs);

                _mrqdHuList.DataRefresh(_materialRequestArgs);
            }
        }

        private void strapButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_materialRequestArgs.MaterialRequestModelArgs.MRH_NO_KEY))
            {
                //선택된 행이 없습니다.
                StrapMessageBox.Show("A001", 61);
            }
            else
            {
                Doc_Print();
            }
        }

        private void Doc_Print()
        {
            MaterialRequestReportFactory rf = MaterialRequestReportFactory.GetInstance();
            rf.ShowReport(_materialRequestArgs.MaterialRequestModelArgs.Select_Main_Comp_CD
                        , _materialRequestArgs.MaterialRequestModelArgs.Select_Main_Plant_CD
                        , _materialRequestArgs.MaterialRequestModelArgs.MRH_NO_KEY).ShowPreviewDialog();
               
        }
    }
}

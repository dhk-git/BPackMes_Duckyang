using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.QC.IqcInsp;
using BPack.Pocket.App.QC.IqcInsp;
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

namespace BPack.Carrying.App.QC.IqcInsp
{
    public partial class IqcInspMain : StrapMainForm
    {
        
        private IqcInspArgs _IqcInspArgs;
        private IqcInspPocket _IqcInspPocket;
        private IqcInspList _IqcInspList;
        private IqcInspItemList _IqcInspItemList;
        private IqcInspFailList _IqcInspFailList;

        public IqcInspMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();

            _IqcInspArgs = new IqcInspArgs();
            _IqcInspPocket = new IqcInspPocket();
            _IqcInspList = new IqcInspList(_IqcInspArgs, _IqcInspPocket);
            _IqcInspItemList = new IqcInspItemList(_IqcInspArgs, _IqcInspPocket);
            _IqcInspFailList = new IqcInspFailList(_IqcInspArgs, _IqcInspPocket);

            AddSubForm(this, _IqcInspList, layoutControlGroup2);
            AddSubForm(this, _IqcInspItemList, layoutControlGroup3);
            AddSubForm(this, _IqcInspFailList, layoutControlGroup5);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _IqcInspArgs,
                InitlistForm = _IqcInspList,
                StrapLayout = strapLayout1
            });

            LookUpEditHelper.SetCompCode(sleCompCd);
            sleCompCd.EditValueChanged += SleCompCd_EditValueChanged;

            slePlantCd.EditValueChanged += SlePlantCd_EditValueChanged;

            sleCompCd.EditValue = UserInfo.CompCode;
            slePlantCd.EditValue = UserInfo.PlantCode;
            strapDateEdit1.EditValue = DateTime.Now.Date.AddDays(-30);
            strapDateEdit2.EditValue = DateTime.Now.Date;


            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _IqcInspList) 
                { 
                    SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: true);
                }
                if (this.SelectedSubForm == _IqcInspItemList) 
                {
                    //검사완료
                    if (_IqcInspArgs.IqcInspModelArgs.IQC_STATUS == "CLOSE")
                    {
                        SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: false);
                    }
                    else
                    {
                        SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: true);
                    }
                }
                if (this.SelectedSubForm == _IqcInspFailList) 
                {
                    if (_IqcInspArgs.IqcInspModelArgs.IQC_STATUS == "CLOSE")
                    {
                        SetRibbonButtonsEnable_ByAuth(add: false, edit: false, delete: false, save: false);
                    }
                    else
                    { 
                        SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true, save: true); 
                    }
                }

            };

            _IqcInspList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _IqcInspArgs.IqcInspModelArgs.Select_Main_IQC_NO = ((IqcInspModel)e.SelectedModelArgsBase.SelectedModelBase).IQC_NO;
                _IqcInspArgs.IqcInspModelArgs.IQC_STATUS = ((IqcInspModel)e.SelectedModelArgsBase.SelectedModelBase).IQC_STATUS;
                _IqcInspArgs.IqcInspModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
                _IqcInspArgs.IqcInspModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
                _IqcInspItemList.DataRefresh(_IqcInspArgs);
                _IqcInspItemList.SelectModelAndRaiseEvent(0);


            };

            _IqcInspItemList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _IqcInspArgs.IqcInspModelArgs.Select_Main_IQC_NO = ((IqcInspItemModel)e.SelectedModelArgsBase.SelectedModelBase).IQC_NO;
                _IqcInspArgs.IqcInspModelArgs.Select_SUB_IQD_NO = ((IqcInspItemModel)e.SelectedModelArgsBase.SelectedModelBase).IQD_NO;
                _IqcInspArgs.IqcInspModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
                _IqcInspArgs.IqcInspModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
                _IqcInspFailList.DataRefresh(_IqcInspArgs);

            };
            _IqcInspFailList.ModelUpdatedEvent += (object sender, ArgsBase e) =>
            {
                //2022.01.19 e 가 null임
                //_IqcInspArgs.IqcInspModelArgs.Select_Main_IQC_NO = ((IqcInspItemModel)e.SelectedModelArgsBase.SelectedModelBase).IQC_NO;
                //_IqcInspArgs.IqcInspModelArgs.Select_SUB_IQD_NO = ((IqcInspItemModel)e.SelectedModelArgsBase.SelectedModelBase).IQD_NO;
                //_IqcInspArgs.IqcInspModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
                //_IqcInspArgs.IqcInspModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
                _IqcInspItemList.DataRefresh(_IqcInspArgs);
            };
            _IqcInspFailList.Event_DetailModeldUpdated += _IqcInspFailList_Event_DetailModeldUpdated;


            InitRibbonButtons(true);
        }

        private void _IqcInspFailList_Event_DetailModeldUpdated(object sender, EventArgs e)
        {
            _IqcInspItemList.DataRefresh(_IqcInspArgs);
        }

        private void SleCompCd_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
            _IqcInspArgs.IqcInspModelArgs.Select_Main_Comp_Cd= sleCompCd.EditValue?.ToString();
        }

        private void SlePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _IqcInspArgs.IqcInspModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString(); 
            ;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _IqcInspArgs.IqcInspModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            _IqcInspArgs.IqcInspModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
            _IqcInspArgs.IqcInspModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _IqcInspArgs.IqcInspModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;

            base.Refresh_From_ExecuteByRibbonButton();
            
            _IqcInspList.SelectModelAndRaiseEvent(0);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _IqcInspList.EtcInList();

            _IqcInspList.DataRefresh(_IqcInspArgs);

        }
    }
}

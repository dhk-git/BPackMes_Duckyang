using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.SomDevice;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.SomDevice;
using DevExpress.XtraEditors.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.SomDevice
{
    public partial class SomDeviceMain : StrapMainForm
    {
        private SomDeviceArgs _somDeviceArgs;
        private SomDevicePocket _somDevicePocket;
        private DeviceList _deviceList;
        private ModeList _modeList;
        private SettingList _settingList;
        private PlcInfoList _plcInfoList;

        public SomDeviceMain()
        {
            InitializeComponent();
        }


        public override void InitStrap()
        {
            base.InitStrap();
            _somDeviceArgs = new SomDeviceArgs();
            _somDevicePocket = new SomDevicePocket();
            _deviceList = new DeviceList(_somDeviceArgs, _somDevicePocket);
            _modeList = new ModeList(_somDeviceArgs, _somDevicePocket);
            _settingList = new SettingList(_somDeviceArgs, _somDevicePocket);
            _plcInfoList = new PlcInfoList(_somDeviceArgs, _somDevicePocket);
            AddSubForm(this, _deviceList, layoutControlGroup2);
            AddSubForm(this, _modeList, layoutControlGroup3);
            AddSubForm(this, _settingList, layoutControlGroup5);
            AddSubForm(this, _plcInfoList, layoutControlGroup6);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _somDeviceArgs,
                InitlistForm = _deviceList,
                IsAutoDataRefreshOnShown = true,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            LookUpEditHelper.SetCompCode(strapLookUpEdit1, new { COMP_CD = Common.LoginInfo.UserInfo.CompCode });
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
            _deviceList.ModelSelectedEvent += DeviceList_ModelSelectedEvent;
            _modeList.ModelSelectedEvent += ModeList_ModelSelectedEvent;
            this.SelectedSubFormChanged += SomDeviceMain_SelectedSubFormChanged;
        }

        private void SomDeviceMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            if (this.SelectedSubForm == _settingList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: false, save: true, delete: false);
            }
            else if (this.SelectedSubForm == _plcInfoList)
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: false, save: true, delete: true);
            }
            else
            {
                SetRibbonButtonsEnable_ByAuth(add: true, edit: false, save: true, delete: true); //Batch모드로 바뀜
            }
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, false, true);
        }

        private void ModeList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _somDeviceArgs.SomDeviceModelArgs.Select_Mode_ID = ((ModeModel)e.SelectedModelArgsBase.SelectedModelBase).MODE_ID;
            _settingList.DataRefresh(_somDeviceArgs);
        }

        private void DeviceList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _somDeviceArgs.SomDeviceModelArgs.Select_Plant_CD = ((DeviceModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
            _somDeviceArgs.SomDeviceModelArgs.Select_Dvc_ID = ((DeviceModel)e.SelectedModelArgsBase.SelectedModelBase).DVC_ID;
            _modeList.DataRefresh(_somDeviceArgs);
            _modeList.SelectModelAndRaiseEvent(0);
            if (_modeList.SelectedModels.Count() == 0)
            {
                _settingList.DataClear(_somDeviceArgs);
            }
            _plcInfoList.DataRefresh(_somDeviceArgs);
            //_settingList.DataClear(_somDeviceArgs);
            _somDeviceArgs.SomDeviceModelArgs.Select_Mode_ID = null;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _somDeviceArgs.SomDeviceModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _somDeviceArgs.SomDeviceModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();
            _deviceList.RefreshWorkCenterLookupEdit(_somDeviceArgs);
            _modeList.DataClear(_somDeviceArgs);
            _settingList.DataClear(_somDeviceArgs);
            _plcInfoList.DataClear(_somDeviceArgs);
            base.Refresh_From_ExecuteByRibbonButton();
        }

        //항목동기화 버튼
        private void strapButton1_Click(object sender, EventArgs e)
        {
            if (_somDeviceArgs.SomDeviceModelArgs.Select_Dvc_ID == null)
            {
                StrapMessageBox.Show("단말기가 선택되지 않았습니다.");
                return;
            }
            if (_somDeviceArgs.SomDeviceModelArgs.Select_Mode_ID == null)
            {
                StrapMessageBox.Show("모드가 선택되지 않았습니다.");
                return;
            }
            if (StrapMessageBox.Show("A001", 6, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _settingList.SyncSettingData(_somDeviceArgs);
                _settingList.DataRefresh(_somDeviceArgs);
            }
        }
    }

}

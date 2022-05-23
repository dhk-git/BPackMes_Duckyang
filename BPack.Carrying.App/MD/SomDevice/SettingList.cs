using BPack.Common.Model;
using BPack.Model.App.MD.SomDevice;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.SomDevice;
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
    public partial class SettingList : StrapSubForm_OnlyOneGrid_V2
    {
        private SomDeviceArgs _somDeviceArgs;
        private SomDevicePocket _somDevicePocket;

        public SettingList()
        {
            InitializeComponent();
        }

        public SettingList(SomDeviceArgs somDeviceArgs, SomDevicePocket somDevicePocket) : this()
        {
            this._somDeviceArgs = somDeviceArgs;
            this._somDevicePocket = somDevicePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = settingModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _somDeviceArgs,
                GridView = gridView1,
                InitModelType = typeof(SettingModel),
                ModelArgs = _somDeviceArgs.SomDeviceModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<SomDeviceModelArgs, SettingModel>(_somDevicePocket.SelectSettingModels, null, _somDevicePocket.SaveSettingModels);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((SettingModel)model).DVC_ID = _somDeviceArgs.SomDeviceModelArgs.Select_Dvc_ID;
            ((SettingModel)model).MODE_ID = _somDeviceArgs.SomDeviceModelArgs.Select_Mode_ID;
            ((SettingModel)model).DEL_FG = "N";
            ((SettingModel)model).VALID = true;
            base.SetInsertDefaultValue(model);
        }

        public void SyncSettingData(SomDeviceArgs args)
        {
            _somDevicePocket.SyncSettingData(args.SomDeviceModelArgs);
        }
    }
}

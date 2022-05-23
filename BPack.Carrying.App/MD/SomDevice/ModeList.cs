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
    public partial class ModeList : StrapSubForm_OnlyOneGrid_V2
    {
        private SomDeviceArgs _somDeviceArgs;
        private SomDevicePocket _somDevicePocket;

        public ModeList()
        {
            InitializeComponent();
        }

        public ModeList(SomDeviceArgs somDeviceArgs, SomDevicePocket somDevicePocket) : this()
        {
            this._somDeviceArgs = somDeviceArgs;
            this._somDevicePocket = somDevicePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = modeModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _somDeviceArgs,
                GridView = gridView1,
                InitModelType = typeof(ModeModel),
                ModelArgs = _somDeviceArgs.SomDeviceModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<SomDeviceModelArgs, ModeModel>(_somDevicePocket.SelectModeModels, _somDevicePocket.SaveModeModel, _somDevicePocket.SaveModeModels);
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((ModeModel)model).DVC_ID = _somDeviceArgs.SomDeviceModelArgs.Select_Dvc_ID;
            ((ModeModel)model).DEL_FG = "N";
            ((ModeModel)model).VALID = true;
            base.SetInsertDefaultValue(model);
        }

    }
}

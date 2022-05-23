using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.SomDevice;
using BPack.Pocket.App.MD.SomDevice;
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

namespace BPack.Carrying.App.MD.SomDevice
{
    public partial class PlcInfoList : StrapSubForm_OnlyOneGrid_V2
    {
        private SomDeviceArgs _somDeviceArgs;
        private SomDevicePocket _somDevicePocket;

        public PlcInfoList()
        {
            InitializeComponent();
        }

        public PlcInfoList(SomDeviceArgs somDeviceArgs, SomDevicePocket somDevicePocket) : this()
        {
            this._somDeviceArgs = somDeviceArgs;
            this._somDevicePocket = somDevicePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = plcInfoModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _somDeviceArgs,
                GridView = gridView1,
                InitModelType = typeof(PlcInfoModel),
                ModelArgs = _somDeviceArgs.SomDeviceModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });

            InitPocketDelegate<SomDeviceModelArgs, PlcInfoModel>(_somDevicePocket.SelectPlcInfoModels, null, _somDevicePocket.SavePlcInfoModels);
            LookUpEditHelper.SetGridColumnSysCode(colDEL_FG, "DEL_FG");
            LookUpEditHelper.SetGridColumnSysCode(colDATA_TYPE, "PLC_DATA_TYPE");
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((PlcInfoModel)model).DVC_ID = _somDeviceArgs.SomDeviceModelArgs.Select_Dvc_ID;
            ((PlcInfoModel)model).DEL_FG = "N";
            base.SetInsertDefaultValue(model);
        }

    }
}

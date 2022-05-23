using BPack.Common.Model;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.SomDevice;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.SomDevice;
using DevExpress.XtraSplashScreen;
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
    public partial class DeviceList : StrapSubForm_OnlyOneGrid_V2
    {
        private SomDeviceArgs _somDeviceArgs;
        private SomDevicePocket _somDevicePocket;

        public DeviceList()
        {
            InitializeComponent();
        }

        public DeviceList(SomDeviceArgs somDeviceArgs, SomDevicePocket somDevicePocket) : this()
        {
            this._somDeviceArgs = somDeviceArgs;
            this._somDevicePocket = somDevicePocket;
        }

        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = deviceModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _somDeviceArgs,
                GridView = gridView1,
                InitModelType = typeof(DeviceModel),
                ModelArgs = _somDeviceArgs.SomDeviceModelArgs,
                StrapEditMode = StrapEditMode.Batch
            });

            InitPocketDelegate<SomDeviceModelArgs, DeviceModel>(_somDevicePocket.SelectDeviceModels, _somDevicePocket.SaveDeviceModel, _somDevicePocket.SaveDeviceModels);
            LookUpEditHelper.SetGridColumnSysCode(colPOP_TYPE, "POP_TYPE");
        }
        protected override void SetInsertDefaultValue(ModelBase model)
        {
            ((DeviceModel)model).COMP_CD = _somDeviceArgs.SomDeviceModelArgs.Select_Main_Comp_CD;
            ((DeviceModel)model).PLANT_CD = _somDeviceArgs.SomDeviceModelArgs.Select_Main_Plant_CD;
            ((DeviceModel)model).DEL_FG = "N";
            ((DeviceModel)model).VALID = true;
            base.SetInsertDefaultValue(model);
        }

        public void RefreshWorkCenterLookupEdit(SomDeviceArgs args)
        {
            LookUpEditHelper.SetWorkCenter(colWC_CD, args.SomDeviceModelArgs.Select_Main_Comp_CD, args.SomDeviceModelArgs.Select_Main_Plant_CD);
        }

    }
}

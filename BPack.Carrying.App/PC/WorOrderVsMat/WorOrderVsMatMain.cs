using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WorOrderVsMat;
using System;
using BPack.CommonMes.Helpers;
using BPack.Common.Pocket;
using BPack.CommonMes.Enums;
using System.Linq;

namespace BPack.Carrying.App.PC.WorOrderVsMat
{
    public partial class WorOrderVsMatMain : StrapMainForm
    {
        private WorOrderVsMatArgs _worOrderVsMatArgs;
        private WorOrderVsMatPocket _worOrderVsMatPocket;
        private WorOrderVsMatWorkOrderList _worOrderVsMatWorkOrderList;
        private WorOrderVsMatMaterialList _worOrderVsMatMaterialList;

        public WorOrderVsMatMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _worOrderVsMatArgs = new WorOrderVsMatArgs();
            _worOrderVsMatPocket = new WorOrderVsMatPocket();
            _worOrderVsMatWorkOrderList = new WorOrderVsMatWorkOrderList(_worOrderVsMatArgs, _worOrderVsMatPocket);
            _worOrderVsMatMaterialList = new WorOrderVsMatMaterialList(_worOrderVsMatArgs, _worOrderVsMatPocket);

            AddSubForm(this, _worOrderVsMatWorkOrderList, lagWorkOrder);
            AddSubForm(this, _worOrderVsMatMaterialList, lagMat);

            InitFields(new FieldArgs_StrapMainForm() {
                FormArgs = _worOrderVsMatArgs,
                InitlistForm = _worOrderVsMatWorkOrderList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });
            InitRibbonButtons(true, false, false, false);

            LookUpEditHelper.SetCompCode(lueCompCd);
            strapDateEdit1.EditValue = DateTime.Now.Date;
            _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Main_Wo_Dt = (DateTime)strapDateEdit1.EditValue;
            strapDateEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                //if (strapDateEdit1.EditValue != null) 
                _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Main_Wo_Dt = (DateTime)strapDateEdit1.EditValue;
            };

            lueCompCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Main_Comp_Cd = lueCompCd.EditValue?.ToString();

                LookUpEditHelper.SetPlantCode(luePlantCd, new { COMP_CD = lueCompCd.EditValue?.ToString() }, isFirstSelect: true);

                LookUpEditHelper.SetCommonCode(lueLineCd, lueCompCd.EditValue?.ToString(), "LINE");
                LookUpEditHelper.FirstRowSelect(lueLineCd);

            };

            luePlantCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Main_Plant_Cd = luePlantCd.EditValue?.ToString();
                
                LookUpEditHelper.SetWorkCenter(lueWcCd, lueCompCd.EditValue?.ToString(), luePlantCd.EditValue?.ToString(), lueLineCd.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true );

                SetLocation();
            };

            lueLineCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetWorkCenter(lueWcCd, lueCompCd.EditValue?.ToString(), luePlantCd.EditValue?.ToString(), lueLineCd.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true);
            };

            lueWcCd.EditValueChanged += (object sender, EventArgs e) =>
            {
                _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Main_Wc_Cd = lueWcCd.EditValue?.ToString();
            };

            lueCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;

            strapDateEdit1.EditValue = DateTime.Now.Date;
            _worOrderVsMatWorkOrderList.ModelSelectionChangedEvent += (object sender, object e) =>
            {
                var workOrderModels = _worOrderVsMatWorkOrderList.GetSelectedModels();
                var models = workOrderModels.Select(r => r.WO_NO).Distinct().ToList();
                _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_WorkOrder_WoNoList = String.Join(SysCode.Separator.Parameter, models);

                _worOrderVsMatMaterialList.DataRefresh(_worOrderVsMatArgs);
            };

            cbxWareHouseLoc.EditValueChanged += (object sender, EventArgs e) =>
            {
                _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Material_LocationList = cbxWareHouseLoc.EditValue?.ToString().Replace(", ", SysCode.Separator.Parameter);
                _worOrderVsMatMaterialList.DataRefresh(_worOrderVsMatArgs);
            };
            SetLocation();
            
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void SetLocation()
        {
            var simplePocket = SimplePocket.GetInstance();
            var source = simplePocket.SelectData("Locations_WithWarehouse", new
            {
                COMP_CD = _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Main_Comp_Cd,
                PLANT_CD = _worOrderVsMatArgs.WorOrderVsMatModelArgs.Select_Main_Plant_Cd,
                WH_CD = ""
            });
            cbxWareHouseLoc.Properties.DataSource = source;
            cbxWareHouseLoc.Properties.ValueMember = "CODE";
            cbxWareHouseLoc.Properties.DisplayMember = "NAME";
            cbxWareHouseLoc.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            cbxWareHouseLoc.Properties.PopupFormMinSize = new System.Drawing.Size(cbxWareHouseLoc.Size.Width, 500);

            cbxWareHouseLoc.CheckAll();
        }
    }
}

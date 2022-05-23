using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvLineCarType;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.DlvLineCarType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvLineCarType
{
    public partial class DlvLineCarTypeMain : StrapMainForm
    {
        private DlvLineCarTypeArgs _dlvLineCarTypeArgs;
        private DlvLineCarTypePocket _dlvLineCarTypePocket;
        private GateList _gateList;
        private CarTypeList _carTypeList;

        public DlvLineCarTypeMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _dlvLineCarTypeArgs = new DlvLineCarTypeArgs();
            _dlvLineCarTypePocket = new DlvLineCarTypePocket();
            _gateList = new GateList(_dlvLineCarTypeArgs, _dlvLineCarTypePocket);
            _carTypeList = new CarTypeList(_dlvLineCarTypeArgs, _dlvLineCarTypePocket);

            AddSubForm(this, _gateList, layoutControlGroup2);
            AddSubForm(this, _carTypeList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _dlvLineCarTypeArgs,
                InitlistForm = _gateList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);

                _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();

                _gateList.DataRefresh(_dlvLineCarTypeArgs);
                _carTypeList.DataRefresh(_dlvLineCarTypeArgs);
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();

                _gateList.DataRefresh(_dlvLineCarTypeArgs);
                _carTypeList.DataRefresh(_dlvLineCarTypeArgs);
            };

            _gateList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Gate_Dlv_Plc_CD = ((DlvLineCarTypeGateModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_PLC_CD;

                _carTypeList.DataRefresh(_dlvLineCarTypeArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _gateList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
                if (this.SelectedSubForm == _carTypeList) { SetRibbonButtonsEnable_ByAuth(add: true, save: true, edit: true, delete: true); }
            };

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;

        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _dlvLineCarTypeArgs.DlvLineCarTypeModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}

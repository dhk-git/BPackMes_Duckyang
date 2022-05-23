using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.DlvJisInfo;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.DlvJisInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.DlvJisInfo
{
    public partial class DlvJisInfoMain : StrapMainForm
    {
        private DlvJisInfoArgs _dlvJisInfoArgs;
        private DlvJisInfoPocket _dlvJisInfoPocket;
        private GateList _gateList;
        private CarTypeList _carTypeList;

        public DlvJisInfoMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _dlvJisInfoArgs = new DlvJisInfoArgs();
            _dlvJisInfoPocket = new DlvJisInfoPocket();
            _gateList = new GateList(_dlvJisInfoArgs, _dlvJisInfoPocket);
            _carTypeList = new CarTypeList(_dlvJisInfoArgs, _dlvJisInfoPocket);

            AddSubForm(this, _gateList, layoutControlGroup2);
            AddSubForm(this, _carTypeList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _dlvJisInfoArgs,
                InitlistForm = _gateList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, true, true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);

                _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();

                _gateList.DataRefresh(_dlvJisInfoArgs);
                _carTypeList.DataRefresh(_dlvJisInfoArgs);
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();

                _gateList.DataRefresh(_dlvJisInfoArgs);
                _carTypeList.DataRefresh(_dlvJisInfoArgs);
            };

            _gateList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Gate_Dlv_Plc_CD = ((DlvJisInfoGateModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_PLC_CD;

                _carTypeList.DataRefresh(_dlvJisInfoArgs);
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
            _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Main_Comp_CD = strapLookUpEdit1.EditValue?.ToString();
            _dlvJisInfoArgs.DlvJisInfoModelArgs.Select_Main_Plant_CD = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

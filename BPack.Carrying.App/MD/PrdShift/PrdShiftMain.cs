using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdShift;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Model.App.MD.PrdShift;
using BPack.Common.LoginInfo;

namespace BPack.Carrying.App.MD.PrdShift
{
    public partial class PrdShiftMain : StrapMainForm
    {
        private PrdShiftArgs _prdShiftArgs;
        private PrdShiftPocket _prdShiftPocket;

        private ShifGrouptList _shiftGroupList;
        private ShiftDetailGrouptList _ShiftDetailGrouptList;
        private ShiftList _shiftList;

        public PrdShiftMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _prdShiftArgs = new PrdShiftArgs();
            _prdShiftPocket = new PrdShiftPocket();
            _shiftGroupList = new ShifGrouptList(_prdShiftArgs, _prdShiftPocket);
            _ShiftDetailGrouptList= new ShiftDetailGrouptList(_prdShiftArgs, _prdShiftPocket);
            _shiftList = new ShiftList(_prdShiftArgs, _prdShiftPocket);

            AddSubForm(this, _shiftGroupList, layoutControlGroup2);
            AddSubForm(this, _shiftList, layoutControlGroup3);
            AddSubForm(this, _ShiftDetailGrouptList, layoutControlGroup4);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _prdShiftArgs,
                InitlistForm = _shiftGroupList,
                StrapLayout = strapLayout1
            });


            InitRibbonButtons(refresh: true, add: true, delete: true, save: true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
                _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            };


            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _shiftGroupList) { SetRibbonButtonsEnable_ByAuth(refresh: true, add: true, delete: true, save: true); }
            };

            //좌측 변경시 우측 이벤트 발생
            _shiftGroupList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code = ((ShiftGroupModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD_KEY;
                _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code = ((ShiftGroupModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD_KEY;
                _prdShiftArgs.PrdShiftModelArgs.SHIFT_GROUP_CD = ((ShiftGroupModel)e.SelectedModelArgsBase.SelectedModelBase).SHIFT_GROUP_CD;
                _ShiftDetailGrouptList.DataRefresh(_prdShiftArgs);
                _shiftList.DataRefresh(_prdShiftArgs);

            };
            strapLookUpEdit1.EditValue = UserInfo.CompCode;
            strapLookUpEdit2.EditValue = UserInfo.PlantCode;
        }

        

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdShiftArgs.PrdShiftModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _prdShiftArgs.PrdShiftModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

    }
}

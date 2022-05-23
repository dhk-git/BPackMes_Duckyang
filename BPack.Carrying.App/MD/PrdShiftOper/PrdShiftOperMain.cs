using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdShiftOper;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdShiftOper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.PrdShiftOper
{
    public partial class PrdShiftOperMain : StrapMainForm
    {
        PrdShiftOperArgs _prdShiftOperArgs;
        PrdShiftOperPocket _prdShiftOperPocket;

        OperList _operList;
        ShiftList _shiftList;

        public PrdShiftOperMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _prdShiftOperArgs = new PrdShiftOperArgs();
            _prdShiftOperPocket = new PrdShiftOperPocket();
            _shiftList = new ShiftList(_prdShiftOperArgs, _prdShiftOperPocket);
            _operList = new OperList(_prdShiftOperArgs, _prdShiftOperPocket);

            AddSubForm(this, _shiftList, layoutControlGroup2);
            AddSubForm(this, _operList, layoutControlGroup3);

            _shiftList.AddRefreshTargetSubForm(_operList);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _prdShiftOperArgs,
                InitlistForm = _shiftList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(refresh: true, add: true, delete: true, save: true);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() });
                strapLookUpEdit2.EditValue = strapLookUpEdit2.Properties.GetDataSourceValue("CODE", 0);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _shiftList) { SetRibbonButtonsEnable_ByAuth(); }
                if (this.SelectedSubForm == _operList) { SetRibbonButtonsEnable_ByAuth(refresh: true, add: true, delete: true, save: true); }
            };

            _shiftList.ModelSelectedEvent += (object sender, ArgsBase e) => 
            {
                _prdShiftOperArgs.PrdShiftOperModelArgs.Select_Shift_Code = ((ShiftModel)e.SelectedModelArgsBase.SelectedModelBase).SHIFT_CD;

                _operList.DataRefresh(_prdShiftOperArgs);
            };

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdShiftOperArgs.PrdShiftOperModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _prdShiftOperArgs.PrdShiftOperModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

   
    }
}

using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdWcOper;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.PrdWcOper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.PrdWcOper
{
    public partial class PrdWcOperMain : StrapMainForm
    {
        PrdWcOperArgs _prdWcOperArgs;
        PrdWcOperPocket _prdWcOperPocket;

        PrdWcOperOperatorList _PrdWcOperOperatorList;
        PrdWcOperWorkCenterList _prdWcOperWorkCenterList;

        public PrdWcOperMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _prdWcOperArgs = new PrdWcOperArgs();
            _prdWcOperPocket = new PrdWcOperPocket();
            _prdWcOperWorkCenterList = new PrdWcOperWorkCenterList(_prdWcOperArgs, _prdWcOperPocket);
            _PrdWcOperOperatorList = new PrdWcOperOperatorList(_prdWcOperArgs, _prdWcOperPocket);

            AddSubForm(this, _prdWcOperWorkCenterList, layoutControlGroup2);
            AddSubForm(this, _PrdWcOperOperatorList, layoutControlGroup3);

            _prdWcOperWorkCenterList.AddRefreshTargetSubForm(_PrdWcOperOperatorList);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _prdWcOperArgs,
                InitlistForm = _prdWcOperWorkCenterList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });
            InitRibbonButtons(refresh: true, add: false, delete: false, save: false);

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _prdWcOperWorkCenterList) { SetRibbonButtonsEnable_ByAuth(refresh: true, add: false, delete: false, save: false); }
                if (this.SelectedSubForm == _PrdWcOperOperatorList) { SetRibbonButtonsEnable_ByAuth(refresh: true, add: true, delete: true, save: true); }
            };
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
            _prdWcOperWorkCenterList.ModelSelectedEvent += (object sender, ArgsBase e) => 
            {
                _prdWcOperArgs.PrdWcOperModelArgs.Select_WorkCenter_Code = ((PrdWcOperWorkCenterModel)e.SelectedModelArgsBase.SelectedModelBase).WC_CD;

                _PrdWcOperOperatorList.DataRefresh(_prdWcOperArgs);
            };

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdWcOperArgs.PrdWcOperModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _prdWcOperArgs.PrdWcOperModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

   
    }
}

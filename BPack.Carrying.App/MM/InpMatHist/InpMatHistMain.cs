using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.InpMatHist;
using BPack.Pocket.App.MM.InpMatHist;
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

namespace BPack.Carrying.App.MM.InpMatHist
{
    public partial class InpMatHistMain : StrapMainForm
    {
        private InpMatHistArgs _inpMatHistArgs;
        private InpMatHistPocket _inpMatHistPocket;
        private InpMatHistHeaderList _inpMatHistHeaderList;
        private InpMatHistDetailList _inpMatHistDetailList;

        public InpMatHistMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _inpMatHistArgs = new InpMatHistArgs();
            _inpMatHistPocket = new InpMatHistPocket();
            _inpMatHistHeaderList = new InpMatHistHeaderList(_inpMatHistArgs, _inpMatHistPocket);
            _inpMatHistDetailList = new InpMatHistDetailList(_inpMatHistArgs, _inpMatHistPocket);
            AddSubForm(this, _inpMatHistHeaderList, layoutControlGroup2);
            AddSubForm(this, _inpMatHistDetailList, layoutControlGroup3);
            InitFields(new FieldArgs_StrapMainForm {
                FormArgs = _inpMatHistArgs,
                InitlistForm = _inpMatHistHeaderList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            _inpMatHistHeaderList.ModelSelectedEvent += InpMatHistHeaderList_ModelSelectedEvent;
            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, isFirstSelect:true);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _inpMatHistArgs.InpMatHistModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _inpMatHistArgs.InpMatHistModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _inpMatHistArgs.InpMatHistModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _inpMatHistArgs.InpMatHistModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            _inpMatHistArgs.InpMatHistModelArgs.Select_Main_Item_Cd = strapTextEdit1.EditValue?.ToString();
            _inpMatHistArgs.InpMatHistModelArgs.Select_Main_Item_Nm = strapTextEdit2.EditValue?.ToString();
            _inpMatHistArgs.InpMatHistModelArgs.Select_Main_Bp_Cd = strapTextEdit3.EditValue?.ToString();
            _inpMatHistArgs.InpMatHistModelArgs.Select_Main_Bp_Nm = strapTextEdit4.EditValue?.ToString();
            _inpMatHistDetailList.DataClear(_inpMatHistArgs);
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void InpMatHistHeaderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _inpMatHistArgs.InpMatHistModelArgs.Select_Item_Cd = ((InpMatHistHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
            _inpMatHistArgs.InpMatHistModelArgs.Select_Bp_Cd = ((InpMatHistHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            _inpMatHistDetailList.DataRefresh(_inpMatHistArgs);
        }
    }
}

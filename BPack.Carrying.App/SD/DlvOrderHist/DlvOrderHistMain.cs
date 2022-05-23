using BPack.Common.LoginInfo;
using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.DlvOrderHist;
using BPack.Pocket.App.SD.DlvOrderHist;
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

namespace BPack.Carrying.App.SD.DlvOrderHist
{
    public partial class DlvOrderHistMain : StrapMainForm
    {
        private DlvOrderHistArgs _dlvOrderArgs;
        private DlvOrderHistPocket _dlvOrderPocket;

        private DlvOrderHistList _dlvOrderList;
        private DlvOrderHistDetailList _dlvOrderDetailList;
        private DlvOrderHistHuDetailList _dlvOrderHistHuDetailList;

        string trLang;
        public DlvOrderHistMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _dlvOrderArgs = new DlvOrderHistArgs();
            _dlvOrderPocket = new DlvOrderHistPocket();
 
            _dlvOrderList = new DlvOrderHistList(_dlvOrderArgs, _dlvOrderPocket);
            _dlvOrderDetailList = new DlvOrderHistDetailList(_dlvOrderArgs, _dlvOrderPocket);
            _dlvOrderHistHuDetailList= new DlvOrderHistHuDetailList(_dlvOrderArgs, _dlvOrderPocket);
            AddSubForm(this, _dlvOrderList, layoutControlGroup4);
            AddSubForm(this, _dlvOrderDetailList, layoutControlGroup2);
            AddSubForm(this, _dlvOrderHistHuDetailList, layoutControlGroup5);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _dlvOrderArgs,
                InitlistForm = _dlvOrderList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });

            InitRibbonButtons(true);
            this.SelectedSubFormChanged += DlvOrderHistMain_SelectedSubFormChanged;
            _dlvOrderList.ModelSelectedEvent += DlvOrderHistList_ModelSelectedEvent;
            _dlvOrderList.AddRefreshTargetSubForm(_dlvOrderDetailList);
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
            LookUpEditHelper.SetByQuery(strapLookUpEdit2, "BpaList", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, BP_CD = "", ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);

            //2022.03.17 정수교 언어변환 
            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup3.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup3.Text = trLang;
            }

            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup4.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup4.Text = trLang;
            }

            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup2.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup2.Text = trLang;
            }

            trLang = LanguagePack.GetTransWord(UserInfo.Sys_Language, layoutControlGroup5.Text);
            if (!string.IsNullOrEmpty(trLang))
            {
                layoutControlGroup5.Text = trLang;
            }
            

        }

        private void DlvOrderHistMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
           
            if (this.SelectedSubForm == _dlvOrderList)
            {
                SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, save: false, delete: false);
            }

        }

        private void DlvOrderHistList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _dlvOrderArgs.DlvOrderHistModelArgs.Select_Main_Dlv_Dt = ((DlvOrderHistModel)e.SelectedModelArgsBase.SelectedModelBase).DLV_DT;
            _dlvOrderArgs.DlvOrderHistModelArgs.Select_Main_BP_CD = ((DlvOrderHistModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            _dlvOrderArgs.DlvOrderHistModelArgs.Select_Main_ITEM_CD = ((DlvOrderHistModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;

            _dlvOrderDetailList.DataRefresh(_dlvOrderArgs);

        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvOrderArgs.DlvOrderHistModelArgs.Search_Main_START_DT    = strapDateEdit1.DateTime;
            _dlvOrderArgs.DlvOrderHistModelArgs.Search_Main_END_DT      = strapDateEdit2.DateTime;
            _dlvOrderArgs.DlvOrderHistModelArgs.Search_Main_ITEM_CD     = textEdit1.EditValue?.ToString();
            _dlvOrderArgs.DlvOrderHistModelArgs.Search_Main_ITEM_NM     = textEdit2.EditValue?.ToString();
            _dlvOrderArgs.DlvOrderHistModelArgs.Search_Main_ITEM_GR1_CD = strapLookUpEdit1.EditValue?.ToString();
            _dlvOrderArgs.DlvOrderHistModelArgs.Search_Main_ITEM_BP_CD = strapLookUpEdit2.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();

            _dlvOrderHistHuDetailList.DataRefresh(_dlvOrderArgs);


        }



    }
}

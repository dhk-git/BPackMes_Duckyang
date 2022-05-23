using BPack.CommonMes.Helpers;
using BPack.Model.App.SD.SalesOrderHist;
using BPack.Pocket.App.SD.SalesOrderHist;
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

namespace BPack.Carrying.App.SD.SalesOrderHist
{
    public partial class SalesOrderHistMain : StrapMainForm
    {
        private SalesOrderHistArgs _dlvOrderArgs;
        private SalesOrderHistPocket _dlvOrderPocket;

        private SalesOrderHistList _dlvOrderList;
        private SalesOrderHistDetailList _dlvOrderDetailList;
        public SalesOrderHistMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _dlvOrderArgs = new SalesOrderHistArgs();
            _dlvOrderPocket = new SalesOrderHistPocket();
 
            _dlvOrderList = new SalesOrderHistList(_dlvOrderArgs, _dlvOrderPocket);
            _dlvOrderDetailList = new SalesOrderHistDetailList(_dlvOrderArgs, _dlvOrderPocket);
 
            AddSubForm(this, _dlvOrderList, layoutControlGroup4);
            AddSubForm(this, _dlvOrderDetailList, layoutControlGroup2);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _dlvOrderArgs,
                InitlistForm = _dlvOrderList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayout1
            });

            InitRibbonButtons(true);
            this.SelectedSubFormChanged += SalesOrderHistMain_SelectedSubFormChanged;
            _dlvOrderList.ModelSelectedEvent += SalesOrderHistList_ModelSelectedEvent;
            _dlvOrderList.AddRefreshTargetSubForm(_dlvOrderDetailList);
            LookUpEditHelper.SetByQuery(strapLookUpEdit1, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode, ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);
            LookUpEditHelper.SetByQuery(strapLookUpEdit2, "BpaList", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, BP_CD = "", ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME", isTotalRow: true);

        }

        private void SalesOrderHistMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
           
            if (this.SelectedSubForm == _dlvOrderList)
            {
                SetRibbonButtonsEnable_ByAuth(true, add: false, edit: false, save: false, delete: false);
            }

        }

        private void SalesOrderHistList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _dlvOrderArgs.SalesOrderHistModelArgs.Select_Main_Sor_Dt = ((SalesOrderHistModel)e.SelectedModelArgsBase.SelectedModelBase).SOR_DT;
            _dlvOrderArgs.SalesOrderHistModelArgs.Select_Main_BP_CD = ((SalesOrderHistModel)e.SelectedModelArgsBase.SelectedModelBase).BP_CD;
            _dlvOrderArgs.SalesOrderHistModelArgs.Select_Main_ITEM_CD = ((SalesOrderHistModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
            _dlvOrderDetailList.DataRefresh(_dlvOrderArgs);

        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _dlvOrderArgs.SalesOrderHistModelArgs.Search_Main_START_DT    = strapDateEdit1.DateTime;
            _dlvOrderArgs.SalesOrderHistModelArgs.Search_Main_END_DT      = strapDateEdit2.DateTime;
            _dlvOrderArgs.SalesOrderHistModelArgs.Search_Main_ITEM_CD     = textEdit1.EditValue?.ToString();
            _dlvOrderArgs.SalesOrderHistModelArgs.Search_Main_ITEM_NM     = textEdit2.EditValue?.ToString();
            _dlvOrderArgs.SalesOrderHistModelArgs.Search_Main_ITEM_GR1_CD = strapLookUpEdit1.EditValue?.ToString();
            _dlvOrderArgs.SalesOrderHistModelArgs.Search_Main_ITEM_BP_CD = strapLookUpEdit2.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();

        }

        
      
    }
}

using BPack.CommonMes.Helpers;
using BPack.Model.App.MD.PrdStdRouting;
using BPack.Pocket.App.MD.PrdStdRouting;
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

namespace BPack.Carrying.App.MD.PrdStdRouting
{
    public partial class PrdStdRoutingMain : StrapMainForm
    {
        private PrdStdRoutingArgs _prdStdRoutingArgs;
        private PrdStdRoutingPocket _prdStdRoutingPocket;
        private StdRoutingList _stdRoutingList;
        private StdRoutingDetailList _stdRoutingDetailList;

        public PrdStdRoutingMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _prdStdRoutingArgs = new PrdStdRoutingArgs();
            _prdStdRoutingPocket = new PrdStdRoutingPocket();

            _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, new { COMP_CD = Common.LoginInfo.UserInfo.CompCode }, isTotalRow: false, isFirstSelect: true);
            _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();

            _stdRoutingList = new StdRoutingList(_prdStdRoutingArgs, _prdStdRoutingPocket);
            _stdRoutingDetailList = new StdRoutingDetailList(_prdStdRoutingArgs, _prdStdRoutingPocket);
            AddSubForm(this, _stdRoutingList, layoutControlGroup2);
            AddSubForm(this, _stdRoutingDetailList, layoutControlGroup3);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _prdStdRoutingArgs,
                InitlistForm = _stdRoutingList,
                IsAutoDataRefreshOnShown = true,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, true, false, true, true);
            LookUpEditHelper.SetByQuery(strapLookUpEdit2, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = strapLookUpEdit2.EditValue?.ToString(), ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME");
            strapLookUpEdit1.EditValueChanged += StrapLookUpEdit1_EditValueChanged;
            _stdRoutingList.ModelSelectedEvent += StdRoutingList_ModelSelectedEvent;

        }

        private void StdRoutingList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Str_No = ((StdRoutingModel)e.SelectedModelArgsBase.SelectedModelBase).STR_NO;
            _stdRoutingDetailList.DataRefresh(_prdStdRoutingArgs);
        }

        private void StrapLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEditHelper.SetByQuery(strapLookUpEdit2, "ItemGroupDetail", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = strapLookUpEdit2.EditValue?.ToString(), ITEM_GR_CLS = "ITEM_GR_1" }, "CODE", "NAME");
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Item_Gr = strapLookUpEdit2.EditValue?.ToString();
            _prdStdRoutingArgs.PrdStdRoutingModelArgs.Select_Main_Apply_Dt = null;
            _stdRoutingDetailList.DataClear(_prdStdRoutingArgs);
            base.Refresh_From_ExecuteByRibbonButton();
        }
    }
}

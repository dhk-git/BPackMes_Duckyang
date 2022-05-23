using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WoeResultBatch;
using BPack.Pocket.App.PC.WoeResultBatch;
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

namespace BPack.Carrying.App.PC.WoeResultBatch
{
    public partial class WoeResultBatchMain : StrapMainForm
    {
        private WoeResultBatchArgs _woeResultBatchArgs;
        private WoeResultBatchPocket _woeResultBatchPocket;
        private WoeResultBatchWorkOrderList _woeResultBatchWorkOrderList;
        private WoeResultBatchMatList _woeResultBatchMatList;
        private WoeResultBatchResultList _woeResultBatchResultList;

        public WoeResultBatchMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            _woeResultBatchArgs = new WoeResultBatchArgs();
            _woeResultBatchPocket = new WoeResultBatchPocket();
            _woeResultBatchWorkOrderList = new WoeResultBatchWorkOrderList(_woeResultBatchArgs, _woeResultBatchPocket);
            _woeResultBatchMatList = new WoeResultBatchMatList(_woeResultBatchArgs, _woeResultBatchPocket);
            _woeResultBatchResultList = new WoeResultBatchResultList(_woeResultBatchArgs, _woeResultBatchPocket);
            AddSubForm(this, _woeResultBatchWorkOrderList, layoutControlGroup2);
            AddSubForm(this, _woeResultBatchMatList, layoutControlGroup3);
            AddSubForm(this, _woeResultBatchResultList, layoutControlGroup4);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _woeResultBatchArgs,
                InitlistForm = _woeResultBatchWorkOrderList,
                IsAutoDataRefreshOnShown = true,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true);
            _woeResultBatchWorkOrderList.ModelSelectedEvent += WoeResultBatchWorkOrderList_ModelSelectedEvent;
            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, false, true, true);
        }

        private void WoeResultBatchWorkOrderList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Wo_No = ((WoeResultBatchWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).WO_NO;
            _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Route_No = ((WoeResultBatchWorkOrderModel)e.SelectedModelArgsBase.SelectedModelBase).ROUTE_NO;
            _woeResultBatchMatList.DataRefresh(_woeResultBatchArgs);
            _woeResultBatchResultList.DataRefresh(_woeResultBatchArgs);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Main_Plant_Cd = strapLookUpEdit1.EditValue?.ToString();
            _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Main_Wc_Cd = "";
            _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;
            _woeResultBatchArgs.WoeResultBatchModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;
            base.Refresh_From_ExecuteByRibbonButton();
        }

        //실적등록 버튼
        private void strapButton1_Click(object sender, EventArgs e)
        {
            var selectedHuList = _woeResultBatchMatList.GetSelectedHuList();
            if (selectedHuList.Count == 0)
            {
                StrapMessageBox.Show("사용할 식별표를 선택하십시오"); 
                return;
            }
            var selectedHuQty = selectedHuList.Sum(a => a.HU_STOCK_QTY);
            var selectedHuListString = selectedHuList.Select(a => a.HU_NO).ToList<string>().Aggregate((a, b) => a + "^#^" + b);

            _woeResultBatchArgs.SelectedHuList = selectedHuListString;
            _woeResultBatchArgs.SelectedHuQty = selectedHuQty;
            _woeResultBatchArgs.OperQty = selectedHuList[0].OPER_QTY;
            _woeResultBatchResultList.OpenResultForm();

            //if (StrapMessageBox.Show("생산실적을 등록합니다.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            
            //}

        }
        //식별표 출력 버튼
        private void strapButton2_Click(object sender, EventArgs e)
        {
            var selectedHuList = _woeResultBatchResultList.GetSelectedHuList();
            if (selectedHuList.Count == 0)
            {
                StrapMessageBox.Show("파렛트 식별표를 선택하십시오");
                return;
            }
            var report = Report.App.Factory.HandlingUnitReportFactory.GetInstance();
            var selectedHuListString = selectedHuList.Select(a => a.HU_NO).ToList();
            report.HandlingUnit_BoxProd(selectedHuListString).ShowPreviewDialog();

        }
    }
}

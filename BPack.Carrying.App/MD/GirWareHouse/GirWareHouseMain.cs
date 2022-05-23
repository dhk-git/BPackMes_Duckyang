using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.IStrap.Forms;
using BPack.Model.App.MD.GirWareHouse;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.GirWareHouse;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Carrying.App.MD.GirWareHouse
{
    public partial class GirWareHouseMain : StrapMainForm
    {
        private GirWareHousePocket _girWareHousePocket;
        private GirWareHouseArgs _girWareHouseArgs;
        private GirWhList _girWhList;
        private GirLocList _girLocList;

        public GirWareHouseMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _girWareHouseArgs = new GirWareHouseArgs();
            _girWareHousePocket = new GirWareHousePocket();
            _girWhList = new GirWhList(_girWareHouseArgs, _girWareHousePocket);
            _girLocList = new GirLocList(_girWareHouseArgs, _girWareHousePocket);
            

            AddSubForm(this, _girWhList, layoutControlGroup2);
            AddSubForm(this, _girLocList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _girWareHouseArgs,
                InitlistForm = _girWhList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });
            InitRibbonButtons(true, true, true, true);
            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
            };
            LookUpEditHelper.SetCompCode(strapLookUpEdit1);


            _girWhList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _girWareHouseArgs.girWareHouseModelArgs.Select_Comp_Code = ((WareHouseModel)e.SelectedModelArgsBase.SelectedModelBase).COMP_CD;
                _girWareHouseArgs.girWareHouseModelArgs.Select_Plant_Code = ((WareHouseModel)e.SelectedModelArgsBase.SelectedModelBase).PLANT_CD;
                _girWareHouseArgs.girWareHouseModelArgs.Select_WareHouse_Code = ((WareHouseModel)e.SelectedModelArgsBase.SelectedModelBase).WH_CD;
                _girWareHouseArgs.girWareHouseModelArgs.Select_WareHouse_Group = ((WareHouseModel)e.SelectedModelArgsBase.SelectedModelBase).WH_GR;
                _girLocList.DataRefresh(_girWareHouseArgs);
            };

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _girWhList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: true, delete: true); }
                if (this.SelectedSubForm == _girLocList) { SetRibbonButtonsEnable_ByAuth(add: true, edit: false, delete: true, save:true); }
            };

        
        }

        protected override void OnShown(EventArgs e)
        {
            strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
            base.OnShown(e);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _girWareHouseArgs.girWareHouseModelArgs.Select_Main_Comp_Code = strapLookUpEdit1.EditValue?.ToString();
            _girWareHouseArgs.girWareHouseModelArgs.Select_Main_Plant_Code = strapLookUpEdit2.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

        
/*        private void strapButton1_Click(object sender, EventArgs e)
        {
                _xtraReport1.ShowPreviewDialog();
                _xtraReport1.Location = new Point(50, 50);
        }*/

        private void btnPrintBarcodeLabel_Click(object sender, EventArgs e)
        {

            _girLocList.ShowLocBarcodeReport(LocBacodeType.Label);
        }

        private void btnPrintBarcodeA4_Click(object sender, EventArgs e)
        {
            _girLocList.ShowLocBarcodeReport(LocBacodeType.A4);
        }
    }
}

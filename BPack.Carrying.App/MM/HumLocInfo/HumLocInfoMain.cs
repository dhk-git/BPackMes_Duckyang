using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.HumLocInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPack.Report.App.Factory;
using BPack.Model.App.MM.HumLocInfo;
using BPack.Report.App.Factory.Dy_HandlingUnit;

namespace BPack.Carrying.App.MM.HumLocInfo
{
    public partial class HumLocInfoMain : StrapMainForm
    {
        private HumLocInfoPocket _humLocInfoPocket;
        private HumLocInfoArgs _humLocInfoArgs;
        private HumLocInfoList _humLocInfoList;

        public HumLocInfoMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            _humLocInfoArgs = new HumLocInfoArgs();
            _humLocInfoPocket = new HumLocInfoPocket();
            _humLocInfoList = new HumLocInfoList(_humLocInfoArgs, _humLocInfoPocket);

            AddSubForm(this, _humLocInfoList, layoutControlGroup2);

            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _humLocInfoArgs,
                InitlistForm = _humLocInfoList,
                StrapLayout = strapLayout1
            });
            InitRibbonButtons(true, false, false, true);

            strapButtonEdit_ItemMaster1.InitStrap();
            strapButtonEdit_ItemMaster1.InitCompCode(Common.LoginInfo.UserInfo.CompCode);

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                strapButtonEdit_ItemMaster1.InitPlantCode(strapLookUpEdit2.EditValue?.ToString());
                LookUpEditHelper.SetWareHouse(strapLookUpEdit2, Common.LoginInfo.UserInfo.CompCode, strapLookUpEdit1.EditValue?.ToString(), true, true);
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetLocation(strapLookUpEdit3, Common.LoginInfo.UserInfo.CompCode, strapLookUpEdit1.EditValue?.ToString(), strapLookUpEdit2.EditValue?.ToString(), true, true);
            };

            LookUpEditHelper.SetPlantCode(strapLookUpEdit1, Common.LoginInfo.UserInfo.CompCode, isFirstSelect: true);
            //공장 Lookupedit 숨김
            layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //strapLookUpEdit1.EditValue = Common.LoginInfo.UserInfo.CompCode;
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _humLocInfoArgs.HumLocInfoModelArgs.Select_Main_Plant_Code = strapLookUpEdit1.EditValue?.ToString();
            _humLocInfoArgs.HumLocInfoModelArgs.Select_Main_Ware_House = strapLookUpEdit2.EditValue?.ToString();
            _humLocInfoArgs.HumLocInfoModelArgs.Select_Main_Location = strapLookUpEdit3.EditValue?.ToString();
            _humLocInfoArgs.HumLocInfoModelArgs.Select_Main_Item_Code = strapButtonEdit_ItemMaster1.EditValue?.ToString();
            _humLocInfoArgs.HumLocInfoModelArgs.Select_Main_Hu_No = strapTextEdit1.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void btnPrintSampleBarcode_Click(object sender, EventArgs e)
        {
            //2021.12.17 정수교
            Dy_HandlingUnitReportFactory rf = Dy_HandlingUnitReportFactory.GetInstance();

            //2021.12.17 dy로 변경
            //HandlingUnitReportFactory rf = HandlingUnitReportFactory.GetInstance();
            var checkedModels = _humLocInfoList.GetCheckedModels();
            if (!checkedModels.Any())
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }

            List<string> huNoList = new List<string>();
            foreach (HumLocInfoModel model in checkedModels)
            {
                huNoList.Add(model.HU_NO);
            }
            rf.HandlingUnit_HuSampleBarcode(huNoList).ShowPreviewDialog();
        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    _humLocInfoList.PrintHu();
        //}

    }
}

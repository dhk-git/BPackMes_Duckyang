using BPack.Common.Pocket;
using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.HumHuMaster;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.HumHuMaster;
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
using BPack.Report.App.Factory.Dy_HandlingUnit;

namespace BPack.Carrying.App.MM.HumHuMaster
{
    public partial class HumHuMasterMain : StrapMainForm
    {
        private HumHuMasterArgs _humHuMasterArgs;
        private HuList _huList;
        private ChildHuList _childHuList;
        private HumHuMasterPocket _humHuMasterPocket;

        public HumHuMasterMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();
            
            _humHuMasterArgs = new HumHuMasterArgs();
            _humHuMasterPocket = new HumHuMasterPocket();
            _huList = new HuList(_humHuMasterArgs, _humHuMasterPocket);
            _childHuList = new ChildHuList(_humHuMasterArgs, _humHuMasterPocket);

            AddSubForm(this, _huList, layoutControlGroup2);
            AddSubForm(this, _childHuList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm() 
            {
                FormArgs = _humHuMasterArgs,
                InitlistForm = _huList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = false
            });

            _huList.AddRefreshTargetSubForm(_childHuList);
            _huList.ModelSelectedEvent += HuList_ModelSelectedEvent;

            strapButtonEdit_ItemMaster1.InitStrap();
            strapButtonEdit_ItemMaster1.InitCompCode(Common.LoginInfo.UserInfo.CompCode);
            strapLookUpEdit2.EditValueChanged += StrapLookUpEdit2_EditValueChanged;

            InitRibbonButtons(true, false, false, false, false);
            this.SelectedSubFormChanged += HumHuMasterMain_SelectedSubFormChanged;

            LookUpEditHelper.SetSysCode(strapLookUpEdit1, "HU_TYPE", isTotalRow: false, isFirstSelect: true);
            LookUpEditHelper.SetPlantCode(strapLookUpEdit2, Common.LoginInfo.UserInfo.CompCode, isFirstSelect: true);
            strapDateEdit1.EditValue = DateTime.Now.Date;
        }

        private void HumHuMasterMain_SelectedSubFormChanged(object sender, EventArgs e)
        {
            //if (this.SelectedSubForm == _huList)
            //{

            //}
        }

        private void StrapLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            strapButtonEdit_ItemMaster1.InitPlantCode(strapLookUpEdit2.EditValue?.ToString());
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _humHuMasterArgs.HumHuMasterModelArgs.Select_Comp_Cd = Common.LoginInfo.UserInfo.CompCode;
            _humHuMasterArgs.HumHuMasterModelArgs.Select_Main_Hu_Type = strapLookUpEdit1.EditValue?.ToString();
            _humHuMasterArgs.HumHuMasterModelArgs.Select_Main_Plant_Cd = strapLookUpEdit2.EditValue?.ToString();
            _humHuMasterArgs.HumHuMasterModelArgs.Select_Main_Item_Cd = strapButtonEdit_ItemMaster1.EditValue?.ToString();
            _humHuMasterArgs.HumHuMasterModelArgs.Select_Main_Hu_No = strapTextEdit1.EditValue?.ToString();
            _humHuMasterArgs.HumHuMasterModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _humHuMasterArgs.HumHuMasterModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            _humHuMasterArgs.HumHuMasterModelArgs.Select_Main_Barcode_Text = strapTextEdit2.EditValue?.ToString();
            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void HuList_ModelSelectedEvent(object sender, ArgsBase e)
        {
            _humHuMasterArgs.HumHuMasterModelArgs.Select_Hu_No = ((HuModel)e.SelectedModelArgsBase.SelectedModelBase).HU_NO;
            _childHuList.DataRefresh(_humHuMasterArgs);
        }

        private void btnPrintSampleBarcode_Click(object sender, EventArgs e)
        {
            HandlingUnitReportFactory rf = HandlingUnitReportFactory.GetInstance();
            List<string> huNoList = new List<string>();
            //2021.12.17 동일한 Barcode_type 만 선택 
            List<HuModel> models = _huList.SelectedModels as List<HuModel>;
            int _barcodeTypeCnt = models
                            .Where(v => v.IsCheck==true)
                            .GroupBy(v => v.BARCODE_TYPE).Count();
            string _BarcodeType = models.Where(v => v.IsCheck == true).Select(v => v.BARCODE_TYPE).FirstOrDefault();
            if (_barcodeTypeCnt == 0)
            {
                //선택된 건이 없습니다.
                StrapMessageBox.Show("A002", 12);
                return;
            }
            else
            {
                foreach (HuModel model in models)
                {
                    if (model.IsCheck == true)
                    {
                        huNoList.Add(model.HU_NO);
                    }
                }
                rf.HandlingUnit_HuSampleBarcode(huNoList).ShowPreviewDialog();
            }
        }

        private void btnPrintLPackBarcode_Click(object sender, EventArgs e)
        {
            //2021.12.17 정수교 dy 로 파일 변경
            Dy_HandlingUnitReportFactory rf = Dy_HandlingUnitReportFactory.GetInstance();

            //HandlingUnitReportFactory rf = HandlingUnitReportFactory.GetInstance();

            List<string> huNoList = new List<string>();

            //2021.12.17 동일한 Barcode_type 만 선택 
            List<HuModel> models = _huList.SelectedModels as List<HuModel>;
            int _barcodeTypeCnt = models
                            .Where(v => v.IsCheck == true)
                            .GroupBy(v => v.BARCODE_TYPE).Count();
            string _BarcodeType = models.Where(v => v.IsCheck == true).Select(v => v.BARCODE_TYPE).FirstOrDefault();
            if (_barcodeTypeCnt == 0)
            {
                //선택된 건이 없습니다.
                StrapMessageBox.Show("A002", 12);
                return;
            }
            else if (_barcodeTypeCnt > 1)
            {
                //동일한 유형의 식별표만 출력할수 있습니다
                StrapMessageBox.Show("A002", 30);
                return;
            }
            else
            {
                foreach (HuModel model in models)
                {
                    if (model.IsCheck == true)
                    {
                        huNoList.Add(model.HU_NO);
                    }
                }
                switch (_BarcodeType)
                {
                    case "PLS":
                        //대포장 바코드
                        rf.HandlingUnit_LPackingBarcode(huNoList).ShowPreviewDialog();
                        break;
                    case "SERIAL_GOODS":
                    case "PRG":
                        //완제품 바코드
                        rf.HandlingUnit_HuSampleBarcode(huNoList).ShowPreviewDialog();
                        break;
                }
            }
        }
    }
}

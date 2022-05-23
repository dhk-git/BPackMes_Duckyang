using BPack.CommonMes.Helpers;
using BPack.Model.App.MM.HumMebBarcode;
using BPack.Pocket.App.MM.HumMebBarcode;
using BPack.Report.App.Factory.Dy_HandlingUnit;
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

namespace BPack.Carrying.App.MM.HumMebBarcode
{
    public partial class HumMebBarcodeMain : StrapMainForm
    {
        private HumMebBarcodeArgs _humMebBarcodeArgs;
        private HumMebBarcodePocket _humMebBarcodePocket;
        private HumMebBarcodeList _humMebBarcodeList;

        public HumMebBarcodeMain()
        {
            InitializeComponent();
        }
        public override void InitStrap()
        {
            base.InitStrap();

            _humMebBarcodeArgs = new HumMebBarcodeArgs();
            _humMebBarcodePocket = new HumMebBarcodePocket();
            _humMebBarcodeList = new HumMebBarcodeList(_humMebBarcodeArgs, _humMebBarcodePocket);
            AddSubForm(this, _humMebBarcodeList, layoutControlGroup3);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _humMebBarcodeArgs,
                InitlistForm = _humMebBarcodeList,
                StrapLayout = strapLayout1,
                IsAutoDataRefreshOnShown = true
            });
            InitRibbonButtons(true, false, false, false);

            LookUpEditHelper.SetCompCode(sleCompCd);
            

            ctl_Start_dt.EditValue = DateTime.Now;
            ctl_End_dt.EditValue = DateTime.Now;
            sleCompCd.EditValue = Common.LoginInfo.UserInfo.CompCode;
            slePlantCd.EditValue = Common.LoginInfo.UserInfo.PlantCode;
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();

            ctl_New_ItemCd.InitStrap();
            ctl_New_ItemCd.InitCompCode(_humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Comp_Cd);
            ctl_New_ItemCd.InitPlantCode(_humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Plant_Cd);
            ctl_New_ItemCd.ButtonClick += Ctl_New_ItemCd_ButtonClick;
            ctl_New_WorkDT.EditValue = DateTime.Now;
            ctl_new_PackDate.EditValue = DateTime.Now;
            ctl_new_ShipDate.EditValue = DateTime.Now;


            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
            
            //MEB 바코드 식별표 유형
            LookUpEditHelper.SetByQuery(ctl_BarcodeType, "SysCode_Condition"
                , new 
                {
                    P_CODE = "BARCODE_TYPE",
                    VALUE_1 = "MEB",
                    VALUE_2 = "",
                    VALUE_3 = "",
                    VALUE_4 = "",
                    VALUE_5 = ""

                }
                , "CODE","NAME");
            LookUpEditHelper.SetByQuery(ctl_New_MebType, "SysCode_Condition"
                , new
                {
                    P_CODE = "BARCODE_TYPE",
                    VALUE_1 = "MEB",
                    VALUE_2 = "",
                    VALUE_3 = "",
                    VALUE_4 = "",
                    VALUE_5 = ""

                }
                , "CODE", "NAME");
            //LookUpEditHelper.SetSysCode(ctl_New_MebType, "HU_MEB_TYPE",total:false,isFirstSelect:true,isTotalRow:false);
            ctl_New_BarcodeType_EditValueChanged(null, null);

            sleCompCd.EditValueChanged += SleCompCd_EditValueChanged;
            slePlantCd.EditValueChanged += SlePlantCd_EditValueChanged;
            
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Start_Dt = ctl_Start_dt.DateTime;
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_End_Dt = ctl_End_dt.DateTime;

        }

        private void Ctl_New_ItemCd_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ctl_New_ItemCd.InitCompCode(_humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Comp_Cd);
            ctl_New_ItemCd.InitPlantCode(_humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Plant_Cd);
            ctl_New_ItemCd.DataClear();
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Comp_Cd = sleCompCd.EditValue?.ToString();
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Plant_Cd = slePlantCd.EditValue?.ToString();
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Start_Dt = ctl_Start_dt.DateTime;
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_End_Dt = ctl_End_dt.DateTime;
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Barcode_Type = ctl_BarcodeType.EditValue?.ToString();
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Item_Cd = ctl_ItemCd.EditValue?.ToString();

            base.Refresh_From_ExecuteByRibbonButton();
        }

        private void SlePlantCd_EditValueChanged(object sender, EventArgs e)
        {
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Comp_Cd
                = sleCompCd.EditValue?.ToString();
            LookUpEditHelper.SetPlantCode(slePlantCd, new { COMP_CD = sleCompCd.EditValue?.ToString() }, isFirstSelect: true);
        }

        private void SleCompCd_EditValueChanged(object sender, EventArgs e)
        {
            _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Plant_Cd 
                = slePlantCd.EditValue?.ToString();
        }

        private void ctl_New_BarcodeType_EditValueChanged(object sender, EventArgs e)
        {
            switch (ctl_New_MebType.EditValue?.ToString())
            {
                //대포장
                case "LPACK":
                    //Ly01_OrderNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    
                    Ly01_WorkDate.Visibility= DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    Ly01_PackDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    Ly01_ShipDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                //중포장
                case "MPACK":

                    //Ly01_OrderNo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

                    Ly01_WorkDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    Ly01_PackDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    Ly01_ShipDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;  

            }
        }

        private void Btn_CreateHu_Click(object sender, EventArgs e)
        {
            //기본값저장.
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.RowState = Common.Model.RowState.Added;
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.CREATE_USER_ID
                = Common.LoginInfo.UserInfo.UserID;
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.MODIFY_USER_ID
                = Common.LoginInfo.UserInfo.UserID;
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.LANG_CODE
                = Common.LoginInfo.UserInfo.Sys_Language;
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.CREATE_DTTM
                = DateTime.Now;
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.MODIFY_DTTM
                = DateTime.Now;

            _humMebBarcodeArgs.NewhumMebBarcodeArgs.COMP_CD
                    = _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Comp_Cd;
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.PLANT_CD
                    = _humMebBarcodeArgs.HumMebBarcodeModelArgs.Select_Main_Plant_Cd;
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.HU_MEB_TYPE
                = ctl_New_MebType.EditValue?.ToString();

            _humMebBarcodeArgs.NewhumMebBarcodeArgs.ORDER_NO
                = ctl_new_OrderNo.EditValue?.ToString();
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.WORK_DT
                = ctl_New_WorkDT.DateTime;
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.ITEM_CD
                    = ctl_New_ItemCd.EditValue?.ToString();
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.PACK_DATE
                = ctl_new_PackDate.DateTime;
            _humMebBarcodeArgs.NewhumMebBarcodeArgs.SHIP_DATE
                = ctl_new_ShipDate.DateTime;

            _humMebBarcodeArgs.NewhumMebBarcodeArgs.INIT_QTY
                = Convert.ToInt32(ctl_New_HuQty.EditValue);

            if (string.IsNullOrEmpty(_humMebBarcodeArgs.NewhumMebBarcodeArgs.HU_MEB_TYPE)
                || string.IsNullOrEmpty(_humMebBarcodeArgs.NewhumMebBarcodeArgs.ITEM_CD)
                )
            {
                //필수항목이 누락되었습니다.
                StrapMessageBox.Show("A001", 116);
                return;
            }

            //발행 유형에 따라 데이터가 등록되어있어야함...
            switch (_humMebBarcodeArgs.NewhumMebBarcodeArgs.HU_MEB_TYPE)
            {
                case "LPACK":
                    if ( string.IsNullOrEmpty(_humMebBarcodeArgs.NewhumMebBarcodeArgs.ORDER_NO)  )
                    {
                        //필수항목이 누락되었습니다.
                        StrapMessageBox.Show("A001", 116);
                        return;
                    }

                    break;

                case "MPACK":
                    //Ly01_PackDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    //Ly01_ShipDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    if (_humMebBarcodeArgs.NewhumMebBarcodeArgs.PACK_DATE.HasValue == false
                        || _humMebBarcodeArgs.NewhumMebBarcodeArgs.SHIP_DATE.HasValue == false
                        )
                    {
                        //필수항목이 누락되었습니다.
                        StrapMessageBox.Show("A001", 116);
                        return;
                    }
                    break;
            }
            List<string> barcodeList= _humMebBarcodeList.SaveNewMebLot(_humMebBarcodeArgs.NewhumMebBarcodeArgs);

            if (barcodeList != null)
            {
                //출력
                switch (_humMebBarcodeArgs.NewhumMebBarcodeArgs.HU_MEB_TYPE)
                {
                    case "LPACK":
                        Dy_HandlingUnitReportFactory rf = Dy_HandlingUnitReportFactory.GetInstance();
                        rf.HandlingUnit_LPackingBarcode(barcodeList).ShowPreviewDialog();
                        break;

                    case "MPACK":
                        Dy_HandlingUnitReportFactory rf2 = Dy_HandlingUnitReportFactory.GetInstance();
                        rf2.HandlingUnit_MPackingBarcode(barcodeList).ShowPreviewDialog();
                        break;
                }
            }

            _humMebBarcodeList.DataRefresh(_humMebBarcodeArgs);
        }

        private void CreateHuInit()
        {
            _humMebBarcodeArgs.NewhumMebBarcodeArgs = new Model.App.MM.HumMebBarcode.NewHumMebBarcodeArgs();
            ctl_new_OrderNo.EditValue = "";
            ctl_New_WorkDT.EditValue = DateTime.Now;
            ctl_New_ItemCd.EditValue = "";
            ctl_new_PackDate.EditValue = DateTime.Now;
            ctl_new_ShipDate.EditValue = DateTime.Now;
            ctl_New_HuQty.EditValue = 1;
            


        }

        private void btnPrintSampleBarcode_Click(object sender, EventArgs e)
        {
            Dy_HandlingUnitReportFactory rf = Dy_HandlingUnitReportFactory.GetInstance();
            List<string> barcodeList = new List<string>();
            List<string> huNoList = new List<string>();

            List<HumMebBarcodeModel> models = _humMebBarcodeList.SelectedModels as List<HumMebBarcodeModel>;
            int _barcodeTypeCnt = models
                            .Where(v => v.IsCheck == true)
                            .GroupBy(v => v.HU_MEB_TYPE).Count();
            string _mebType = models.Where(v => v.IsCheck == true).Select(v => v.HU_MEB_TYPE).FirstOrDefault();
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
                foreach (HumMebBarcodeModel model in models)
                {
                    if (model.IsCheck == true)
                    {
                        barcodeList.Add(model.BARCODE_TEXT);
                        huNoList.Add(model.HU_NO);
                    }
                }
                switch (_mebType)
                {
                    case "LPACK":
                        //대포장 바코드
                        rf.HandlingUnit_LPackingBarcode(huNoList).ShowPreviewDialog();
                        break;
                    case "MPACK":
                        //완제품 바코드
                        rf.HandlingUnit_MPackingBarcode(barcodeList).ShowPreviewDialog();
                        break;
                }
            }
        }
    }
}

using BPack.CommonMes.Controls.SerialPortSelect;
using BPack.CommonMes.Helpers;
using BPack.CommonMes.IO.SerialComm;
using BPack.Model.App.MM.HumEmptyLabel;
using BPack.Pocket.App.MM.HumEmptyLabel;
using BPack.Report.App.Factory;
using BPack.Report.App.HandlingUnit.Commands;
using BPack.Strap.FormControls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace BPack.Carrying.App.MM.HumEmptyLabel
{
    public partial class HumEmptyLabelMain : StrapMainForm
    {
        private HumEmptyLabelArgs _humEmptyLabelArgs;
        private HumEmptyLabelPocket _humEmptyLabelPocket;
        private PrintedBarcodeList _printedBarcodeList;

        SerialComm serialComm;
        SerialPortSeletor serialPortSeletor;
        SerialPortSelctorModel serialPortSelctorModel;

        public HumEmptyLabelMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            strapDateEdit1.EditValue = DateTime.Now.Date;
            strapDateEdit2.EditValue = DateTime.Now.Date;
            dteWorkDT.EditValue = DateTime.Now.Date;


            _humEmptyLabelArgs = new HumEmptyLabelArgs();
            _humEmptyLabelPocket = new HumEmptyLabelPocket();
            _printedBarcodeList = new PrintedBarcodeList(_humEmptyLabelArgs, _humEmptyLabelPocket);
            InitFields(new FieldArgs_StrapMainForm
            {
                FormArgs = _humEmptyLabelArgs,
                InitlistForm = _printedBarcodeList,
                IsAutoDataRefreshOnShown = false,
                StrapLayout = strapLayoutControl1
            });
            AddSubForm(this, _printedBarcodeList, layoutControlGroup4);
            InitRibbonButtons(true);

            LookUpEditHelper.SetCompCode(lueComp);

            lueComp.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(luePlant, lueComp.EditValue?.ToString(), isFirstSelect: true);
                LookUpEditHelper.SetBusinessPartner(lueBusinessPartner, lueComp.EditValue?.ToString(), isPurchase: true, isSales: false);

                _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Comp_CD = lueComp.EditValue?.ToString();

            };

            luePlant.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetWorkCenter(lueWorkCenter, lueComp.EditValue?.ToString(), luePlant.EditValue?.ToString(), isFirstSelect: true);
                LookUpEditHelper.SetDeviceID(lueDevice, lueComp.EditValue?.ToString(), luePlant.EditValue?.ToString(), lueWorkCenter.EditValue?.ToString(), isFirstSelect: true);

                _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Plant_CD = luePlant.EditValue?.ToString();

            };

            lueWorkCenter.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetDeviceID(lueDevice, lueComp.EditValue?.ToString(), luePlant.EditValue?.ToString(), lueWorkCenter.EditValue?.ToString(), isTotalRow: false, isFirstSelect: true);

                _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_WorkCenter_CD = lueWorkCenter.EditValue?.ToString();
            };

            lueDevice.EditValueChanged += (object sender, EventArgs e) =>
            {
                _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Device_ID = lueDevice.EditValue?.ToString();
            };

            itemMasterButtonEdit1.ButtonClick += (object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) =>
            {
                itemMasterButtonEdit1.InitCompCode(_humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Comp_CD);
                itemMasterButtonEdit1.InitPlantCode(_humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Plant_CD);
                itemMasterButtonEdit1.DataClear();
            };

            lueBarcodeType.EditValueChanged += (object sender, EventArgs e) =>
            {
                _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Barcode_Kind = lueBarcodeType.EditValue?.ToString();
            };

            lueBarcodeType2.EditValueChanged += (object sender, EventArgs e) =>
            {
                switch (lueBarcodeType2.EditValue)
                {
                    case "DLV_GOODS":
                    case "MAPPING":
                        layBusinessPartner.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layWorkCenter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layDevice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layHuQty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layNormalPrint.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        break;
                    case "MULTI":
                    case "PALLET_MAT":
                        layBusinessPartner.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layWorkCenter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layDevice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layHuQty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layNormalPrint.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        break;
                    case "PALLET_PROD":
                        layBusinessPartner.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layWorkCenter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layDevice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layHuQty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layNormalPrint.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        break;
                    case "SERIAL_GOODS":
                        layBusinessPartner.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layWorkCenter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layDevice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layHuQty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layNormalPrint.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        speHuQty.EditValue = 1;
                        break;
                    case "SERIAL_SEMI":
                        layBusinessPartner.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layWorkCenter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layDevice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layHuQty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        speHuQty.EditValue = 1;
                        break;
                    default:
                        layBusinessPartner.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layWorkCenter.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layDevice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        layHuQty.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        layNormalPrint.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        break;
                };

                itemMasterButtonEdit1.EditValue = null;
            };

            lueComp.EditValue = Common.LoginInfo.UserInfo.CompCode;

            LookUpEditHelper.SetSysCode(lueBarcodeType, "BARCODE_TYPE", false, isFirstSelect: true, isTotalRow: true);
            LookUpEditHelper.SetSysCode(lueBarcodeType2, "BARCODE_TYPE", false, isFirstSelect: true);

            var data = lueBarcodeType2.Properties.DataSource as List<Strap.EditControls.LookUpEditCommonCodeModel>;
            var source = data.Where(a => a.C_CODE != "DLV_GOODS" && a.C_CODE != "MAPPING" && a.C_CODE != "MULTI").ToList(); //만능바코드는 제외
            var source2 = source.Where(a => a.C_CODE != "").ToList();
            lueBarcodeType.Properties.DataSource = source;
            lueBarcodeType2.Properties.DataSource = source2;

            LookUpEditHelper.TotalRowInsert(lueBarcodeType);
            LookUpEditHelper.Orderby(lueBarcodeType);
            LookUpEditHelper.Orderby(lueBarcodeType2);


            itemMasterButtonEdit1.InitStrap();

            _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Comp_CD = lueComp.EditValue?.ToString();
            _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Plant_CD = luePlant.EditValue?.ToString();
            if (Common.LoginInfo.UserInfo.UserID == "NAP")
            {
                luePlant.EditValue = "11";
                luePlant.ReadOnly = true;
                lueBarcodeType.EditValue = "SERIAL_SEMI";
                lueBarcodeType.ReadOnly = true;
                layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                splitterItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lueBarcodeType2.ReadOnly = true;
                lueBarcodeType2.EditValue = "SERIAL_SEMI";
                lueWorkCenter.EditValue = "VNAP1";
                lueWorkCenter.ReadOnly = true;
                lueDevice.EditValue = "VNAP1-01";
                lueDevice.ReadOnly = true;
            }
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Start_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_End_Dt = strapDateEdit2.DateTime;// (DateTime)strapDateEdit2.EditValue;
            base.Refresh_From_ExecuteByRibbonButton();
        }


        //재발행 버튼
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var data = _printedBarcodeList.GetCheckedData();
            if (data.Count < 1)
            {
                StrapMessageBox.Show("A001", 9);
                return;
            }

            string barcodeType = data[0].BARCODE_KIND;
            //상이한 라벨은 선택할수 없음 메시지 출력할것
            bool isDiffData = false;
            foreach (var item in data)
            {
                if (barcodeType != item.BARCODE_KIND)
                {
                    isDiffData = true;
                }
            }
            if (isDiffData)
            {
                StrapMessageBox.Show("A001", 41);
                return;
            }

            string rePrintingBarcode = "";
            foreach (var item in data)
            {
                rePrintingBarcode += item.BARCODE_NO + "^#^";
            }
            var rePrintingData = _humEmptyLabelPocket.SelectRePrintingModels(rePrintingBarcode);

            if (barcodeType == "MULTI")
            {
                List<string> barcodeNoList = new List<string>();
                foreach (var item in rePrintingData)
                {
                    barcodeNoList.Add(item.BARCODE_NO);
                }
                ShowReportPreviewDialog_Multi(barcodeNoList);
            }
            else
            {
                List<string> huNoList = new List<string>();
                foreach (var item in rePrintingData)
                {
                    huNoList.Add(item.HU_NO);
                }
                ShowReportPreviewDialog(barcodeType, huNoList);
            }

        }

        private void ShowReportPreviewDialog(string barcodeType, List<string> huNoList)
        {
            HandlingUnitReportFactory rf = HandlingUnitReportFactory.GetInstance();


            if (barcodeType == "PALLET_MAT")
            {
                rf.HandlingUnit_Mat(huNoList).ShowPreviewDialog();
            }
            if (barcodeType == "PALLET_PROD")
            {
                rf.HandlingUnit_PalletProd(huNoList).ShowPreviewDialog();
            }
            if (barcodeType == "SERIAL_SEMI")
            {
                var rst = StrapMessageBox.Show("35x55 사이즈(아산)는 '예'\r\n55x25 사이즈(광주)는 '아니오'를 선택하십시오!", MessageBoxButtons.YesNoCancel);
                if ( rst == DialogResult.Yes)
                {
                    rf.HandlingUnit_SerialSemi35x55(huNoList).ShowPreviewDialog();
                }
                else if(rst == DialogResult.No)
                {
                    rf.HandlingUnit_SerialSemi(huNoList).ShowPreviewDialog();
                }
                else
                {
                    return;
                }
            }
            if (barcodeType == "SERIAL_GOODS")
            {
                if (StrapMessageBox.Show("일반 프린터 출력하시겠습니까?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    chkTestPrint.Checked = true;
                }
                else
                {
                    chkTestPrint.Checked = false;
                }
                if (barcodeType == "SERIAL_GOODS" && chkTestPrint.Checked) // 테스트용 일반프린터 출력
                {
                    rf.HandlingUnit_SerialGoods(huNoList).ShowPreviewDialog();
                    return;
                }
                else
                {
                    #region 이더넷 통신

                    //PrintDialog PrintDialog1 = new PrintDialog();
                    //PrintDialog1.ShowDialog();

                    //var printerName = PrintDialog1.PrinterSettings.PrinterName;

                    //var sendList = HandlingUnitBarcodeCommands.CreateSerialGoodsBarcodes(huNoList);
                    //var sendData = String.Join("", sendList);

                    //// 이더넷
                    //var netPrinter = NetworkHelper.getNetworkPrinter(printerName);
                    //if (netPrinter != null)
                    //{
                    //    var portName = netPrinter.Properties["Name"].Value.ToString();
                    //    var hostAddress = netPrinter.Properties["HostAddress"].Value;
                    //    var portNumber = netPrinter.Properties["PortNumber"].Value;
                    //    var endpoint = NetworkHelper.CreateIPEndPoint(hostAddress + ":" + portNumber);

                    //    AsyncSocket socketObject = new AsyncSocket(endpoint);
                    //    Thread thread = new Thread(new ParameterizedThreadStart(socketObject.SendData));
                    //    thread.Start(sendData);
                    //}

                    #endregion ~이더넷 통신

                    #region 시리얼 통신

                    serialPortSeletor = new SerialPortSeletor();
                    serialPortSeletor.SelectedComplate += (object sender, SerialPortSelectedEventArgs e) =>
                    {
                        this.serialPortSelctorModel = e.serialPortSelctorModel;
                    };
                    serialPortSeletor.ShowDialog();


                    if (serialComm == null)
                    {
                        serialComm = new SerialComm("BarcodePrinter1");
                    }

                    if (serialPortSelctorModel != null)
                    {
                        if (serialComm.serialPort == null || serialPortSelctorModel.ComPort != serialComm.serialPort.PortName)
                        {
                            // 시리얼 -> 프린터 드라이브로 잡히면 COM Port 오픈이 안됨. 프린터목록에서 제거 후 사용가능함
                            serialComm.OpenComm(serialPortSelctorModel.ComPort, serialPortSelctorModel.BaudRate, serialPortSelctorModel.DataBits, serialPortSelctorModel.StopBits, serialPortSelctorModel.Parity);
                        }

                        if (serialComm.IsOpen)
                        {
                            var sendList = HandlingUnitBarcodeCommands.CreateSerialGoodsBarcodes(huNoList);
                            var sendData = String.Join("", sendList);

                            byte[] bytes = Encoding.GetEncoding(949).GetBytes(sendData.ToString());
                            serialComm.Send(bytes);
                        }
                        else
                        {
                            StrapMessageBox.Show("A001", 18); // Com Port Open Failed
                        }
                    }

                    #endregion ~시리얼 통신
                }
            }
            if (barcodeType == "MAPPING")
            {
                rf.HandlingUnit_Mapping(huNoList).ShowPreviewDialog();
            }
        }

        private void ShowReportPreviewDialog_Multi(List<string> barcodeNoList)
        {
            HandlingUnitReportFactory rf = HandlingUnitReportFactory.GetInstance();
            rf.HandlingUnit_Multi(barcodeNoList).ShowPreviewDialog();
        }


        //만능 Multi 식별표 발행 버튼
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            if ((decimal)spinEdit1.EditValue <= 0)
            {
                StrapMessageBox.Show("A001", 39);
                return;
            }
            //MultiBarcodeReport report = new MultiBarcodeReport();
            CreateMultiBarcodeModel createMultiBarcodeModel = new CreateMultiBarcodeModel
            {
                CREATING_QTY = Convert.ToInt32(spinEdit1.EditValue),
                RowState = Common.Model.RowState.Added,
                DEVICE_ID = Common.LoginInfo.UserInfo.UserID,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID
            };
            var data = _humEmptyLabelPocket.CreateMultiBarcodeLabel(createMultiBarcodeModel);
            List<string> barcodeNoList = new List<string>();
            foreach (var item in data)
            {
                barcodeNoList.Add(item.BARCODE_NO);
            }
            ShowReportPreviewDialog_Multi(barcodeNoList);

        }

        //유형별 식별표 발행버튼
        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            string barcodeType = lueBarcodeType2.EditValue?.ToString();

            #region 유효성 검사

            if (String.IsNullOrEmpty(barcodeType)) // 식별표유형을 선택해주세요.
            {
                StrapMessageBox.Show("A001", 53);
                return;
            }

            if (String.IsNullOrEmpty(dteWorkDT.EditValue?.ToString()))
            {
                StrapMessageBox.Show("A001", 54); // 작업일을 선택해주세요.
                return;
            }

            if (barcodeType == "PALLET_MAT" || barcodeType == "MULTI")
            {
                if (String.IsNullOrEmpty(lueBusinessPartner.EditValue?.ToString()))
                {
                    StrapMessageBox.Show("A001", 55); // 납품업체를 선택해주세요.
                    return;
                }
            }

            if (barcodeType == "SERIAL_GOODS")
            {
                if (String.IsNullOrEmpty(lueDevice.EditValue?.ToString())) // 단말기코드를 선택해주세요.
                {
                    StrapMessageBox.Show("A001", 52);
                    return;
                }
            }

            if (itemMasterButtonEdit1.EditValue == null)
            {
                StrapMessageBox.Show("A001", 40); // 품번은 필수선택 사항입니다.
                return;
            }

            if ((decimal)speCreatingQty.EditValue <= 0)
            {
                StrapMessageBox.Show("A001", 39); // 발행수량이 0 이하 입니다
                return;
            }

            if ((decimal)speCreatingQty.EditValue > 50)
            {
                StrapMessageBox.Show("A001", 67); // 한번에 50개 이상 발행할 수 없습니다.
                return;
            }

            #endregion ~유효성 검사

            //유형별 출력 
            string deviceId;
            if (lueBarcodeType2.EditValue?.ToString() == "SERIAL_SEMI" || lueBarcodeType2.EditValue?.ToString() == "SERIAL_GOODS")
                deviceId = lueDevice.EditValue?.ToString();
            //deviceId = _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_WorkCenter_CD;
            else
                deviceId = Common.LoginInfo.UserInfo.UserID;
            //deviceId = lueDevice.EditValue?.ToString();
            //deviceId = _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_WorkCenter_CD;
            Common.Config.SystemConfig.RefreshServerDateTime();
            CreatingBarcodeModel creatingBarcodeModel = new CreatingBarcodeModel
            {
                BARCODE_KIND = lueBarcodeType2.EditValue?.ToString(),
                COMP_CD = _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Comp_CD,
                PLANT_CD = _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_Plant_CD,
                WC_CD = _humEmptyLabelArgs.HumEmptyLabelModelArgs.Select_Main_WorkCenter_CD,
                ITEM_CD = itemMasterButtonEdit1.EditValue?.ToString(),
                HU_QTY = (decimal)speHuQty.EditValue,
                CREATING_QTY = Convert.ToInt32(speCreatingQty.EditValue),
                WORK_DT = (DateTime)dteWorkDT.EditValue,
                LOT_NO = ((DateTime)dteWorkDT.EditValue).ToString("yyyyMMdd"),
                CREATE_DTTM = Common.Config.SystemConfig.ServerDateTime,
                MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,

                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                DEVICE_ID = deviceId,
                BP_CD = lueBusinessPartner.EditValue?.ToString(),
                RowState = Common.Model.RowState.Added
            };

            List<string> huNoList = new List<string>();
            try
            {
                var data = _humEmptyLabelPocket.CreateBarcodeLabel(creatingBarcodeModel);
                foreach (var item in data)
                {
                    huNoList.Add(item.HU_NO);
                }

                ShowReportPreviewDialog(barcodeType, huNoList);
            }
            catch (Exception ex)
            {
                StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
            }

        }

        private void HumEmptyLabelMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialComm != null && serialComm.IsOpen) serialComm.CloseComm();
        }
    }
}

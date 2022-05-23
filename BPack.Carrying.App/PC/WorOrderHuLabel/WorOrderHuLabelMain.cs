using BPack.Strap.FormControls;
using BPack.Pocket.App.PC.WorOrderHuLabel;
using System;
using BPack.CommonMes.Helpers;
using BPack.Model.App.PC.WorOrderHuLabel;
using BPack.Report.App.Factory;
using BPack.Common.LoginInfo;
using System.Linq;
using DevExpress.XtraTab;
using BPack.CommonMes.Controls.SerialPortSelect;
using BPack.CommonMes.IO.SerialComm;
using BPack.Report.App.HandlingUnit.Commands;
using System.Text;
using System.Collections.Generic;

namespace BPack.Carrying.App.PC.WorOrderHuLabel
{
    public partial class WorOrderHuLabelMain : StrapMainForm
    {
        private WorOrderHuLabelArgs _worOrderHuLabelArgs;
        private WorOrderHuLabelPocket _worOrderHuLabelPocket;
        private WorOrderHuLabelPalletHeaderList _worOrderHuLabelPalletHeaderList;
        private WorOrderHuLabelPalletDetailList _worOrderHuLabelPalletDetailList;
        private WorOrderHuLabelSerialHeaderList _worOrderHuLabelSerialHeaderList;
        private WorOrderHuLabelSerialDetailList _worOrderHuLabelSerialDetailList;

        SerialComm serialComm;
        SerialPortSeletor serialPortSeletor;
        SerialPortSelctorModel serialPortSelctorModel;

        public WorOrderHuLabelMain()
        {
            InitializeComponent();
        }

        public override void InitStrap()
        {
            base.InitStrap();

            _worOrderHuLabelArgs = new WorOrderHuLabelArgs();
            _worOrderHuLabelPocket = new WorOrderHuLabelPocket();
            _worOrderHuLabelPalletHeaderList = new WorOrderHuLabelPalletHeaderList(_worOrderHuLabelArgs, _worOrderHuLabelPocket);
            _worOrderHuLabelPalletDetailList = new WorOrderHuLabelPalletDetailList(_worOrderHuLabelArgs, _worOrderHuLabelPocket);
            _worOrderHuLabelSerialHeaderList = new WorOrderHuLabelSerialHeaderList(_worOrderHuLabelArgs, _worOrderHuLabelPocket);
            _worOrderHuLabelSerialDetailList = new WorOrderHuLabelSerialDetailList(_worOrderHuLabelArgs, _worOrderHuLabelPocket);

            AddSubForm(this, _worOrderHuLabelPalletHeaderList, layoutControlGroup3);
            AddSubForm(this, _worOrderHuLabelPalletDetailList, layoutControlGroup5);
            AddSubForm(this, _worOrderHuLabelSerialHeaderList, layoutControlGroup7);
            AddSubForm(this, _worOrderHuLabelSerialDetailList, layoutControlGroup9);

            InitFields(new FieldArgs_StrapMainForm()
            {
                FormArgs = _worOrderHuLabelArgs,
                InitlistForm = _worOrderHuLabelPalletHeaderList,
                StrapLayout = strapLayout1
            });
            strapDateEdit1.EditValue = DateTime.Now.Date;
            InitRibbonButtons(true, false, false, false);

            this.SelectedSubFormChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedSubForm == _worOrderHuLabelPalletDetailList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: true, delete: true); }
                else if (this.SelectedSubForm == _worOrderHuLabelSerialDetailList) { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: true, delete: true); }
                else { SetRibbonButtonsEnable_ByAuth(add: false, save: false, edit: false, delete: false); }
            };

            LookUpEditHelper.SetCompCode(strapLookUpEdit1);
            strapButtonEdit_ItemMaster1.InitStrap();

            strapLookUpEdit1.EditValueChanged += (object sender, EventArgs e) =>
            {
                LookUpEditHelper.SetPlantCode(strapLookUpEdit2, new { COMP_CD = strapLookUpEdit1.EditValue?.ToString() }, isFirstSelect: true);
                strapButtonEdit_ItemMaster1.InitCompCode(strapLookUpEdit1.EditValue?.ToString());
            };

            strapLookUpEdit2.EditValueChanged += (object sender, EventArgs e) =>
            {
                SetWorkCenter();
                LookUpEditHelper.SetShiftCode(strapLookUpEdit4, strapLookUpEdit1.EditValue?.ToString(), strapLookUpEdit2.EditValue?.ToString(), isTotalRow: true, isFirstSelect: true);
                strapButtonEdit_ItemMaster1.InitPlantCode(strapLookUpEdit2.EditValue?.ToString());
            };

            strapLookUpEdit1.EditValue = UserInfo.CompCode;

            #region 부품 식별표

            _worOrderHuLabelPalletHeaderList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Pallet_Wo_No = ((WorOrderHuLabelPalletHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).WO_NO;

                txtPallet_WO_NO.EditValue = ((WorOrderHuLabelPalletHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).WO_NO;
                txtPallet_ITEM_CD.EditValue = ((WorOrderHuLabelPalletHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
                txtPallet_ITEM_NM.EditValue = ((WorOrderHuLabelPalletHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_NM;
                spePallet_WOR_QTY.EditValue = ((WorOrderHuLabelPalletHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).WOR_QTY;
                spePallet_PRINTED_QTY.EditValue = ((WorOrderHuLabelPalletHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PRINTED_QTY;
                var avaQty = ((WorOrderHuLabelPalletHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).WOR_QTY - ((WorOrderHuLabelPalletHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PRINTED_QTY;
                if (avaQty < 0) avaQty = 0;
                spePallet_AVA_QTY.EditValue = avaQty;
                spePallet_HU_SIZE.EditValue = ((WorOrderHuLabelPalletHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).HU_SIZE;

                CalcPrintQtyPallet();
                PrintValidatingCheckPallet();

                _worOrderHuLabelPalletDetailList.DataRefresh(_worOrderHuLabelArgs);
            };


            _worOrderHuLabelPalletDetailList.ModelDeletedEvent += (object sender, ArgsBase e) =>
            {
                _worOrderHuLabelPalletHeaderList.DataRefresh(_worOrderHuLabelArgs);
            };

            spePallet_HU_SIZE.EditValueChanged += (object sender, EventArgs e) =>
            {
                CalcPrintQtyPallet();
            };

            spePallet_PRINT_QTY.EditValueChanged += (object sender, EventArgs e) =>
            {
                PrintValidatingCheckPallet();
            };

            #endregion ~부품 식별표

            #region 개별 식별표

            _worOrderHuLabelSerialHeaderList.ModelSelectedEvent += (object sender, ArgsBase e) =>
            {
                _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Serial_Wo_No = ((WorOrderHuLabelSerialHeaderModel)e.SelectedModelArgsBase.SelectedModelBase)?.WO_NO;

                txtSerial_WO_NO.EditValue = ((WorOrderHuLabelSerialHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).WO_NO;
                txtSerial_ITEM_CD.EditValue = ((WorOrderHuLabelSerialHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_CD;
                txtSerial_ITEM_NM.EditValue = ((WorOrderHuLabelSerialHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).ITEM_NM;
                speSerial_WOR_QTY.EditValue = ((WorOrderHuLabelSerialHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).WOR_QTY;
                speSerial_PRINTED_QTY.EditValue = ((WorOrderHuLabelSerialHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PRINTED_QTY;
                var avaQty = ((WorOrderHuLabelSerialHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).WOR_QTY - ((WorOrderHuLabelSerialHeaderModel)e.SelectedModelArgsBase.SelectedModelBase).PRINTED_QTY;
                if (avaQty < 1)
                {
                    avaQty = 0;
                    speSerial_PRINT_QTY.EditValue = avaQty;
                }
                else
                {
                    speSerial_PRINT_QTY.EditValue = 1;
                }
                speSerial_AVA_QTY.EditValue = avaQty;

                PrintValidatingCheckSerial();

                _worOrderHuLabelSerialDetailList.DataRefresh(_worOrderHuLabelArgs);
            };


            _worOrderHuLabelSerialDetailList.ModelDeletedEvent += (object sender, ArgsBase e) =>
            {
                _worOrderHuLabelSerialHeaderList.DataRefresh(_worOrderHuLabelArgs);
            };
            
            speSerial_PRINT_QTY.EditValueChanged += (object sender, EventArgs e) =>
            {
                PrintValidatingCheckSerial();
            };

            #endregion ~ 개별 식별표
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            SetWorkCenter();
        }

        private void SetWorkCenter()
        {
            var targetWcType = "";
            if (xtraTabControl1.SelectedTabPageIndex == 0)
                targetWcType = "COVER";
            else if (xtraTabControl1.SelectedTabPageIndex == 1)
                targetWcType = "CKDAS";

            LookUpEditHelper.SetWorkCenter(strapLookUpEdit3, strapLookUpEdit1.EditValue?.ToString(), strapLookUpEdit2.EditValue?.ToString(), workCenterType: targetWcType, isFirstSelect: true);
        }

        protected override void Refresh_From_ExecuteByRibbonButton()
        {
            _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Main_Wo_Dt = strapDateEdit1.DateTime;// (DateTime)strapDateEdit1.EditValue;
            _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Main_Comp_Cd = strapLookUpEdit1.EditValue?.ToString();
            _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Main_Plant_Cd = strapLookUpEdit2.EditValue?.ToString();
            _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Main_WorkCenter_Cd = strapLookUpEdit3.EditValue?.ToString();
            _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Main_Shift_Cd = strapLookUpEdit4.EditValue?.ToString();
            _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Main_Item_Cd = strapButtonEdit_ItemMaster1.EditValue?.ToString();
            _worOrderHuLabelArgs.WorOrderHuLabelModelArgs.Select_Main_Wo_No = strapTextEdit1.EditValue?.ToString();


            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {
                _worOrderHuLabelPalletDetailList.DataClear(_worOrderHuLabelArgs);

                base.Refresh_From_ExecuteByRibbonButton();
            }
            else if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                _worOrderHuLabelSerialDetailList.DataClear(_worOrderHuLabelArgs);

                _worOrderHuLabelSerialHeaderList.DataRefresh(_worOrderHuLabelArgs);
            }
        }

        private void btnPallet_Print_Click(object sender, EventArgs e)
        {
            var printQty = Convert.ToDecimal(spePallet_PRINT_QTY.EditValue);

            if (printQty < 1)
            {
                StrapMessageBox.Show("A001", 68); // 발행수량을 확인해주세요.
                return;
            }
            else if (printQty > 50)
            {
                StrapMessageBox.Show("A001", 67); // 한번에 50개 이상 발행할 수 없습니다.
                return;
            }
            else if (String.IsNullOrEmpty(txtPallet_WO_NO.EditValue?.ToString()))
            {
                StrapMessageBox.Show("A001", 70); // 작업지시 정보가 없습니다. 작업지시를 선택해주세요.
                return;
            }

                //var avaQty = Convert.ToDecimal(spePallet_AVA_QTY.EditValue);
                //if (avaQty == 0)
                //{
                //    StrapMessageBox.Show("A001", 44); // 발행 가능 수량을 초과했습니다.
                //    return;
                //}


                WorOrderHuLabelCreatingBarcodeModel model = new WorOrderHuLabelCreatingBarcodeModel();
            var selModel = _worOrderHuLabelPalletHeaderList.GetSelectedModel();

            model.RowState = Common.Model.RowState.Added;
            model.BARCODE_KIND = "PALLET_PROD";
            model.DEVICE_ID = UserInfo.UserID;
            model.CREATING_QTY = Convert.ToInt32(printQty);
            model.COMP_CD = selModel.COMP_CD;
            model.PLANT_CD = selModel.PLANT_CD;
            model.ITEM_CD = selModel.ITEM_CD;
            model.HU_QTY = Convert.ToDecimal(spePallet_HU_SIZE.EditValue);
            model.WORK_DT = selModel.WO_DT;
            model.LOT_NO = selModel.WO_DT.ToString("yyyyMMdd") + selModel.SHIFT_CD;
            model.WO_NO = selModel.WO_NO;
            model.REMAINDER_QTY = Convert.ToDecimal(spePallet_REMAINDER_QTY.EditValue);
            model.IS_INSERTED_RETURN = "Y";

            Common.Config.SystemConfig.RefreshServerDateTime();
            model.CREATE_DTTM = Common.Config.SystemConfig.ServerDateTime;
            model.MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime;
            model.CREATE_USER_ID = UserInfo.UserID;
            model.MODIFY_USER_ID = UserInfo.UserID;

            //var models = _worOrderHuLabelPalletDetailList.GetSelectedModels();

            var createdModel = _worOrderHuLabelPocket.SelectWorOrderHuLabelCreatedBarcodeModels(model); // 식별표 생성 + 저장 + 조회

            var huNoList = createdModel.Select(r => r.HU_NO).ToList<string>();
            HandlingUnitReportFactory reportFactory = HandlingUnitReportFactory.GetInstance();
            reportFactory.HandlingUnit_PalletProd(huNoList).ShowPreviewDialog();

            _worOrderHuLabelPalletHeaderList.DataRefresh(_worOrderHuLabelArgs);
            _worOrderHuLabelPalletDetailList.DataRefresh(_worOrderHuLabelArgs);

            PrintInfoClearPallet();
        }

        private void btnSerial_Print_Click(object sender, EventArgs e)
        {
            var printQty = Convert.ToDecimal(speSerial_PRINT_QTY.EditValue);
            if (printQty < 1)
            {
                StrapMessageBox.Show("A001", 68); // 발행수량을 확인해주세요.
                return;
            }
            else if (printQty > 50)
            {
                StrapMessageBox.Show("A001", 67); // 한번에 50개 이상 발행할 수 없습니다.
                return;
            }
            else if (String.IsNullOrEmpty(txtSerial_WO_NO.EditValue?.ToString()))
            {
                StrapMessageBox.Show("A001", 70); // 작업지시 정보가 없습니다. 작업지시를 선택해주세요.
                return;
            }

            Common.Config.SystemConfig.RefreshServerDateTime();

            WorOrderHuLabelCreatingBarcodeModel model = new WorOrderHuLabelCreatingBarcodeModel();
            var selModel = _worOrderHuLabelSerialHeaderList.GetSelectedModel();
            model.BARCODE_KIND = "SERIAL_GOODS";
            model.COMP_CD = selModel.COMP_CD;
            model.PLANT_CD = selModel.PLANT_CD;
            model.ITEM_CD = selModel.ITEM_CD;
            model.HU_QTY = Convert.ToDecimal(1);
            model.CREATING_QTY = Convert.ToInt32(printQty);
            model.REMAINDER_QTY = 0;
            model.WORK_DT = selModel.WO_DT;
            model.LOT_NO = selModel.WO_DT.ToString("yyyyMMdd") + selModel.SHIFT_CD;
            model.CREATE_DTTM = Common.Config.SystemConfig.ServerDateTime;
            model.MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime;
            model.CREATE_USER_ID = UserInfo.UserID;
            model.MODIFY_USER_ID = UserInfo.UserID;

            model.LANG_CODE = UserInfo.Sys_Language;
            model.DEVICE_ID = UserInfo.UserID;
            model.WO_NO = selModel.WO_NO;
            model.IS_INSERTED_RETURN = "Y";
            model.RowState = Common.Model.RowState.Added;
            model.DEVICE_ID = "92CA1-01"; // CKD 임시 적용

            var createdModel = _worOrderHuLabelPocket.SelectWorOrderHuLabelCreatedBarcodeModels(model); // 식별표 생성 + 저장 + 조회

            var huNoList = createdModel.Select(r => r.HU_NO).ToList<string>();
            if (huNoList != null && huNoList.Count > 0)
            {
                PrintSerialGoodsBarcode(huNoList);

                _worOrderHuLabelSerialHeaderList.DataRefresh(_worOrderHuLabelArgs);
                _worOrderHuLabelSerialDetailList.DataRefresh(_worOrderHuLabelArgs);

                PrintInfoClearSerial();
            }
        }

        private bool PrintSerialGoodsBarcode(List<string> huNoList)
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
            serialPortSeletor.SelectedComplate += (object objSender, SerialPortSelectedEventArgs selectedEventArgs) =>
                {
                    this.serialPortSelctorModel = selectedEventArgs.serialPortSelctorModel;
                };
            serialPortSeletor.ShowDialog();


            if (serialComm == null)
            {
                serialComm = new SerialComm("BarcodePrinter1");
            }

            if (serialPortSelctorModel == null)
            {
                return false;
            }
            else
            {
                if (serialComm.serialPort == null || serialComm.IsOpen == false || serialPortSelctorModel.ComPort != serialComm.serialPort.PortName)
                {
                    // 시리얼 -> 프린터 드라이브로 잡히면 COM Port 오픈이 안됨. 프린터목록에서 제거 후 사용가능함
                  var msg = serialComm.OpenComm(serialPortSelctorModel.ComPort, serialPortSelctorModel.BaudRate, serialPortSelctorModel.DataBits, serialPortSelctorModel.StopBits, serialPortSelctorModel.Parity);
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
                    StrapMessageBox.Show("A001", 69); // Com Port Open Failed

                    return false;
                }

                return true;
            }

            #endregion ~시리얼 통신
        }

        private void btnPallet_RePrint_Click(object sender, EventArgs e)
        {
            var models = _worOrderHuLabelPalletDetailList.GetSelectedModels();
            var checkedModels = models.Where(r => r.IsCheck).Select(s => s.HU_NO).ToList<string>();
            if (checkedModels.Count() == 0)
            {
                StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                return;
            }

            HandlingUnitReportFactory reportFactory = HandlingUnitReportFactory.GetInstance();
            reportFactory.HandlingUnit_PalletProd(checkedModels).ShowPreviewDialog();

            
        }
        private void btnSerial_RePrint_Click(object sender, EventArgs e)
        {
            var models = _worOrderHuLabelSerialDetailList.GetSelectedModels();
            var checkedhuNoList = models.Where(r => r.IsCheck).Select(s => s.HU_NO).ToList<string>();
            if (checkedhuNoList.Count() == 0)
            {
                StrapMessageBox.Show("A001", 9); // 선택된 행이 없습니다. 더블클릭 혹은 엔터로 선택하십시오
                return;
            }

            PrintSerialGoodsBarcode(checkedhuNoList);
        }

        private void CalcPrintQtyPallet()
        {
            var worQty = Convert.ToDecimal(spePallet_WOR_QTY.EditValue);
            var printedQty = Convert.ToDecimal(spePallet_PRINTED_QTY.EditValue);
            var avaQty = worQty - printedQty;

            var huSize = Convert.ToDecimal(spePallet_HU_SIZE.EditValue);
            if (huSize > 0)
            {
                var quotient = Math.Truncate(avaQty / huSize);
                var remainder = avaQty % huSize;

                if (remainder > 0)
                {
                    quotient = quotient + 1;
                }
                if (quotient < 0)
                    quotient = 0;

                spePallet_PRINT_QTY.EditValue = quotient;
                spePallet_REMAINDER_QTY.EditValue = remainder;
            }
        }

        private void PrintValidatingCheckPallet()
        {
            if (Convert.ToDecimal(spePallet_PRINT_QTY.EditValue) < 1 || Convert.ToDecimal(spePallet_AVA_QTY.EditValue) < 1)
                btnPallet_Print.Enabled = true; //광주공장 요청에 의해 추가 발행되도록 수정 - 곽동혁 20201228 
            else
                btnPallet_Print.Enabled = true;
        }

        private void PrintValidatingCheckSerial()
        {
            if (Convert.ToDecimal(speSerial_PRINT_QTY.EditValue) < 1 || Convert.ToDecimal(speSerial_AVA_QTY.EditValue) < 1)
                btnSerial_Print.Enabled = true;
            else
                btnSerial_Print.Enabled = true;
        }

        private void PrintInfoClearPallet()
        {
            txtPallet_WO_NO.EditValue = "";
            txtPallet_ITEM_CD.EditValue = "";
            txtPallet_ITEM_NM.EditValue = "";
            spePallet_WOR_QTY.EditValue = 0;
            spePallet_PRINTED_QTY.EditValue = 0;
            spePallet_AVA_QTY.EditValue = 0;
            spePallet_HU_SIZE.EditValue = 0;
            spePallet_REMAINDER_QTY.EditValue = 0;
            spePallet_PRINT_QTY.EditValue = 0;
        }

        private void PrintInfoClearSerial()
        {
            txtSerial_WO_NO.EditValue = "";
            txtSerial_ITEM_CD.EditValue = "";
            txtSerial_ITEM_NM.EditValue = "";
            speSerial_WOR_QTY.EditValue = 0;
            speSerial_PRINTED_QTY.EditValue = 0;
            speSerial_AVA_QTY.EditValue = 0;
        }

        private void WorOrderHuLabelMain_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (serialComm != null && serialComm.IsOpen) serialComm.CloseComm();
        }
    }
}

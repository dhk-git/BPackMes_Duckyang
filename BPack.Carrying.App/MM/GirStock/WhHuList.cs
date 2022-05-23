using BPack.Model.App.MM.GirStock;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MM.GirStock;
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
using BPack.CommonMes.Helpers;
using BPack.Report.App.HandlingUnit.Commands;
using System.Threading;
using BPack.CommonMes.Controls.SerialPortSelect;
using BPack.CommonMes.IO.SerialComm;

namespace BPack.Carrying.App.MM.GirStock
{
    public partial class WhHuList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirStockArgs _girStockArgs;
        private GirStockPocket _girStockPocket;

        SerialPortSeletor serialPortSeletor;
        SerialPortSelctorModel serialPortSelctorModel;
        SerialComm serialComm;

        public WhHuList()
        {
            InitializeComponent();
        }

        public WhHuList(GirStockArgs girStockArgs, GirStockPocket girStockPocket) : this()
        {
            _girStockArgs = girStockArgs;
            _girStockPocket = girStockPocket;
        }
        public override void InitStrap()
        {
            base.InitStrap();
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid() {
                BindingSource = whHuModelBindingSource,
                ExcelUploadModelType = null,
                FormArgs = _girStockArgs,
                GridView = gridView1,
                InitModelType = typeof(WhHuModel),
                ModelArgs = _girStockArgs.GirStockModelArgs,
                StrapEditMode = StrapEditMode.Default
            });
            InitPocketDelegate<GirStockModelArgs, WhHuModel>(_girStockPocket.SelectWhHuModels, null);
            colIsCheck.Visible = false;
            LookUpEditHelper.SetGridColumnSysCode(colHU_TYPE, "HU_TYPE");
        }

        public void PrintHu()
        {
            if (whHuModelBindingSource.Current == null || whHuModelBindingSource?.Count == 0)
            {
                MessageBox.Show("선택된 식별표가 없습니다.");
                return;
            }
            WhHuModel selectedModel = (WhHuModel)whHuModelBindingSource.Current;
            string barcodeType = selectedModel.BARCODE_TYPE;
            List<string> huNoList = new List<string>();
            huNoList.Add(selectedModel.HU_NO);

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
                rf.HandlingUnit_SerialSemi(huNoList).ShowPreviewDialog();
            }
            if (barcodeType == "SERIAL_GOODS")
            {
                if (_girStockArgs.GirStockModelArgs.TestPrint) // 테스트용 일반프린터 출력
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
                    //var print = NetworkHelper.getNetworkPrinter(printerName);

                    //var portName = print.Properties["Name"].Value.ToString();
                    //var hostAddress = print.Properties["HostAddress"].Value;
                    //var portNumber = print.Properties["PortNumber"].Value;
                    //var endpoint = NetworkHelper.CreateIPEndPoint(hostAddress + ":" + portNumber);

                    //var sendList = HandlingUnitBarcodeCommands.CreateSerialGoodsBarcodes(huNoList);
                    //var sendData = String.Join("", sendList);

                    //AsyncSocket socketObject = new AsyncSocket(endpoint);
                    //Thread thread = new Thread(new ParameterizedThreadStart(socketObject.SendData));
                    //thread.Start(sendData);

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

        private void WhHuList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialComm != null && serialComm.IsOpen) serialComm.CloseComm();
        }
    }
}

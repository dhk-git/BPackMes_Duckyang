using BPack.Common.Model;
using BPack.Model.App.MM.HumLocInfo;
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

namespace BPack.Carrying.App.MM.HumLocInfo
{
    public partial class HumLocInfoList : StrapSubForm_OnlyOneGrid_V2
    {
        HumLocInfoArgs _humLocInfoArgs;
        HumLocInfoPocket _humLocInfoPocket;

        public HumLocInfoList(HumLocInfoArgs humLocInfoArgs, HumLocInfoPocket humLocInfoPocket)
        {
            InitializeComponent();

            _humLocInfoArgs = humLocInfoArgs;
            _humLocInfoPocket = humLocInfoPocket;

        }

        public override void InitStrap()
        {
            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = humLocInfoModelBindingSource,
                FormArgs = _humLocInfoArgs,
                ModelArgs = _humLocInfoArgs.HumLocInfoModelArgs,
                InitModelType = typeof(HumLocInfoModel),
                GridView = gridView1,
                StrapEditMode = StrapEditMode.Default
            });
            
            InitPocketDelegate<HumLocInfoModelArgs, HumLocInfoModel>(_humLocInfoPocket.SelectHumLocInfoModels, null);
            //LookUpEditHelper.SetGridColumnSysCode(colINHU_IN_STATUS, "INHU_IN_STATUS");
            //LookUpEditHelper.SetGridColumnSysCode(colINHU_INSP_STATUS, "INHU_INSP_STATUS");
            //LookUpEditHelper.SetGridColumnSysCode(colITEM_TYPE_CLS, "ITEM_TYPE_CLS");
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridView1.OptionsSelection.MultiSelect = true;
        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            //((PurInboundHistModel)model).COMP_CD = _purInboundHistArgs.PurInboundHistModelArgs.Select_Main_Comp_Code;
        }

        public List<HumLocInfoModel> GetCheckedModels()
        {
            var checkedRows = gridView1.GetSelectedRows();
            List<HumLocInfoModel> humLocInfoModels = new List<HumLocInfoModel>();
            foreach (var rowHandle in checkedRows)
            {
                humLocInfoModels.Add(gridView1.GetRow(rowHandle) as HumLocInfoModel);
            }
            return humLocInfoModels;
        }

        public override void Delete(ArgsBase args)
        {
            //base.Delete(args);
            var checkedRows = GetCheckedModels();
            if (!checkedRows.Any())
            {
                StrapMessageBox.Show("A001", 61); //선택된 행이 없습니다.
                return;
            }

            if (StrapMessageBox.Show("A001", 10, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택한 행을 삭제하시겠습니까?
            {
                try
                {
                    Common.Config.SystemConfig.RefreshServerDateTime();
                    foreach (var model in checkedRows)
                    {
                        model.RowState = RowState.Deleted;
                        model.CREATE_DTTM = Common.Config.SystemConfig.ServerDateTime;
                        model.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                        model.MODIFY_DTTM = Common.Config.SystemConfig.ServerDateTime;
                        model.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
                    }
                    _humLocInfoPocket.DeleteHumLocInfoModels(checkedRows);
                    DataRefresh(_humLocInfoArgs);
                }
                catch (Exception ex)
                {
                    StrapMessageBox.Show(Common.Command.ExceptionProcess.AlertMessage(ex));
                }
            }

        }

        //internal void PrintHu()
        //{
        //    if (humLocInfoModelBindingSource.Current == null || humLocInfoModelBindingSource?.Count == 0)
        //    {
        //        MessageBox.Show("선택된 식별표가 없습니다.");
        //        return;
        //    }
        //    HumLocInfoModel selectedModel = (HumLocInfoModel)humLocInfoModelBindingSource.Current;
        //    string barcodeType = selectedModel.BARCODE_TEXT;
        //    List<string> huNoList = new List<string>();
        //    huNoList.Add(selectedModel.HU_NO);

        //    HandlingUnitReportFactory rf = HandlingUnitReportFactory.GetInstance();

        //    if (barcodeType == "PALLET_MAT")
        //    {
        //        rf.HandlingUnit_Mat(huNoList).ShowPreviewDialog();
        //    }
        //    if (barcodeType == "PALLET_PROD")
        //    {
        //        rf.HandlingUnit_PalletProd(huNoList).ShowPreviewDialog();
        //    }
        //    if (barcodeType == "SERIAL_SEMI")
        //    {
        //        rf.HandlingUnit_SerialSemi(huNoList).ShowPreviewDialog();
        //    }
        //    if (barcodeType == "SERIAL_GOODS")
        //    {
        //        MessageBox.Show("준비중");
        //        //    PrintDialog PrintDialog1 = new PrintDialog();
        //        //    PrintDialog1.ShowDialog();

        //        //    var printerName = PrintDialog1.PrinterSettings.PrinterName;
        //        //    var print = NetworkHelper.getNetworkPrinter(printerName);

        //        //    var portName = print.Properties["Name"].Value.ToString();
        //        //    var hostAddress = print.Properties["HostAddress"].Value;
        //        //    var portNumber = print.Properties["PortNumber"].Value;
        //        //    var endpoint = NetworkHelper.CreateIPEndPoint(hostAddress + ":" + portNumber);

        //        //    var sendList = HandlingUnitBarcodeCommands.CreateSerialGoodsBarcodes(huNoList);
        //        //    var sendData = String.Join("", sendList);

        //        //    AsyncSocket socketObject = new AsyncSocket(endpoint);
        //        //    Thread thread = new Thread(new ParameterizedThreadStart(socketObject.SendData));
        //        //    thread.Start(sendData);
        //    }
        //    if (barcodeType == "MAPPING")
        //    {
        //        rf.HandlingUnit_Mapping(huNoList).ShowPreviewDialog();
        //    }
        //}
    }
}

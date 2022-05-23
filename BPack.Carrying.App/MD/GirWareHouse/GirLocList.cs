using BPack.Common.Model;
using BPack.Model.App.MD.GirWareHouse;
using BPack.Strap.EditControls;
using BPack.Strap.FormControls;
using BPack.Pocket.App.MD.GirWareHouse;
using DevExpress.CodeParser;
using DevExpress.XtraPrinting.BarCode;
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
using DevExpress.XtraPrinting;
using BPack.CommonMes.Helpers;

namespace BPack.Carrying.App.MD.GirWareHouse
{
    public partial class GirLocList : StrapSubForm_OnlyOneGrid_V2
    {
        private GirWareHouseArgs _girWareHouseArgs;
        private GirWareHousePocket _girWareHousePocket;

        private DataGridView dataGridView1 = new DataGridView();

        public GirLocList(GirWareHouseArgs girWareHouseArgs, GirWareHousePocket girWareHousePocket)
        {
            InitializeComponent();

            _girWareHouseArgs = girWareHouseArgs;
            _girWareHousePocket = girWareHousePocket;

        }

        public override void InitStrap()
        {
            base.InitStrap();

            InitFields(new FieldArgs_StrapSubForm_OnlyOneGrid
            {
                BindingSource = locationModelBindingSource,
                FormArgs = _girWareHouseArgs,
                ModelArgs = _girWareHouseArgs.girWareHouseModelArgs,
                InitModelType = typeof(LocationModel),
                GridView = gridView1,
                StrapEditMode = StrapEditMode.Batch
            });
            InitPocketDelegate<GirWareHouseModelArgs, LocationModel>(_girWareHousePocket.SelectLocationModels, _girWareHousePocket.SaveLocationModel, _girWareHousePocket.SaveLocationModels);

            LookUpEditHelper.SetGridColumnSysCode(colLOC_STOCK_TYPE, "LOC_STOCK_TYPE");

        }

        protected override void SetInsertDefaultValue(ModelBase model)
        {
            base.SetInsertDefaultValue(model);

            ((LocationModel)model).COMP_CD = _girWareHouseArgs.girWareHouseModelArgs.Select_Comp_Code;
            ((LocationModel)model).PLANT_CD = _girWareHouseArgs.girWareHouseModelArgs.Select_Plant_Code;
            ((LocationModel)model).WH_CD = _girWareHouseArgs.girWareHouseModelArgs.Select_WareHouse_Code;
            //2021.12.20 최초수량 1 설정
            ((LocationModel)model).LOC_CNT = 1;
            //2021.12.21
            ((LocationModel)model).LOC_STOCK_TYPE = "A001";

            //2021.12.23 공통위치 여부
            ((LocationModel)model).COMMON_YN = false;


        }

        public override void DataRefresh(ArgsBase args)
        {
            
            base.DataRefresh(args);
        }
        

        public void ShowLocBarcodeReport(LocBacodeType locBacodeType)
        {
            var checkedModels = ((List<LocationModel>)SelectedModels).Where(a => a.IsCheck == true).ToList();
            
            if (checkedModels.Count == 0)
            {
                StrapMessageBox.Show("A001", 61); //선택행이 없습니다.
                return;
            }
            if (StrapMessageBox.Show("A001", 107, MessageBoxButtons.YesNo) == DialogResult.Yes) //선택된 위치바코드를 출력합니다.
            {
                List<LocBarcodeModel> locBarcodeModels = new List<LocBarcodeModel>();
                foreach (var item in checkedModels)
                {
                    locBarcodeModels.Add(new LocBarcodeModel {
                        COMP_CD = item.COMP_CD,
                        PLANT_CD = item.PLANT_CD,
                        WH_CD = item.WH_CD,
                        LOC_CD = item.LOC_CD,
                        WH_NM = item.WH_NM,
                        LOC_NM = item.LOC_NM,
                        //LocBarcode = "L$" + item.COMP_CD + "$" + item.PLANT_CD + "$" + item.WH_CD + "$" + item.LOC_CD
                        LocBarcode = item.LOC_BARCODE
                    });
                }
                if (locBacodeType == LocBacodeType.A4 )
                {
                    LocBarcodeReport locBarcodeReport = new LocBarcodeReport();
                    locBarcodeReport.DataRefresh(locBarcodeModels);
                    locBarcodeReport.CreateDocument();
                    PrintTool pt1 = new PrintTool(locBarcodeReport.PrintingSystem);
                    pt1.ShowPreviewDialog();

                }
                else if (locBacodeType == LocBacodeType.Label)
                {
                    LocBarcodeLabelReport locBarcodeLabelReport = new LocBarcodeLabelReport();
                    locBarcodeLabelReport.DataRefresh(locBarcodeModels);
                    locBarcodeLabelReport.CreateDocument();
                    PrintTool pt2 = new PrintTool(locBarcodeLabelReport.PrintingSystem);
                    pt2.ShowPreviewDialog();
                }

            };
        }
    }
    public enum LocBacodeType
    {
        Label,
        A4

    }
}

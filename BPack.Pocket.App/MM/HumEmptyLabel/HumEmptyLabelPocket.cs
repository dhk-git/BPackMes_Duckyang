using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.HumEmptyLabel;

namespace BPack.Pocket.App.MM.HumEmptyLabel
{
    public class HumEmptyLabelPocket : PocketBase
    {
        public HumEmptyLabelPocket()
        {
            InitPocket("HumEmptyLabel");
        }

        public List<BarcodeModel> SelectBarcodeModels(HumEmptyLabelModelArgs args)
        {
            return PocketQuery<BarcodeModel>("MM.HumEmptyLabel.PrintedBarcodeList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Main_Plant_CD,
                BARCODE_KIND = args.Select_Main_Barcode_Kind,
                BARCODE_FULL_NO = args.Select_Main_Barcode_Full_No,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt
            });
        }

        public void SaveBarcodeModel(BarcodeModel barcodeModel)
        {
            PocketExecute("MM.HumEmptyLabel.PrintedBarcodeList.Save", GetParameters_StrapDisableParam(barcodeModel));
        }
        public List<CreatedBarcodeModel> CreateMultiBarcodeLabel(CreateMultiBarcodeModel createMultiBarcodeModel)
        {
            return PocketQuery<CreatedBarcodeModel>("MM.HumEmptyLabel.CreateMultiBarcode.BP", createMultiBarcodeModel);
        }

        public List<CreatedBarcodeModel> CreateBarcodeLabel(CreatingBarcodeModel creatingBarcodeModel)
        {
            return PocketQuery<CreatedBarcodeModel>("MM.HumEmptyLabel.CreateBarcode.BP", creatingBarcodeModel);
        }

        public List<CreatedBarcodeModel> SelectRePrintingModels(string rePrintingBarcode)
        {
            return PocketQuery<CreatedBarcodeModel>("MM.HumEmptyLabel.BarcodeReprint.BP", new 
            { 
                REPRINTING_BARCODE = rePrintingBarcode
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WorOrderHuLabel;

namespace BPack.Pocket.App.PC.WorOrderHuLabel
{
    public class WorOrderHuLabelPocket : PocketBase
    {
        public WorOrderHuLabelPocket()
        {
            InitPocket("WorOrderHuLabel");
        }

        public List<WorOrderHuLabelPalletHeaderModel> SelectWorOrderHuLabelPalletHeaderModels(WorOrderHuLabelModelArgs args)
        {
            return PocketQuery<WorOrderHuLabelPalletHeaderModel>("PC.WorOrderHuLabel.PalletHeader.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WO_DT = args.Select_Main_Wo_Dt,
                SHIFT_CD = args.Select_Main_Shift_Cd,
                WC_CD = args.Select_Main_WorkCenter_Cd,
                ITEM_CD = args.Select_Main_Item_Cd,
                WO_NO = args.Select_Main_Wo_No
            });
        }

        public List<WorOrderHuLabelPalletDetailModel> SelectWorOrderHuLabelPalletDetailModels(WorOrderHuLabelModelArgs args)
        {
            return PocketQuery<WorOrderHuLabelPalletDetailModel>("PC.WorOrderHuLabel.PalletDetail.Select", new
            {
                WO_NO = args.Select_Pallet_Wo_No,
            });
        }

        public List<WorOrderHuLabelSerialHeaderModel> SelectWorOrderHuLabelSerialHeaderModels(WorOrderHuLabelModelArgs args)
        {
            return PocketQuery<WorOrderHuLabelSerialHeaderModel>("PC.WorOrderHuLabel.SerialHeader.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                WO_DT = args.Select_Main_Wo_Dt,
                SHIFT_CD = args.Select_Main_Shift_Cd,
                WC_CD = args.Select_Main_WorkCenter_Cd,
                ITEM_CD = args.Select_Main_Item_Cd,
                WO_NO = args.Select_Main_Wo_No
            });
        }

        public List<WorOrderHuLabelSerialDetailModel> SelectWorOrderHuLabelSerialDetailModels(WorOrderHuLabelModelArgs args)
        {
            return PocketQuery<WorOrderHuLabelSerialDetailModel>("PC.WorOrderHuLabel.SerialDetail.Select", new
            {
                WO_NO = args.Select_Serial_Wo_No,
            });
        }

        public List<WorOrderHuLabelCreatedBarcodeModel> SelectWorOrderHuLabelCreatedBarcodeModels(WorOrderHuLabelCreatingBarcodeModel model)
        {
            return PocketQuery<WorOrderHuLabelCreatedBarcodeModel>("PC.WorOrderHuLabel.CreatedBarcode.BP", GetParameters_StrapDisableParam(model));
        }

        public void SaveWorOrderHuLabelPalletDetailModels(List<WorOrderHuLabelPalletDetailModel> models)
        {
            PocketExecute("PC.WorOrderHuLabel.PalletDetail.Save", GetParameters_StrapDisableParam(models));
        }

        public void SaveWorOrderHuLabelSerialDetailModels(List<WorOrderHuLabelSerialDetailModel> models)
        {
            PocketExecute("PC.WorOrderHuLabel.SerialDetail.Save", GetParameters_StrapDisableParam(models));
        }
    }
}

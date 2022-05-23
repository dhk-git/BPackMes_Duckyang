using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.HumMebBarcode;

namespace BPack.Pocket.App.MM.HumMebBarcode
{
    public class HumMebBarcodePocket : PocketBase
    {
        public HumMebBarcodePocket()
        {
            InitPocket("HumMebBarcode");
        }
        public List<HumMebBarcodeModel> SelectHumMebBarcodeModels(HumMebBarcodeModelArgs args)
        {
            return PocketQuery<HumMebBarcodeModel>("MM.HumMebBarcode.MebList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                ITEM_CD=args.Select_Main_Item_Cd,
                HU_MEB_TYPE = args.Select_Main_Barcode_Type,
            });
        }
        public List<string>  SaveHumMebBarcodeModel(NewHumMebBarcodeArgs args)
        {
            return PocketQuery<string>("MM.HumMebBarcode.MebList.CUD", new
            {
                CrudCls=args.CrudCls,
                REMARK=args.REMARK,
                CREATE_USER_ID=args.CREATE_USER_ID,
                MODIFY_USER_ID=args.MODIFY_USER_ID,
                LANG_CODE=args.LANG_CODE,
                COMP_CD = args.COMP_CD,
                PLANT_CD = args.PLANT_CD,
                WORK_DT = args.WORK_DT,
                ITEM_CD = args.ITEM_CD,
                HU_MEB_TYPE = args.HU_MEB_TYPE,
                INIT_QTY = args.INIT_QTY,
                ORDER_NO=args.ORDER_NO,
                PACK_DATE=args.PACK_DATE,
                SHIP_DATE=args.SHIP_DATE,
            });
        }

    }
}

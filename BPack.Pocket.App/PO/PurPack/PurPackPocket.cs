using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PO.PurPack;

namespace BPack.Pocket.App.PO.PurPack
{
    public class PurPackPocket : PocketBase
    {
        public PurPackPocket()
        {
            InitPocket("PurPack");
        }

        public List<PurPackModel> SelectPurPackModels(PurPackModelArgs args)
        {
            return PocketQuery<PurPackModel>("PO.PurPack.PackingList.Select", new
            {
                INVOICE_NO = args.Select_Invoice_No
            });
            //return PocketQuery<PurPackModel>("PO.PurPack.PackingList.Select", new {
            //    START_DT = args.Select_Main_Start_Dt,
            //    END_DT = args.Select_Main_End_Dt,
            //    COMP_CD = Common.LoginInfo.UserInfo.CompCode,
            //    PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
            //    ITEM_CD = args.Select_Main_Item_Cd,
            //    ITEM_NM = args.Select_Main_Item_Nm,
            //    ITEM_GR_1 = args.Select_Main_Item_Gr_1
            //});
        }

        public void SavePurPackModels(List<PurPackModel> purPackModels)
        {
            PocketExecute("PO.PurPack.PackingList.Save", GetParameters_StrapDisableParam(purPackModels));
        }

        public void ExcelUploadPurPackModels(List<PurPackModel> purPackModels)
        {
            PocketExecute("PO.PurPack.PackingList.ExcelUpload.BP", GetParameters_StrapDisableParam(purPackModels));
        }

        public List<InvoiceModel> SelectInvoiceModels(PurPackModelArgs args)
        {
            var data = PocketQuery<InvoiceModel>("PO.PurPack.InvoiceList.Select", new {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                BP_CD = args.Select_Main_Bp_Cd,
                INVOICE_STATUS = args.Select_Main_Invoice_Status,
                INVOICE_NO = args.Select_Main_Invoice_No
            });
            return data;
        }

        public void SaveInvoiceModel(InvoiceModel invoiceModel)
        {
            PocketExecute("PO.PurPack.InvoiceList.Save", GetParameters_StrapDisableParam(invoiceModel));
        }

    }
}

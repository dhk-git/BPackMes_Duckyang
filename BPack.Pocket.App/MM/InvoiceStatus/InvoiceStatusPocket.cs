using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.InvoiceStatus;

namespace BPack.Pocket.App.MM.InvoiceStatus
{
    public class InvoiceStatusPocket : PocketBase
    {
        public InvoiceStatusPocket()
        {
            InitPocket("InvoiceStatus");
        }
        public List<InvoiceStatusHeaderModel> SelectInvoiceStatusHeaderModels(InvoiceStatusModelArgs args)
        {
            return PocketQuery<InvoiceStatusHeaderModel>("MM.InvoiceStatus.InvoiceStatusHeader.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                INVOICE_NO = args.Select_Main_Invoice_No,
                START_DT=args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                BP_CD = args.Select_Main_Bp_Cd,
                BP_NM = args.Select_Main_Bp_Nm
            });
        }

    }
}

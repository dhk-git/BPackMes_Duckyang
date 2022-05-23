using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.InvAmount;

namespace BPack.Pocket.App.MM.InvAmount
{
    public class InvAmountPocket : PocketBase
    {
        public InvAmountPocket()
        {
            InitPocket("InvAmount");
        }

        public List<InvAmountModel> SelectInvAmountModels(InvAmountModelArgs args)
        {
            return PocketQuery<InvAmountModel>("MM.InvAmount.InvAmountList.Select", new { 
                ITEM_PRICE_TYPE = args.Select_Main_Item_Price_Type,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_TYPE_CD = args.Select_Main_Item_Type_Cd,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm
            });
        }
    }
}

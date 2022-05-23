using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.ItmPurchase;

namespace BPack.Pocket.App.MD.ItmPurchase
{
    public class ItmPurchasePocket : PocketBase
    {
        public ItmPurchasePocket()
        {
            InitPocket("ItmPurchase");
        }

        public void SaveItmListModels(List<ItmListModel> itmListModels)
        {
            PocketExecute("MD.BPA.ItmList.Save", GetParameters_StrapDisableParam(itmListModels));
        }

        public void SaveItmListModel(ItmListModel itmListModel)
        {
            PocketExecute("MD.BPA.ItmList.Save", GetParameters_StrapDisableParam(itmListModel));
        }

        public List<ItmPurchaseModel> SelectItmPurchaseModels(ItmPurchaseModelArgs args)
        {
            return PocketQuery<ItmPurchaseModel>("MD.BPA.Itmpurchase.Select", new
            {
                COMP_CD = args.Select_Main_Comp_CD,
                PLANT_CD = args.Select_Plant_CD
            });
        }

        public List<ItmListModel> SelectItmListModels(ItmPurchaseModelArgs args)
        {
            return PocketQuery<ItmListModel>("MD.BPA.ItmList.Select", new 
                { 
                    COMP_CD = args.Select_Main_Comp_CD ,
                    PLANT_CD = args.Select_Plant_CD ,
                    BP_CD = args.Select_Bp_CD

                });
        }

    }
}

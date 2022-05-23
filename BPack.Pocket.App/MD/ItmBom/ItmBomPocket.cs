using System;
using BPack.Common.Pocket;
using BPack.Model.App.MD.ItmBom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.ItmBom
{
    public class ItmBomPocket : PocketBase
    {
        public ItmBomPocket()
        {
            InitPocket("ItmBom");
        }

        public void SaveBomDetail(BomDetailModel bomDetailModel)
        {
            PocketExecute("MD.ItmBom.BomDetail.Save", GetParameters_StrapDisableParam(bomDetailModel));
        }
        public void SaveBomDetails(List<BomDetailModel> bomDetailModels)
        {
            PocketExecute("MD.ItmBom.BomDetail.Save", GetParameters_StrapDisableParam(bomDetailModels));
        }

        public void SaveBomHeader(BomHeaderModel bomHeaderModel)
        {
            PocketExecute("MD.ItmBom.BomHeader.Save", GetParameters_StrapDisableParam(bomHeaderModel));
           // var newData = PocketQuery<BomHeaderModel>("MD.ItmBom.BomHeader.Save", bomHeaderModel).SingleOrDefault();
            //bomHeaderModel.BOM_NO = newData?.BOM_NO;
        }
        public void SaveBomHeaders(List<BomHeaderModel> bomHeaderModels)
        {
            PocketExecute("MD.ItmBom.BomHeader.Save", GetParameters_StrapDisableParam(bomHeaderModels));
           // var newData = PocketQuery<List<BomHeaderModel>>("MD.ItmBom.BomHeader.Save", bomHeaderModel).SingleOrDefault();
    
        }
        public List<BomDetailModel> SelectBomDetailModels(ItmBomModelArgs args)
        {
            return PocketQuery<BomDetailModel>("MD.ItmBom.BomDetail.Select",
                new
                {
                    COMP_CD = args.Select_Comp_Code,
                    PLANT_CD = args.Select_Plant_Code,
                    BOM_NO = args.Select_Bom_No,
                }
            );
        }

        public List<BomHeaderModel> SelectBomHeaderModels(ItmBomModelArgs args)
        {
            return PocketQuery<BomHeaderModel>("MD.ItmBom.BomHeader.Select",
                new
                {
                    COMP_CD = args.Select_Comp_Code,
                    PLANT_CD = args.Select_Plant_Code,
                    ITEM_CD = args.Select_Item_Code,
                }
            );
        }
        public List<ItemInfoModel> SelectitemInfoModels(ItmBomModelArgs args)
        {
            return PocketQuery<ItemInfoModel>("MD.ItmBom.ItemList.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_Code,
                    PLANT_CD = args.Select_Main_Plant_Code,
                    ITEM_CD = args.Select_Main_Item_Code,
                    ITEM_NM = args.Select_Main_Item_Name,
                }
            );
        }

        public ItemInfoModel SelectitemInfoModel(ItmBomModelArgs args)
        {
            return PocketQuery<ItemInfoModel>("MD.ItmBom.Item.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_Code,
                    PLANT_CD = args.Select_Main_Plant_Code,
                    ITEM_CD = args.Select_EditForm_Item_Code,
                }
            ).SingleOrDefault<ItemInfoModel>();
        }

        public void CopyBom(BomCopyModel copyModel)
        {
            PocketExecute("MD.ItmBom.BomCopy.BP", GetParameters_StrapDisableParam(copyModel));
        }
    }
}

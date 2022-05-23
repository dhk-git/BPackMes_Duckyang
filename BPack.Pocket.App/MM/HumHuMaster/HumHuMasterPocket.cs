using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.HumHuMaster;

namespace BPack.Pocket.App.MM.HumHuMaster
{
    public class HumHuMasterPocket : PocketBase
    {
        public HumHuMasterPocket()
        {
            InitPocket("HumHuMaster");
        }

        public void SaveHuModel(HuModel huModel)
        {
            PocketExecute("MM.HumHuMaster.HuList.Save", huModel);
        }

        public void SaveHuModels(List<HuModel> huModels)
        {
            PocketExecute("MM.HumHuMaster.HuList.Save", huModels);
        }

        public List<HuModel> SelectChildHuModels(HumHuMasterModelArgs args)
        {
            return PocketQuery<HuModel>("MM.HumHuMaster.ChildHuList.Select", new { PARENT_HU_NO = args.Select_Hu_No });
        }

        public List<HuModel> SelectHuModels(HumHuMasterModelArgs args)
        {
            return PocketQuery<HuModel>("MM.HumHuMaster.HuList.Select", new {

                HU_NO = args.Select_Main_Hu_No,
                HU_TYPE = args.Select_Main_Hu_Type,
                PLANT_CD = args.Select_Main_Plant_Cd,
                ITEM_CD = args.Select_Main_Item_Cd,
                COMP_CD = args.Select_Comp_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                BARCODE_TEXT = args.Select_Main_Barcode_Text
            });
        }
    }
}

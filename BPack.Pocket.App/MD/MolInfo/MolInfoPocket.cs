using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.MolInfo;

namespace BPack.Pocket.App.MD.MolInfo
{
    public class MolInfoPocket : PocketBase
    {
        public MolInfoPocket()
        {
            InitPocket("MolInfo");
        }

        public void SaveMoldListModel(MoldListModel moldListModel)
        {
            PocketExecute("MD.MolInfo.MoldList.Save", moldListModel);
        }

        public List<MoldListModel> SelectMoldListModels(MolInfoModelArgs args)
        {
            return PocketQuery<MoldListModel>("MD.MolInfo.MoldList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                MOLD_CD = args.Select_Main_Mold_Code,
                MOLD_NM = args.Select_Main_Mold_Name
            });
        }
    }
}

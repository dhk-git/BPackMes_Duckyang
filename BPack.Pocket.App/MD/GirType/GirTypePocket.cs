using BPack.Common.Pocket;
using BPack.Model.App.MD.GirType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.GirType
{
    public class GirTypePocket : PocketBase
    {
        public GirTypePocket()
        {
            InitPocket("GirType");
        }

        public void SaveTypeModel(TypeModel typeModel)
        {
            PocketExecute("MD.GirType.TypeList.Save", typeModel);
        }

        public List<TypeModel> SelectTypeModels(GirTypeModelArgs args)
        {
            return PocketQuery<TypeModel>("MD.GirType.TypeList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code
            });
        }

    }
}

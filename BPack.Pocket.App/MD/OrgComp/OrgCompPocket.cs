using BPack.Common.Pocket;
using BPack.Model.App.MD.OrgComp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MD.OrgComp
{
    public class OrgCompPocket : PocketBase
    {
        public OrgCompPocket()
        {
            InitPocket("OrgComp");
        }

        public void SaveCompModel(CompModel compModel)
        {
            PocketExecute("MD.OrgComp.CompList.Save", GetParameters_StrapDisableParam(compModel));
        }

        public List<CompModel> SelectCompModels(OrgCompModelArgs args)
        {
            return PocketQuery<CompModel>("MD.OrgComp.CompList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                COMP_NM = args.Select_Main_Comp_Name
            });
        }
    }
}

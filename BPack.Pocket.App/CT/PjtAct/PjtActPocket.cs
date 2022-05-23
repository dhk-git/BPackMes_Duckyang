using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.CT.PjtAct;

namespace BPack.Pocket.App.CT.PjtAct
{
    public class PjtActPocket : PocketBase
    {
        public PjtActPocket()
        {
            InitPocket("PjtAct");
        }

        public List<PjtActModel> SelectPjtActModels(PjtActModelArgs args)
        {
            return PocketQuery<PjtActModel>("CT.PjtAct.PjtAct.Select", new {
                START_DT = args.Select_Start_Dt,
                END_DT = args.Select_End_Dt
            });
        }
    }
}

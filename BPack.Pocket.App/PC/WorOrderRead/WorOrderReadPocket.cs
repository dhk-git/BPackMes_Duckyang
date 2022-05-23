using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.WorOrderRead;

namespace BPack.Pocket.App.PC.WorOrderRead
{
    public class WorOrderReadPocket : PocketBase
    {
        public WorOrderReadPocket()
        {
            InitPocket("WorOrderRead");
        }

        public List<WorOrderReadHeaderModel> SelectWorkOrderHeaderModels(WorOrderReadModelArgs args)
        {
            return PocketQuery<WorOrderReadHeaderModel>("PC.WorOrderRead.WoHeader.R", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                PARENT_WC_CD = args.Select_Main_ParentWorkCenter_Cd,
                WC_CD = args.Select_Main_WorkCenter_Cd
            });
        }

    }
}

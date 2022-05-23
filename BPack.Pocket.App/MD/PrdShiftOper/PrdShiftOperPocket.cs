using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdShiftOper;

namespace BPack.Pocket.App.MD.PrdShiftOper
{
    public class PrdShiftOperPocket : PocketBase
    {
        public PrdShiftOperPocket()
        {
            InitPocket("PrdShiftOper");
        }

        public void SaveShiftOperModel(ShiftOperModel model)
        {
            PocketExecute("MD.PrdShiftOper.OperList.Save", model);
        }

        public void SaveShiftOperModels(List<ShiftOperModel> models)
        {
            PocketExecute("MD.PrdShiftOper.OperList.Save", models);
        }

        public List<ShiftModel> SelectShiftModels(PrdShiftOperModelArgs args)
        {
            return PocketQuery<ShiftModel>("MD.PrdShiftOper.ShiftList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
            });
        }

        public List<ShiftOperModel> SelectShiftOperModels(PrdShiftOperModelArgs args)
        {
            return PocketQuery<ShiftOperModel>("MD.PrdShiftOper.OperList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                SHIFT_CD = args.Select_Shift_Code
            });
        }
    }
}

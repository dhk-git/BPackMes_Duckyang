using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.DlvLineCarType;

namespace BPack.Pocket.App.MD.DlvLineCarType
{
    public class DlvLineCarTypePocket : PocketBase
    {
        public DlvLineCarTypePocket()
        {
            InitPocket("DlvLineCarType");
        }

        public void SaveCarTypeModel(DlvLineCarTypeModel model)
        {
            PocketExecute("MD.DlvLineCarType.CarType.Save", GetParameters_StrapDisableParam(model));
        }

        public List<DlvLineCarTypeGateModel> SelectCarTypeGateModels(DlvLineCarTypeModelArgs args)
        {
            return PocketQuery<DlvLineCarTypeGateModel>("MD.DlvLineCarType.Gate.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD
                });
        }

        public List<DlvLineCarTypeModel> SelectCarTypeModels(DlvLineCarTypeModelArgs args)
        {
            return PocketQuery<DlvLineCarTypeModel>("MD.DlvLineCarType.CarType.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    DLV_PLC_CD = args.Select_Gate_Dlv_Plc_CD
                });
        }
    }
}

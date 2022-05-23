using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.DlvJisInfo;

namespace BPack.Pocket.App.MD.DlvJisInfo
{
    public class DlvJisInfoPocket : PocketBase
    {
        public DlvJisInfoPocket()
        {
            InitPocket("DlvJisInfo");
        }

        public void SaveJISModel(DlvJisInfoJISModel model)
        {
            PocketExecute("MD.DlvJisInfo.JIS.Save", GetParameters_StrapDisableParam(model));
        }

        public List<DlvJisInfoGateModel> SelectJISGateModels(DlvJisInfoModelArgs args)
        {
            return PocketQuery<DlvJisInfoGateModel>("MD.DlvJisInfo.Gate.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD
                });
        }


        public List<DlvJisInfoJISModel> SelectJISModels(DlvJisInfoModelArgs args)
        {
            return PocketQuery<DlvJisInfoJISModel>("MD.DlvJisInfo.JIS.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    DLV_PLC_CD = args.Select_Gate_Dlv_Plc_CD,
                });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.QC.NcrReg;

namespace BPack.Pocket.App.QC.NcrReg
{
    public class NcrRegPocket : PocketBase
    {
        public NcrRegPocket()
        {
            InitPocket("NcrReg");
        }
        public List<NcrRegHeaderModel> SelectNcrRegHeaderModels(NcrRegModelArgs args)
        {
            return PocketQuery<NcrRegHeaderModel>("QC.NcrReg.Header.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_Cd,
                    PLANT_CD = args.Select_Main_Plant_Cd,
                    START_DT = args.Select_Main_Start_dt,
                    END_DT = args.Select_Main_End_dt,
                    NCH_STATUS = args.Select_Main_Nch_Status
                });
        }
        public void SaveNcrRegHeaderModels(List<NcrRegHeaderModel> models)
        {
            PocketExecute("QC.NcrReg.Header.Save", GetParameters_StrapDisableParam(models));
        }
        public void SaveNcrRegHeaderModel(NcrRegHeaderModel model)
        {
            PocketExecute("QC.NcrReg.Header.Save", GetParameters_StrapDisableParam(model));
        }

        public void ConfirmNcrRegHeaderModel(NcrRegHeaderConfirmModel model)
        {
            PocketExecute("QC.NcrReg.Header.BP", GetParameters_StrapDisableParam(model));
        }
        public void ConfirmNcrRegHeaderModels(List<NcrRegHeaderConfirmModel> models)
        {
            PocketExecute("QC.NcrReg.Header.BP", GetParameters_StrapDisableParam(models));
        }

        public List<NcrRegDetailModel> SelectNcrRegDetailModels(NcrRegModelArgs args)
        {
            return PocketQuery<NcrRegDetailModel>("QC.NcrReg.Detail.Select",
                new
                {
                    COMP_CD = args.Comp_cd,
                    PLANT_CD = args.Plant_cd,
                    NCH_NO = args.NCH_NO_KEY
                });
        }
        public void SaveNcrRegDetailModel(NcrRegDetailModel model)
        {
            PocketExecute("QC.NcrReg.Detail.Save", GetParameters_StrapDisableParam(model));
        }
        public void SaveNcrRegDetailModels(List<NcrRegDetailModel> models)
        {
            PocketExecute("QC.NcrReg.Detail.Save", GetParameters_StrapDisableParam(models));
        }

        public List<NcrRegDetailBomModel> SelectItemBomModels(NcrRegModelArgs args)
        {
            return PocketQuery<NcrRegDetailBomModel>("QC.NcrReg.ItemBom.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Cd,
                PLANT_CD = args.Select_Main_Plant_Cd,
                ITEM_CD = args.ITEM_CD,
                BOM_NO = args.BOM_NO
            });
        }

    }
}

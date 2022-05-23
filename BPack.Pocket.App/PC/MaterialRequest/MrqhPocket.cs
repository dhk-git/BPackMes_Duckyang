using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.PC.MaterialRequest;

namespace BPack.Pocket.App.PC.MaterialRequest
{
    public class MaterialRequestPocket : PocketBase
    {
        public MaterialRequestPocket()
        {
            InitPocket("MaterialRequest");
        }

        public List<MrqhListModel> SelectMrqhListModels(MaterialRequestModelArgs args)
        {
            return PocketQuery<MrqhListModel>("PC.MaterialRequest.MrqhList.R", new
            {
                COMP_CD = args.Select_Main_Comp_CD
            ,
                PLANT_CD = args.Select_Main_Plant_CD
            ,
                START_DT = args.START_DT
            ,
                END_DT = args.END_DT
            ,
                MRH_STATUS=args.MRH_STATUS
            });
        }

        public void SaveMrqhListModels(List<MrqhListModel> models)
        {
            PocketExecute("PC.MaterialRequest.MrqhList.S", GetParameters_StrapDisableParam(models));
        }
        public void SaveMrqhListModel(MrqhListModel model)
        {
            PocketExecute("PC.MaterialRequest.MrqhList.S", GetParameters_StrapDisableParam(model));
        }

        public List<MrqdListModel> SelectMrqdListModels(MaterialRequestModelArgs args)
        {
            return PocketQuery<MrqdListModel>("PC.MaterialRequest.MrqdList.R", new
            {
                COMP_CD = args.Select_Main_Comp_CD
            ,
                PLANT_CD = args.Select_Main_Plant_CD
            ,
                MRH_NO_KEY = args.MRH_NO_KEY
            });
        }

        public void SaveMrqdListModels(List<MrqdListModel> models)
        {
            PocketExecute("PC.MaterialRequest.MrqdList.S", GetParameters_StrapDisableParam(models));
        }
        public void SaveMrqdListModel(MrqdListModel model)
        {
            PocketExecute("PC.MaterialRequest.MrqdList.S", GetParameters_StrapDisableParam(model));
        }

        public List<MrqdHuListModel> SelectMrqdHuListModels(MaterialRequestModelArgs args)
        {
            return PocketQuery<MrqdHuListModel>("PC.MaterialRequest.MrqdHuList.R", new
            {
                COMP_CD = args.Select_Main_Comp_CD
            ,
                PLANT_CD = args.Select_Main_Plant_CD
            ,
                MRD_NO_KEY = args.MRD_NO_KEY
            });
        }

        public void SaveMrqdHuListModels(List<MrqdHuListModel> models)
        {
            PocketExecute("PC.MaterialRequest.MrqdHuListModel.S", GetParameters_StrapDisableParam(models));
        }
        public void SaveMrqdHuListModel(MrqdHuListModel model)
        {
            PocketExecute("PC.MaterialRequest.MrqdHuListModel.S", GetParameters_StrapDisableParam(model));
        }


    }
}

using BPack.Common.Pocket;
using BPack.Model.App.MM.MovDoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MM.MovDoc
{
    public class MovDocPocket : PocketBase
    {
        public MovDocPocket()
        {
            InitPocket("MovDoc");
        }

        public void SaveMovDocModel(MovDocModel movDocModel)
        {
            PocketExecute("MM.MovDoc.Doc.Save", GetParameters_StrapDisableParam(movDocModel));
        }

        public void SaveMovDocModels(List<MovDocModel> movDocModels)
        {
            PocketExecute("MM.MovDoc.Doc.Save", GetParameters_StrapDisableParam(movDocModels));
        }

        public void SaveMovHuModels(List<MovHuModel> movHuModels)
        {
            PocketExecute("MM.MovDoc.Hu.Save", GetParameters_StrapDisableParam(movHuModels));
        }

        public void SaveMovItemModels(List<MovItemModel> movItemModels)
        {
            PocketExecute("MM.MovDoc.Item.Save", GetParameters_StrapDisableParam(movItemModels));
        }

        public List<MovDocModel> SelectMovDocModels(MovDocModelArgs args)
        {
            return PocketQuery<MovDocModel>("MM.MovDoc.Doc.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                PLANT_CD = args.Select_Main_Plant_Cd,
                MOV_NO = args.Select_Mov_No
            });
        }

        public List<MovHuModel> SelectMovHuModels(MovDocModelArgs args)
        {
            return PocketQuery<MovHuModel>("MM.MovDoc.Hu.Select", new
            {
                MOV_NO = args.Select_Mov_No
            });
        }

        public List<MovItemModel> SelectMovItemModels(MovDocModelArgs args)
        {
            return PocketQuery<MovItemModel>("MM.MovDoc.Item.Select", new
            {
                MOV_NO = args.Select_Mov_No
            });

        }
    }
}

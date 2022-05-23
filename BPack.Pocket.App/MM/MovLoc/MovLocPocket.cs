using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.MovDoc;
using BPack.Model.App.MM.MovLoc;

namespace BPack.Pocket.App.MM.MovLoc
{
    public class MovLocPocket : PocketBase
    {
        public MovLocPocket()
        {
            InitPocket("MovLoc");
        }
        public void SaveModel(MovLocModel huModel)
        {
            var rst = PocketQuery<MovLocModel>("MM.MovLoc.Header.Save", GetParameters_StrapDisableParam( huModel)).SingleOrDefault();
            if (huModel.RowState == Common.Model.RowState.Added)
            {
                huModel.MOV_NO = rst.MOV_NO;
            }

        }

        public void SaveModels(List<MovLocModel> huModels)
        {
            PocketExecute("MM.MovLoc.Header.Save", GetParameters_StrapDisableParam(huModels));
        }

        public void SaveInOuptModelConfirm(MoveLocConfirmModel confirmModel)
        {
            try
            {
                PocketExecute("MM.MovLoc.Header.BP", GetParameters_StrapDisableParam(confirmModel));
                //PocketExecute("MM.MovLoc.Header.INOUT.Save", huModel);
            }
            catch
            { 
            
            }
        }
      
        public void SaveItemModel(MovLocItemModel huModel)
        {
            PocketExecute("MM.MovLoc.Detail.Save", GetParameters_StrapDisableParam(huModel));
        }

        public void SaveItemModels(List<MovLocItemModel> huModels)
        {
            PocketExecute("MM.MovLoc.Detail.Save", GetParameters_StrapDisableParam( huModels));
        }
        public List<MovLocItemModel> SelectDetailModels(MovLocModelArgs args)
        {
            return PocketQuery<MovLocItemModel>("MM.MovLoc.Detail.Select", new { MOV_NO = args.Select_Main_MOV_NO });
        }

        public List<MovLocModel> SelectHeaderModels(MovLocModelArgs args)
        {
            return PocketQuery<MovLocModel>("MM.MovLoc.Header.Select", new
            {
                COMP_CD=args.Select_Main_Comp_cd,
                PLANT_CD=args.Select_Main_Plant_cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                FROM_WH_CD = args.Select_Main_FROM_WH_CD,
                TO_WH_CD = args.Select_Main_TO_WH_CD,

            });
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.MovDocConfirm;

namespace BPack.Pocket.App.MM.MovDocConfirm
{
    public class MovDocConfirmPocket : PocketBase
    {
        public MovDocConfirmPocket()
        {
            InitPocket("MovDocConfirm");
        }

        public void BpMovDocConfirm(MovDocModel movDocModel)
        {
            PocketExecute("MM.MovDocConfirm.DocConfirm.BP", GetParameters_StrapDisableParam(movDocModel));
        }

        public List<MovDocModel> SelectMovDocModels(MovDocConfirmModelArgs args)
        {
            return PocketQuery<MovDocModel>("MM.MovDocConfirm.DocList.Select", new
            {
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                MOV_NO = args.Select_Main_Mov_No
            });
            
        }

        public MovDocReportModel SelectMovDocReportModel(MovDocConfirmModelArgs args)
        {
            var rawData = PocketQueryMultiple(GetQueryInfoModel_FromSelectedModels("MM.MovDocConfirm.DocReport.Select"), new
            {
                MOV_NO = args.Select_Mov_No
            });
            
            var movDoc = rawData.Read<MovDocReportModel>().SingleOrDefault();
            movDoc.MovItemModels = rawData.Read<MovItemReportModel>().ToList();
            var movHu = rawData.Read<MovHuReportModel>().ToList();
            foreach (var model in movDoc.MovItemModels)
            {
                model.MovHuModels = movHu.Where(a => a.MOD_NO == model.MOD_NO).ToList();
            }
            return movDoc;

        }
    }
}

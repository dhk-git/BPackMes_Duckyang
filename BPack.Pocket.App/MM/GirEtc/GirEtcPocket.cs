using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.GirEtc;

namespace BPack.Pocket.App.MM.GirEtc
{
    public class GirEtcPocket : PocketBase
    {
        public GirEtcPocket()
        {
            InitPocket("GirEtc");
        }

         public void SaveModel(GirEtcModel huModel)
        {
            var rst = PocketQuery<GirEtcModel>("MM.GirEtc.Header.Save", GetParameters_StrapDisableParam(huModel)).SingleOrDefault();
            if (huModel.RowState == Common.Model.RowState.Added)
            {
                huModel.ETG_NO = rst.ETG_NO;
            }
        }

        public void SaveModels(List<GirEtcModel> huModels)
        {
            PocketExecute("MM.GirEtc.Header.Save", GetParameters_StrapDisableParam(huModels));
        }

        public void SaveInOutModel(GirEtcModel huModel)
        {
            PocketExecute("MM.GirEtc.Header.INOUT.BP", GetParameters_StrapDisableParam(huModel));
        }

        //public void SaveInOutModels(List<GirEtcModel> huModels)
        //{
        //    PocketExecute("MM.GirEtc.Header.INOUT.Save", huModels);
        //}

        public void SaveItemModel(GirEtcItemModel huModel)
        {
            PocketExecute("MM.GirEtc.Detail.Save", GetParameters_StrapDisableParam(huModel));
        }

        public void SaveItemModels(List<GirEtcItemModel> huModels)
        {
            PocketExecute("MM.GirEtc.Detail.Save", GetParameters_StrapDisableParam(huModels));
        }
        public List<GirEtcItemModel> SelectDetailModels(GirEtcModelArgs args)
        {
            return PocketQuery<GirEtcItemModel>("MM.GirEtc.Detail.Select", new { ETG_NO = args.Select_Etg_No });
        }

        public List<GirEtcModel> SelectHeaderModels(GirEtcModelArgs args)
        {
            return PocketQuery<GirEtcModel>("MM.GirEtc.Header.Select", new {

                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                WH_CD = args.Select_Main_WH_CD,
                
            });
        }
    }
}

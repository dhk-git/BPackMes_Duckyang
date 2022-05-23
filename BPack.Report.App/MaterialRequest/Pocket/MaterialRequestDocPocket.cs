using BPack.Common.Pocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.MaterialRequest.Pocket
{
    class MaterialRequestDocPocket : PocketBase
    {
        public MaterialRequestDocPocket()
        {
            InitPocket("ReportQuerys");
        }

        public List<MaterialRequestHeaderModel> SelectMaterialRequestHeaderModel(MaterialRequestDocModelArgs args)
        {
            return PocketQuery<MaterialRequestHeaderModel>("Report.MaterialRequest.Header.R", new
            {
                COMP_CD = args.COMP_CD
            ,
                PLANT_CD = args.PLANT_CD
              ,
                MRH_NO = args.MRH_NO
            });
        }
        public List<MaterialRequestDetailModel> SelectMaterialRequestDetailModel(MaterialRequestDocModelArgs args)
        {
            return PocketQuery<MaterialRequestDetailModel>("Report.MaterialRequest.Detail.R", new
            {
                COMP_CD = args.COMP_CD
    ,
                PLANT_CD = args.PLANT_CD
      ,
                MRH_NO = args.MRH_NO
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.QciNcr;

namespace BPack.Pocket.App.MD.QciNcr
{
    public class QciNcrPocket : PocketBase
    {
        public QciNcrPocket()
        {
            InitPocket("QciNcr");
        }

        public void SaveQciNcrCodeModel(QciNcrCodeModel qciNcrCodeModel)
        {
            PocketExecute("MD.QciNcr.Code.Save", GetParameters_StrapDisableParam(qciNcrCodeModel));
        }

        public void SaveQciNcrTypeModel(QciNcrTypeModel qciNcrTypeModel)
        {
            PocketExecute("MD.QciNcr.Type.Save", GetParameters_StrapDisableParam(qciNcrTypeModel));
        }

        public List<QciNcrCodeModel> SelectQciNcrCodeModels(QciNcrModelArgs qciNcrModelArgs)
        {
            return PocketQuery<QciNcrCodeModel>("MD.QciNcr.Code.Select",
                new
                {
                    COMP_CD = qciNcrModelArgs.Select_Main_Comp_CD,
                    NCR_TYPE = qciNcrModelArgs.Select_Type_Ncr_Type
                });
        }

        public List<QciNcrTypeModel> SelectQciNcrTypeModels(QciNcrModelArgs qciNcrModelArgs)
        {
            return PocketQuery<QciNcrTypeModel>("MD.QciNcr.Type.Select",
                new
                {
                    COMP_CD = qciNcrModelArgs.Select_Main_Comp_CD
                });
        }
    }
}

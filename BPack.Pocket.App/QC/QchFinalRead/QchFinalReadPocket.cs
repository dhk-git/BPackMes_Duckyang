using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.QC.QchFinalRead;

namespace BPack.Pocket.App.QC.QchFinalRead
{
    public class QchFinalReadPocket : PocketBase
    {
        public QchFinalReadPocket()
        {
            InitPocket("QchFinalRead");
        }

        public void SaveQchFinalReadHeaderModel(QchFinalReadHeaderModel model)
        {
            PocketExecute("QC.QchFinalRead.Header.Save", GetParameters_StrapDisableParam(model));
        }

        public void SaveQchFinalReadHeaderModels(List<QchFinalReadHeaderModel> models)
        {
            PocketExecute("QC.QchFinalRead.Header.Save", GetParameters_StrapDisableParam(models));
        }

        public void SaveQchFinalReadDetailModel(QchFinalReadDetailModel model)
        {
            PocketExecute("QC.QchFinalRead.Detail.Save", GetParameters_StrapDisableParam(model));
        }

        public void SaveQchFinalReadDetailModels(List<QchFinalReadDetailModel> models)
        {
            PocketExecute("QC.QchFinalRead.Detail.Save", GetParameters_StrapDisableParam(models));
        }

        public List<QchFinalReadDetailModel> SelectQchFinalReadDetailModels(QchFinalReadModelArgs args)
        {
            return PocketQuery<QchFinalReadDetailModel>("QC.QchFinalRead.Detail.Select",
                new
                {
                    INSP_NO = args.Select_Insp_No
                });
        }

        public List<QchFinalReadHeaderModel> SelectQchFinalReadHeaderModels(QchFinalReadModelArgs args)
        {
            return PocketQuery<QchFinalReadHeaderModel>("QC.QchFinalRead.Header.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    WO_DT_FROM = args.Select_Main_WorkOrderDate_From,
                    WO_DT_TO = args.Select_Main_WorkOrderDate_To,
                    WC_CD = args.Select_Main_WorkCenter_CD,
                    SHIFT_CD = args.Select_Main_Shift_CD,
                    ITEM_GR_CD = args.Select_Main_ItemGroup_CD,
                    ITEM_CD = args.Select_Main_Item_CD,
                    INSP_JUDGE = args.Select_Main_Insp_Judge
                });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.QC.QchPatrolRead;

namespace BPack.Pocket.App.QC.QchPatrolRead
{
    public class QchPatrolReadPocket : PocketBase
    {
        public QchPatrolReadPocket()
        {
            InitPocket("QchPatrolRead");
        }

        public void SaveQchPatrolReadHeaderModel(QchPatrolReadHeaderModel model)
        {
            PocketExecute("QC.QchPatrolRead.Header.Save", GetParameters_StrapDisableParam(model));
        }

        public void SaveQchPatrolReadHeaderModels(List<QchPatrolReadHeaderModel> models)
        {
            PocketExecute("QC.QchPatrolRead.Header.Save", GetParameters_StrapDisableParam(models));
        }

        public void SaveQchPatrolReadDetialModel(QchPatrolReadDetailModel model)
        {
            PocketExecute("QC.QchPatrolRead.Detail.Save", GetParameters_StrapDisableParam(model));
        }

        public void SaveQchPatrolReadDetialModels(List<QchPatrolReadDetailModel> models)
        {
            PocketExecute("QC.QchPatrolRead.Detail.Save", GetParameters_StrapDisableParam(models));
        }

        public List<QchPatrolReadDetailModel> SelectQchPatrolReadDetailModels(QchPatrolReadModelArgs args)
        {
            return PocketQuery<QchPatrolReadDetailModel>("QC.QchPatrolRead.Detail.Select",
                new
                {
                    INSP_NO = args.Select_Header_Insp_No
                });
        }

        public List<QchPatrolReadHeaderModel> SelectQchPatrolReadHeaderModels(QchPatrolReadModelArgs args)
        {
            return PocketQuery<QchPatrolReadHeaderModel>("QC.QchPatrolRead.Header.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    INSP_DT_FROM = args.Select_Main_InspDate_From,
                    INSP_DT_TO = args.Select_Main_InspDate_To,
                    WH_CD = args.Select_Main_Warehouse_CD,
                    LOC_CD = args.Select_Main_Location_CD,
                    ITEM_GR_CD = args.Select_Main_ItemGroup_CD,
                    ITEM_CD = args.Select_Main_Item_CD,
                    INSP_JUDGE = args.Select_Main_Insp_Judge
                });
        }
    }
}

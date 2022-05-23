using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.QC.QchFmlRead;

namespace BPack.Pocket.App.QC.QchFmlRead
{
    public class QchFmlReadPocket : PocketBase
    {
        public QchFmlReadPocket()
        {
            InitPocket("QchFmlRead");
        }

        public void SaveQchFmlReadHeaderModel(QchFmlReadHeaderModel model)
        {
            PocketExecute("QC.QchFmlRead.Header.Save", GetParameters_StrapDisableParam(model));
        }

        public void SaveQchFmlReadHeaderModels(List<QchFmlReadHeaderModel> models)
        {
            PocketExecute("QC.QchFmlRead.Header.Save", GetParameters_StrapDisableParam(models));
        }

        public List<QchFmlReadDetailModel> SelectQchFmlReadDetailModels(QchFmlReadModelArgs args)
        {
            return PocketQuery<QchFmlReadDetailModel>("QC.QchFmlRead.Detail.Select",
                new
                {
                    INSP_NO = args.Select_Insp_No
                });
        }

        public List<QchFmlReadHeaderModel> SelectQchFmlReadHeaderModels(QchFmlReadModelArgs args)
        {
            return PocketQuery<QchFmlReadHeaderModel>("QC.QchFmlRead.Header.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    WO_DT_FROM = args.Select_Main_WorkOrderDate_From,
                    WO_DT_TO = args.Select_Main_WorkOrderDate_To,
                    SHIFT_CD = args.Select_Main_Shift_CD,
                    WC_CD = args.Select_Main_WorkCenter_CD,
                    ITEM_GR_CD = args.Select_Main_ItemGroup_CD,
                    ITEM_CD = args.Select_Main_Item_CD,
                    INSP_SUB_TYPE_F = args.Select_Main_Insp_Sub_Type_F,
                    INSP_SUB_TYPE_M = args.Select_Main_Insp_Sub_Type_M,
                    INSP_SUB_TYPE_L = args.Select_Main_Insp_Sub_Type_L,
                    INSP_JUDGE = args.Select_Main_Insp_Judge
                });
        }
    }
}

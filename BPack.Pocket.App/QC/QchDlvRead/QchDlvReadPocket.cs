using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.QC.QchDlvRead;

namespace BPack.Pocket.App.QC.QchDlvRead
{
    public class QchDlvReadPocket : PocketBase
    {
        public QchDlvReadPocket()
        {
            InitPocket("QchDlvRead");
        }

        public List<QchDlvReadHeaderModel> SelectQchDlvReadHeaderModels(QchDlvReadModelArgs args)
        {
            return PocketQuery<QchDlvReadHeaderModel>("QC.QchDlvRead.Header.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    INSP_DT_FROM = args.Select_Main_InspDate_From,
                    INSP_DT_TO = args.Select_Main_InspDate_To,
                    ITEM_GR_CD = args.Select_Main_ItemGroup_CD,
                    ITEM_CD = args.Select_Main_Item_CD,
                    INSP_JUDGE = args.Select_Main_Insp_Judge
                });
        }
        public List<QchDlvReadDetailModel> SelectQchDlvReadDetailModels(QchDlvReadModelArgs args)
        {
            return PocketQuery<QchDlvReadDetailModel>("QC.QchDlvRead.Detail.Select",
                new
                {
                    INSP_NO = args.Select_Header_Insp_No
                });
        }

        public void SaveQchDlvReadDetialModel(QchDlvReadDetailModel model)
        {
            PocketExecute("QC.QchDlvRead.Detail.Save", GetParameters_StrapDisableParam(model));
        }

        public void SaveQchDlvReadDetialModels(List<QchDlvReadDetailModel> models)
        {
            var aaa = GetParameters_StrapDisableParam(models);
            PocketExecute("QC.QchDlvRead.Detail.Save", GetParameters_StrapDisableParam(models));
        }
    }
}

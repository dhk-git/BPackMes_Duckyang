using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.QciInspStd;

namespace BPack.Pocket.App.MD.QciInspStd
{
    public class QciInspStdPocket : PocketBase
    {
        public QciInspStdPocket()
        {
            InitPocket("QciInspStd");
        }

        public void SaveInspectionCheckListModel(InspectionCheckListModel inspectionCheckListModel)
        {
            PocketExecute("MD.QciInspStd.CheckList.Save", GetParameters_StrapDisableParam(inspectionCheckListModel));
        }

        public void SaveInspectionCheckListFileModel(InspectionCheckListModel inspectionCheckListModel)
        {
            PocketExecute("MD.QciInspStd.CheckListFile.Save", GetParameters_StrapDisableParam(inspectionCheckListModel));
        }

        public void SaveInspectionCheckListModels(List<InspectionCheckListModel> inspectionCheckListModels)
        {
            PocketExecute("MD.QciInspStd.CheckList.Save", GetParameters_StrapDisableParam(inspectionCheckListModels));
        }

        public void SaveInspectionRevisionModel(InspectionRevisionModel inspectionRevisionModel)
        {
            PocketExecute("MD.QciInspStd.Revision.Save", GetParameters_StrapDisableParam(inspectionRevisionModel));
        }

        public void SaveInspectionStandardModel(InspectionStandardModel inspectionStandardModel)
        {
            PocketExecute("MD.QciInspStd.Standard.Save", GetParameters_StrapDisableParam(inspectionStandardModel));
        }

        public List<InspectionCheckListModel> SelectInspectionCheckListModels(QciInspStdModelArgs qciInspStdModelArgs)
        {
            return PocketQuery<InspectionCheckListModel>("MD.QciInspStd.CheckList.Select",
                new
                {
                    INSP_STD_ID = qciInspStdModelArgs.Select_Standard_Insp_Std_ID,
                    REVISION = qciInspStdModelArgs.Select_Revision_Revision
                });
        }

        public List<InspectionRevisionModel> SelectInspectionRevisionModels(QciInspStdModelArgs qciInspStdModelArgs)
        {
            return PocketQuery<InspectionRevisionModel>("MD.QciInspStd.Revision.Select",
                new
                {
                    COMP_CD = qciInspStdModelArgs.Select_Main_Comp_CD,
                    PLANT_CD = qciInspStdModelArgs.Select_Main_Plant_CD,
                    INSP_TYPE = qciInspStdModelArgs.Select_Standard_Insp_type,
                    INSP_STD_ID = qciInspStdModelArgs.Select_Standard_Insp_Std_ID
                });
        }

        public List<InspectionStandardModel> SelectInspectionStandardModels(QciInspStdModelArgs qciInspStdModelArgs)
        {
            return PocketQuery<InspectionStandardModel>("MD.QciInspStd.Standard.Select",
                new
                {
                    COMP_CD = qciInspStdModelArgs.Select_Main_Comp_CD,
                    PLANT_CD = qciInspStdModelArgs.Select_Main_Plant_CD,
                    INSP_TYPE = qciInspStdModelArgs.Select_Main_Insp_Type,
                    ITEM_CD = qciInspStdModelArgs.Select_Main_Item_CD
                });
        }

        //public List<ItemModel> SelectItemModels(QciInspStdModelArgs modelArgs)
        //{
        //    return PocketQuery<ItemModel>("MD.QciInspStd.Item.Select", new
        //    {
        //        COMP_CD = modelArgs.Select_Main_Comp_CD,
        //        PLANT_CD = modelArgs.Select_Main_Plant_CD,
        //        ITEM_GR_1 = modelArgs.Select_Item_Item_Gr_1,
        //        ITEM_GR_2 = modelArgs.Select_Item_Item_Gr_2,
        //        ITEM_TYPE = modelArgs.Select_Item_Item_Type,
        //        ITEM_CD = modelArgs.Select_Item_Item_Cd,
        //        ITEM_NM = modelArgs.Select_Item_Item_Nm,
        //    });
        //}
    }
}

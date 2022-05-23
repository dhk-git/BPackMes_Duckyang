using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.QciFMLGroup;

namespace BPack.Pocket.App.MD.QciFMLGroup
{
    public class QciFMLGroupPocket : PocketBase
    {
        public QciFMLGroupPocket()
        {
            InitPocket("QciFMLGroup");
        }

        public void SaveQciFMLGroupItemModel(QciFMLGroupItemModel qciFMLGroupItemModel)
        {
            PocketExecute("MD.QciFMLGroup.Item.Save", GetParameters_StrapDisableParam(qciFMLGroupItemModel));
        }

        public void SaveQciFMLGroupModel(QciFMLGroupModel qciFMLGroupModel)
        {
            PocketExecute("MD.QciFMLGroup.Group.Save", GetParameters_StrapDisableParam(qciFMLGroupModel));
        }

        public List<QciFMLGroupItemModel> SelectQciFMLGroupItemModels(QciFMLGroupModelArgs args)
        {
            return PocketQuery<QciFMLGroupItemModel>("MD.QciFMLGroup.Item.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    FML_GR = args.Select_Type_Fml_GR,
                });
        }

        public List<QciFMLGroupModel> SelectQciFMLGroupModels(QciFMLGroupModelArgs args)
        {
            return PocketQuery<QciFMLGroupModel>("MD.QciFMLGroup.Group.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                });
        }
    }
}

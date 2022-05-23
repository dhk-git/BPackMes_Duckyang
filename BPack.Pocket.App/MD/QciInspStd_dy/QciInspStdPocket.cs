using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.QciInspStd_dy;

namespace BPack.Pocket.App.MD.QciInspStd_dy
{
    public class QciInspStd_dyPocket : PocketBase
    {
        public QciInspStd_dyPocket()
        {
            InitPocket("QciInspStd_dy");
        }
        public List<QciLinspStdHeaderModel> SelectQciLinspStdHeaderModels(QciInspStd_dyModelArgs args)
        {
            return PocketQuery<QciLinspStdHeaderModel>("MD.QciInspStd_dy.HeaderList.Select", new
            {
                LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                ITEM_GR_1 =args.Select_Main_ITEM_GR_1,
                ITEM_TYPE_CD=args.Select_Main_ITEM_TYPE_CD,
                ITEM_CD=args.Select_Main_ITEM_CD,
                ITEM_NM=args.Select_Main_ITEM_NM,
                QCI_TYPE=args.Select_Main_QCI_TYPE

            });
        }
        public void SaveQciLinspStdHeaderModel(QciLinspStdHeaderModel model)
        {
            PocketExecute("MD.QciInspStd_dy.HeaderList.Save", GetParameters_StrapDisableParam (model));
        }
        public void SaveQciLinspStdHeaderModels(List<QciLinspStdHeaderModel> models)
        {
            PocketExecute("MD.QciInspStd_dy.HeaderList.Save", GetParameters_StrapDisableParam( models));
        }
    }
}

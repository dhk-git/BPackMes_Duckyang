using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.PrdShift;

namespace BPack.Pocket.App.MD.PrdShift
{
    public class PrdShiftPocket : PocketBase
    {
        public PrdShiftPocket()
        {
            InitPocket("PrdShift");
        }

        public void SaveShiftGroupModel(ShiftGroupModel model)
        {
            PocketExecute("MD.PrdShift.ShiftGroupList.Save", model);
        }

        public void SaveShiftGroupModels(List<ShiftGroupModel> models)
        {
            PocketExecute("MD.PrdShift.ShiftGroupList.Save", models);
        }

        public List<ShiftGroupModel> SelectShiftGroupModels(PrdShiftModelArgs args)
        {
            return PocketQuery<ShiftGroupModel>("MD.PrdShift.ShiftGroupList.Select", new
            {
                LANG_CODE= Common.LoginInfo.UserInfo.Sys_Language,
                CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID,
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
            });
        }

        public void SaveShiftModel(ShiftModel model)
        {
            PocketExecute("MD.PrdShift.ShiftList.Save", model);
        }
        public void SaveShiftModels(List<ShiftModel> models)
        {
            PocketExecute("MD.PrdShift.ShiftList.Save", models);
        }

        public List<ShiftModel> SelectShiftModels(PrdShiftModelArgs args)
        {
            return PocketQuery<ShiftModel>("MD.PrdShift.ShiftList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                SHIFT_GROUP_CD=args.SHIFT_GROUP_CD
            });
        }

        public List<ShiftDetailGroupModel> SelectShiftDetailGroupModel(PrdShiftModelArgs args)
        {
            return PocketQuery<ShiftDetailGroupModel>("MD.PrdShift.ShiftDetailGroupList.Select", new
            {
                COMP_CD = args.Select_Main_Comp_Code,
                PLANT_CD = args.Select_Main_Plant_Code,
                SHIFT_GROUP_CD = args.SHIFT_GROUP_CD
            });
        }
        public void SaveShiftDetailGroupModels(List<ShiftDetailGroupModel> models)
        {
            PocketExecute("MD.PrdShift.ShiftDetailGroupList.Save", models);
        }
        public void SaveShiftDetailGroupModel(ShiftDetailGroupModel model)
        {
            PocketExecute("MD.PrdShift.ShiftDetailGroupList.Save", model);
        }




    }
}

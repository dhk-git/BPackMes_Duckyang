using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.PurInbound;

namespace BPack.Pocket.App.MM.PurInbound
{
    public class PurInboundPocket : PocketBase
    {
        public PurInboundPocket()
        {
            InitPocket("PurInbound");
        }

        public void BpInDetail(List<InDetailModel> inDetailModels)
        {
            PocketExecute("MM.PurInbound.InDetail.BP", inDetailModels);
        }

        public void BpInHeader(ConfirmInHeaderModel confirmInHeaderModel)
        {
            PocketExecute("MM.PurInbound.InHeader.BP", confirmInHeaderModel);
        }

        public void BpInHeader(List<InHuHeaderModel> inHuProcessModels)
        {
            PocketExecute("MM.PurInbound.InHuHeader.BP", GetParameters_StrapDisableParam(inHuProcessModels));
        }
        public void BpInHu(List<InHuProcessModel> inHuProcessModels)
        {
            PocketExecute("MM.PurInbound.InHu.BP", GetParameters_StrapDisableParam(inHuProcessModels));
        }

        public void SaveInDetailModel(InDetailModel inDetailModel)
        {
            PocketExecute("MM.PurInbound.InDetail.Save", GetParameters_StrapDisableParam(inDetailModel));
        }

        public void SaveInDetailModels(List<InDetailModel> inDetailModels)
        {
            PocketExecute("MM.PurInbound.InDetail.Save", GetParameters_StrapDisableParam(inDetailModels));
        }

        public void SaveInHeaderModel(InHeaderModel inHeaderModel)
        {
            var rst = PocketQuery<InHeaderModel>("MM.PurInbound.InHeader.Save", GetParameters_StrapDisableParam(inHeaderModel)).SingleOrDefault();
            if (inHeaderModel.RowState == Common.Model.RowState.Added)
            {
                inHeaderModel.PIH_NO = rst?.PIH_NO;
            }
        }

        public List<PurPackModel> SelectPurPackModels(PurInboundModelArgs args)
        {
            return PocketQuery<PurPackModel>("MM.PurInbound.PurPackList.Select", new {
                START_DT = args.Select_Main_PackingList_Start_Dt,
                END_DT = args.Select_Main_PackingList_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1
            });
        }

        public void SaveInHeaderModels(List<InHeaderModel> inHeaderModels)
        {
            PocketExecute("MM.PurInbound.InHeader.Save",  GetParameters_StrapDisableParam(inHeaderModels));
        }

        public void SaveInHuModel(InHuModel inHuModel)
        {
            PocketExecute("MM.PurInbound.InHu.Save", GetParameters_StrapDisableParam(inHuModel));
        }

        public void SaveInHuModels(List<InHuModel> inHuModels)
        {
            PocketExecute("MM.PurInbound.InHu.Save", GetParameters_StrapDisableParam(inHuModels));
        }

        public List<InDetailModel> SelectInDetailModels(PurInboundModelArgs args)
        {
            return PocketQuery<InDetailModel>("MM.PurInbound.InDetail.Select", new {
                PIH_NO = args.Select_Pih_No
            });
        }

        public List<InHeaderModel> SelectInHeaderModels(PurInboundModelArgs args)
        {
            return PocketQuery<InHeaderModel>("MM.PurInbound.InHeader.Select", new
            {
                COMP_CD = args.Select_Comp_Cd,
                BP_CD = args.Select_Main_Bp_Cd,
                PIH_NO = args.Select_Main_Pih_No,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt
            });
        }

        public List<InHuModel> SelectInHuModels(PurInboundModelArgs args)
        {
            return PocketQuery<InHuModel>("MM.PurInbound.InHu.Select", new
            {
                PIH_NO = args.Select_Pih_No,
                PID_NO = args.Select_Pid_No
            });
        }
    }
}

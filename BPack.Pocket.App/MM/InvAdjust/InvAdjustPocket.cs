using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.InvAdjust;
using Dapper;

namespace BPack.Pocket.App.MM.InvAdjust
{
    public class InvAdjustPocket : PocketBase
    {
        public InvAdjustPocket()
        {
            InitPocket("InvAdjust");
        }

        public List<InvAdjOrderModel> SelectInvOrderModels(InvAdjustModelArgs args)
        {
            return PocketQuery<InvAdjOrderModel>("MM.InvAdjust.InvAdjOrderList.Select", new
            {
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Cd,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                TARGET_INV_GR = args.Select_Main_Taget_Inv_Gr
            });
        }

        public List<InvAdjDetailModel> SelectInvAdjDetailModels(InvAdjustModelArgs args)
        {
            return PocketQuery<InvAdjDetailModel>("MM.InvAdjust.InvAdjDetailList.Select", new
            {
                INV_NO = args.Select_Inv_No
            });
        }

        public List<InvAdjItemModel> SelectInvAdjItemModels(InvAdjustModelArgs args)
        {
            return PocketQuery<InvAdjItemModel>("MM.InvAdjust.InvAdjItemList.Select", new
            {
                INVD_NO = args.Select_Invd_No
            });
        }

        public List<InvAdjHuModel> SelectInvAdjHuModels(InvAdjustModelArgs args)
        {
            return PocketQuery<InvAdjHuModel>("MM.InvAdjust.InvAdjHuList.Select", new
            {
                INVD_NO = args.Select_Invd_No,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = args.Select_Main_Plant_Cd,
                ITEM_CD = args.Select_Item_Cd
            });
        }

        public void SaveInvAdjHuModels(List<InvAdjHuModel> invAdjHuModels)
        {
            foreach (var model in invAdjHuModels)
            {
                model.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                model.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
            }
            PocketExecute("MM.InvAdjust.InvAdjHuList.Save", GetParameters_StrapDisableParam(invAdjHuModels));
        }

        public void BpAddInvResultLikeLogi(List<InvAdjAddResultLikeLogiModel> invAdjHuModels)
        {
            foreach (var model in invAdjHuModels)
            {
                model.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                model.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
            }
            //PocketExecute("MM.InvAdjust.AddInvResultLikeLogi.BP", GetParameters_StrapDisableParam(invAdjHuModels));
            var queryModel1 = GetQueryInfoModel_FromSelectedModels("MM.InvAdjust.AddInvResultLikeLogi.BP");
            var queryModel2 = GetQueryInfoModel_FromSelectedModels("MM.InvAdjust.AddInvResultLikeLogiSumItemQty.BP");
            using (var con = new SqlConnection(ConnectionInfo.GetConnectionString(queryModel1.DB_CONNECTION)))
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        //실사결과 데이터 일괄 등록
                        con.Execute(queryModel1.QUERY_TEXT, GetParameters_StrapDisableParam(invAdjHuModels),commandType:System.Data.CommandType.StoredProcedure ,transaction: tran);
                        //실사결과 데이터 item 수량 반영
                        con.Execute(queryModel2.QUERY_TEXT, GetParameters_StrapDisableParam(invAdjHuModels), commandType: System.Data.CommandType.StoredProcedure, transaction: tran);
                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public void BpAdjustInvDetail(List<InvAdjDetailModel> invAdjDetailModels)
        {
            foreach (var model in invAdjDetailModels)
            {
                model.CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID;
                model.MODIFY_USER_ID = Common.LoginInfo.UserInfo.UserID;
            }
            PocketExecute("MM.InvAdjust.WhLocGirAdjust.BP", GetParameters_StrapDisableParam(invAdjDetailModels));
        }

    }
}

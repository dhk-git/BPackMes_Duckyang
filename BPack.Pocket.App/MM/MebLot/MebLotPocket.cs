using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MM.MebLot;
using Dapper;

namespace BPack.Pocket.App.MM.MebLot
{
    public class MebLotPocket : PocketBase
    {
        public MebLotPocket()
        {
            InitPocket("MebLot");
        }

        public List<MPackAndPartLotModel> SelectMPackAndPartLotModels(MebLotModelArgs args)
        {
            return PocketQuery<MPackAndPartLotModel>("MM.MebLot.MPackAndPartList.Select", new
            {
                L_PACK_NO = args.Select_L_Pack_No,
                M_PACK_NO = args.Select_M_Pack_No,
                CHK_ALL_MPACK = args.Select_Main_Chk_All_MPack,
                PART_LOT = args.Select_Main_PartLotNo
            });
        }

        public List<LPackAndMPackModel> SelectLPackAndMPackModels(MebLotModelArgs args)
        {
            return PocketQuery<LPackAndMPackModel>("MM.MebLot.LPackAndMPackList.Select", new
            {
                L_PACK_NO = args.Select_Main_LPackNo,
                M_PACK_NO = args.Select_Main_MPackNo,
                CASE_NO = args.Select_Main_CaseNo,
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                PART_LOT = args.Select_Main_PartLotNo
            });
        }

        public void SaveLPackAndMPackModels(List<LPackAndMPackModel> newModels)
        {
            try
            {
                //삭제할 대포장정보
                List<PackModel> deletingLPackList;
                deletingLPackList = newModels.GroupBy(a => new { PACK_NO = a.PACK_NO })
                    .Select(a => new PackModel
                    {
                        PACK_NO = a.Key.PACK_NO,
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
                    }).ToList();

                using (SqlConnection con = new SqlConnection(ConnectionInfo.GetConnectionString("APP")))
                {
                    con.Open();
                    using (SqlTransaction tran = con.BeginTransaction())
                    {
                        try
                        {
                            //대포장 삭제
                            var deleteQueryInfoModel = GetQueryInfoModel_FromSelectedModels("MM.MebLot.LPackAndMPack.Delete");
                            con.Execute(deleteQueryInfoModel.QUERY_TEXT, deletingLPackList, commandType: System.Data.CommandType.StoredProcedure, transaction: tran);

                            //대/중포장 등록
                            var insertQueryInfoModel = GetQueryInfoModel_FromSelectedModels("MM.MebLot.LPackAndMPack.Insert");
                            con.Execute(insertQueryInfoModel.QUERY_TEXT, newModels, commandType: System.Data.CommandType.StoredProcedure, transaction: tran);

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
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveMPackAndMPartModels(List<MPackAndPartLotModel> newModels)
        {
            try
            {
                //삭제할 중포장정보
                List<PackModel> deletingMPackList;
                deletingMPackList = newModels.GroupBy(a => new { PACK_NO = a.PACK_NO })
                    .Select(a => new PackModel
                    {
                        PACK_NO = a.Key.PACK_NO,
                        CREATE_USER_ID = Common.LoginInfo.UserInfo.UserID,
                        LANG_CODE = Common.LoginInfo.UserInfo.Sys_Language
                    }).ToList();

                using (SqlConnection con = new SqlConnection(ConnectionInfo.GetConnectionString("APP")))
                {
                    con.Open();
                    using (SqlTransaction tran = con.BeginTransaction())
                    {
                        try
                        {
                            //중포장 삭제
                            var deleteQueryInfoModel = GetQueryInfoModel_FromSelectedModels("MM.MebLot.MPackAndPart.Delete");
                            con.Execute(deleteQueryInfoModel.QUERY_TEXT, deletingMPackList, commandType: System.Data.CommandType.StoredProcedure, transaction: tran);

                            //중포장 및 개별 LOT 등록
                            var insertQueryInfoModel = GetQueryInfoModel_FromSelectedModels("MM.MebLot.MPackAndPart.Insert");
                            con.Execute(insertQueryInfoModel.QUERY_TEXT, newModels, commandType: System.Data.CommandType.StoredProcedure, transaction: tran);

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
            catch (Exception)
            {
                throw;
            }

        }
    }
}

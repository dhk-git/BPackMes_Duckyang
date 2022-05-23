using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.SD.CiqDlvClose;

namespace BPack.Pocket.App.SD.CiqDlvClose
{
    public class CiqDlvClosePocket : PocketBase
    {
        public CiqDlvClosePocket()
        {
            InitPocket("CiqDlvClose");
        }
        public List<DlvResultDetailModel> SelectDlvResultDetailModels(CiqDlvCloseModelArgs args)
        {
            return PocketQuery<DlvResultDetailModel>("SD.CiqDlvClose.DlvResultList.R", new { 
                START_DT = args.Select_Main_Start_Dt,
                END_DT = args.Select_Main_End_Dt,
                COMP_CD = Common.LoginInfo.UserInfo.CompCode,
                PLANT_CD = Common.LoginInfo.UserInfo.PlantCode,
                ITEM_CD = args.Select_Main_Item_Cd,
                ITEM_NM = args.Select_Main_Item_Nm,
                ITEM_GR_1 = args.Select_Main_Item_Gr_1,
                BP_CD = args.Select_Main_Bp_Cd
            });
        }

        public void SaveDlvResultDetailModels(List<DlvResultDetailModel> dlvResultDetailModels)
        {
            PocketExecute("SD.CiqDlvClose.DlvResultList.U", GetParameters_StrapDisableParam(dlvResultDetailModels));
        }

        public void BpExcelUpload(List<BpSkbaDataExcelUploadModel> bpSkbaDataExcelUploadModels)
        {
            PocketExecute("SD.CiqDlvClose.DlvResultList.ExcelUpload.BP", bpSkbaDataExcelUploadModels);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.QC.QchNcrRegRead;

namespace BPack.Pocket.App.QC.QchNcrRegRead
{
    public class QchNcrRegReadPocket : PocketBase
    {
        public QchNcrRegReadPocket()
        {
            InitPocket("QchNcrRegRead");
        }
        public List<QchNcrRegReadHeaderModel> SelectQchNcrRegReadHeaderModels(QchNcrRegReadModelArgs args)
        {
            return PocketQuery<QchNcrRegReadHeaderModel>("QC.QchNcrRegRead.Header.Select",
                   new
                   {
                       COMP_CD = args.Select_Main_Comp_Cd,
                       PLANT_CD = args.Select_Main_Plant_Cd,
                       START_DT = args.Select_Main_Start_dt,
                       END_DT = args.Select_Main_End_dt,
                       ITEM_GR1=args.Select_Main_Item_Group1,
                       ITEM_CD = args.Select_Main_Item_Cd,
                       ITEM_NM=args.Select_Main_Item_Nm,
                       NCH_TYPE=args.Select_Main_Nch_Type
                   });
        }
        public List<QchNcrRegReadDetailModel> SelectQchNcrRegReadDetailModels(QchNcrRegReadModelArgs args)
        {
            return PocketQuery<QchNcrRegReadDetailModel>("QC.QchNcrRegRead.Detail.Select",
                   new
                   {
                       COMP_CD = args.Comp_cd,
                       PLANT_CD = args.Plant_cd,
                       START_DT = args.Start_dt,
                       ITEM_CD = args.Item_cd
                   });
        }

    }
}

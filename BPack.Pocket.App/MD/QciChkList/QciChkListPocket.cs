using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Pocket;
using BPack.Model.App.MD.QciChkList;

namespace BPack.Pocket.App.MD.QciChkList
{
    public class QciChkListPocket : PocketBase
    {
        public QciChkListPocket()
        {
            InitPocket("QciChkList");
        }

        public void SaveChkListModel(CheckListModel qciChkListModel)
        {
            PocketExecute("MD.QciChkList.CheckList.Save", qciChkListModel);
        }

        public List<CheckListModel> SelectChkListModels(QciChkListModelArgs args)
        {
            return PocketQuery<CheckListModel>("MD.QciChkList.CheckList.Select",
                new
                {
                    COMP_CD = args.Select_Main_Comp_CD,
                    PLANT_CD = args.Select_Main_Plant_CD,
                    INSP_DV = args.Select_Main_Insp_Dv
                });
        }
    }
}

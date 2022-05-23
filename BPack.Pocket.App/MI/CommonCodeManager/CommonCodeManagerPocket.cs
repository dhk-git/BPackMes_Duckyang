using BPack.Common.Pocket;
using BPack.Model.App.MI.CommonCodeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MI.CommonCodeManager
{
    public class CommonCodeManagerPocket : PocketBase
    {
        public CommonCodeManagerPocket()
        {
            _queryInfoModels = GetQueryInfoModels(new QueryInfoModelArgs { Select_Group1 = "CommonCodeManager" }).ToList();
        }

        public void SaveChildeCodeModel(ChildCodeModel childCodeModel)
        {
            _queryInfoModel = _queryInfoModels.Where(a => a.QUERY_ID == "USP_MI_COMMONCODEMANAGER_CHILDCODE_CUD").SingleOrDefault();
            PocketExecute(_queryInfoModel, childCodeModel);
        }
        public void SaveChildeCodeModels(List<ChildCodeModel> childCodeModels)
        {
            _queryInfoModel = _queryInfoModels.Where(a => a.QUERY_ID == "USP_MI_COMMONCODEMANAGER_CHILDCODE_CUD").SingleOrDefault();
            PocketExecute(_queryInfoModel, childCodeModels);
        }

        public void SaveParentCodeModel(ParentCodeModel parentCodeModel)
        {
            _queryInfoModel = _queryInfoModels.Where(a => a.QUERY_ID == "USP_MI_COMMONCODEMANAGER_PARENTCODE_CUD").SingleOrDefault();
            PocketExecute(_queryInfoModel, parentCodeModel);
        }

        public List<ChildCodeModel> SelectChildeCodeModels(CommonCodeManagerModelArgs args)
        {
            _queryInfoModel = _queryInfoModels.Where(a => a.QUERY_ID == "USP_MI_COMMONCODEMANAGER_CHILDCODE_R").SingleOrDefault();
            return PocketQuery<ChildCodeModel>(_queryInfoModel, new { PCODE = args.Select_PCode, COMP_CODE = args.Select_Comp_Code });
        }

        public List<ParentCodeModel> SelectParentCodeModels(CommonCodeManagerModelArgs args)
        {
            _queryInfoModel = _queryInfoModels.Where(a => a.QUERY_ID == "USP_MI_COMMONCODEMANAGER_PARENTCODE_R").SingleOrDefault();
            return PocketQuery<ParentCodeModel>(_queryInfoModel, new { PCODE = args.Select_Main_PCode, COMP_CODE = args.Select_Comp_Code });
        }
    }
}

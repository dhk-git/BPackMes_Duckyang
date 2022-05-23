using BPack.Common.Pocket;
using BPack.Model.App.MI.CommonCodeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Pocket.App.MI.CommonCodeManager
{
    public class CommonCodeManagerPocketWebApi : PocketBase
    {
        public CommonCodeManagerPocketWebApi()
        {
            _queryInfoModels = GetQueryInfoModelsWebApi(new QueryInfoModelArgs { Select_Group1 = "CommonCodeManager" }).ToList();
        }

        public void SaveChildeCodeModel(ChildCodeModel childCodeModel)
        {
            _queryInfoModel = _queryInfoModels.Where(a => a.QUERY_ID == "USP_MI_COMMONCODEMANAGER_CHILDCODE_CUD").SingleOrDefault();
            //PocketExecute(_queryInfoModel, childCodeModel);
            PocketExecute_WebApi<ChildCodeModel>(_queryInfoModel, childCodeModel);
        }

        public void SaveParentCodeModel(ParentCodeModel parentCodeModel)
        {
            _queryInfoModel = _queryInfoModels.Where(a => a.QUERY_ID == "USP_MI_COMMONCODEMANAGER_PARENTCODE_CUD").SingleOrDefault();
            //PocketExecute(_queryInfoModel, parentCodeModel);
            PocketExecute_WebApi<ParentCodeModel>(_queryInfoModel, parentCodeModel);
        }

        public List<ChildCodeModel> SelectChildeCodeModels(CommonCodeManagerModelArgs args)
        {
            _queryInfoModel = _queryInfoModels.Where(a => a.QUERY_ID == "USP_MI_COMMONCODEMANAGER_CHILDCODE_R").SingleOrDefault();
            return Task.Run(() => PocketQuery_WebApiJsonArrayAsync<ChildCodeModel>(_queryInfoModel, new
            {
                PCODE = args.Select_PCode,
                COMP_CODE = args.Select_Comp_Code
            })).Result;
        }

        public List<ParentCodeModel> SelectParentCodeModels(CommonCodeManagerModelArgs args)
        {
            _queryInfoModel = _queryInfoModels.Where(a => a.QUERY_ID == "USP_MI_COMMONCODEMANAGER_PARENTCODE_R").SingleOrDefault();
            return Task.Run(() => PocketQuery_WebApiJsonArrayAsync<ParentCodeModel>(_queryInfoModel, new
            {
                PCODE = args.Select_Main_PCode,
                COMP_CODE = args.Select_Comp_Code
            })).Result;
        }
    }
}

using BPack.Common.Pocket;
using BPack.Report.App.DlvOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.DlvOrder.Pocket
{
    public class DlvOrderPocket : PocketBase
    {
        public DlvOrderPocket()
        {
            InitPocket("ReportQuerys");
        }

        public List<DlvOrderModel> SelectDlvOrderModels(DlvOrderModelArgs args)
        {
            var rst = PocketMultiple("Report.DlvOrder.Multi.R", new {
                DOH_NO_LIST = string.Join("^#^", args.Doh_No_List)
            });
            var dlvOrderModels = rst.Read<DlvOrderModel>().ToList();
            var dlvOrderDetailModels = rst.Read<DlvOrderDetailModel>().ToList();
            var reservedHuModels = rst.Read<ReservedHuModel>().ToList();

            foreach (var model in dlvOrderModels)
            {
                model.DlvOrderDetailModels = dlvOrderDetailModels.Where(a => a.DOH_NO == model.DOH_NO).ToList();
                foreach (var detailModel in model.DlvOrderDetailModels)
                {
                    detailModel.ReservedHuModels = reservedHuModels.Where(a => a.DOD_NO == detailModel.DOD_NO).ToList();
                }
            }
            return dlvOrderModels;
        }
    }
}

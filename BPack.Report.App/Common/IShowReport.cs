using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Report.App.Common
{
    public interface IShowReport
    {
        void ShowPreview();
        void ShowPreviewDialog();
        void Print();
        void Print(string printerName);
        DevExpress.XtraReports.UI.XtraReport GetReport();
    }
}

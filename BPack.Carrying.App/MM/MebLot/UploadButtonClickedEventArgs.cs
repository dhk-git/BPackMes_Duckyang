using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Carrying.App.MM.MebLot
{
    public class UploadButtonClickedEventArgs : EventArgs
    {
        public string UploadType { get; set; }
        public DataTable DataTable { get; set; }
    }
}

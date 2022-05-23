using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MM.HumEmptyLabel
{
    public class CreateMultiBarcodeModel : ModelBase_CommonColumns
    {
        public string DEVICE_ID { get; set; }
        public int CREATING_QTY { get; set; }
    }
}

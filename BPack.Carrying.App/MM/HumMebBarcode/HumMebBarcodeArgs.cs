using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Model.App.MM.HumMebBarcode;
using BPack.Strap.FormControls;

namespace BPack.Carrying.App.MM
{
    public class HumMebBarcodeArgs : ArgsBase
    {
        public HumMebBarcodeModelArgs HumMebBarcodeModelArgs { get; set; } = new HumMebBarcodeModelArgs();
        public NewHumMebBarcodeArgs NewhumMebBarcodeArgs { get; set; } = new NewHumMebBarcodeArgs();
    }
}

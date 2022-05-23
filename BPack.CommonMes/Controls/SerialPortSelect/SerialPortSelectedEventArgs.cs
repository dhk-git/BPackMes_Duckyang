using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Controls.SerialPortSelect
{
    public class SerialPortSelectedEventArgs : EventArgs
    {
        public SerialPortSelctorModel serialPortSelctorModel { get; set; }
    }
}

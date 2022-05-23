using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.IO.SerialComm
{
    public class SerialCommDisconnectedEventArgs : EventArgs
    {
        public string DeviceID { get; set; }
    }
}

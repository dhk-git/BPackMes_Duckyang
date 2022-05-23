using BPack.Common.Model;
using BPack.Model.Annotation.Common;
using BPack.Model.Annotation.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Controls.SerialPortSelect
{
    public class SerialPortSelctorModel : ModelBase_CommonColumns
    {
        public string ComPort { get; set; }
        public Int32 BaudRate { get; set; }
        public Int32 DataBits { get; set; }
        public StopBits StopBits { get; set; }
        public Parity Parity { get; set; }
    }
}

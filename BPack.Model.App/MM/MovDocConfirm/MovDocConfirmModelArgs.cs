using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPack.Common.Model;

namespace BPack.Model.App.MM.MovDocConfirm
{
    public class MovDocConfirmModelArgs : ModelArgsBase
    {
        public DateTime Select_Main_Start_Dt { get; set; }
        public DateTime Select_Main_End_Dt { get; set; }
        public string Select_Main_Mov_No { get; set; }
        public string Select_Mov_No { get; set; }
    }
}

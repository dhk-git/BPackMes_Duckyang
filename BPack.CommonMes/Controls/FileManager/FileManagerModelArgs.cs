using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Controls.FileManager
{
    public class FileManagerModelArgs
    {
        public string SaveSubDir { get; set; }
        public string FilterString { get; set; }
        public int FileCountLimit { get; set; }

        public string Select_Main_File_Group_ID { get; set; }
        public string Select_Main_Menu_ID { get; set; }
        public string Select_Main_Table_ID { get; set; }
        public string Select_Main_Ref_ID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Enums
{
    public static class SysCode
    {
        public static class FileNameExtension
        {
            public const string Image = "(*.png, *.bmp, *.jpg)|*.png;*.bmp;*.jpg";
        }

        public static class WorkType
        {
            public const string WORKINGDAY = "A001";    // 근무일
            public const string HOLIDAY = "A002";       // 휴일
        }

        public static class MovStatus
        {
            public const string TEMP_SAVE = "S001";
            public const string PUBLISH = "S002";
            public const string CLOSED = "S003";
        }

        public static class Separator
        {
            public const string Parameter = "^#^";
        }

    }
}

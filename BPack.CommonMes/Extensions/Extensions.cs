using BPack.CommonMes.Enums;
using BPack.Strap.EditControls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// 해당 날짜의 근무유형 Return
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string GetWorkType(this DateTime dateTime)
        {
            var workType = dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday ? SysCode.WorkType.HOLIDAY : SysCode.WorkType.WORKINGDAY;
            return workType;
        }

    }
}

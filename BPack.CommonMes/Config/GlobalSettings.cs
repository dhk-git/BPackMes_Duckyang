using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Config
{
    public static class GlobalSettings
    {
        /// <summary>
        /// 그리드 셀 OK 색상
        /// </summary>
        public static Color OkColor { get; set; } = Color.FromArgb(150, 0, 255, 0);
        /// <summary>
        /// 그리드 셀 NG 색상
        /// </summary>
        public static Color NgColor { get; set; } = Color.FromArgb(150, 255, 0, 0);
        /// <summary>
        /// 공장기준에서 사용하는 통화
        /// </summary>
        public static string CURRENCY_TYPE { get; set; }
        /// <summary>
        /// 공장기준조업시작시간
        /// </summary>
        public static TimeSpan WORK_FROM_TM { get; set; }
 
        //필요한거 추가
        public static void InitGlobalSettings()
        {
            var sp = Common.Pocket.SimplePocket.GetInstance();
            var data = sp.SelectData<dynamic>("Sys.CommonMes.GlobalSettings", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode });
            CURRENCY_TYPE = data[0].CURRENCY_TYPE;
            WORK_FROM_TM = data[0].WORK_FROM_TM;
        }

        public static DateTime GetWorkDt()
        {
            var sp = Common.Pocket.SimplePocket.GetInstance();
            var data = sp.SelectData<dynamic>("Sys.GetWorkDt", new { COMP_CD = Common.LoginInfo.UserInfo.CompCode, PLANT_CD = Common.LoginInfo.UserInfo.PlantCode }).SingleOrDefault();
            return data.WORK_DT;
        }
    }
}

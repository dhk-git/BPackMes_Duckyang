using BPack.Common.Pocket;
using BPack.Run.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Run
{
    public static class CommonLib
    {
        public static bool CheckUpdate()
        {
            SimplePocket simplePocket = SimplePocket.GetInstance();
            var currentVerDate = Convert.ToDateTime(simplePocket.SelectDataFromLocalDB<string>("SELECT CRTVER FROM COM_VER")[0].ToString());
            var updateCheckModels = simplePocket.SelectData<UpdateCheckModel>("USP_REFORM_UPDATE_CHECK_R", new { UPDATE_DTTM = currentVerDate });
            //TODO : WebApi 테스트 할것
            //var updateCheckModels = Task.Run(() => simplePocket.PocketQuery_WebApiJsonArrayAsync<UpdateCheckModel>(simplePocket.SelectQueryInfoModel("USP_REFORM_UPDATE_CHECK_R"), new { UPDATE_DTTM = currentVerDate })).Result;
            if (updateCheckModels.Count > 0)
            {
                string reformPath = Application.StartupPath + "\\reform";
                string reformFileName = "Reform.exe";
                if (System.IO.File.Exists(reformPath + "\\" + reformFileName))
                {
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo()
                    {
                        WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                        FileName = reformPath + "\\" + reformFileName,
                        WorkingDirectory = reformPath
                    };
                    System.Diagnostics.Process.Start(psi);
                    return true;
                }
                else
                {
                    MessageBox.Show("업데이트 실행파일이 없습니다.");
                    return false;
                }
            }
            return false;
        }
    }
}

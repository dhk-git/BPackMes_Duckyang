using BPack.Carrying.Core.Forms;
using BPack.Common.Config;
using BPack.Common.Model;
using BPack.Common.Pocket;
using BPack.Run.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPack.Run
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //BPack.Strap.FormControls.StrapSplashScreenManager.ShowDefaultWaitForm();
            //*********************Procject Setting - Start************************//
            AppConfig.DbConnectionMode = DbConnectionMode.DbDirect;     //DbDirect로 설정
            //AppConfig.DbConnectionMode = DbConnectionMode.NewWebApi;  //WebApi로 설정

            bool isConnectionValid = true;
            DialogResult connResult = DialogResult.OK;
            if (AppConfig.DbConnectionMode == DbConnectionMode.NewWebApi)
            {

            }
            else
            {
                //초기화문자열에 커넥션 문자열을 추가
                //덕양 미국법인 내부 접속 - 내부배포시 아래 주석해제, 클릭원스 설치폴더URL http://192.168.10.248/deploymes/
                //ConnectionInfo.AddInitConectionString("1", "DYA_Prod", "192.168.10.248", "192.168.10.248", "cVwpYg8dnfqd8/vvORCTtRXe72YLKhCS7+dvc2855vqXleK0eB0+PXi31TEfK8VssrI7S/bfm76GiYlpiJM0eQzwy7NvUHoAuU/wvH2j/ev3x1LE3aU/sKQOVzVTc6J/EfU8SXYNDbg=", "Y");
                //ConnectionInfo.AddInitConectionString("2", "DYA_Test_5", "192.168.10.248", "192.168.10.248", "cVwpYg8dnfqd8/vvORCTtRXe72YLKhCS7+dvc2855vqXleK0eB0+PXi31TEfK8VsHlLzICcL8HtdXk6fn6b0oLSYBAFRbXNSOKswKHP8TpEiRnby4XwuBukugRmjBTFBBjOohHxzP0UlxR2SSvq2OA==", "N");

                //덕양 외부 접속 - 외부배포시 아래 주석해제, 클릭원스 설치폴더URL http://199.119.240.99/deploymespublic/
                ConnectionInfo.AddInitConectionString("1", "DYA_Prod", "199.119.240.99", "199.119.240.99", "cVwpYg8dnfrhiLzFEfj17ZL+xYZDqpNBMOtMBimdt46XleK0eB0+PXi31TEfK8VssrI7S/bfm76GiYlpiJM0eQzwy7NvUHoAuU/wvH2j/ev3x1LE3aU/sKQOVzVTc6J/EfU8SXYNDbg=", "Y");

                //로컬DB의 버전확인 - 초기화 문자열에 있는 버전(일시)과 일치하지 않으면 로컬DB를 초기화 한다.--------
                var lastVer = "2022-05-18 13:00";
                ConnectionInfo.AddQueryLocalDbInitString($"UPDATE COM_VER SET CRTVER = '{lastVer}';");  //초기화 문자열에 쿼리구문을 추가함. 버전정보가 INSERT 되어 있는 상태라 UPDATE 구분을 추가하여 버전관리를 할수 있도록 함
                if (System.IO.File.Exists(ConnectionInfo.LocalDbPath)) //파일이 있을때만 체크 없으면  ConnectionInfo.initializeDBConnection() 에서 새로생성함
                {
                    SimplePocket sp = SimplePocket.GetInstance();
                    var crtVer = sp.SelectDataFromLocalDB<string>("SELECT CRTVER FROM COM_VER").SingleOrDefault();
                    //버전이 다르면 로컬DB를 초기화 한다.
                    if (!crtVer.Equals(lastVer))
                    {
                        ConnectionInfo.InitLocalSqlite();
                    }
                }
                //-----------------------------------------------------------------------------------------------------

                var initDBResult = ConnectionInfo.initializeDBConnection(); //연결정보 체크하고 Local DB가 없으면 새로 생성함
                if (initDBResult.ErrorMessage != null && initDBResult.ErrorMessage.Length > 0)
                {
                    if (MessageBox.Show("연결정보 구성을 실패했습니다. 설정을 초기화 하시겠습니까?", "Warning", buttons: MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        ConnectionInfo.InitLocalSqlite();
                        ConnectionInfo.initializeDBConnection();
                        //ConnectionInfo.initializeURLConnection();
                        isConnectionValid = false;
                    }
                }
                else
                {
                    isConnectionValid = true;
                }
            }



            try
            {
                //string configUrl = System.Configuration.ConfigurationManager.AppSettings["configUrl"].ToString();
                //Debug일때 서버 선택 기능
#if DEBUG
                if (AppConfig.DbConnectionMode == DbConnectionMode.NewWebApi)
                {
                    using (WebApiConnectionSettings connectionSettings = new WebApiConnectionSettings())
                    {
                        connResult = connectionSettings.ShowDialog();
                        if (connResult == DialogResult.OK)
                        {
                            isConnectionValid = true;
                            try
                            {
                                AppConfig.ConnectWebServer();
                            }
                            catch (Exception ex)
                            {
                                if (ex.InnerException != null)
                                {

                                    MessageBox.Show(ex.InnerException.Message);
                                }
                                else
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                isConnectionValid = false;
                            }
                        }
                        else
                        {
                            isConnectionValid = false;
                        }
                    }
                }
                else
                {
                    //SelectConnection sc = new SelectConnection(configUrl);
                    //sc.ShowDialog();

                    //신규 커넥션 선택 20201208
                    //  서버선택하는 부분 주석처리 Release로 배포하니 클릭원스가 안됨 20220510
                    
                    /* //커넥션 선택 항상뜨게
                    using (ConnectionSettings connectionSettings = new ConnectionSettings())
                    {
                        connectionSettings.ResizeForm();
                        connResult = connectionSettings.ShowDialog();

                        if (connResult == DialogResult.No)
                            isConnectionValid = false;
                        else
                            isConnectionValid = true;
                    }
                    */

                    //연결실패했을때만 뜨도록 20220517
                    using (ConnectionSettings connectionSettings = new ConnectionSettings())
                    {
                        connectionSettings.CheckConncetion(false);
                        connResult = connectionSettings._connResultModel.Result == true ? DialogResult.OK : DialogResult.No;
                        while (true)
                        {
                            if (connResult == DialogResult.No)
                            {
                                isConnectionValid = false;
                                //connectionSettings.ResizeForm();
                                connResult = connectionSettings.ShowDialog();
                                continue;
                            }
                            else
                            {
                                isConnectionValid = true;
                                break;
                            }
                        }
                    }
                }

#endif
                //Release 일때 
#if !DEBUG
                //isConnectionValid = SetAppConfig.SetConfig_WebApi(configUrl, ServerMode.Prod);
#endif

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //커넥션이 유효하지 않을때 중지
            if (isConnectionValid == false)
            {
                //BPack.Strap.FormControls.StrapSplashScreenManager.CloseDefaultWaitForm();
                MessageBox.Show("Connection invalid");
                Application.Exit();
            }
            //*********************Procject Setting - End************************//
            bool isUpdateValid = false;
            //릴리즈일때 버전체크
#if !DEBUG
            //isUpdateValid = CommonLib.CheckUpdate();
#endif
            if (connResult == DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }
            if (isUpdateValid == false && isConnectionValid == true)
            {
                DialogResult result = DialogResult.No;
                try
                {
                    using (CoreLogin login = new CoreLogin())
                    {
                        //BPack.Strap.FormControls.StrapSplashScreenManager.CloseDefaultWaitForm();
                        //TODO : 고객사에 맞게끔 수정할 것
                        login.Text = "MES - Login";
                        login.SetTitleAndDescription("MES", "Duckyang America Inc.");
                        result = login.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (result == DialogResult.OK)
                {
                    BPack.Strap.FormControls.StrapSplashScreenManager.ShowDefaultWaitForm();
                    //웹서버 인증 - 파일 업로드 20200417
                    try
                    {
                        if (AppConfig.DbConnectionMode == DbConnectionMode.NewWebApi)
                        {

                        }
                        else
                        {
                            AppConfig.ConnectWebServer();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("웹서버 연결 실패\r\n" + ex.Message + ex.InnerException?.Message);
                        Application.Exit();
                    }
                    //Local Sqlite 설정 가져오기
                    SimplePocket sp = SimplePocket.GetInstance();
                    AppConfig.CoreSettingsModel = sp.SelectDataFromLocalDB<CoreSettingsModel>("SELECT * FROM CORE_SETTINGS").SingleOrDefault();
                    //UI 모드변경
                    if (AppConfig.CoreSettingsModel.UI_MODE.Equals("Default"))
                    {
                        AppConfig.UI_Mode = UI_Mode.Default;
                    }
                    else
                    {
                        AppConfig.UI_Mode = UI_Mode.Touch;
                    }
                    CoreMdiForm main = new CoreMdiForm()
                    {
                        WindowState = FormWindowState.Maximized,
                        Text = "MES - Duckyang America Inc."
                    };
                    if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                    {
                        main.SetVersion("Version : " + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString());
                    }

                    BPack.Strap.FormControls.StrapSplashScreenManager.CloseDefaultWaitForm();
                    CommonMes.Config.GlobalSettings.InitGlobalSettings();
                    Application.Run(main);
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}

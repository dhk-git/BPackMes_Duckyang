using BPack.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.Model.App.MI.UserInfo
{
    public class UserInfoModelArgs : ModelArgsBase
    {
        public string Select_Main_User_ID { get; set; }
        public string Select_Main_User_Name { get; set; }
        public string Select_Main_Dept_Code { get; set; }
        public string Select_Main_Comp_Code { get; set; }
        public string Check_User_ID { get; set; } //로그인 체크용
        public string Check_User_PW { get; set; } //로그인 체크용
        public string Check_Login_Guid { get; set; } //로그인용 키
    }
}

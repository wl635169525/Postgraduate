using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
    public interface IUserInfo
    {
        void AddUserInfo(UserInfo userInfo);


        UserInfo Login(string UserName, string PassWord);

        UserInfo GetUsersById(int UserID);

        void UpdateUser1(UserInfo userInfo);

        UserInfo GetUsersByName(string UserName);
        UserInfo GetUserById(int? id);
        UserInfo GetUser1ByID(int UserID);
    }
}

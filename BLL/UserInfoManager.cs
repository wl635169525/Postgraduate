using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALFactory;
using IDAL;
using Models;

namespace BLL
{
   public  class UserInfoManager
    {
        IUserInfo iuserinfo = DataAccess.CreateUserInfo();
        public void AddUserInfo(UserInfo userInfo)
        {
            iuserinfo.AddUserInfo(userInfo);
        }

        public UserInfo Login(string UserName,string PassWord)
        {
            var userInfo = iuserinfo.Login(UserName, PassWord);
            return userInfo;
        }
        public UserInfo GetUsersById(int UserID)
        {
            var userInfo = iuserinfo.GetUsersById(UserID);
            return userInfo;
        }

        //public void UpdateUserInfo(UserInfo userInfo)
        //{
        //    iuserinfo.UpdateUserInfo(userInfo);
        //}

        public UserInfo GetUsersByName(string UserName)
        {
            var userInfo = iuserinfo.GetUsersByName(UserName);
            return userInfo;
        }
        public UserInfo GetUserById(int? id)
        {
            UserInfo userinfo = iuserinfo.GetUserById(id);
            return userinfo;
        }
        public UserInfo GetUser1ByID(int UserID)
        {
            return iuserinfo.GetUser1ByID(UserID);
        }
        public void UpdateUser1(UserInfo users)
        {
            iuserinfo.UpdateUser1(users);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;
using System.Data.Entity;


namespace DAL
{
    public class SqlUserInfo : IUserInfo
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();
        public void AddUserInfo(UserInfo userInfo)
        {
            db.UserInfo.Add(userInfo);
            db.SaveChanges();
          
        }

        public UserInfo Login(string UserName, string PassWord)
        {
            var userInfo = db.UserInfo.Where(u => u.UserName == UserName).
                Where(u => u.PassWord == PassWord).FirstOrDefault();
            return userInfo;
        }

        public UserInfo GetUsersById(int UserID)
        {
            UserInfo userInfo = db.UserInfo.Find(UserID);
            return userInfo;
        }

        public void UpdateUser1(UserInfo userInfo)
        {
            db.Entry(userInfo).State = EntityState.Modified;
            db.SaveChanges();
        }

        public UserInfo GetUsersByName(string UserName)
        {
            UserInfo userInfo = (from u in db.UserInfo
                                 where u.UserName == UserName
                                 select u).FirstOrDefault();
            return userInfo;
        }
        public UserInfo GetUserById(int? id)
        {
            UserInfo userinfo = db.UserInfo.Find(id);
            return userinfo;
        }
        public UserInfo GetUser1ByID(int UserID)
        {
            UserInfo user1 = (from u in db.UserInfo
                              where u.UserID == UserID
                              select u).FirstOrDefault();
            return user1;
        }
    }
}

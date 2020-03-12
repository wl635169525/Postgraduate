using BLL;
using Models;
using System;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        YanShenWangEntities db = new YanShenWangEntities();
        UserInfoManager userinfomanager = new UserInfoManager();

    
        #region 登入

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "UserName,PassWord")] string UserName, string PassWord)
        {
          
            try
            {
                var users = userinfomanager.Login(UserName, PassWord);
                if (users != null)
                {


                    Session["UserName"] = UserName;
                    System.Web.HttpContext.Current.Session["UserID"] = users.UserID; //将用户名放入session中
                   

                    return Content("<script>;alert('登录成功!返回首页!');window.location.href='/Index/Index'</script>");

                }
                else
                {
                    return Content("<script>;alert('该账号不存在!');history.go(-1)</script>");

                }
            }

            catch (Exception ex)
            {
               
                return Content(ex.Message);
            }

        }

        #endregion

        #region 注册

      
         public  ActionResult ZhuChe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ZhuChe([Bind(Include = "UserName,PassWord,Email")] UserInfo userInfo)
        {
          
            if (ModelState.IsValid)
            {

                userinfomanager.AddUserInfo(userInfo);
                return Content("<script>;alert('注册成功！');window.history.go(-2); window.location.reload(); </script>");
            }
            else
            {
                return Content("<script>;alert('注册失败！');history.go(-1)</script>");

            }

        }

        #endregion
    }
}






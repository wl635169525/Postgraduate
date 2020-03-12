using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using System.Data.Entity.Validation;

namespace UI.Controllers
{
    public class UserCenterController : Controller
    {
        YanShenWangEntities db = new YanShenWangEntities();
        UserInfoManager userinfoManager = new UserInfoManager();
        ShoppingCartManager shoppingcartManager = new ShoppingCartManager();
        // GET: UserCenter
        //展示个人信息
        public ActionResult UserCenter(int userid)
        {
            Session["userid"] = userid;
            int User_id = Convert.ToInt32(Session["userid"]);
            
            var userinfo = userinfoManager.GetUserById(User_id);           
           
            return View(userinfo);
        }
        #region 修改个人信息        
        public ActionResult UserCenter1(UserInfo user)
        {           
            UserInfo u = userinfoManager.GetUser1ByID(int.Parse(Session["UserID"].ToString()));
            //HttpPostedFileBase photo = Request.Files["Photo"];
            try
            {
                //if (photo.FileName != "")
                //{
                //    string filePath = photo.FileName;
                //    string filename = DateTime.Now.ToString("yyyyMMddHHmmssfffffff") +
                //                      filePath.Substring(filePath.LastIndexOf("\\") + 1);
                //    string serverpath = Server.MapPath(@"\images\Userphoto\") + filename;
                //    string relativepath = @"/images/Userphoto/" + filename;
                //    photo.SaveAs(serverpath);
                //    user.Photo = relativepath;
                //}
                //else
                //{
                //    user.Photo = db.UserInfo.Find(user.UserID).Photo;
                //}
                //if (ModelState.IsValid)
                //{
                    u.Sex = user.Sex;
                    u.UserName = user.UserName;
                    u.Email = user.Email;
                    u.Birth = user.Birth;
                    u.Phone = user.Phone;


                    userinfoManager.UpdateUser1(u);
                    
                //}
                //else
                //{
                //    return Content("<script>;alert('修改失败！');window.history.go(-1);window.location.reload();</script>");
                //}
            }
            catch (DbEntityValidationException ex)
            {
                string error = ex.Message;

            }

            return View("UserCenter", u);
        }
        #endregion

    }
    

}
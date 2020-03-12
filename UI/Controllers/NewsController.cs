using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using UI.Models;
using BLL;

namespace UI.Controllers
{
    public class NewsController : Controller
    {
        YanShenWangEntities db = new YanShenWangEntities();
        NewsManager newsmanager = new NewsManager();
        // GET: News
        public ActionResult NewsIndex()
        {
            var news1 = newsmanager.GetNews();
            return View(news1);
        }

        public ActionResult NewsDetail(int newsid)
        {
            Session["newsid"] = newsid;
            int NewsID = Convert.ToInt32(Session["newsid"]);
            var news2 = newsmanager.GetNewsById(newsid);
            if (news2 == null)
            {
                return HttpNotFound();
            }
            return View(news2);
        }
    }
}
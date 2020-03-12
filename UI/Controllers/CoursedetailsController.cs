using BLL;
using Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class CoursedetailsController : Controller
    {
        // GET: Coursedetails
        YanShenWangEntities db = new YanShenWangEntities();
        CourseManager courseManager = new CourseManager();
        CommentCourseManager commentcourseManager = new CommentCourseManager();
        ReplyCommentCourseManager coursereplyManager = new ReplyCommentCourseManager();

        public ActionResult Coursedetails()
        {
            var coursexq = courseManager.GetCoursebyTopTime(4);
            Models.CourseDetailsViewModels Vm = new Models.CourseDetailsViewModels();
            Vm.CourseXQ = coursexq;
            return View(Vm);
        }
        public ActionResult Coursedetails1(int courseid)
        {
            Session["courseid"] = courseid;
            int Course_id = Convert.ToInt32(Session["courseid"]);
            Models.CourseDetailsViewModels Vm = new Models.CourseDetailsViewModels();
            var coursexq = courseManager.GetCoursebyTopTime(4);   
            var  course= courseManager.GetCourseById(Course_id);
            var coursecomment = commentcourseManager.GetCourseCommentById(courseid);

            if (course == null)
            {
                return HttpNotFound();
            }
            
            Vm.GetCourseById = course;
            Vm.CourseXQ = coursexq;
            Vm.CourseComment = coursecomment;

            return View("Coursedetails" ,Vm);
        }

     
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Coursedetails(CommentCourse coursecomment)
        {
            int CourseID = Convert.ToInt32(Session["courseid"]);
            int UserID = Convert.ToInt32(Session["UserID"]);
            coursecomment.CCContent = Request.Form["CourseCommentContent"];


            if (coursecomment.CCContent == "")
            {
                return Content("<script>;alert('评论内容不能为空');window.open('" + Url.Action("Coursedetails1", "Coursedetails", new { courseid = CourseID }) + "', '_self' </script>");
            }
            else
            {
                coursecomment.UserID = UserID;
                coursecomment.CourseID = CourseID;
                coursecomment.CCtime = DateTime.Now;               
                commentcourseManager.InsertCourseComment(coursecomment);
                return RedirectToAction("Coursedetails1", "Coursedetails", new { courseid = CourseID });
            }
       
            
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ReplyCourse(ReplyCommentCourse coursereply,int CourseCommentID)
        {
            int CourseID = Convert.ToInt32(Session["courseid"]);

            coursereply.RCCContent = Request.Form["CourseReplyContent"];        
            if(coursereply.RCCContent == "")
            {
                return  Content("<script>;alert('回复内容不能为空');window.open('" + Url.Action("Coursedetails1", "Coursedetails", new { courseid = CourseID }) + "', '_self' </script>");
            }
            else
            {
                coursereply.UserID = Convert.ToInt32(Session["UserID"]);
                coursereply.CCourseID = CourseCommentID;
                coursereply.RCCTime = DateTime.Now;
                coursereplyManager.InsertCourseReply(coursereply);
                return RedirectToAction("Coursedetails1", "Coursedetails", new { courseid = CourseID });
            }
        }
    }
}
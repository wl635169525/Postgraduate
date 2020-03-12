using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using PagedList;

namespace UI.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        YanShenWangEntities db = new YanShenWangEntities();
        CourseManager courseManager = new CourseManager();      
        public ActionResult Course()
        {
            var courseEnglish = courseManager.GetCoursebyTopEnglish(6);
            var courseMath = courseManager.GetCoursebyTopMath(6);
            var coursePolitic = courseManager.GetCoursebyTopPolitic(6);
            var courseOther = courseManager.GetCoursebyTopOther(6);          
            Models.CoursesViewModels Vm = new Models.CoursesViewModels();
            Vm.CourseEnglish = courseEnglish;
            Vm.CourseMath = courseMath;
            Vm.CoursePolitic = coursePolitic;
            Vm.CourseOther = courseOther;
            return View(Vm);
        }

        public ActionResult Ueditor()
        {
            return View();
        }

        //分页
        //public ActionResult CourseFenYe(String genreInfoFrom, string currentFilter, int? page)
        //{

        //    var Course = courseManager.GetCourse();


        //    if (genreInfoFrom != null)
        //    {
        //        page = 1;
        //    }
        //    else
        //    {
        //        genreInfoFrom = currentFilter;
        //    }

        //    ViewBag.CurrentFilter = genreInfoFrom;




        //    if (!String.IsNullOrEmpty(genreInfoFrom))
        //    {

        //        course = course.Where(x => x.Special.SpecialName == genreInfoFrom);

        //    }



        //    int pageSize = 18;
        //    int pageNumber = (page ?? 1);

        //    return PartialView(course.ToPagedList(pageNumber, pageSize));
        //}
    }
}
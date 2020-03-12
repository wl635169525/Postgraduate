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
   public  class SqlCourse:ICourse
    {
        YanShenWangEntities db = DbContextFactory.CreateDbContext();

        //首页绑定
        public IQueryable<Course> GetCoursebyTop(int top)
        {
            var course = from kechen in db.Course
                       orderby kechen.CourseID descending
                       select kechen;
            return course.Take(top);
        }
        //课程中心
        public IQueryable<Course> GetCoursebyTopEnglish(int top)
        {
            var course = db.Course.Where(x => x.CourseSort == "English")
                     .OrderBy(x => x.CourseID)
                     .Take(6);
            return course;           
        }
        public IQueryable<Course> GetCoursebyTopMath(int top)
        {
            var course = db.Course.Where(x => x.CourseSort == "Math")
                .OrderBy(x => x.CourseID)
                .Take(6);
            return course;
           
        }
        public IQueryable<Course>GetCoursebyTopPolitic(int top)
        {
            var course = db.Course.Where(x=>x.CourseSort == "Politic")
                .OrderBy(x=>x.CourseID)
                .Take(6);
            return course;
        }
        public IQueryable<Course> GetCoursebyTopOther(int top)
        {
            var course = db.Course.Where(x => x.CourseSort == "Other")
                .OrderBy(x => x.CourseID)
                .Take(6);
            return course;
        }
        public IQueryable<Course> GetCoursebyTopTime(int top)
        {
            var course = from kechen in db.Course
                         orderby kechen.CourseTime descending
                         select kechen;
            return course.Take(top);
        }

        public Course GetCourseById(int? id)
        {
            Course course = db.Course.Find(id);
            return course;
        }
    }
}

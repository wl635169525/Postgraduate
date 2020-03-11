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
   public  class CourseManager
    {
        ICourse icourse = DataAccess.CreateCourse();

        public IQueryable<Course> GetCoursesbyTop(int top)
        {
            var course = icourse.GetCoursebyTop(top);
            return course;
        }
        public IQueryable<Course> GetCoursebyTopEnglish(int top)
        {
            var course = icourse.GetCoursebyTopEnglish(top);
            return course;
        }
        public IQueryable<Course> GetCoursebyTopMath(int top)
        {
            var course = icourse.GetCoursebyTopMath(top);
            return course;             
        }
        public IQueryable<Course> GetCoursebyTopPolitic(int top)
        { 
            var course = icourse.GetCoursebyTopPolitic(top);
            return course;
        }
        public IQueryable<Course> GetCoursebyTopOther(int top)
        {
            var course = icourse.GetCoursebyTopOther(top);
            return course;
        }
        public IQueryable<Course> GetCoursebyTopTime(int top)
        {
            var course = icourse.GetCoursebyTopTime(top);
            return course;
        }
        public Course GetCourseById(int? id)
        {
            Course course = icourse.GetCourseById(id);
            return course;
        }
    }
}

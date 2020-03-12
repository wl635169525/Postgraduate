using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
   public  interface ICourse
    {
        //首页
        IQueryable<Course> GetCoursebyTop(int top);
        //课程中心
        IQueryable<Course> GetCoursebyTopEnglish(int top);
        IQueryable<Course> GetCoursebyTopMath(int top);
        IQueryable<Course> GetCoursebyTopPolitic(int top);
        IQueryable<Course> GetCoursebyTopOther(int top);
        IQueryable<Course> GetCoursebyTopTime(int top);
        Course GetCourseById(int? id);
    }
}

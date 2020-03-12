using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using PagedList;

namespace UI.Models
{
    public class CourseDetailsViewModels
    {
        public IEnumerable<Course> CourseXQ { get; set; }
        public Course GetCourseById { get; set; }

        public IEnumerable<Course_pl>  CourseComment { get; set; }

       public IEnumerable<Course_hf> CourseReply { get; set; }
    }
}
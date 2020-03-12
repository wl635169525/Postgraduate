using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace UI.Models
{
    public class CoursesViewModels
    {
        public IEnumerable<Course>CourseEnglish{ get; set; }
        public IEnumerable<Course>CourseMath { get; set; }
        public IEnumerable<Course> CoursePolitic { get; set; }
        public IEnumerable<Course> CourseOther { get; set; }
      
    }
}
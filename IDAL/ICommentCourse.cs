using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IDAL
{
   public  interface ICommentCourse
    {
        IEnumerable<Course_pl> GetCourseCommentById(int id);

        void InsertCourseComment(CommentCourse commentcourse);

    }
}

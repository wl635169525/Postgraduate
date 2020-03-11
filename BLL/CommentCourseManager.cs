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
   public  class CommentCourseManager
    {
        ICommentCourse icommentcourse = DataAccess.CreateCommentCourse();

        public IEnumerable<Course_pl> GetCourseCommentById(int id)
        {
            var Course_pl = icommentcourse.GetCourseCommentById(id);
            return Course_pl;
        }
        public void InsertCourseComment(CommentCourse commentcourse)
        {
            icommentcourse.InsertCourseComment(commentcourse);
        }
    }
}
